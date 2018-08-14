using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.LexaSIOOperLogica;
using LogicaCC.Logica;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	public partial class frmAsignarFacCon : Form
	{
		UsuarioData AUsuario = UsuarioData.Instancia;
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
        public frmAsignarFacCon() : this(false) { }

        public frmAsignarFacCon(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
		}
		//public frmAsignarFacCon()
		//{
		//	InitializeComponent();
		//}

		static frmAsignarFacCon _AsignarFactCon;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show()
        {
            _AsignarFactCon = new frmAsignarFacCon();
            Form frmSet = Application.OpenForms["FPrincipal"];

            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _AsignarFactCon.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _AsignarFactCon.Location = new Point(x, y);

			_AsignarFactCon.InitializeControls();
			_DialogResult                     = DialogResult.No;

			//BlackScreen _BlackScreen = new BlackScreen();
			//_BlackScreen.Show();
			//_FlatMessageBox.Activate();
			//_FlatMessageBox.ShowDialog();
			//_BlackScreen.Close();
			_AsignarFactCon.Activate();
			_AsignarFactCon.ShowDialog();
			//frmSet.Activate();
			//_FlatMessageBox.ShowDialog();
			return _DialogResult;
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

		private void btnSalir_Click(Object sender, EventArgs e)
		{
			_DialogResult = DialogResult.No;
			_AsignarFactCon.Close();
		}

		private void btnGuardar_Click(Object sender, EventArgs e)
		{
			if (ValidarCampos() == 0)
			{
				int iResultado = SaveChang();
				if (iResultado == 1)
				{
					frmPagos _Pagos = Application.OpenForms["frmPagos"] as frmPagos;
					if (_Pagos != null)
						_Pagos.cargarPagos();

					_DialogResult = DialogResult.Yes;
					//_AsignarFactCon.Close();
				}
				else if (iResultado == 0)
				{
					FlatMessageBox.Show("Error al guardar en la base de datos", "OK", string.Empty, FlatMessageBoxIcon.Error);
				}
				else if (iResultado == -1)
				{
					FlatMessageBox.Show("Error de conexión, reintente en un momento", "OK", string.Empty, FlatMessageBoxIcon.Error);
				}
			}
		}

		private void InitializeControls()
		{
			int iYear = DateTime.Now.Year;
			for (int i = iYear; i <= iYear + 4; i++)
			{
				cmbxAnios.Items.Add(i.ToString());
			}
			cmbxAnios.Text = DateTime.Now.Year.ToString();

			//CALCULA Y LLENA EL NÚMERO TOTAL DE SEMANAS DEL AÑO
            cmbxSemanas.Items.Clear();
            DateTimeFormatInfo dfi	= DateTimeFormatInfo.CurrentInfo;
            DateTime date1			= new DateTime(int.Parse(cmbxAnios.Text), 12, 31);
            Calendar cal			= dfi.Calendar;
            for (int i = 1; i < cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) + 1; i++)
            {
				cmbxSemanas.Items.Add(i);
            }

			//CALCULAR EL NÚMERO DE SEMANA EN CURSO
			CultureInfo _CultureInfo	= new CultureInfo("en-US");
			Calendar	_Calendar		= _CultureInfo.Calendar;
			CalendarWeekRule _CalendarWeekRule = _CultureInfo.DateTimeFormat.CalendarWeekRule;
			DayOfWeek _DayOfWeek = _CultureInfo.DateTimeFormat.FirstDayOfWeek;
			cmbxSemanas.Text = _Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek).ToString();

			txtNoFactura.Focus();
		}

		private void cmbxAnios_SelectionChangeCommitted(Object sender, EventArgs e)
		{
			//CALCULA Y LLENA EL NÚMERO TOTAL DE SEMANAS DEL AÑO
            cmbxSemanas.Items.Clear();
            DateTimeFormatInfo dfi	= DateTimeFormatInfo.CurrentInfo;
            DateTime date1			= new DateTime(int.Parse(cmbxAnios.Text), 12, 31);
            Calendar cal			= dfi.Calendar;
            for (int i = 1; i < cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) + 1; i++)
            {
				cmbxSemanas.Items.Add(i);
            }
		}

		private int SaveChang()
		{
			int iResultado = 0;
			iResultado = new Pago().UpdatePagoFacCon(int.Parse(AUsuario.sIdusuario),
													 int.Parse(cmbxAnios.Text),
													 int.Parse(cmbxSemanas.Text),
													 txtNoFactura.Text,
													 txtConcepto.Text);
			return iResultado;
		}

		/// <summary>
		/// Valida que la información este completa
		/// </summary>
		/// <returns></returns>
		private int ValidarCampos()
		{
			int iResultado = 0;
			errorProvider1.Clear();

			if (string.IsNullOrEmpty(cmbxSemanas.Text))
			{
				iResultado = 1;
				errorProvider1.SetError(cmbxSemanas, "Seleccione una semana");
			}

			return iResultado;
		}
	}
}
