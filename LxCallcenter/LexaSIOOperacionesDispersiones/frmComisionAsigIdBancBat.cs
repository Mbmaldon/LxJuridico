using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.Logica;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	public partial class frmComisionAsigIdBancBat : Form
	{
		UsuarioData AUsuario = UsuarioData.Instancia;
		private const int CS_DROPSHADOW = 0X20000;
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
		const int AW_HIDE			= 0X10000;
		const int AW_SLIDE			= 0X40000;
		const int AW_HOR_POSITIVE	= 0X1;
		const int AW_HOR_NEGATIVE	= 0X2;
		const int AW_BLEND			= 0X80000;
		const int AW_VER_POSITIVE	= 0X00000004;
		const int AW_VER_NEGATIVE	= 0X00000008;

		[System.Runtime.InteropServices.DllImport("user32")]
		static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

		private bool _UseSlideAnimation;
		public frmComisionAsigIdBancBat() : this(false) { }

		public frmComisionAsigIdBancBat(bool useSlideAnimation)
		{
			InitializeComponent();
			_UseSlideAnimation = useSlideAnimation;
		}

		//public frmComisionAsigIdBancBat()
		//{
		//	InitializeComponent();
		//}

		static frmComisionAsigIdBancBat _AsigIdBanBat;
		static DialogResult _DialogResult = DialogResult.No;

		public static DialogResult Show()
		{
			_AsigIdBanBat = new frmComisionAsigIdBancBat();
			Form frmSet = Application.OpenForms["FPrincipal"];

			int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _AsigIdBanBat.Width) / 2);
			int y = frmSet.Location.Y + 1;
			_AsigIdBanBat.Location = new Point(x, y);

			//_AsigIdBanBat.InitializeControls();
			_DialogResult = DialogResult.No;

			_AsigIdBanBat.Activate();
			_AsigIdBanBat.ShowDialog();

			return _DialogResult;
		}

		protected override void OnLoad(EventArgs e)
		{
			//Animate Form
			base.OnLoad(e);
			AnimateWindow(this.Handle, 100, AW_SLIDE | AW_VER_POSITIVE);
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
			if (e.Cancel == false)
			{
				AnimateWindow(this.Handle, 200, AW_HIDE | AW_SLIDE | AW_VER_NEGATIVE);
			}
		}
	}
}
