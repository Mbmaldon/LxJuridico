using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.LexaSIOContaLogica;

namespace LxCallcenter.LexaSIOConta
{
	public partial class frmRecordatorios : Form
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
		public frmRecordatorios() : this(false) { }

		public frmRecordatorios(bool useSlideAnimation)
		{
			InitializeComponent();
			_UseSlideAnimation = useSlideAnimation;
		}
		//public frmRecordatorios()
		//{
		//	InitializeComponent();
		//}

		static frmRecordatorios _Recordatorios;
		static DialogResult _DialogResult = DialogResult.No;

		public static DialogResult Show(string sNombre)
		{
			_Recordatorios = new frmRecordatorios();
			Form frmSet = Application.OpenForms["FPrincipal"];

			int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _Recordatorios.Width) / 2);
			int y = frmSet.Location.Y + 1;
			_Recordatorios.Location = new Point(x, y);

			//if (string.IsNullOrEmpty(sBtnNo))
			//{
			//	_FlatMessageBox.btnNo.Visible = false;
			//	_FlatMessageBox.btnYes.Location = new Point(167, 185);
			//}
			//_FlatMessageBox.asignarIcono(icon);

			//_FlatMessageBox.lblMessage.Text = sText;
			//_FlatMessageBox.btnYes.Text = sBtnSi;
			//_FlatMessageBox.btnNo.Text = sBtnNo;
			_Recordatorios.label1.Text = string.Format("Hola {0},", sNombre);
			_Recordatorios.InitializeControls();
			_DialogResult = DialogResult.No;

			//BlackScreen _BlackScreen = new BlackScreen();
			//_BlackScreen.Show();
			//_Recordatorios.Activate();
			//_Recordatorios.ShowDialog();
			//_BlackScreen.Close();
			//frmSet.Activate();
			//_FlatMessageBox.ShowDialog();
			//BlackScreen _BlackScreen = new BlackScreen();
			//_BlackScreen.Show();
			_Recordatorios.Activate();
			_Recordatorios.ShowDialog();
			//_BlackScreen.Close();

			return _DialogResult;
		}

		public void InitializeControls()
		{
			List<DetalleObligacion> Recordatorios = new DetalleObligacion().GetListRecordatorios();
			if (Recordatorios.Count > 0)
			{
				for (int i = 0; i < Recordatorios.Count; i++)
				{
					Label lblRecordatorio = new Label();
					lblRecordatorio.Name = Recordatorios[i].iIdDetalleObligacion.ToString();
					lblRecordatorio.Text = "      " + Recordatorios[i].sDetalleObligacion;
					lblRecordatorio.Location = new Point(16, 28 * i + 12);
					lblRecordatorio.Font	 = new Font("Segoe UI", 9.5f);
					lblRecordatorio.Image = Properties.Resources.appointment_reminders_20px;
					lblRecordatorio.ImageAlign = ContentAlignment.TopLeft;
					lblRecordatorio.TextAlign = ContentAlignment.MiddleLeft;
					lblRecordatorio.Size = new Size(522, 19);
					lblRecordatorio.AutoEllipsis = true;

					pnlObligaciones.Controls.Add(lblRecordatorio);
				}
			}
		}


		protected override void OnLoad(EventArgs e)
		{
			//Animate form
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

		private void btnOK_Click(Object sender, EventArgs e)
		{
			_DialogResult = DialogResult.Yes;
			_Recordatorios.Close();
		}
	}
}
