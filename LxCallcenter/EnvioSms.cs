using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter
{
	public partial class EnvioSms : Form
	{
		private const int CS_DROPSHADOW = 0x20000;
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.ClassStyle |= CS_DROPSHADOW;
				return cp;
			}
		}
		//Constants
		const int AW_HIDE           = 0X10000;
        const int AW_SLIDE          = 0X40000;
        const int AW_HOR_POSITIVE   = 0X1;
        const int AW_HOR_NEGATIVE   = 0X2;
        const int AW_BLEND          = 0X80000;
        const int AW_VER_POSITIVE   = 0x00000004;
        const int AW_VER_NEGATIVE   = 0x00000008;

        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        private bool _UseSlideAnimation;

        public EnvioSms() : this(false) { }
        public EnvioSms(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;

            rbCliente.AutoCheck = true;
            rbClientesTodos.AutoCheck = true;
        }

        // CONSTRUCTOR
  //      public EnvioSms()
		//{
		//	InitializeComponent();

  //          rbCliente.AutoCheck = true;
  //          rbClientesTodos.AutoCheck = true;
		//}

        static EnvioSms _EnvioSms;
        static DialogResult _DialogResult = DialogResult.No;

        /// <summary>
        /// Muestra una ventana modal para el envío de SMS a los clientes
        /// </summary>
        /// <returns></returns>
        public static DialogResult Show()
        {
            FPrincipal frmSet = Application.OpenForms["FPrincipal"] as FPrincipal;
            _EnvioSms = new EnvioSms();

            int x = frmSet.Location.X + (frmSet.Width - _EnvioSms.Width);
            int y = frmSet.Location.Y;
            _EnvioSms.Location = new Point(x, y);
            _EnvioSms.Height   = frmSet.Height - 7;
            _EnvioSms.Owner    = frmSet;


            _DialogResult = DialogResult.No;

			//BlackScreen _BlackScreen = new BlackScreen();
			//_BlackScreen.Show();
			//_EnvioSms.Activate();
			//_EnvioSms.ShowDialog();
			//_BlackScreen.Close();
			//frmSet.Activate();

			//BlackScreen _BlackScreen = new BlackScreen();
			//_BlackScreen.Show();
			_EnvioSms.Activate();
			_EnvioSms.ShowDialog();
			//_BlackScreen.Close();
			frmSet.Activate();

			return _DialogResult;
        }

        protected override void OnLoad(EventArgs e)
        {
            //Animate form
            base.OnLoad(e);
            AnimateWindow(this.Handle, 100, AW_SLIDE | AW_HOR_NEGATIVE);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (e.Cancel == false)
            {
                AnimateWindow(this.Handle, 200, AW_HIDE | AW_SLIDE | AW_HOR_POSITIVE);
            }
        }

        #region EVENTOS

        // EVENTO SMS A CLIENTE ESPECIFICO
        private void rbCliente_CheckedChanged(Object sender, EventArgs e)
		{
			Application.OpenForms["FPrincipal"].Focus();
			ClienteSMS FCliente = new ClienteSMS();
			ClienteSMS Cliente  = FCliente ?? new ClienteSMS();
			MostrarForm(Cliente);
		}

        // EVENTO SMS A CLIENTES ASIGNADOS
		private void rbMasivo_CheckedChanged(Object sender, EventArgs e)
		{
			Application.OpenForms["FPrincipal"].Focus();
			ClientesSMSs FCliente = new ClientesSMSs();
			ClientesSMSs Cliente  = FCliente ?? new ClientesSMSs();
			MostrarForm(Cliente);
		}

		#endregion EVENTOS

		#region FUNCIONES

		// RECIBE EL FORMULARIO A MOSTRAR, LO EDITA Y LO MUESTRA
		private void MostrarForm(Form Formulario)
		{
			CerrarFormularios();
			Formulario.TopLevel        = false;
			Formulario.FormBorderStyle = FormBorderStyle.None;
			Formulario.Dock            = DockStyle.Fill;
			this.pnlforms.Controls.Add(Formulario);
			this.pnlforms.Tag = Formulario;
			Formulario.Show();
		}

		// CIERRA LOS FORMULARIOS ABIERTOS Y PUESTOS EN EL FORM.
		private void CerrarFormularios()
		{
			Form[] sAforms = new Form[10];
			int iContador = 0;
            // Se genera el listado de los formularios abiertos
            //foreach(Form x in Application.OpenForms)
            foreach (Form x in pnlforms.Controls)
            {
				string sForm = x.Name.ToString();

				if(!sForm.Equals("Login") &&
				   !sForm.Equals("FPrincipal") &&
				   !sForm.Equals("EnvioSms") &&
                   !sForm.Equals("frmDirectorio"))
				{
					pnlforms.Controls.Remove(x);
					sAforms[iContador] = x;
					iContador++;
				}
			}
			// Cierra los formularios
			for(int i = 0; i < 10; i++)
			{
				if(sAforms[i] != null)
				{
					sAforms[i].Close();
				}
			}
		}

        #endregion FUNCIONES

        private void lnkCerrar_Click(object sender, EventArgs e)
        {
            _EnvioSms.Close();
        }
    }
}
