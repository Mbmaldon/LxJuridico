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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraLayout;
using LogicaCC.Logica;

namespace LxCallcenter.LexaSIOConta
{
	public partial class frmClients : Form
	{
		UsuarioData AUsuario = UsuarioData.Instancia;
		FPrincipal _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;
		public frmClients()
		{
			InitializeComponent();
			InitializeControls();
		}

		private void InitializeControls()
		{
			this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
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

			grdClientes.DataSource = new LogicaCC.LexaSIOContaLogica.Cliente().GetListClientesByContador(int.Parse(AUsuario.sIdusuario));

			gridView1.BestFitColumns();
            gridView1.Appearance.FooterPanel.Options.UseBackColor   = true;
            gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            gridView1.Appearance.FooterPanel.BackColor              = Color.White;
            gridView1.Appearance.FooterPanel.BackColor2             = Color.White;
            gridView1.Appearance.FooterPanel.BorderColor            = Color.White;
			gridView1.ExpandAllGroups();

			ContarRegistros();
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

		MRUEdit edit;
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			FindControl find = null;
			foreach (Control ctrl in grdClientes.Controls)
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

		public int iIdReciboSeleccionado = 0;
		private void gridView1_DoubleClick(Object sender, EventArgs e)
		{
			BeginInvoke(new Action(delegate {
				gridView1.SelectRow(gridView1.FocusedRowHandle);
				if (gridView1.RowCount > 0)
				{
					if (iIdReciboSeleccionado > 0)
						AltaDeclaracion.Show(int.Parse(gridView1.GetFocusedRowCellValue("iIdCliente").ToString()));
				}

			}));
		}

		private void gridView1_RowClick(Object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			try
			{
				iIdReciboSeleccionado = int.Parse(gridView1.GetFocusedRowCellValue("iIdCliente").ToString());
			}
			catch
			{
				iIdReciboSeleccionado = 0;
			}
		}
	}
}
