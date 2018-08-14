namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	partial class frmReportesOperaciones
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblNoRegitros = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdReportes = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ejecutivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Referencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Monto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImporteDevolver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImporteRepartir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Comisiones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Beneficio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.lblFecha);
            this.panel5.Location = new System.Drawing.Point(-2, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1275, 57);
            this.panel5.TabIndex = 240;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1275, 1);
            this.panel2.TabIndex = 227;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.label4.Location = new System.Drawing.Point(28, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 33);
            this.label4.TabIndex = 96;
            this.label4.Text = "Reportes";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblFecha.Location = new System.Drawing.Point(32, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 22);
            this.lblFecha.TabIndex = 97;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.panel6);
            this.panelControl1.Location = new System.Drawing.Point(24, 79);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1212, 546);
            this.panelControl1.TabIndex = 241;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Controls.Add(this.lblNoRegitros);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txtBuscar);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.grdReportes);
            this.panel6.Location = new System.Drawing.Point(2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1208, 542);
            this.panel6.TabIndex = 0;
            // 
            // lblNoRegitros
            // 
            this.lblNoRegitros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNoRegitros.AutoSize = true;
            this.lblNoRegitros.Depth = 0;
            this.lblNoRegitros.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNoRegitros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoRegitros.Location = new System.Drawing.Point(19, 516);
            this.lblNoRegitros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoRegitros.Name = "lblNoRegitros";
            this.lblNoRegitros.Size = new System.Drawing.Size(137, 19);
            this.lblNoRegitros.TabIndex = 216;
            this.lblNoRegitros.Text = "No. de Registros: --";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 210;
            this.label1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "";
            this.txtBuscar.Location = new System.Drawing.Point(23, 40);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(194, 23);
            this.txtBuscar.TabIndex = 213;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(21, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 66);
            this.panel1.TabIndex = 215;
            // 
            // grdReportes
            // 
            this.grdReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdReportes.Location = new System.Drawing.Point(22, 22);
            this.grdReportes.MainView = this.gridView1;
            this.grdReportes.Name = "grdReportes";
            this.grdReportes.Size = new System.Drawing.Size(1168, 488);
            this.grdReportes.TabIndex = 214;
            this.grdReportes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView1.Appearance.FixedLine.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView1.Appearance.FixedLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView1.Appearance.FixedLine.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FixedLine.Options.UseBorderColor = true;
            this.gridView1.Appearance.FixedLine.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gridView1.Appearance.GroupPanel.BorderColor = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Cliente,
            this.Nombre,
            this.Ejecutivo,
            this.NoFactura,
            this.Referencia,
            this.FechaPago,
            this.Monto,
            this.ImporteDevolver,
            this.ImporteRepartir,
            this.Comisiones,
            this.Beneficio});
            this.gridView1.GridControl = this.grdReportes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.PaintStyleName = "Web";
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "sCliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.OptionsColumn.AllowEdit = false;
            this.Cliente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "sNombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.OptionsColumn.AllowEdit = false;
            this.Nombre.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 1;
            // 
            // Ejecutivo
            // 
            this.Ejecutivo.Caption = "Ejecutivo";
            this.Ejecutivo.FieldName = "sEjecutivo";
            this.Ejecutivo.Name = "Ejecutivo";
            this.Ejecutivo.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Ejecutivo.Visible = true;
            this.Ejecutivo.VisibleIndex = 2;
            // 
            // NoFactura
            // 
            this.NoFactura.Caption = "No. Factura";
            this.NoFactura.FieldName = "sNoFactura";
            this.NoFactura.Name = "NoFactura";
            this.NoFactura.OptionsColumn.AllowEdit = false;
            this.NoFactura.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.NoFactura.Visible = true;
            this.NoFactura.VisibleIndex = 3;
            // 
            // Referencia
            // 
            this.Referencia.Caption = "Referencia";
            this.Referencia.FieldName = "sReferencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.OptionsColumn.AllowEdit = false;
            this.Referencia.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Referencia.Visible = true;
            this.Referencia.VisibleIndex = 4;
            // 
            // FechaPago
            // 
            this.FechaPago.Caption = "Fecha de Deposito";
            this.FechaPago.FieldName = "dtFechaPago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.OptionsColumn.AllowEdit = false;
            this.FechaPago.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart;
            this.FechaPago.Visible = true;
            this.FechaPago.VisibleIndex = 5;
            // 
            // Monto
            // 
            this.Monto.Caption = "Importe";
            this.Monto.DisplayFormat.FormatString = "C2";
            this.Monto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Monto.FieldName = "dMonto";
            this.Monto.Name = "Monto";
            this.Monto.OptionsColumn.AllowEdit = false;
            this.Monto.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Monto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dMonto", "{0:C2}")});
            this.Monto.Visible = true;
            this.Monto.VisibleIndex = 6;
            // 
            // ImporteDevolver
            // 
            this.ImporteDevolver.Caption = "Devolución";
            this.ImporteDevolver.DisplayFormat.FormatString = "C2";
            this.ImporteDevolver.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ImporteDevolver.FieldName = "dImporteDevolver";
            this.ImporteDevolver.Name = "ImporteDevolver";
            this.ImporteDevolver.OptionsColumn.AllowEdit = false;
            this.ImporteDevolver.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.ImporteDevolver.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dImporteDevolver", "{0:C2}")});
            this.ImporteDevolver.Visible = true;
            this.ImporteDevolver.VisibleIndex = 7;
            // 
            // ImporteRepartir
            // 
            this.ImporteRepartir.Caption = "Importe a Repartir";
            this.ImporteRepartir.DisplayFormat.FormatString = "C2";
            this.ImporteRepartir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ImporteRepartir.FieldName = "dImporteRepartir";
            this.ImporteRepartir.Name = "ImporteRepartir";
            this.ImporteRepartir.OptionsColumn.AllowEdit = false;
            this.ImporteRepartir.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.ImporteRepartir.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dImporteRepartir", "{0:C2}")});
            this.ImporteRepartir.Visible = true;
            this.ImporteRepartir.VisibleIndex = 8;
            // 
            // Comisiones
            // 
            this.Comisiones.Caption = "Total de Comisiones";
            this.Comisiones.DisplayFormat.FormatString = "C2";
            this.Comisiones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Comisiones.FieldName = "dComisiones";
            this.Comisiones.Name = "Comisiones";
            this.Comisiones.OptionsColumn.AllowEdit = false;
            this.Comisiones.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Comisiones.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dComisiones", "{0:C2}")});
            this.Comisiones.Visible = true;
            this.Comisiones.VisibleIndex = 9;
            // 
            // Beneficio
            // 
            this.Beneficio.Caption = "Beneficio";
            this.Beneficio.DisplayFormat.FormatString = "C2";
            this.Beneficio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Beneficio.FieldName = "dBeneficio";
            this.Beneficio.Name = "Beneficio";
            this.Beneficio.OptionsColumn.AllowEdit = false;
            this.Beneficio.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Beneficio.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dBeneficio", "{0:C2}")});
            this.Beneficio.Visible = true;
            this.Beneficio.VisibleIndex = 10;
            // 
            // frmReportesOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1268, 644);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel5);
            this.Name = "frmReportesOperaciones";
            this.Text = "frmReportesOperaciones";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Components.MetroToolTip metroToolTip1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblFecha;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.Panel panel6;
		private MaterialSkin.Controls.MaterialLabel lblNoRegitros;
		private MaterialSkin.Controls.MaterialLabel label1;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraGrid.GridControl grdReportes;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn Cliente;
		private DevExpress.XtraGrid.Columns.GridColumn Nombre;
		private DevExpress.XtraGrid.Columns.GridColumn NoFactura;
		private DevExpress.XtraGrid.Columns.GridColumn Referencia;
		private DevExpress.XtraGrid.Columns.GridColumn FechaPago;
		private DevExpress.XtraGrid.Columns.GridColumn Monto;
		private DevExpress.XtraGrid.Columns.GridColumn ImporteDevolver;
		private DevExpress.XtraGrid.Columns.GridColumn ImporteRepartir;
		private DevExpress.XtraGrid.Columns.GridColumn Comisiones;
		private DevExpress.XtraGrid.Columns.GridColumn Beneficio;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private DevExpress.XtraGrid.Columns.GridColumn Ejecutivo;
	}
}