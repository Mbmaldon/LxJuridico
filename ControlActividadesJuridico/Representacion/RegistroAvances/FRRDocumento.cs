using ClaseData.Clases;
using ClaseData.Clases.Solicitud;
using ClaseData.Clases.Solicitud.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using ClaseData.Clases.AccesoArchivos;

namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    public partial class FRRDocumento : Form
    {
        int     iIdSol;
        int     iIdRec;
        int     idDocumento;
        int     iIdUser;
        string  linkArchivo;

        ISDocumento         detalle;
        ISRutaDocumento     rutaDocument;
        ISDetalleServicio   detalleSol;
        LinkLabel           link;
        Button              btnEliminar;

        //NetworkCredential _NetworkCredential = new NetworkCredential(AccessFiles.sUsuario, AccessFiles.sContraseña);
        //string PathFolderShared = @"\\192.169.143.34\Data_Files";

        /*Funciones que se inicializan cuando el formulario es llamado*/
        public FRRDocumento(int iIdSolicitud, int iIdDocumento, int iRecibido)
        {
            InitializeComponent();
            idDocumento = iIdDocumento;
            iIdSol      = iIdSolicitud;
            iIdRec      = iRecibido;
        }

        /*Evento Load del formulario para realizar la carga de informacion cuando sea requerido*/
        private void FRRDocumento_Load(object sender, EventArgs e)
        {
            LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
            //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
            iIdUser = int.Parse(AUsuarioData.sIdusuario);

            detalle = null;
            DDRegistrado detalleDocumento = new DDRegistrado();
            detalle = detalleDocumento.documentoRegistrado(idDocumento);
            DetalleDocumento(detalle, iIdRec);

            rutaDocument = null;
            rutaDocument = detalleDocumento.rutaDocumentoRegistrado(idDocumento);
            rutaArchivo(rutaDocument, iIdRec);

            detalleSol = null;
            DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
            detalleSol = detalleSolicitud.InfoSolicitud(iIdSol);

            if (rutaDocument == null)
            {
                frm2.Controls.Remove(link);
                frm2.Controls.Remove(btnEliminar);
                btnRegistrar.Visible    = true;
                btnAdjuntar.Visible     = true;
                txtRutaArchivo.Visible  = true;
            }
        }

        /*Funcion para generar el link del documento cargado*/
        private void rutaArchivo (ISRutaDocumento rta, int iRec)
        {
            try
            {
                if (rta != null)
                {
                    linkArchivo = rta.sRutaArchivo.ToString();

                    if (iRec == 1)
                    {
                        string nomAr        = Path.GetFileName(rutaDocument.sRutaArchivo.ToString());
                        link                = new LinkLabel();
                        link.Location       = new Point(125, 106);
                        link.LinkColor      = Color.Blue;
                        link.AutoSize       = true;
                        link.Text           = nomAr;
                        frm2.Controls.Add(link);
                        link.LinkClicked    += new LinkLabelLinkClickedEventHandler(this.link_LinkClicked);

                        btnEliminar                 = new Button();
                        btnEliminar.Size            = new Size(15, 15);
                        btnEliminar.FlatAppearance.BorderSize = 0;
                        btnEliminar.MouseHover      += BtnEliminar_MouseHover; ;
                        btnEliminar.MouseLeave      += BtnEliminar_MouseLeave; ;
                        btnEliminar.Cursor          = Cursors.Hand;
                        btnEliminar.FlatStyle       = FlatStyle.Flat;
                        metroToolTip1.SetToolTip(btnEliminar, "Eliminar");
                        btnEliminar.Image           = Properties.Resources.delete_sign_filled_10px;
                        btnEliminar.Location        = new Point(108, 105);
                        btnEliminar.AccessibleName  = rta.sRutaArchivo;
                        btnEliminar.Name            = rta.sIdRuta;
                        btnEliminar.Click           += BtnEliminar_Click;
                        frm2.Controls.Add(btnEliminar);
                    }
                }
            }
            catch (Exception ex)
            {
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

        /*Evento click del boton eliminar que es generado cuando existe archivo cargado, esta funcion realiza cambia a inactivo el registro sin borrarlo de la bd y consume funciones para mover archivo de la carpeta*/
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Button eliminar = sender as Button;
            string sourceFile = eliminar.AccessibleName;

           
            DialogResult rs = MessageBox.Show("¿Estás seguro de eliminar el archivo seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                new DSDetalleServicio().eliminarArchivo(int.Parse(eliminar.Name));
                moverArchivo(sourceFile);
                FRRDocumento_Load(sender, e);
            }
        }

        /*Función para vaciar la información en los controles visibles del diseño*/
        private void DetalleDocumento(ISDocumento Info, int iRec )
        {
            txtRequ.Text = Info.sRequisicion.ToString();
            lblReq.Text = Info.sTipoReq.ToString();

            if (iRec == 1)
            {
                rbSI.Checked            = true;
                rbSI.Enabled            = false;
                rbNO.Enabled            = false;
                btnRegistrar.Visible    = false;
                btnAdjuntar.Visible     = false;
                txtRutaArchivo.Visible  = false;
            }
        }

        /*Funcion click para lanzar la apertura del archivo seleccionado*/
        public void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
                //{
                    Process.Start(linkArchivo);
                //}
            }
            catch (Exception ex)
            {
            }
        }

        /*Evento click boton registrar la actualización de recepcion de documento*/
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (rbSI.Checked == true)
            {
                try
                {
                    new Solicitud().RecepcionDocumento(idDocumento);
                    cargaArchivo();
                    Close();
                }
                catch 
                {
                }
            }
            else
            {
                Close();
            }
        }

        /*Evento click del boton Adjuntar el cual consume control openFileDialog para permitir seleccionar el archivo que sera cargado*/
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
                    if (!Directory.Exists(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "SolicitudDocumentos" + "\\" + idDocumento))
                    {
                        Directory.CreateDirectory(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "SolicitudDocumentos" + "\\" + idDocumento);
                    }

                    //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO
                    var fileCount = (from file in Directory.EnumerateFiles(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "SolicitudDocumentos" + "\\" + idDocumento) select file).Count();
                    int i = fileCount - 1;


                    foreach (string fileName in openFileDialogDocumento.FileNames)
                    {
                        //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
                        i++;
                        File.Copy(fileName, rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "SolicitudDocumentos" + "\\" + idDocumento + "\\" + Path.GetFileName(fileName));

                        File.Move(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "SolicitudDocumentos" + "\\" + idDocumento + "\\" + Path.GetFileName(fileName), 
                                  rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "SolicitudDocumentos" + "\\" + idDocumento + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));

                        EscribirLog("Se copió el archivo " + rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "SolicitudDocumentos" + "\\" + idDocumento + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));


                        string ruta = rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "SolicitudDocumentos" + "\\" + idDocumento + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName));

                        ////GUARDA UN REGISTRO DE LA RUTA DONDE SE GUARDO EL ARCHIVO
                        new Adjunto().RegistrarRutaAdjunto(idDocumento, int.Parse(detalleSol.sIdCaso), 3, iIdUser, ruta);

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
        /// <param name = "strMessage" > Mensaje que se guardara en el log.</param>
        public void EscribirLog(string strMessage)
        {
            //VALIDACIÓN SI EL ARCHIVO EXISTE
            if (!File.Exists(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + @"SolicitudDocumentos\Log.txt"))
            {
                var myFile = File.Create(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + @"SolicitudDocumentos\Log.txt");
                myFile.Close();
            }

            //RUTA DE ACCESO DEL ARCHIVO LOG
            string logFile = rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + @"SolicitudDocumentos\Log.txt";

            //APLICA FORMATO AL LOG Y ESCRIBE EL MENSAJE QUE SE PASA EN EL PARAMETRO STRMENSAJE.
            string line = DateTime.Now.ToString() + " | ";
            line += strMessage;
            FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter swFromFileStream = new StreamWriter(fs);
            swFromFileStream.WriteLine(line);
            swFromFileStream.Flush();
            swFromFileStream.Close();
        }

        /*Evento CheckedChanged de control radioButton para visualizar controles*/
        private void rbSI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSI.Checked == true)
            {
                btnAdjuntar.Visible = true;
                txtRutaArchivo.Visible = true;
            }
            else if (rbNO.Checked == true)
            {
                btnAdjuntar.Visible = false;
                txtRutaArchivo.Visible = false;
                txtRutaArchivo.Text = string.Empty;
            }
        }

        /*Funcion para mover el archivo de la carpeta PropuestaRespuesta*/
        public void moverArchivo(string archivo)
        {
            try
            {
                //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
                //{
                    if (!Directory.Exists(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "SolicitudDocumentos" + "\\" + "Eliminados"))
                    {
                        Directory.CreateDirectory(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "SolicitudDocumentos" + "\\" + "Eliminados");
                    }

                    File.Move(archivo, rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "SolicitudDocumentos" + "\\" + "Eliminados" + "\\" + Path.GetFileName(archivo));

                    EscribirLogEliminado("Se movio el archivo de la carpeta " + idDocumento + " a la ruta " + rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "SolicitudDocumentos" + "\\" + "Eliminados" + "\\" + Path.GetFileName(archivo));

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
            if (!File.Exists(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "SolicitudDocumentos" + "\\" + @"Eliminados\Log.txt"))
            {
                var myFile = File.Create(rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "SolicitudDocumentos" + "\\" + @"Eliminados\Log.txt");
                myFile.Close();
            }

            //RUTA DE ACCESO DEL ARCHIVO LOG
            string logFile = rutaAdjuntarArchivo.Path + detalleSol.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalleSol.sIdCaso + "\\" + "SolicitudDocumentos" + "\\" + @"Eliminados\Log.txt";

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

        /*Evento click de cerrar formulario*/
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
