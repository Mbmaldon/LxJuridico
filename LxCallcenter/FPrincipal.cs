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
using System.Threading;

namespace LxCallcenter
{
    public partial class FPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UsuarioData AUsuarioData = UsuarioData.Instancia;
        private readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        // CONSTRUCTOR
        public FPrincipal()
		{
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            InitializeComponent();      
            materialSkinManager             = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.Theme       = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo400, MaterialSkin.Primary.Indigo400, MaterialSkin.Primary.Indigo400, MaterialSkin.Accent.Green700, MaterialSkin.TextShade.BLACK);
		}

		private void FPrincipal_Load(object sender, EventArgs e)
        {
            //CheckForIllegalCrossThreadCalls = false;



            ThreadStart proceso = new ThreadStart(ShowReminders);
            Thread hilo = new Thread(proceso);
            hilo.Start();

            // CODIGO QUE SE EJECUTA MIENTRAS MUESTRO EL CUADRO MODAL

            _MainDelegate mainDelegado = new _MainDelegate(PermisosUsuario);
            mainDelegado(sender, e);

            _Delegate delegado = new _Delegate(ShowPhone);
            this.Invoke(delegado);
        }

        public delegate void _Delegate();

        public delegate void _MainDelegate(object sender, EventArgs e);

        private void ShowReminders()
        {
            if (AUsuarioData.sTipoUsuario.Equals("6"))
            {
                btnRecordatorios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                LexaSIOConta.frmReminders _Reminders = new LexaSIOConta.frmReminders();
                _Reminders.ShowDialog();
            }

            //_Delegate = new Delegate(ShowPhone);
            
            //Thread.Sleep(200);
            //Thread.Sleep(200);
        }

        private void Move1(object sender, EventArgs e)
        {
            try
            {
                Point p = this.PointToScreen(new Point(this.ClientRectangle.X + this.Width - _frmTelefonoTwo.Width, this.ClientRectangle.Y));
                _frmTelefonoTwo.Location = p; //childForm needs to be a class member

            }
            catch (Exception)
            {
            }
        }
        private void FPrincipal_Move(object sender, EventArgs e)
        {
            try
            {
                Point p = this.PointToScreen(new Point(this.ClientRectangle.X + this.Width - _frmTelefonoOne.Width, this.ClientRectangle.Y));
                _frmTelefonoOne.Location = p; //childForm needs to be a class member

            }
            catch (Exception)
            {
            }
        }

        private void FPrincipal_Resize(object sender, EventArgs e)
        {
            if (_frmTelefonoOne != null)
                _frmTelefonoOne.Height = this.Height;
            else if (_frmTelefonoTwo != null)
                _frmTelefonoTwo.Height = this.Height;
        }

        frmTelefono _frmTelefonoOne = null;
        frmTelefono _frmTelefonoTwo = null;

        public void ShowPhone()
        {
            // Valida si el usuario tiene una línea configurada        
            if (new UsuarioLinea().ObtenerLinea(int.Parse(AUsuarioData.sIdusuario)) != null)
            {
                _frmTelefonoOne = Application.OpenForms["frmTelefono"] as frmTelefono;
                if (_frmTelefonoOne == null)
                {
                    _frmTelefonoTwo = new frmTelefono();
                    this.Move += Move1;
                    Point p = this.PointToScreen(new Point(this.ClientRectangle.X + this.Width - _frmTelefonoTwo.Width - 127, this.ClientRectangle.Y));


                    _frmTelefonoTwo.Location = p;
                    _frmTelefonoTwo.Owner = this;
                    _frmTelefonoTwo.Height = this.Height;
                    _frmTelefonoTwo.Show();

                    while (_frmTelefonoTwo.Width < 301)
                    {
                        _frmTelefonoTwo.Width+=20;
                        _frmTelefonoTwo.Left-=20;
                        Application.DoEvents(); //allow the Form to display its new size before the next iteration
                    }
                    _frmTelefonoTwo.bEstadoPanel = true;
                }
                else
                {
                    Point p = this.PointToScreen(new Point(this.ClientRectangle.X + this.Width - _frmTelefonoOne.Width, this.ClientRectangle.Y));
                    _frmTelefonoOne.Location = p;
                    _frmTelefonoOne.Owner = this;
                    _frmTelefonoOne.Height = this.Height;
                    _frmTelefonoOne.Show();

                    while (_frmTelefonoOne.Width < 301)
                    {
                        _frmTelefonoOne.Width+=20;
                        _frmTelefonoOne.Left-=20;
                        Application.DoEvents(); //allow the Form to display its new size before the next iteration
                    }
                    _frmTelefonoTwo.bEstadoPanel = true;
                }














            }
            else
            {
                // Muestra form para configurar línea
                frmTelefonoConfigurar _frmTelefonoConfigurar = new frmTelefonoConfigurar();
                _frmTelefonoConfigurar.Owner = this;
                _frmTelefonoConfigurar.Show();
            }
            //// Valida si el usuario tiene una línea configurada        
            //if (new UsuarioLinea().ObtenerLinea(int.Parse(AUsuarioData.sIdusuario)) != null)
            //{
            //    // Muestra form de teléfono
            //    frmTelefono _frmTelefono = new frmTelefono();
            //    _frmTelefono.Owner = this;
            //    _frmTelefono.Show();
            //}
            //else
            //{
            //    // Muestra form para configurar línea
            //    frmTelefonoConfigurar _frmTelefonoConfigurar = new frmTelefonoConfigurar();
            //    _frmTelefonoConfigurar.Owner = this;
            //    _frmTelefonoConfigurar.Show();
            //}
        }

        #region Eventos controles
        // Evento para cerrar la aplicación
        private void FPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmTelefono _Telefono = Application.OpenForms["frmTelefono"] as frmTelefono;
            if (FlatMessageBox.Show("¿Esta seguro que desea salir?", "SI", "NO", FlatMessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                // Valida si existe una llamada en curso, si es así, no se permite salir de la aplicación
                if (_Telefono != null)
                {
                    if (_Telefono._call != null)
                    {
                        e.Cancel = true;
                        FlatMessageBox.Show("Existe una llamada en curso, para continuar, debe finalizarla.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
                    }
                }
            }
        }
        #endregion 

        #region Funciones usuadas por controles
        /// <summary>
        /// Establece permisos a los usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PermisosUsuario(object sender, EventArgs e) 
        {
            // Muestra el nombre del usuario
            barStaticItem1.Caption = string.Format("{0} {1} {2}", AUsuarioData.sNombre, AUsuarioData.sAPaterno, AUsuarioData.sAMAterno);

            //// Valida si el usuario tiene una línea configurada        
            //if (new UsuarioLinea().ObtenerLinea(int.Parse(AUsuarioData.sIdusuario)) != null)
            //{
            //    // Muestra form de teléfono
            //    frmTelefono _frmTelefono = new frmTelefono();
            //    MostrarTelefono(_frmTelefono);
            //}
            //else
            //{
            //    // Muestra form para configurar línea
            //    frmTelefonoConfigurar _frmTelefonoConfigurar = new frmTelefonoConfigurar();
            //    MostrarTelefono(_frmTelefonoConfigurar);
            //}

            if (AUsuarioData.sTipoUsuario.Equals("6"))
            {
                // Usuario Contador
                verObligacionesFiscalesEnCursoToolStripMenuItem_Click(sender, e);
                btnOFEditarAsignadas.Visibility			= DevExpress.XtraBars.BarItemVisibility.Never;
                btnCLSeguimientoFolios.Visibility		= DevExpress.XtraBars.BarItemVisibility.Never;
                ribbonPageGroup10.Visible				= false;
                ribbonPageGroup4.Visible				= false;
                ribbonPage7.Visible						= false;
                ribbonPage3.Visible						= false;
                ribbonPage9.Visible						= false;
                btnOFVerClientes.Visibility				= DevExpress.XtraBars.BarItemVisibility.Never;
                ribbonPageGroup5.Visible				= false;
                ribbonPageGroup17.Visible				= true;
                ribbonPageGroup18.Visible				= true;
                ribbonPageGroup19.Visible				= true;
                ribbonPageGroup20.Visible				= true;
                ribbonPageGroup21.Visible				= true;
				btnObligacionesRecordatorios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
				btnObligacionesUnicas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

			}
            else if (AUsuarioData.sTipoUsuario.Equals("5"))
            {
                // Usuario Supervisor de Contabilidad
                verObligacionesFiscalesEnCursoToolStripMenuItem_Click(sender, e);
                ribbonPage2.Visible                  = false;
                ribbonPage4.Visible                  = false;
                ribbonPage5.Visible                  = false;
                ribbonPage7.Visible                  = false;
                ribbonPage9.Visible					 = false;
                ribbonPageGroup17.Visible            = true;
                ribbonPageGroup18.Visible            = true;
                ribbonPageGroup19.Visible            = true;
                ribbonPageGroup20.Visible            = true;
                ribbonPageGroup21.Visible            = true;
                btnOFCumplidas.Visibility            = DevExpress.XtraBars.BarItemVisibility.Never;
                btnOFVerObligacionesFiscales.Enabled = false;
                ribbonPageGroup8.Visible             = false;
                ribbonPage8.Visible = false;

            }
            else if (AUsuarioData.sTipoUsuario.Equals("1"))
            {
                ribbonPage6.Visible = true;
            }
            else if (AUsuarioData.sTipoUsuario.Equals("10009"))
            {
                // Usuario Atención a Clientes
                ribbonPageGroup8.Visible	= false;
                ribbonPage1.Visible			= false;
                ribbonPage2.Visible			= false;
                ribbonPage3.Visible			= false;
                ribbonPage5.Visible			= false;
                ribbonPage7.Visible			= false;
				ribbonPageGroup20.Visible	= true;
				RegistrarLlamada FCliente = new RegistrarLlamada();
                MostrarFormulario(FCliente);
            }
            else if (AUsuarioData.sTipoUsuario.Equals("20016"))
            {
                // Usuario Expediente en Línea
                ribbonPage1.Visible = false;
                ribbonPage2.Visible = false;
                ribbonPage3.Visible = false;
                ribbonPage4.Visible = false;
                ribbonPage7.Visible = false;
                ribbonPage9.Visible = false;

                LexaSIOConta.frmExpedienteLineaClientes _frmInicioObligaciones = new LexaSIOConta.frmExpedienteLineaClientes();
                MostrarFormulario(_frmInicioObligaciones);
                btnAgregarArchivo.Enabled = false;
                ribbonPage8.Visible = false;
            }
			else if (AUsuarioData.sTipoUsuario.Equals("20071"))
			{
				// Usuario para OPERACIONES Y DISPERSIONES
				ribbonPage1.Visible = false;
				ribbonPage2.Visible = false;
				ribbonPage3.Visible = false;
				ribbonPage4.Visible = false;
				ribbonPage5.Visible = false;
				ribbonPage6.Visible = false;
                ribbonPage9.Visible = false;

                ribbonPageGroup9.Visible = false;

				LexaSIOOperacionesDispersiones.frmPagos _frmPagos = new LexaSIOOperacionesDispersiones.frmPagos();
				MostrarFormulario(_frmPagos);
				btnExportarConcentradoFacturas.Enabled	= true;
				btnAsignarFacCon.Enabled				= false;
				btnActualizarListaPagos.Enabled			= true;
                ribbonPage8.Visible = false;
            }
			else if (AUsuarioData.sTipoUsuario.Equals("10008") || AUsuarioData.sTipoUsuario.Equals("20015") || AUsuarioData.sTipoUsuario.Equals("20020"))
            {
                // Usuario para Tesorería
                ribbonPage1.Visible = false;
                ribbonPage2.Visible = false;
                ribbonPage3.Visible = false;
                ribbonPage4.Visible = false;
                ribbonPage5.Visible = false;
                ribbonPage6.Visible = false;
                ribbonPage8.Visible = false;
                ribbonPage9.Visible = false;

                ribbonPageGroup22.Visible = false;
				ribbonPageGroup13.Visible = false;
				ribbonPageGroup15.Visible = false;
				ribbonPageGroup16.Visible = false;
				ribbonPageGroup23.Visible = false;



				if (AUsuarioData.sTipoUsuario.Equals("20015"))
                {
                    // Validación si el usuario es de Recursos Humanos
                    btnRegistroFacturas.Enabled          = false;
                    btnConcentradoFacturas.Enabled       = false;
                    btnReportesOperaciones.Enabled       = false;
                    //btnExportarClientesInactivos.Enabled = false;
                    //btnClientesInactivos.Enabled         = false;
                    ribbonPageGroup22.Enabled            = true;
					btnAsignarFacCon.Enabled			 = false;
					//btnPagarComisionSel.Visibility       = DevExpress.XtraBars.BarItemVisibility.Never;
                    //btnPagarComisionesTod.Visibility     = DevExpress.XtraBars.BarItemVisibility.Never;
                    LexaSIOOperacionesDispersiones.frmComisionesPago _frmComisionesPago = new LexaSIOOperacionesDispersiones.frmComisionesPago();
                    MostrarFormulario(_frmComisionesPago);
                }
                else
                {
					LexaSIOOperacionesDispersiones.frmConciliacion _frmConciliacion = new LexaSIOOperacionesDispersiones.frmConciliacion();
					MostrarFormulario(_frmConciliacion);
				}
			}
            else if (AUsuarioData.sTipoUsuario.Equals("20043") || AUsuarioData.sTipoUsuario.Equals("20082") || AUsuarioData.sTipoUsuario.Equals("20083"))
            {
                // Usuario Jurídico
                ControlActividadesJuridico.FBandeja _frmBandeja = new ControlActividadesJuridico.FBandeja();
                MostrarFormulario(_frmBandeja);

                ControlActividadesJuridico.FBandeja _Bandeja = Application.OpenForms["FBandeja"] as ControlActividadesJuridico.FBandeja;
                btnNuevaSolicitudJuridico.Enabled = _Bandeja.btnNewSolicitud.Visible;

                ribbonPage1.Visible = false;
                ribbonPage2.Visible = false;
                ribbonPage3.Visible = false;
                ribbonPage4.Visible = false;
                ribbonPage5.Visible = false;
                ribbonPage6.Visible = false;
                ribbonPage7.Visible = false;
                ribbonPage9.Visible = false;
            }
			else
			{
				ribbonPage1.Visible = false;
				ribbonPage2.Visible = false;
				ribbonPage3.Visible = false;
				ribbonPage4.Visible = false;
				ribbonPage5.Visible = false;
				ribbonPage6.Visible = false;
				ribbonPage7.Visible = false;
                ribbonPage8.Visible = false;
                ribbonPage9.Visible = false;
            }
                        
            ribbonControlPrincipal.SelectedPageChanged += RibbonControlPrincipal_SelectedPageChanged;
        }

        private void RibbonControlPrincipal_SelectedPageChanged(object sender, EventArgs e)
        {
            if (ribbonControlPrincipal.SelectedPage == ribbonPage1) // Abre Pantalla Obligaciones Fiscale en Curso
            {
                if (AUsuarioData.sTipoUsuario.Equals("5")) // Abre pantalla si el usuario es el coordinaro de contabilidad
                {
                    LexaSIOConta.frmInicioContadores _frmInicioContadores = new LexaSIOConta.frmInicioContadores();
                    MostrarFormulario(_frmInicioContadores);
                }
                else
                {
                    LexaSIOConta.frmInicioObligaciones _frmInicioObligaciones = new LexaSIOConta.frmInicioObligaciones(int.Parse(AUsuarioData.sIdusuario)); // Abre pantalla si el usuario es contador
                    MostrarFormulario(_frmInicioObligaciones);
                }
            }
            else if (ribbonControlPrincipal.SelectedPage == ribbonPage2) // Abre Pantalla Declaraciones
            {
                //AltaDeclaracion ADeclaracion = new AltaDeclaracion();
                //MostrarFormulario(ADeclaracion);

				LexaSIOConta.frmClients ClientesDeclaraciones = new LexaSIOConta.frmClients();
				MostrarFormulario(ClientesDeclaraciones);

				//Controles del la pagina Obligaciones Fiscales
				btnOFVerClientes.Enabled             = false;
                btnOFVerObligacionesFiscales.Enabled = false;
            }
            else if (ribbonControlPrincipal.SelectedPage == ribbonPage3) // Abre Pantalla Clientes
            {
                if (AUsuarioData.sTipoUsuario.Equals("6"))
                {
                    CerrarFormularios();
                }
                else
                {
                    AltaCliente FCliente      = new AltaCliente(this);
                    MostrarFormulario(FCliente);
                    btnCEditarCliente.Enabled = false;
                    btnCGuardarInfo.Enabled   = false;
                }
            }
            else if (ribbonControlPrincipal.SelectedPage == ribbonPage4) // Abre Pantalla Control de Llamadas
            {
                RegistrarLlamada FCliente = new RegistrarLlamada();
                MostrarFormulario(FCliente);
            }
            else if (ribbonControlPrincipal.SelectedPage == ribbonPage5) // Abre Pantalla Expediente en Línea
            {
                LexaSIOConta.frmExpedienteLineaClientes _frmInicioObligaciones = new LexaSIOConta.frmExpedienteLineaClientes();
                MostrarFormulario(_frmInicioObligaciones);
                btnAgregarArchivo.Enabled = false;
            }
            else if (ribbonControlPrincipal.SelectedPage == ribbonPage6) // Abre Pantalla Alta de Usuarios
            {
                AltaUsuario AUsuario          = new AltaUsuario();
                MostrarFormulario(AUsuario);
                //btnGuardarUsuario.Enabled     = true;
                btnVerDetallesUsuario.Enabled = false;
                btnExportarUsuarios.Enabled   = false;
            }
            else if (ribbonControlPrincipal.SelectedPage == ribbonPage7) // Abre pantalla para cambiar el estado de pago de las comisiones
            {
                if (AUsuarioData.sTipoUsuario.Equals("20015"))
                {
                    // Valida si el usuario es de Recursos Humanos
                    LexaSIOOperacionesDispersiones.frmComisionesPago _frmComisionesPago = new LexaSIOOperacionesDispersiones.frmComisionesPago();
                    MostrarFormulario(_frmComisionesPago);
                }
                else
                {
                    // Valida si el usuario es de tesorería
                    //LexaSIOOperacionesDispersiones.frmControlOperaciones _frmControlOperaciones = new LexaSIOOperacionesDispersiones.frmControlOperaciones();
                    //MostrarFormulario(_frmControlOperaciones);
					LexaSIOOperacionesDispersiones.frmConciliacion _frmConciliacion = new LexaSIOOperacionesDispersiones.frmConciliacion();
					MostrarFormulario(_frmConciliacion);
				}
            }
            else if (ribbonControlPrincipal.SelectedPage == ribbonPage8) // Abre Pantalla Juridico
            {
                ControlActividadesJuridico.FBandeja _frmBandeja = new ControlActividadesJuridico.FBandeja();
                MostrarFormulario(_frmBandeja);
            }
            else if (ribbonControlPrincipal.SelectedPage == ribbonPage9) // Abre pantalla de Prospección
            {
                frmProspectos _Prospeccion = new frmProspectos();
                MostrarFormulario(_Prospeccion);
            }
        }

        /// <summary>
        /// Abre un nuevo formulario dentro del panel principal
        /// </summary>
        /// <param name="Formulario">Form a mostrar</param>
        public void MostrarFormulario(Form Formulario)
        {
            // Valida si el contenedor principal tiene un form
            if (panelContenedor.Controls.Count > 0)
            {
                // Asigna el nombre del form abierto en el panel principal si este existe
                Form fc = Application.OpenForms[Formulario.Name];
                // Si el form no existe en el panel principal, se abre el nuevo form dentro del panel principal, si no, se deja el actual.            
                if (fc == null)
                {
                    CerrarFormularios();
                    Formulario.TopLevel			= false;
                    Formulario.FormBorderStyle	= FormBorderStyle.None;
                    Formulario.Dock				= DockStyle.Fill;
                    panelContenedor.Controls.Add(Formulario);
                    panelContenedor.Tag			= Formulario;
                    Formulario.Show();
                }
            }
            else
            {
                // Si no tiene form, abre el nuevo form dentro del panel principal
                Formulario.TopLevel			= false;
                Formulario.FormBorderStyle	= FormBorderStyle.None;
                Formulario.Dock				= DockStyle.Fill;
                panelContenedor.Controls.Add(Formulario);
                panelContenedor.Tag			= Formulario;
                Formulario.Show();
            }
        }

        ///// <summary>
        ///// Muestra un form de lado derecho de  pantalla, este evita que se cierren las demás pantallas en el panel principal
        ///// </summary>
        ///// <param name="Formulario">Formulario a mostrar</param>
        //private void MostrarTelefono(Form Formulario)
        //{
        //    Formulario.TopLevel        = false;
        //    Formulario.FormBorderStyle = FormBorderStyle.None;
        //    Formulario.Dock            = DockStyle.Fill;
        //    this.pnlTelefono.Controls.Add(Formulario);
        //    this.pnlTelefono.Tag       = Formulario;
        //    Formulario.Show();
        //}

        /// <summary>
        /// Cierra los formularios abiertos y puestos en el panel principal.
        /// </summary>
        private void CerrarFormularios()
		{
			Form[]	sAforms		= new Form[10];
			int		iContador	= 0;
			// Se genera el listado de los formularios abiertos
			foreach(Form x in Application.OpenForms)
			{
				string sForm = x.Name.ToString();

				if(!sForm.Equals("Login") && !sForm.Equals("FPrincipal") && !sForm.Equals("EnviarMensajes") && !sForm.Equals("frmDirectorio") && !sForm.Equals("frmTelefono") && !sForm.Equals("frmTelefonoConfigurar"))
				{
					panelContenedor.Controls.Remove(x);
					sAforms[iContador] = x;
					iContador++;
				}
			}
			// Cierra los formularios
			for(int i=0;i<10;i++)
			{
				if(sAforms[i] != null)
				{
					sAforms[i].Close();
				}
			}
		}
        #endregion            

        #region Eventos para mostrar formularios
        private void verObligacionesFiscalesEnCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // LLAMAMOS AL FORMULARIO QUE MUESTRA LA LISTA DE OBLIGACIONES FISCALES VIGENTES          
            if (AUsuarioData.sTipoUsuario.Equals("5"))
            {
                LexaSIOConta.frmInicioContadores _frmInicioContadores = new LexaSIOConta.frmInicioContadores();
                MostrarFormulario(_frmInicioContadores);
            }
            else
            {
                LexaSIOConta.frmInicioObligaciones _frmInicioObligaciones = new LexaSIOConta.frmInicioObligaciones(int.Parse(AUsuarioData.sIdusuario));
                MostrarFormulario(_frmInicioObligaciones);
            }
        }        

        private void btnObligacionesFiscales_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra un formulario que contiene la información de las obligaciones fiscales en curso
            if (AUsuarioData.sTipoUsuario.Equals("5"))
            {
                LexaSIOConta.frmInicioContadores _frmInicioContadores = new LexaSIOConta.frmInicioContadores();
                MostrarFormulario(_frmInicioContadores);
                btnOFVerObligacionesFiscales.Enabled = false;
            }
            else
            {
                LexaSIOConta.frmInicioObligaciones _frmInicioObligaciones = new LexaSIOConta.frmInicioObligaciones(int.Parse(AUsuarioData.sIdusuario));
                MostrarFormulario(_frmInicioObligaciones);
            }
        }

        private void btnOFCumplidas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra un formulario que contiene un listado de obligaciones fiscales cumplidas por cliente
            LexaSIOConta.frmObligacionesCumplidasCliente _frmObligacionesCumplidasCliente = new LexaSIOConta.frmObligacionesCumplidasCliente();
            MostrarFormulario(_frmObligacionesCumplidasCliente);
            btnOFVerObligacionesFiscales.Enabled = false;
        }

        private void btnOFEditarAsignadas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra un formulario que contiene información de las obligaciones fiscales asignadas por cliente
            LexaSIOConta.frmObligacionesEditarCliente _frmObligacionesEditarCliente = new LexaSIOConta.frmObligacionesEditarCliente();
            MostrarFormulario(_frmObligacionesEditarCliente);
            btnOFVerClientes.Enabled             = false;
            btnOFVerObligacionesFiscales.Enabled = false;
        }

        private void btnDNuevaDeclaracion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
			// Muestra un formulario donde se puede realizar el alta de declaraciones fiscales
			LexaSIOConta.frmClients _Clients = Application.OpenForms["frmClients"] as LexaSIOConta.frmClients;
			if (_Clients != null)
			{
				int iIdCliente = int.Parse(_Clients.gridView1.GetFocusedRowCellValue("iIdCliente").ToString());
				AltaDeclaracion.Show(iIdCliente);
			}
        }

        private void btnDEditarDeclaraciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
			// Muestra un formulario para cambiar el estado de pago de las declaraciones fiscales
			LexaSIOConta.frmClients _Clients = Application.OpenForms["frmClients"] as LexaSIOConta.frmClients;
			if (_Clients != null)
			{
				int iIdCliente = int.Parse(_Clients.gridView1.GetFocusedRowCellValue("iIdCliente").ToString());
				LexaSIOConta.frmEditarDeclaracion.Show(iIdCliente);
			}
		}

        private void btnDNuevaDeclaracionComp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra un formulario donde se puede realizar el alta de declaraciones complementarias
            LexaSIOConta.frmDeclaracionComplementaria _frmDeclaracionComplementaria = new LexaSIOConta.frmDeclaracionComplementaria();
            MostrarFormulario(_frmDeclaracionComplementaria);
        }

        private void btnDCalculadora_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
			// Muestra un formulario donde se puede realiazar el calculo de recargos y actualizaciones
			LexaSIOConta.frmClients _Clients = Application.OpenForms["frmClients"] as LexaSIOConta.frmClients;
			if (_Clients != null)
			{
				string sCliente = _Clients.gridView1.GetFocusedRowCellValue("sCliente").ToString();
				LexaSIOConta.frmCalculadoraRecargosActualizaciones _frmCalculadoraRecargosActualizaciones = new LexaSIOConta.frmCalculadoraRecargosActualizaciones(sCliente);
				MostrarFormulario(_frmCalculadoraRecargosActualizaciones);
			}
        }

        private void btnCAltaCliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra un formulario donde se puede realizar el alta de un cliente
            AltaCliente FCliente = new AltaCliente(this);
            MostrarFormulario(FCliente);
            btnCEditarCliente.Enabled               = false;            
            btnCConfirmarCancelarServicio.Enabled   = false;
        }

        private void btnCCancelarServicio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra un formulario donde se puede realizar la cancelación del servicio de un cliente
            FCancelarServicio FCancelarS = new FCancelarServicio();
            MostrarFormulario(FCancelarS);
            btnCEditarCliente.Enabled = false;
            btnCGuardarInfo.Enabled   = false;
        }

        private void btnCEnviarSMS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {         
            // Muestra una modal para el envío de SMS
            EnvioSms.Show();
        }

        private void btnCLRegistrarLlamada_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra un formulario para llevar el seguimiento de llamadas de los clientes
            RegistrarLlamada FCliente = new RegistrarLlamada();
            MostrarFormulario(FCliente);
        }

        private void btnCLSeguimientoFolios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra un formulario para el historial de llamadas de los clientes y cierre de estos
            FSeguimientoFolios FSeguimientoF = new FSeguimientoFolios();
            MostrarFormulario(FSeguimientoF);
            btnRegLlamada.Enabled = false;
        }

        private void btnOFVerClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra un formulario con un listado de clientes que tienen de obligaciones fiscales en curso, este solo aplica si esta
            // primero en el listado de contadores que tienen clientes con obligaciones fiscales por cumplir
            int    iIdCliente = 0;
            string sCliente   = null;

            LexaSIOConta.frmInicioContadores frmIC = Application.OpenForms["frmInicioContadores"] as LexaSIOConta.frmInicioContadores;
            if (frmIC != null)
            {
                iIdCliente = int.Parse(frmIC.gridView1.GetFocusedRowCellValue("iIdCliente").ToString());
                sCliente   = frmIC.gridView1.GetFocusedRowCellValue("sEquipoContador").ToString();
				//iIdCliente = int.Parse(frmIC.gridView1.GetFocusedRowCellValue("iIdEquipoContador").ToString());
				//sCliente = frmIC.gridView1.GetFocusedRowCellValue("sEquipoContador").ToString();
			}

            LexaSIOConta.frmInicioObligaciones _frmInicioObligaciones = new LexaSIOConta.frmInicioObligaciones(iIdCliente);
            MostrarFormulario(_frmInicioObligaciones);
            _frmInicioObligaciones.label3.Text      = "EQUIPO " + sCliente;
            btnOFVerClientes.Enabled                = false;
            btnOFVerObligacionesFiscales.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }

        private void btnOFVerObligacionesFiscales_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            // Muestra un formulario con un listado de clientes que tienen obligaciones fiscales en curso
            int iIdCliente       = 0;
            string sFechaInicio  = null;
            string sFechaTermino = null;

            LexaSIOConta.frmInicioObligaciones frmIO = Application.OpenForms["frmInicioObligaciones"] as LexaSIOConta.frmInicioObligaciones;
            if (frmIO != null)
            {
                iIdCliente    = int.Parse(frmIO.gridView1.GetFocusedRowCellValue("iIdCliente").ToString());
                sFechaInicio  = frmIO.dttmDesde.Value.ToShortDateString();
                sFechaTermino = frmIO.dttmHasta.Value.ToShortDateString();
            

				LexaSIOConta.frmObligacionesCliente _frmObligacionesCliente = new LexaSIOConta.frmObligacionesCliente(iIdCliente, sFechaInicio, sFechaTermino);
				MostrarFormulario(_frmObligacionesCliente);
				btnOFVerObligacionesFiscales.Enabled = false;
			}
        }

        private void btnNuevoUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra un formulario para realziar el alta de un nuevo usuario
            AltaUsuario AUsuario = new AltaUsuario();
            MostrarFormulario(AUsuario);
            //btnGuardarUsuario.Enabled       = true;
            btnVerDetallesUsuario.Enabled   = false;
            btnExportarUsuarios.Enabled     = false;
        }

        private void btnConcentradoUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra un formulario con el concentrado de usaurios que administran los sistemas
            ConcentradoUsuarios _frmConcentradoUsuarios = new ConcentradoUsuarios();
            MostrarFormulario(_frmConcentradoUsuarios);
            //btnGuardarUsuario.Enabled       = false;
            btnVerDetallesUsuario.Enabled   = true;
            btnExportarUsuarios.Enabled     = true;
        }

        private void btnVerDirectorioClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra una modal con el directorio de clientes
            frmDirectorio.Show(this);
        }

        private void btnRegistroFacturas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra un formulario para realizar el alta de operaciones
            //LexaSIOOperacionesDispersiones.frmControlOperaciones _frmControlOperaciones = new LexaSIOOperacionesDispersiones.frmControlOperaciones();
            //MostrarFormulario(_frmControlOperaciones);
			LexaSIOOperacionesDispersiones.frmConciliacion _frmConciliacion = new LexaSIOOperacionesDispersiones.frmConciliacion();
			MostrarFormulario(_frmConciliacion);

			btnCargaBatchFacturas.Enabled            = true;
                                                     
            btnVerDetallesFactura.Enabled            = false;
            btnExportarConcentradoFacturas.Enabled   = false;
			btnAsignarFacCon.Enabled				 = false;
			btnActualizarListaPagos.Enabled				 = false;


			btnExportarConcentradoComisiones.Enabled = false;
            //btnPagarComisionSel.Enabled              = false;
            //btnPagarComisionesTod.Enabled            = false;
			btnActualizarListaComisiones.Enabled	 = false;
			btnAsignarIdBancario.Enabled			 = false;

			btnExportarIngrCliente.Enabled           = false;
            btnExportarComisionesVendedores.Enabled  = false;
			btnGenerarLayoutComisiones.Enabled		 = false;

			btnGenerarLayoutDevoluciones.Enabled	 = false;
			btnAsignarIdBancarioDevoluciones.Enabled = false;

			btnExportarDevoluciones.Enabled = false;
			btnActulziarListaDevoluciones.Enabled = false;

			btnExportarReportesOperaciones.Enabled	= false;
			btnActualziarReportes.Enabled			= false;

			//btnExportarClientesInactivos.Enabled     = false;
		}

        private void btnConcentradoFacturas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
			// Muestra un formulario para ver el concentrado de operaciones
			//LexaSIOOperacionesDispersiones.frmComisiones _frmComisiones = new LexaSIOOperacionesDispersiones.frmComisiones();
			//MostrarFormulario(_frmComisiones);

			LexaSIOOperacionesDispersiones.frmPagos _frmPagos = new LexaSIOOperacionesDispersiones.frmPagos();
			MostrarFormulario(_frmPagos);

			btnVerDetallesFactura.Enabled            = true;
            btnExportarConcentradoFacturas.Enabled   = true;
			btnAsignarFacCon.Enabled				 = AUsuarioData.sTipoUsuario.Equals("20071") ? false : true;
			btnActualizarListaPagos.Enabled			 = true;


			btnCargaBatchFacturas.Enabled            = false;

            btnExportarConcentradoComisiones.Enabled = false;
            //btnPagarComisionSel.Enabled              = false;
            //btnPagarComisionesTod.Enabled            = false;
			btnActualizarListaComisiones.Enabled	 = false;
			btnAsignarIdBancario.Enabled			 = false;
                                                     
            btnExportarIngrCliente.Enabled           = false;
            btnExportarComisionesVendedores.Enabled  = false;
			btnGenerarLayoutComisiones.Enabled		 = false;
			btnGenerarLayoutDevoluciones.Enabled	 = false;
			btnAsignarIdBancarioDevoluciones.Enabled = false;

			btnExportarDevoluciones.Enabled = false;
			btnActulziarListaDevoluciones.Enabled = false;

			btnExportarReportesOperaciones.Enabled	= false;
			btnActualziarReportes.Enabled			= false;


			//btnExportarClientesInactivos.Enabled     = false;
		}

        private void btnComisionesBonos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
			// Muestra un formulario para ver el concentrado de comisiones
			//LexaSIOOperacionesDispersiones.frmComisionesPago _frmComisionesPago = new LexaSIOOperacionesDispersiones.frmComisionesPago();
			//MostrarFormulario(_frmComisionesPago);
			LexaSIOOperacionesDispersiones.frmComision _frmComisiones = new LexaSIOOperacionesDispersiones.frmComision();
			MostrarFormulario(_frmComisiones);

			btnCargaBatchFacturas.Enabled            = false;
                                                     
            btnVerDetallesFactura.Enabled            = false;
            btnExportarConcentradoFacturas.Enabled   = false;
			btnAsignarFacCon.Enabled				 = false;
			btnActualizarListaPagos.Enabled				 = false;

            btnExportarConcentradoComisiones.Enabled = true;
            //btnPagarComisionSel.Enabled              = true;
            //btnPagarComisionesTod.Enabled            = true;
			btnActualizarListaComisiones.Enabled	 = true;
			btnAsignarIdBancario.Enabled			 = true;
			btnGenerarLayoutComisiones.Enabled		 = true;

			btnGenerarLayoutDevoluciones.Enabled	 = false;
			btnAsignarIdBancarioDevoluciones.Enabled = false;


			btnExportarIngrCliente.Enabled           = false;
            btnExportarComisionesVendedores.Enabled  = false;
			btnExportarDevoluciones.Enabled = false;
			btnActulziarListaDevoluciones.Enabled = false;

			btnExportarReportesOperaciones.Enabled	= false;
			btnActualziarReportes.Enabled			= false;

			//btnExportarClientesInactivos.Enabled     = false;
		}

        private void btnReportesOperaciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra un formulario que contiene reportes de ingresos de las operaciones
            LexaSIOOperacionesDispersiones.frmReportes _frmReportes = new LexaSIOOperacionesDispersiones.frmReportes();
            MostrarFormulario(_frmReportes);

            btnCargaBatchFacturas.Enabled            = false;
                                                     
                                                     
            btnVerDetallesFactura.Enabled            = false;
            btnExportarConcentradoFacturas.Enabled   = false;
			btnAsignarFacCon.Enabled				 = false;
			btnActualizarListaPagos.Enabled				 = false;

            btnExportarConcentradoComisiones.Enabled = false;
            //btnPagarComisionSel.Enabled              = false;
            //btnPagarComisionesTod.Enabled            = false;
			btnActualizarListaComisiones.Enabled	 = false;
                                                     
            btnExportarIngrCliente.Enabled           = true;
            btnExportarComisionesVendedores.Enabled  = true;

			btnExportarDevoluciones.Enabled = false;
			btnActulziarListaDevoluciones.Enabled = false;

			//btnExportarClientesInactivos.Enabled     = false;
		}

        private void btnAsignarObligacionesFiscales_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra un formulario para realizar la asignacipon de obligaciones fiscales a los nuevos clientes
            LexaSIOConta.frmAsignarObligaciones _frmAsignarObligaciones = new LexaSIOConta.frmAsignarObligaciones();
            MostrarFormulario(_frmAsignarObligaciones);
        }

        private void btnClientesInactivos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra un formulario con un listado de clientes inactivos
            LexaSIOOperacionesDispersiones.frmClientesInactivos _ClientesInactivos = new LexaSIOOperacionesDispersiones.frmClientesInactivos();
            MostrarFormulario(_ClientesInactivos);

            btnCargaBatchFacturas.Enabled            = false;
                                                     
            btnVerDetallesFactura.Enabled            = false;
            btnExportarConcentradoFacturas.Enabled   = false;

            btnExportarConcentradoComisiones.Enabled = false;
            //btnPagarComisionSel.Enabled              = false;
            //btnPagarComisionesTod.Enabled            = false;
                                                     
            btnExportarIngrCliente.Enabled           = false;
            btnExportarComisionesVendedores.Enabled  = false;
                                                     
            //btnExportarClientesInactivos.Enabled     = false;
        }

        private void btnCargaBatchFacturas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Muestra una modal para realizar el alta de operaciones de forma masiva
            LexaSIOOperacionesDispersiones.frmOperacionesCargaBatch.Show();
        }

        private void btnBonos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LexaSIOOperacionesDispersiones.frmBonos _frmBonos = new LexaSIOOperacionesDispersiones.frmBonos();
            MostrarFormulario(_frmBonos);
			btnAsignarFacCon.Enabled				 = false;
			btnActualizarListaPagos.Enabled				 = false;
			btnActualizarListaComisiones.Enabled	 = false;

			btnExportarDevoluciones.Enabled = false;
			btnActulziarListaDevoluciones.Enabled = false;
			btnAsignarIdBancario.Enabled			 = false;
			btnGenerarLayoutComisiones.Enabled		 = false;
			btnGenerarLayoutDevoluciones.Enabled	 = false;
			btnAsignarIdBancarioDevoluciones.Enabled = false;

			btnExportarReportesOperaciones.Enabled	= false;
			btnActualziarReportes.Enabled			= false;
		}

        private void btnExportarBonos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LexaSIOOperacionesDispersiones.frmBonos _frmBonos = Application.OpenForms["frmBonos"] as LexaSIOOperacionesDispersiones.frmBonos;
            if (_frmBonos != null)
                _frmBonos.Exportar();
        }

        private void btnPremios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LexaSIOOperacionesDispersiones.frmPremios _frmPremios = new LexaSIOOperacionesDispersiones.frmPremios();
            MostrarFormulario(_frmPremios);

			btnAsignarFacCon.Enabled				 = false;
			btnActualizarListaPagos.Enabled				 = false;
			btnActualizarListaComisiones.Enabled	 = false;

			btnExportarDevoluciones.Enabled = false;
			btnActulziarListaDevoluciones.Enabled = false;
			btnAsignarIdBancario.Enabled			 = false;
			btnGenerarLayoutComisiones.Enabled		 = false;
			btnGenerarLayoutDevoluciones.Enabled	 = false;
			btnAsignarIdBancarioDevoluciones.Enabled = false;

			btnExportarReportesOperaciones.Enabled	= false;
			btnActualziarReportes.Enabled			= false;
		}

        private void btnExportarPremios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LexaSIOOperacionesDispersiones.frmPremios _frmPremios = Application.OpenForms["frmPremios"] as LexaSIOOperacionesDispersiones.frmPremios;
            if (_frmPremios != null)
                _frmPremios.Exportar();
        }

        #endregion

        #region Eventos y Funciones
        private void btnCEditarCliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Evento para habilitar la edición de información de un cliente
            AltaCliente frmAC = Application.OpenForms["AltaCliente"] as AltaCliente;
            if (frmAC != null)
            {
                if (frmAC.btnEditar.Enabled == true)
                {
                    frmAC.EditarCliente();
                    btnCEditarCliente.Enabled        = false;
                    btnCGuardarInfo.Enabled          = true;
                    frmAC.btnCancelarEdicion.Enabled = true;
                }
            }
        }

        private void btnCGuardarInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Evento para guardar la información de un cliente
            AltaCliente frmAC = Application.OpenForms["AltaCliente"] as AltaCliente;
            if (frmAC != null)
            {
                if (frmAC.btnGuardar.Visible == true)
                    frmAC.Guardar();
                else if (frmAC.btnPreGuardar.Visible == true)
                    frmAC.PreGuardar();
            }
        }

        private void btnCConfirmarCancelarServicio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Evento para confirmar la cancelación del servicio de un cliente
            FCancelarServicio frmCancelarServicio = Application.OpenForms["FCancelarServicio"] as FCancelarServicio;
            if (frmCancelarServicio != null)
                frmCancelarServicio.cancelarServicio();
        }

        private void btnVerDetallesUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Evento para mostrar los detalles de un usuario en el contrado de estos
            ConcentradoUsuarios frmConcentradoUsuarios = Application.OpenForms["ConcentradoUsuarios"] as ConcentradoUsuarios;
            if (frmConcentradoUsuarios != null)
                frmConcentradoUsuarios.obtenerInformacionUsuario();
        }

        private void btnExportarUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Evento para exporta un listado de usuarios registrados
            ConcentradoUsuarios frmConcentradoUsuarios = Application.OpenForms["ConcentradoUsuarios"] as ConcentradoUsuarios;
            if (frmConcentradoUsuarios != null)
                frmConcentradoUsuarios.exportar();
        }        

        private void btnRegLlamada_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Evento para realizar el registro de una nueva llamada
            RegistrarLlamada _RegistrarLlamada = Application.OpenForms["RegistrarLlamada"] as RegistrarLlamada;
            if (_RegistrarLlamada != null)
                _RegistrarLlamada.btnRegLlamada_Click(sender, e);
        }

        private void btnAgregarArchivo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Evento para realizar el alta de un nuevo archivo en el expediente en línea
            LexaSIOConta.frmExpedienteLineaClientes _ExpedienteLinea = Application.OpenForms["frmExpedienteLineaClientes"] as LexaSIOConta.frmExpedienteLineaClientes;
            if (_ExpedienteLinea != null)
                _ExpedienteLinea.btnNuevo_Click(sender, e);
        }

        private void btnNuevaCarpeta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Evento para realizar el alta de un nueva carpeta en el expediente en línea
            LexaSIOConta.frmExpedienteLineaClientes _ExpedienteLinea = Application.OpenForms["frmExpedienteLineaClientes"] as LexaSIOConta.frmExpedienteLineaClientes;
            if (_ExpedienteLinea != null)
                _ExpedienteLinea.NuevaCarpeta();
        }

        private void btnVerDetallesFactura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Evento para mostrar los detalles de una operacion
            LexaSIOOperacionesDispersiones.frmComisiones _frmComisiones = Application.OpenForms["frmComisiones"] as LexaSIOOperacionesDispersiones.frmComisiones;
            if (_frmComisiones != null)
                _frmComisiones.btnMostrarPagadas_Click(sender, e);
        }

        private void btnExportarConcentradoFacturas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Evento para exportar un listado de operaciones
			LexaSIOOperacionesDispersiones.frmPagos _frmPagos= Application.OpenForms["frmPagos"] as LexaSIOOperacionesDispersiones.frmPagos;
			if (_frmPagos != null)
				_frmPagos.ExportarLista();
		}

        private void btnExportarConcentradoComisiones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
			LexaSIOOperacionesDispersiones.frmComision _frmComision = Application.OpenForms["frmComision"] as LexaSIOOperacionesDispersiones.frmComision;
			if (_frmComision != null)
				_frmComision.Exportar();
		}

        private void btnExportarIngrCliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Evento para exportar un reporte de los ingresos
            LexaSIOOperacionesDispersiones.frmReportes _frmReportes = Application.OpenForms["frmReportes"] as LexaSIOOperacionesDispersiones.frmReportes;
            if (_frmReportes != null)
                _frmReportes.btnExportarIngrCliente_Click(sender, e);
        }

        private void btnExportarComisionesVendedores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Evento para exporta un listado de egresos por comisiones
            LexaSIOOperacionesDispersiones.frmReportes _frmReportes = Application.OpenForms["frmReportes"] as LexaSIOOperacionesDispersiones.frmReportes;
            if (_frmReportes != null)
                _frmReportes.btnExportarComisionesVendedores_Click(sender, e);
        }                     

        private void btnCerrarSesion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FlatMessageBox.Show("¿Está seguro que desea cerrar sesión?", "SI", "NO", FlatMessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Start a new instance of the current program
                System.Diagnostics.Process.Start(Application.ExecutablePath);

                //close the current application process
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }
        
        private void btnPagarBono_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LexaSIOOperacionesDispersiones.frmBonos _frmBonos = Application.OpenForms["frmBonos"] as LexaSIOOperacionesDispersiones.frmBonos;
            if (_frmBonos != null)
                _frmBonos.PagarBono();
        }

		private void btnRecordatorios_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
            //LexaSIOConta.frmRecordatorios.Show(AUsuarioData.sNombre);
            LexaSIOConta.frmReminders _Reminders = new LexaSIOConta.frmReminders();
            _Reminders.Owner = this;
            _Reminders.ShowDialog();
        }

		private void btnObligacionesRecordatorios_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			btnOFVerObligacionesFiscales.Enabled = false;
			LexaSIOConta.frmObligacionesRecordatorios _frmObligacionesRecordatorios = new LexaSIOConta.frmObligacionesRecordatorios();
			MostrarFormulario(_frmObligacionesRecordatorios);
		}

		private void btnObligacionesUnicas_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			btnOFVerObligacionesFiscales.Enabled = false;
			LexaSIOConta.frmObligacionesUnicas _frmObligacionesUnicas = new LexaSIOConta.frmObligacionesUnicas();
			MostrarFormulario(_frmObligacionesUnicas);
		}

		private void btnAsignarFacCon_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmAsignarFacCon.Show();
		}

		private void btnActualizarLista_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmPagos _Pagos = Application.OpenForms["frmPagos"] as LexaSIOOperacionesDispersiones.frmPagos;
			if (_Pagos != null)
				_Pagos.cargarPagos();
		}

		private void btnActualizarListaComisiones_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmComision _Comisiones = Application.OpenForms["frmComision"] as LexaSIOOperacionesDispersiones.frmComision;
			if (_Comisiones != null)
				_Comisiones.InitializeComisiones(int.Parse(_Comisiones.cmbxAnio.Text), int.Parse(_Comisiones.cmbxSemDesde.Text), int.Parse(_Comisiones.cmbxSemHasta.Text));
		}

		private void btnDevoluciones_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmAlimentos _Alimentos = new LexaSIOOperacionesDispersiones.frmAlimentos();
			MostrarFormulario(_Alimentos);
			btnExportarDevoluciones.Enabled				= true;
			btnActulziarListaDevoluciones.Enabled		= true;
			btnAsignarIdBancario.Enabled				= false;
			btnGenerarLayoutComisiones.Enabled			= false;
			btnExportarConcentradoComisiones.Enabled	= false;
			btnActualizarListaComisiones.Enabled		= false;

			btnGenerarLayoutDevoluciones.Enabled		= true;
			btnAsignarIdBancarioDevoluciones.Enabled	= true;

			btnExportarReportesOperaciones.Enabled		= false;
			btnActualziarReportes.Enabled				= false;
		}

		private void btnExportarDevoluciones_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmAlimentos _Alimentos = new LexaSIOOperacionesDispersiones.frmAlimentos();
			if (_Alimentos != null)
				_Alimentos.Exportar();
		}

		private void btnActulziarListaDevoluciones_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmAlimentos _Alimentos = Application.OpenForms["frmAlimentos"] as LexaSIOOperacionesDispersiones.frmAlimentos;
			if (_Alimentos != null)
				_Alimentos.InitializeDevoluciones(int.Parse(_Alimentos.cmbxAnio.Text), int.Parse(_Alimentos.cmbxSemDesde.Text), int.Parse(_Alimentos.cmbxSemanas.Text));
		}

		private void btnHistorialDeclaraciones_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			//LexaSIOConta.frmHistorialDeclaraciones _HistorialDeclaraciones = new LexaSIOConta.frmHistorialDeclaraciones();
			//MostrarFormulario(_HistorialDeclaraciones);
			LexaSIOConta.frmClients _Clients = Application.OpenForms["frmClients"] as LexaSIOConta.frmClients;
			if (_Clients != null)
			{
				string sCliente = _Clients.gridView1.GetFocusedRowCellValue("sCliente").ToString();
				LexaSIOConta.frmHistorialDeclaraciones.Show(sCliente);
			}
		}

		private void btnAsignarIdBancManualComisiones_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmComision _Comision = Application.OpenForms["frmComision"] as LexaSIOOperacionesDispersiones.frmComision;
			if (_Comision != null)
				_Comision.AsignarComisionista();
		}

		private void btnAsignarIdBancBatchComisiones_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmComisionAsigIdBancBat.Show();
		}

		private void btnLayoutComisiones1_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmComision _Comision = Application.OpenForms["frmComision"] as LexaSIOOperacionesDispersiones.frmComision;
			if (_Comision != null)
				_Comision.GenerarLayout(1);
		}

		private void btnLayoutComisiones2_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmComision _Comision = Application.OpenForms["frmComision"] as LexaSIOOperacionesDispersiones.frmComision;
			if (_Comision != null)
				_Comision.GenerarLayout(2);
		}

		private void btnLayoutDevoluciones1_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmAlimentos _Devolucion = Application.OpenForms["frmAlimentos"] as LexaSIOOperacionesDispersiones.frmAlimentos;
			if (_Devolucion != null)
				_Devolucion.GenerarLayout(1);
		}

		private void btnLayoutDevoluciones2_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmAlimentos _Devolucion = Application.OpenForms["frmAlimentos"] as LexaSIOOperacionesDispersiones.frmAlimentos;
			if (_Devolucion != null)
				_Devolucion.GenerarLayout(2);
		}

		private void btnAsignarIdBancManualDevoluciones_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmAlimentos _Devoluciones = Application.OpenForms["frmAlimentos"] as LexaSIOOperacionesDispersiones.frmAlimentos;
			if (_Devoluciones != null)
				_Devoluciones.AsignarCliente();
		}

		private void btnAsignarIdBancBatchDevoluciones_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		private void btnRepOpera_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmReportesOperaciones _ReportesOperaciones = new LexaSIOOperacionesDispersiones.frmReportesOperaciones();
			MostrarFormulario(_ReportesOperaciones);

			btnExportarReportesOperaciones.Enabled	= true;
			btnActualziarReportes.Enabled			= true;
		}

		private void btnExportarReportesOperaciones_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmReportesOperaciones _ReportesOperaciones = Application.OpenForms["frmReportesOperaciones"] as LexaSIOOperacionesDispersiones.frmReportesOperaciones;
			if (_ReportesOperaciones != null)
				_ReportesOperaciones.Exportar();
		}

		private void btnActualziarReportes_ItemClick(Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LexaSIOOperacionesDispersiones.frmReportesOperaciones _ReportesOperaciones = Application.OpenForms["frmReportesOperaciones"] as LexaSIOOperacionesDispersiones.frmReportesOperaciones;
			if (_ReportesOperaciones != null)
				_ReportesOperaciones.InitializeControls();
		}
        #endregion

        private void btnNuevaSolicitudJuridico_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ControlActividadesJuridico.FBandeja _Bandeja = Application.OpenForms["FBandeja"] as ControlActividadesJuridico.FBandeja;
            if (_Bandeja != null)
                _Bandeja.btnNewSolicitud_Click(sender, e);
        }

        private void btnNuevoProspecto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProspectosAlta _ProspectosAlta = new frmProspectosAlta();
            _ProspectosAlta.ShowDialog();
        }

        private void btnVerProspectos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProspectos _Prospectos = new frmProspectos();
            MostrarFormulario(_Prospectos);
        }

        private void btnProspectosInactivos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProspectosInactivos _ProspectosInactivos = new frmProspectosInactivos();
            MostrarFormulario(_ProspectosInactivos);
        }

        private void btnCargaMasivaProspectos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProspectosAltaMasiva _ProspectosAltaMasiva = new frmProspectosAltaMasiva();
            _ProspectosAltaMasiva.ShowDialog();
        }

        private void btnActivarProspecto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProspectosInactivos _ProspectosInactivos = Application.OpenForms["frmProspectosInactivos"] as frmProspectosInactivos;
            if (_ProspectosInactivos != null)
                _ProspectosInactivos.ReactiveProsp();
        }

        private void btnActivarTodosProspectos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProspectosInactivos _ProspectosInactivos = Application.OpenForms["frmProspectosInactivos"] as frmProspectosInactivos;
            if (_ProspectosInactivos != null)
                _ProspectosInactivos.ReactiveAllProsp();
        }

        private void btnHistorialPospectos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProspectoHistorialDetalle _Historial = new frmProspectoHistorialDetalle();
            _Historial.ShowDialog();
        }

        private void btnActualizarExp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Evento para actualizar el expediente en línea
            LexaSIOConta.frmExpedienteLineaClientes _ExpedienteLinea = Application.OpenForms["frmExpedienteLineaClientes"] as LexaSIOConta.frmExpedienteLineaClientes;
            if (_ExpedienteLinea != null)
                _ExpedienteLinea.UpdateList();
        }

        private void btnShowPhoneMinBar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowPhone();
        }

        private void btnCitasAgendadas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCitasAgendadas _CitasAgendadas = new frmCitasAgendadas();
            _CitasAgendadas.ShowDialog();
        }

        private void btnHistorialLlamada_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHistorialLlamadas _HistorialLlamadas = new frmHistorialLlamadas();
            _HistorialLlamadas.ShowDialog();
        }
    }
}
