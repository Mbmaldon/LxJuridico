using LogicaCC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter
{
    public partial class frmDescargarArchivos : Form
    {
        FTPDownload DownloadData = FTPDownload.Instancia;
        public frmDescargarArchivos()
        {
            InitializeComponent();
        }

        #region FUNCIONES
        public void InitializeControls()
        {
            lblNombreArchivo.Text = DownloadData.sNombreArchivo;
            backgroundWorker1.RunWorkerAsync();
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

        public void StartDownloadFile(string FTPAddress, string filename, string username, string password)
        {

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(string.Format("{0}/{1}", FTPAddress, filename));
            request.Credentials = new NetworkCredential(username, password);
            request.Method = WebRequestMethods.Ftp.GetFileSize;
            request.Proxy = null;

            long fileSize; // this is the key for ReportProgress
            using (WebResponse resp = request.GetResponse()) fileSize = resp.ContentLength;

            request = (FtpWebRequest)WebRequest.Create(string.Format("{0}/{1}", FTPAddress, filename));
            request.Credentials = new NetworkCredential(username, password);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            using (FtpWebResponse responseFileDownload = (FtpWebResponse)request.GetResponse())
            using (Stream responseStream = responseFileDownload.GetResponseStream())
            using (FileStream writeStream = new FileStream(string.Format("C:\\Users\\{0}\\Downloads\\{1}", Environment.UserName, filename), FileMode.Create))
            {
                byte[] buffer = new byte[1024];
                int totalReadBytesCount = 0;
                int readBytesCount;

                while ((readBytesCount = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    writeStream.Write(buffer, 0, readBytesCount);
                    totalReadBytesCount += readBytesCount;// don't forget to increment bytesRead !
                    var progress = totalReadBytesCount * 100.0 / fileSize;
                    backgroundWorker1.ReportProgress((int)progress, string.Format("{0}|Descargando archivo...|{1}", totalReadBytesCount, fileSize));

                }
            }
        }
        #endregion

        #region EVENTOS
        private void frmDescargarArchivos_Shown(object sender, EventArgs e)
        {
            InitializeControls();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (File.Exists(string.Format("C:\\Users\\{0}\\Downloads\\{1}", Environment.UserName, DownloadData.sNombreArchivo)))
                Process.Start(string.Format("C:\\Users\\{0}\\Downloads\\{1}", Environment.UserName, DownloadData.sNombreArchivo));
            else
                FlatMessageBox.Show("No se encontro el archivo", "OK", string.Empty, FlatMessageBoxIcon.Warning);
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            MaterialSkin.Controls.MaterialRaisedButtonCustom lnkMenu = (MaterialSkin.Controls.MaterialRaisedButtonCustom)sender;
            Point ptLowerLeft = new Point(-160, -25);
            ptLowerLeft = lnkMenu.PointToScreen(ptLowerLeft);
            materialContextMenuStrip1.Show(ptLowerLeft);
        }

        private void mostrarEnCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string argument = "/select, \"" + string.Format("C:\\Users\\{0}\\Downloads\\{1}", Environment.UserName, DownloadData.sNombreArchivo) + "\"";
            Process.Start("explorer.exe", argument);
        }

        private void frmDescargarArchivos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string FileName;
            // Nombre del archivo
            FileName = DownloadData.sNombreArchivo;

            string FullPath = DownloadData.sRutaArchivo;
            string LocalPath = string.Format("C:\\Users\\{0}\\Downloads\\", Environment.UserName);

            StartDownloadFile(FullPath, FileName, FTPCredentials.User, FTPCredentials.Password);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbDescarga.Value = e.ProgressPercentage;
            string[] Info = e.UserState.ToString().Split('|');
            lbProgress.Text = string.Format("{1} MB/{0} MB", BytesToMegabytes(int.Parse(Info[2])).ToString("0.00"), BytesToMegabytes(int.Parse(Info[0])).ToString("0.00"));
            lblStatus.Text = Info[1];
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "Descarga completa";

            // QUITAMOS EL EVENTO FORMCLOSING PARA PERMITIR CERRAR EL FORNULARIO.
            this.FormClosing -= new FormClosingEventHandler(this.frmDescargarArchivos_FormClosing);
            pnlBtms.Visible = true;
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

            //if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
            //    m.Result = (IntPtr)HTCAPTION;

        }


        #endregion
    }
}
