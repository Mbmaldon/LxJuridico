﻿using LogicaCC;
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
    public partial class frmSubirArchivos : Form
    {
        FTPDownload DownloadData = FTPDownload.Instancia;
        public frmSubirArchivos()
        {
            InitializeComponent();
        }

        #region FUNCIONES
        public void StartUploadFile()
        {
            FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(DownloadData.sRutaArchivo + Path.GetFileName(DownloadData.sNombreArchivo));
            ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile;
            ftpWebRequest.Credentials = new NetworkCredential(FTPCredentials.User, FTPCredentials.Password);

            using (Stream inputStream = File.OpenRead(DownloadData.sNombreArchivo))
            using (Stream outputStream = ftpWebRequest.GetRequestStream())
            {
                byte[] buffer = new byte[1024];
                int totalReadBytesCount = 0;
                int readBytesCount;
                while ((readBytesCount = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    outputStream.Write(buffer, 0, readBytesCount);
                    totalReadBytesCount += readBytesCount;
                    var progress = totalReadBytesCount * 100.0 / inputStream.Length;
                    backgroundWorker1.ReportProgress((int)progress, string.Format("{0}|Subiendo archivo...|{1}", totalReadBytesCount, inputStream.Length));
                }
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
        private void frmSubirArchivos_Shown(object sender, EventArgs e)
        {
            lblNombreArchivo.Text = Path.GetFileName(DownloadData.sNombreArchivo);
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            StartUploadFile();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbDescarga.Value = e.ProgressPercentage;
            string[] Info = e.UserState.ToString().Split('|');
            lbProgress.Text = string.Format("{1} MB/{0} MB", BytesToMegabytes(int.Parse(Info[2])).ToString("0.00"), BytesToMegabytes(int.Parse(Info[0])).ToString("0.00"));
            lblStatus.Text = Info[1];
        }

        private void frmSubirArchivos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // QUITAMOS EL EVENTO FORMCLOSING PARA PERMITIR CERRAR EL FORNULARIO.
            this.FormClosing -= new FormClosingEventHandler(this.frmSubirArchivos_FormClosing);
            lblStatus.Text = "Carga completa";
            pnlBtms.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
