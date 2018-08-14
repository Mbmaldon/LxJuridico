using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.Logica;
using System.Runtime.InteropServices;

namespace LxCallcenter
{
    public partial class Login : Form
    {
        


        private readonly MaterialSkin.MaterialSkinManager materialSkinManager;
		Usuario AUsuario			= null;
		UsuarioData AUsuarioData	= null;
		// CONSTRUCTOR
		public Login()
        {
            // Code for border shadow
            m_aeroEnabled = false;
            //this.FormBorderStyle = FormBorderStyle.None;


            InitializeComponent();
            materialSkinManager             = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.Theme       = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo400, MaterialSkin.Primary.Blue700, MaterialSkin.Primary.Blue700, MaterialSkin.Accent.Blue700, MaterialSkin.TextShade.WHITE);

			InitializeRemember();
		}

		private void InitializeRemember()
		{
			if (Properties.Settings.Default.Usuario != string.Empty)
			{
				txbUsuario.Text			= Properties.Settings.Default.Usuario;
				txbContrasena.Text		= Properties.Settings.Default.Contrasenia;
				tglRecordarme.Checked	= true;
			}		
		}

		private void Remember()
		{
			if (tglRecordarme.Checked)
			{
				Properties.Settings.Default.Usuario		= txbUsuario.Text;
				Properties.Settings.Default.Contrasenia = txbContrasena.Text;
				Properties.Settings.Default.Save();
			}
		}

		// EVENTO BOTON INGRESAR
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidateConnection())
            {
			    txbUsuario.Enabled		    = false;
			    txbContrasena.Enabled	    = false;
			    tglRecordarme.Enabled	    = false;
                btnConfiguracion.Enabled    = false;
                btnIngresar.Visible		    = false;
			    pictureBox2.Visible		    = true;
			    bgwLogin.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show(string.Format("Se requiere configurar la conexión al servidor y bases de datos.{0}{0}Contacte con el administrador."
                              , Environment.NewLine)
                              , "Configuración"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Asterisk);
            }
        }

        private void txbContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            // char 13 (Intro)
            if (e.KeyChar == (char)13)
                btnIngresar_Click(sender, e);
        }

		private void lnkConfigurar_Click(Object sender, EventArgs e)
		{
			this.Close();
		}

		private void bgwLogin_DoWork(Object sender, DoWorkEventArgs e)
		{
			Thread.Sleep(100);
			AUsuario		= new Usuario();
			AUsuarioData	= UsuarioData.Instancia;

            Llamada.RstrDLL();

            AUsuario.ValidarUsuario(txbUsuario.Text, txbContrasena.Text);
		}

		private void bgwLogin_RunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
		{
			if (AUsuarioData.sIdusuario != null)
			{
				pictureBox2.Visible = false;
				Remember();
				this.Hide();
				var form2 = new FPrincipal();
				form2.Closed += (s, args) => this.Close();
				form2.Show();
			}
			else
			{
				txbUsuario.Enabled		    = true;
				txbContrasena.Enabled	    = true;
				tglRecordarme.Enabled	    = true;
                btnConfiguracion.Enabled    = true;
				btnIngresar.Visible		    = true;
				pictureBox2.Visible		    = false;

				txbContrasena.Clear();
				txbUsuario.Clear();
				MessageBox.Show("Usuario o Contraseña Incorrectos.",
								"¡ATENCIÓN!",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);

				txbUsuario.Focus();
			}
		}

        public static bool ValidateConnection()
        {
            if (string.IsNullOrEmpty(LogicaCC.Properties.Settings.Default.DbServer))
                return false;
            else
                return true;
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lnkOptions_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroLink lnkMenu = (MetroFramework.Controls.MetroLink)sender;
            Point ptLowerLeft = new Point(-125, -50);
            ptLowerLeft = lnkMenu.PointToScreen(ptLowerLeft);
            mnstpMas.Show(ptLowerLeft);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            frmDbSettings.Show();
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
