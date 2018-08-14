using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.Logica;
using System.IO;
using System.Net;

namespace LxCallcenter.LexaSIOConta
{
    public partial class frmDeclaracionComplementaria : Form
    {
        UsuarioData                     AUsuario;
        public static int               iIdCliente;
        public static string            sCliente;
        public List<DeclaracionEstado>  declaraciones;

        NetworkCredential _NetworkCredential = new NetworkCredential(ServerFile.sUser, ServerFile.sPassword);
        string PathFolderShared = @"\\192.169.143.34\MiPyme_Files";

        public frmDeclaracionComplementaria()
        {
            InitializeComponent();
            AUsuario = UsuarioData.Instancia;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            MensajeError.Clear();
            try
            {
                //SE REALIZA UNA BUSQUEDA DEL CLIENTE A TRAVES DE SU CLAVE
                DeclaracionEstado declaracionEstado = new DeclaracionEstado().obtenerClienteDC(int.Parse(AUsuario.sIdusuario), txbNCliente.Text, txbRfc.Text);
                iIdCliente = declaracionEstado.iIdCliente;
                sCliente   = declaracionEstado.sCliente;
                lblBuscarCliente.Visible = false;

                txbNombre.Text = declaracionEstado.sNombre   + " " +
                                 declaracionEstado.sAPaterno + " " +
                                 declaracionEstado.sAMaterno;
                txbEMail.Text  = declaracionEstado.sCorreoElectronico;
                
                //VALIDACIÓN SI EL CLIENTE ESTA ACTIVO O NO
                if (declaracionEstado.sActivo.Equals("True"))
                {
                    btnNDeclracion.Enabled  = true;
                    lblCActivo.Visible      = false;
                }
                else
                {
                    lblCActivo.Visible = true;
                }
            }
            catch (Exception)
            {
                lblBuscarCliente.Visible = true;
                lblCActivo.Visible       = false;
                txbNombre.Text           = string.Empty;
                txbEMail.Text            = string.Empty;
            }
        }

        private void btnNDeclracion_Click(object sender, EventArgs e)
        {
            gbDeclaracion.Visible = true;
            InicializaControles();
        }

        public void InicializaControles()
        {
            //CREA UNA LISTA DE LOS SIGUIENTES TRES AÑOS A PARTIR DEL AÑO EN CURSO
            int v = 0;
            List<Anio> lista = new List<Anio>();
            for (int i = DateTime.Now.Year; i < DateTime.Now.Year + 3; i++)
            {
                v++;
                lista.Add(new Anio(i.ToString(), v));
            }

            //CARGA LA LISTA DE AÑOS EN UN COMBOBOX
            cmbxAnioDeclaracion.DisplayMember  = "sAnio";
            cmbxAnioDeclaracion.ValueMember    = "iIdAnio";
            cmbxAnioDeclaracion.DataSource     = lista;
            cmbxAnioDeclaracion.SelectedIndex  = -1;

            //CARGAR UNA LISTA DE DECLARACIONES DISPONIBLES PARA EL CLIENTE
            cbDecTipo.DisplayMember = "sDetalleObligacion";
            cbDecTipo.ValueMember   = "iIdDetalleObligacion";
            cbDecTipo.DataSource    = new LogicaCC.LexaSIOContaLogica.Declaracion().listaDComplementarias(new LogicaCC.LexaSIOContaLogica.Declaracion()
            {
                iIdCliente = iIdCliente
            });
            cbDecTipo.SelectedIndex = -1;

            //CARGA LOS ESTADOS DE PAGO DISPONIBLES PARA LA DECLARACIÓN
            cbEstadoPago.DataSource     = new DeclaracionEstado().listaDeclaracionEstado();
            cbEstadoPago.DisplayMember  = "sDeclaracionEstado";
            cbEstadoPago.ValueMember    = "iIdDeclaracionEstado";
            cbEstadoPago.SelectedIndex  = -1;

            //CARGA UNA LISTA DE CONCEPTOS DISPONIBLES PARA EL CLIENTE
            cmbxConcepto.DataSource     = new LogicaCC.LexaSIOContaLogica.Concepto().listaConceptos();
            cmbxConcepto.DisplayMember  = "sConcepto";
            cmbxConcepto.ValueMember    = "iIdConcepto";
            cmbxConcepto.SelectedIndex  = -1;
        }

