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
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using LogicaCC;

namespace LxCallcenter.LexaSIOConta
{
    public partial class frmEditarDeclaracion : Form
    {
        UsuarioData                    AUsuario;
        LogicaCC.LexaSIOContaLogica.Cliente Cliente = null;
        public List<DeclaracionEstado> declaraciones;
        public static int    iIdCliente;
        public static string sCliente;
        public int           iIdDeclaracion;
        

		public frmEditarDeclaracion()
		{
			InitializeComponent();
		}

		static frmEditarDeclaracion _EditarDeclaracion;
		static DialogResult _DialogResult = DialogResult.No;

		public static DialogResult Show(int iIdCliente)
		{
			_EditarDeclaracion = new frmEditarDeclaracion();
            _EditarDeclaracion.StartPosition = FormStartPosition.CenterScreen;

            _EditarDeclaracion.AUsuario = UsuarioData.Instancia;
			_EditarDeclaracion.Cliente = new LogicaCC.LexaSIOContaLogica.Cliente().InformacionCliente(iIdCliente);
			_EditarDeclaracion.InicializeControls();

			_DialogResult = DialogResult.No;

			_EditarDeclaracion.Activate();
			_EditarDeclaracion.ShowDialog();
			return _DialogResult;
		}

        #region EVENTOS
        private void cbEstadoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            //VALIDA SI ESTADO DE PAGO ESTA EN ESTADO "PAGADA"
            if (cbEstadoPago.SelectedIndex == 3)
            {
                txtRutaArchivo.Visible  = true;
                dtFechaPago.Visible     = true;
                materialLabel6.Visible  = true;
            }
            else
            {
                txtRutaArchivo.Visible  = false;
                dtFechaPago.Visible     = false;
                materialLabel6.Visible  = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //REALIZA BUSQUEDA DE DECLARIONES PENDIENTES DE UN CLIENTE
                pnlDeclaraciones.Controls.Clear();
                cargarDeclaraciones(Cliente.iIdCliente);
            }
            catch (Exception)
            {
                FlatMessageBox.Show(string.Format("El cliente que intentas buscar, aun no tiene{0}obligaciones fiscales asignadas, contacte{1}con sus supervisor.", Environment.NewLine, Environment.NewLine), "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
            }          
        }

        private void BtnDeclaracion_Click(object sender, EventArgs e)
		{
			//EVENTO CLICK, PARA SELECCIONAR Y MOSTRAR LA INFORMACIÓN DE LA DECLARACIÓN
			btnGuardar.Enabled		= true;
			Button btnDeclaracion   = sender as Button;
            iIdDeclaracion          = int.Parse(btnDeclaracion.Name);
            seleccionDeclaracion(int.Parse(btnDeclaracion.Name));
            cbEstadoPago.Focus();
        }

        /// <summary>
        /// Cambia la propiedad Enabled de los controles en el formulario
        /// </summary>
        /// <param name="bEstado"></param>
        private void EstadoControles(bool bEstado)
        {
            pnlDeclaraciones.Enabled = bEstado;
            txbLlavePago.Enabled     = bEstado;
            dtFechaPago.Enabled      = bEstado;
            txtRutaArchivo.Enabled   = bEstado;
            btnGuardar.Enabled       = bEstado;
            btnCancelar.Enabled      = bEstado;
            lnkCerrar.Enabled        = bEstado;
        }

        string sEstadoPagoTx;
        int iEstadoPago;
        string sLlavePag;
        DateTime? dtFechaPa;

