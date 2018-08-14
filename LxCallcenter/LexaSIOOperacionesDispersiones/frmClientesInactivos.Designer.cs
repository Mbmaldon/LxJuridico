namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    partial class frmClientesInactivos
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
            this.grdClientes = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TelefonoM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CorreoElectronico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdServicioTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ServicioTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ServicioStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaUltimoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaVencimientoServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel4 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblFecha.Location = new System.Drawing.Point(27, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(336, 22);
            this.lblFecha.TabIndex = 97;
            this.lblFecha.Text = "Consulta el concentrado de clientes inactivos.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.label4.Location = new System.Drawing.Point(26, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 33);
            this.label4.TabIndex = 96;
            this.label4.Text = "Clientes Inactivos";
            // 
            // grdClientes
            // 
            this.grdClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdClientes.Location = new System.Drawing.Point(31, 165);
            this.grdClientes.MainView = this.gridView1;
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.Size = new System.Drawing.Size(1217, 438);
            this.grdClientes.TabIndex = 211;
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
            this.IdUsuario,
            this.NoCliente,
            this.Nombre,
            this.TelefonoM,
            this.CorreoElectronico,
            this.IdServicioTipo,
            this.ServicioTipo,
            this.ServicioStatus,
            this.FechaUltimoPago,
            this.FechaVencimientoServicio});
            this.gridView1.GridControl = this.grdClientes;
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
            // IdUsuario
            // 
            this.IdUsuario.Caption = "IdCliente";
            this.IdUsuario.FieldName = "iIdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            // 
            // NoCliente
            // 
            this.NoCliente.Caption = "No. Cliente";
            this.NoCliente.FieldName = "sCliente";
            this.NoCliente.Name = "NoCliente";
            this.NoCliente.Visible = true;
            this.NoCliente.VisibleIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "sNombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 1;
            // 
            // TelefonoM
            // 
            this.TelefonoM.Caption = "Teléfono Móvil";
            this.TelefonoM.FieldName = "sTelefonoM";
            this.TelefonoM.Name = "TelefonoM";
            this.TelefonoM.Visible = true;
            this.TelefonoM.VisibleIndex = 2;
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.Caption = "Correo Electrónico";
            this.CorreoElectronico.FieldName = "sCorreoE";
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.Visible = true;
            this.CorreoElectronico.VisibleIndex = 3;
            // 
            // IdServicioTipo
            // 
            this.IdServicioTipo.Caption = "IdServicio";
            this.IdServicioTipo.FieldName = "iIdServicioTipo";
            this.IdServicioTipo.Name = "IdServicioTipo";
            // 
            // ServicioTipo
            // 
            this.ServicioTipo.Caption = "Servicio";
            this.ServicioTipo.FieldName = "sServicioConta";
            this.ServicioTipo.Name = "ServicioTipo";
            this.ServicioTipo.Visible = true;
            this.ServicioTipo.VisibleIndex = 4;
            // 
            // ServicioStatus
            // 
            this.ServicioStatus.Caption = "Status";
            this.ServicioStatus.FieldName = "sServicioOD";
            this.ServicioStatus.Name = "ServicioStatus";
            this.ServicioStatus.Visible = true;
            this.ServicioStatus.VisibleIndex = 5;
            // 
            // FechaUltimoPago
            // 
            this.FechaUltimoPago.Caption = "Fecha de Ultimo Pago";
            this.FechaUltimoPago.FieldName = "sFechaContr";
            this.FechaUltimoPago.Name = "FechaUltimoPago";
            this.FechaUltimoPago.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateAlt;
            this.FechaUltimoPago.Visible = true;
            this.FechaUltimoPago.VisibleIndex = 6;
            // 
            // FechaVencimientoServicio
            // 
            this.FechaVencimientoServicio.Caption = "Fecha de Vencimiento de Servicio";
            this.FechaVencimientoServicio.FieldName = "sFechaVenci";
            this.FechaVencimientoServicio.Name = "FechaVencimientoServicio";
            this.FechaVencimientoServicio.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateAlt;
            this.FechaVencimientoServicio.Visible = true;
            this.FechaVencimientoServicio.VisibleIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(31, 80);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 213;
            this.label1.Text = "Buscar (Nombre)";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Nombre";
            this.txtBuscar.Location = new System.Drawing.Point(34, 102);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(193, 23);
            this.txtBuscar.TabIndex = 212;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Location = new System.Drawing.Point(-1, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1270, 22);
            this.panel4.TabIndex = 227;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivo Excel | *.xlsx";
            // 
            // frmClientesInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1268, 644);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.grdClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Name = "frmClientesInactivos";
            this.Text = "frmClientesInactivos";
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl grdClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.Columns.GridColumn IdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn NoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn TelefonoM;
        private DevExpress.XtraGrid.Columns.GridColumn CorreoElectronico;
        private DevExpress.XtraGrid.Columns.GridColumn IdServicioTipo;
        private DevExpress.XtraGrid.Columns.GridColumn ServicioTipo;
        private DevExpress.XtraGrid.Columns.GridColumn ServicioStatus;
        private DevExpress.XtraGrid.Columns.GridColumn FechaUltimoPago;
        private DevExpress.XtraGrid.Columns.GridColumn FechaVencimientoServicio;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}