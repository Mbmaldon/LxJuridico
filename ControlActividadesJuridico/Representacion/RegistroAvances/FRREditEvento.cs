using ClaseData.Clases.AccesoArchivos;
using ClaseData.Clases.Archivo;
using ClaseData.Clases.Archivo.ArchivoEntidades;
using ClaseData.Clases.Solicitud;
using ClaseData.Clases.Solicitud.DetalleServicio;
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

namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    public partial class FRREditEvento : Form
    {
        string  sNCliente;
        int     ifolio;
        int     iEvento;
        int     idUsuario;
        string  nomArchivo;
        EDetalleEvento detalle;
        List<ERArchivo> LRuta;

        //NetworkCredential _NetworkCredential = new NetworkCredential(AccessFiles.sUsuario, AccessFiles.sContraseña);
        //string PathFolderShared = @"\\192.169.143.34\Data_Files";

        /*Funciones que se inicializan cuando el formulario es llamado*/
        public FRREditEvento(int iIdEvento, string sNumCliente, int iCaso, int idUser)
        {
            InitializeComponent();
            iEvento         = iIdEvento;
            sNCliente       = sNumCliente;
            ifolio          = iCaso;
            idUsuario       = idUser;
        }

        /*Evento Load del formulario para realizar la carga de informacion cuando sea requerido*/
        private void FRREditEvento_Load(object sender, EventArgs e)
        {
            detalle             = null;
            DEvento detalleEve  = new DEvento();
            detalle             = detalleEve.infoEvento(iEvento);
            detallesEvento(detalle);

            CDocumentosOficialia Archivos = new CDocumentosOficialia();
            LRuta = Archivos.listaArchivoEvento(iEvento);

            /*Condicion para genera el link label del archivo*/
            if (LRuta.Count != 0)
            {
                for (int i = 0; i < LRuta.Count; i++)
                {
                    nomArchivo              = Path.GetFileName(LRuta[i].sRuta);
                    LinkLabel lnkDocumento  = new LinkLabel();
                    lnkDocumento.Text       = nomArchivo;
                    lnkDocumento.AutoSize   = true;
                    lnkDocumento.Location   = new Point(20, 15 * i + 2);
                    lnkDocumento.Name       = LRuta[i].sRuta;
                    lnkDocumento.Click += LnkDocumento_Click;
                    listArchivos.Controls.Add(lnkDocumento);

                    Button btnEliminar      = new Button();
                    btnEliminar.Size        = new Size(15, 15);
                    btnEliminar.FlatAppearance.BorderSize = 0;

                    btnEliminar.MouseHover += BtnEliminar_MouseHover;
                    btnEliminar.MouseLeave += BtnEliminar_MouseLeave;
                    btnEliminar.Cursor          = Cursors.Hand;
                    btnEliminar.FlatStyle       = FlatStyle.Flat;
                    metroToolTip1.SetToolTip(btnEliminar, "Eliminar");
                    btnEliminar.Image           = Properties.Resources.delete_sign_filled_10px;
                    btnEliminar.Location        = new Point(5, 15 * i + 2);
                    btnEliminar.AccessibleName  = LRuta[i].sRuta;
                    btnEliminar.Name            = LRuta[i].sIdRuta;
                    btnEliminar.Click += BtnEliminar_Click;
                    listArchivos.Controls.Add(btnEliminar);
                }
            }
        }

        /*Función para vaciar la información en los controles visibles del diseño*/
        public void detallesEvento(EDetalleEvento Evento)
        {
            //if (Evento.sExpOrigen == " ")
            //{
            //    txtExpOrigen.Text = string.Empty;
            //}
            //else
            //{
            //    txtExpOrigen.Text = Evento.sExpOrigen;
            //}
            if (Evento.sNumExpediente == " ")
            {
                txtNumExp.Text = string.Empty;
            }
            else
            {
                txtNumExp.Text = Evento.sNumExpediente;
            }

            if (Evento.sJuzgado == " ")
            {
                txtJuzgado.Text = string.Empty;
            }
            else
            {
                txtJuzgado.Text = Evento.sJuzgado;
            }

            if (Evento.sContraparte == " ")
            {
                txtContraparte.Text = string.Empty;
            }
            else
            {
                txtContraparte.Text = Evento.sContraparte;
            }
            if (Evento.sTipoJuicio == " ")
            {
                txtTJuicio.Text = string.Empty;
            }
            else
            {
                txtTJuicio.Text = Evento.sTipoJuicio;
            }

            //if (Evento.sDecripcionActo == " ")
            //{
            //    txtDescripActo.Text = string.Empty;

            //}
            //else
            //{
            //    txtDescripActo.Text = Evento.sDecripcionActo;
            //}
            
            txtEvento.Text          = Evento.sEvento;
            txtTarea.Text           = Evento.sTarea;
            dtpTeminoLegal.Text     = Evento.sFTerLegal;
            dtpTerminoInterno.Text  = Evento.sFTerInterno;
            txtDescripcion.Text     = Evento.sPropuesta;
            
        }

        /*Funcion click para lanzar la apertura del archivo seleccionado*/
        private void LnkDocumento_Click(object sender, EventArgs e)
        {
            LinkLabel ruta = sender as LinkLabel;

            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                System.Diagnostics.Process.Start(ruta.Name);
            //}
        }

        /*Evento CheckedChanged de control checBox para habilitar o deshabiltar controles para alimentar el evento registrado*/
        private void cbhActivarCampos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhActivarCampos.Checked == true)
            {
                //txtExpOrigen.Enabled    = true;
                txtNumExp.Enabled       = true;
                txtJuzgado.Enabled      = true;
                txtContraparte.Enabled  = true;
                txtTJuicio.Enabled      = true;
                //txtDescripActo.Enabled = true;
                //chbOficialia.Visible = true;
            }
            else
            {
                //txtExpOrigen.Enabled    = false;
                txtNumExp.Enabled       = false;
                txtJuzgado.Enabled      = false;
                txtContraparte.Enabled  = false;
                txtTJuicio.Enabled      = false;
                //txtDescripActo.Enabled = false;
                //chbOficialia.Visible = false;
            }
        }

        /*Evento click boton registrar para actualizar el evento*/
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string  expOrigen;
            string  numExpediente;
            string  juzgado;
            string  contraparte;
            string  tipoJuicio;
            string  descripcion;
            string descripcionActo;
            int     iOficialia = 0;

            //if (txtExpOrigen.Text == string.Empty)
            //{
            //    expOrigen = " ";
            //}
            //else
            //{
            //    expOrigen = txtExpOrigen.Text;
            //}
            if (txtNumExp.Text == string.Empty)
            {
                numExpediente = " ";
            }
            else
            {
                numExpediente = txtNumExp.Text;
            }

            if (txtJuzgado.Text == string.Empty)
            {
                juzgado = " ";
            }
            else
            {
                juzgado = txtJuzgado.Text;
            }

            if (txtContraparte.Text == string.Empty)
            {
                contraparte = " ";
            }
            else
            {
                contraparte = txtContraparte.Text;
            }

            if (txtTJuicio.Text == string.Empty)
            {
                tipoJuicio = " ";
            }
            else
            {
                tipoJuicio = txtTJuicio.Text;
            }

            //if(txtDescripActo.Text == string.Empty)
            //{
            //    descripcionActo = " ";
            //}
            //else
            //{
            //    descripcionActo = txtDescripActo.Text;
            //}

            //if (chbOficialia.Checked == true)
            //{
            //    iOficialia = 1;
            //}
            //else
            //{
            //    iOficialia = 0;
            //}

            if (txtDescripcion.Text != string.Empty)
            {
                descripcion = txtDescripcion.Text;

                //if (chbOficialia.Checked == true)
                //{
                if(cbhActivarCampos.Checked == true)
                { 
                   // if (txtExpOrigen.Text == string.Empty && txtNumExp.Text == string.Empty && txtJuzgado.Text == string.Empty && txtContraparte.Text == string.Empty && txtTJuicio.Text == string.Empty)
                        if (txtNumExp.Text == string.Empty && txtJuzgado.Text == string.Empty && txtContraparte.Text == string.Empty && txtTJuicio.Text == string.Empty)
                        {
                            MessageBox.Show("Es necesario ingresar información en alguno de los siguientes campos: " + Environment.NewLine + 
                                        "- Expediente de Origen" + Environment.NewLine + 
                                        "- No. Expediente" + Environment.NewLine + 
                                        "- Juzgado" + Environment.NewLine + 
                                        "- Contraparte" + Environment.NewLine + 
                                        "- Tipo Juicio" + Environment.NewLine + 
                                        "- Descripción del Acto", 
                                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            DialogResult rs = MessageBox.Show("¿Estás seguro de actualizar la información del registro?", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            if (rs == DialogResult.OK)
                            {
                                new DSDetalleServicio().ActualizarEvento(iEvento, " ", numExpediente, juzgado, contraparte, tipoJuicio, descripcion, iOficialia, "");
                                if (txtRutaArchivo.Text != string.Empty)
                                {
                                    cargaArchivo();
                                }
                                DialogResult rs2 = MessageBox.Show("Se ha realizado la actualización correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (rs2 == DialogResult.OK)
                                {
                                    Close();
                                }
                            }
                            else
                            {
                                Close();
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                else
                {
                    try
                    {
                        DialogResult rs = MessageBox.Show("¿Estás seguro de actualizar la información del registro?", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        if (rs == DialogResult.OK)
                        {
                            new DSDetalleServicio().ActualizarEvento(iEvento, " ", numExpediente, juzgado, contraparte, tipoJuicio, descripcion, iOficialia, "");
                            if (txtRutaArchivo.Text != string.Empty)
                            {
                                cargaArchivo();
                            }
                            DialogResult rs2 = MessageBox.Show("Se ha realizado la actualización correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (rs2 == DialogResult.OK)
                            {
                                Close();
                            }
                        }
                        else
                        {
                            Close();
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("Es necesario ingresar la descripción del evento", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*Evento click de boton cancelar para cerrar formulario*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*Evento click del boton CargarArchivo el cual consume control openFileDialog para permitir seleccionar el archivo que sera cargado*/
        private void btnCargarArchivo_Click(object sender, EventArgs e)
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
                //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
                //{
                    if (!Directory.Exists(rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + iEvento))
                    {
                        Directory.CreateDirectory(rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + iEvento);
                    }

                    //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO
                    var fileCount = (from file in Directory.EnumerateFiles(rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + iEvento) select file).Count();
                    int i = fileCount - 1;

                    foreach (string fileName in openFileDialogDocumento.FileNames)
                    {
                        //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
                        i++;
                        File.Copy(fileName, rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + iEvento + "\\" + Path.GetFileName(fileName));

                        File.Move(rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + iEvento + "\\" + Path.GetFileName(fileName), 
                                  rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + iEvento + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));

                        EscribirLog("Se copió el archivo " + rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + iEvento + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));

                        string ruta = rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + iEvento + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName));

                        ////GUARDA UN REGISTRO DE LA RUTA DONDE SE GUARDO EL ARCHIVO
                        new Adjunto().RegistrarRutaAdjunto(iEvento, ifolio, 1, idUsuario, ruta);
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
            if (!File.Exists(rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + @"EventoOficialia\Log.txt"))
            {
                var myFile = File.Create(rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + @"EventoOficialia\Log.txt");
                myFile.Close();
            }

            //RUTA DE ACCESO DEL ARCHIVO LOG
            string logFile = rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + @"EventoOficialia\Log.txt";

            //APLICA FORMATO AL LOG Y ESCRIBE EL MENSAJE QUE SE PASA EN EL PARAMETRO STRMENSAJE.
            string line = DateTime.Now.ToString() + " | ";
            line += strMessage;
            FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter swFromFileStream = new StreamWriter(fs);
            swFromFileStream.WriteLine(line);
            swFromFileStream.Flush();
            swFromFileStream.Close();
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

        /*Evento click del boton eliminar que es generado cuando existe archivo cargado, esta funcion realiza cambia a inactivo el registro sin borrarlo de la bd y consume funciones para mover archivo de la carpeta*/
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Button eliminar = sender as Button;
            string sourceFile = eliminar.AccessibleName;

           
            // MessageBox.Show( iEvento.ToString());
            DialogResult rs = MessageBox.Show("¿Estás seguro de eliminar el archivo seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                new DSDetalleServicio().eliminarArchivo(int.Parse(eliminar.Name));
                moverArchivo(sourceFile);

                listArchivos.Controls.Clear();
                FRREditEvento_Load(sender, e);
            }
        }

        /*Funcion para mover el archivo de la carpeta PropuestaRespuesta*/
        public void moverArchivo(string archivo)
        {
            try
            {
                //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
                //{
                    if (!Directory.Exists(rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + "Eliminados"))
                    {
                        Directory.CreateDirectory(rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + "Eliminados");
                    }

                    File.Move(archivo, rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + "Eliminados" + "\\" + Path.GetFileName(archivo));

                    EscribirLogEliminado("Se movió el archivo de la carpeta " + iEvento + " a la ruta " + rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + "Eliminados" + "\\" + Path.GetFileName(archivo));

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
        public void EscribirLogEliminado(string strMessage)
        {
            //VALIDACIÓN SI EL ARCHIVO EXISTE
            if (!File.Exists(rutaAdjuntarArchivo.Path + sNCliente + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + @"Eliminados\Log.txt"))
            {
                var myFile = File.Create(rutaAdjuntarArchivo.Path + sNCliente + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + @"Eliminados\Log.txt");
                myFile.Close();
            }

            //RUTA DE ACCESO DEL ARCHIVO LOG
            string logFile = rutaAdjuntarArchivo.Path + sNCliente + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + @"Eliminados\Log.txt";

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
