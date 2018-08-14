using ClaseData.Clases;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    public partial class FRRRecepcionOficialia : Form
    {
        int     iIdCaso;
        int     iIdOficial;
        int     idUsuario;
        string  sNumCliente;
        string  nomArchivo;

        EDetalleOficilia detalle;
        List<ERArchivo> LRuta;

        /*Funciones que se inicializan cuando el formulario es llamado*/
        public FRRRecepcionOficialia(string sNCliente, string sCaso, int iIdOficialia)
        {
            InitializeComponent();
            sNumCliente     = sNCliente;
            iIdCaso         = int.Parse(sCaso);
            iIdOficial      = iIdOficialia;
        }

        /*Evento Load del formulario para realizar la carga de informacion cuando sea requerido*/
        private void FRRRecepcionOficialia_Load(object sender, EventArgs e)
        {
            LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
            //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
            idUsuario = int.Parse(AUsuarioData.sIdusuario);

            detalle             = null;
            DEvento detalleEve  = new DEvento();
            detalle             = detalleEve.infoOficialia(iIdOficial);
            detallesOficialia(detalle);

            CDocumentosOficialia Archivos = new CDocumentosOficialia();
            LRuta = Archivos.listaDocumentos(iIdOficial);
            
            /*Condicion para saber si es necesario crear o no links y botones*/
            if (LRuta.Count != 0)
            {
                /*Ciclo for para recorrer las rutas y saber cuantos link y botones generar en el formulario*/
                for (int i = 0; i < LRuta.Count; i++)
                {
                    nomArchivo                  = Path.GetFileName(LRuta[i].sRuta);
                    LinkLabel lnkDocumento      = new LinkLabel();
                    lnkDocumento.Text           = nomArchivo;
                    lnkDocumento.AutoSize       = true;
                    lnkDocumento.Location       = new Point(20, 15 * i + 2);
                    lnkDocumento.Name           = LRuta[i].sRuta;
                    lnkDocumento.Click          += LnkDocumento_Click;
                    listArchivos.Controls.Add(lnkDocumento);

                    Button btnEliminar          = new Button();
                    btnEliminar.Size            = new Size(15, 15);
                    btnEliminar.FlatAppearance.BorderSize = 0;

                    btnEliminar.MouseHover      += BtnEliminar_MouseHover;
                    btnEliminar.MouseLeave      += BtnEliminar_MouseLeave;
                    btnEliminar.Cursor          = Cursors.Hand;
                    btnEliminar.FlatStyle       = FlatStyle.Flat;
                    metroToolTip1.SetToolTip(btnEliminar, "Eliminar");
                    btnEliminar.Image           = Properties.Resources.delete_sign_filled_10px;
                    btnEliminar.Location        = new Point(5, 15 * i + 2);
                    btnEliminar.AccessibleName  = LRuta[i].sRuta;
                    btnEliminar.Name            = LRuta[i].sIdRuta;
                    btnEliminar.Click           += BtnEliminar_Click;
                    listArchivos.Controls.Add(btnEliminar);
                }
            }
        }

        /*Evento MouseHover de boton Eliminar para cambiar el color e imagen al posicionar el puntero encima del boton*/
        private void BtnEliminar_MouseLeave(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255,255,255);
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

            //MessageBox.Show(eliminar.Name);
            DialogResult rs = MessageBox.Show("¿Estas seguro de eliminar el archivo seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                new DSDetalleServicio().eliminarArchivo(int.Parse(eliminar.Name));
                moverArchivo(sourceFile);
                listArchivos.Controls.Clear();
                FRRRecepcionOficialia_Load(sender, e);
            }
        }

        /*Funcion click para lanzar la apertura del archivo seleccionado*/
        private void LnkDocumento_Click(object sender, EventArgs e)
        {
            LinkLabel ruta = sender as LinkLabel;
            System.Diagnostics.Process.Start(ruta.Name);
        }

        /*Función para vaciar la información en los controles visibles del diseño*/
        public void detallesOficialia(EDetalleOficilia detOficilia)
        {
            if (detOficilia.sExpOrigen == " ")
            {
                txtExpOrigen.Text = string.Empty;
            }
            else
            {
                txtExpOrigen.Text = detOficilia.sExpOrigen;
            }
            if (detOficilia.sNumExpediente == " ")
            {
                txtNumExp.Text = string.Empty;
            }
            else
            {
                txtNumExp.Text = detOficilia.sNumExpediente;
            }

            if (detOficilia.sJuzgado == " ")
            {
                txtJuzgado.Text = string.Empty;
            }
            else
            {
                txtJuzgado.Text = detOficilia.sJuzgado;
            }

            if (detOficilia.sContraparte == " ")
            {
                txtContraparte.Text = string.Empty;
            }
            else
            {
                txtContraparte.Text = detOficilia.sContraparte;
            }
            if (detOficilia.sTipoJuicio == " ")
            {
                txtTJuicio.Text = string.Empty;
            }
            else
            {
                txtTJuicio.Text = detOficilia.sTipoJuicio;
            }
           
            txtDescripcion.Text = detOficilia.sOficialia;
        }

        /*Evento click del boton CargarArchivo el cual consume control openFileDialog para permitir seleccionar el archivo que sera cargado*/
        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            //ASIGNA NOMBRE Y FILTROS DEL CONTROL OPENFILEDIALOG
            openFileDialogDocumento.Title       = "Subir Archivos";
            //openFileDialogDocumento.Filter = "Pdf Files|*.pdf |JPG|*.jpg;*.jpeg |Excel Files|*.xls;*.xlsx;*.xlsm |txt files (*.txt)|*.txt|Zip Files|*.zip;*.rar";
            openFileDialogDocumento.FileName    = "";
            openFileDialogDocumento.ShowDialog();
            txtRutaArchivo.Text                 = openFileDialogDocumento.FileName;
        }

        /*Evento click boton Cargar, Ingresa la hora en la que fue la recpecion del documento asi como la carga de archivo*/
        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                new DSDetalleServicio().recepcionDocumentoOficialia(iIdOficial);
                cargaArchivo();
                Close();
            }
            catch (Exception ex)
            {
            }
        }

        /*Funcion para cargar archivo */
        public void cargaArchivo()
        {
            try
            {
                if (!Directory.Exists(rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + "EventoOficialia" + "\\" + iIdOficial))
                {
                    Directory.CreateDirectory(rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + "EventoOficialia" + "\\" + iIdOficial);
                }

                //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO
                var fileCount = (from file in Directory.EnumerateFiles(rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + "EventoOficialia" + "\\" + iIdOficial) select file).Count();
                int i = fileCount - 1;


                foreach (string fileName in openFileDialogDocumento.FileNames)
                {
                    //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
                    i++;
                    File.Copy(fileName, rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + "EventoOficialia" + "\\" + iIdOficial + "\\" + Path.GetFileName(fileName));

                    File.Move(rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + "EventoOficialia" + "\\" + iIdOficial + "\\" + Path.GetFileName(fileName), 
                              rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + "EventoOficialia" + "\\" + iIdOficial + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));


                    EscribirLog("Se copió el archivo " + rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + "EventoOficialia" + "\\" + iIdOficial + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));


                    string ruta = rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + "EventoOficialia" + "\\" + iIdOficial + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName));

                    ////GUARDA UN REGISTRO DE LA RUTA DONDE SE GUARDO EL ARCHIVO
                    new Adjunto().RegistrarRutaAdjunto(iIdOficial, iIdCaso, 1, idUsuario, ruta);

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
        /// <param name="strMessage">Mensaje que se guardara en el log.</param>
        public void EscribirLog(string strMessage)
        {
            //VALIDACIÓN SI EL ARCHIVO EXISTE
            if (!File.Exists(rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + @"EventoOficialia\Log.txt"))
            {
                var myFile = File.Create(rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + @"EventoOficialia\Log.txt");
                myFile.Close();
            }

            //RUTA DE ACCESO DEL ARCHIVO LOG
            string logFile = rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + @"EventoOficialia\Log.txt";

            //APLICA FORMATO AL LOG Y ESCRIBE EL MENSAJE QUE SE PASA EN EL PARAMETRO STRMENSAJE.
            string line = DateTime.Now.ToString() + " | ";
            line += strMessage;
            FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter swFromFileStream = new StreamWriter(fs);
            swFromFileStream.WriteLine(line);
            swFromFileStream.Flush();
            swFromFileStream.Close();
        }

        /*Evento KeyPress evita la escritura de texto en el control*/
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /*Funcion para mover el archivo de la carpeta PropuestaRespuesta*/
        public void moverArchivo(string archivo)
        {
            try
            {
                if (!Directory.Exists(rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + "EventoOficialia" + "\\" + "Eliminados"))
                {
                    Directory.CreateDirectory(rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + "EventoOficialia" + "\\" + "Eliminados");
                }

                System.IO.File.Move(archivo, rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + "EventoOficialia" + "\\" + "Eliminados" + "\\" + Path.GetFileName(archivo));

                EscribirLogEliminado("Se movio el archivo de la carpeta " + iIdOficial + " a la ruta " + rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + "EventoOficialia" + "\\" + "Eliminados" + "\\" + Path.GetFileName(archivo));

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
            if (!File.Exists(rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + "EventoOficialia" + "\\" + @"Eliminados\Log.txt"))
            {
                var myFile = File.Create(rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + "EventoOficialia" + "\\" + @"Eliminados\Log.txt");
                myFile.Close();
            }

            //RUTA DE ACCESO DEL ARCHIVO LOG
            string logFile = rutaAdjuntarArchivo.Path + sNumCliente + "\\" + iIdCaso + "\\" + "EventoOficialia" + "\\" + @"Eliminados\Log.txt";

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

        /*Evento click de boton cancelar para cerrar formulario*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
