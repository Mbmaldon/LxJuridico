namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    partial class frmComisiones
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
			this.lblFecha = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.grdComisionistas = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.NoOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.NoFactura = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FechaDeposito = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Importe = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Iva = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
			this.NombreComisionista = new DevExpress.XtraGrid.Columns.GridColumn();
			this.NombreVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Ventas = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Pagadas = new DevExpress.XtraGrid.Columns.GridColumn();
			this.PorcentajeTotal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RFC = new DevExpress.XtraGrid.Columns.GridColumn();
			this.UUID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Concepto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Descuento = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Moneda = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Estatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.NumeroOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.pblImportes = new System.Windows.Forms.Panel();
			this.cmbxAño = new MetroFramework.Controls.MetroComboBox();
			this.lollipopLabel1 = new LollipopLabel();
			this.label5 = new LollipopLabel();
			this.label7 = new LollipopLabel();
			this.lblTotalIngresos = new LollipopLabel();
			this.lblImporteRepartidoAlimentos = new LollipopLabel();
			this.label95 = new LollipopLabel();
			this.label2 = new LollipopLabel();
			this.cmbxTipoFactura = new MetroFramework.Controls.MetroComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label1 = new MaterialSkin.Controls.MaterialLabel();
			this.cmbxEstadoFac = new MetroFramework.Controls.MetroComboBox();
			this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.cmbxNoSemana = new MetroFramework.Controls.MetroComboBox();
			this.lblNoSemana = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btnExportar = new System.Windows.Forms.Button();
			this.btnMostrarPagadas = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.pnlPagoComisiones = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnlComentario = new System.Windows.Forms.Panel();
			this.txtComentario = new LollipopTextBox();
			this.btnCancelarCanFac = new LollipopFlatButton();
			this.btnCancelarFactura = new LollipopButton();
			this.label9 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lnkCancelarFactura = new MetroFramework.Controls.MetroLink();
			this.btnFacturaPagada = new System.Windows.Forms.Button();
			this.dtFechaDeposito = new MetroFramework.Controls.MetroDateTime();
			this.dtFechaFactura = new MetroFramework.Controls.MetroDateTime();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.lblImporteTotal = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.lblNoFactura = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.pnlComisiones = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lnkCerrarPagoComisiones = new MetroFramework.Controls.MetroLink();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblNoOperacion = new System.Windows.Forms.Label();
			this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.panel7 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.grdComisionistas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.pblImportes.SuspendLayout();
			this.pnlPagoComisiones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pnlComentario.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.lblFecha.Location = new System.Drawing.Point(24, 30);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(489, 22);
			this.lblFecha.TabIndex = 95;
			this.lblFecha.Text = "Consulta el concentrado de facturas sobre los pagos de los clientes.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
			this.label4.Location = new System.Drawing.Point(23, -2);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(281, 33);
			this.label4.TabIndex = 94;
			this.label4.Text = "Concentrado de Facturas";
			// 
			// grdComisionistas
			// 
			this.grdComisionistas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdComisionistas.Location = new System.Drawing.Point(22, 96);
			this.grdComisionistas.MainView = this.gridView1;
			this.grdComisionistas.Name = "grdComisionistas";
			this.grdComisionistas.Size = new System.Drawing.Size(1172, 435);
			this.grdComisionistas.TabIndex = 96;
			this.grdComisionistas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.NoOperacion,
            this.NoFactura,
            this.FechaFactura,
            this.FechaDeposito,
            this.Importe,
            this.Iva,
            this.Total,
            this.NombreComisionista,
            this.NombreVendedor,
            this.Ventas,
            this.Pagadas,
            this.PorcentajeTotal,
            this.RFC,
            this.UUID,
            this.Concepto,
            this.Descuento,
            this.Moneda,
            this.Estatus,
            this.NumeroOperacion});
			this.gridView1.GridControl = this.grdComisionistas;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.Editable = false;
			this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
			this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
			this.gridView1.OptionsMenu.EnableFooterMenu = false;
			this.gridView1.OptionsView.ColumnAutoWidth = false;
			this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
			this.gridView1.OptionsView.RowAutoHeight = true;
			this.gridView1.OptionsView.ShowFooter = true;
			this.gridView1.OptionsView.ShowIndicator = false;
			this.gridView1.PaintStyleName = "Web";
			// 
			// NoOperacion
			// 
			this.NoOperacion.Caption = "Id Operación";
			this.NoOperacion.FieldName = "iIdOperacion";
			this.NoOperacion.Name = "NoOperacion";
			this.NoOperacion.OptionsColumn.AllowEdit = false;
			// 
			// NoFactura
			// 
			this.NoFactura.Caption = "No. Factura";
			this.NoFactura.FieldName = "sNoFactura";
			this.NoFactura.Name = "NoFactura";
			this.NoFactura.Visible = true;
			this.NoFactura.VisibleIndex = 1;
			// 
			// FechaFactura
			// 
			this.FechaFactura.Caption = "Fecha de Factura";
			this.FechaFactura.FieldName = "sFechaFactura";
			this.FechaFactura.Name = "FechaFactura";
			this.FechaFactura.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateAlt;
			this.FechaFactura.Visible = true;
			this.FechaFactura.VisibleIndex = 5;
			// 
			// FechaDeposito
			// 
			this.FechaDeposito.Caption = "Fecha de Depósito";
			this.FechaDeposito.FieldName = "sFechaDeposito";
			this.FechaDeposito.Name = "FechaDeposito";
			this.FechaDeposito.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateAlt;
			this.FechaDeposito.Visible = true;
			this.FechaDeposito.VisibleIndex = 6;
			// 
			// Importe
			// 
			this.Importe.Caption = "Subtotal";
			this.Importe.DisplayFormat.FormatString = "c2";
			this.Importe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.Importe.FieldName = "dImporte";
			this.Importe.Name = "Importe";
			this.Importe.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dImporte", "{0:c2}")});
			this.Importe.Visible = true;
			this.Importe.VisibleIndex = 8;
			// 
			// Iva
			// 
			this.Iva.Caption = "Iva";
			this.Iva.DisplayFormat.FormatString = "c2";
			this.Iva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.Iva.FieldName = "dIva";
			this.Iva.Name = "Iva";
			this.Iva.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dIva", "{0:c2}")});
			this.Iva.UnboundExpression = "[dImporte] * 0.16";
			this.Iva.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.Iva.Visible = true;
			this.Iva.VisibleIndex = 10;
			// 
			// Total
			// 
			this.Total.Caption = "Total";
			this.Total.DisplayFormat.FormatString = "c2";
			this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.Total.FieldName = "dTotal";
			this.Total.Name = "Total";
			this.Total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dTotal", "{0:c2}")});
			this.Total.UnboundExpression = "[dImporte] + [dIva]";
			this.Total.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.Total.Visible = true;
			this.Total.VisibleIndex = 11;
			// 
			// NombreComisionista
			// 
			this.NombreComisionista.Caption = "Cliente";
			this.NombreComisionista.FieldName = "sNombre";
			this.NombreComisionista.Name = "NombreComisionista";
			this.NombreComisionista.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.NombreComisionista.Visible = true;
			this.NombreComisionista.VisibleIndex = 3;
			// 
			// NombreVendedor
			// 
			this.NombreVendedor.Caption = "Vendedor";
			this.NombreVendedor.FieldName = "sVendedor";
			this.NombreVendedor.Name = "NombreVendedor";
			// 
			// Ventas
			// 
			this.Ventas.Caption = "Ventas";
			this.Ventas.FieldName = "iVentas";
			this.Ventas.Name = "Ventas";
			// 
			// Pagadas
			// 
			this.Pagadas.Caption = "Ventas Pagadas";
			this.Pagadas.FieldName = "iPagadas";
			this.Pagadas.Name = "Pagadas";
			// 
			// PorcentajeTotal
			// 
			this.PorcentajeTotal.Caption = "Porcentaje";
			this.PorcentajeTotal.DisplayFormat.FormatString = "P0";
			this.PorcentajeTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.PorcentajeTotal.FieldName = "PorcentajeTotal";
			this.PorcentajeTotal.Name = "PorcentajeTotal";
			this.PorcentajeTotal.UnboundExpression = "Iif([iVentas] >= 1 And [iVentas] <= 3, 0.3, Iif([iVentas] >= 4 And [iVentas] <= 7" +
    ", 0.45, Iif([iVentas] >= 8 And [iVentas] <= 11, 0.6, 0.6)))";
			this.PorcentajeTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			// 
			// RFC
			// 
			this.RFC.Caption = "RFC";
			this.RFC.FieldName = "sRfc";
			this.RFC.Name = "RFC";
			this.RFC.Visible = true;
			this.RFC.VisibleIndex = 2;
			// 
			// UUID
			// 
			this.UUID.Caption = "UUID";
			this.UUID.FieldName = "sUUID";
			this.UUID.Name = "UUID";
			this.UUID.Visible = true;
			this.UUID.VisibleIndex = 4;
			// 
			// Concepto
			// 
			this.Concepto.Caption = "Concepto";
			this.Concepto.FieldName = "sConcepto";
			this.Concepto.Name = "Concepto";
			this.Concepto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "sConcepto", "TOTALES")});
			this.Concepto.Visible = true;
			this.Concepto.VisibleIndex = 7;
			// 
			// Descuento
			// 
			this.Descuento.Caption = "Descuento";
			this.Descuento.FieldName = "dDescuento";
			this.Descuento.Name = "Descuento";
			this.Descuento.Visible = true;
			this.Descuento.VisibleIndex = 9;
			// 
			// Moneda
			// 
			this.Moneda.Caption = "Moneda";
			this.Moneda.FieldName = "sMoneda";
			this.Moneda.Name = "Moneda";
			this.Moneda.Visible = true;
			this.Moneda.VisibleIndex = 12;
			// 
			// Estatus
			// 
			this.Estatus.Caption = "Sts";
			this.Estatus.FieldName = "sEstatus";
			this.Estatus.Name = "Estatus";
			this.Estatus.Visible = true;
			this.Estatus.VisibleIndex = 13;
			// 
			// NumeroOperacion
			// 
			this.NumeroOperacion.Caption = "No. Operación";
			this.NumeroOperacion.FieldName = "sNoOperacion";
			this.NumeroOperacion.Name = "NumeroOperacion";
			this.NumeroOperacion.Visible = true;
			this.NumeroOperacion.VisibleIndex = 0;
			// 
			// pblImportes
			// 
			this.pblImportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pblImportes.AutoScroll = true;
			this.pblImportes.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pblImportes.Controls.Add(this.cmbxAño);
			this.pblImportes.Controls.Add(this.lollipopLabel1);
			this.pblImportes.Controls.Add(this.label5);
			this.pblImportes.Controls.Add(this.label7);
			this.pblImportes.Controls.Add(this.lblTotalIngresos);
			this.pblImportes.Controls.Add(this.lblImporteRepartidoAlimentos);
			this.pblImportes.Controls.Add(this.label95);
			this.pblImportes.Controls.Add(this.label2);
			this.pblImportes.Controls.Add(this.cmbxTipoFactura);
			this.pblImportes.Controls.Add(this.label8);
			this.pblImportes.Controls.Add(this.label1);
			this.pblImportes.Controls.Add(this.cmbxEstadoFac);
			this.pblImportes.Controls.Add(this.txtBuscar);
			this.pblImportes.Controls.Add(this.cmbxNoSemana);
			this.pblImportes.Controls.Add(this.lblNoSemana);
			this.pblImportes.Controls.Add(this.label10);
			this.pblImportes.Location = new System.Drawing.Point(13, 11);
			this.pblImportes.Name = "pblImportes";
			this.pblImportes.Size = new System.Drawing.Size(1181, 76);
			this.pblImportes.TabIndex = 97;
			// 
			// cmbxAño
			// 
			this.cmbxAño.FormattingEnabled = true;
			this.cmbxAño.ItemHeight = 23;
			this.cmbxAño.Location = new System.Drawing.Point(883, 3);
			this.cmbxAño.Name = "cmbxAño";
			this.cmbxAño.Size = new System.Drawing.Size(84, 29);
			this.cmbxAño.Style = MetroFramework.MetroColorStyle.Purple;
			this.cmbxAño.TabIndex = 218;
			this.cmbxAño.UseSelectable = true;
			this.cmbxAño.SelectionChangeCommitted += new System.EventHandler(this.cmbxAño_SelectionChangeCommitted);
			// 
			// lollipopLabel1
			// 
			this.lollipopLabel1.AutoSize = true;
			this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
			this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.lollipopLabel1.Location = new System.Drawing.Point(816, 9);
			this.lollipopLabel1.Name = "lollipopLabel1";
			this.lollipopLabel1.Size = new System.Drawing.Size(33, 17);
			this.lollipopLabel1.TabIndex = 217;
			this.lollipopLabel1.Text = "Año";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.label5.Location = new System.Drawing.Point(816, 45);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 17);
			this.label5.TabIndex = 216;
			this.label5.Text = "Semana";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.label7.Location = new System.Drawing.Point(625, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(121, 17);
			this.label7.TabIndex = 215;
			this.label7.Text = "Semana en Curso";
			// 
			// lblTotalIngresos
			// 
			this.lblTotalIngresos.AutoSize = true;
			this.lblTotalIngresos.BackColor = System.Drawing.Color.Transparent;
			this.lblTotalIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblTotalIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
			this.lblTotalIngresos.Location = new System.Drawing.Point(404, 43);
			this.lblTotalIngresos.Name = "lblTotalIngresos";
			this.lblTotalIngresos.Size = new System.Drawing.Size(30, 17);
			this.lblTotalIngresos.TabIndex = 214;
			this.lblTotalIngresos.Text = "$ --";
			// 
			// lblImporteRepartidoAlimentos
			// 
			this.lblImporteRepartidoAlimentos.AutoSize = true;
			this.lblImporteRepartidoAlimentos.BackColor = System.Drawing.Color.Transparent;
			this.lblImporteRepartidoAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblImporteRepartidoAlimentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
			this.lblImporteRepartidoAlimentos.Location = new System.Drawing.Point(404, 22);
			this.lblImporteRepartidoAlimentos.Name = "lblImporteRepartidoAlimentos";
			this.lblImporteRepartidoAlimentos.Size = new System.Drawing.Size(30, 17);
			this.lblImporteRepartidoAlimentos.TabIndex = 213;
			this.lblImporteRepartidoAlimentos.Text = "$ --";
			// 
			// label95
			// 
			this.label95.AutoSize = true;
			this.label95.BackColor = System.Drawing.Color.Transparent;
			this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label95.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.label95.Location = new System.Drawing.Point(262, 43);
			this.label95.Name = "label95";
			this.label95.Size = new System.Drawing.Size(118, 17);
			this.label95.TabIndex = 212;
			this.label95.Text = "Total de Ingresos";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.label2.Location = new System.Drawing.Point(262, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 17);
			this.label2.TabIndex = 211;
			this.label2.Text = "Subtotal de Ingresos";
			// 
			// cmbxTipoFactura
			// 
			this.cmbxTipoFactura.FormattingEnabled = true;
			this.cmbxTipoFactura.ItemHeight = 23;
			this.cmbxTipoFactura.Location = new System.Drawing.Point(1086, 3);
			this.cmbxTipoFactura.Name = "cmbxTipoFactura";
			this.cmbxTipoFactura.Size = new System.Drawing.Size(28, 29);
			this.cmbxTipoFactura.Style = MetroFramework.MetroColorStyle.Yellow;
			this.cmbxTipoFactura.TabIndex = 208;
			this.cmbxTipoFactura.UseSelectable = true;
			this.cmbxTipoFactura.Visible = false;
			this.cmbxTipoFactura.SelectedIndexChanged += new System.EventHandler(this.cmbxTipoFactura_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label8.Location = new System.Drawing.Point(975, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(104, 15);
			this.label8.TabIndex = 207;
			this.label8.Text = "TIPO DE FACTURA";
			this.label8.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Depth = 0;
			this.label1.Font = new System.Drawing.Font("Roboto Medium", 11F);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(11, 23);
			this.label1.MouseState = MaterialSkin.MouseState.HOVER;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 20);
			this.label1.TabIndex = 210;
			this.label1.Text = "Buscar (No. de Factura)";
			// 
			// cmbxEstadoFac
			// 
			this.cmbxEstadoFac.FormattingEnabled = true;
			this.cmbxEstadoFac.ItemHeight = 23;
			this.cmbxEstadoFac.Items.AddRange(new object[] {
            "Canceladas",
            "Activas"});
			this.cmbxEstadoFac.Location = new System.Drawing.Point(1086, 38);
			this.cmbxEstadoFac.Name = "cmbxEstadoFac";
			this.cmbxEstadoFac.Size = new System.Drawing.Size(28, 29);
			this.cmbxEstadoFac.Style = MetroFramework.MetroColorStyle.Yellow;
			this.cmbxEstadoFac.TabIndex = 204;
			this.cmbxEstadoFac.UseSelectable = true;
			this.cmbxEstadoFac.Visible = false;
			this.cmbxEstadoFac.SelectedIndexChanged += new System.EventHandler(this.cmbxEstadoFac_SelectedIndexChanged);
			// 
			// txtBuscar
			// 
			this.txtBuscar.Depth = 0;
			this.txtBuscar.Hint = "No. de Factura";
			this.txtBuscar.Location = new System.Drawing.Point(14, 45);
			this.txtBuscar.MaxLength = 32767;
			this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.PasswordChar = '\0';
			this.txtBuscar.SelectedText = "";
			this.txtBuscar.SelectionLength = 0;
			this.txtBuscar.SelectionStart = 0;
			this.txtBuscar.Size = new System.Drawing.Size(193, 25);
			this.txtBuscar.TabIndex = 209;
			this.txtBuscar.TabStop = false;
			this.txtBuscar.UseSystemPasswordChar = false;
			this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
			// 
			// cmbxNoSemana
			// 
			this.cmbxNoSemana.FormattingEnabled = true;
			this.cmbxNoSemana.ItemHeight = 23;
			this.cmbxNoSemana.Location = new System.Drawing.Point(883, 39);
			this.cmbxNoSemana.Name = "cmbxNoSemana";
			this.cmbxNoSemana.Size = new System.Drawing.Size(84, 29);
			this.cmbxNoSemana.Style = MetroFramework.MetroColorStyle.Purple;
			this.cmbxNoSemana.TabIndex = 204;
			this.cmbxNoSemana.UseSelectable = true;
			this.cmbxNoSemana.SelectionChangeCommitted += new System.EventHandler(this.cmbxNoSemana_SelectedIndexChanged);
			// 
			// lblNoSemana
			// 
			this.lblNoSemana.AutoSize = true;
			this.lblNoSemana.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNoSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
			this.lblNoSemana.Location = new System.Drawing.Point(749, 28);
			this.lblNoSemana.Name = "lblNoSemana";
			this.lblNoSemana.Size = new System.Drawing.Size(22, 25);
			this.lblNoSemana.TabIndex = 115;
			this.lblNoSemana.Text = "0";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label10.Location = new System.Drawing.Point(1024, 45);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(50, 15);
			this.label10.TabIndex = 114;
			this.label10.Text = "ESTADO";
			this.label10.Visible = false;
			// 
			// btnExportar
			// 
			this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(71)))));
			this.btnExportar.FlatAppearance.BorderSize = 0;
			this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(80)))), ((int)(((byte)(71)))));
			this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(100)))), ((int)(((byte)(71)))));
			this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnExportar.Image = global::LxCallcenter.Properties.Resources.Excel_Export;
			this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnExportar.Location = new System.Drawing.Point(1214, 18);
			this.btnExportar.Name = "btnExportar";
			this.btnExportar.Size = new System.Drawing.Size(5, 5);
			this.btnExportar.TabIndex = 202;
			this.btnExportar.Text = "Exportar";
			this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExportar.UseVisualStyleBackColor = false;
			this.btnExportar.Visible = false;
			this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
			// 
			// btnMostrarPagadas
			// 
			this.btnMostrarPagadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMostrarPagadas.BackColor = System.Drawing.Color.Gray;
			this.btnMostrarPagadas.FlatAppearance.BorderSize = 0;
			this.btnMostrarPagadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
			this.btnMostrarPagadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
			this.btnMostrarPagadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMostrarPagadas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnMostrarPagadas.Image = global::LxCallcenter.Properties.Resources.Payments_01_WF;
			this.btnMostrarPagadas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnMostrarPagadas.Location = new System.Drawing.Point(1227, 18);
			this.btnMostrarPagadas.Name = "btnMostrarPagadas";
			this.btnMostrarPagadas.Size = new System.Drawing.Size(5, 5);
			this.btnMostrarPagadas.TabIndex = 203;
			this.btnMostrarPagadas.Text = "Ver Detalles";
			this.btnMostrarPagadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnMostrarPagadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMostrarPagadas.UseVisualStyleBackColor = false;
			this.btnMostrarPagadas.Visible = false;
			this.btnMostrarPagadas.Click += new System.EventHandler(this.btnMostrarPagadas_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Archivo Excel | *.xlsx";
			// 
			// pnlPagoComisiones
			// 
			this.pnlPagoComisiones.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlPagoComisiones.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pnlPagoComisiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlPagoComisiones.Controls.Add(this.pictureBox1);
			this.pnlPagoComisiones.Controls.Add(this.pnlComentario);
			this.pnlPagoComisiones.Controls.Add(this.panel2);
			this.pnlPagoComisiones.Controls.Add(this.btnFacturaPagada);
			this.pnlPagoComisiones.Controls.Add(this.dtFechaDeposito);
			this.pnlPagoComisiones.Controls.Add(this.dtFechaFactura);
			this.pnlPagoComisiones.Controls.Add(this.label17);
			this.pnlPagoComisiones.Controls.Add(this.label18);
			this.pnlPagoComisiones.Controls.Add(this.lblImporteTotal);
			this.pnlPagoComisiones.Controls.Add(this.label16);
			this.pnlPagoComisiones.Controls.Add(this.lblNoFactura);
			this.pnlPagoComisiones.Controls.Add(this.label12);
			this.pnlPagoComisiones.Controls.Add(this.lblCliente);
			this.pnlPagoComisiones.Controls.Add(this.label6);
			this.pnlPagoComisiones.Controls.Add(this.panel1);
			this.pnlPagoComisiones.Controls.Add(this.label3);
			this.pnlPagoComisiones.Controls.Add(this.pnlComisiones);
			this.pnlPagoComisiones.Controls.Add(this.panel3);
			this.pnlPagoComisiones.Controls.Add(this.panel5);
			this.pnlPagoComisiones.Location = new System.Drawing.Point(374, 79);
			this.pnlPagoComisiones.Name = "pnlPagoComisiones";
			this.pnlPagoComisiones.Size = new System.Drawing.Size(522, 451);
			this.pnlPagoComisiones.TabIndex = 203;
			this.pnlPagoComisiones.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LxCallcenter.Properties.Resources.info_25px;
			this.pictureBox1.Location = new System.Drawing.Point(17, 61);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(25, 26);
			this.pictureBox1.TabIndex = 216;
			this.pictureBox1.TabStop = false;
			// 
			// pnlComentario
			// 
			this.pnlComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlComentario.BackColor = System.Drawing.SystemColors.Control;
			this.pnlComentario.Controls.Add(this.txtComentario);
			this.pnlComentario.Controls.Add(this.btnCancelarCanFac);
			this.pnlComentario.Controls.Add(this.btnCancelarFactura);
			this.pnlComentario.Controls.Add(this.label9);
			this.pnlComentario.Location = new System.Drawing.Point(-2, 131);
			this.pnlComentario.Name = "pnlComentario";
			this.pnlComentario.Size = new System.Drawing.Size(522, 167);
			this.pnlComentario.TabIndex = 215;
			this.pnlComentario.Visible = false;
			// 
			// txtComentario
			// 
			this.txtComentario.FocusedColor = "#FFA300";
			this.txtComentario.FontColor = "#999999";
			this.txtComentario.IsEnabled = true;
			this.txtComentario.Location = new System.Drawing.Point(42, 52);
			this.txtComentario.MaxLength = 32767;
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.ReadOnly = false;
			this.txtComentario.Size = new System.Drawing.Size(438, 70);
			this.txtComentario.TabIndex = 209;
			this.txtComentario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtComentario.UseSystemPasswordChar = false;
			// 
			// btnCancelarCanFac
			// 
			this.btnCancelarCanFac.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelarCanFac.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelarCanFac.FontColor = "#508ef5";
			this.btnCancelarCanFac.Location = new System.Drawing.Point(417, 128);
			this.btnCancelarCanFac.Name = "btnCancelarCanFac";
			this.btnCancelarCanFac.Size = new System.Drawing.Size(62, 26);
			this.btnCancelarCanFac.TabIndex = 208;
			this.btnCancelarCanFac.Text = "Salir";
			this.btnCancelarCanFac.Click += new System.EventHandler(this.btnCancelarCanFac_Click);
			// 
			// btnCancelarFactura
			// 
			this.btnCancelarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelarFactura.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelarFactura.BGColor = "#800000";
			this.btnCancelarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelarFactura.FontColor = "#ffffff";
			this.btnCancelarFactura.Location = new System.Drawing.Point(284, 128);
			this.btnCancelarFactura.Name = "btnCancelarFactura";
			this.btnCancelarFactura.Size = new System.Drawing.Size(125, 26);
			this.btnCancelarFactura.TabIndex = 207;
			this.btnCancelarFactura.Text = "Cancelar Factura";
			this.btnCancelarFactura.Click += new System.EventHandler(this.btnCancelarFactura_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.DimGray;
			this.label9.Location = new System.Drawing.Point(23, 12);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(208, 27);
			this.label9.TabIndex = 203;
			this.label9.Text = "Motivo de cancelación";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
			this.panel2.Controls.Add(this.lnkCancelarFactura);
			this.panel2.Location = new System.Drawing.Point(-1, 412);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(522, 37);
			this.panel2.TabIndex = 214;
			// 
			// lnkCancelarFactura
			// 
			this.lnkCancelarFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lnkCancelarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lnkCancelarFactura.FontWeight = MetroFramework.MetroLinkWeight.Regular;
			this.lnkCancelarFactura.Image = global::LxCallcenter.Properties.Resources.cancel_filled_16px_Hover_Total;
			this.lnkCancelarFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lnkCancelarFactura.Location = new System.Drawing.Point(199, 3);
			this.lnkCancelarFactura.Name = "lnkCancelarFactura";
			this.lnkCancelarFactura.NoFocusImage = global::LxCallcenter.Properties.Resources.cancel_16px_normal;
			this.lnkCancelarFactura.Size = new System.Drawing.Size(114, 31);
			this.lnkCancelarFactura.Style = MetroFramework.MetroColorStyle.Red;
			this.lnkCancelarFactura.TabIndex = 0;
			this.lnkCancelarFactura.Text = "Cancelar Factura";
			this.lnkCancelarFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.lnkCancelarFactura.UseCustomBackColor = true;
			this.lnkCancelarFactura.UseSelectable = true;
			this.lnkCancelarFactura.Click += new System.EventHandler(this.lnkCancelarFactura_Click);
			// 
			// btnFacturaPagada
			// 
			this.btnFacturaPagada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFacturaPagada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
			this.btnFacturaPagada.FlatAppearance.BorderSize = 0;
			this.btnFacturaPagada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFacturaPagada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnFacturaPagada.Image = global::LxCallcenter.Properties.Resources.Payments_01_WF;
			this.btnFacturaPagada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFacturaPagada.Location = new System.Drawing.Point(364, 188);
			this.btnFacturaPagada.Name = "btnFacturaPagada";
			this.btnFacturaPagada.Size = new System.Drawing.Size(114, 25);
			this.btnFacturaPagada.TabIndex = 212;
			this.btnFacturaPagada.Text = "Factura Pagada";
			this.btnFacturaPagada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFacturaPagada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFacturaPagada.UseVisualStyleBackColor = false;
			this.btnFacturaPagada.Click += new System.EventHandler(this.btnFacturaPagada_Click);
			// 
			// dtFechaDeposito
			// 
			this.dtFechaDeposito.Location = new System.Drawing.Point(282, 129);
			this.dtFechaDeposito.MinimumSize = new System.Drawing.Size(0, 29);
			this.dtFechaDeposito.Name = "dtFechaDeposito";
			this.dtFechaDeposito.Size = new System.Drawing.Size(196, 29);
			this.dtFechaDeposito.TabIndex = 211;
			// 
			// dtFechaFactura
			// 
			this.dtFechaFactura.Location = new System.Drawing.Point(46, 129);
			this.dtFechaFactura.MinimumSize = new System.Drawing.Size(0, 29);
			this.dtFechaFactura.Name = "dtFechaFactura";
			this.dtFechaFactura.Size = new System.Drawing.Size(196, 29);
			this.dtFechaFactura.TabIndex = 211;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.label17.ForeColor = System.Drawing.Color.DimGray;
			this.label17.Location = new System.Drawing.Point(278, 105);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(140, 22);
			this.label17.TabIndex = 210;
			this.label17.Text = "Fecha de depósito";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.label18.ForeColor = System.Drawing.Color.DimGray;
			this.label18.Location = new System.Drawing.Point(42, 105);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(128, 22);
			this.label18.TabIndex = 210;
			this.label18.Text = "Fecha de factura";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblImporteTotal
			// 
			this.lblImporteTotal.AutoSize = true;
			this.lblImporteTotal.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.lblImporteTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
			this.lblImporteTotal.Location = new System.Drawing.Point(278, 72);
			this.lblImporteTotal.Name = "lblImporteTotal";
			this.lblImporteTotal.Size = new System.Drawing.Size(32, 22);
			this.lblImporteTotal.TabIndex = 209;
			this.lblImporteTotal.Text = "$ --";
			this.lblImporteTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.label16.ForeColor = System.Drawing.Color.DimGray;
			this.label16.Location = new System.Drawing.Point(278, 50);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(105, 22);
			this.label16.TabIndex = 208;
			this.label16.Text = "Importe Total";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNoFactura
			// 
			this.lblNoFactura.AutoSize = true;
			this.lblNoFactura.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.lblNoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
			this.lblNoFactura.Location = new System.Drawing.Point(42, 72);
			this.lblNoFactura.Name = "lblNoFactura";
			this.lblNoFactura.Size = new System.Drawing.Size(200, 22);
			this.lblNoFactura.TabIndex = 207;
			this.lblNoFactura.Text = "QWERTYUIOP1234567890";
			this.lblNoFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.label12.ForeColor = System.Drawing.Color.DimGray;
			this.label12.Location = new System.Drawing.Point(42, 50);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(91, 22);
			this.label12.TabIndex = 206;
			this.label12.Text = "No. Factura";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
			this.lblCliente.Location = new System.Drawing.Point(42, 188);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(145, 22);
			this.lblCliente.TabIndex = 205;
			this.lblCliente.Text = "Nombre de Cliente";
			this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.label6.ForeColor = System.Drawing.Color.DimGray;
			this.label6.Location = new System.Drawing.Point(42, 166);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 22);
			this.label6.TabIndex = 204;
			this.label6.Text = "Cliente";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.panel1.Location = new System.Drawing.Point(9, 247);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(482, 1);
			this.panel1.TabIndex = 203;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DimGray;
			this.label3.Location = new System.Drawing.Point(20, 222);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 27);
			this.label3.TabIndex = 202;
			this.label3.Text = "Comisiones";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlComisiones
			// 
			this.pnlComisiones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlComisiones.AutoScroll = true;
			this.pnlComisiones.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pnlComisiones.Location = new System.Drawing.Point(0, 252);
			this.pnlComisiones.Name = "pnlComisiones";
			this.pnlComisiones.Size = new System.Drawing.Size(520, 159);
			this.pnlComisiones.TabIndex = 97;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
			this.panel3.Controls.Add(this.lnkCerrarPagoComisiones);
			this.panel3.Location = new System.Drawing.Point(-1, -1);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(522, 16);
			this.panel3.TabIndex = 217;
			// 
			// lnkCerrarPagoComisiones
			// 
			this.lnkCerrarPagoComisiones.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lnkCerrarPagoComisiones.Image = global::LxCallcenter.Properties.Resources.cancel_16px;
			this.lnkCerrarPagoComisiones.Location = new System.Drawing.Point(497, -3);
			this.lnkCerrarPagoComisiones.Name = "lnkCerrarPagoComisiones";
			this.lnkCerrarPagoComisiones.NoFocusImage = global::LxCallcenter.Properties.Resources.cancel_16px;
			this.lnkCerrarPagoComisiones.Size = new System.Drawing.Size(18, 20);
			this.lnkCerrarPagoComisiones.TabIndex = 201;
			this.metroToolTip1.SetToolTip(this.lnkCerrarPagoComisiones, "Cerrar");
			this.lnkCerrarPagoComisiones.UseCustomBackColor = true;
			this.lnkCerrarPagoComisiones.UseSelectable = true;
			this.lnkCerrarPagoComisiones.Click += new System.EventHandler(this.lnkCerrarPagoComisiones_Click);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
			this.panel5.Controls.Add(this.lblNoOperacion);
			this.panel5.Location = new System.Drawing.Point(-1, 14);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(522, 33);
			this.panel5.TabIndex = 218;
			// 
			// lblNoOperacion
			// 
			this.lblNoOperacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblNoOperacion.AutoSize = true;
			this.lblNoOperacion.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNoOperacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblNoOperacion.Location = new System.Drawing.Point(161, 3);
			this.lblNoOperacion.Name = "lblNoOperacion";
			this.lblNoOperacion.Size = new System.Drawing.Size(199, 27);
			this.lblNoOperacion.TabIndex = 96;
			this.lblNoOperacion.Text = "Detalles de la Factura";
			this.lblNoOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// metroToolTip1
			// 
			this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroToolTip1.StyleManager = null;
			this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 57);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1275, 1);
			this.panel4.TabIndex = 226;
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
			this.panel6.TabIndex = 227;
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
			this.panelControl1.TabIndex = 228;
			// 
			// panel7
			// 
			this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel7.Controls.Add(this.pblImportes);
			this.panel7.Controls.Add(this.grdComisionistas);
			this.panel7.Location = new System.Drawing.Point(2, 2);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(1215, 549);
			this.panel7.TabIndex = 0;
			// 
			// frmComisiones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
			this.ClientSize = new System.Drawing.Size(1268, 644);
			this.Controls.Add(this.pnlPagoComisiones);
			this.Controls.Add(this.btnExportar);
			this.Controls.Add(this.btnMostrarPagadas);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panelControl1);
			this.Name = "frmComisiones";
			this.Text = "frmComisiones";
			this.Load += new System.EventHandler(this.frmComisiones_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdComisionistas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.pblImportes.ResumeLayout(false);
			this.pblImportes.PerformLayout();
			this.pnlPagoComisiones.ResumeLayout(false);
			this.pnlPagoComisiones.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pnlComentario.ResumeLayout(false);
			this.pnlComentario.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl grdComisionistas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NoOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn NoFactura;
        private DevExpress.XtraGrid.Columns.GridColumn FechaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn FechaDeposito;
        private DevExpress.XtraGrid.Columns.GridColumn Importe;
        private DevExpress.XtraGrid.Columns.GridColumn NombreComisionista;
        private DevExpress.XtraGrid.Columns.GridColumn Iva;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private System.Windows.Forms.Panel pblImportes;
        private System.Windows.Forms.Label lblNoSemana;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnMostrarPagadas;
        private System.Windows.Forms.Panel pnlPagoComisiones;
        private System.Windows.Forms.Label lblNoOperacion;
        private System.Windows.Forms.Panel pnlComisiones;
        private MetroFramework.Controls.MetroLink lnkCerrarPagoComisiones;
        private DevExpress.XtraGrid.Columns.GridColumn NombreVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn Ventas;
        private DevExpress.XtraGrid.Columns.GridColumn PorcentajeTotal;
        private MetroFramework.Controls.MetroComboBox cmbxNoSemana;
        private DevExpress.XtraGrid.Columns.GridColumn Pagadas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNoFactura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private MetroFramework.Controls.MetroDateTime dtFechaDeposito;
        private MetroFramework.Controls.MetroDateTime dtFechaFactura;
        private System.Windows.Forms.Button btnFacturaPagada;
        private MetroFramework.Controls.MetroComboBox cmbxTipoFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLink lnkCancelarFactura;
        private System.Windows.Forms.Panel pnlComentario;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroComboBox cmbxEstadoFac;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialLabel label1;
        private System.Windows.Forms.Panel panel4;
        private LollipopTextBox txtComentario;
        private LollipopFlatButton btnCancelarCanFac;
        private LollipopButton btnCancelarFactura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.Columns.GridColumn RFC;
        private DevExpress.XtraGrid.Columns.GridColumn UUID;
        private DevExpress.XtraGrid.Columns.GridColumn Concepto;
        private DevExpress.XtraGrid.Columns.GridColumn Descuento;
        private DevExpress.XtraGrid.Columns.GridColumn Moneda;
        private DevExpress.XtraGrid.Columns.GridColumn Estatus;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroOperacion;
        private LollipopLabel label95;
        private LollipopLabel label2;
        private LollipopLabel label7;
        private LollipopLabel lblTotalIngresos;
        private LollipopLabel lblImporteRepartidoAlimentos;
        private MetroFramework.Controls.MetroComboBox cmbxAño;
        private LollipopLabel lollipopLabel1;
        private LollipopLabel label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.Panel panel7;
	}
}