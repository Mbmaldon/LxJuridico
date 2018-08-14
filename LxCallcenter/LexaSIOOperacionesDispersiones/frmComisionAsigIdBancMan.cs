using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraLayout;
using LogicaCC.LexaSIOOperLogica;
using LogicaCC.Logica;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	public partial class frmComisionAsigIdBancMan : Form
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
		public frmComisionAsigIdBancMan() : this(false) { }

		public frmComisionAsigIdBancMan(bool useSlideAnimation)
		{
			InitializeComponent();
			_UseSlideAnimation = useSlideAnimation;
		}

		//public frmComisionAsigIdBancMan()
		//{
		//	InitializeComponent();
		//}

		static frmComisionAsigIdBancMan _AsigIdBanMan;
		static DialogResult _DialogResult = DialogResult.No;

		public static DialogResult Show(int iIdComisionista)
		{
			_AsigIdBanMan = new frmComisionAsigIdBancMan();
			Form frmSet = Application.OpenForms["FPrincipal"];

			int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _AsigIdBanMan.Width) / 2);
			int y = frmSet.Location.Y + 1;
			_AsigIdBanMan.Location = new Point(x, y);

			_AsigIdBanMan.InitializeControls(iIdComisionista);
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

		Comisionista _Comisionista = null;
		public void InitializeControls(int iIdUsuario)
		{
			_Comisionista				= new Comisionista().GetInfoComisionista(iIdUsuario);
			txtComisionista.Text		= _Comisionista.sComisionista;
			txtNoCuenta.Text			= _Comisionista.sNoCuenta;
			txtClabeInterbancaria.Text	= _Comisionista.sClabeInterbancaria;
			txtIdBancario.Text			= _Comisionista.sIdBancario;
			txtBanco.Text				= _Comisionista.sBanco;
		}

		private void btnGuardar_Click(Object sender, EventArgs e)
		{
			int iResultado = 0;
			iResultado = new Comisionista().UpdateInfoComisionista(int.Parse(AUsuario.sIdusuario), _Comisionista.iIdComisionista, txtIdBancario.Text, txtBanco.Text);

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
