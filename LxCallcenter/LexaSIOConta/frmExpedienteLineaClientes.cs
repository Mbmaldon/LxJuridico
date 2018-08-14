using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Net;
using LogicaCC;
using System.Text.RegularExpressions;

namespace LxCallcenter.LexaSIOConta
{
    public partial class frmExpedienteLineaClientes : Form
    {
        FPrincipal _frmPrincipal;
        FTPDownload DownloadData = FTPDownload.Instancia;
        LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;

        List<string> directories = new List<string>();
        public List<LogicaCC.LexaSIOContaLogica.Cliente> clientes;      

        public int      iIdUsuario;
        public string   iIdCliente;
        string sClienteActual   = "";
        string sRutaActual      = "";
        string FolderA          = "";
        string sRutaLink        = "";

        public frmExpedienteLineaClientes()
        {
            InitializeComponent();
            iIdUsuario = int.Parse(AUsuarioData.sIdusuario);
        }      
        
        public void buscarCliente(int iIdUsuario, string sCliente)
        {
            LogicaCC.LexaSIOContaLogica.Cliente cliente = new LogicaCC.LexaSIOContaLogica.Cliente().informacionClienteExLN(iIdUsuario, sCliente);
            if (cliente != null)
            {                
                lblCampoRequerido.Visible     = false;
                lblCampoRequerido.Text        = "*Campo requerido";
                
                lblNombre.Text      = string.Format("{0} {1} {2}", cliente.sNombre, cliente.sAPaterno, cliente.sAMaterno);
                lblNoCliente.Text   = cliente.sCliente;
                lblRfc.Text         = cliente.sRfc;
                lblTelefonoM.Text   = cliente.sNumeroMovil;
                lblCorreoE.Text     = cliente.sCorreoElectronico;
                asignarFotografia(cliente.iIdCliente);
                sRutaActual = "";
                FolderA = "";
                materialLabel3.Text = "";

                sClienteActual = sCliente;

                // Busca el formulario principal abierto para poder hacer uso de sus controles
                _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;

                 cargarCliente(sCliente);
            }
            else
            {
                lblCampoRequerido.Text    = "*El Cliente no existe";
                lblCampoRequerido.Visible = true;
            }
        }

        /// <summary>
        /// Obtiene y asigna la foto de perfil de un cliente, si este no tiene, se le asigna una por default
        /// </summary>
        /// <param name="iIdCliente">Id del Cliente</param>
        void asignarFotografia(int iIdCliente)
        {
			ovalPictureBox1.Image = Properties.Resources.circled_user_male_skin_type_1_2_96px;
		}
       
