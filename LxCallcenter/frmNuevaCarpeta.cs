using LogicaCC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter
{
    public partial class frmNuevaCarpeta : Form
    {
        public string sRutaActual;
        public frmNuevaCarpeta()
        {
            InitializeComponent();
        }

        static frmNuevaCarpeta _NuevaCarpeta;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show(string sRuta)
        {
            _NuevaCarpeta = new frmNuevaCarpeta();
            Form frmSet = Application.OpenForms["FPrincipal"];

            _NuevaCarpeta.StartPosition = FormStartPosition.CenterScreen;

            // Código inicializate aquí
            _NuevaCarpeta.sRutaActual = sRuta;

            _DialogResult = DialogResult.No;

            _NuevaCarpeta.Activate();
            _NuevaCarpeta.ShowDialog();

            return _DialogResult;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_NuevaCarpeta.txtNombreCarpeta.Text))
            {
                _NuevaCarpeta.CreateDirectory();
            }

            
        }

        public void CreateDirectory()
        {
            WebRequest request = WebRequest.Create(string.Format("{0}{1}", sRutaActual, _NuevaCarpeta.txtNombreCarpeta.Text));
            request.Method = WebRequestMethods.Ftp.MakeDirectory;
            request.Credentials = new NetworkCredential(FTPCredentials.User, FTPCredentials.Password);
            var resp = (FtpWebResponse)request.GetResponse();

            _DialogResult = DialogResult.Yes;
            _NuevaCarpeta.Close();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _DialogResult = DialogResult.No;
            _NuevaCarpeta.Close();
        }

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
