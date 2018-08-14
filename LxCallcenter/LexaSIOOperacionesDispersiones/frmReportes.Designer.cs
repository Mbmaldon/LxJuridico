namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    partial class frmReportes
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnBuscarIngrCliente = new LollipopButton();
            this.btnExportarIngrCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaHasta = new MetroFramework.Controls.MetroDateTime();
            this.dtFechaDesde = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.grdIngresosCliente = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalImportes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnBuscarComisionesVendedores = new LollipopButton();
            this.dtFechaHastaCom = new MetroFramework.Controls.MetroDateTime();
            this.dtFechaDesdeCom = new MetroFramework.Controls.MetroDateTime();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExportarComisionesVendedores = new System.Windows.Forms.Button();
            this.grdComisionesVendedores = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Comision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstadoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.btnExportarRemanente = new LollipopButton();
            this.btnBuscarRemanente = new LollipopButton();
            this.grdRemanente = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblRemanente = new System.Windows.Forms.Label();
            this.cmbxAnioRemanente = new MetroFramework.Controls.MetroComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblComisionesPagadas = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBonosPagados = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlParcentaje = new System.Windows.Forms.Panel();
            this.btnCancelarPorcentaje = new System.Windows.Forms.Button();
            this.btnGuardarPorcentaje = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPorcentaje = new MetroFramework.Controls.MetroTextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIngresosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdComisionesVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.metroTabPage4.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRemanente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.pnlParcentaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblFecha.Location = new System.Drawing.Point(27, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(365, 22);
            this.lblFecha.TabIndex = 99;
            this.lblFecha.Text = "Genera reportes enfocados en el flujo de efectivo.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.label4.Location = new System.Drawing.Point(26, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 33);
            this.label4.TabIndex = 98;
            this.label4.Text = "Reportes Operaciones";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 68);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1134, 377);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTabControl1.TabIndex = 100;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panel2);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.Controls.Add(this.grdIngresosCliente);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1126, 335);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Ingresos por cliente";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(-75, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1277, 22);
            this.panel2.TabIndex = 227;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.btnBuscarIngrCliente);
            this.metroPanel1.Controls.Add(this.btnExportarIngrCliente);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.dtFechaHasta);
            this.metroPanel1.Controls.Add(this.dtFechaDesde);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.metroToggle1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(22, 6);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1069, 78);
            this.metroPanel1.TabIndex = 206;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnBuscarIngrCliente
            // 
            this.btnBuscarIngrCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarIngrCliente.BGColor = "#001489";
            this.btnBuscarIngrCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarIngrCliente.FontColor = "#ffffff";
            this.btnBuscarIngrCliente.Location = new System.Drawing.Point(469, 25);
            this.btnBuscarIngrCliente.Name = "btnBuscarIngrCliente";
            this.btnBuscarIngrCliente.Size = new System.Drawing.Size(94, 29);
            this.btnBuscarIngrCliente.TabIndex = 218;
            this.btnBuscarIngrCliente.Text = "Buscar";
            this.btnBuscarIngrCliente.Click += new System.EventHandler(this.btnBuscarIngrCliente_Click);
            // 
            // btnExportarIngrCliente
            // 
            this.btnExportarIngrCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarIngrCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(71)))));
            this.btnExportarIngrCliente.FlatAppearance.BorderSize = 0;
            this.btnExportarIngrCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(80)))), ((int)(((byte)(71)))));
            this.btnExportarIngrCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(100)))), ((int)(((byte)(71)))));
            this.btnExportarIngrCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarIngrCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportarIngrCliente.Image = global::LxCallcenter.Properties.Resources.Excel_Export;
            this.btnExportarIngrCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportarIngrCliente.Location = new System.Drawing.Point(975, 25);
            this.btnExportarIngrCliente.Name = "btnExportarIngrCliente";
            this.btnExportarIngrCliente.Size = new System.Drawing.Size(91, 25);
            this.btnExportarIngrCliente.TabIndex = 217;
            this.btnExportarIngrCliente.Text = "Exportar";
            this.btnExportarIngrCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarIngrCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarIngrCliente.UseVisualStyleBackColor = false;
            this.btnExportarIngrCliente.Visible = false;
            this.btnExportarIngrCliente.Click += new System.EventHandler(this.btnExportarIngrCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(11, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 15);
            this.label3.TabIndex = 215;
            this.label3.Text = "Se incluyen facturas por cancelación de servicio";
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.Location = new System.Drawing.Point(251, 25);
            this.dtFechaHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(200, 29);
            this.dtFechaHasta.Style = MetroFramework.MetroColorStyle.Yellow;
            this.dtFechaHasta.TabIndex = 210;
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.Location = new System.Drawing.Point(14, 25);
            this.dtFechaDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(200, 29);
            this.dtFechaDesde.Style = MetroFramework.MetroColorStyle.Yellow;
            this.dtFechaDesde.TabIndex = 210;
            this.dtFechaDesde.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(248, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 208;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 208;
            this.label1.Text = "Desde";
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToggle1.Checked = true;
            this.metroToggle1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle1.Location = new System.Drawing.Point(584, 37);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroToggle1.TabIndex = 216;
            this.metroToggle1.Text = "On";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.Visible = false;
            // 
            // grdIngresosCliente
            // 
            this.grdIngresosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdIngresosCliente.Location = new System.Drawing.Point(22, 110);
            this.grdIngresosCliente.MainView = this.gridView1;
            this.grdIngresosCliente.Name = "grdIngresosCliente";
            this.grdIngresosCliente.Size = new System.Drawing.Size(1069, 212);
            this.grdIngresosCliente.TabIndex = 205;
            this.grdIngresosCliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.IdCliente,
            this.NoCliente,
            this.NombreCliente,
            this.TotalImportes});
            this.gridView1.GridControl = this.grdIngresosCliente;
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
            // IdCliente
            // 
            this.IdCliente.Caption = "Id Cliente";
            this.IdCliente.FieldName = "iIdCliente";
            this.IdCliente.Name = "IdCliente";
            // 
            // NoCliente
            // 
            this.NoCliente.Caption = "No. Cliente";
            this.NoCliente.FieldName = "sCliente";
            this.NoCliente.Name = "NoCliente";
            this.NoCliente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.NoCliente.Visible = true;
            this.NoCliente.VisibleIndex = 0;
            // 
            // NombreCliente
            // 
            this.NombreCliente.Caption = "Nombre";
            this.NombreCliente.FieldName = "sNombre";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.NombreCliente.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "sNombre", "TOTAL = ")});
            this.NombreCliente.Visible = true;
            this.NombreCliente.VisibleIndex = 1;
            // 
            // TotalImportes
            // 
            this.TotalImportes.Caption = "Total Importe";
            this.TotalImportes.DisplayFormat.FormatString = "c2";
            this.TotalImportes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalImportes.FieldName = "dImporte";
            this.TotalImportes.Name = "TotalImportes";
            this.TotalImportes.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dImporte", "{0:c2}")});
            this.TotalImportes.Visible = true;
            this.TotalImportes.VisibleIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.panel1);
            this.metroTabPage2.Controls.Add(this.metroPanel2);
            this.metroTabPage2.Controls.Add(this.grdComisionesVendedores);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1126, 335);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Comisiones";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(-75, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 22);
            this.panel1.TabIndex = 228;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.btnBuscarComisionesVendedores);
            this.metroPanel2.Controls.Add(this.dtFechaHastaCom);
            this.metroPanel2.Controls.Add(this.dtFechaDesdeCom);
            this.metroPanel2.Controls.Add(this.label5);
            this.metroPanel2.Controls.Add(this.label6);
            this.metroPanel2.Controls.Add(this.btnExportarComisionesVendedores);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(22, 6);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1069, 82);
            this.metroPanel2.TabIndex = 208;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnBuscarComisionesVendedores
            // 
            this.btnBuscarComisionesVendedores.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarComisionesVendedores.BGColor = "#001489";
            this.btnBuscarComisionesVendedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarComisionesVendedores.FontColor = "#ffffff";
            this.btnBuscarComisionesVendedores.Location = new System.Drawing.Point(469, 25);
            this.btnBuscarComisionesVendedores.Name = "btnBuscarComisionesVendedores";
            this.btnBuscarComisionesVendedores.Size = new System.Drawing.Size(94, 29);
            this.btnBuscarComisionesVendedores.TabIndex = 222;
            this.btnBuscarComisionesVendedores.Text = "Buscar";
            this.btnBuscarComisionesVendedores.Click += new System.EventHandler(this.btnBuscarComisionesVendedores_Click);
            // 
            // dtFechaHastaCom
            // 
            this.dtFechaHastaCom.Location = new System.Drawing.Point(251, 25);
            this.dtFechaHastaCom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFechaHastaCom.Name = "dtFechaHastaCom";
            this.dtFechaHastaCom.Size = new System.Drawing.Size(200, 29);
            this.dtFechaHastaCom.Style = MetroFramework.MetroColorStyle.Yellow;
            this.dtFechaHastaCom.TabIndex = 220;
            // 
            // dtFechaDesdeCom
            // 
            this.dtFechaDesdeCom.Location = new System.Drawing.Point(14, 25);
            this.dtFechaDesdeCom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFechaDesdeCom.Name = "dtFechaDesdeCom";
            this.dtFechaDesdeCom.Size = new System.Drawing.Size(200, 29);
            this.dtFechaDesdeCom.Style = MetroFramework.MetroColorStyle.Yellow;
            this.dtFechaDesdeCom.TabIndex = 221;
            this.dtFechaDesdeCom.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(248, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 218;
            this.label5.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(11, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 219;
            this.label6.Text = "Desde";
            // 
            // btnExportarComisionesVendedores
            // 
            this.btnExportarComisionesVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarComisionesVendedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(71)))));
            this.btnExportarComisionesVendedores.FlatAppearance.BorderSize = 0;
            this.btnExportarComisionesVendedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(80)))), ((int)(((byte)(71)))));
            this.btnExportarComisionesVendedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(100)))), ((int)(((byte)(71)))));
            this.btnExportarComisionesVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarComisionesVendedores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportarComisionesVendedores.Image = global::LxCallcenter.Properties.Resources.Excel_Export;
            this.btnExportarComisionesVendedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportarComisionesVendedores.Location = new System.Drawing.Point(962, 25);
            this.btnExportarComisionesVendedores.Name = "btnExportarComisionesVendedores";
            this.btnExportarComisionesVendedores.Size = new System.Drawing.Size(91, 25);
            this.btnExportarComisionesVendedores.TabIndex = 217;
            this.btnExportarComisionesVendedores.Text = "Exportar";
            this.btnExportarComisionesVendedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarComisionesVendedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarComisionesVendedores.UseVisualStyleBackColor = false;
            this.btnExportarComisionesVendedores.Visible = false;
            this.btnExportarComisionesVendedores.Click += new System.EventHandler(this.btnExportarComisionesVendedores_Click);
            // 
            // grdComisionesVendedores
            // 
            this.grdComisionesVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdComisionesVendedores.Location = new System.Drawing.Point(22, 110);
            this.grdComisionesVendedores.MainView = this.gridView2;
            this.grdComisionesVendedores.Name = "grdComisionesVendedores";
            this.grdComisionesVendedores.Size = new System.Drawing.Size(1069, 212);
            this.grdComisionesVendedores.TabIndex = 207;
            this.grdComisionesVendedores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView2.Appearance.FixedLine.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView2.Appearance.FixedLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView2.Appearance.FixedLine.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView2.Appearance.FixedLine.Options.UseBorderColor = true;
            this.gridView2.Appearance.FixedLine.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gridView2.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gridView2.Appearance.GroupPanel.BorderColor = System.Drawing.Color.White;
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.gridView2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.gridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdVendedor,
            this.NombreVendedor,
            this.Comision,
            this.EstadoPago});
            this.gridView2.GridControl = this.grdComisionesVendedores;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView2.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView2.OptionsMenu.EnableFooterMenu = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsView.RowAutoHeight = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowIndicator = false;
            this.gridView2.PaintStyleName = "Web";
            // 
            // IdVendedor
            // 
            this.IdVendedor.Caption = "Id Vendedor";
            this.IdVendedor.FieldName = "iIdVendedor";
            this.IdVendedor.Name = "IdVendedor";
            // 
            // NombreVendedor
            // 
            this.NombreVendedor.Caption = "Vendedor";
            this.NombreVendedor.FieldName = "sVendedor";
            this.NombreVendedor.Name = "NombreVendedor";
            this.NombreVendedor.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.NombreVendedor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sVendedor", "TOTAL =")});
            this.NombreVendedor.Visible = true;
            this.NombreVendedor.VisibleIndex = 0;
            // 
            // Comision
            // 
            this.Comision.Caption = "Comisión";
            this.Comision.DisplayFormat.FormatString = "c2";
            this.Comision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Comision.FieldName = "dComision";
            this.Comision.Name = "Comision";
            this.Comision.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dComision", "{0:c2}")});
            this.Comision.Visible = true;
            this.Comision.VisibleIndex = 1;
            // 
            // EstadoPago
            // 
            this.EstadoPago.Caption = "Estado de Pago";
            this.EstadoPago.FieldName = "sEstado";
            this.EstadoPago.Name = "EstadoPago";
            this.EstadoPago.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.EstadoPago.Visible = true;
            this.EstadoPago.VisibleIndex = 2;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.metroPanel4);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1126, 335);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Remanente de Ingresos";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel4.Controls.Add(this.btnExportarRemanente);
            this.metroPanel4.Controls.Add(this.btnBuscarRemanente);
            this.metroPanel4.Controls.Add(this.grdRemanente);
            this.metroPanel4.Controls.Add(this.lblRemanente);
            this.metroPanel4.Controls.Add(this.cmbxAnioRemanente);
            this.metroPanel4.Controls.Add(this.label15);
            this.metroPanel4.Controls.Add(this.lblComisionesPagadas);
            this.metroPanel4.Controls.Add(this.label13);
            this.metroPanel4.Controls.Add(this.label9);
            this.metroPanel4.Controls.Add(this.lblBonosPagados);
            this.metroPanel4.Controls.Add(this.label11);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(22, 20);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(1069, 255);
            this.metroPanel4.TabIndex = 211;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // btnExportarRemanente
            // 
            this.btnExportarRemanente.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarRemanente.BGColor = "#1F7246";
            this.btnExportarRemanente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarRemanente.FontColor = "#ffffff";
            this.btnExportarRemanente.Location = new System.Drawing.Point(107, 127);
            this.btnExportarRemanente.Name = "btnExportarRemanente";
            this.btnExportarRemanente.Size = new System.Drawing.Size(91, 27);
            this.btnExportarRemanente.TabIndex = 226;
            this.btnExportarRemanente.Text = "Exportar";
            this.btnExportarRemanente.Click += new System.EventHandler(this.btnExportarRemanente_Click);
            // 
            // btnBuscarRemanente
            // 
            this.btnBuscarRemanente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarRemanente.BGColor = "#001489";
            this.btnBuscarRemanente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarRemanente.FontColor = "#ffffff";
            this.btnBuscarRemanente.Location = new System.Drawing.Point(107, 94);
            this.btnBuscarRemanente.Name = "btnBuscarRemanente";
            this.btnBuscarRemanente.Size = new System.Drawing.Size(91, 27);
            this.btnBuscarRemanente.TabIndex = 225;
            this.btnBuscarRemanente.Text = "Buscar";
            this.btnBuscarRemanente.Click += new System.EventHandler(this.btnBuscarRemanente_Click);
            // 
            // grdRemanente
            // 
            this.grdRemanente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRemanente.Location = new System.Drawing.Point(468, 127);
            this.grdRemanente.MainView = this.gridView4;
            this.grdRemanente.Name = "grdRemanente";
            this.grdRemanente.Size = new System.Drawing.Size(554, 116);
            this.grdRemanente.TabIndex = 224;
            this.grdRemanente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            this.grdRemanente.Visible = false;
            // 
            // gridView4
            // 
            this.gridView4.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView4.Appearance.FixedLine.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView4.Appearance.FixedLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView4.Appearance.FixedLine.ForeColor = System.Drawing.Color.White;
            this.gridView4.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView4.Appearance.FixedLine.Options.UseBorderColor = true;
            this.gridView4.Appearance.FixedLine.Options.UseForeColor = true;
            this.gridView4.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gridView4.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gridView4.Appearance.GroupPanel.BorderColor = System.Drawing.Color.White;
            this.gridView4.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView4.Appearance.GroupPanel.Options.UseBorderColor = true;
            this.gridView4.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.gridView4.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.gridView4.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.gridView4.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridView4.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.gridView4.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView4.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView4.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView4.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView4.GridControl = this.grdRemanente;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView4.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView4.OptionsMenu.EnableFooterMenu = false;
            this.gridView4.OptionsView.ColumnAutoWidth = false;
            this.gridView4.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView4.OptionsView.RowAutoHeight = true;
            this.gridView4.OptionsView.ShowFooter = true;
            this.gridView4.OptionsView.ShowIndicator = false;
            this.gridView4.PaintStyleName = "Web";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id Op Com";
            this.gridColumn1.FieldName = "iIdOperacionComisionista";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Vendedor";
            this.gridColumn2.FieldName = "sVendedor";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tipo";
            this.gridColumn3.FieldName = "sTipo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "sTipo", "TOTAL =")});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Importe";
            this.gridColumn4.DisplayFormat.FormatString = "c2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "dImporteR";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dImporteR", "{0:c2}")});
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // lblRemanente
            // 
            this.lblRemanente.AutoSize = true;
            this.lblRemanente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemanente.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblRemanente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.lblRemanente.Location = new System.Drawing.Point(265, 149);
            this.lblRemanente.Name = "lblRemanente";
            this.lblRemanente.Size = new System.Drawing.Size(32, 22);
            this.lblRemanente.TabIndex = 217;
            this.lblRemanente.Text = "$ --";
            this.lblRemanente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbxAnioRemanente
            // 
            this.cmbxAnioRemanente.FormattingEnabled = true;
            this.cmbxAnioRemanente.ItemHeight = 23;
            this.cmbxAnioRemanente.Location = new System.Drawing.Point(77, 59);
            this.cmbxAnioRemanente.Name = "cmbxAnioRemanente";
            this.cmbxAnioRemanente.Size = new System.Drawing.Size(121, 29);
            this.cmbxAnioRemanente.TabIndex = 223;
            this.cmbxAnioRemanente.UseSelectable = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(265, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 22);
            this.label15.TabIndex = 216;
            this.label15.Text = "Remanente";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComisionesPagadas
            // 
            this.lblComisionesPagadas.AutoSize = true;
            this.lblComisionesPagadas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComisionesPagadas.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblComisionesPagadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.lblComisionesPagadas.Location = new System.Drawing.Point(464, 81);
            this.lblComisionesPagadas.Name = "lblComisionesPagadas";
            this.lblComisionesPagadas.Size = new System.Drawing.Size(32, 22);
            this.lblComisionesPagadas.TabIndex = 215;
            this.lblComisionesPagadas.Text = "$ --";
            this.lblComisionesPagadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(464, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 22);
            this.label13.TabIndex = 214;
            this.label13.Text = "Comisiones Pagadas";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(76, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 218;
            this.label9.Text = "Año";
            // 
            // lblBonosPagados
            // 
            this.lblBonosPagados.AutoSize = true;
            this.lblBonosPagados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBonosPagados.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblBonosPagados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.lblBonosPagados.Location = new System.Drawing.Point(265, 81);
            this.lblBonosPagados.Name = "lblBonosPagados";
            this.lblBonosPagados.Size = new System.Drawing.Size(32, 22);
            this.lblBonosPagados.TabIndex = 213;
            this.lblBonosPagados.Text = "$ --";
            this.lblBonosPagados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(265, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 22);
            this.label11.TabIndex = 212;
            this.label11.Text = "Bonos Pagados";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivo Excel | *.xlsx";
            // 
            // pnlParcentaje
            // 
            this.pnlParcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlParcentaje.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlParcentaje.Controls.Add(this.btnCancelarPorcentaje);
            this.pnlParcentaje.Controls.Add(this.btnGuardarPorcentaje);
            this.pnlParcentaje.Controls.Add(this.label18);
            this.pnlParcentaje.Controls.Add(this.txtPorcentaje);
            this.pnlParcentaje.Location = new System.Drawing.Point(787, 20);
            this.pnlParcentaje.Name = "pnlParcentaje";
            this.pnlParcentaje.Size = new System.Drawing.Size(355, 62);
            this.pnlParcentaje.TabIndex = 213;
            this.pnlParcentaje.Visible = false;
            // 
            // btnCancelarPorcentaje
            // 
            this.btnCancelarPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarPorcentaje.BackColor = System.Drawing.Color.Gray;
            this.btnCancelarPorcentaje.FlatAppearance.BorderSize = 0;
            this.btnCancelarPorcentaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnCancelarPorcentaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.btnCancelarPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPorcentaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarPorcentaje.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarPorcentaje.Location = new System.Drawing.Point(270, 26);
            this.btnCancelarPorcentaje.Name = "btnCancelarPorcentaje";
            this.btnCancelarPorcentaje.Size = new System.Drawing.Size(71, 21);
            this.btnCancelarPorcentaje.TabIndex = 212;
            this.btnCancelarPorcentaje.Text = "Cancelar";
            this.btnCancelarPorcentaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarPorcentaje.UseVisualStyleBackColor = false;
            this.btnCancelarPorcentaje.Click += new System.EventHandler(this.btnCancelarPorcentaje_Click);
            // 
            // btnGuardarPorcentaje
            // 
            this.btnGuardarPorcentaje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.btnGuardarPorcentaje.FlatAppearance.BorderSize = 0;
            this.btnGuardarPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPorcentaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarPorcentaje.Location = new System.Drawing.Point(167, 26);
            this.btnGuardarPorcentaje.Name = "btnGuardarPorcentaje";
            this.btnGuardarPorcentaje.Size = new System.Drawing.Size(99, 21);
            this.btnGuardarPorcentaje.TabIndex = 211;
            this.btnGuardarPorcentaje.Text = "Guardar";
            this.btnGuardarPorcentaje.UseVisualStyleBackColor = false;
            this.btnGuardarPorcentaje.Click += new System.EventHandler(this.btnGuardarPorcentaje_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(15, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 19);
            this.label18.TabIndex = 210;
            this.label18.Text = "Porcentaje";
            // 
            // txtPorcentaje
            // 
            // 
            // 
            // 
            this.txtPorcentaje.CustomButton.Image = null;
            this.txtPorcentaje.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtPorcentaje.CustomButton.Name = "";
            this.txtPorcentaje.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPorcentaje.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPorcentaje.CustomButton.TabIndex = 1;
            this.txtPorcentaje.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPorcentaje.CustomButton.UseSelectable = true;
            this.txtPorcentaje.CustomButton.Visible = false;
            this.txtPorcentaje.Lines = new string[0];
            this.txtPorcentaje.Location = new System.Drawing.Point(18, 25);
            this.txtPorcentaje.MaxLength = 32767;
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.PasswordChar = '\0';
            this.txtPorcentaje.PromptText = "%";
            this.txtPorcentaje.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPorcentaje.SelectedText = "";
            this.txtPorcentaje.SelectionLength = 0;
            this.txtPorcentaje.SelectionStart = 0;
            this.txtPorcentaje.ShortcutsEnabled = true;
            this.txtPorcentaje.Size = new System.Drawing.Size(142, 23);
            this.txtPorcentaje.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtPorcentaje.TabIndex = 209;
            this.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcentaje.UseSelectable = true;
            this.txtPorcentaje.WaterMark = "%";
            this.txtPorcentaje.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPorcentaje.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentaje_KeyPress);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1158, 477);
            this.Controls.Add(this.pnlParcentaje);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIngresosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdComisionesVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.metroTabPage4.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRemanente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.pnlParcentaje.ResumeLayout(false);
            this.pnlParcentaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private DevExpress.XtraGrid.GridControl grdIngresosCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroDateTime dtFechaHasta;
        private MetroFramework.Controls.MetroDateTime dtFechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private DevExpress.XtraGrid.Columns.GridColumn IdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn NoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn NombreCliente;
        private DevExpress.XtraGrid.Columns.GridColumn TotalImportes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnExportarIngrCliente;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Button btnExportarComisionesVendedores;
        private DevExpress.XtraGrid.GridControl grdComisionesVendedores;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn IdVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn NombreVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn Comision;
        private DevExpress.XtraGrid.Columns.GridColumn EstadoPago;
        private MetroFramework.Controls.MetroDateTime dtFechaHastaCom;
        private MetroFramework.Controls.MetroDateTime dtFechaDesdeCom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroComboBox cmbxAnioRemanente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBonosPagados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRemanente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblComisionesPagadas;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraGrid.GridControl grdRemanente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Panel pnlParcentaje;
        private System.Windows.Forms.Button btnCancelarPorcentaje;
        private System.Windows.Forms.Button btnGuardarPorcentaje;
        private System.Windows.Forms.Label label18;
        private MetroFramework.Controls.MetroTextBox txtPorcentaje;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private LollipopButton btnBuscarIngrCliente;
        private System.Windows.Forms.Panel panel2;
        private LollipopButton btnBuscarComisionesVendedores;
        private System.Windows.Forms.Panel panel1;
        private LollipopButton btnBuscarRemanente;
        private LollipopButton btnExportarRemanente;
    }
}