        private void cargarCliente(string sCliente)
        {
            if (FTPServer.DirectoryExists(string.Format("{0}/{1}/", FTPCredentials.Path, ConnectionString.FolderConnection), FTPCredentials.User, FTPCredentials.Password, sCliente))
            {
                //FlatMessageBox.Show("Expediente encontrado", "OK", string.Empty, FlatMessageBoxIcon.Information);
                //LLenar();
                directories.Clear();
                lvCarpetas.Items.Clear();
                lvCarpetas.Visible  = true;
                separatorControl1.Visible = true;
                //lnkAtras.Visible    = true;
                //lnkAdelante.Visible = true;
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                FlatMessageBox.Show("No se encontro el expediente del cliente", "OK", string.Empty, FlatMessageBoxIcon.Warning);
            }
        }
      
        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            if (contextMenuStrip1.Items[1].Selected)
             {
                if (FlatMessageBox.Show("¿Está seguro de eliminar el archivo?", "SI", "NO", FlatMessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(sRutaActual + lvCarpetas.SelectedItems[0].Text);
                    request.Method = WebRequestMethods.Ftp.DeleteFile;
                    request.Credentials = new NetworkCredential(FTPCredentials.User, FTPCredentials.Password);
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    response.Close();
                    UpdateList();
                }
             }
			else if(contextMenuStrip1.Items[2].Selected)
			{
                // Opción para descargar el archivo seleccionado
                DownloadData.sRutaArchivo       = sRutaActual;
                DownloadData.sNombreArchivo     = lvCarpetas.SelectedItems[0].Text;

                frmDescargarArchivos DownloadFile = new frmDescargarArchivos();
                DownloadFile.StartPosition = FormStartPosition.Manual;
                DownloadFile.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - DownloadFile.Width) - 10
                                                , (Screen.PrimaryScreen.WorkingArea.Height - DownloadFile.Height) - 10);
                DownloadFile.ShowDialog();
			}
            else if (contextMenuStrip1.Items[4].Selected)
            {
                UpdateList();
            }
        }

        public void btnNuevo_Click(object sender, EventArgs e)
        {
            //ASIGNA NOMBRE Y FILTRO DE ARCHIVOS AL CONTROL OPENFILEDIALOG
            openFileDialogDocumentos.Title    = "Subir Archivos";
            //openFileDialogDocumentos.Filter = "Pdf Files|*.pdf |JPG|*.jpg;*.jpeg |Excel Files|*.xls;*.xlsx;*.xlsm |txt files (*.txt)|*.txt|Zip Files|*.zip;*.rar";
            openFileDialogDocumentos.FileName = "";

            string sRuta = lblRuta.Text;

            if (openFileDialogDocumentos.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    DownloadData.sRutaArchivo   = sRutaActual;
                    DownloadData.sNombreArchivo = openFileDialogDocumentos.FileName;

                    frmSubirArchivos UploadFile = new frmSubirArchivos();

                    UploadFile.StartPosition = FormStartPosition.Manual;
                    UploadFile.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - UploadFile.Width) - 10
                                                  , (Screen.PrimaryScreen.WorkingArea.Height - UploadFile.Height) - 10);

                    UploadFile.ShowDialog();
                    UpdateList();
                }
                catch(Exception ex)
                {
                    FlatMessageBox.Show(ex.Message, "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
                }
            }          
        }

        public void NuevaCarpeta()
        {
            if (frmNuevaCarpeta.Show(sRutaActual) == DialogResult.Yes)
                UpdateList();
        }

        /// <summary>
        /// Método Público para escribir un log de los cambios de los archivos del expediente en línea
        /// </summary>
        /// <param name="strMessage">Mensaje que se guardara en el log.</param>
        public void EscribirLog(string strMessage)
        {
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                //VALIDACIÓN SI EL ARCHIVO EXISTE
                if (!File.Exists(string.Format(@"\\192.168.1.34\\Documentos\\{1}\\Documentos\\Clientes\\{0}\Expediente en Linea\Log.txt", iIdCliente, LogicaCC.ConnectionString.FolderConnection)))
                {
                    var myFile = File.Create(string.Format(@"\\192.168.1.34\\Documentos\\{1}\\Documentos\\Clientes\\{0}\Expediente en Linea\Log.txt", iIdCliente, LogicaCC.ConnectionString.FolderConnection));                
                    myFile.Close();
                }

                //RUTA DE ACCESO DEL ARCHIVO LOG
                string logFile = string.Format(@"\\192.168.1.34\Documentos\\{1}\Documentos\Clientes\{0}\Expediente en Linea\Log.txt", iIdCliente, LogicaCC.ConnectionString.FolderConnection);

                //APLICA FORMATO AL LOG Y ESCRIBE EL MENSAJE QUE SE PASA EN EL PARAMETRO STRMENSAJE.
                string line = string.Format("{0} | {1} | ", DateTime.Now, iIdUsuario);
                line += strMessage;
                FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
                StreamWriter swFromFileStream = new StreamWriter(fs);
                swFromFileStream.WriteLine(line);
                swFromFileStream.Flush();
                swFromFileStream.Close();
            //}
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            // Valida si la caja de busqueda no esta vacia
            if (string.IsNullOrEmpty(txtCliente.Text))
            {
                // Envía mensaje notificacndo el campo vacio
                lblCampoRequerido.Text    = "*Campo Requerido";
                lblCampoRequerido.Visible = true;
            }
            else
            {
                // Ejecuta el metodo para realizar la busqueda del cliente
                buscarCliente(int.Parse(AUsuarioData.sIdusuario), txtCliente.Text);
            }
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Convierte a mayusculas
            e.KeyChar = Char.ToUpper(e.KeyChar);
            // Valida si e es Enter para disparar un evento
            if (e.KeyChar == (char)13)
                btnBuscarCliente_Click(sender, e);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            LlenarListView();
        }
        
        public string GetDirection(string directorio, string newDirec)
        {
             return string.Format("{0}{1}/", directorio, newDirec);
        }
   
        private void LlenarListView()
        {
            directories.Clear();
            var root = "";
            if (string.IsNullOrEmpty(materialLabel3.Text))
            {
                root = string.Format("ftp://{0}/{1}/{2}/", FTPCredentials.Path, LogicaCC.ConnectionString.FolderConnection, sClienteActual);
                sRutaActual = root;
            }
            else
            {
                root = GetDirection(sRutaActual, materialLabel3.Text);
                sRutaActual = root;
            }
            
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(root);
            ftpRequest.Credentials = new NetworkCredential(FTPCredentials.User, FTPCredentials.Password);
            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());

            

            //string line = streamReader.ReadLine();
            var line = streamReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                

                var split = new Regex(FTPServer.regex).Match(line);
                string dir = split.Groups["dir"].ToString();
                string filename = split.Groups["filename"].ToString();
                string size = split.Groups["size"].ToString();
                string sFecha = string.Format("{0} {1} {2}", split.Groups["day"], split.Groups["month"], split.Groups["timeyear"]);
                bool isDirectory = !string.IsNullOrWhiteSpace(dir) && dir.Equals("d", StringComparison.OrdinalIgnoreCase);


                //directories.Add(line);
                string sLine = string.Format("{0}|{1}|{2}|{3}", (isDirectory ? "d" : "f"), filename, (isDirectory ? "" : BytesToMegabytes(int.Parse(size)).ToString("0.00") + "MB"), sFecha);
                //directories.Add((isDirectory ? "(d)" : "(f)") + filename);
                //directories.Add(line);
                directories.Add(sLine);
                line = streamReader.ReadLine();
            }

            streamReader.Close();
        }

        /// <summary>
        /// Convierte bytes a megabytes
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        static double BytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string[] Separator = new string[] { "|" };
            directories = directories.OrderBy(s => s.Split(Separator, StringSplitOptions.None)[0]).ToList();
            for (int i = 0; i < directories.Count; i++)
            {
                string[] sDirectory = directories[i].Split('|');
                var Item1 = new ListViewItem(sDirectory[1]);
                Item1.SubItems.Add(sDirectory[2]);
                Item1.SubItems.Add(sDirectory[3]);
                Item1.SubItems.Add(sDirectory[0]);
                Item1.ImageIndex = AsignarIcono(sDirectory[1], sDirectory[0]);

                if (sDirectory[0] == "d")
                {
                    // Valida si la carpeta será una carpeta autorizada
                    if (sDirectory[1].Substring(0, 1) != "-")
                        lvCarpetas.Items.Add(Item1);
                }
                else
                {
                    if (sDirectory[1] != "Log.txt")
                        lvCarpetas.Items.Add(Item1);
                }

            }

            pgbCarga.Visible = false;
            EstadoControles2(true);
            FolderA = materialLabel3.Text;
            lnkHome.Visible = true;
            ShowPaths();

            if (sRutaActual == string.Format("ftp://{0}/{1}/{2}/", FTPCredentials.Path, LogicaCC.ConnectionString.FolderConnection, sClienteActual))
            {
                _frmPrincipal.btnAgregarArchivo.Enabled = false;
                _frmPrincipal.btnNuevaCarpeta.Enabled = false;
            }
            else
            {
                _frmPrincipal.btnAgregarArchivo.Enabled = true;
                _frmPrincipal.btnNuevaCarpeta.Enabled = true;
            }
        }
        
        public int AsignarIcono(string sArchivo, string sTipo)
        {
            int iResultado = 7;
            if (sTipo == "d")
                iResultado = 0;
            else
            {
                string ext = Path.GetExtension(sArchivo);
                if (ext == ".png"
                 || ext == ".JPG"
                 || ext == ".JPEG"
                 || ext == ".jpg"
                 || ext == ".ico")
                {
                    iResultado = 1;
                }
                else if (ext == ".txt")
                {
                    iResultado = 2;
                }
                else if (ext == ".pdf")
                {
                    iResultado = 3;
                }
                else if (ext == ".bak" || ext == ".sql")
                {
                    iResultado = 4;
                }
                else if (ext == ".zip" || ext == ".rar")
                {
                    iResultado = 5;
                }
                else if (ext == ".xlsx" || ext == ".xls")
                {
                    iResultado = 6;
                }
                else if (ext == ".xml" || ext == ".XML")
                {
                    iResultado = 7;
                }
                else if (ext == ".cer")
                {
                    iResultado = 8;
                }
                else if (ext == ".docx" || ext == ".doc")
                {
                    iResultado = 10;
                }
                else
                {
                    iResultado = 9;
                }
            }
            return iResultado;
        }

        public void ShowPaths()
        {
            flowLayoutPanel2.Controls.Clear();
            string[] PathL = sRutaActual.Split(new[] { txtCliente.Text }, StringSplitOptions.None);

            string[] PathLS = PathL[1].Split('/');

            for (int i = 1; i < PathLS.Length; i++)
            {
                MetroFramework.Controls.MetroLink lnkRuta = new MetroFramework.Controls.MetroLink();
                lnkRuta.AutoSize = true;
                lnkRuta.AutoSizeMode = AutoSizeMode.GrowOnly;
                lnkRuta.Text = PathLS[i];
                lnkRuta.FontSize = MetroFramework.MetroLinkSize.Tall;
                lnkRuta.FontWeight = MetroFramework.MetroLinkWeight.Regular;
                metroToolTip1.SetToolTip(lnkRuta, PathLS[i]);
                lnkRuta.Click += LnkRuta_Click;
                if (i == PathLS.Length - 2)
                    lnkRuta.Enabled = false;

                MaterialSkin.Controls.MaterialLabel lblSeparator = new MaterialSkin.Controls.MaterialLabel();
                lblSeparator.AutoSize = false;
                lblSeparator.Size = new Size(14, 27);
                lblSeparator.TextAlign = ContentAlignment.BottomLeft;
                lblSeparator.Text = "➤";// "→";
                
                    

                flowLayoutPanel2.Controls.Add(lnkRuta);
                if (i < (PathLS.Length - 2))
                    flowLayoutPanel2.Controls.Add(lblSeparator);
                else
                    break;
            }
        }

        private void LnkRuta_Click(object sender, EventArgs e)
        {
            pgbCarga.Visible = true;
            MetroFramework.Controls.MetroLink lnkRuta = sender as MetroFramework.Controls.MetroLink;
            string[] PathL  = sRutaActual.Split(new[] { lnkRuta.Text }, StringSplitOptions.None);
            sRutaLink = string.Format("{0}{1}/", PathL[0], lnkRuta.Text);
            lvCarpetas.Items.Clear();
            bgwLinks.RunWorkerAsync();
        }

        private void lvCarpetas_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvCarpetas.SelectedItems.Count > 0)
            {
                if (lvCarpetas.SelectedItems[0].SubItems[3].Text == "d")
                {
                    pgbCarga.Visible = true;
                    materialLabel3.Text = lvCarpetas.SelectedItems[0].Text;
                    EstadoControles2(false);
                    lvCarpetas.Items.Clear();
                    backgroundWorker1.RunWorkerAsync();
                }
                else
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        public void EstadoControles2(bool bEstado)
        {
            txtCliente.Enabled = bEstado;
            btnBuscarCliente.Enabled = bEstado;
            lvCarpetas.Enabled = bEstado;
        }

        private void bgwLinks_DoWork(object sender, DoWorkEventArgs e)
        {
            LlenarListViewByLink();
        }

        private void LlenarListViewByLink()
        {
            directories.Clear();
            var root = "";

            root = sRutaLink;
            sRutaActual = root;

            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(root);
            ftpRequest.Credentials = new NetworkCredential(FTPCredentials.User, FTPCredentials.Password);
            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());



            //string line = streamReader.ReadLine();
            var line = streamReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                var split = new Regex(FTPServer.regex).Match(line);
                string dir = split.Groups["dir"].ToString();
                string filename = split.Groups["filename"].ToString();
                string size = split.Groups["size"].ToString();
                string sFecha = string.Format("{0} {1} {2}", split.Groups["day"], split.Groups["month"], split.Groups["timeyear"]);
                bool isDirectory = !string.IsNullOrWhiteSpace(dir) && dir.Equals("d", StringComparison.OrdinalIgnoreCase);

                string sLine = string.Format("{0}|{1}|{2}|{3}", (isDirectory ? "d" : "f"), filename, (isDirectory ? "" : BytesToMegabytes(int.Parse(size)).ToString("0.00") + "MB"), sFecha);

                directories.Add(sLine);
                line = streamReader.ReadLine();
            }
            streamReader.Close();
        }

        public void UpdateList()
        {
            if (!string.IsNullOrEmpty(sClienteActual))
            {
                pgbCarga.Visible = true;
                EstadoControles2(false);
                lvCarpetas.Items.Clear();
                bgwUpdate.RunWorkerAsync();
            }
        }

        private void bgwUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateListView();
        }

        private void UpdateListView()
        {
            directories.Clear();
            var root = "";

            root = sRutaActual;


            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(root);
            ftpRequest.Credentials = new NetworkCredential(FTPCredentials.User, FTPCredentials.Password);
            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());



            //string line = streamReader.ReadLine();
            var line = streamReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                var split = new Regex(FTPServer.regex).Match(line);
                string dir = split.Groups["dir"].ToString();
                string filename = split.Groups["filename"].ToString();
                string size = split.Groups["size"].ToString();
                string sFecha = string.Format("{0} {1} {2}", split.Groups["day"], split.Groups["month"], split.Groups["timeyear"]);
                bool isDirectory = !string.IsNullOrWhiteSpace(dir) && dir.Equals("d", StringComparison.OrdinalIgnoreCase);

                string sLine = string.Format("{0}|{1}|{2}|{3}", (isDirectory ? "d" : "f"), filename, (isDirectory ? "" : BytesToMegabytes(int.Parse(size)).ToString("0.00") + "MB"), sFecha);

                directories.Add(sLine);
                line = streamReader.ReadLine();
            }
            streamReader.Close();
        }

        private void bgwUpdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string[] Separator = new string[] { "|" };
            directories = directories.OrderBy(s => s.Split(Separator, StringSplitOptions.None)[0]).ToList();
            for (int i = 0; i < directories.Count; i++)
            {
                string[] sDirectory = directories[i].Split('|');
                var Item1 = new ListViewItem(sDirectory[1]);
                Item1.SubItems.Add(sDirectory[2]);
                Item1.SubItems.Add(sDirectory[3]);
                Item1.SubItems.Add(sDirectory[0]);
                Item1.ImageIndex = AsignarIcono(sDirectory[1], sDirectory[0]);
                if (sDirectory[0] == "d")
                {
                    // Valida si la carpeta será una carpeta autorizada
                    if (sDirectory[1].Substring(0, 1) != "-")
                        lvCarpetas.Items.Add(Item1);
                }
                else
                {
                    if (sDirectory[1] != "Log.txt")
                        lvCarpetas.Items.Add(Item1);
                }
            }

            pgbCarga.Visible = false;
            EstadoControles2(true);
            lnkHome.Visible = true;
        }
    }
}
