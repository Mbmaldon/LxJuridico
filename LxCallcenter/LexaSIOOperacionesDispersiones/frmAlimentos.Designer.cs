namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	partial class frmAlimentos
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
            this.cmbxSemDesde = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbxSemanas = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbxAnio = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblAnio = new System.Windows.Forms.Label();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblSemana = new System.Windows.Forms.Label();
            this.grdDevoluciones = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CuentaBancaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImporteDevolver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Monto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoOperacionBancaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaDeposito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdBancario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CuentaInterbancaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDevoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.panel5.TabIndex = 239;
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
            this.label4.Size = new System.Drawing.Size(158, 33);
            this.label4.TabIndex = 96;
            this.label4.Text = "Devoluciones";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblFecha.Location = new System.Drawing.Point(32, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(489, 22);
            this.lblFecha.TabIndex = 97;
            this.lblFecha.Text = "Obtiene el concentrado de pagos para devoluciones de los clientes.";
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
            this.panelControl1.TabIndex = 240;
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
            this.panel6.Controls.Add(this.grdDevoluciones);
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
            this.panel1.Controls.Add(this.cmbxSemDesde);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.cmbxSemanas);
            this.panel1.Controls.Add(this.cmbxAnio);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.lblAnio);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.lblSemana);
            this.panel1.Location = new System.Drawing.Point(21, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 66);
            this.panel1.TabIndex = 215;
            // 
            // cmbxSemDesde
            // 
            this.cmbxSemDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxSemDesde.DataSource = null;
            this.cmbxSemDesde.Depth = 0;
            this.cmbxSemDesde.DisplayMember = "";
            this.cmbxSemDesde.DropDownWidth = 80;
            this.cmbxSemDesde.Hint = "";
            this.cmbxSemDesde.Location = new System.Drawing.Point(976, 34);
            this.cmbxSemDesde.MaxLength = 0;
            this.cmbxSemDesde.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxSemDesde.Name = "cmbxSemDesde";
            this.cmbxSemDesde.PasswordChar = '\0';
            this.cmbxSemDesde.SelectedIndex = -1;
            this.cmbxSemDesde.SelectedItem = null;
            this.cmbxSemDesde.SelectedText = "";
            this.cmbxSemDesde.SelectedValue = null;
            this.cmbxSemDesde.Size = new System.Drawing.Size(80, 29);
            this.cmbxSemDesde.TabIndex = 243;
            this.cmbxSemDesde.TabStop = false;
            this.cmbxSemDesde.UseSystemPasswordChar = false;
            this.cmbxSemDesde.ValueMember = "";
            this.cmbxSemDesde.SelectionChangeCommitted += new System.EventHandler(this.cmbxSemanas_SelectionChangeCommitted);
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Enabled = false;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(863, 39);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(107, 19);
            this.materialLabel4.TabIndex = 242;
            this.materialLabel4.Text = "Semana desde";
            // 
            // cmbxSemanas
            // 
            this.cmbxSemanas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxSemanas.DataSource = null;
            this.cmbxSemanas.Depth = 0;
            this.cmbxSemanas.DisplayMember = "";
            this.cmbxSemanas.DropDownWidth = 80;
            this.cmbxSemanas.Hint = "";
            this.cmbxSemanas.Location = new System.Drawing.Point(1087, 34);
            this.cmbxSemanas.MaxLength = 0;
            this.cmbxSemanas.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxSemanas.Name = "cmbxSemanas";
            this.cmbxSemanas.PasswordChar = '\0';
            this.cmbxSemanas.SelectedIndex = -1;
            this.cmbxSemanas.SelectedItem = null;
            this.cmbxSemanas.SelectedText = "";
            this.cmbxSemanas.SelectedValue = null;
            this.cmbxSemanas.Size = new System.Drawing.Size(80, 29);
            this.cmbxSemanas.TabIndex = 241;
            this.cmbxSemanas.TabStop = false;
            this.cmbxSemanas.UseSystemPasswordChar = false;
            this.cmbxSemanas.ValueMember = "";
            this.cmbxSemanas.SelectionChangeCommitted += new System.EventHandler(this.cmbxSemanas_SelectionChangeCommitted);
            // 
            // cmbxAnio
            // 
            this.cmbxAnio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxAnio.DataSource = null;
            this.cmbxAnio.Depth = 0;
            this.cmbxAnio.DisplayMember = "";
            this.cmbxAnio.DropDownWidth = 80;
            this.cmbxAnio.Hint = "";
            this.cmbxAnio.Location = new System.Drawing.Point(976, 1);
            this.cmbxAnio.MaxLength = 0;
            this.cmbxAnio.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxAnio.Name = "cmbxAnio";
            this.cmbxAnio.PasswordChar = '\0';
            this.cmbxAnio.SelectedIndex = -1;
            this.cmbxAnio.SelectedItem = null;
            this.cmbxAnio.SelectedText = "";
            this.cmbxAnio.SelectedValue = null;
            this.cmbxAnio.Size = new System.Drawing.Size(191, 29);
            this.cmbxAnio.TabIndex = 240;
            this.cmbxAnio.TabStop = false;
            this.cmbxAnio.UseSystemPasswordChar = false;
            this.cmbxAnio.ValueMember = "";
            this.cmbxAnio.SelectionChangeCommitted += new System.EventHandler(this.cmbxAnio_SelectionChangeCommitted);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Enabled = false;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(1062, 41);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(17, 19);
            this.materialLabel2.TabIndex = 239;
            this.materialLabel2.Text = "a";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Enabled = false;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(934, 7);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(36, 19);
            this.materialLabel1.TabIndex = 238;
            this.materialLabel1.Text = "Año";
            // 
            // lblAnio
            // 
            this.lblAnio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.lblAnio.Location = new System.Drawing.Point(728, 42);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(114, 16);
            this.lblAnio.TabIndex = 237;
            this.lblAnio.Text = "2017";
            this.lblAnio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Enabled = false;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(721, -2);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(127, 19);
            this.materialLabel3.TabIndex = 235;
            this.materialLabel3.Text = "Semana en Curso";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSemana
            // 
            this.lblSemana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSemana.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.lblSemana.Location = new System.Drawing.Point(728, 15);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(114, 26);
            this.lblSemana.TabIndex = 236;
            this.lblSemana.Text = "34";
            this.lblSemana.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdDevoluciones
            // 
            this.grdDevoluciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDevoluciones.Location = new System.Drawing.Point(22, 22);
            this.grdDevoluciones.MainView = this.gridView1;
            this.grdDevoluciones.Name = "grdDevoluciones";
            this.grdDevoluciones.Size = new System.Drawing.Size(1168, 488);
            this.grdDevoluciones.TabIndex = 214;
            this.grdDevoluciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.IdPago,
            this.Nombre,
            this.IdCliente,
            this.CuentaBancaria,
            this.NoFactura,
            this.ImporteDevolver,
            this.Monto,
            this.NoOperacionBancaria,
            this.FechaPago,
            this.FechaDeposito,
            this.IdBancario,
            this.CuentaInterbancaria,
            this.Banco});
            this.gridView1.GridControl = this.grdDevoluciones;
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
            // IdPago
            // 
            this.IdPago.Caption = "Id Pago";
            this.IdPago.FieldName = "iIdPago";
            this.IdPago.Name = "IdPago";
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Socio Comanditario";
            this.Nombre.FieldName = "sNombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.OptionsColumn.AllowEdit = false;
            this.Nombre.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 0;
            // 
            // IdCliente
            // 
            this.IdCliente.Caption = "Id Cliente";
            this.IdCliente.FieldName = "iIdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.OptionsColumn.AllowEdit = false;
            this.IdCliente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            // 
            // CuentaBancaria
            // 
            this.CuentaBancaria.Caption = "Cuenta bancaria";
            this.CuentaBancaria.FieldName = "sCuentaBancaria";
            this.CuentaBancaria.Name = "CuentaBancaria";
            this.CuentaBancaria.OptionsColumn.AllowEdit = false;
            this.CuentaBancaria.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.CuentaBancaria.Visible = true;
            this.CuentaBancaria.VisibleIndex = 3;
            // 
            // NoFactura
            // 
            this.NoFactura.Caption = "No. de Factura";
            this.NoFactura.FieldName = "sNoFactura";
            this.NoFactura.Name = "NoFactura";
            this.NoFactura.OptionsColumn.AllowEdit = false;
            this.NoFactura.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            // 
            // ImporteDevolver
            // 
            this.ImporteDevolver.Caption = "Importe Alimentos";
            this.ImporteDevolver.DisplayFormat.FormatString = "C2";
            this.ImporteDevolver.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ImporteDevolver.FieldName = "dImporteDevolver";
            this.ImporteDevolver.Name = "ImporteDevolver";
            this.ImporteDevolver.OptionsColumn.AllowEdit = false;
            this.ImporteDevolver.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.ImporteDevolver.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dImporteDevolver", "{0:C2}")});
            this.ImporteDevolver.Visible = true;
            this.ImporteDevolver.VisibleIndex = 6;
            // 
            // Monto
            // 
            this.Monto.Caption = "Monto";
            this.Monto.DisplayFormat.FormatString = "C2";
            this.Monto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Monto.FieldName = "dMonto";
            this.Monto.Name = "Monto";
            this.Monto.OptionsColumn.AllowEdit = false;
            this.Monto.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Monto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dMonto", "{0:C2}")});
            this.Monto.Visible = true;
            this.Monto.VisibleIndex = 5;
            // 
            // NoOperacionBancaria
            // 
            this.NoOperacionBancaria.Caption = "No. de Operación Bancaria";
            this.NoOperacionBancaria.FieldName = "sNoOperacion";
            this.NoOperacionBancaria.Name = "NoOperacionBancaria";
            this.NoOperacionBancaria.OptionsColumn.AllowEdit = false;
            this.NoOperacionBancaria.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            // 
            // FechaPago
            // 
            this.FechaPago.Caption = "Fecha de Pago";
            this.FechaPago.FieldName = "dtFecha";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.OptionsColumn.AllowEdit = false;
            this.FechaPago.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart;
            this.FechaPago.Visible = true;
            this.FechaPago.VisibleIndex = 7;
            // 
            // FechaDeposito
            // 
            this.FechaDeposito.Caption = "Fecha de Deposito (SCI)";
            this.FechaDeposito.FieldName = "sFechaDeposito";
            this.FechaDeposito.Name = "FechaDeposito";
            // 
            // IdBancario
            // 
            this.IdBancario.Caption = "Id Bancario";
            this.IdBancario.FieldName = "sIdBancario";
            this.IdBancario.Name = "IdBancario";
            this.IdBancario.Visible = true;
            this.IdBancario.VisibleIndex = 2;
            // 
            // CuentaInterbancaria
            // 
            this.CuentaInterbancaria.Caption = "CLABE Interbancaria";
            this.CuentaInterbancaria.FieldName = "sCuentaInterbancaria";
            this.CuentaInterbancaria.Name = "CuentaInterbancaria";
            this.CuentaInterbancaria.Visible = true;
            this.CuentaInterbancaria.VisibleIndex = 4;
            // 
            // Banco
            // 
            this.Banco.Caption = "Banco";
            this.Banco.FieldName = "sBanco";
            this.Banco.Name = "Banco";
            this.Banco.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Banco.Visible = true;
            this.Banco.VisibleIndex = 1;
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
            // frmAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1268, 644);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel5);
            this.Name = "frmAlimentos";
            this.Text = "frmAlimentos";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDevoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

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
		private DevExpress.XtraGrid.Columns.GridColumn IdPago;
		private DevExpress.XtraGrid.Columns.GridColumn Nombre;
		private DevExpress.XtraGrid.Columns.GridColumn IdCliente;
		private DevExpress.XtraGrid.Columns.GridColumn CuentaBancaria;
		private DevExpress.XtraGrid.Columns.GridColumn NoFactura;
		private DevExpress.XtraGrid.Columns.GridColumn ImporteDevolver;
		private DevExpress.XtraGrid.Columns.GridColumn Monto;
		private DevExpress.XtraGrid.Columns.GridColumn NoOperacionBancaria;
		private DevExpress.XtraGrid.Columns.GridColumn FechaPago;
		private DevExpress.XtraGrid.Columns.GridColumn FechaDeposito;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private MetroFramework.Components.MetroToolTip metroToolTip1;
		private System.Windows.Forms.Label lblAnio;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private System.Windows.Forms.Label lblSemana;
		private DevExpress.XtraGrid.Columns.GridColumn IdBancario;
		private DevExpress.XtraGrid.Columns.GridColumn CuentaInterbancaria;
		private DevExpress.XtraGrid.Columns.GridColumn Banco;
		public MaterialSkin.Controls.MaterialComboBox cmbxSemanas;
		public MaterialSkin.Controls.MaterialComboBox cmbxAnio;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		public DevExpress.XtraGrid.GridControl grdDevoluciones;
		public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public MaterialSkin.Controls.MaterialComboBox cmbxSemDesde;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}