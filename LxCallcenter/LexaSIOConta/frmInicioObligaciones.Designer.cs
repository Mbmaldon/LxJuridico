namespace LxCallcenter.LexaSIOConta
{
    partial class frmInicioObligaciones
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
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dttmHasta = new MetroFramework.Controls.MetroDateTime();
            this.dttmDesde = new MetroFramework.Controls.MetroDateTime();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBusquedaPerso = new System.Windows.Forms.Button();
            this.lblCampoRequerido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFecha = new System.Windows.Forms.Label();
            this.grdClientes = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rfc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Correo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TelMovil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TelLocal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNoRegitros = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClientes
            // 
            this.pnlClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlClientes.AutoScroll = true;
            this.pnlClientes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlClientes.Location = new System.Drawing.Point(1115, 619);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(17, 17);
            this.pnlClientes.TabIndex = 84;
            this.pnlClientes.Visible = false;
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlBusqueda.Controls.Add(this.label2);
            this.pnlBusqueda.Controls.Add(this.label1);
            this.pnlBusqueda.Controls.Add(this.dttmHasta);
            this.pnlBusqueda.Controls.Add(this.dttmDesde);
            this.pnlBusqueda.Controls.Add(this.btnBuscar);
            this.pnlBusqueda.Controls.Add(this.btnBusquedaPerso);
            this.pnlBusqueda.Location = new System.Drawing.Point(808, 626);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(386, 10);
            this.pnlBusqueda.TabIndex = 85;
            this.pnlBusqueda.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 85;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 86;
            this.label1.Text = "Desde";
            // 
            // dttmHasta
            // 
            this.dttmHasta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dttmHasta.Location = new System.Drawing.Point(21, 94);
            this.dttmHasta.MinimumSize = new System.Drawing.Size(4, 29);
            this.dttmHasta.Name = "dttmHasta";
            this.dttmHasta.Size = new System.Drawing.Size(200, 29);
            this.dttmHasta.Style = MetroFramework.MetroColorStyle.Yellow;
            this.dttmHasta.TabIndex = 84;
            // 
            // dttmDesde
            // 
            this.dttmDesde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dttmDesde.Location = new System.Drawing.Point(21, 38);
            this.dttmDesde.MinimumSize = new System.Drawing.Size(4, 29);
            this.dttmDesde.Name = "dttmDesde";
            this.dttmDesde.Size = new System.Drawing.Size(200, 29);
            this.dttmDesde.Style = MetroFramework.MetroColorStyle.Yellow;
            this.dttmDesde.TabIndex = 83;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(257, 109);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 24);
            this.btnBuscar.TabIndex = 82;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBusquedaPerso
            // 
            this.btnBusquedaPerso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusquedaPerso.BackColor = System.Drawing.Color.Gray;
            this.btnBusquedaPerso.FlatAppearance.BorderSize = 0;
            this.btnBusquedaPerso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.btnBusquedaPerso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.btnBusquedaPerso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaPerso.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaPerso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBusquedaPerso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusquedaPerso.Location = new System.Drawing.Point(231, 159);
            this.btnBusquedaPerso.Name = "btnBusquedaPerso";
            this.btnBusquedaPerso.Size = new System.Drawing.Size(141, 24);
            this.btnBusquedaPerso.TabIndex = 86;
            this.btnBusquedaPerso.Text = "Búsqueda Personalizada";
            this.btnBusquedaPerso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusquedaPerso.UseVisualStyleBackColor = false;
            this.btnBusquedaPerso.Click += new System.EventHandler(this.btnBusquedaPerso_Click);
            // 
            // lblCampoRequerido
            // 
            this.lblCampoRequerido.AutoSize = true;
            this.lblCampoRequerido.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblCampoRequerido.Location = new System.Drawing.Point(1043, 31);
            this.lblCampoRequerido.Name = "lblCampoRequerido";
            this.lblCampoRequerido.Size = new System.Drawing.Size(99, 14);
            this.lblCampoRequerido.TabIndex = 225;
            this.lblCampoRequerido.Text = "*Campo Requerido";
            this.lblCampoRequerido.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.label3.Location = new System.Drawing.Point(27, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 33);
            this.label3.TabIndex = 236;
            this.label3.Text = "Obligaciones Fiscales en Curso | Clientes";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Introduzca texto a buscar...";
            this.txtBuscar.Location = new System.Drawing.Point(939, 64);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(204, 25);
            this.txtBuscar.TabIndex = 237;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoEllipsis = true;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(28, 43);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(549, 22);
            this.lblFecha.TabIndex = 238;
            this.lblFecha.Text = "Clientes que tienen obligaciones fiscales por cumplir en la semana en curso.";
            // 
            // grdClientes
            // 
            this.grdClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdClientes.Location = new System.Drawing.Point(32, 46);
            this.grdClientes.MainView = this.gridView1;
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.Size = new System.Drawing.Size(1111, 527);
            this.grdClientes.TabIndex = 239;
            this.grdClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.Rfc,
            this.Correo,
            this.TelMovil,
            this.TelLocal});
            this.gridView1.GridControl = this.grdClientes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.PaintStyleName = "Web";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
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
            this.NoCliente.Visible = true;
            this.NoCliente.VisibleIndex = 0;
            // 
            // NombreCliente
            // 
            this.NombreCliente.Caption = "Nombre";
            this.NombreCliente.FieldName = "sNombre";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Visible = true;
            this.NombreCliente.VisibleIndex = 1;
            // 
            // Rfc
            // 
            this.Rfc.Caption = "RFC";
            this.Rfc.FieldName = "sRfc";
            this.Rfc.Name = "Rfc";
            this.Rfc.Visible = true;
            this.Rfc.VisibleIndex = 2;
            // 
            // Correo
            // 
            this.Correo.Caption = "Correo Electrónico";
            this.Correo.FieldName = "sCorreo";
            this.Correo.Name = "Correo";
            this.Correo.Visible = true;
            this.Correo.VisibleIndex = 3;
            // 
            // TelMovil
            // 
            this.TelMovil.Caption = "Teléfono Móvil";
            this.TelMovil.FieldName = "sTelMovil";
            this.TelMovil.Name = "TelMovil";
            this.TelMovil.Visible = true;
            this.TelMovil.VisibleIndex = 4;
            // 
            // TelLocal
            // 
            this.TelLocal.Caption = "Teléfono Local";
            this.TelLocal.FieldName = "sTelLocal";
            this.TelLocal.Name = "TelLocal";
            this.TelLocal.Visible = true;
            this.TelLocal.VisibleIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.panel5);
            this.panelControl1.Location = new System.Drawing.Point(31, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1177, 613);
            this.panelControl1.TabIndex = 241;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.lblNoRegitros);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lblFecha);
            this.panel5.Controls.Add(this.lblCampoRequerido);
            this.panel5.Controls.Add(this.materialLabel1);
            this.panel5.Controls.Add(this.txtBuscar);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.grdClientes);
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1173, 609);
            this.panel5.TabIndex = 0;
            // 
            // lblNoRegitros
            // 
            this.lblNoRegitros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNoRegitros.AutoSize = true;
            this.lblNoRegitros.Depth = 0;
            this.lblNoRegitros.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblNoRegitros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoRegitros.Location = new System.Drawing.Point(29, 576);
            this.lblNoRegitros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoRegitros.Name = "lblNoRegitros";
            this.lblNoRegitros.Size = new System.Drawing.Size(142, 20);
            this.lblNoRegitros.TabIndex = 245;
            this.lblNoRegitros.Text = "No. de Registros: --";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(935, 40);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 20);
            this.materialLabel1.TabIndex = 243;
            this.materialLabel1.Text = "Buscar";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(32, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 47);
            this.panel1.TabIndex = 244;
            // 
            // frmInicioObligaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1229, 648);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlClientes);
            this.Name = "frmInicioObligaciones";
            this.Text = "Obligaciones Fiscales";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBusquedaPerso;
        private System.Windows.Forms.Label lblCampoRequerido;
        public System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private System.Windows.Forms.Label lblFecha;
        public DevExpress.XtraGrid.GridControl grdClientes;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn NoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn NombreCliente;
        private DevExpress.XtraGrid.Columns.GridColumn Rfc;
        private DevExpress.XtraGrid.Columns.GridColumn Correo;
        private DevExpress.XtraGrid.Columns.GridColumn TelMovil;
        private DevExpress.XtraGrid.Columns.GridColumn TelLocal;
        public MetroFramework.Controls.MetroDateTime dttmHasta;
        public MetroFramework.Controls.MetroDateTime dttmDesde;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.Panel panel5;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private System.Windows.Forms.Panel panel1;
		private MaterialSkin.Controls.MaterialLabel lblNoRegitros;
	}
}