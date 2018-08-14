using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.Logica;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	public partial class frmGenerarLayoutDevoluciones : Form
	{
		UsuarioData AUsuario = UsuarioData.Instancia;
		frmAlimentos _Devolucion = Application.OpenForms["frmAlimentos"] as frmAlimentos;
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
		public frmGenerarLayoutDevoluciones() : this(false) { }

		public frmGenerarLayoutDevoluciones(bool useSlideAnimation)
		{
			InitializeComponent();
			_UseSlideAnimation = useSlideAnimation;
		}
		//public frmGenerarLayoutDevoluciones()
		//{
		//	InitializeComponent();
		//}

		static frmGenerarLayoutDevoluciones _GenerarLayout;
		static DialogResult _DialogResult = DialogResult.No;

		/// <summary>
		/// Muestra formulario para generar layout bancario
		/// </summary>
		/// <param name="bTipo">True para banorte, False para interbancario</param>
		/// <returns></returns>
		public static DialogResult Show(bool bTipo, DataTable _DataTable)
		{
			_GenerarLayout = new frmGenerarLayoutDevoluciones();
			Form frmSet = Application.OpenForms["FPrincipal"];

			int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _GenerarLayout.Width) / 2);
			int y = frmSet.Location.Y + 1;
			_GenerarLayout.Location = new Point(x, y);

			_GenerarLayout.InitializeControls(bTipo);
			_GenerarLayout._DataTable = _DataTable;
			_DialogResult = DialogResult.No;

			_GenerarLayout.Activate();
			_GenerarLayout.ShowDialog();

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

		public DataTable _DataTable = null;
		private bool bModo = false;
		private void InitializeControls(bool bTipo)
		{
			lblTitulo.Text		= bTipo ? "GENERAR LAYOUT BANCARIO BANORTE" : "GENERAR LAYOUT BANCARIO INTERBANCARIO";
			txtReferencia.Text	= DateTime.Now.ToString("ddMMyy");
			bModo				= bTipo;

			cmbxCuentaOrigen.DataSource		= new LogicaCC.LexaSIOOperLogica.Cuenta().GetListCuentaOrigenDevoluciones();
			cmbxCuentaOrigen.ValueMember	= "iIdCuenta";
			cmbxCuentaOrigen.DisplayMember	= "sCuenta";
			cmbxCuentaOrigen.SelectedIndex  = -1;

			LogicaCC.LexaSIOOperLogica.Dispersion _Dispersion = new LogicaCC.LexaSIOOperLogica.Dispersion().GetInfoForLayaut(2);
			txtDescripcion.Text		= _Dispersion.sConcepto;
			txtRfcOrdenante.Text	= _Dispersion.sRfcOrdenante;
		}

		private void lnkCerrar_Click(Object sender, EventArgs e)
		{
			_DialogResult = DialogResult.No;
			_GenerarLayout.Close();
		}

		public int ValidarCampos()
		{
			int iResultado = 0;
			errorProvider1.Clear();

			if (string.IsNullOrEmpty(cmbxCuentaOrigen.Text))
			{
				errorProvider1.SetError(cmbxCuentaOrigen, "Se requiere una cuenta de origen");
				iResultado = 1;
			}

			return iResultado;
		}

		DataTable _DataTableMain = null;
		private void btnGenerarLayout_Click(Object sender, EventArgs e)
		{
			if (ValidarCampos() == 0)
			{
				if (sfdRuta.ShowDialog() == DialogResult.OK)
				{
					lnkCerrar.Enabled			= false;
					btnGenerarLayout.Visible	= false;
					pgrbProgreso.Visible		= true;
					lblTiempo.Visible			= true;
					lblNumArchivos.Visible		= true;
					txtReferencia.Enabled		= false;
					cmbxCuentaOrigen.Enabled	= false;
					CreateTableLayout();
					bgwProgreso.RunWorkerAsync();
				}
			}
		}

		public void CreateTableLayout()
		{
			var _dtD = _DataTable.AsEnumerable()
			.GroupBy(r => r.Field<string>("ClaveID"))
			.Select(g => new
			{
				Oper				= bModo ? "02" : "04",
				ClaveID				= g.Key,
				CuentaOrigen		= _GenerarLayout.cmbxCuentaOrigen.Text,
				Cuenta				= g.First().Field<String>(bModo ? "Cuenta" : "CuentaCLABE"),
				Importe				= g.Sum(r => r.Field<decimal>("Importe")),
				Rerefencia			= _GenerarLayout.txtReferencia.Text,
				Descripcion			= _GenerarLayout.txtDescripcion.Text,
				RFCOrdenante		= _GenerarLayout.txtRfcOrdenante.Text,
				Iva					= "0",
				FechaAplicacion		= "",
				NombreBeneficiario	= RemoveSpecialCharacters(g.First().Field<String>("NombreBeneficiario").ToUpper())
			});

			_DataTableMain = ConvertToDataTable(_dtD);
		}



		private string RemoveSpecialCharacters(string str)
		{
			string consignos = "áàäéèëíìïóòöúùuñÁÀÄÉÈËÍÌÏÓÒÖÚÙÜçÇ";
			string sinsignos = "aaaeeeiiiooouuunAAAEEEIIIOOOUUUcC";
			for (int v = 0; v < sinsignos.Length; v++)
			{
				string i = consignos.Substring(v, 1);
				string j = sinsignos.Substring(v, 1);
				str = str.Replace(i, j);
			}
			return str;
		}

		public DataTable ConvertToDataTable<T>(IEnumerable<T> varlist)
		{
			DataTable dtReturn = new DataTable();

			// column names 
			PropertyInfo[] oProps = null;

			if (varlist == null)
				return dtReturn;

			foreach (T rec in varlist)
			{
				// Use reflection to get property names, to create table, Only first time, others will follow 
				if (oProps == null)
				{
					oProps = ((Type)rec.GetType()).GetProperties();
					foreach (PropertyInfo pi in oProps)
					{
						Type colType = pi.PropertyType;

						if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
						{
							colType = colType.GetGenericArguments()[0];
						}

						dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
					}
				}

				DataRow dr = dtReturn.NewRow();

				foreach (PropertyInfo pi in oProps)
				{
					dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue
					(rec, null);
				}

				dtReturn.Rows.Add(dr);
			}
			return dtReturn;
		}

		private void bgwProgreso_DoWork(Object sender, DoWorkEventArgs e)
		{
			GenerarLayout(e);
		}

		private void bgwProgreso_ProgressChanged(Object sender, ProgressChangedEventArgs e)
		{
			pgrbProgreso.Value	= e.ProgressPercentage;
			lblTiempo.Text		= String.Format("{0} %", e.ProgressPercentage);
			lblNumArchivos.Text = e.UserState.ToString();
		}

		private void bgwProgreso_RunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
		{
			lnkCerrar.Enabled = true;
			lblNumArchivos.Text = "Operación exitosa";
			Process.Start(sfdRuta.FileName);
		}

		public void GenerarLayout(DoWorkEventArgs e)
		{
			Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
			app.Visible = false;
			string sAutoFitRange = string.Empty;

			Microsoft.Office.Interop.Excel.Workbook _Workbook	= app.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
			Microsoft.Office.Interop.Excel.Worksheet _Worksheet = (Microsoft.Office.Interop.Excel.Worksheet)_Workbook.ActiveSheet;
			bgwProgreso.ReportProgress(0, string.Format("CREANDO DOCUMENTO"));
			// Genera el layout bancario para Banorte

			// Headers.  
			_Worksheet.Cells[1, 0 + 1] = "Oper";
			_Worksheet.Cells[1, 1 + 1] = "Clave ID";
			_Worksheet.Cells[1, 2 + 1] = "Cuenta Origen";
			_Worksheet.Cells[1, 3 + 1] = bModo ? "Cuenta" : "Cuenta/CLABE destino";
			_Worksheet.Cells[1, 4 + 1] = "Importe";
			_Worksheet.Cells[1, 5 + 1] = "Referencia";
			_Worksheet.Cells[1, 6 + 1] = "Descripción";
			_Worksheet.Cells[1, 7 + 1] = "RFC Ordenante";
			_Worksheet.Cells[1, 8 + 1] = "IVA";
			_Worksheet.Cells[1, 9 + 1] = "Fecha aplicación";
			_Worksheet.Cells[1, 10 + 1] = "Nombre beneficiario";

			bgwProgreso.ReportProgress(0, string.Format("DANDO FORMATO"));
			_Worksheet.Range["A2:A" + _DataTableMain.Rows.Count + 1].NumberFormat = "@";
			_Worksheet.Range["B2:B" + _DataTableMain.Rows.Count + 1].NumberFormat = "@";
			_Worksheet.Range["C2:C" + _DataTableMain.Rows.Count + 1].NumberFormat = "@";
			_Worksheet.Range["D2:D" + _DataTableMain.Rows.Count + 1].NumberFormat = "@";
			_Worksheet.Range["E2:E" + _DataTableMain.Rows.Count + 1].NumberFormat = "0.00";
			_Worksheet.Range["F2:F" + _DataTableMain.Rows.Count + 1].NumberFormat = "@";
			_Worksheet.Range["G2:G" + _DataTableMain.Rows.Count + 1].NumberFormat = "@";
			_Worksheet.Range["H2:H" + _DataTableMain.Rows.Count + 1].NumberFormat = "@";

			sAutoFitRange = "A:K";

			for (int i = 0; i < _DataTableMain.Columns.Count; i++)
			{
				_Worksheet.Cells[1, i + 1].Interior.Color = ColorTranslator.ToOle(Color.FromArgb(102, 255, 51));
			}

			int ii = 0;
			int iTotal = _DataTableMain.Rows.Count;
			// Content.  
			for (int i = 0; i < _DataTableMain.Rows.Count; i++)
			{
				ii++;
				Thread.Sleep(100);
				int percents = (ii * 100) / iTotal;
				bgwProgreso.ReportProgress(percents, string.Format("{0}/{1}", ii, iTotal));

				for (int j = 0; j < _DataTableMain.Columns.Count; j++)
				{

					_Worksheet.Cells[i + 2, j + 1] = _DataTableMain.Rows[i][j].ToString();
				}
			}

			_Worksheet.Columns[sAutoFitRange].AutoFit();

			// Lots of options here. See the documentation.  
			_Workbook.SaveAs(sfdRuta.FileName);

			_Workbook.Close();
			app.Quit();
		}
	}
}
