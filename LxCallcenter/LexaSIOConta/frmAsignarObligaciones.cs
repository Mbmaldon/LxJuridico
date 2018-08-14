using LogicaCC.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using LogicaCC;

namespace LxCallcenter.LexaSIOConta
{
    public partial class frmAsignarObligaciones : Form
    {
        FPrincipal frmPrincipal;
        UsuarioData AUsuario;
        public static int iIdCliente;
        LogicaCC.LexaSIOContaLogica.Cliente _Cliente;

        public frmAsignarObligaciones()
        {
            InitializeComponent();
            InicializarControles();
            frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;
            AUsuario     = UsuarioData.Instancia;
        }

        #region FUNCIONES USADAS POR CONTROLES
        private void MostrarForm(Form Formulario)
        {
            FPrincipal _FPrincipal = Application.OpenForms.OfType<FPrincipal>().Where(pre => pre.Name == "FPrincipal").SingleOrDefault<FPrincipal>();
            CerrarFormularios();
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            _FPrincipal.panelContenedor.Controls.Add(Formulario);
            _FPrincipal.panelContenedor.Tag = Formulario;
            Formulario.Show();
        }

        private void CerrarFormularios()
        {
            FPrincipal _FPrincipal = Application.OpenForms.OfType<FPrincipal>().Where(pre => pre.Name == "FPrincipal").SingleOrDefault<FPrincipal>();
            Form[] sAforms = new Form[10];
            int iContador = 0;
            // Se genera el listado de los formularios abiertos
            foreach (Form x in Application.OpenForms)
            {
                string sForm = x.Name.ToString();

                if (!sForm.Equals("Login") && !sForm.Equals("FPrincipal") && !sForm.Equals("EnviarMensajes") && !sForm.Equals("frmDirectorio") && !sForm.Equals("frmDirectorio") && !sForm.Equals("frmTelefono") && !sForm.Equals("frmTelefonoConfigurar"))
                {
                    _FPrincipal.panelContenedor.Controls.Remove(x);
                    sAforms[iContador] = x;
                    iContador++;
                }
            }
            // Cierra los formularios
            for (int i = 0; i < 10; i++)
                if (sAforms[i] != null)
                    sAforms[i].Close();
        }
        #endregion

        #region EVENTOS
        private void lnkBuscar_Click(object sender, EventArgs e)
        {
            if (BuscarCliente("") == 1)
                SystemSounds.Beep.Play();
        }

