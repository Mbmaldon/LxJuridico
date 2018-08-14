namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    partial class frmCatalogoSci
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
            this.grdCatalogoSCI = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NoExpediente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Curp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Comisionista = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Activo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AcumuladoAlimentos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImportarNuevosSocios = new System.Windows.Forms.Button();
            this.btnExportarListaSocios = new System.Windows.Forms.Button();
            this.pblImportes = new System.Windows.Forms.Panel();
            this.lblSociosBaja = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblActivos = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblAltasMes = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCatalogoSCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pblImportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(114, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(117, 27);
            this.lblFecha.TabIndex = 99;
            this.lblFecha.Text = "Vendedores";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 33);
            this.label4.TabIndex = 98;
            this.label4.Text = "Catálogo de SCI";
            // 
            // grdCatalogoSCI
            // 
            this.grdCatalogoSCI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCatalogoSCI.Location = new System.Drawing.Point(33, 132);
            this.grdCatalogoSCI.MainView = this.gridView1;
            this.grdCatalogoSCI.Name = "grdCatalogoSCI";
            this.grdCatalogoSCI.Size = new System.Drawing.Size(1107, 136);
            this.grdCatalogoSCI.TabIndex = 100;
            this.grdCatalogoSCI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.NoExpediente,
            this.FechaModificacion,
            this.Nombre,
            this.Direccion,
            this.Curp,
            this.Comisionista,
            this.Activo,
            this.AcumuladoAlimentos});
            this.gridView1.GridControl = this.grdCatalogoSCI;
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
            // NoExpediente
            // 
            this.NoExpediente.Caption = "No. Expediente";
            this.NoExpediente.FieldName = "sNoExpediente";
            this.NoExpediente.Name = "NoExpediente";
            this.NoExpediente.Visible = true;
            this.NoExpediente.VisibleIndex = 0;
            // 
            // FechaModificacion
            // 
            this.FechaModificacion.Caption = "Fecha de Alta";
            this.FechaModificacion.FieldName = "sFechaModificacion";
            this.FechaModificacion.Name = "FechaModificacion";
            this.FechaModificacion.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateAlt;
            this.FechaModificacion.Visible = true;
            this.FechaModificacion.VisibleIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "sNombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 2;
            // 
            // Direccion
            // 
            this.Direccion.Caption = "Dirección";
            this.Direccion.FieldName = "sDireccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Visible = true;
            this.Direccion.VisibleIndex = 3;
            // 
            // Curp
            // 
            this.Curp.Caption = "CURP";
            this.Curp.FieldName = "sCurp";
            this.Curp.Name = "Curp";
            this.Curp.Visible = true;
            this.Curp.VisibleIndex = 4;
            // 
            // Comisionista
            // 
            this.Comisionista.Caption = "Vendedor Asociado";
            this.Comisionista.FieldName = "sComisionista";
            this.Comisionista.Name = "Comisionista";
            this.Comisionista.Visible = true;
            this.Comisionista.VisibleIndex = 5;
            // 
            // Activo
            // 
            this.Activo.Caption = "Estatus";
            this.Activo.FieldName = "sActivo";
            this.Activo.Name = "Activo";
            this.Activo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "sActivo", "Total")});
            this.Activo.Visible = true;
            this.Activo.VisibleIndex = 6;
            // 
            // AcumuladoAlimentos
            // 
            this.AcumuladoAlimentos.Caption = "Acumulado de Alimentos";
            this.AcumuladoAlimentos.DisplayFormat.FormatString = "c";
            this.AcumuladoAlimentos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.AcumuladoAlimentos.FieldName = "dAcumulado";
            this.AcumuladoAlimentos.Name = "AcumuladoAlimentos";
            this.AcumuladoAlimentos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dAcumulado", "{0:c}")});
            this.AcumuladoAlimentos.Visible = true;
            this.AcumuladoAlimentos.VisibleIndex = 7;
            // 
            // btnImportarNuevosSocios
            // 
            this.btnImportarNuevosSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportarNuevosSocios.BackColor = System.Drawing.Color.Gray;
            this.btnImportarNuevosSocios.FlatAppearance.BorderSize = 0;
            this.btnImportarNuevosSocios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnImportarNuevosSocios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnImportarNuevosSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarNuevosSocios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImportarNuevosSocios.Image = global::LxCallcenter.Properties.Resources.DataImport_WF;
            this.btnImportarNuevosSocios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImportarNuevosSocios.Location = new System.Drawing.Point(33, 282);
            this.btnImportarNuevosSocios.Name = "btnImportarNuevosSocios";
            this.btnImportarNuevosSocios.Size = new System.Drawing.Size(164, 25);
            this.btnImportarNuevosSocios.TabIndex = 180;
            this.btnImportarNuevosSocios.Text = "Importar Nuevos Socios";
            this.btnImportarNuevosSocios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportarNuevosSocios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportarNuevosSocios.UseVisualStyleBackColor = false;
            this.btnImportarNuevosSocios.Click += new System.EventHandler(this.btnImportarNuevosSocios_Click);
            // 
            // btnExportarListaSocios
            // 
            this.btnExportarListaSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportarListaSocios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(71)))));
            this.btnExportarListaSocios.FlatAppearance.BorderSize = 0;
            this.btnExportarListaSocios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(80)))), ((int)(((byte)(71)))));
            this.btnExportarListaSocios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(100)))), ((int)(((byte)(71)))));
            this.btnExportarListaSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarListaSocios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportarListaSocios.Image = global::LxCallcenter.Properties.Resources.Excel_Export;
            this.btnExportarListaSocios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportarListaSocios.Location = new System.Drawing.Point(33, 313);
            this.btnExportarListaSocios.Name = "btnExportarListaSocios";
            this.btnExportarListaSocios.Size = new System.Drawing.Size(164, 25);
            this.btnExportarListaSocios.TabIndex = 203;
            this.btnExportarListaSocios.Text = "Exportar Lista de Socios";
            this.btnExportarListaSocios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarListaSocios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarListaSocios.UseVisualStyleBackColor = false;
            this.btnExportarListaSocios.Click += new System.EventHandler(this.btnExportarListaSocios_Click);
            // 
            // pblImportes
            // 
            this.pblImportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pblImportes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pblImportes.Controls.Add(this.lblSociosBaja);
            this.pblImportes.Controls.Add(this.label23);
            this.pblImportes.Controls.Add(this.lblActivos);
            this.pblImportes.Controls.Add(this.label15);
            this.pblImportes.Controls.Add(this.lblAltasMes);
            this.pblImportes.Controls.Add(this.label95);
            this.pblImportes.Location = new System.Drawing.Point(33, 72);
            this.pblImportes.Name = "pblImportes";
            this.pblImportes.Size = new System.Drawing.Size(1107, 42);
            this.pblImportes.TabIndex = 204;
            // 
            // lblSociosBaja
            // 
            this.lblSociosBaja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSociosBaja.AutoSize = true;
            this.lblSociosBaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSociosBaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblSociosBaja.Location = new System.Drawing.Point(998, 13);
            this.lblSociosBaja.Name = "lblSociosBaja";
            this.lblSociosBaja.Size = new System.Drawing.Size(17, 15);
            this.lblSociosBaja.TabIndex = 127;
            this.lblSociosBaja.Text = "--";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(814, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(179, 15);
            this.label23.TabIndex = 126;
            this.label23.Text = "NO. DE SOCIOS DADOS DE BAJA";
            // 
            // lblActivos
            // 
            this.lblActivos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblActivos.AutoSize = true;
            this.lblActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblActivos.Location = new System.Drawing.Point(625, 13);
            this.lblActivos.Name = "lblActivos";
            this.lblActivos.Size = new System.Drawing.Size(17, 15);
            this.lblActivos.TabIndex = 119;
            this.lblActivos.Text = "--";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(479, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 15);
            this.label15.TabIndex = 118;
            this.label15.Text = "NO. DE SOCIOS ACTIVOS";
            // 
            // lblAltasMes
            // 
            this.lblAltasMes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAltasMes.AutoSize = true;
            this.lblAltasMes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltasMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblAltasMes.Location = new System.Drawing.Point(299, 13);
            this.lblAltasMes.Name = "lblAltasMes";
            this.lblAltasMes.Size = new System.Drawing.Size(17, 15);
            this.lblAltasMes.TabIndex = 111;
            this.lblAltasMes.Text = "--";
            // 
            // label95
            // 
            this.label95.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label95.Location = new System.Drawing.Point(59, 13);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(232, 15);
            this.label95.TabIndex = 110;
            this.label95.Text = "NO. DE SOCIOS DADOS DE ALTA ESTE MES";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivo Excel | *.xlsx";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivo Excel | *.xlsx";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(203, 283);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(24, 24);
            this.dataGridView1.TabIndex = 205;
            this.dataGridView1.Visible = false;
            // 
            // frmCatalogoSci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1170, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pblImportes);
            this.Controls.Add(this.btnExportarListaSocios);
            this.Controls.Add(this.btnImportarNuevosSocios);
            this.Controls.Add(this.grdCatalogoSCI);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Name = "frmCatalogoSci";
            this.Text = "frmCatalogoSci";
            ((System.ComponentModel.ISupportInitialize)(this.grdCatalogoSCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pblImportes.ResumeLayout(false);
            this.pblImportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl grdCatalogoSCI;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NoExpediente;
        private DevExpress.XtraGrid.Columns.GridColumn FechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Direccion;
        private DevExpress.XtraGrid.Columns.GridColumn Curp;
        private DevExpress.XtraGrid.Columns.GridColumn Comisionista;
        private DevExpress.XtraGrid.Columns.GridColumn Activo;
        private System.Windows.Forms.Button btnImportarNuevosSocios;
        private System.Windows.Forms.Button btnExportarListaSocios;
        private System.Windows.Forms.Panel pblImportes;
        private System.Windows.Forms.Label lblSociosBaja;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblActivos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblAltasMes;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn AcumuladoAlimentos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}