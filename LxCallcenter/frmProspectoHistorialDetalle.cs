using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraLayout;
using LogicaCC;
using LogicaCC.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter
{
    public partial class frmProspectoHistorialDetalle : Form
    {
        int iTipoLlamada;
        bool bExiste = false;
        string sPath = "";
        private byte[] downloadedData;
        MRUEdit edit;
        Llamada Llamada;
        Prospecto _ProspectoData = Prospecto.Instancia;
        Bitmap play_52px = Properties.Resources.play_52px;
        Bitmap pause_52px = Properties.Resources.pause_52px;

        public frmProspectoHistorialDetalle()
        {
            InitializeComponent();
            InitializeControls();
        }

        #region FUNCIONES
        /// <summary>
        /// Inicia la información de los controles
        /// </summary>
        public void InitializeControls()
        {
            lnkPlay.Image = play_52px;
            lnkPlay.NoFocusImage = play_52px;
            LoadHistoryCalls(0);
        }

        /// <summary>
        /// Llena los grids del historial de llamadas
        /// </summary>
        /// <param name="iTipoLlamada"></param>
        public void LoadHistoryCalls(int iTipoLlamada)
        {
            grdLlamadas.DataSource = new Llamada().GetList(_ProspectoData.iIdProspecto, iTipoLlamada);
            CountCalls();
        }

        /// <summary>
        /// Cuenta el total de registros que se muestran el el GridView de llamadas
        /// </summary>
        public void CountCalls()
        {
            if (gridView1.RowCount > 0)
                lblNoRegitros.Text = string.Format("No. de Registros: {0}", gridView1.RowCount);
            else
                lblNoRegitros.Text = "No. de Registros: --";
        }

        public bool PathRecordExist()
        {
            //if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            //    return false;

            string sRuta = string.Format(@"{0}\mpy\records", Path.GetTempPath());
            if (!Directory.Exists(sRuta))
            {
                Directory.CreateDirectory(sRuta);
                return true;
            }
            else
                return true;
        }

        public bool RecordExists()
        {
            bool bResultado = false;
            try
            {
                string FileName = string.Format("pcll-{0}.wav", Llamada.iIdLlamada);
                string FullPath = string.Format("{0}/{1}/Records/", FTPCredentials.Path, ConnectionString.FolderConnection);
                string LocalPath = string.Format(@"{0}\mpy\records\", Path.GetTempPath());

                if (!File.Exists(string.Format("{0}{1}", LocalPath, FileName)))
                {
                    pnlDescarga.Visible = true;
                    downloadFile(FullPath, FileName, FTPCredentials.User, FTPCredentials.Password);
                    pnlDescarga.Visible = false;
                }

                bResultado = true;
            }
            catch (Exception)
            {
                bResultado = false;
            }

            return bResultado;
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
                string FullPath = string.Format("{0}/{1}/Records/", FTPCredentials.Path, ConnectionString.FolderConnection);
                if (bExiste = FTPServer.CheckIfFileExistsOnServer(FullPath, FTPCredentials.User, FTPCredentials.Password, string.Format("pcll-{0}.wav", Llamada.iIdLlamada)))
                {


                    //else


                    //Optional
                    //lblStatus.Text = "Conectando...";
                    Application.DoEvents();

                    //Create FTP request
                    //Note: format is ftp://server.com/file.ext
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", FTPAddress, filename));

                    //Optional
                    //lblStatus.Text = "Recibiendo Información...";
                    Application.DoEvents();

                    //Get the file size first (for progress bar)
                    request.Method = WebRequestMethods.Ftp.GetFileSize;
                    request.Credentials = new NetworkCredential(username, password);
                    request.UsePassive = true;
                    request.UseBinary = true;
                    request.KeepAlive = true; //don't close the connection

                    int dataLength = (int)request.GetResponse().ContentLength;

                    //Optional
                    //lblStatus.Text = "Descargando Archivo...";
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

                    lbProgress.Visible = true;
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
                    lbProgress.Visible = false;

                    //Convert the downloaded stream to a byte array
                    downloadedData = memStream.ToArray();

                    //Clean up
                    reader.Close();
                    memStream.Close();
                    response.Close();
                }

            }
            catch (Exception)
            {
                FlatMessageBox.Show("Error conectando al servidor FTP.", "OK", string.Empty, FlatMessageBoxIcon.Error);
            }

            //lblStatus.Text = "Descargando datos";

            username = string.Empty;
            password = string.Empty;

            if (bExiste)
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
                //lblStatus.Text = "Guardando...";
                Application.DoEvents();

                //Write the bytes to a file
                //string LocalPath = string.Format("C:\\Users\\{0}\\Downloads\\{1}", Environment.UserName, fileName);
                string LocalPath = string.Format(@"{0}\mpy\records\{1}", Path.GetTempPath(), fileName);
                FileStream newFile = new FileStream(LocalPath, FileMode.Create);
                newFile.Write(downloadedData, 0, downloadedData.Length);
                newFile.Close();
                sPath = LocalPath;
            }
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
        #endregion

        #region EVENTOS
        private void lnkCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkPlay_Click(object sender, EventArgs e)
        {
            if (PathRecordExist())
            {
                if (RecordExists())
                {
                    if (string.IsNullOrEmpty(axWindowsMediaPlayer1.URL))
                        axWindowsMediaPlayer1.URL = sPath;

                    if (bExiste)
                    {
                        if (lnkPlay.Image == play_52px)
                        {
                            lnkPlay.Image = pause_52px;
                            lnkPlay.NoFocusImage = pause_52px;
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                        }
                        else
                        {
                            lnkPlay.Image = play_52px;
                            lnkPlay.NoFocusImage = play_52px;
                            axWindowsMediaPlayer1.Ctlcontrols.pause();
                        }
                    }
                }
            }
        }

        private void TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            //axWindowsMediaPlayer1.Ctlcontrols.currentPosition = TrackBar.Value;
            //tmrPlayer.Enabled = false;
        }

        private void TrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            //tmrPlayer.Enabled = false;
        }

        private void TrackBar_MouseLeave(object sender, EventArgs e)
        {
            //tmrPlayer.Enabled = true;
        }

        private void tbTipoLlamada_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialSkin.Controls.MaterialTabControl _TabControl = sender as MaterialSkin.Controls.MaterialTabControl;
            if (_TabControl.TabCount > 0)
            {
                pnlDetalles.Visible = false;
                iTipoLlamada = _TabControl.SelectedTab.Text == "Llamadas" ? 0 : 1;
                LoadHistoryCalls(iTipoLlamada);
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        }

        private void tmrPlayer_Tick(object sender, EventArgs e)
        {
            TrackBar.Maximum    = (int)axWindowsMediaPlayer1.currentMedia.duration;
            TrackBar.Value      = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            lblTiempo.Text = string.Format("{0}/{1}", axWindowsMediaPlayer1.Ctlcontrols.currentPositionString, axWindowsMediaPlayer1.currentMedia.durationString);
        }
        
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                lnkPlay.Image        = play_52px;
                lnkPlay.NoFocusImage = play_52px;
                lnkPlay.Refresh();
                tmrPlayer.Stop();
            }
            if (e.newState == 3)
            {
                tmrPlayer.Start();
                lnkPlay.Image        = pause_52px;
                lnkPlay.NoFocusImage = pause_52px;
                lnkPlay.Refresh();
            }
            if (e.newState == 1)
            {
                lnkPlay.Image        = play_52px;
                lnkPlay.NoFocusImage = play_52px;
                lblTiempo.Text = "--/--";
                tmrPlayer.Stop();
                TrackBar.Value = 0;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            FindControl find = null;
            foreach (Control ctrl in grdLlamadas.Controls)
                if (ctrl.GetType() == typeof(FindControl))
                    find = ctrl as FindControl;
            if (find != null)
            {
                LayoutControl layout = find.Controls[0] as LayoutControl;
                edit = (layout.Items[2] as LayoutControlItem).Control as MRUEdit;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            edit.Text = txtBuscar.Text.ToString();
            CountCalls();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                // Detenemos la reproducción si existe una grabación reproduciendose
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                // Obtenemos información de la llamada para mostrarla en pantalla
                bool bVisible = iTipoLlamada == 0 ? false : true;
                Llamada = new Llamada().GetDetails(int.Parse(gridView1.GetFocusedRowCellValue("iIdLlamada").ToString()), iTipoLlamada);
                lblFecha.Text = Llamada.dtFecha.ToShortDateString();
                lblHora.Text  = Llamada.tsHora.ToString(@"hh\:mm");
                
                lnkPlay.Image        = play_52px;
                lnkPlay.NoFocusImage = play_52px;
                txtComentarioLlamada.Text = Llamada.sComentario;
                materialLabel3.Visible    = bVisible;
                txtComentariosLlamadaAgendada.Visible = bVisible;
                
                sPath = string.Format(@"{0}\mpy\records\pcll-{1}.wav", Path.GetTempPath(), Llamada.iIdLlamada);
                lnkPlay.Enabled = string.IsNullOrEmpty(sPath) ? false : true;

                if (bVisible)
                {
                    if (Llamada.iIdLlamadaRespuesta == 0)
                    {
                        btnMarca.Text    = "Pendiente";
                        btnMarca.BGColor = "#F4511E";
                    }
                    else
                    {
                        btnMarca.Text    = "Realizada";
                        btnMarca.BGColor = "#43A047";
                    }
                    txtComentarioLlamada.Text          = Llamada.sComentarioLlamada;
                    txtComentariosLlamadaAgendada.Text = Llamada.sComentario;
                }
                else
                {
                    txtComentariosLlamadaAgendada.Text = Llamada.sComentario;
                    btnMarca.Text    = "Realizada";
                    btnMarca.BGColor = "#43A047";
                }

                // Mostramos el panel con la información ya cargada
                pnlDetalles.Visible = true;
            }
        }

        private void frmProspectoHistorialDetalle_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Detenemos la reproducción si existe una grabación reproduciendose
            axWindowsMediaPlayer1.Ctlcontrols.stop();
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
    }
}
