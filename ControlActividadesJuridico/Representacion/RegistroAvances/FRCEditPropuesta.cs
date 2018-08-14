using ClaseData.Clases;
using ClaseData.Clases.Archivo;
using ClaseData.Clases.Archivo.ArchivoEntidades;
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
    public partial class FRCEditPropuesta : Form
    {
        int idSoli;
        int idPropuesta;
        int iAprob;
        int iIdUser;

        //string linkArchivo;

        ISPropuesta         detalle;
        ISDetalleServicio   detalleSol;
        //ISRutaDocumento rutaArchivo;
        List<ERArchivo>     LRuta;
        LinkLabel           link;
        Button              btnEliminar;

        /*Funciones que se inicializan cuando el formulario es llamado*/
        public FRCEditPropuesta(int iIdSolicitud, int iIdPropuesta, int iAprobada)
        {
            InitializeComponent();
            idSoli          = iIdSolicitud;
            idPropuesta     = iIdPropuesta;
            iAprob          = iAprobada;
        }

        /*Evento Load del formulario para realizar la carga de informacion cuando sea requerido*/
        private void FRCEditPropuesta_Load(object sender, EventArgs e)
        {

            LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
            //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
            iIdUser = int.Parse(AUsuarioData.sIdusuario);

            detalle = null;
            DSDetalleServicio infoPropuesta = new DSDetalleServicio();
            detalle         = infoPropuesta.InfoPropuesta(idPropuesta);
            detalleSol      = infoPropuesta.InfoSolicitud(idSoli);


            CDocumentosOficialia lRuta = new CDocumentosOficialia();
            LRuta = lRuta.rutaArchivosPropuesta(idPropuesta);
            rutaDocument(LRuta);

            informacionPropuesta(detalle, iAprob);
        }

        /*Funcion para generar el link del documento cargado*/
        public void rutaDocument(List<ERArchivo> rta)
        {
            try
            {
                if (rta.Count != 0)
                {
                    for (int i = 0; i < rta.Count; i++)
                    {

                        string nomArchivo   = Path.GetFileName(rta[i].sRuta);
                        link                = new LinkLabel();
                        link.Location       = new Point(20, 15 * i + 2);
                        link.AutoSize       = true;
                        link.Text           = nomArchivo;
                        link.Name           = rta[i].sRuta;
                        link.Click          += Link_Click;
                        listArchivos.Controls.Add(link);

                        btnEliminar                             = new Button();
                        btnEliminar.Size                        = new Size(15, 15);
                        
                        btnEliminar.Cursor                      = Cursors.Hand;
                        btnEliminar.FlatStyle                   = FlatStyle.Flat;
                        metroToolTip1.SetToolTip(btnEliminar, "Eliminar");
                        btnEliminar.Image                       = Properties.Resources.delete_sign_filled_10px;
                        btnEliminar.Location                    = new Point(5, 15 * i + 2);
                        btnEliminar.AccessibleName              = LRuta[i].sRuta;
                        btnEliminar.Name                        = rta[i].sIdRuta;
                        btnEliminar.FlatAppearance.BorderSize   = 0;
                        btnEliminar.MouseHover                  += BtnEliminar_MouseHover;
                        btnEliminar.MouseLeave                  += BtnEliminar_MouseLeave;
                        btnEliminar.Click                       += BtnEliminar_Click;
                        listArchivos.Controls.Add(btnEliminar);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        /*Evento click del boton eliminar que es generado cuando existe archivo cargado, esta funcion realiza cambia a inactivo el registro sin borrarlo de la bd y consume funciones para mover archivo de la carpeta*/
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Button eliminar     = sender as Button;
            string sourceFile   = eliminar.AccessibleName;
            DialogResult rs = MessageBox.Show("¿Estás seguro de eliminar el archivo seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                new DSDetalleServicio().eliminarArchivo(int.Parse(eliminar.Name));
                moverArchivo(sourceFile);
                listArchivos.Controls.Clear();
                FRCEditPropuesta_Load(sender, e);
            }
        }

        /*Evento MouseLeave de boton Eliminar para cambiar el color e imagen al posicionar el puntero encima del boton*/
        private void BtnEliminar_MouseLeave(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 255);
            boton.Image = Properties.Resources.delete_sign_filled_10px;
        }

        /*Evento MouseHover de boton Eliminar para cambiar el color e imagen al posicionar el puntero encima del boton*/
        private void BtnEliminar_MouseHover(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 67, 54);
            boton.Image = Properties.Resources.delete_sign_filled_10pxb;
        }

        /*Funcion click para lanzar la apertura del archivo seleccionado*/
        private void Link_Click(object sender, EventArgs e)
        {
            LinkLabel ruta = sender as LinkLabel;
            System.Diagnostics.Process.Start(ruta.Name);
        }

        /*Función para vaciar la información en los controles visibles del diseño*/
        private void informacionPropuesta(ISPropuesta infPropuesta, int aprobacion)
        {
            txtPropuesta.Text = infPropuesta.sPropuesta;
            if (aprobacion > 0)
            {
                btnRegistrar.Enabled = false;
            }
        }

        /*Evento KeyPress evita la escritura de texto en el control si ya fue aprobada*/
        private void txtPropuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (iAprob > 0)
            {
                e.Handled = true;
            }
        }

        /*Evento click del boton Adjuntar el cual consume control openFileDialog para permitir seleccionar el archivo que sera cargado*/
        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            //ASIGNA NOMBRE Y FILTROS DEL CONTROL OPENFILEDIALOG
            openFileDialogDocumento.Title = "Subir Archivos";
            //openFileDialogDocumento.Filter = "Pdf Files|*.pdf |JPG|*.jpg;*.jpeg |Excel Files|*.xls;*.xlsx;*.xlsm |txt files (*.txt)|*.txt|Zip Files|*.zip;*.rar";
            openFileDialogDocumento.FileName = "";
            openFileDialogDocumento.ShowDialog();
            txtRutaArchivo.Text = openFileDialogDocumento.FileName;
        }

        /*Funcion para cargar archivo */
        public void cargaArchivo()
        {
            try
            {
                if (!Directory.Exists(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + idPropuesta))
                {
                    Directory.CreateDirectory(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + idPropuesta);
                }

                //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO
                var fileCount = (from file in Directory.EnumerateFiles(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + idPropuesta) select file).Count();
                int i = fileCount - 1;

                foreach (string fileName in openFileDialogDocumento.FileNames)
                {
                    //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
                    i++;
                    File.Copy(fileName, rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + idPropuesta + "\\" + Path.GetFileName(fileName));

                    File.Move(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + idPropuesta + "\\" + Path.GetFileName(fileName), 
                              rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + idPropuesta + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));

                    EscribirLog("Se copió el archivo " + rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + idPropuesta + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));

                    string ruta = rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + idPropuesta + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName));

                    ////GUARDA UN REGISTRO DE LA RUTA DONDE SE GUARDO EL ARCHIVO
                    new Adjunto().RegistrarRutaAdjunto(idPropuesta, int.Parse(detalleSol.sIdCaso), 4, iIdUser, ruta);
                }
                txtRutaArchivo.Text = string.Empty;
                openFileDialogDocumento.FileName = "";
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Método Público para escribir un log de los cambios de los archivos del expediente en linea
        /// </summary>
        /// <param name = "strMessage" > Mensaje que se guardara en el log.</param>
        public void EscribirLog(string strMessage)
        {
            //String ruta = @"\\192.168.1.91";
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

        /*Evento click boton registrar la actualizacion de la propuesta de respuesta ya entes registrada*/
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtPropuesta.Text != string.Empty)
            {
                try
                {
                    new DSDetalleServicio().ActualizarPropuestaRespuesta(idPropuesta, txtPropuesta.Text);
                    cargaArchivo();
                    DialogResult rs = MessageBox.Show("Se ha realizado el registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (rs == DialogResult.OK)
                    {
                        FRDetalleServicio _DS = Application.OpenForms["FRDetalleServicio"] as FRDetalleServicio;
                        _DS.btnEnviarTramite.Visible = true;
                        Close();
                    }
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("Es necesario describir la propuesta de respuesta", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /*Evento click de boton cancelar para cerrar formulario*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*Funcion para mover el archivo de la carpeta PropuestaRespuesta*/
        public void moverArchivo(string archivo)
        {
            try
            {
                if (!Directory.Exists(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + "Eliminados"))
                {
                    Directory.CreateDirectory(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + "Eliminados");
                }

                File.Move(archivo, rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + "Eliminados" + "\\" + Path.GetFileName(archivo));

                EscribirLogEliminado("Se movió el archivo de la carpeta " + idPropuesta + " a la ruta " + rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + "Eliminados" + "\\" + Path.GetFileName(archivo));

                txtRutaArchivo.Text = string.Empty;
                openFileDialogDocumento.FileName = "";
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Método Público para escribir un log de los cambios de los archivos del expediente en linea
        /// </summary>
        /// <param name="strMessage">Mensaje que se guardara en el log.</param>
        public void EscribirLogEliminado(string strMessage)
        {
            //VALIDACIÓN SI EL ARCHIVO EXISTE
            if (!File.Exists(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + @"Eliminados\Log.txt"))
            {
                var myFile = File.Create(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + @"Eliminados\Log.txt");
                myFile.Close();
            }

            //RUTA DE ACCESO DEL ARCHIVO LOG
            string logFile = rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + detalleSol.sIdCaso + "\\" + "PropuestaRespuesta" + "\\" + @"Eliminados\Log.txt";

            //APLICA FORMATO AL LOG Y ESCRIBE EL MENSAJE QUE SE PASA EN EL PARAMETRO STRMENSAJE.
            string line = DateTime.Now.ToString() + " | ";
            line += strMessage;
            FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter swFromFileStream = new StreamWriter(fs);
            swFromFileStream.WriteLine(line);
            swFromFileStream.Flush();
            swFromFileStream.Close();
        }

        /*Función para remover acentos al nombre del archivo cargado*/
        static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

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
