namespace LxCallcenter.LexaSIOConta
{
    partial class frmInicioContadores
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
			this.label30 = new System.Windows.Forms.Label();
			this.lblCampoRequerido = new System.Windows.Forms.Label();
			this.btnBusquedaPerso = new System.Windows.Forms.Button();
			this.pnlBusqueda = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dttmHasta = new MetroFramework.Controls.MetroDateTime();
			this.dttmDesde = new MetroFramework.Controls.MetroDateTime();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtContador = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.grdContadores = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.IdEquipoContador = new DevExpress.XtraGrid.Columns.GridColumn();
			this.EquipoContador = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlBusqueda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdContadores)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblFecha
			// 
			this.lblFecha.AutoEllipsis = true;
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.Location = new System.Drawing.Point(28, 37);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(663, 22);
			this.lblFecha.TabIndex = 85;
			this.lblFecha.Text = "Contadores con clientes que tienen obligaciones fiscales por cumplir en la semana" +
    " en curso.";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label30.Location = new System.Drawing.Point(28, 10);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(115, 19);
			this.label30.TabIndex = 230;
			this.label30.Text = "Buscar contador";
			// 
			// lblCampoRequerido
			// 
			this.lblCampoRequerido.AutoSize = true;
			this.lblCampoRequerido.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCampoRequerido.ForeColor = System.Drawing.Color.Red;
			this.lblCampoRequerido.Location = new System.Drawing.Point(141, 13);
			this.lblCampoRequerido.Name = "lblCampoRequerido";
			this.lblCampoRequerido.Size = new System.Drawing.Size(99, 14);
			this.lblCampoRequerido.TabIndex = 232;
			this.lblCampoRequerido.Text = "*Campo Requerido";
			this.lblCampoRequerido.Visible = false;
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
			this.btnBusquedaPerso.Location = new System.Drawing.Point(231, 14);
			this.btnBusquedaPerso.Name = "btnBusquedaPerso";
			this.btnBusquedaPerso.Size = new System.Drawing.Size(141, 24);
			this.btnBusquedaPerso.TabIndex = 234;
			this.btnBusquedaPerso.Text = "Búsqueda Personalizada";
			this.btnBusquedaPerso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBusquedaPerso.UseVisualStyleBackColor = false;
			this.btnBusquedaPerso.Visible = false;
			this.btnBusquedaPerso.Click += new System.EventHandler(this.btnBusquedaPerso_Click);
			// 
			// pnlBusqueda
			// 
			this.pnlBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
			this.pnlBusqueda.Controls.Add(this.label2);
			this.pnlBusqueda.Controls.Add(this.label1);
			this.pnlBusqueda.Controls.Add(this.btnBusquedaPerso);
			this.pnlBusqueda.Controls.Add(this.dttmHasta);
			this.pnlBusqueda.Controls.Add(this.dttmDesde);
			this.pnlBusqueda.Controls.Add(this.btnBuscar);
			this.pnlBusqueda.Location = new System.Drawing.Point(823, 624);
			this.pnlBusqueda.Name = "pnlBusqueda";
			this.pnlBusqueda.Size = new System.Drawing.Size(386, 12);
			this.pnlBusqueda.TabIndex = 233;
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri Light", 20F);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
			this.label3.Location = new System.Drawing.Point(27, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(486, 33);
			this.label3.TabIndex = 235;
			this.label3.Text = "Obligaciones Fiscales en Curso | Contadores";
			// 
			// txtContador
			// 
			this.txtContador.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtContador.Depth = 0;
			this.txtContador.Hint = "Nombre";
			this.txtContador.Location = new System.Drawing.Point(33, 30);
			this.txtContador.MaxLength = 32767;
			this.txtContador.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtContador.Name = "txtContador";
			this.txtContador.PasswordChar = '\0';
			this.txtContador.ReadOnly = false;
			this.txtContador.SelectedText = "";
			this.txtContador.SelectionLength = 0;
			this.txtContador.SelectionStart = 0;
			this.txtContador.Size = new System.Drawing.Size(233, 23);
			this.txtContador.TabIndex = 236;
			this.txtContador.TabStop = false;
			this.txtContador.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtContador.UseSystemPasswordChar = false;
			this.txtContador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContador_KeyPress);
			this.txtContador.TextChanged += new System.EventHandler(this.txtContador_TextChanged);
			// 
			// grdContadores
			// 
			this.grdContadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdContadores.Location = new System.Drawing.Point(32, 59);
			this.grdContadores.MainView = this.gridView1;
			this.grdContadores.Name = "grdContadores";
			this.grdContadores.Size = new System.Drawing.Size(1111, 483);
			this.grdContadores.TabIndex = 237;
			this.grdContadores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.IdEquipoContador,
            this.EquipoContador,
            this.Estado,
            this.Sucursal});
			this.gridView1.GridControl = this.grdContadores;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
			this.gridView1.OptionsBehavior.Editable = false;
			this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
			this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
			this.gridView1.OptionsMenu.EnableFooterMenu = false;
			this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
			this.gridView1.OptionsView.RowAutoHeight = true;
			this.gridView1.OptionsView.ShowFooter = true;
			this.gridView1.OptionsView.ShowIndicator = false;
			this.gridView1.PaintStyleName = "Web";
			// 
			// IdEquipoContador
			// 
			this.IdEquipoContador.Caption = "Id Equipo Contador";
			this.IdEquipoContador.FieldName = "iIdEquipoContador";
			this.IdEquipoContador.Name = "IdEquipoContador";
			// 
			// EquipoContador
			// 
			this.EquipoContador.Caption = "Equipo";
			this.EquipoContador.FieldName = "sEquipoContador";
			this.EquipoContador.Name = "EquipoContador";
			this.EquipoContador.Visible = true;
			this.EquipoContador.VisibleIndex = 0;
			// 
			// Estado
			// 
			this.Estado.Caption = "Estado";
			this.Estado.FieldName = "sEstado";
			this.Estado.Name = "Estado";
			this.Estado.Visible = true;
			this.Estado.VisibleIndex = 1;
			// 
			// Sucursal
			// 
			this.Sucursal.Caption = "Sucursal";
			this.Sucursal.FieldName = "sSucursal";
			this.Sucursal.Name = "Sucursal";
			this.Sucursal.Visible = true;
			this.Sucursal.VisibleIndex = 2;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.lblFecha);
			this.panel3.Location = new System.Drawing.Point(-2, -1);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1234, 65);
			this.panel3.TabIndex = 238;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 64);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1234, 1);
			this.panel4.TabIndex = 236;
			// 
			// panelControl1
			// 
			this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelControl1.Controls.Add(this.panel1);
			this.panelControl1.Location = new System.Drawing.Point(31, 81);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1177, 555);
			this.panelControl1.TabIndex = 239;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel1.Controls.Add(this.label30);
			this.panel1.Controls.Add(this.grdContadores);
			this.panel1.Controls.Add(this.lblCampoRequerido);
			this.panel1.Controls.Add(this.txtContador);
			this.panel1.Location = new System.Drawing.Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1173, 551);
			this.panel1.TabIndex = 0;
			// 
			// frmInicioContadores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
			this.ClientSize = new System.Drawing.Size(1229, 648);
			this.Controls.Add(this.panelControl1);
			this.Controls.Add(this.pnlBusqueda);
			this.Controls.Add(this.panel3);
			this.Name = "frmInicioContadores";
			this.Text = "frmInicioContadores";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContador_KeyPress);
			this.pnlBusqueda.ResumeLayout(false);
			this.pnlBusqueda.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdContadores)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblCampoRequerido;
        private System.Windows.Forms.Button btnBusquedaPerso;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime dttmHasta;
        private MetroFramework.Controls.MetroDateTime dttmDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContador;
        private DevExpress.XtraGrid.Columns.GridColumn IdEquipoContador;
        private DevExpress.XtraGrid.Columns.GridColumn EquipoContador;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        public DevExpress.XtraGrid.GridControl grdContadores;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.Panel panel1;
	}
}