        private void txtNoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)13)
                lnkBuscar_Click(sender, e);
        }

        private void btnAsignarObligaciones_Click(object sender, EventArgs e)
        {
			ptbLoader.Visible = true;
			
			// VALIDA SI EL CLIENTE YA TIENE UN TIPO DE PERSONA ASIGNADO
			LogicaCC.LexaSIOContaLogica.TipoPersona tipoPersona = new LogicaCC.LexaSIOContaLogica.TipoPersona();
			tipoPersona = new LogicaCC.LexaSIOContaLogica.TipoPersona().validarPersona(iIdCliente);

			// AGREGAMOS CLIENTE A LA BD BD DBLEXACONTA
			new LogicaCC.LexaSIOContaLogica.Cliente().bInsertarCliente(new LogicaCC.LexaSIOContaLogica.Cliente()
			{
			    iIdCliente            = iIdCliente,
			    iIdUsuarioCreacion    = _Cliente.iIdContador,
			    sCliente              = _Cliente.sCliente,
			    sNombre               = txbNombre.Text,
			    sAPaterno             = txbAPaterno.Text,
			    sAMaterno             = txbAMaterno.Text,
			    sRfc                  = txbRfc.Text,
			    sCorreoElectronico    = txbCorreoCliente.Text,
			    sTelefono             = txbTelefono.Text,
			    sDireccion            = _Cliente.sDireccion,
			    sMunicipio            = _Cliente.sMunicipio,
			    sCodigoPostal         = _Cliente.sCodigoPostal,
			    sExtension            = txbExtension.Text,
			    sNumeroMovil          = txbMovil.Text
			});


            if (ExisteExpediente(_Cliente.sCliente))
            {
                frmTipoPersona _frmTipoPersona = new frmTipoPersona();
                frmTipoPersona TipoPersona = _frmTipoPersona ?? new frmTipoPersona();
                MostrarForm(TipoPersona);
                frmPrincipal.btnCEditarCliente.Enabled = false;
            }
            else
            {
                txtNoCliente.Enabled           = false;
                lnkBuscar.Enabled              = false;
                btnAsignarObligaciones.Enabled = false;
                btnCancelar.Enabled            = false;
                lblProgress.Visible            = true;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EstadoControles(false);
            LimpiarControles();
            txtNoCliente.Clear();
            ckbActivo.Checked = false;
        }

		private void backgroundWorker1_DoWork(Object sender, DoWorkEventArgs e)
		{
			Thread.Sleep(4000);
			CrearExpedienteLinea(_Cliente.sCliente);
		}

		private void backgroundWorker1_RunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
		{
			ptbLoader.Visible				= false;
            frmTipoPersona _frmTipoPersona  = new frmTipoPersona();
            frmTipoPersona TipoPersona      = _frmTipoPersona ?? new frmTipoPersona();
            MostrarForm(TipoPersona);
            frmPrincipal.btnCEditarCliente.Enabled = false;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblProgress.Text = e.UserState.ToString();
        }
        #endregion

        #region FUNCIONES
        /// <summary>
        /// Inicializa la información de los controles
        /// </summary>
        private void InicializarControles()
        {
            List<UsuarioInfo> AListaUsuarios = null;
            UsuarioLista AUsuarios = new UsuarioLista();

            //Lista de contadores
            AListaUsuarios = AUsuarios.ObtenerLista("6");

            if (AListaUsuarios != null)
            {
                cbContaAsig.DataSource    = AListaUsuarios;
                cbContaAsig.DisplayMember = "sNombre";
                cbContaAsig.ValueMember   = "sIdusuario";
            }
        }

        /// <summary>
        /// FUNCION QUE BUSCA UN CLIENTE
        /// </summary>
        /// <param name="sCliente">Número de cliente</param>
        /// <returns></returns>
        private int BuscarCliente(string sCliente)
        {
            int iResultado = 0;

            EstadoControles(false);

            if (sCliente.Equals(""))
                _Cliente = new LogicaCC.LexaSIOContaLogica.Cliente().InfoClienteContador(txtNoCliente.Text, int.Parse(AUsuario.sIdusuario));
            else
                _Cliente = new LogicaCC.LexaSIOContaLogica.Cliente().InfoClienteContador(sCliente, int.Parse(AUsuario.sIdusuario));

            LimpiarControles();

            if (_Cliente != null)
            {
                if (_Cliente.iIdRegimen == 2)
                {
                    materialLabel5.Text      = "Razón o denominación social";
                    materialLabel6.Visible   = false;
                    materialLabel7.Visible   = false;
                    txbAPaterno.Visible      = false;
                    txbAMaterno.Visible      = false;
                    materialLabel17.Location = materialLabel4.Location;
                    cbContaAsig.Location     = txbCurp.Location;
                    materialLabel4.Visible   = false;
                    txbCurp.Visible          = false;
                    txbNombre.Size = new Size(709, 23);
                    ovalPictureBox1.Image = Properties.Resources.skyscrapers_96px;
                }
                else
                {
                    materialLabel5.Text      = "Nombre";
                    materialLabel6.Visible   = true;
                    materialLabel7.Visible   = true;
                    txbAPaterno.Visible      = true;
                    txbAMaterno.Visible      = true;
                    materialLabel17.Location = new Point(783, 260);
                    cbContaAsig.Location     = new Point(787, 280);
                    materialLabel4.Visible   = true;
                    txbCurp.Visible          = true;
                    txbNombre.Size = new Size(218, 23);
                    ovalPictureBox1.Image = Properties.Resources.circled_user_male_skin_type_1_2_96px;
                }


                txbRfc.Text               = _Cliente.sRfc;
                txbMovil.Text             = _Cliente.sNumeroMovil;
                txbNombre.Text            = _Cliente.sNombre;
                txbTelefono.Text          = _Cliente.sTelefono;
                txbAPaterno.Text          = _Cliente.sAPaterno;
                txbAMaterno.Text          = _Cliente.sAMaterno;
                txbExtension.Text         = _Cliente.sExtension;
                txbCorreoCliente.Text     = _Cliente.sCorreoElectronico;
                cbContaAsig.SelectedValue = _Cliente.iIdContador.ToString();
                txbCurp.Text              = _Cliente.sCurp;

                if (_Cliente.sActivo.Equals("True"))
                    ckbActivo.Checked = true;

                iIdCliente = _Cliente.iIdCliente;
                btnAsignarObligaciones.Enabled = true;
            }
            else
            {
                iResultado = 1;
                lblMensajeBusqueda.Text = "* Cliente no encontrado.";
            }
            return iResultado;
        }

        /// <summary>
        /// Cambia el estado de los controles
        /// </summary>
        /// <param name="bEstado">False o true</param>
        private void EstadoControles(bool bEstado)
        {
            ckbActivo.Enabled              = bEstado;
            btnAsignarObligaciones.Enabled = bEstado;
            cbContaAsig.Enabled            = bEstado;
        }

        /// <summary>
        /// Limpieza de controles
        /// </summary>
        private void LimpiarControles()
        {
            // Informacion Cliente
            foreach (Control x in panel3.Controls)
                if (x is MaterialSkin.Controls.MaterialSingleLineTextField)
                    x.Text = "";

            // Pone combobox en estado inicial.
            cbContaAsig.SelectedIndex = 0;
            // Limpia la leyenda abajo del texbox de busqueda.
            lblMensajeBusqueda.Text = "";
        }

        /// <summary>
        /// Valida si existe el expediente el linea de un cliente
        /// </summary>
        /// <param name="sCliente">Número de cliente</param>
        /// <returns></returns>
        public bool ExisteExpediente(string sCliente)
        {
            string FullPath = string.Format("{0}/{1}/{2}/", FTPCredentials.Path, ConnectionString.FolderConnection, sCliente);

            if (FTPServer.DirectoryExists(string.Format("{0}/{1}/", FTPCredentials.Path, ConnectionString.FolderConnection), FTPCredentials.User, FTPCredentials.Password, sCliente)
             && FTPServer.CheckIfFileExistsOnServer(FullPath, FTPCredentials.User, FTPCredentials.Password, "Log.txt")
             && FTPServer.Count(string.Format("{0}/{1}/", FTPCredentials.Path, ConnectionString.FolderConnection), FTPCredentials.User, FTPCredentials.Password, sCliente).Count > 13)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Crea un directorio a partir de una ruta, si este existe, se omitira la creación
        /// </summary>
        /// <param name="sDirectorio">Ruta a crear</param>
        public void CreateDirectoryFTP(string sDirectorio)
        {
            FTPServer.CreateDirectory(FTPCredentials.Path, FTPCredentials.User, FTPCredentials.Password, sDirectorio);
        }

        /// <summary>
        /// Crea un directorio en base a un ruta, creando dos carpetas por ejercicios
        /// y dentro de estas, los meses correspondientes.
        /// </summary>
        /// <param name="sDirectorio">Ruta base</param>
        public void CreateDirectoryByDateFTP(string sDirectorio)
        {
            string[] sMeses = System.Globalization.DateTimeFormatInfo.CurrentInfo.MonthNames;
            int i = 0;

            // Creamos el ejercicio anterior al que esta en curso
            CreateDirectoryFTP(sDirectorio + @"\" + (DateTime.Now.Year + 1));

            //Creamos los meses correspodientes al ejercicio anterior
            foreach (string mes in sMeses.Where(m => m.Length > 0))
            {
                i++;
                CreateDirectoryFTP(sDirectorio + @"\" + (DateTime.Now.Year + 1) + @"\" + string.Format("{0} {1}", i.ToString("00"), char.ToUpper(mes[0]) + mes.Substring(1)));
            }

            i = 0;
            // Creamos el ejercicio en curso
            CreateDirectoryFTP(sDirectorio + @"\" + (DateTime.Now.Year));

            //Creamos los meses correspodientes al ejercicio en curso
            foreach (string mes in sMeses.Where(m => m.Length > 0))
            {
                i++;
                CreateDirectoryFTP(sDirectorio + @"\" + (DateTime.Now.Year) + @"\" + string.Format("{0} {1}", i.ToString("00"), char.ToUpper(mes[0]) + mes.Substring(1)));
            }
        }

        /// <summary>
        /// Función para crear los directorios del expediente en línea.
        /// </summary>
        /// <param name="sCliente">Número de cliente</param>
        public void CrearExpedienteLinea(string sCliente)
        {
            // 01. General
            backgroundWorker1.ReportProgress(0, "01. General");
            CreateDirectoryFTP(string.Format(@"{0}\01. General\CIF", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\01. General\e-firma y contraseñas", sCliente));
            // 02. Movimientos al RFC
            backgroundWorker1.ReportProgress(0, "02. Movimientos al RFC");
            CreateDirectoryFTP(string.Format(@"{0}\02. Movimientos al RFC\Actualización aumento-disminución de obligaciones", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\02. Movimientos al RFC\Apertura de establecimiento o sucursal", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\02. Movimientos al RFC\Cambio de Domicilio", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\02. Movimientos al RFC\Cierre de establecimiento o sucursal", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\02. Movimientos al RFC\Inscripción al RFC", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\02. Movimientos al RFC\Reanudación de actividades", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\02. Movimientos al RFC\Suspensión de actividades", sCliente));
            //03. IMSS-INFONAVIT
            backgroundWorker1.ReportProgress(0, "03. IMSS-INFONAVIT");
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Avisos de INFONAVIT\Avisos de descuentos", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Avisos de INFONAVIT\Avisos de modificación de factor", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Avisos de INFONAVIT\Avisos de suspensión de credito", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Avisos trimestrales", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Cedulas SUA\Archivos de pago (SUA)", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Cedulas SUA\Bimestrales", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Cedulas SUA\Mensuales", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Cedulas SUA\Reporte de incidencias", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Cedulas SUA\Resumen de liquidación", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Certificado. Req, Key, usuario y contraseña", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\EMA-EBA", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Incapacidades medicas\Enfermedad general", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Incapacidades medicas\Maternidad", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Incapacidades medicas\Riesgo de trabajo", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Movimientos IDSE", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Opinión de cumplimiento\IMSS", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Opinión de cumplimiento\INFONAVIT", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Respaldos SUA", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\SIPARE y pagos", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\ST-2", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\ST-7", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\03. IMSS-INFONAVIT\Tarjetas patronales", sCliente));
            // 04. Declaraciones, acuses y pagos de impuestos federales
            backgroundWorker1.ReportProgress(0, "04. Declaraciones, acuses y pagos de impuestos federales");
            CreateDirectoryByDateFTP(string.Format(@"{0}\04. Declaraciones, acuses y pagos de impuestos federales\Constancias de rentención (ISR e IVA)", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\04. Declaraciones, acuses y pagos de impuestos federales\Impuesto especial sobre producción y servicios", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\04. Declaraciones, acuses y pagos de impuestos federales\Impuesto sobre el Valor Agregado", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\04. Declaraciones, acuses y pagos de impuestos federales\Impuesto Sobre la Renta", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\04. Declaraciones, acuses y pagos de impuestos federales\Pagos", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\04. Declaraciones, acuses y pagos de impuestos federales\Papeles de Trabajo\Impuestos federales", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\04. Declaraciones, acuses y pagos de impuestos federales\Retenciones de ISR a Terceros", sCliente));
            // 05. DIOT
            backgroundWorker1.ReportProgress(0, "05. DIOT");
            CreateDirectoryByDateFTP(string.Format(@"{0}\05. DIOT\Declaración, acuses de aceptación y envío", sCliente));
            // 06. Impuesto Sobre Nómina
            backgroundWorker1.ReportProgress(0, "06. Impuesto Sobre Nómina");
            CreateDirectoryFTP(string.Format(@"{0}\06. Impuesto Sobre Nómina\Contraseña", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\06. Impuesto Sobre Nómina\Declaraciones y comprobantes de pagos", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\06. Impuesto Sobre Nómina\Empadronamientos o altas", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\06. Impuesto Sobre Nómina\Papeles de trabajo", sCliente));
            // 07. Facturas emitidas
            backgroundWorker1.ReportProgress(0, "07. Facturas emitidas");
            CreateDirectoryByDateFTP(string.Format(@"{0}\07. Facturas emitidas", sCliente));
            // 08. Facturas recibidas
            backgroundWorker1.ReportProgress(0, "08. Facturas recibidas");
            CreateDirectoryByDateFTP(string.Format(@"{0}\08. Facturas recibidas", sCliente));
            // 09. Registros contables y Estados financieros
            backgroundWorker1.ReportProgress(0, "09. Registros contables y Estados financieros");
            CreateDirectoryByDateFTP(string.Format(@"{0}\09. Registros contables y Estados financieros\Auxiliares", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\09. Registros contables y Estados financieros\Balanzas de comprobación", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\09. Registros contables y Estados financieros\Estados Financieros", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\09. Registros contables y Estados financieros\Libro diario y libro mayor", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\09. Registros contables y Estados financieros\Polizas contables\Cheque", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\09. Registros contables y Estados financieros\Polizas contables\Diario", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\09. Registros contables y Estados financieros\Polizas contables\Egresos", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\09. Registros contables y Estados financieros\Polizas contables\Ingresos", sCliente));
            // 10. Contabilidad electrónica
            backgroundWorker1.ReportProgress(0, "10. Contabilidad electrónica");
            CreateDirectoryByDateFTP(string.Format(@"{0}\10. Contabilidad electrónica\Acuses de aceptación y envío", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\10. Contabilidad electrónica\Balanzas de comprobación", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\10. Contabilidad electrónica\Catalogo de cuentas", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\10. Contabilidad electrónica\Pólizas contables", sCliente));
            // 11. Bancos
            backgroundWorker1.ReportProgress(0, "11. Bancos");
            CreateDirectoryByDateFTP(string.Format(@"{0}\11. Bancos\Conciliaciones Bancarias", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\11. Bancos\Contratos Bancarios", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\11. Bancos\Estados de Cuenta", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\11. Bancos\Pólizas Cheque", sCliente));
            // 12. Facultades de Comprobación
            backgroundWorker1.ReportProgress(0, "12. Facultades de Comprobación");
            CreateDirectoryFTP(string.Format(@"{0}\12. Facultades de Comprobación\Invitaciones", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\12. Facultades de Comprobación\Procedimiento administrativo de ejecución (PAE)", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\12. Facultades de Comprobación\Requerimientos", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\12. Facultades de Comprobación\Revisión de gabinete", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\12. Facultades de Comprobación\Revisiones electrónicas", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\12. Facultades de Comprobación\Verificación de comprobantes digitales", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\12. Facultades de Comprobación\Visitas domiciliarias", sCliente));
            // 13. Relaciones Laborales
            backgroundWorker1.ReportProgress(0, "13. Relaciones Laborales");
            CreateDirectoryFTP(string.Format(@"{0}\13. Relaciones Laborales\Expediente del Trabajador", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\13. Relaciones Laborales\Otros descuentos", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\13. Relaciones Laborales\Pensiones Alimenticias", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\13. Relaciones Laborales\Prestamos Empleados", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\13. Relaciones Laborales\Recibos de Nómina\Quincenal", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\13. Relaciones Laborales\Recibos de Nómina\Semanal", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\13. Relaciones Laborales\Vales de Despensa", sCliente));
            // 14. FONACOT
            backgroundWorker1.ReportProgress(0, "14. FONACOT");
            CreateDirectoryFTP(string.Format(@"{0}\14. FONACOT\Alta", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\14. FONACOT\Cedulas mensuales", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\14. FONACOT\Comprobantes de pago", sCliente));
            CreateDirectoryByDateFTP(string.Format(@"{0}\14. FONACOT\Descuento FONACOT", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\14. FONACOT\Usuario y contraseña", sCliente));
            // 15. Nómina
            backgroundWorker1.ReportProgress(0, "15. Nómina");
            CreateDirectoryFTP(string.Format(@"{0}\15. Nómina\Comprobante de pago de nómina", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\15. Nómina\Finiquitos", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\15. Nómina\Nóminas", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\15. Nómina\Recibos de nómina", sCliente));   
            // 16. Opinión de cumplimiento
            backgroundWorker1.ReportProgress(0, "16. Opinion de cumplimiento");
            CreateDirectoryByDateFTP(string.Format(@"{0}\16. Opinion de cumplimiento", sCliente));
            // 17. Inventarios
            backgroundWorker1.ReportProgress(0, "17. Inventarios");
            CreateDirectoryFTP(string.Format(@"{0}\17. Inventarios", sCliente));
            // 18. Propiedades, planta y equipo
            backgroundWorker1.ReportProgress(0, "18. Propiedades, planta y equipo");
            CreateDirectoryFTP(string.Format(@"{0}\18. Propiedades, planta y equipo", sCliente));
            // 19. Activos Intangibles
            backgroundWorker1.ReportProgress(0, "19. Activos Intangibles");
            CreateDirectoryFTP(string.Format(@"{0}\19. Activos Intangibles", sCliente));
            // 20. Inversiones en instrumentos financieros
            backgroundWorker1.ReportProgress(0, "20. Inversiones en instrumentos financieros");
            CreateDirectoryFTP(string.Format(@"{0}\20. Inversiones en instrumentos financieros", sCliente));
            // 21. Partes relacionadas
            backgroundWorker1.ReportProgress(0, "21. Partes relacionadas");
            CreateDirectoryFTP(string.Format(@"{0}\21. Partes relacionadas\Estudios de precios de transferencia", sCliente));
            // 22. Actas de asamblea, libros y registros sociales
            backgroundWorker1.ReportProgress(0, "22. Actas de asamblea, libros y registros sociales");
            CreateDirectoryByDateFTP(string.Format(@"{0}\22. Actas de asamblea, libros y registros sociales", sCliente));
            // 23. Comercio exterior y aduana
            backgroundWorker1.ReportProgress(0, "23. Comercio exterior y aduana");
            CreateDirectoryFTP(string.Format(@"{0}\23. Comercio exterior y aduana", sCliente));
            if (_Cliente.iIdRegimen == 1)
            {
                // 24. Deducciones personales (Solo personas físicas)
                backgroundWorker1.ReportProgress(0, "24. Deducciones personales");
                CreateDirectoryByDateFTP(string.Format(@"{0}\24. Deducciones personales", sCliente));
            }
            // 25. Avisos antilavado
            backgroundWorker1.ReportProgress(0, string.Format("{0}. Avisos antilavado", _Cliente.iIdRegimen == 1 ? "25" : "24"));
            CreateDirectoryByDateFTP(string.Format(@"{0}\{1}. Avisos antilavado", sCliente, _Cliente.iIdRegimen == 1 ? "25" : "24"));
            // 26. Otros
            backgroundWorker1.ReportProgress(0, string.Format("{0}. Otros", _Cliente.iIdRegimen == 1 ? "26" : "25"));
            CreateDirectoryFTP(string.Format(@"{0}\{1}. Otros", sCliente, _Cliente.iIdRegimen == 1 ? "26" : "25"));

            // CARPETAS Y ARCHIVOS ESPECIALES
            backgroundWorker1.ReportProgress(0, "Otros");
            CreateDirectoryFTP(string.Format(@"{0}\-Declaraciones", sCliente));
            CreateDirectoryFTP(string.Format(@"{0}\-Del", sCliente));
            // Creamos un archivo de texto y lo subimos
            string PathLog = string.Format(@"{0}\mpy\Log.txt", Path.GetTempPath());
            TextWriter tw = new StreamWriter(PathLog);
            tw.Close();
            string FullPath = string.Format("{0}/{1}/{2}/", FTPCredentials.Path, ConnectionString.FolderConnection, sCliente);
            FTPServer.Upload(FullPath, FTPCredentials.User, FTPCredentials.Password, Path.GetFileName(PathLog), PathLog);
            File.Delete(PathLog);
        }
        #endregion 
    }
}