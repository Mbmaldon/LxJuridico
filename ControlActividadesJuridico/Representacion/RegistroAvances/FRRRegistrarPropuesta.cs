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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    public partial class FRRRegistrarPropuesta : Form
    {
        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        [Flags]
        enum AnimateWindowFlags
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER       = 0x00000010,
            AW_HIDE         = 0x00010000,
            AW_ACTIVATE     = 0x00020000,
            AW_SLIDE        = 0x00040000,
            AW_BLEND        = 0x00080000
        }

        public FRRRegistrarPropuesta()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            AnimateWindow(this.Handle, 200, AnimateWindowFlags.AW_BLEND);
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            AnimateWindow(this.Handle, 300, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }

        int                 iIdSol;
        int                 iIdConsultor;
        ISDetalleServicio   detalleSol;
        EIOSFolioPropuesta  Id;

        //NetworkCredential _NetworkCredential = new NetworkCredential(AccessFiles.sUsuario, AccessFiles.sContraseña);
        //string PathFolderShared = @"\\192.169.143.34\Data_Files";

        /*Funciones que se inicializan cuando el formulario es llamado*/
        //public FRRRegistrarPropuesta(int idSolicitud, int Usuario)
        //{
        //    InitializeComponent();
        //    iIdSol          = idSolicitud;
        //    iIdConsultor    = Usuario;

        //    detalleSol      = null;
        //    DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
        //    detalleSol      = detalleSolicitud.InfoSolicitud(idSolicitud);

        //    CObtenerFolio idPro = new CObtenerFolio();
        //    Id = idPro.obtenerID();
        //}

        static FRRRegistrarPropuesta _Registro;
        static DialogResult _DialogResult = DialogResult.No;
        public static DialogResult Show(int idSolicitud, int Usuario)
        {
            _Registro = new FRRRegistrarPropuesta();
            Form frmSet = Application.OpenForms["FPrincipal"];
            FRDetalleServicio _DetalleServicio = Application.OpenForms["FRDetalleServicio"] as FRDetalleServicio;

            _Registro.FormClosed += new FormClosedEventHandler(_DetalleServicio.ActualizarDetalles_FormClosed);


            _Registro.iIdSol = idSolicitud;
            _Registro.iIdConsultor = Usuario;

            _Registro.detalleSol = null;
            DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
            _Registro.detalleSol = detalleSolicitud.InfoSolicitud(idSolicitud);

            CObtenerFolio idPro = new CObtenerFolio();
            _Registro.Id = idPro.obtenerID();



            _DialogResult = DialogResult.No;

            _Registro.Activate();
            _Registro.ShowDialog();
            return _DialogResult;
        }

        /*Evento click boton registrar para dar de alta una nueva propuesta de respuesta*/
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string propuesta;

            if (txtPropuesta.Text != string.Empty)
            {
                propuesta = txtPropuesta.Text;

                try
                {
                    new DSDetalleServicio().RegistrarPropuestaRespuesta(iIdSol, iIdConsultor, propuesta);
                    cargaArchivo();
                    DialogResult rs = MessageBox.Show("Se ha realizado el registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (rs == DialogResult.OK)
                    {
                        FRDetalleServicio _DS = Application.OpenForms["FRDetalleServicio"] as FRDetalleServicio;
                        _DS.btnEnviarTramite.Visible = true;
                        Close();
                    }
                }
                catch (Exception)
                {
                }
            }
            else
            {
                MessageBox.Show("Es necesario describir la propuesta de respuesta", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*Evento click del boton adjuntar el cual abre control openFileDialog para permitir seleccionar el archivo que sera cargado*/
        private void btnAdjuntar_Click(object sender, EventArgs e)
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
                    if (!Directory.Exists(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta))
                    {
                        Directory.CreateDirectory(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta);
                    }

                    //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO
                    var fileCount = (from file in Directory.EnumerateFiles(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta) select file).Count();
                    int i = fileCount - 1;

                    foreach (string fileName in openFileDialogDocumento.FileNames)
                    {
                        //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
                        i++;
                        File.Copy(fileName, rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta + "\\" + Path.GetFileName(fileName));

                        File.Move(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta + "\\" + Path.GetFileName(fileName), 
                                  rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));

                        EscribirLog("Se copió el archivo " + rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));

                        string ruta = rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName));

                        ////GUARDA UN REGISTRO DE LA RUTA DONDE SE GUARDO EL ARCHIVO
                        new Adjunto().RegistrarRutaAdjunto(int.Parse(Id.sIdPropuesta), int.Parse(detalleSol.sIdCaso), 4, iIdConsultor, ruta);
                    }
                    txtRutaArchivo.Text = string.Empty;
                    openFileDialogDocumento.FileName = "";
                //}
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Método Público para escribir un log de los cambios de los archivos del expediente en linea
        /// </summary>
        /// <param name = "strMessage" > Mensaje que se guardara en el log.</param>
        public void EscribirLog(string strMessage)
        {
            //VALIDACIÓN SI EL ARCHIVO EXISTE
            if (!File.Exists(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + @"PropuestaRespuesta\Log.txt"))
            {
                var myFile = File.Create(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + @"PropuestaRespuesta\Log.txt");
                myFile.Close();
            }

            //RUTA DE ACCESO DEL ARCHIVO LOG
            string logFile = rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + @"PropuestaRespuesta\Log.txt";

            //APLICA FORMATO AL LOG Y ESCRIBE EL MENSAJE QUE SE PASA EN EL PARAMETRO STRMENSAJE.
            string line = DateTime.Now.ToString() + " | ";
            line += strMessage;
            FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter swFromFileStream = new StreamWriter(fs);
            swFromFileStream.WriteLine(line);
            swFromFileStream.Flush();
            swFromFileStream.Close();
        }

        /*Evento click de boton cancelar para cerrar formulario*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
