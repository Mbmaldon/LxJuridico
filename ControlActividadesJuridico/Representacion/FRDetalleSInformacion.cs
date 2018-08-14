using ClaseData.Clases;
using ClaseData.Clases.AccesoArchivos;
using ClaseData.Clases.Solicitud;
using ClaseData.Clases.Solicitud.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion
{
    public partial class FRDetalleSInformacion : Form
    {
        int iIdSol;
        int iIdUsuario;
        //int iContador;
        ISDSolicitudInformacion detalle;

        //Constants
        const int AW_HIDE           = 0X10000;
        const int AW_SLIDE          = 0X40000;
        const int AW_HOR_POSITIVE   = 0X1;
        const int AW_HOR_NEGATIVE   = 0X2;
        const int AW_BLEND          = 0X80000;
        const int AW_VER_POSITIVE   = 0x00000004;
        const int AW_VER_NEGATIVE   = 0x00000008;


        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        private bool _UseSlideAnimation;
        public FRDetalleSInformacion() : this(false) { }

        public FRDetalleSInformacion(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
        }

        //NetworkCredential _NetworkCredential = new NetworkCredential(AccessFiles.sUsuario, AccessFiles.sContraseña);
        //string PathFolderShared = @"\\192.169.143.34\Data_Files";

        static FRDetalleSInformacion _Detalle;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show(int iIdSolicitud)
        {
            _Detalle = new FRDetalleSInformacion();
            Form frmSet = Application.OpenForms["FPrincipal"];
            FBandeja _FBandeja = Application.OpenForms["FBandeja"] as FBandeja;

            _Detalle.FormClosed += new FormClosedEventHandler(_FBandeja.ActualizarSolPendientes_FormClosed);
            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _Detalle.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _Detalle.Location = new Point(x, y);

            _Detalle.iIdSol = iIdSolicitud;

            //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
            LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
            _Detalle.iIdUsuario = int.Parse(AUsuarioData.sIdusuario);

            DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
            _Detalle.detalle = detalleSolicitud.InfoSolicitudInformacion(iIdSolicitud);
            _Detalle.SolicitudDetalle(_Detalle.detalle);



            _DialogResult = DialogResult.No;

            _Detalle.Activate();
            _Detalle.ShowDialog();

            return _DialogResult;
        }


        protected override void OnLoad(EventArgs e)
        {
            //Animate form
            base.OnLoad(e);
            AnimateWindow(this.Handle, 100, AW_SLIDE | AW_VER_POSITIVE);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (e.Cancel == false)
                AnimateWindow(this.Handle, 200, AW_HIDE | AW_SLIDE | AW_VER_NEGATIVE);
        }

        //public FRDetalleSInformacion(int iIdSolicitud)
        //{
        //    InitializeComponent();
        //    iIdSol = iIdSolicitud;

        //    //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
        //    LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
        //    iIdUsuario = int.Parse(AUsuarioData.sIdusuario);

        //    DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
        //    detalle = detalleSolicitud.InfoSolicitudInformacion(iIdSolicitud);
        //    SolicitudDetalle(detalle);
        //}

        /*Función para vaciar la información en los controles visibles en diseño*/
        private void SolicitudDetalle(ISDSolicitudInformacion detSolicitud)
        {
            lblNocliente1.Text      = detSolicitud.sNumCliente;
            lblNomCliente.Text      = detSolicitud.sNombreCliente;
            lblRFC.Text             = detSolicitud.sRFC;
            lblTelCelular.Text      = detSolicitud.sTelefonoMovil;
            lblTipoPersona.Text     = detSolicitud.sTipoPersona;
            lblServicio.Text        = detSolicitud.sTipoServicio;
            lblFolio.Text           = detSolicitud.sIdCaso;
            lblFechaRegistro.Text   = detSolicitud.sFechaRegistro;
            lblFechaVigencia.Text   = detSolicitud.sFechaVigencia;
            lblRegistro.Text        = detSolicitud.sRegistro;
            lblTipoEvento.Text      = detSolicitud.sTipoEvento;
            txtSolicitud.Text       = detSolicitud.sSolicitud;
        }

        /*Evento click del boton adjuntar el cual abre control openFileDialog para permitir seleccionar el archivo que sera cargado*/
        private void btCargarArchivo_Click(object sender, EventArgs e)
        {
            //ASIGNA NOMBRE Y FILTROS DEL CONTROL OPENFILEDIALOG
            openFileDialogDocumento.Title       = "Subir Archivos";
            //openFileDialogDocumento.Filter = "Pdf Files|*.pdf |JPG|*.jpg;*.jpeg |Excel Files|*.xls;*.xlsx;*.xlsm |txt files (*.txt)|*.txt|Zip Files|*.zip;*.rar";
            openFileDialogDocumento.FileName    = "";
            openFileDialogDocumento.ShowDialog();
            txtRutaArchivo.Text                 = openFileDialogDocumento.FileName;
        }

        /*Funcion para cargar archivo */
        public void cargaArchivo()
        {
            try
            {
                //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
                //{
                    if (!Directory.Exists(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "SolicitudInformacion" + "\\" + detalle.siIdSolicitudInformacion))
                    {
                        Directory.CreateDirectory(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "SolicitudInformacion" + "\\" + detalle.siIdSolicitudInformacion);
                    }

                    //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO
                    var fileCount = (from file in Directory.EnumerateFiles(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "SolicitudInformacion" + "\\" + detalle.siIdSolicitudInformacion) select file).Count();
                    int i = fileCount - 1;

                    foreach (string fileName in openFileDialogDocumento.FileNames)
                    {
                        //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO@"\\192.168.1.91\\CSJDoc\\"
                        i++;
                        File.Copy(fileName, rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "SolicitudInformacion" + "\\" + detalle.siIdSolicitudInformacion + "\\" + Path.GetFileName(fileName));

                        File.Move(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "SolicitudInformacion" + "\\" + detalle.siIdSolicitudInformacion + "\\" + Path.GetFileName(fileName),
                                  rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "SolicitudInformacion" + "\\" + detalle.siIdSolicitudInformacion + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));

                        EscribirLog("Se copió el archivo " + rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "SolicitudInformacion" + "\\" + detalle.siIdSolicitudInformacion + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));


                        string ruta = rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "SolicitudInformacion" + "\\" + detalle.siIdSolicitudInformacion + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName));

                        ////GUARDA UN REGISTRO DE LA RUTA DONDE SE GUARDO EL ARCHIVO
                        new Adjunto().RegistrarRutaAdjunto(iIdSol, int.Parse(detalle.sIdCaso), 2, iIdUsuario, ruta);

                    }
                    txtRutaArchivo.Text = string.Empty;
                    openFileDialogDocumento.FileName = "";
                //}
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Método Público para escribir un log de los cambios de los archivos del expediente en linea
        /// </summary>
        /// <param name="strMessage">Mensaje que se guardara en el log.</param>
        public void EscribirLog(string strMessage)
        {
            //VALIDACIÓN SI EL ARCHIVO EXISTE
            if (!File.Exists(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + @"SolicitudInformacion\Log.txt"))
            {
                var myFile = File.Create(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + @"SolicitudInformacion\Log.txt");
                myFile.Close();
            }

            //RUTA DE ACCESO DEL ARCHIVO LOG
            string logFile = rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + @"SolicitudInformacion\Log.txt";

            //APLICA FORMATO AL LOG Y ESCRIBE EL MENSAJE QUE SE PASA EN EL PARAMETRO STRMENSAJE.
            string line = DateTime.Now.ToString() + " | ";
            line += strMessage;
            FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter swFromFileStream = new StreamWriter(fs);
            swFromFileStream.WriteLine(line);
            swFromFileStream.Flush();
            swFromFileStream.Close();
        }
      
        /*Evento click de boton enviar el cual registra el la información solicitada por el consultor*/
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtRespuesta.Text != string.Empty)
            {
                DialogResult rs = MessageBox.Show("¿Estás seguro(a) de enviar la información solicitada?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    try
                    {
                        new DSDetalleServicio().respuestaSolicitudInformacion(iIdSol, txtRespuesta.Text);
                        cargaArchivo();
                        Close();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("Es necesario describir la respuesta de envio de información", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*Función para remover acentos al nombre del archivo cargado*/
        static string RemoveDiacritics(string text)
        {
            var normalizedString    = text.Normalize(NormalizationForm.FormD);
            var stringBuilder       = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        /*Evento click boton cerrar, cierra formulario*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}