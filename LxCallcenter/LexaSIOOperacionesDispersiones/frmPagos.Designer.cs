namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	partial class frmPagos
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
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id_Concepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Concepto_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdPagos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoSocio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Concepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Monto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Referencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ganancia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostoFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ComisionNeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNoRegitros = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id_Concepto,
            this.Concepto_});
            this.gridView2.GridControl = this.grdPagos;
            this.gridView2.Name = "gridView2";
            // 
            // Id_Concepto
            // 
            this.Id_Concepto.Caption = "Código";
            this.Id_Concepto.FieldName = "iIdConcepto";
            this.Id_Concepto.Name = "Id_Concepto";
            this.Id_Concepto.Visible = true;
            this.Id_Concepto.VisibleIndex = 0;
            // 
            // Concepto_
            // 
            this.Concepto_.Caption = "Concepto";
            this.Concepto_.FieldName = "sConcepto";
            this.Concepto_.Name = "Concepto_";
            this.Concepto_.Visible = true;
            this.Concepto_.VisibleIndex = 1;
            // 
            // grdPagos
            // 
            this.grdPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPagos.Location = new System.Drawing.Point(22, 22);
            this.grdPagos.MainView = this.gridView1;
            this.grdPagos.Name = "grdPagos";
            this.grdPagos.Size = new System.Drawing.Size(1172, 488);
            this.grdPagos.TabIndex = 96;
            this.grdPagos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
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
            this.IdPago,
            this.fecha,
            this.NoFactura,
            this.NoSocio,
            this.Nombre,
            this.NoOperacion,
            this.Concepto,
            this.Banco,
            this.Monto,
            this.Referencia,
            this.Ganancia,
            this.CostoFiscal,
            this.ComisionNeta});
            this.gridView1.GridControl = this.grdPagos;
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
            this.gridView1.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridView1_MasterRowExpanded);
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
            // 
            // IdPago
            // 
            this.IdPago.Caption = "Id Pago";
            this.IdPago.FieldName = "iIdPago";
            this.IdPago.Name = "IdPago";
            // 
            // fecha
            // 
            this.fecha.Caption = "Fecha";
            this.fecha.FieldName = "dtFecha";
            this.fecha.Name = "fecha";
            this.fecha.OptionsColumn.AllowEdit = false;
            this.fecha.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart;
            this.fecha.Visible = true;
            this.fecha.VisibleIndex = 0;
            // 
            // NoFactura
            // 
            this.NoFactura.Caption = "No. Factura";
            this.NoFactura.FieldName = "sNoFactura";
            this.NoFactura.Name = "NoFactura";
            this.NoFactura.OptionsColumn.AllowEdit = false;
            this.NoFactura.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.NoFactura.Visible = true;
            this.NoFactura.VisibleIndex = 1;
            // 
            // NoSocio
            // 
            this.NoSocio.Caption = "No. Socio";
            this.NoSocio.FieldName = "sNoSocio";
            this.NoSocio.Name = "NoSocio";
            this.NoSocio.OptionsColumn.AllowEdit = false;
            this.NoSocio.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.NoSocio.Visible = true;
            this.NoSocio.VisibleIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "sNombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.OptionsColumn.AllowEdit = false;
            this.Nombre.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 3;
            // 
            // NoOperacion
            // 
            this.NoOperacion.Caption = "No. Operación";
            this.NoOperacion.FieldName = "sNoOperacion";
            this.NoOperacion.Name = "NoOperacion";
            this.NoOperacion.OptionsColumn.AllowEdit = false;
            this.NoOperacion.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.NoOperacion.Visible = true;
            this.NoOperacion.VisibleIndex = 4;
            // 
            // Concepto
            // 
            this.Concepto.Caption = "Concepto";
            this.Concepto.FieldName = "sConcepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.OptionsColumn.AllowEdit = false;
            this.Concepto.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Concepto.Visible = true;
            this.Concepto.VisibleIndex = 5;
            // 
            // Banco
            // 
            this.Banco.Caption = "Banco";
            this.Banco.FieldName = "sBanco";
            this.Banco.Name = "Banco";
            this.Banco.OptionsColumn.AllowEdit = false;
            this.Banco.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Banco.Visible = true;
            this.Banco.VisibleIndex = 6;
            // 
            // Monto
            // 
            this.Monto.Caption = "Ingreso";
            this.Monto.DisplayFormat.FormatString = "C2";
            this.Monto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Monto.FieldName = "dMonto";
            this.Monto.Name = "Monto";
            this.Monto.OptionsColumn.AllowEdit = false;
            this.Monto.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Monto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dMonto", "{0:C2}")});
            this.Monto.Visible = true;
            this.Monto.VisibleIndex = 7;
            // 
            // Referencia
            // 
            this.Referencia.Caption = "Referencia Bancaria";
            this.Referencia.FieldName = "sReferencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.OptionsColumn.AllowEdit = false;
            this.Referencia.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Referencia.Visible = true;
            this.Referencia.VisibleIndex = 8;
            // 
            // Ganancia
            // 
            this.Ganancia.Caption = "Utilidad";
            this.Ganancia.DisplayFormat.FormatString = "C2";
            this.Ganancia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Ganancia.FieldName = "dGanancia";
            this.Ganancia.Name = "Ganancia";
            this.Ganancia.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dGanancia", "{0:C2}")});
            // 
            // CostoFiscal
            // 
            this.CostoFiscal.Caption = "Costo Fiscal";
            this.CostoFiscal.DisplayFormat.FormatString = "C2";
            this.CostoFiscal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CostoFiscal.FieldName = "dCostoFiscal";
            this.CostoFiscal.Name = "CostoFiscal";
            this.CostoFiscal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dCostoFiscal", "{0:C2}")});
            // 
            // ComisionNeta
            // 
            this.ComisionNeta.Caption = "Utilidad Neta";
            this.ComisionNeta.DisplayFormat.FormatString = "C2";
            this.ComisionNeta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ComisionNeta.FieldName = "dComisionNeta";
            this.ComisionNeta.Name = "ComisionNeta";
            this.ComisionNeta.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dComisionNeta", "{0:C2}")});
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.lblFecha);
            this.panel6.Location = new System.Drawing.Point(-2, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1275, 58);
            this.panel6.TabIndex = 228;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.label4.Location = new System.Drawing.Point(23, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 33);
            this.label4.TabIndex = 94;
            this.label4.Text = "Concentrado de Pagos";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1275, 1);
            this.panel4.TabIndex = 226;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblFecha.Location = new System.Drawing.Point(24, 30);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(360, 22);
            this.lblFecha.TabIndex = 95;
            this.lblFecha.Text = "Consulta el concentrado de pagos de los clientes.";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivo Excel | *.xlsx";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.panel7);
            this.panelControl1.Location = new System.Drawing.Point(24, 79);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1219, 553);
            this.panelControl1.TabIndex = 229;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.txtBuscar);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.lblNoRegitros);
            this.panel7.Controls.Add(this.grdPagos);
            this.panel7.Location = new System.Drawing.Point(2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1215, 549);
            this.panel7.TabIndex = 0;
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
            this.txtBuscar.Size = new System.Drawing.Size(193, 23);
            this.txtBuscar.TabIndex = 209;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(21, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 47);
            this.panel1.TabIndex = 212;
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
            this.lblNoRegitros.TabIndex = 211;
            this.lblNoRegitros.Text = "No. de Registros: --";
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1268, 644);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel6);
            this.Name = "frmPagos";
            this.Text = "frmPagos";
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private MetroFramework.Components.MetroToolTip metroToolTip1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.Panel panel7;
		private MaterialSkin.Controls.MaterialLabel label1;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn IdPago;
		private DevExpress.XtraGrid.Columns.GridColumn fecha;
		private DevExpress.XtraGrid.Columns.GridColumn NoFactura;
		private DevExpress.XtraGrid.Columns.GridColumn NoSocio;
		private DevExpress.XtraGrid.Columns.GridColumn Nombre;
		private DevExpress.XtraGrid.Columns.GridColumn NoOperacion;
		private DevExpress.XtraGrid.Columns.GridColumn Concepto;
		private DevExpress.XtraGrid.Columns.GridColumn Banco;
		private DevExpress.XtraGrid.Columns.GridColumn Monto;
		private DevExpress.XtraGrid.Columns.GridColumn Referencia;
		private MaterialSkin.Controls.MaterialLabel lblNoRegitros;
		private System.Windows.Forms.Panel panel1;
		public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.Columns.GridColumn Id_Concepto;
		private DevExpress.XtraGrid.Columns.GridColumn Concepto_;
		public DevExpress.XtraGrid.GridControl grdPagos;
		private DevExpress.XtraGrid.Columns.GridColumn Ganancia;
		private DevExpress.XtraGrid.Columns.GridColumn CostoFiscal;
		private DevExpress.XtraGrid.Columns.GridColumn ComisionNeta;
	}
}