namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    partial class frmCatalogoVendedores
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
            this.grdCatalogoVendedores = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Porcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Importe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Operaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbVendedor = new System.Windows.Forms.GroupBox();
            this.lblComisionista = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblMovil = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblAMaterno = new System.Windows.Forms.Label();
            this.lblAPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRfc = new System.Windows.Forms.Label();
            this.lblNuVendedor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkCancelarGenerarCostanciaAlimentos = new MetroFramework.Controls.MetroLink();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblCorreo0 = new System.Windows.Forms.Label();
            this.lblMovil0 = new System.Windows.Forms.Label();
            this.lblExtension0 = new System.Windows.Forms.Label();
            this.lblTelefono0 = new System.Windows.Forms.Label();
            this.lblCodigoP = new System.Windows.Forms.Label();
            this.lblEstado0 = new System.Windows.Forms.Label();
            this.lblMunicipio0 = new System.Windows.Forms.Label();
            this.lblDireccion0 = new System.Windows.Forms.Label();
            this.lblRfc0 = new System.Windows.Forms.Label();
            this.lblAMaterno0 = new System.Windows.Forms.Label();
            this.lblAPaterno0 = new System.Windows.Forms.Label();
            this.lblNombre0 = new System.Windows.Forms.Label();
            this.ckbActivo = new System.Windows.Forms.CheckBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCatalogoVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(190, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(117, 27);
            this.lblFecha.TabIndex = 97;
            this.lblFecha.Text = "Vendedores";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 33);
            this.label4.TabIndex = 96;
            this.label4.Text = "Catálogo de Vendedores";
            // 
            // grdCatalogoVendedores
            // 
            this.grdCatalogoVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCatalogoVendedores.Location = new System.Drawing.Point(33, 132);
            this.grdCatalogoVendedores.MainView = this.gridView1;
            this.grdCatalogoVendedores.Name = "grdCatalogoVendedores";
            this.grdCatalogoVendedores.Size = new System.Drawing.Size(1107, 136);
            this.grdCatalogoVendedores.TabIndex = 99;
            this.grdCatalogoVendedores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdVendedor,
            this.NombreVendedor,
            this.Nivel,
            this.Porcentaje,
            this.Importe,
            this.Operaciones,
            this.IdCliente});
            this.gridView1.GridControl = this.grdCatalogoVendedores;
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
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // IdVendedor
            // 
            this.IdVendedor.Caption = "Clave";
            this.IdVendedor.FieldName = "sVendedor";
            this.IdVendedor.Name = "IdVendedor";
            this.IdVendedor.Visible = true;
            this.IdVendedor.VisibleIndex = 1;
            // 
            // NombreVendedor
            // 
            this.NombreVendedor.Caption = "Nombre del Vendedor";
            this.NombreVendedor.FieldName = "sNombre";
            this.NombreVendedor.Name = "NombreVendedor";
            this.NombreVendedor.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.NombreVendedor.Visible = true;
            this.NombreVendedor.VisibleIndex = 2;
            // 
            // Nivel
            // 
            this.Nivel.Caption = "Nivel";
            this.Nivel.FieldName = "sNivel";
            this.Nivel.Name = "Nivel";
            this.Nivel.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "sNivel", "Total")});
            this.Nivel.Visible = true;
            this.Nivel.VisibleIndex = 3;
            // 
            // Porcentaje
            // 
            this.Porcentaje.Caption = "Porcentaje";
            this.Porcentaje.DisplayFormat.FormatString = "p";
            this.Porcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Porcentaje.FieldName = "dPorcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.Visible = true;
            this.Porcentaje.VisibleIndex = 5;
            // 
            // Importe
            // 
            this.Importe.Caption = "Importe";
            this.Importe.DisplayFormat.FormatString = "c";
            this.Importe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Importe.FieldName = "dImporte";
            this.Importe.Name = "Importe";
            this.Importe.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dImporte", "{0:c2}")});
            this.Importe.Visible = true;
            this.Importe.VisibleIndex = 4;
            // 
            // Operaciones
            // 
            this.Operaciones.Caption = "Operación";
            this.Operaciones.FieldName = "sNoOperacion";
            this.Operaciones.Name = "Operaciones";
            this.Operaciones.Visible = true;
            this.Operaciones.VisibleIndex = 6;
            // 
            // IdCliente
            // 
            this.IdCliente.Caption = "ID";
            this.IdCliente.FieldName = "iIdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Visible = true;
            this.IdCliente.VisibleIndex = 0;
            // 
            // gbVendedor
            // 
            this.gbVendedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbVendedor.Controls.Add(this.lblComisionista);
            this.gbVendedor.Controls.Add(this.lblNivel);
            this.gbVendedor.Controls.Add(this.lblCorreo);
            this.gbVendedor.Controls.Add(this.lblMovil);
            this.gbVendedor.Controls.Add(this.lblExtension);
            this.gbVendedor.Controls.Add(this.lblTelefono);
            this.gbVendedor.Controls.Add(this.lblCodigoPostal);
            this.gbVendedor.Controls.Add(this.lblEstado);
            this.gbVendedor.Controls.Add(this.lblMunicipio);
            this.gbVendedor.Controls.Add(this.lblDireccion);
            this.gbVendedor.Controls.Add(this.lblAMaterno);
            this.gbVendedor.Controls.Add(this.lblAPaterno);
            this.gbVendedor.Controls.Add(this.lblNombre);
            this.gbVendedor.Controls.Add(this.lblRfc);
            this.gbVendedor.Controls.Add(this.lblNuVendedor);
            this.gbVendedor.Controls.Add(this.label2);
            this.gbVendedor.Controls.Add(this.lnkCancelarGenerarCostanciaAlimentos);
            this.gbVendedor.Controls.Add(this.lblContador);
            this.gbVendedor.Controls.Add(this.lblServicio);
            this.gbVendedor.Controls.Add(this.lblCorreo0);
            this.gbVendedor.Controls.Add(this.lblMovil0);
            this.gbVendedor.Controls.Add(this.lblExtension0);
            this.gbVendedor.Controls.Add(this.lblTelefono0);
            this.gbVendedor.Controls.Add(this.lblCodigoP);
            this.gbVendedor.Controls.Add(this.lblEstado0);
            this.gbVendedor.Controls.Add(this.lblMunicipio0);
            this.gbVendedor.Controls.Add(this.lblDireccion0);
            this.gbVendedor.Controls.Add(this.lblRfc0);
            this.gbVendedor.Controls.Add(this.lblAMaterno0);
            this.gbVendedor.Controls.Add(this.lblAPaterno0);
            this.gbVendedor.Controls.Add(this.lblNombre0);
            this.gbVendedor.Controls.Add(this.ckbActivo);
            this.gbVendedor.Controls.Add(this.lblActivo);
            this.gbVendedor.Controls.Add(this.label1);
            this.gbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVendedor.Location = new System.Drawing.Point(154, 124);
            this.gbVendedor.Name = "gbVendedor";
            this.gbVendedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbVendedor.Size = new System.Drawing.Size(863, 346);
            this.gbVendedor.TabIndex = 100;
            this.gbVendedor.TabStop = false;
            this.gbVendedor.Visible = false;
            // 
            // lblComisionista
            // 
            this.lblComisionista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComisionista.AutoSize = true;
            this.lblComisionista.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComisionista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblComisionista.Location = new System.Drawing.Point(413, 286);
            this.lblComisionista.Name = "lblComisionista";
            this.lblComisionista.Size = new System.Drawing.Size(37, 15);
            this.lblComisionista.TabIndex = 214;
            this.lblComisionista.Text = "------";
            // 
            // lblNivel
            // 
            this.lblNivel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblNivel.Location = new System.Drawing.Point(123, 285);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(37, 15);
            this.lblNivel.TabIndex = 213;
            this.lblNivel.Text = "------";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblCorreo.Location = new System.Drawing.Point(123, 255);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(37, 15);
            this.lblCorreo.TabIndex = 212;
            this.lblCorreo.Text = "------";
            // 
            // lblMovil
            // 
            this.lblMovil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMovil.AutoSize = true;
            this.lblMovil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblMovil.Location = new System.Drawing.Point(683, 224);
            this.lblMovil.Name = "lblMovil";
            this.lblMovil.Size = new System.Drawing.Size(37, 15);
            this.lblMovil.TabIndex = 211;
            this.lblMovil.Text = "------";
            // 
            // lblExtension
            // 
            this.lblExtension.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblExtension.AutoSize = true;
            this.lblExtension.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblExtension.Location = new System.Drawing.Point(413, 223);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(37, 15);
            this.lblExtension.TabIndex = 210;
            this.lblExtension.Text = "------";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblTelefono.Location = new System.Drawing.Point(123, 223);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(37, 15);
            this.lblTelefono.TabIndex = 209;
            this.lblTelefono.Text = "------";
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblCodigoPostal.Location = new System.Drawing.Point(683, 189);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(37, 15);
            this.lblCodigoPostal.TabIndex = 208;
            this.lblCodigoPostal.Text = "------";
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblEstado.Location = new System.Drawing.Point(413, 191);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(37, 15);
            this.lblEstado.TabIndex = 207;
            this.lblEstado.Text = "------";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblMunicipio.Location = new System.Drawing.Point(123, 191);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(37, 15);
            this.lblMunicipio.TabIndex = 206;
            this.lblMunicipio.Text = "------";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblDireccion.Location = new System.Drawing.Point(123, 156);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(37, 15);
            this.lblDireccion.TabIndex = 205;
            this.lblDireccion.Text = "------";
            // 
            // lblAMaterno
            // 
            this.lblAMaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAMaterno.AutoSize = true;
            this.lblAMaterno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblAMaterno.Location = new System.Drawing.Point(686, 123);
            this.lblAMaterno.Name = "lblAMaterno";
            this.lblAMaterno.Size = new System.Drawing.Size(37, 15);
            this.lblAMaterno.TabIndex = 204;
            this.lblAMaterno.Text = "------";
            // 
            // lblAPaterno
            // 
            this.lblAPaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAPaterno.AutoSize = true;
            this.lblAPaterno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblAPaterno.Location = new System.Drawing.Point(413, 125);
            this.lblAPaterno.Name = "lblAPaterno";
            this.lblAPaterno.Size = new System.Drawing.Size(37, 15);
            this.lblAPaterno.TabIndex = 204;
            this.lblAPaterno.Text = "------";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblNombre.Location = new System.Drawing.Point(123, 125);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(37, 15);
            this.lblNombre.TabIndex = 204;
            this.lblNombre.Text = "------";
            // 
            // lblRfc
            // 
            this.lblRfc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRfc.AutoSize = true;
            this.lblRfc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRfc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblRfc.Location = new System.Drawing.Point(413, 90);
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(37, 15);
            this.lblRfc.TabIndex = 203;
            this.lblRfc.Text = "------";
            // 
            // lblNuVendedor
            // 
            this.lblNuVendedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNuVendedor.AutoSize = true;
            this.lblNuVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblNuVendedor.Location = new System.Drawing.Point(123, 91);
            this.lblNuVendedor.Name = "lblNuVendedor";
            this.lblNuVendedor.Size = new System.Drawing.Size(37, 15);
            this.lblNuVendedor.TabIndex = 202;
            this.lblNuVendedor.Text = "------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 27);
            this.label2.TabIndex = 201;
            this.label2.Text = "Información del Vendedor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkCancelarGenerarCostanciaAlimentos
            // 
            this.lnkCancelarGenerarCostanciaAlimentos.Image = global::LxCallcenter.Properties.Resources.Close_WF;
            this.lnkCancelarGenerarCostanciaAlimentos.Location = new System.Drawing.Point(830, 13);
            this.lnkCancelarGenerarCostanciaAlimentos.Name = "lnkCancelarGenerarCostanciaAlimentos";
            this.lnkCancelarGenerarCostanciaAlimentos.Size = new System.Drawing.Size(29, 23);
            this.lnkCancelarGenerarCostanciaAlimentos.TabIndex = 200;
            this.lnkCancelarGenerarCostanciaAlimentos.UseSelectable = true;
            this.lnkCancelarGenerarCostanciaAlimentos.Click += new System.EventHandler(this.lnkCancelarGenerarCostanciaAlimentos_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContador.Location = new System.Drawing.Point(76, 287);
            this.lblContador.Margin = new System.Windows.Forms.Padding(10);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(34, 13);
            this.lblContador.TabIndex = 36;
            this.lblContador.Text = "Nivel:";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServicio.Location = new System.Drawing.Point(332, 287);
            this.lblServicio.Margin = new System.Windows.Forms.Padding(10);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(68, 13);
            this.lblServicio.TabIndex = 28;
            this.lblServicio.Text = "Comisionista:";
            // 
            // lblCorreo0
            // 
            this.lblCorreo0.AutoSize = true;
            this.lblCorreo0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCorreo0.Location = new System.Drawing.Point(13, 257);
            this.lblCorreo0.Margin = new System.Windows.Forms.Padding(10);
            this.lblCorreo0.Name = "lblCorreo0";
            this.lblCorreo0.Size = new System.Drawing.Size(97, 13);
            this.lblCorreo0.TabIndex = 26;
            this.lblCorreo0.Text = "Correo Electrónico:";
            // 
            // lblMovil0
            // 
            this.lblMovil0.AutoSize = true;
            this.lblMovil0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovil0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMovil0.Location = new System.Drawing.Point(641, 224);
            this.lblMovil0.Margin = new System.Windows.Forms.Padding(10);
            this.lblMovil0.Name = "lblMovil0";
            this.lblMovil0.Size = new System.Drawing.Size(35, 13);
            this.lblMovil0.TabIndex = 24;
            this.lblMovil0.Text = "Movil:";
            // 
            // lblExtension0
            // 
            this.lblExtension0.AutoSize = true;
            this.lblExtension0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtension0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExtension0.Location = new System.Drawing.Point(344, 224);
            this.lblExtension0.Margin = new System.Windows.Forms.Padding(10);
            this.lblExtension0.Name = "lblExtension0";
            this.lblExtension0.Size = new System.Drawing.Size(56, 13);
            this.lblExtension0.TabIndex = 22;
            this.lblExtension0.Text = "Extensión:";
            // 
            // lblTelefono0
            // 
            this.lblTelefono0.AutoSize = true;
            this.lblTelefono0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTelefono0.Location = new System.Drawing.Point(58, 224);
            this.lblTelefono0.Margin = new System.Windows.Forms.Padding(10);
            this.lblTelefono0.Name = "lblTelefono0";
            this.lblTelefono0.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono0.TabIndex = 20;
            this.lblTelefono0.Text = "Telefono:";
            // 
            // lblCodigoP
            // 
            this.lblCodigoP.AutoSize = true;
            this.lblCodigoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodigoP.Location = new System.Drawing.Point(598, 191);
            this.lblCodigoP.Margin = new System.Windows.Forms.Padding(10);
            this.lblCodigoP.Name = "lblCodigoP";
            this.lblCodigoP.Size = new System.Drawing.Size(75, 13);
            this.lblCodigoP.TabIndex = 18;
            this.lblCodigoP.Text = "Codigo Postal:";
            // 
            // lblEstado0
            // 
            this.lblEstado0.AutoSize = true;
            this.lblEstado0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEstado0.Location = new System.Drawing.Point(357, 191);
            this.lblEstado0.Margin = new System.Windows.Forms.Padding(10);
            this.lblEstado0.Name = "lblEstado0";
            this.lblEstado0.Size = new System.Drawing.Size(43, 13);
            this.lblEstado0.TabIndex = 16;
            this.lblEstado0.Text = "Estado:";
            // 
            // lblMunicipio0
            // 
            this.lblMunicipio0.AutoSize = true;
            this.lblMunicipio0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMunicipio0.Location = new System.Drawing.Point(55, 191);
            this.lblMunicipio0.Margin = new System.Windows.Forms.Padding(10);
            this.lblMunicipio0.Name = "lblMunicipio0";
            this.lblMunicipio0.Size = new System.Drawing.Size(55, 13);
            this.lblMunicipio0.TabIndex = 14;
            this.lblMunicipio0.Text = "Municipio:";
            // 
            // lblDireccion0
            // 
            this.lblDireccion0.AutoSize = true;
            this.lblDireccion0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDireccion0.Location = new System.Drawing.Point(55, 158);
            this.lblDireccion0.Margin = new System.Windows.Forms.Padding(10);
            this.lblDireccion0.Name = "lblDireccion0";
            this.lblDireccion0.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion0.TabIndex = 12;
            this.lblDireccion0.Text = "Dirección:";
            // 
            // lblRfc0
            // 
            this.lblRfc0.AutoSize = true;
            this.lblRfc0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRfc0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRfc0.Location = new System.Drawing.Point(369, 92);
            this.lblRfc0.Margin = new System.Windows.Forms.Padding(10);
            this.lblRfc0.Name = "lblRfc0";
            this.lblRfc0.Size = new System.Drawing.Size(31, 13);
            this.lblRfc0.TabIndex = 10;
            this.lblRfc0.Text = "RFC:";
            // 
            // lblAMaterno0
            // 
            this.lblAMaterno0.AutoSize = true;
            this.lblAMaterno0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMaterno0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAMaterno0.Location = new System.Drawing.Point(584, 125);
            this.lblAMaterno0.Margin = new System.Windows.Forms.Padding(10);
            this.lblAMaterno0.Name = "lblAMaterno0";
            this.lblAMaterno0.Size = new System.Drawing.Size(89, 13);
            this.lblAMaterno0.TabIndex = 8;
            this.lblAMaterno0.Text = "Apellido Materno:";
            // 
            // lblAPaterno0
            // 
            this.lblAPaterno0.AutoSize = true;
            this.lblAPaterno0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPaterno0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAPaterno0.Location = new System.Drawing.Point(313, 125);
            this.lblAPaterno0.Margin = new System.Windows.Forms.Padding(10);
            this.lblAPaterno0.Name = "lblAPaterno0";
            this.lblAPaterno0.Size = new System.Drawing.Size(87, 13);
            this.lblAPaterno0.TabIndex = 6;
            this.lblAPaterno0.Text = "Apellido Paterno:";
            // 
            // lblNombre0
            // 
            this.lblNombre0.AutoSize = true;
            this.lblNombre0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre0.Location = new System.Drawing.Point(63, 125);
            this.lblNombre0.Margin = new System.Windows.Forms.Padding(10);
            this.lblNombre0.Name = "lblNombre0";
            this.lblNombre0.Size = new System.Drawing.Size(47, 13);
            this.lblNombre0.TabIndex = 4;
            this.lblNombre0.Text = "Nombre:";
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Enabled = false;
            this.ckbActivo.Location = new System.Drawing.Point(686, 92);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Size = new System.Drawing.Size(15, 14);
            this.ckbActivo.TabIndex = 3;
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblActivo.Location = new System.Drawing.Point(633, 92);
            this.lblActivo.Margin = new System.Windows.Forms.Padding(10);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(40, 13);
            this.lblActivo.TabIndex = 2;
            this.lblActivo.Text = "Activo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Vendedor:";
            // 
            // frmCatalogoVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1170, 438);
            this.Controls.Add(this.gbVendedor);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdCatalogoVendedores);
            this.Name = "frmCatalogoVendedores";
            this.Text = "frmCatalogoVendedores";
            ((System.ComponentModel.ISupportInitialize)(this.grdCatalogoVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbVendedor.ResumeLayout(false);
            this.gbVendedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl grdCatalogoVendedores;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn NombreVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn Nivel;
        private DevExpress.XtraGrid.Columns.GridColumn Porcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn Importe;
        private DevExpress.XtraGrid.Columns.GridColumn Operaciones;
        private System.Windows.Forms.GroupBox gbVendedor;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblCorreo0;
        private System.Windows.Forms.Label lblMovil0;
        private System.Windows.Forms.Label lblExtension0;
        private System.Windows.Forms.Label lblTelefono0;
        private System.Windows.Forms.Label lblCodigoP;
        private System.Windows.Forms.Label lblEstado0;
        private System.Windows.Forms.Label lblMunicipio0;
        private System.Windows.Forms.Label lblDireccion0;
        private System.Windows.Forms.Label lblRfc0;
        private System.Windows.Forms.Label lblAMaterno0;
        private System.Windows.Forms.Label lblAPaterno0;
        private System.Windows.Forms.Label lblNombre0;
        private System.Windows.Forms.CheckBox ckbActivo;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLink lnkCancelarGenerarCostanciaAlimentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNuVendedor;
        private System.Windows.Forms.Label lblRfc;
        private System.Windows.Forms.Label lblAMaterno;
        private System.Windows.Forms.Label lblAPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblMovil;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblComisionista;
        private System.Windows.Forms.Label lblNivel;
        private DevExpress.XtraGrid.Columns.GridColumn IdCliente;
    }
}