        string sDecTipo;
        string sDecTipoTx;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FlatMessageBox.Show("¿Está seguro de cambiar el estado de" + Environment.NewLine + "pago de esta declaración?", "SI", "NO", FlatMessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Cambiamos el estado de los controles
                EstadoControles(false);
                btnGuardar.Visible  = false;
                pgbCarga.Visible    = true;

                // Recogemos la información de la declaración en variables
                sEstadoPagoTx = cbEstadoPago.Text;
                iEstadoPago   = cbEstadoPago.SelectedIndex;
                sLlavePag     = txbLlavePago.Text;
                dtFechaPa     = dtFechaPago.Value;
                sDecTipo      = txtDecTipo.Name.ToString();
                sDecTipoTx    = txtDecTipo.Text;

                if (openFileDialogDocumento.FileName != string.Empty && sLlavePag != string.Empty)
                {
                    if (sEstadoPagoTx == "PAGADA" || sEstadoPagoTx == "Pagada")
                    {
                        

                        // Inciamos el guardado de la declaración
                        bgwDeclaracion.RunWorkerAsync();
                    }
                    else
                    {
                        //SE GUARDA EL ESTADO DE LA DECLARACIÓN
                        new DeclaracionEstado().UpdateDeclaracion(iIdDeclaracion, iEstadoPago + 1, string.Empty, null);
                    }
                }
                else
                {
                    FlatMessageBox.Show("No se ha seleccionado un archivo o no ha ingresado la llave de pago.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _DialogResult = DialogResult.No;
            _EditarDeclaracion.Close();
        }

        private void txtRutaArchivo_Click(object sender, EventArgs e)
        {
            openFileDialogDocumento.Title    = "Subir Archivos";
            openFileDialogDocumento.FileName = "";

            if (openFileDialogDocumento.ShowDialog() == DialogResult.OK)
            {
                txtRutaArchivo.Text = Path.GetFileName(openFileDialogDocumento.FileName);
                metroToolTip1.SetToolTip(txtRutaArchivo, openFileDialogDocumento.FileName);
            }
        }
        #endregion

        #region FUNCIONES
        /// <summary>
        /// Inicializa el contenido de los controles que se cargaran por primera vez
        /// </summary>
        private void InicializeControls()
		{
            lblNombre.Text = Cliente.sNombre + " " +
							 Cliente.sAPaterno + " " +
							 Cliente.sAMaterno;
			sCliente	   = Cliente.sCliente;
			cargarDeclaraciones(Cliente.iIdCliente);

            //CARGAMOS LA LISTA DE ESTADOS EN EL COMBOBOX
            cbEstadoPago.DataSource    = new DeclaracionEstado().listaDeclaracionEstado();
            cbEstadoPago.DisplayMember = "sDeclaracionEstado";
            cbEstadoPago.ValueMember   = "iIdDeclaracionEstado";
        }

        /// <summary>
        /// Carga el listado de declaraciones y los muestra en controles
        /// </summary>
        /// <param name="iIdCliente"></param>
        public void cargarDeclaraciones(int iIdCliente)
        {
            //REALIZA BÚSQUEDA DE DECLARACIONES DE UN CLIENTE EN ESPECIFICO
            DeclaracionEstado declaracionEstado = new DeclaracionEstado();
            declaraciones = declaracionEstado.listaDeclaracion(iIdCliente);

            if(declaraciones.Count > 0)
            { 
                //SE CREA UNA LISTA DINAMICA DE DECLARACIONES PEDIENTES
                for (int i = 0; i < declaraciones.Count; i++)
                {
                    Button btnDeclaracion                               = new Button();
                    btnDeclaracion.Location                             = new Point(1, 24 * i + 0);
                    btnDeclaracion.Name                                 = declaraciones[i].iIdDeclaracionTipo.ToString();
                    btnDeclaracion.Text                                 = declaraciones[i].sDeclaracionTipo;
                    btnDeclaracion.Width                                = pnlDeclaraciones.Width - 1;//260, 40
                    btnDeclaracion.Height                               = 23;
                    btnDeclaracion.FlatStyle                            = FlatStyle.Flat;
                    btnDeclaracion.FlatAppearance.BorderSize            = 0;
                    btnDeclaracion.FlatAppearance.MouseOverBackColor    = Color.FromArgb(236, 239, 241);//33, 69, 129// 246, 164, 0
                    btnDeclaracion.TextAlign                            = ContentAlignment.MiddleLeft;
                    btnDeclaracion.Font                                 = new Font("Arial", 9, FontStyle.Regular);
                    btnDeclaracion.ForeColor                            = Color.Black;//.FromArgb(105, 105, 105);
                    btnDeclaracion.Cursor                               = Cursors.Hand;
                    //Creamos el evento Click del boton
                    btnDeclaracion.Click += BtnDeclaracion_Click;

                    Button btnEstado     = new Button();
                    btnEstado.Location   = new Point(0, 24 * i + 0);
                    btnEstado.Width      = 3;
                    btnEstado.Height     = 23;
                    btnEstado.BackColor  = Color.FromArgb(63, 81, 181);
                    btnEstado.Text       = "";
                    btnEstado.FlatStyle  = FlatStyle.Flat;
                    btnEstado.FlatAppearance.BorderSize = 0;
                    btnEstado.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 81, 181);
                    btnEstado.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 81, 181);

                    pnlDeclaraciones.Controls.Add(btnEstado);
                    pnlDeclaraciones.Controls.Add(btnDeclaracion);
                }
            }
            else
            {
                FlatMessageBox.Show(string.Format("No se encontraron declaraciones pendientes{0}para este cliente.", Environment.NewLine), "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Método Público para mostrar la información de una declaración en los controles.
        /// </summary>
        /// <param name="declaracion">ID de la declaración</param>
        private void seleccionDeclaracion(int declaracion)
        {
            //SE OBTIENE LA INFORMACIÓN DE LAS OBLIGACIONES
            DeclaracionEstado declaracionEstado = new DeclaracionEstado().informacionDeclaracion(declaracion);
            //ASIGNA LA INFORMACIÓN A LOS CONTROLES
            txbAño.Text                 = declaracionEstado.iAnioDeclaracion.ToString();
            dpFPresentacion.Value       = DateTime.Parse(declaracionEstado.sFechaPresentacion);
            txbMonto.Text               = FormatToMoney(declaracionEstado.sMonto);
            dpFechaPago.Value           = DateTime.Parse(declaracionEstado.sFechaLimitePago);
            cbEstadoPago.SelectedIndex  = declaracionEstado.iIdDeclaracionEstado - 1;
            txtDecTipo.Text             = declaracionEstado.sDeclaracionTipo;
            txtDecTipo.Name             = declaracionEstado.iIdDeclaracionTipo.ToString();
            txtPeriodo.Text             = declaracionEstado.sPeriodoDeclaracion;
            txbNumOperacion.Text        = declaracionEstado.sNumOperacion;
            txbLlavePago.Text           = declaracionEstado.sLlavePago;
            txbLCaptura.Text            = declaracionEstado.sLineaCaptura;
            txtTipoDeclaracion.Text     = declaracionEstado.sDeclaracionModo;

            grdConceptos.AutoGenerateColumns = false;
            grdConceptos.DataSource = new LogicaCC.LexaSIOContaLogica.RegistroConcepto().lConceptosRegistrados(declaracion);
        }

        /// <summary>
        /// Limpia y pone los controles en estado inicial
        /// </summary>
        private void LimpiarControles()
        {
            txbAño.Text             = "";
            txbMonto.Text           = "";
            txbNumOperacion.Text    = "";
            txbLlavePago.Text       = "";
            txbLCaptura.Text        = "";
            txtTipoDeclaracion.Text = "";
            txtDecTipo.Text         = "";
            txtPeriodo.Text         = "";
            dpFPresentacion.Text    = DateTime.Now.ToString();
            dpFechaPago.Text        = DateTime.Now.ToString();
            txtRutaArchivo.Text     = "";
            dtFechaPago.Visible     = false;
            materialLabel6.Visible  = false;
            txtRutaArchivo.Visible  = false;
            openFileDialogDocumento.FileName = "";
            cbEstadoPago.SelectedIndex = 0;
            sEstadoPagoTx   = "";
            iEstadoPago     = 0;
            sLlavePag       = "";
            dtFechaPa       = DateTime.Now;
            sDecTipo        = "";
            sDecTipoTx      = "";

            List<DeclaracionEstado> ListEmpty = new List<DeclaracionEstado>();
            DeclaracionEstado itemEmpty = new DeclaracionEstado();
            ListEmpty.Add(itemEmpty);
            grdConceptos.DataSource = ListEmpty;

            EstadoControles(true);
        }

        /// <summary>
		/// Realiza la carga del archivo de pago de la declaración en el servidor
		/// </summary>
		public void cargarArchivos(int iIdDeclaracion)
        {
            //VALIDA SI ESTADO DE PAGO ESTA EN "PAGADA"
            if (iEstadoPago == 3)
            {
                try
                {
                    // VALIDA SI LOS DIRECTORIO EXISTEN, SI NO, SE CREAN LAS CARPETAS
                    FTPServer.CreateDirectory(FTPCredentials.Path, FTPCredentials.User, FTPCredentials.Password, string.Format(@"{0}/04. Declaraciones, acuses y pagos de impuestos federales/Pagos/{1}/{2}/", _EditarDeclaracion.Cliente.sCliente, sDecTipoTx, DateTime.Now.ToString("dd-MM-yyyy")));

                    //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO
                    int i = FTPServer.CountFileList(FTPCredentials.Path, FTPCredentials.User, FTPCredentials.Password, string.Format(@"{0}/04. Declaraciones, acuses y pagos de impuestos federales/Pagos/{1}/{2}/", _EditarDeclaracion.Cliente.sCliente, sDecTipoTx, DateTime.Now.ToString("dd-MM-yyyy")));

                    //COPIA Y CAMBIA EL NOMBRE DE LOS ARCHIVO SELECCIONADOS EN EL CONTROL OPENFILEDIALOG
                    foreach (string fileName in openFileDialogDocumento.FileNames)
                    {
                        //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
                        i++;
                        string FullPath = string.Format("{0}/{1}/{2}/04. Declaraciones, acuses y pagos de impuestos federales/Pagos/{3}/{4}", FTPCredentials.Path, ConnectionString.FolderConnection, _EditarDeclaracion.Cliente.sCliente, sDecTipoTx, DateTime.Now.ToString("dd-MM-yyyy"));
                        FTPServer.Upload(FullPath, FTPCredentials.User, FTPCredentials.Password, Path.GetFileName(fileName), fileName);
                        FTPServer.RenameFile(FullPath, FTPCredentials.User, FTPCredentials.Password, Path.GetFileName(fileName), i.ToString() + DateTime.Now.ToString("ddMMyyyy") + Path.GetExtension(fileName));

                        //GUARDA UN REGISTRO DE LA RUTA DONDE SE GUARDO EL ARCHIVO
                        new Adjunto().insertarAdjunto(new Adjunto()
                        {
                            iIdDeclaracion          = iIdDeclaracion,
                            iIdRegistroObligacion   = int.Parse(sDecTipo),
                            iIdCliente              = Cliente.iIdCliente,
                            sAdjunto                = string.Format("{0}/{1}/{2}/04. Declaraciones, acuses y pagos de impuestos federales/Pagos/{3}/{4}/{5}", FTPCredentials.Path, ConnectionString.FolderConnection, _EditarDeclaracion.Cliente.sCliente, sDecTipoTx, DateTime.Now.ToString("dd-MM-yyyy"), i.ToString() + DateTime.Now.ToString("ddMMyyyy") + Path.GetExtension(fileName))
                        });
                    }
                }
                catch (Exception)
                {
                }
            }
     //       //VALIDA SI ESTADO DE PAGO ESTA EN "PAGADA"
     //       if (iEstadoPago == 3)
     //       {
     //           try
     //           {
					////VALIDA SI LOS DIRECTORIO EXISTEN, SI NO, SE CREAN LAS CARPETAS
					//if (!Directory.Exists(@"\\192.168.1.34\\Documentos\\" + LogicaCC.ConnectionString.FolderConnection + "\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04. Declaraciones, acuses y pagos de impuestos federales\\Pagos\\" + txtDecTipo.Text + "\\" + DateTime.Now.ToString("dd-MM-yyyy")))
					//	Directory.CreateDirectory(@"\\192.168.1.34\\Documentos\\" + LogicaCC.ConnectionString.FolderConnection + "\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04. Declaraciones, acuses y pagos de impuestos federales\\Pagos\\" + txtDecTipo.Text + "\\" + DateTime.Now.ToString("dd-MM-yyyy"));

     //               //CUENTA EL NÚMERO DE ARCHIVOS EN EL DIRECTORIO
     //               var fileCount = (from file in Directory.EnumerateFiles(@"\\192.168.1.34\\Documentos\\" + LogicaCC.ConnectionString.FolderConnection + "\\Documentos\\Clientes\\" + iIdCliente + "\\" + "Declaraciones" + "\\" + txtDecTipo.Name + "\\" + DateTime.Now.ToString("dd-MM-yyyy")) select file).Count();
     //               int i = fileCount - 1;

     //               //GUARDA LOS ARCHIVOS SELECCIONADOS EN EL CONTROL OPENFILEDIALOG
     //               foreach (string fileName in openFileDialogDocumento.FileNames)
     //               {
     //                   //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
     //                   i++;
     //                   File.Copy(fileName, @"\\192.168.1.34\\Documentos\\" + LogicaCC.ConnectionString.FolderConnection + "\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04. Declaraciones, acuses y pagos de impuestos federales\\Pagos\\" + txtDecTipo.Text + "\\" + DateTime.Now.ToString("dd-MM-yyyy") + "\\" + Path.GetFileName(fileName));
     //                   File.Move(@"\\192.168.1.34\\Documentos\\" + LogicaCC.ConnectionString.FolderConnection + "\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04. Declaraciones, acuses y pagos de impuestos federales\\Pagos\\" + txtDecTipo.Text + "\\" + DateTime.Now.ToString("dd-MM-yyyy") + "\\" + Path.GetFileName(fileName), @"\\192.168.1.34\\Documentos\\" + LogicaCC.ConnectionString.FolderConnection + "\\Documentos\\Clientes\\" + sCliente + "\\" + "Expediente en Linea\\04. Declaraciones, acuses y pagos de impuestos federales\\Pagos\\" + txtDecTipo.Text + "\\" + DateTime.Now.ToString("dd-MM-yyyy") + "\\" + i + DateTime.Now.ToString("ddMMyyyy") + Path.GetExtension(fileName));

     //                   //SE GUARDA REGISTRO DEL ADJUNTO DEN LA BD
     //                   new Adjunto().insertarAdjunto(new Adjunto()
     //                   {
     //                       iIdDeclaracion        = iIdDeclaracion,
     //                       iIdRegistroObligacion = int.Parse(txtDecTipo.Name.ToString()),
     //                       iIdCliente            = iIdCliente,
     //                       sAdjunto              = @"\\192.168.1.34\\Documentos\\" + LogicaCC.ConnectionString.FolderConnection + "\\Documentos\\Clientes\\" + iIdCliente + "\\" + "Declaraciones" + "\\" + txtDecTipo.Name + "\\" + DateTime.Now.ToString("dd-MM-yyyy") + "\\" + i + DateTime.Now.ToString("ddMMyyyy") + Path.GetExtension(fileName)
     //                   });
     //               }

     //               //SE INICIALIZA AL APARTADO PARA SUBIR ARCHIVOS
     //               txtRutaArchivo.Text              = string.Empty;
     //               openFileDialogDocumento.FileName = "";
     //           }
     //           catch (Exception)
     //           {
     //           }
     //       }
        }

        /// <summary>
        /// Método Público para escribir un log de los cambios de los archivos del expediente en linea
        /// </summary>
        /// <param name="strMessage">Mensaje que se guardara en el log.</param>
        public void EscribirLog(string strMessage)
        {
			//VALIDACIÓN SI EL ARCHIVO EXISTE
			if (!File.Exists(@"\\192.168.1.34\\Documentos\\" + LogicaCC.ConnectionString.FolderConnection + "\\Documentos\\Clientes\\" + sCliente + "\\" + @"Expediente en Linea\Log.txt"))
			{
			    var myFile = File.Create(@"\\192.168.1.34\\Documentos\\" + LogicaCC.ConnectionString.FolderConnection + "\\Documentos\\Clientes\\" + sCliente + "\\" + @"Expediente en Linea\Log.txt");
			    myFile.Close();
			}

			//RUTA DE ACCESO DEL ARCHIVO LOG
			string logFile = @"\\192.168.1.34\Documentos\\" + LogicaCC.ConnectionString.FolderConnection + @"\Documentos\Clientes\" + sCliente + @"\Expediente en Linea\Log.txt";

			//APLICA FORMATO AL LOG Y ESCRIBE EL MENSAJE QUE SE PASA EN EL PARAMETRO STRMENSAJE.
			string line = string.Format("{0} | {1} | ", DateTime.Now, AUsuario.sIdusuario);
			line += strMessage;
			FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
			StreamWriter swFromFileStream = new StreamWriter(fs);
			swFromFileStream.WriteLine(line);
			swFromFileStream.Flush();
			swFromFileStream.Close();
        }

        /// <summary>
        /// Retorna un monto en tipo cadena a moneda con formato
        /// </summary>
        /// <param name="sImport"></param>
        /// <returns></returns>
        public string FormatToMoney(string sImport)
        {
            return decimal.Parse(sImport).ToString("C2");
        }

        #endregion




        private void bgwDeclaracion_DoWork(object sender, DoWorkEventArgs e)
        {
            GuardarDeclaracion();
        }

        private void bgwDeclaracion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pgbCarga.Visible    = false;
            txtRutaArchivo.Text = string.Empty;
            openFileDialogDocumento.FileName = "";
            btnBuscar_Click(sender, e);
            FlatMessageBox.Show("Declaración guardada exitosamente.", "OK", string.Empty, FlatMessageBoxIcon.Information);
            LimpiarControles();
            btnGuardar.Visible = true;
        }

        public void GuardarDeclaracion()
        {
            new DeclaracionEstado().UpdateDeclaracion(iIdDeclaracion, iEstadoPago + 1, sLlavePag, dtFechaPago.Value);
            cargarArchivos(iIdDeclaracion);
        }
























        #region Code for border shadow
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
     );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            //if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
            //    m.Result = (IntPtr)HTCAPTION;

        }
        #endregion

        
    }
}
