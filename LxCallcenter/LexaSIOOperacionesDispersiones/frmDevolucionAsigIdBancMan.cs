using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.LexaSIOOperLogica;
using LogicaCC.Logica;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	public partial class frmDevolucionAsigIdBancMan : Form
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
		const int AW_HIDE           = 0X10000;
		const int AW_SLIDE          = 0X40000;
		const int AW_HOR_POSITIVE   = 0X1;
		const int AW_HOR_NEGATIVE   = 0X2;
		const int AW_BLEND          = 0X80000;
		const int AW_VER_POSITIVE   = 0X00000004;
		const int AW_VER_NEGATIVE   = 0X00000008;

		[System.Runtime.InteropServices.DllImport("user32")]
		static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

		private bool _UseSlideAnimation;
		public frmDevolucionAsigIdBancMan() : this(false) { }

		public frmDevolucionAsigIdBancMan(bool useSlideAnimation)
		{
			InitializeComponent();
			_UseSlideAnimation = useSlideAnimation;
		}
		//public frmDevolucionAsigIdBancMan()
		//{
		//	InitializeComponent();
		//}

		static frmDevolucionAsigIdBancMan _AsigIdBanMan;
		static DialogResult _DialogResult = DialogResult.No;

		public static DialogResult Show(int iIdCliente)
		{
			_AsigIdBanMan = new frmDevolucionAsigIdBancMan();
			Form frmSet = Application.OpenForms["FPrincipal"];

			int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _AsigIdBanMan.Width) / 2);
			int y = frmSet.Location.Y + 1;
			_AsigIdBanMan.Location = new Point(x, y);

			_AsigIdBanMan.InitializeControls(iIdCliente);
			_DialogResult = DialogResult.No;

			_AsigIdBanMan.Activate();
			_AsigIdBanMan.ShowDialog();

			return _DialogResult;
		}

		protected override void OnLoad(EventArgs e)
		{
			//Animate Form
			base.OnLoad(e);
			AnimateWindow(this.Handle, 100, AW_SLIDE | AW_VER_POSITIVE);
			//AnimateWindow(this.Handle, 50, AW_BLEND);
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
			if (e.Cancel == false)
				AnimateWindow(this.Handle, 200, AW_HIDE | AW_SLIDE | AW_VER_NEGATIVE);
			//AnimateWindow(this.Handle, 50, AW_HIDE | AW_BLEND);
		}

		private void btnSalir_Click(Object sender, EventArgs e)
		{
			_DialogResult = DialogResult.Yes;
			_AsigIdBanMan.Close();
		}

		private void lnkConfigurar_Click(Object sender, EventArgs e)
		{
			_DialogResult = DialogResult.No;
			_AsigIdBanMan.Close();
		}

		SocioComanditario _Cliente = null;
		public void InitializeControls(int iIdCliente)
		{
			_Cliente = new SocioComanditario().GetInfoCliente(iIdCliente);
			txtComisionista.Text		= _Cliente.sNombre;
			txtNoCuenta.Text			= _Cliente.sNoCuenta;
			txtClabeInterbancaria.Text	= _Cliente.sClabeInterbancaria;
			txtIdBancario.Text			= _Cliente.sIdBancario;
			txtBanco.Text				= _Cliente.sBanco;
		}

		private void btnGuardar_Click(Object sender, EventArgs e)
		{
			int iResultado = 0;
			iResultado = new SocioComanditario().UpdateInfoCliente(int.Parse(AUsuario.sIdusuario), _Cliente.iIdCliente, txtIdBancario.Text, txtBanco.Text);

			if (iResultado == 1)
			{
				FlatMessageBox.Show("Operación exitosa", "OK", string.Empty, FlatMessageBoxIcon.Information);
				_DialogResult = DialogResult.Yes;
				_AsigIdBanMan.Close();
			}
			else if (iResultado == 0)
			{
				FlatMessageBox.Show("Error al actualizar en la base de datos", "OK", string.Empty, FlatMessageBoxIcon.Error);
			}
			else if (iResultado == -1)
			{
				FlatMessageBox.Show("Error de conexión, reintente en un momento", "OK", string.Empty, FlatMessageBoxIcon.Warning);
			}
		}
	}
}
