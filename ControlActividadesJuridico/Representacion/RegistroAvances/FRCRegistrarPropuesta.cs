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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    public partial class FRCRegistrarPropuesta : Form
    {
        int iIdSol;
        int iIdConsultor;
        ISDetalleServicio detalleSol;
        EIOSFolioPropuesta Id;

        /*Funciones que se inicializan cuando el formulario es llamado*/
        public FRCRegistrarPropuesta(int idSolicitud, int Usuario)
        {
            InitializeComponent();
            iIdSol          = idSolicitud;
            iIdConsultor    = Usuario;
            detalleSol      = null;

            DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
            detalleSol = detalleSolicitud.InfoSolicitud(idSolicitud);

            CObtenerFolio idPro = new CObtenerFolio();
            Id = idPro.obtenerID();
        }

        /*Evento click boton registrar nueva propuesta de respuesta*/
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string propuesta;

            if (txtPropuesta.Text != string.Empty)
            {
                propuesta = txtPropuesta.Text;

                try
                {
                    new DSDetalleServicio().RegistrarPropuestaRespuestaContador(iIdSol, iIdConsultor, propuesta);
                    cargaArchivo();
                    DialogResult rs = MessageBox.Show("Se ha realizado el registro correctamente", "Mensaje", MessageBoxButtons.OK);
                    if (rs == DialogResult.OK)
                    {
                        FRDetalleServicio _DS = Application.OpenForms["FRDetalleServicio"] as FRDetalleServicio;
                        _DS.btnEnviarTramite.Visible = true;
                        Close();
                    }
                }
                catch (Exception )
                {
                }
            }
            else
            {
                MessageBox.Show("Es necesario describir la propuesta de respuesta", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /*Funcion para cargar archivo */
        public void cargaArchivo()
        {
            try
            {
                if (!Directory.Exists(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta))
                {
                    Directory.CreateDirectory(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta);
                }

                //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO
                var fileCount = (from file in Directory.EnumerateFiles(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta) select file).Count();
                int i = fileCount - 1;

                foreach (string fileName in openFileDialogDocumento.FileNames)
                {
                    //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
                    i++;
                    File.Copy(fileName, rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta + "\\" + Path.GetFileName(fileName));

                    File.Move(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta + "\\" + Path.GetFileName(fileName), 
                              rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));

                    EscribirLog("Se copió el archivo " + rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));

                    string ruta = rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + Id.sIdPropuesta + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName));

                    ////GUARDA UN REGISTRO DE LA RUTA DONDE SE GUARDO EL ARCHIVO
                    new Adjunto().RegistrarRutaAdjunto(int.Parse(Id.sIdPropuesta), int.Parse(detalleSol.sIdCaso), 4, iIdConsultor, ruta);
                }
                txtRutaArchivo.Text = string.Empty;
                openFileDialogDocumento.FileName = "";
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
            if (!File.Exists(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + @"PropuestaRespuesta\Log.txt"))
            {
                var myFile = File.Create(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + @"PropuestaRespuesta\Log.txt");
                myFile.Close();
            }

            //RUTA DE ACCESO DEL ARCHIVO LOG
            string logFile = rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + @"PropuestaRespuesta\Log.txt";

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

        /*Evento click del boton Adjuntar el cual consume control openFileDialog para permitir seleccionar el archivo que sera cargado*/
        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            //ASIGNA NOMBRE Y FILTROS DEL CONTROL OPENFILEDIALOG
            openFileDialogDocumento.Title       = "Subir Archivos";
            //openFileDialogDocumento.Filter = "Pdf Files|*.pdf |JPG|*.jpg;*.jpeg |Excel Files|*.xls;*.xlsx;*.xlsm |txt files (*.txt)|*.txt|Zip Files|*.zip;*.rar";
            openFileDialogDocumento.FileName    = "";
            openFileDialogDocumento.ShowDialog();
            txtRutaArchivo.Text = openFileDialogDocumento.FileName;
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