        private void cbDecTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //CARGA UNA LISTA DE PERIODOS SEGÚN LA DECLARACIÓN SELECCIONADA
                cbPeriodo.DisplayMember = "sPeriodo";
                cbPeriodo.ValueMember   = "iIdPeriodo";
                cbPeriodo.DataSource    = new LogicaCC.LexaSIOContaLogica.Declaracion().listaPeriodoDC(new LogicaCC.LexaSIOContaLogica.Declaracion()
                {
                    iIdCliente              = iIdCliente,
                    iAnio                   = int.Parse(cmbxAnioDeclaracion.GetItemText(cmbxAnioDeclaracion.SelectedItem)),
                    iIdDetalleObligacion    = int.Parse(cbDecTipo.SelectedValue.ToString())
                });

                cbPeriodo.SelectedIndex = -1;
            }
            catch
            {
                //MessageBox.Show("0");
                //cbPeriodo.Items.Clear();
            }
        }

        private void cbEstadoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            //VALIDACIONES PARA CONTROLES CUANDO SE CAMBIA EL ESTADO DE PAGO
            if (cbEstadoPago.SelectedIndex == 3)
            {
                btnSubirArchivo.Visible = true;
                txtRutaArchivo.Visible  = true;
            }
            else
            {
                btnSubirArchivo.Visible = false;
                txtRutaArchivo.Visible  = false;
            }
        }

        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            //NOMBRE Y FILTROS PARA EL CONTROL OPENFILEDIALOG
            openFileDialogDocumento.Title = "Subir Archivos";
            //openFileDialogDocumento.Filter = "Pdf Files|*.pdf |JPG|*.jpg;*.jpeg |Excel Files|*.xls;*.xlsx;*.xlsm |txt files (*.txt)|*.txt|Zip Files|*.zip;*.rar";
            openFileDialogDocumento.FileName = "";
            openFileDialogDocumento.ShowDialog();
            txtRutaArchivo.Text = openFileDialogDocumento.FileName;
        }

        /// <summary>
        /// Guarda los archivos de la declaración en el servidor
        /// </summary>
        public void cargarArchivos()
        {
            //VALIDA SI ESTADO DE PAGO ES "PAGADA"
            if (cbEstadoPago.SelectedIndex == 3)
            {
                try
                {
                    using (new NetworkConnection(PathFolderShared, _NetworkCredential))
                    {
                        //VALIDA SI EL DIRECTORIO DONDE SE GUARDARA EL ARCHIVO EXISTE
                        if (!Directory.Exists(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + iIdCliente + "\\" + "Declaraciones" + "\\" + cbDecTipo.SelectedValue.ToString() + "\\" + DateTime.Now.ToString("dd-MM-yyyy")))
                        {
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + iIdCliente + "\\" + "Declaraciones" + "\\" + cbDecTipo.SelectedValue.ToString() + "\\" + DateTime.Now.ToString("dd-MM-yyyy"));
                        }

                        //VALIDA SI LOS DIRECTORIO EXISTEN, SI NO, SE CREAN LAS CARPETAS
                        if (!Directory.Exists(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea"))
                        {
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea");

                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\01 General");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\01 General\\CIF");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\01 General\\e-firma y contrasenas");

                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\02 Movimientos al RFC");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\02 Movimientos al RFC\\Actualizacion aumento-disminucion de obligaciones");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\02 Movimientos al RFC\\Apertura de establecimiento o sucursal");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\02 Movimientos al RFC\\Cambio de Domicilio");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\02 Movimientos al RFC\\Cierre de establecimiento o sucursal");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\02 Movimientos al RFC\\Inscripcion al RFC");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\02 Movimientos al RFC\\Reanudacion de actividades");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\02 Movimientos al RFC\\Suspension de actividades");

                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\Altas, bajas y modificaciones de salario");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\Altas, bajas y modificaciones de salario\\Altas");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\Altas, bajas y modificaciones de salario\\Bajas");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\Altas, bajas y modificaciones de salario\\Modificaciones de salario");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\Avisos de retencion INFONAVIT");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\Avisos trimestrales IMSS-INFONAVIT");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\Cedulas de determinacion");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\Certificado. Req, Key, usuario y contrasena");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\EMA-EBA");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\Incapacidades medicas");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\Incapacidades medicas\\Enfermedad general");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\Incapacidades medicas\\Maternidad");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\Incapacidades medicas\\Riesgo de trabajo");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\Opinion de cumplimiento IMSS-INFONAVIT");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\Respaldos SUA");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\SIPARE y pagos");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\03 IMSS-INFONAVIT\\Tarjeta y registro patronal");

                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04 Declaraciones y pagos");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04 Declaraciones y pagos\\Declaraciones y acuses de pagos provisionales, definitivos y retenciones");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04 Declaraciones y pagos\\DIOT");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04 Declaraciones y pagos\\Pagos");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04 Declaraciones y pagos\\Pagos\\" + cbDecTipo.Text);

                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\05 Facturas emitidas");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\05 Facturas emitidas\\Al publico en general");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\05 Facturas emitidas\\Contribuyente especifico");

                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\06 Facturas recibidas");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\06 Facturas recibidas\\Deducible");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\06 Facturas recibidas\\No deducible");

                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\07 Recibos de Nomina");

                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\08 Registros contables y Estados financieros");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\08 Registros contables y Estados financieros\\Auxiliares");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\08 Registros contables y Estados financieros\\Balanzas de comprobacion");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\08 Registros contables y Estados financieros\\Libro diario y libro mayor");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\08 Registros contables y Estados financieros\\Mis Cuentas");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\08 Registros contables y Estados financieros\\Polizas contables");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\08 Registros contables y Estados financieros\\Polizas contables\\Cheque");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\08 Registros contables y Estados financieros\\Polizas contables\\Diario");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\08 Registros contables y Estados financieros\\Polizas contables\\Egresos");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\08 Registros contables y Estados financieros\\Polizas contables\\Ingresos");

                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\09 Estados de Cuenta");

                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\10 Facultades de Comprobacion");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\10 Facultades de Comprobacion\\Invitaciones");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\10 Facultades de Comprobacion\\Requerimientos");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\10 Facultades de Comprobacion\\Revision de gabinete");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\10 Facultades de Comprobacion\\Revisiones electronicas");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\10 Facultades de Comprobacion\\Verificacion de comprobantes digitales");
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\10 Facultades de Comprobacion\\Visitas domiciliarias");

                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\11 Otros");

                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\12 Comprobantes de pagos");


                        }

                        //VALIDA SI LOS DIRECTORIO EXISTEN, SI NO, SE CREAN LAS CARPETAS
                        if (!Directory.Exists(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04 Declaraciones y pagos\\Pagos\\" + cbDecTipo.Text + "\\" + DateTime.Now.ToString("dd-MM-yyyy")))
                        {
                            Directory.CreateDirectory(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04 Declaraciones y pagos\\Pagos\\" + cbDecTipo.Text + "\\" + DateTime.Now.ToString("dd-MM-yyyy"));
                        }


                        //CUENTA EL NÚMERO DE ARCHIVOS EN EL DIRECTORIO
                        var fileCount = (from file in Directory.EnumerateFiles(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + iIdCliente + "\\" + "Declaraciones" + "\\" + cbDecTipo.SelectedValue.ToString() + "\\" + DateTime.Now.ToString("dd-MM-yyyy")) select file).Count();
                        int i = fileCount - 1;

                        //GUARDA LOS ARCHIVOS SELECCIONADOS EN EL CONTROL OPENFILEDIALOG
                        foreach (string fileName in openFileDialogDocumento.FileNames)
                        {
                            //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
                            i++;
                            File.Copy(fileName, @"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + iIdCliente + "\\" + "Declaraciones" + "\\" + cbDecTipo.SelectedValue.ToString() + "\\" + DateTime.Now.ToString("dd-MM-yyyy") + "\\" + Path.GetFileName(fileName));
                            File.Move(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + iIdCliente + "\\" + "Declaraciones" + "\\" + cbDecTipo.SelectedValue.ToString() + "\\" + DateTime.Now.ToString("dd-MM-yyyy") + "\\" + Path.GetFileName(fileName), @"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + iIdCliente + "\\" + "Declaraciones" + "\\" + cbDecTipo.SelectedValue.ToString() + "\\" + DateTime.Now.ToString("dd-MM-yyyy") + "\\" + i + DateTime.Now.ToString("ddMMyyyy") + Path.GetExtension(fileName));

                            //Directory.CreateDirectory(@"\\192.168.1.34\\Documentos\\" + sCliente + "\\" + "Expediente en Linea\\04 Declaraciones y pagos\\Pagos");
                            File.Copy(fileName, @"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04 Declaraciones y pagos\\Pagos\\" + cbDecTipo.Text + "\\" + DateTime.Now.ToString("dd-MM-yyyy") + "\\" + Path.GetFileName(fileName));
                            File.Move(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04 Declaraciones y pagos\\Pagos\\" + cbDecTipo.Text + "\\" + DateTime.Now.ToString("dd-MM-yyyy") + "\\" + Path.GetFileName(fileName), @"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04 Declaraciones y pagos\\Pagos\\" + cbDecTipo.Text + "\\" + DateTime.Now.ToString("dd-MM-yyyy") + "\\" + i + DateTime.Now.ToString("ddMMyyyy") + Path.GetExtension(fileName));
                            EscribirLog("Se copió el archivo " + @"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04 Declaraciones y pagos\\Pagos\\" + cbDecTipo.Text + "\\" + DateTime.Now.ToString("dd-MM-yyyy") + "\\" + i + DateTime.Now.ToString("ddMMyyyy") + Path.GetExtension(fileName));


                            //SE GUARDA REGISTRO DEL ADJUNTO DEN LA BD
                            new Adjunto().insertarAdjunto(new Adjunto()
                            {
                                iIdRegistroObligacion  = int.Parse(cbDecTipo.SelectedValue.ToString()),
                                iIdCliente             = iIdCliente,
                                sAdjunto               = @"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + iIdCliente + "\\" + "Declaraciones" + "\\" + cbDecTipo.SelectedValue.ToString() + "\\" + DateTime.Now.ToString("dd-MM-yyyy") + "\\" + i + DateTime.Now.ToString("ddMMyyyy") + Path.GetExtension(fileName)
                            });
                        }

                        //SE INICIALIZA AL APARTADO PARA SUBIR ARCHIVOS
                        txtRutaArchivo.Text               = string.Empty;
                        openFileDialogDocumento.FileName  = "";
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// VALIDA LOS CONTROLES DE LA DECLARACIÓN
        /// </summary>
        /// <returns></returns>
        private int ValidarDeclaracion()
        {
            int iResultado = 0;

            if (cmbxAnioDeclaracion.SelectedIndex == -1)
            {
                MensajeError.SetError(cmbxAnioDeclaracion, "Debe insertar año de la declaración.");
                iResultado = 1;
            }

            if (cbPeriodo.SelectedIndex == -1)
            {
                MensajeError.SetError(cbPeriodo, "Debe seleccionar un periodo.");
                iResultado = 1;
            }

            if (txbMonto.Text.Equals(""))
            {
                MensajeError.SetError(txbMonto, "Debe insertar año de la declaración.");
                iResultado = 1;
            }

            if (cbEstadoPago.SelectedIndex == 0)
            {
                MensajeError.SetError(cbEstadoPago, "Debe seleccionar estado del pago.");
                iResultado = 1;
            }

            if (txbLCaptura.Text.Equals(""))
            {
                MensajeError.SetError(txbLCaptura, "Debe proporcionar la linea de captura.");
                iResultado = 1;
            }

            DateTime dFecha = Convert.ToDateTime(dpFechaPago.Text);

            if (dFecha < DateTime.Now)
            {
                MensajeError.SetError(dpFechaPago, "La fecha no puede ser menor a la actual.");
                iResultado = 1;
            }
            return iResultado;
        }

        /// <summary>
        /// LIMPIA LOS CONTROLES DE LA BÚSQUEDA
        /// </summary>
        private void LimpiarBusqueda()
        {
            txbNCliente.Text  = "";
            txbRfc.Text       = "";
        }

        /// <summary>
        /// VALIDA LOS TEXTBOX DE BÚSQUEDA DE CLIENTE
        /// </summary>
        /// <returns></returns>
        private int ValidarBusqueda()
        {
            int iResultado = 0;

            if (txbNCliente.Text.Equals("") && txbRfc.Text.Equals(""))
            {
                MessageBox.Show("Debe buscar un cliente por RFC o Número de cliente.");
                iResultado = 1;
            }

            return iResultado;
        }

        /// <summary>
        /// LIMPIA Y PONE LOS CONTROLES EN ESTADO INICIAL
        /// </summary>
        private void LimpiarControles()
        {
            txbNombre.Text                      = "";
            txbEMail.Text                       = "";
            cmbxAnioDeclaracion.SelectedIndex   = -1;
            dpFPresentacion.Text                = DateTime.Now.ToString();
            txbMonto.Text                       = "";
            txbNumOperacion.Text                = "";
            dpFechaPago.Text                    = DateTime.Now.ToString();
            txbLlavePago.Text                   = "";
            txbLCaptura.Text                    = "";
            grdConceptos.Rows.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //LIMPIA DEL CONTROL ERRORPROVIDER
            MensajeError.Clear();
            //VALIDAMOS SI SE TIENE LA INFORMACIÓN REQUERIDA
            if (ValidarDeclaracion() == 0)
            {
                //CREA NUEVO REGISTRO DE LA DECLARACIÓN COMPLEMENTARIA
                new LogicaCC.LexaSIOContaLogica.Declaracion().crearDeclaracionComplementaria(new LogicaCC.LexaSIOContaLogica.Declaracion()
                {
                    sIdCliente          = iIdCliente.ToString(),
                    sIdPeriodo          = cbPeriodo.SelectedValue.ToString(),
                    sIdDeclaracionTipo  = cbDecTipo.SelectedValue.ToString(),
                    sIdDecEstado        = cbEstadoPago.SelectedValue.ToString(),
                    sIdUsuario          = AUsuario.sIdusuario,
                    sAñoDec             = cmbxAnioDeclaracion.GetItemText(cmbxAnioDeclaracion.SelectedItem),
                    sLinCap             = txbLCaptura.Text,
                    sNumOper            = txbNumOperacion.Text,
                    sMonto              = txbMonto.Text,
                    sLlavePago          = txbLlavePago.Text,
                    sFechaLimPag        = dpFechaPago.Text,
                    sFechaPresentacion  = dpFPresentacion.Text
                });
                //RECORRE EL GRIDVIEW DE CONCEPTOS PARA GUARDARLOS
                foreach (DataGridViewRow row in grdConceptos.Rows)
                {
                    new LogicaCC.LexaSIOContaLogica.RegistroConcepto().InsertarRegistroObligacion(new LogicaCC.LexaSIOContaLogica.RegistroConcepto()
                    {
                        iIdConcepto = int.Parse(row.Cells[0].Value.ToString()),
                        dMonto      = decimal.Parse(row.Cells[2].Value.ToString())
                    });
                }

                MessageBox.Show("Declaración guardada exitosamente.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarBusqueda();
                LimpiarControles();
                gbBuscarCliente.Enabled = true;
                gbDeclaracion.Visible   = false;
                txbNCliente.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //REINICIAMOS LOS ESTADOS DE LOS CONTROLES
            LimpiarBusqueda();
            LimpiarControles();
            gbBuscarCliente.Enabled = true;
            gbDeclaracion.Visible   = false;
            txbNCliente.Focus();
        }

        private void btnAgregarConcepto_Click(object sender, EventArgs e)
        {
            //AGREGAMOS UN NUEVO CONCEPTO DE LA LISTA DE CONCEPTOS AL GRIDVIEW GRDCONCEPTOS
            if (cmbxConcepto.SelectedIndex != -1 && txtImporte.Text != string.Empty)
            {
                string[] concepto = new string[] { cmbxConcepto.SelectedValue.ToString(), cmbxConcepto.Text, txtImporte.Text };
                grdConceptos.Rows.Add(concepto);

                cmbxConcepto.SelectedIndex  = -1;
                txtImporte.Text             = string.Empty;
            }
            else
            {
                MessageBox.Show("No campos vacios");
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDACIÓN PARA INGRESAR SÓLO NÚMEROS
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Método Público para escribir un log de los cambios de los archivos del expediente en linea
        /// </summary>
        /// <param name="strMessage">Mensaje que se guardara en el log.</param>
        public void EscribirLog(string strMessage)
        {
            using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            {
                //VALIDACIÓN SI EL ARCHIVO EXISTE
                if (!File.Exists(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + @"Expediente en Linea\Log.txt"))
                {
                    var myFile = File.Create(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Clientes\\" + sCliente + "\\" + @"Expediente en Linea\Log.txt");
                    myFile.Close();
                }

                //RUTA DE ACCESO DEL ARCHIVO LOG
                string logFile = @"\\192.169.143.34\MiPyme_Files\Documentos\Clientes\" + sCliente + @"\Expediente en Linea\Log.txt";

                //APLICA FORMATO AL LOG Y ESCRIBE EL MENSAJE QUE SE PASA EN EL PARAMETRO STRMENSAJE.
                string line = string.Format("{0} | {1} | ", DateTime.Now, AUsuario.sIdusuario);
                line += strMessage;
                FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
                StreamWriter swFromFileStream = new StreamWriter(fs);
                swFromFileStream.WriteLine(line);
                swFromFileStream.Flush();
                swFromFileStream.Close();
            }
        }



    }
}
