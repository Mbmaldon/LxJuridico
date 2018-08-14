using LogicaCC;
using LogicaCC.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter
{
    public partial class frmProspectosAltaMasiva : Form
    {
        UsuarioData AUsuarioData = UsuarioData.Instancia;
        private byte[] downloadedData;
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        string sRegimen;
        public frmProspectosAltaMasiva()
        {
            InitializeComponent();
            InitializeControls();
        }




        #region Funciones
        /// <summary>
        /// Inicializa la información que se cargara desde
        /// un principio en el formulario
        /// </summary>
        public void InitializeControls()
        {
            LoadRegimen();
        }

        /// <summary>
        /// Carga un listado de regimenes
        /// </summary>
        public void LoadRegimen()
        {
            cmbxRegimen.DataSource    = new Regimen().GetList();
            cmbxRegimen.ValueMember   = "iIdRegimen";
            cmbxRegimen.DisplayMember = "sRegimen";
            cmbxRegimen.SelectedIndex = -1;
        }

        /// <summary>
        /// Descarga una plnatilla para el registro de prospectos
        /// de acuerdo al regimen seleccionado
        /// </summary>
        public void DownloadTemplate()
        {
            lnkPlantilla.Visible = false;
            pnlDescarga.Visible = true;
            string FileName;
            FileName = cmbxRegimen.SelectedValue.ToString() == "1" ? "Layout_Fisica.xlsx" : "Layout_Moral.xlsx";
            string FullPath = string.Format("{0}/Templates/", FTPCredentials.Path);
            string LocalPath = string.Format("C:\\Users\\{0}\\Downloads\\", Environment.UserName);
            //FTPServer.Download(FullPath, FTPCredentials.User, FTPCredentials.Password, FileName, LocalPath);

            downloadFile(FullPath, FileName, FTPCredentials.User, FTPCredentials.Password);
        }



        public bool ValidateForm()
        {
            bool bResultado = true;
            return bResultado;
        }

        public void SaveAll()
        {
            pnlPlantilla.Visible = false;
            pnlCarga.Visible     = true;
            cmbxRegimen.Enabled  = false;
            btnCancelar.Enabled  = false;
            lnkCerrar.Enabled    = false;

            pgbCargaBancos.Value    = 0;
            pgbCargaBancos.Visible  = true;
            lblArchivos.Text        = "";
            lblRegistros.Text       = "";
            bgwCarga.RunWorkerAsync();
        }

        public void Save(DoWorkEventArgs e)
        {
            string sFilePath = ofdArchivoCarga.FileName;          // Ruta del archivo
            string sExtension = Path.GetExtension(sFilePath); // Extensión del archivo
            string sHeader = "YES";                        // Leer los headers del documento
            string ConnectionString, sheetName;
            ConnectionString = string.Empty;

            int i, iTotal;

            switch (sExtension) // Establece el formato del archivo y la cadena de conexión
            {
                case ".xls":  // Excel 97-03
                    ConnectionString = string.Format(Excel03ConString, sFilePath, sHeader);
                    break;
                case ".xlsx": // Excel 07-16
                    ConnectionString = string.Format(Excel07ConString, sFilePath, sHeader);
                    break;
                case ".XLS":  // Excel 97-03
                    ConnectionString = string.Format(Excel03ConString, sFilePath, sHeader);
                    break;
                case ".XLSX": // Excel 07-16
                    ConnectionString = string.Format(Excel07ConString, sFilePath, sHeader);
                    break;
            }



            // INICIA
            DataTable _DTProspectos = new DataTable();
            sheetName = sGetSheet(1, ConnectionString); // 1 Personas Fisica
            _DTProspectos = GetTable(ConnectionString, sheetName, sRegimen == "1" ? "Nombre" : "Razón Social");

            i = 0;
            iTotal = _DTProspectos.Rows.Count;

            foreach (DataRow row in _DTProspectos.Rows)
            {
                i = i + 1;
                Thread.Sleep(100);
                int percents = (i * 100) / iTotal;
                bgwCarga.ReportProgress(percents, string.Format("Persona Física-{1}/{0}", iTotal, i));
                if (row[0].ToString() != string.Empty || row[1].ToString() != string.Empty)
                {
                    try
                    {
                        if (sRegimen == "1")
                        {
                            string  sNombre     = row[0].ToString(); // Nombre
                            string  sAPaterno   = row[1].ToString(); // Apellido Paterno
                            string  sAMaterno   = row[2].ToString(); // Apellido Materno
                            int     iEdad       = int.Parse(row[3].ToString()); // Edad
                            string  sCorreo     = row[4].ToString(); // Correo Electrónico
                            string  sTelefono   = row[5].ToString(); // Teléfono
                            int     iIdGenero   = int.Parse(row[7].ToString()); // IdGenero
                            string  sCodigoP    = row[8].ToString(); // Código Postal
                            int     iIdEstado   = int.Parse(row[10].ToString());
                            string  sDomicilio  = row[11].ToString(); // Domicilio
                            int     iIdAgente   = int.Parse(row[12].ToString()); // IdAgente

                            new Prospecto().NewItem(int.Parse(AUsuarioData.sIdusuario), sNombre
                                                  , sAPaterno, sAMaterno
                                                  , iEdad, sCorreo
                                                  , sTelefono, iIdGenero
                                                  , sCodigoP, iIdEstado
                                                  , sDomicilio, iIdAgente);
                        }
                        else
                        {
                            string  sRazon      = row[0].ToString(); // Razón Social
                            string  sRfc        = row[1].ToString(); // RFC
                            int     iIdEstado   = int.Parse(row[3].ToString()); // IdEstado
                            string  sCodigo     = row[4].ToString(); // Código postal
                            string  sDomicilio  = row[5].ToString(); // Domicilio
                            string  sNombre     = row[6].ToString(); // Nombre
                            string  sAPaterno   = row[7].ToString(); // Apellido Paterno
                            string  sAMaterno   = row[8].ToString(); // Apellido Materno
                            string  sPuesto     = row[9].ToString(); // Puesto
                            string  sCorreo     = row[10].ToString(); // Correo Electrónico
                            string  sTelefono   = row[11].ToString(); // Teléfono
                            int     iIdAgente   = int.Parse(row[12].ToString()); // IdAgente

                            new Prospecto().NewItem(int.Parse(AUsuarioData.sIdusuario), sRazon
                                                  , sRfc, iIdEstado
                                                  , sCodigo, sDomicilio
                                                  , sNombre, sAPaterno
                                                  , sAMaterno, sPuesto
                                                  , sCorreo, sTelefono
                                                  , iIdAgente);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            // TERMINA
        }

        /// <summary>
		/// Obtiene el nombre de la hoja de trabajo
		/// </summary>
		/// <param name="iNoHoja">Número de hoja</param>
		/// <param name="ConnectionString">Cadena de conexión</param>
		/// <returns></returns>
		public string sGetSheet(int iNoHoja, string ConnectionString)
        {
            using (OleDbConnection _OleDbConnection = new OleDbConnection(ConnectionString))
            {
                using (OleDbCommand _OleDbCommand = new OleDbCommand())
                {
                    _OleDbCommand.Connection = _OleDbConnection;
                    _OleDbConnection.Open();
                    DataTable _DTExcelSchema = _OleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    string sheet = _DTExcelSchema.Rows[iNoHoja]["TABLE_NAME"].ToString();
                    _OleDbConnection.Close();
                    return sheet;
                }
            }
        }

        /// <summary>
        /// Regresa una tabla con el contenido de la hoja que se requiere
        /// </summary>
        /// <param name="ConnectionString">Cadena de conexión</param>
        /// <param name="SheetName">Nombre de la hoja de  trabajo</param>
        /// <returns></returns>
        public DataTable GetTable(string ConnectionString, string SheetName, string ColumnName)
        {
            DataTable _DataTable = new DataTable();
            using (OleDbConnection _OleDbConnection = new OleDbConnection(ConnectionString))
            {
                using (OleDbCommand _OleDbCommand = new OleDbCommand())
                {
                    using (OleDbDataAdapter _OleDbDataAdapter = new OleDbDataAdapter())
                    {
                        //DataTable _DataTable = new DataTable();
                        if (string.IsNullOrEmpty(ColumnName))
                            _OleDbCommand.CommandText = string.Format("SELECT * FROM [{0}]", SheetName);
                        else
                            _OleDbCommand.CommandText = string.Format("SELECT * FROM [{0}] WHERE [{1}] IS NOT NULL", SheetName, ColumnName);

                        _OleDbCommand.Connection = _OleDbConnection;
                        _OleDbConnection.Open();
                        _OleDbDataAdapter.SelectCommand = _OleDbCommand;
                        _OleDbDataAdapter.Fill(_DataTable);
                        _OleDbConnection.Close();
                    }
                }
            }
            return _DataTable;
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

        /// <summary>
        /// Conecta al servidor FTP y descarga archivos
        /// </summary>
        /// <param name="FTPAddress"></param>
        /// <param name="filename"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        private void downloadFile(string FTPAddress, string filename, string username, string password)
        {
            downloadedData = new byte[0];

            try
            {
                //Optional
                lblStatus.Text = "Conectando...";
                Application.DoEvents();

                //Create FTP request
                //Note: format is ftp://server.com/file.ext
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", FTPAddress, filename));

                //Optional
                lblStatus.Text = "Recibiendo Información...";
                Application.DoEvents();

                //Get the file size first (for progress bar)
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                request.Credentials = new NetworkCredential(username, password);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true; //don't close the connection

                int dataLength = (int)request.GetResponse().ContentLength;

                //Optional
                lblStatus.Text = "Descargando Archivo...";
                Application.DoEvents();

                //Now get the actual data
                request = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", FTPAddress, filename));
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(username, password);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false; //close the connection when done

                //Set up progress bar
                pgbDescarga.Value = 0;
                pgbDescarga.Maximum = dataLength;
                lbProgress.Text = "0 MB/" + BytesToMegabytes(dataLength).ToString("0.00") + "MB";

                //Streams
                FtpWebResponse response = request.GetResponse() as FtpWebResponse;
                Stream reader = response.GetResponseStream();

                //Download to memory
                //Note: adjust the streams here to download directly to the hard drive
                MemoryStream memStream = new MemoryStream();
                byte[] buffer = new byte[1024]; //downloads in chuncks

                while (true)
                {
                    Application.DoEvents(); //prevent application from crashing

                    //Try to read the data
                    int bytesRead = reader.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        //Nothing was read, finished downloading
                        pgbDescarga.Value = pgbDescarga.Maximum;
                        lbProgress.Text = string.Format("{0} MB/{0} MB", BytesToMegabytes(dataLength).ToString("0.00"));

                        Application.DoEvents();
                        break;
                    }
                    else
                    {
                        //Write the downloaded data
                        memStream.Write(buffer, 0, bytesRead);

                        //Update the progress bar
                        if (pgbDescarga.Value + bytesRead <= pgbDescarga.Maximum)
                        {
                            pgbDescarga.Value += bytesRead;
                            lbProgress.Text = string.Format("{0} MB/{1} MB", BytesToMegabytes(pgbDescarga.Value).ToString("0.00"), BytesToMegabytes(dataLength).ToString("0.00"));

                            pgbDescarga.Refresh();
                            Application.DoEvents();
                        }
                    }
                }

                //Convert the downloaded stream to a byte array
                downloadedData = memStream.ToArray();

                //Clean up
                reader.Close();
                memStream.Close();
                response.Close();

                //MessageBox.Show("Downloaded Successfully");
            }
            catch (Exception)
            {
                FlatMessageBox.Show("Error conectando al servidor FTP.", "OK", string.Empty, FlatMessageBoxIcon.Error);
            }

            lblStatus.Text = "Descargando datos";

            username = string.Empty;
            password = string.Empty;

            SaveDownload(filename);
        }

        /// <summary>
        /// Guarda el archivo descargado
        /// </summary>
        /// <param name="fileName"></param>
        public void SaveDownload(string fileName)
        {
            if (downloadedData != null && downloadedData.Length != 0)
            {
                lblStatus.Text = "Guardando...";
                Application.DoEvents();

                //Write the bytes to a file
                string LocalPath = string.Format("C:\\Users\\{0}\\Downloads\\{1}", Environment.UserName, fileName);
                FileStream newFile = new FileStream(LocalPath, FileMode.Create);
                newFile.Write(downloadedData, 0, downloadedData.Length);
                newFile.Close();

                lblStatus.Text = "Descarga Completa";
                FlatMessageBox.Show("Descarga completa correctamente", "OK", string.Empty, FlatMessageBoxIcon.Information);
                pnlDescarga.Visible = false;
                lnkPlantilla.Visible = true;

                pgbDescarga.Value = 0;
                lbProgress.Text = "";
                lblStatus.Text = "";
            }
            else
                FlatMessageBox.Show("No se encontraron archivos para guardar!", "OK", string.Empty, FlatMessageBoxIcon.Warning);
        }
        #endregion

        #region Eventos
        private void lnkCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbxRegimen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pnlCarga.Visible            = false;
            txtArchivoCarga.Text        = "";
            ofdArchivoCarga.FileName    = "";
            btnGuardar.Visible          = false;
            pnlPlantilla.Visible        = true;
            sRegimen = cmbxRegimen.SelectedValue.ToString();
        }

        private void lnkSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            if (ofdArchivoCarga.ShowDialog() == DialogResult.OK)
            {
                btnGuardar.Visible   = true;
                txtArchivoCarga.Text = ofdArchivoCarga.FileName;             
            }
        }

        private void lnkPlantilla_Click(object sender, EventArgs e)
        {
            DownloadTemplate();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
                SaveAll();
        }
        #endregion       

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

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;

        }

        #endregion

        private void bgwCarga_DoWork(object sender, DoWorkEventArgs e)
        {
            Save(e);
        }

        private void bgwCarga_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbCargaBancos.Value = e.ProgressPercentage;
            lblPorcentaje.Text = String.Format("{0} %", e.ProgressPercentage);
            string[] sUserState = e.UserState.ToString().Split('-');

            lblArchivos.Text = sUserState[0];
            lblRegistros.Text = sUserState[1];
        }

        private void bgwCarga_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Operación Cancelada");
                btnGuardar.Enabled = true;
                pnlPlantilla.Visible = true;
                pnlCarga.Visible     = false;
                cmbxRegimen.Enabled  = true;
                btnCancelar.Enabled  = true;
                lnkCerrar.Enabled    = true;

                pgbCargaBancos.Value    = 0;
                pgbCargaBancos.Visible  = false;
                lblArchivos.Text        = "";
                lblRegistros.Text       = "";
            }
            else
            {
                lblArchivos.Text = "Operación Completa";

                btnGuardar.Enabled = true;
                btnCancelar.Enabled  = true;
                lnkCerrar.Enabled    = true;
                SystemSounds.Hand.Play();

                frmProspectos _Prospectos = Application.OpenForms["frmProspectos"] as frmProspectos;
                if (_Prospectos != null)
                    _Prospectos.LoadProspectos();

            }

            if (e.Error != null)
            {
                MessageBox.Show("Error! " + e.Error.ToString());
            }
        }
    }
}
