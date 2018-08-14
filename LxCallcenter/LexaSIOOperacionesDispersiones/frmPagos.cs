using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	public partial class frmPagos : Form
	{
		FPrincipal _frmPrincipal;
		public frmPagos()
		{
			InitializeComponent();

			//ASIGNA FORMATO AL DOCUMENTO EXPORTADO DESDE EL GRIDVIEW DE DEVEXPRESS
            ExportSettings.DefaultExportType                    = ExportType.WYSIWYG;
            gridView1.AppearancePrint.HeaderPanel.BackColor     = Color.FromArgb(0, 20, 137);
            gridView1.AppearancePrint.HeaderPanel.ForeColor     = Color.White;
            gridView1.AppearancePrint.HeaderPanel.BorderColor   = Color.FromArgb(0, 20, 137);
            gridView1.AppearancePrint.FooterPanel.BackColor     = Color.White;
            gridView1.AppearancePrint.FooterPanel.BorderColor   = Color.White;
            gridView1.AppearancePrint.Row.BorderColor           = Color.FromArgb(216, 216, 216);
            gridView1.OptionsPrint.AutoWidth                    = false;
            gridView1.OptionsPrint.UsePrintStyles               = true;
			gridView1.OptionsPrint.ExpandAllDetails				= true;
			gridView1.OptionsPrint.ExpandAllGroups				= true;
			gridView1.OptionsPrint.PrintDetails					= true;

            _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;
            _frmPrincipal.btnVerDetallesFactura.Enabled          = true;
            _frmPrincipal.btnExportarConcentradoFacturas.Enabled = true;

			cargarPagos();
		}

		/// <summary>
		/// Realiza la carga de pagos
		/// </summary>
		public void cargarPagos()
		{
            grdPagos.DataSource = null;
			grdPagos.DataSource = new LogicaCC.LexaSIOOperLogica.Pago().GetList();
            //gridView1.BestFitColumns();
			//BestFitAllViews();




			gridView1.Appearance.FooterPanel.Options.UseBackColor   = true;
            gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            gridView1.Appearance.FooterPanel.BackColor              = Color.White;
            gridView1.Appearance.FooterPanel.BackColor2             = Color.White;
            gridView1.Appearance.FooterPanel.BorderColor            = Color.White;

            gridView1.ExpandAllGroups();
			ContarRegistros();
			BestFitAllViews();
		}

		private void BestFitAllViews()
		{
			foreach (BaseView view in grdPagos.ViewCollection)
				BestFit(view as GridView);
		}

		private void BestFit(GridView dview)
		{
			if (dview == null)
				return;
			dview.OptionsView.ColumnAutoWidth = false;
			foreach (GridColumn gc in dview.Columns)
				gc.BestFit();
		}

		/// <summary>
		/// Exporta un listado de pagos en Excel
		/// </summary>
		public void ExportarLista()
		{
			if (gridView1.RowCount != 0)
			{
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					gridView1.ZoomView();
					//grdPagos.ZoomView();
					gridView1.ExportToXlsx(saveFileDialog1.FileName);
					//grdPagos.ExportToXlsx(saveFileDialog1.FileName);
					gridView1.NormalView();
					Process.Start(saveFileDialog1.FileName);
				}
			}
		}

		/// <summary>
		/// Cuenta los registros que se encuentran en el gridView
		/// </summary>
		public void ContarRegistros()
		{
			if (gridView1.RowCount > 0)
				lblNoRegitros.Text = string.Format("No. de Registros: {0}", gridView1.RowCount);
			else
				lblNoRegitros.Text = "No. de Registros: --";
		}

		private void gridView1_ColumnFilterChanged(Object sender, EventArgs e)
		{
			ContarRegistros();
		}

		MRUEdit edit;
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			FindControl find = null;
			foreach (Control ctrl in grdPagos.Controls)
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

		private void gridView1_MasterRowExpanded(Object sender, CustomMasterRowEventArgs e)
		{
			GridView view = sender as GridView;
			if (((GridView)view.GetDetailView(e.RowHandle, e.RelationIndex)) != null)
				((GridView)view.GetDetailView(e.RowHandle, e.RelationIndex)).BestFitColumns();
		}
	}
}
