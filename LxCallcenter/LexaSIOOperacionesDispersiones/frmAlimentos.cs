using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Export;
using LogicaCC.Logica;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraLayout;
using System.Diagnostics;
using LogicaCC.LexaSIOOperLogica;
using System.Globalization;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	public partial class frmAlimentos : Form
	{
		UsuarioData AUsuario;
		FPrincipal _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;
		public frmAlimentos()
		{
			InitializeComponent();
			//ASIGNA FORMATO AL DOCUMENTO EXPORTADO DESDE EL GRIDVIEW DE DEVEXPRESS
            ExportSettings.DefaultExportType                    = ExportType.WYSIWYG;
            gridView1.AppearancePrint.HeaderPanel.BackColor     = Color.FromArgb(7, 22, 127);
            gridView1.AppearancePrint.HeaderPanel.ForeColor     = Color.White;
            gridView1.AppearancePrint.HeaderPanel.BorderColor   = Color.FromArgb(7, 22, 127);
            gridView1.AppearancePrint.FooterPanel.BackColor     = Color.White;
            gridView1.AppearancePrint.FooterPanel.BorderColor   = Color.White;
            gridView1.AppearancePrint.Row.BorderColor           = Color.FromArgb(216, 216, 216);
            gridView1.OptionsPrint.AutoWidth                    = false;
            gridView1.OptionsPrint.UsePrintStyles               = true;
			InitializeControls();
		}

		public void InitializeControls()
		{
			int iYear = DateTime.Now.Year;
            cmbxAnio.Items.Add(iYear - 1);
            for (int i = iYear; i <= iYear + 4; i++)
			{
				cmbxAnio.Items.Add(i.ToString());
			}
			cmbxAnio.Text = DateTime.Now.Year.ToString();


            //CALCULA Y LLENA EL NÚMERO TOTAL DE SEMANAS DEL AÑO
            cmbxSemDesde.Items.Clear();
            cmbxSemanas.Items.Clear();
            DateTimeFormatInfo dfi	= DateTimeFormatInfo.CurrentInfo;
            DateTime date1			= new DateTime(int.Parse(cmbxAnio.Text), 12, 31);
            Calendar cal			= dfi.Calendar;
            for (int i = 1; i < cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) + 1; i++)
            {
                cmbxSemDesde.Items.Add(i);
                cmbxSemanas.Items.Add(i);
            }

			//CALCULAR EL NÚMERO DE SEMANA EN CURSO
			CultureInfo _CultureInfo	= new CultureInfo("en-US");
			Calendar	_Calendar		= _CultureInfo.Calendar;
			CalendarWeekRule _CalendarWeekRule = _CultureInfo.DateTimeFormat.CalendarWeekRule;
			DayOfWeek _DayOfWeek = _CultureInfo.DateTimeFormat.FirstDayOfWeek;
            cmbxSemDesde.Text = (_Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek) - 1).ToString();
            cmbxSemanas.Text = _Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek).ToString();

			lblAnio.Text	= DateTime.Now.Year.ToString();
			lblSemana.Text	= _Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek).ToString();


			InitializeDevoluciones(DateTime.Now.Year, _Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek) - 1, _Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek));
		}

		public void InitializeDevoluciones(int iAnio, int iSemanaDesde, int iSemana)
		{
			//CARGAMOS COMISIONES EN EL GRIDVIEW
			//grdDevoluciones.DataSource = null;
			grdDevoluciones.DataSource = new Pago().GetListDevoluciones(iAnio, iSemanaDesde, iSemana);
			gridView1.BestFitColumns();
			gridView1.Appearance.FooterPanel.Options.UseBackColor	= true;
			gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
			gridView1.Appearance.FooterPanel.BackColor				= Color.White;
			gridView1.Appearance.FooterPanel.BackColor2				= Color.White;
			gridView1.Appearance.FooterPanel.BorderColor			= Color.White;

			gridView1.ExpandAllGroups();
			ContarRegistros();
		}

		public void ContarRegistros()
		{
			if (gridView1.RowCount > 0)
				lblNoRegitros.Text = string.Format("No. de Registros: {0}", gridView1.RowCount);
			else
				lblNoRegitros.Text = "No. de Registros: --";
		}

		public void Exportar()
		{
			if (gridView1.RowCount != 0)
			{
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					DevExpress.XtraPrinting.XlsxExportOptions options = new DevExpress.XtraPrinting.XlsxExportOptions();
					options.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;

					grdDevoluciones.ExportToXlsx(saveFileDialog1.FileName, options);
					Process.Start(saveFileDialog1.FileName);
				}
			}
		}

		MRUEdit edit;
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			FindControl find = null;
			foreach (Control ctrl in grdDevoluciones.Controls)
				if (ctrl.GetType() == typeof(FindControl))
					find = ctrl as FindControl;
			if (find != null)
			{
				LayoutControl layout = find.Controls[0] as LayoutControl;
				edit = (layout.Items[2] as LayoutControlItem).Control as MRUEdit;
			}
		}

		private void txtBuscar_TextChanged(Object sender, EventArgs e)
		{
			edit.Text = txtBuscar.Text.ToString();
		}

		private void gridView1_ColumnFilterChanged(Object sender, EventArgs e)
		{
			ContarRegistros();
		}

		private void cmbxAnio_SelectionChangeCommitted(Object sender, EventArgs e)
		{
			cmbxSemanas.Items.Clear();
            cmbxSemDesde.Items.Clear();
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
			DateTime date1 = new DateTime(int.Parse(cmbxAnio.Text), 12, 31);
			Calendar cal = dfi.Calendar;
			for (int i = 1; i < cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) + 1; i++)
			{
                cmbxSemDesde.Items.Add(i);
                cmbxSemanas.Items.Add(i);
			}
		}

		private void cmbxSemanas_SelectionChangeCommitted(Object sender, EventArgs e)
		{
            if (cmbxSemDesde.Text != string.Empty && cmbxSemanas.Text != string.Empty)
            {
			    //lblSemana.Text	= cmbxSemanas.Text;
			    //lblAnio.Text	= cmbxAnio.Text;
			    InitializeDevoluciones(int.Parse(cmbxAnio.Text), int.Parse(cmbxSemDesde.Text), int.Parse(cmbxSemanas.Text));
            }
		}

		public void GenerarLayout(int iModo)
		{
			if (gridView1.RowCount > 0)
				frmGenerarLayoutDevoluciones.Show(iModo == 1 ? true : false, GenerateTableLayout(iModo));
		}

		/// <summary>
		/// Genera una tabla cone el listado de comisiones
		/// </summary>
		/// <param name="iModo"></param>
		/// <returns></returns>
		public DataTable GenerateTableLayout(int iModo)
        {
            //CREAMOS UNA NUEVA TABLA PARA INSERTAR LOS REGISTROS DEL GRIDVIEW EN ELLA
            DataTable table     = new DataTable();

            //CREAMOS LAS COLUMNAS QUE SE OCUPARAN PARA EXPORTAR LA POLIZA DE ALIMENTOS
            table.Columns.Add("ClaveID", typeof(string));
            table.Columns.Add(iModo == 1 ? "Cuenta" : "CuentaCLABE", typeof(string));
            table.Columns.Add("Importe", typeof(decimal));
            table.Columns.Add("NombreBeneficiario", typeof(string));

			//AGREGAMOS LOS REGISTROS A LA TABLA
			for (int i = 0; i < gridView1.RowCount; i++)
            {
				string c1 = Convert.ToString(gridView1.GetRowCellValue(i, "sIdBancario"));
				string c2 = Convert.ToString(gridView1.GetRowCellValue(i, iModo == 1 ? "sCuentaBancaria" : "sCuentaInterbancaria"));
				string c3 = Convert.ToString(gridView1.GetRowCellValue(i, "dImporteDevolver"));
				string c4 = Convert.ToString(gridView1.GetRowCellValue(i, "sNombre"));

				table.Rows.Add(c1, c2, c3, c4);
            }
            return table;
        }

		public void AsignarCliente()
		{
			if (gridView1.RowCount > 0)
			{
				if (frmDevolucionAsigIdBancMan.Show(int.Parse(gridView1.GetFocusedRowCellValue("iIdCliente").ToString())) == DialogResult.Yes)
					InitializeDevoluciones(int.Parse(cmbxAnio.Text), int.Parse(cmbxSemDesde.Text), int.Parse(cmbxSemanas.Text));
			}
		}
	}
}
