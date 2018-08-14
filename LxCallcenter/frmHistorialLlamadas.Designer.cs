namespace LxCallcenter
{
    partial class frmHistorialLlamadas
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
            this.grdLlamadas = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdLlamada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Persona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaLlamada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoraLlamada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Comentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblNoRegitros = new MaterialSkin.Controls.MaterialLabel();
            this.btnExportar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.sfdExportarLlamadas = new System.Windows.Forms.SaveFileDialog();
            this.lnkCerrar = new MetroFramework.Controls.MetroLink();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.grdLlamadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLlamadas
            // 
            this.grdLlamadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdLlamadas.Location = new System.Drawing.Point(38, 69);
            this.grdLlamadas.MainView = this.gridView1;
            this.grdLlamadas.Name = "grdLlamadas";
            this.grdLlamadas.Size = new System.Drawing.Size(915, 421);
            this.grdLlamadas.TabIndex = 249;
            this.grdLlamadas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.IdLlamada,
            this.Persona,
            this.FechaLlamada,
            this.HoraLlamada,
            this.Comentario});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.grdLlamadas;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.PaintStyleName = "Web";
            // 
            // IdLlamada
            // 
            this.IdLlamada.Caption = "Id Llamada";
            this.IdLlamada.FieldName = "iIdLlamada";
            this.IdLlamada.Name = "IdLlamada";
            // 
            // Persona
            // 
            this.Persona.Caption = "Persona";
            this.Persona.FieldName = "sPersona";
            this.Persona.Name = "Persona";
            this.Persona.Visible = true;
            this.Persona.VisibleIndex = 2;
            // 
            // FechaLlamada
            // 
            this.FechaLlamada.Caption = "Fecha";
            this.FechaLlamada.FieldName = "dtFecha";
            this.FechaLlamada.Name = "FechaLlamada";
            this.FechaLlamada.Visible = true;
            this.FechaLlamada.VisibleIndex = 0;
            // 
            // HoraLlamada
            // 
            this.HoraLlamada.Caption = "Hora";
            this.HoraLlamada.FieldName = "tsHora";
            this.HoraLlamada.Name = "HoraLlamada";
            this.HoraLlamada.Visible = true;
            this.HoraLlamada.VisibleIndex = 1;
            // 
            // Comentario
            // 
            this.Comentario.Caption = "Comentario";
            this.Comentario.FieldName = "sComentario";
            this.Comentario.Name = "Comentario";
            this.Comentario.Visible = true;
            this.Comentario.VisibleIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(38, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 47);
            this.panel2.TabIndex = 252;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Introduzca texto a buscar...";
            this.txtBuscar.Location = new System.Drawing.Point(40, 83);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(204, 23);
            this.txtBuscar.TabIndex = 250;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(36, 59);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(55, 19);
            this.materialLabel6.TabIndex = 251;
            this.materialLabel6.Text = "Buscar";
            // 
            // lblNoRegitros
            // 
            this.lblNoRegitros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNoRegitros.AutoSize = true;
            this.lblNoRegitros.Depth = 0;
            this.lblNoRegitros.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNoRegitros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoRegitros.Location = new System.Drawing.Point(34, 493);
            this.lblNoRegitros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoRegitros.Name = "lblNoRegitros";
            this.lblNoRegitros.Size = new System.Drawing.Size(137, 19);
            this.lblNoRegitros.TabIndex = 253;
            this.lblNoRegitros.Text = "No. de Registros: --";
            // 
            // btnExportar
            // 
            this.btnExportar.BGColor = "#1B5E20";
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Depth = 0;
            this.btnExportar.Icon = global::LxCallcenter.Properties.Resources.Excel_Export;
            this.btnExportar.Location = new System.Drawing.Point(38, 33);
            this.btnExportar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Primary = true;
            this.btnExportar.Size = new System.Drawing.Size(87, 23);
            this.btnExportar.TabIndex = 254;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lnkCerrar
            // 
            this.lnkCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.lnkCerrar.Image = global::LxCallcenter.Properties.Resources.delete_sign_filled_23px;
            this.lnkCerrar.ImageSize = 25;
            this.lnkCerrar.Location = new System.Drawing.Point(952, 12);
            this.lnkCerrar.Name = "lnkCerrar";
            this.lnkCerrar.NoFocusImage = global::LxCallcenter.Properties.Resources.delete_sign_23px;
            this.lnkCerrar.Size = new System.Drawing.Size(25, 25);
            this.lnkCerrar.TabIndex = 10;
            this.metroToolTip1.SetToolTip(this.lnkCerrar, "Cerrar");
            this.lnkCerrar.UseSelectable = true;
            this.lnkCerrar.Click += new System.EventHandler(this.lnkCerrar_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmHistorialLlamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(989, 536);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblNoRegitros);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grdLlamadas);
            this.Controls.Add(this.lnkCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHistorialLlamadas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistorialLlamadas";
            ((System.ComponentModel.ISupportInitialize)(this.grdLlamadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraGrid.GridControl grdLlamadas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdLlamada;
        private DevExpress.XtraGrid.Columns.GridColumn FechaLlamada;
        private DevExpress.XtraGrid.Columns.GridColumn HoraLlamada;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lblNoRegitros;
        private DevExpress.XtraGrid.Columns.GridColumn Persona;
        private DevExpress.XtraGrid.Columns.GridColumn Comentario;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnExportar;
        private System.Windows.Forms.SaveFileDialog sfdExportarLlamadas;
        private MetroFramework.Controls.MetroLink lnkCerrar;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}