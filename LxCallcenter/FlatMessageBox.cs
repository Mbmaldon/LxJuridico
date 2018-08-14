using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter
{
    public partial class FlatMessageBox : Form
    {

        public FlatMessageBox()
        {
            InitializeComponent();
        }
        static FlatMessageBox _FlatMessageBox;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show(string sText, string sBtnSi, string sBtnNo, FlatMessageBoxIcon icon)
        {
            _FlatMessageBox = new FlatMessageBox();
            Form frmSet = Application.OpenForms["FPrincipal"];

            _FlatMessageBox.StartPosition = FormStartPosition.CenterScreen;

            if (string.IsNullOrEmpty(sBtnNo))
            {
                _FlatMessageBox.btnNo.Visible   = false;
                _FlatMessageBox.btnYes.Location = new Point(167, 185);
            }
            _FlatMessageBox.asignarIcono(icon);

            _FlatMessageBox.lblMessage.Text   = sText;
            _FlatMessageBox.btnYes.Text       = sBtnSi;
            _FlatMessageBox.btnNo.Text        = sBtnNo;

			

            _DialogResult                     = DialogResult.No;

			_FlatMessageBox.Activate();
			_FlatMessageBox.ShowDialog();

			return _DialogResult;
        }

        public void asignarIcono(FlatMessageBoxIcon ico)
        {
            if (ico == FlatMessageBoxIcon.Warning)
            {
                _FlatMessageBox.ptbImagenDescripcion.BackgroundImage = Properties.Resources.error_96px;
                _FlatMessageBox.pnlColor.BackColor = Color.FromArgb(251, 192, 45);
            }
            else if (ico == FlatMessageBoxIcon.Error)
            {
                _FlatMessageBox.ptbImagenDescripcion.BackgroundImage = Properties.Resources.cancel_96px;
                _FlatMessageBox.pnlColor.BackColor = Color.FromArgb(213, 55, 51);
            }
            else if (ico == FlatMessageBoxIcon.Information)
            {
                _FlatMessageBox.ptbImagenDescripcion.BackgroundImage = Properties.Resources.checked_96px;
                _FlatMessageBox.pnlColor.BackColor = Color.FromArgb(87, 184, 87);
            }
            else if (ico == FlatMessageBoxIcon.Question)
            {
                _FlatMessageBox.ptbImagenDescripcion.BackgroundImage = Properties.Resources.help_96px;
                _FlatMessageBox.pnlColor.BackColor = Color.FromArgb(33, 150, 243);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            _DialogResult = DialogResult.Yes;
            _FlatMessageBox.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            _DialogResult = DialogResult.No;
            _FlatMessageBox.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Application.OpenForms["EnvioSms"] != null)
            {
                Application.OpenForms["EnvioSms"].BringToFront();
                Application.OpenForms["EnvioSms"].Activate();
            }
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

    public enum FlatMessageBoxIcon
    {
        Error       = 16,
        Question    = 32,
        Warning     = 48,
        Information = 64        
    }
}
