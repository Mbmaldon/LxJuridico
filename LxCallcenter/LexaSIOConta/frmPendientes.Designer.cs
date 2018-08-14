namespace LxCallcenter.LexaSIOConta
{
	partial class frmPendientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinalizar = new LollipopButton();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMultas = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRecargos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtActualizacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.txtImporte = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbxConcepto = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMonto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.cbEstadoPago = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLlavePago = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLCaptura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumOperacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaPago = new MetroFramework.Controls.MetroDateTime();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFPresentacion = new MetroFramework.Controls.MetroDateTime();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbxTipoDeclaracion = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.grdConceptos = new MetroFramework.Controls.MetroGrid();
            this.iIdConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dActualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRecargos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMultas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTodal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarConcepto = new LollipopButton();
            this.cmbxPeriodo = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbxDeclaracion = new MaterialSkin.Controls.MaterialComboBox();
            this.btnGuardar = new LollipopButton();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label2.Location = new System.Drawing.Point(28, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 22);
            this.label2.TabIndex = 81;
            this.label2.Text = "Selección de declaraciones pendientes.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 33);
            this.label1.TabIndex = 80;
            this.label1.Text = "Declaraciones";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Location = new System.Drawing.Point(31, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1177, 588);
            this.panelControl1.TabIndex = 99;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnFinalizar);
            this.panel1.Controls.Add(this.materialLabel15);
            this.panel1.Controls.Add(this.txtMultas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.materialLabel14);
            this.panel1.Controls.Add(this.txtRecargos);
            this.panel1.Controls.Add(this.materialLabel13);
            this.panel1.Controls.Add(this.txtActualizacion);
            this.panel1.Controls.Add(this.materialLabel12);
            this.panel1.Controls.Add(this.txtImporte);
            this.panel1.Controls.Add(this.materialLabel11);
            this.panel1.Controls.Add(this.cmbxConcepto);
            this.panel1.Controls.Add(this.materialLabel10);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.materialLabel9);
            this.panel1.Controls.Add(this.cbEstadoPago);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.txtLlavePago);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.txtLCaptura);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.txtNumOperacion);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.dtpFechaPago);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.dtpFPresentacion);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.cmbxTipoDeclaracion);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.grdConceptos);
            this.panel1.Controls.Add(this.btnAgregarConcepto);
            this.panel1.Controls.Add(this.cmbxPeriodo);
            this.panel1.Controls.Add(this.cmbxDeclaracion);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 584);
            this.panel1.TabIndex = 0;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.BGColor = "#3f51b5";
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FontColor = "#ffffff";
            this.btnFinalizar.Location = new System.Drawing.Point(526, 549);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(124, 20);
            this.btnFinalizar.TabIndex = 235;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(798, 299);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(55, 19);
            this.materialLabel15.TabIndex = 234;
            this.materialLabel15.Text = "Multas";
            this.materialLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMultas
            // 
            this.txtMultas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMultas.Depth = 0;
            this.txtMultas.Hint = "";
            this.txtMultas.Location = new System.Drawing.Point(802, 327);
            this.txtMultas.MaxLength = 32767;
            this.txtMultas.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMultas.Name = "txtMultas";
            this.txtMultas.PasswordChar = '\0';
            this.txtMultas.ReadOnly = false;
            this.txtMultas.SelectedText = "";
            this.txtMultas.SelectionLength = 0;
            this.txtMultas.SelectionStart = 0;
            this.txtMultas.Size = new System.Drawing.Size(111, 25);
            this.txtMultas.TabIndex = 233;
            this.txtMultas.TabStop = false;
            this.txtMultas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMultas.UseSystemPasswordChar = false;
            this.txtMultas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(673, 288);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(73, 19);
            this.materialLabel14.TabIndex = 232;
            this.materialLabel14.Text = "Recargos";
            this.materialLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecargos
            // 
            this.txtRecargos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRecargos.Depth = 0;
            this.txtRecargos.Hint = "";
            this.txtRecargos.Location = new System.Drawing.Point(677, 316);
            this.txtRecargos.MaxLength = 32767;
            this.txtRecargos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRecargos.Name = "txtRecargos";
            this.txtRecargos.PasswordChar = '\0';
            this.txtRecargos.ReadOnly = false;
            this.txtRecargos.SelectedText = "";
            this.txtRecargos.SelectionLength = 0;
            this.txtRecargos.SelectionStart = 0;
            this.txtRecargos.Size = new System.Drawing.Size(111, 25);
            this.txtRecargos.TabIndex = 231;
            this.txtRecargos.TabStop = false;
            this.txtRecargos.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRecargos.UseSystemPasswordChar = false;
            this.txtRecargos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(543, 288);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(101, 19);
            this.materialLabel13.TabIndex = 230;
            this.materialLabel13.Text = "Actualización";
            this.materialLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtActualizacion
            // 
            this.txtActualizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtActualizacion.Depth = 0;
            this.txtActualizacion.Hint = "";
            this.txtActualizacion.Location = new System.Drawing.Point(547, 316);
            this.txtActualizacion.MaxLength = 32767;
            this.txtActualizacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtActualizacion.Name = "txtActualizacion";
            this.txtActualizacion.PasswordChar = '\0';
            this.txtActualizacion.ReadOnly = false;
            this.txtActualizacion.SelectedText = "";
            this.txtActualizacion.SelectionLength = 0;
            this.txtActualizacion.SelectionStart = 0;
            this.txtActualizacion.Size = new System.Drawing.Size(111, 25);
            this.txtActualizacion.TabIndex = 229;
            this.txtActualizacion.TabStop = false;
            this.txtActualizacion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtActualizacion.UseSystemPasswordChar = false;
            this.txtActualizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(411, 288);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(50, 19);
            this.materialLabel12.TabIndex = 228;
            this.materialLabel12.Text = "Cargo";
            this.materialLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImporte
            // 
            this.txtImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtImporte.Depth = 0;
            this.txtImporte.Hint = "";
            this.txtImporte.Location = new System.Drawing.Point(415, 316);
            this.txtImporte.MaxLength = 32767;
            this.txtImporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.PasswordChar = '\0';
            this.txtImporte.ReadOnly = false;
            this.txtImporte.SelectedText = "";
            this.txtImporte.SelectionLength = 0;
            this.txtImporte.SelectionStart = 0;
            this.txtImporte.Size = new System.Drawing.Size(111, 25);
            this.txtImporte.TabIndex = 227;
            this.txtImporte.TabStop = false;
            this.txtImporte.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtImporte.UseSystemPasswordChar = false;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(102, 288);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(74, 19);
            this.materialLabel11.TabIndex = 226;
            this.materialLabel11.Text = "Concepto";
            this.materialLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbxConcepto
            // 
            this.cmbxConcepto.DataSource = null;
            this.cmbxConcepto.Depth = 0;
            this.cmbxConcepto.DisplayMember = "";
            this.cmbxConcepto.DropDownWidth = 266;
            this.cmbxConcepto.Hint = "";
            this.cmbxConcepto.Location = new System.Drawing.Point(106, 311);
            this.cmbxConcepto.MaxLength = 0;
            this.cmbxConcepto.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxConcepto.Name = "cmbxConcepto";
            this.cmbxConcepto.PasswordChar = '\0';
            this.cmbxConcepto.SelectedIndex = -1;
            this.cmbxConcepto.SelectedItem = null;
            this.cmbxConcepto.SelectedText = "";
            this.cmbxConcepto.SelectedValue = null;
            this.cmbxConcepto.Size = new System.Drawing.Size(266, 29);
            this.cmbxConcepto.TabIndex = 225;
            this.cmbxConcepto.TabStop = false;
            this.cmbxConcepto.UseSystemPasswordChar = false;
            this.cmbxConcepto.ValueMember = "";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(907, 201);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(100, 19);
            this.materialLabel10.TabIndex = 224;
            this.materialLabel10.Text = "Total a Pagar";
            this.materialLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMonto
            // 
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMonto.Depth = 0;
            this.txtMonto.Hint = "";
            this.txtMonto.Location = new System.Drawing.Point(912, 224);
            this.txtMonto.MaxLength = 32767;
            this.txtMonto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.ReadOnly = true;
            this.txtMonto.SelectedText = "";
            this.txtMonto.SelectionLength = 0;
            this.txtMonto.SelectionStart = 0;
            this.txtMonto.Size = new System.Drawing.Size(150, 25);
            this.txtMonto.TabIndex = 223;
            this.txtMonto.TabStop = false;
            this.txtMonto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMonto.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(103, 185);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(115, 19);
            this.materialLabel9.TabIndex = 222;
            this.materialLabel9.Text = "Estado de Pago";
            this.materialLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbEstadoPago
            // 
            this.cbEstadoPago.DataSource = null;
            this.cbEstadoPago.Depth = 0;
            this.cbEstadoPago.DisplayMember = "";
            this.cbEstadoPago.DropDownWidth = 154;
            this.cbEstadoPago.Hint = "";
            this.cbEstadoPago.Location = new System.Drawing.Point(107, 208);
            this.cbEstadoPago.MaxLength = 0;
            this.cbEstadoPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbEstadoPago.Name = "cbEstadoPago";
            this.cbEstadoPago.PasswordChar = '\0';
            this.cbEstadoPago.SelectedIndex = -1;
            this.cbEstadoPago.SelectedItem = null;
            this.cbEstadoPago.SelectedText = "";
            this.cbEstadoPago.SelectedValue = null;
            this.cbEstadoPago.Size = new System.Drawing.Size(154, 29);
            this.cbEstadoPago.TabIndex = 221;
            this.cbEstadoPago.TabStop = false;
            this.cbEstadoPago.UseSystemPasswordChar = false;
            this.cbEstadoPago.ValueMember = "";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(725, 201);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(104, 19);
            this.materialLabel8.TabIndex = 220;
            this.materialLabel8.Text = "Llave de Pago";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLlavePago
            // 
            this.txtLlavePago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLlavePago.Depth = 0;
            this.txtLlavePago.Hint = "";
            this.txtLlavePago.Location = new System.Drawing.Point(729, 224);
            this.txtLlavePago.MaxLength = 32767;
            this.txtLlavePago.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLlavePago.Name = "txtLlavePago";
            this.txtLlavePago.PasswordChar = '\0';
            this.txtLlavePago.ReadOnly = false;
            this.txtLlavePago.SelectedText = "";
            this.txtLlavePago.SelectionLength = 0;
            this.txtLlavePago.SelectionStart = 0;
            this.txtLlavePago.Size = new System.Drawing.Size(150, 25);
            this.txtLlavePago.TabIndex = 219;
            this.txtLlavePago.TabStop = false;
            this.txtLlavePago.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLlavePago.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(531, 190);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(121, 19);
            this.materialLabel7.TabIndex = 218;
            this.materialLabel7.Text = "Línea de Captura";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLCaptura
            // 
            this.txtLCaptura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLCaptura.Depth = 0;
            this.txtLCaptura.Hint = "";
            this.txtLCaptura.Location = new System.Drawing.Point(535, 213);
            this.txtLCaptura.MaxLength = 32767;
            this.txtLCaptura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLCaptura.Name = "txtLCaptura";
            this.txtLCaptura.PasswordChar = '\0';
            this.txtLCaptura.ReadOnly = false;
            this.txtLCaptura.SelectedText = "";
            this.txtLCaptura.SelectionLength = 0;
            this.txtLCaptura.SelectionStart = 0;
            this.txtLCaptura.Size = new System.Drawing.Size(166, 25);
            this.txtLCaptura.TabIndex = 217;
            this.txtLCaptura.TabStop = false;
            this.txtLCaptura.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLCaptura.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(284, 190);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(155, 19);
            this.materialLabel6.TabIndex = 216;
            this.materialLabel6.Text = "Número de Operación";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumOperacion
            // 
            this.txtNumOperacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumOperacion.Depth = 0;
            this.txtNumOperacion.Hint = "";
            this.txtNumOperacion.Location = new System.Drawing.Point(289, 213);
            this.txtNumOperacion.MaxLength = 32767;
            this.txtNumOperacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumOperacion.Name = "txtNumOperacion";
            this.txtNumOperacion.PasswordChar = '\0';
            this.txtNumOperacion.ReadOnly = false;
            this.txtNumOperacion.SelectedText = "";
            this.txtNumOperacion.SelectionLength = 0;
            this.txtNumOperacion.SelectionStart = 0;
            this.txtNumOperacion.Size = new System.Drawing.Size(221, 25);
            this.txtNumOperacion.TabIndex = 215;
            this.txtNumOperacion.TabStop = false;
            this.txtNumOperacion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumOperacion.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(909, 123);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(155, 19);
            this.materialLabel5.TabIndex = 214;
            this.materialLabel5.Text = "Fecha Límite de Pago";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPago.Location = new System.Drawing.Point(912, 147);
            this.dtpFechaPago.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(150, 29);
            this.dtpFechaPago.Style = MetroFramework.MetroColorStyle.Purple;
            this.dtpFechaPago.TabIndex = 213;
            this.dtpFechaPago.Value = new System.DateTime(2017, 9, 25, 0, 0, 0, 0);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(726, 123);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(162, 19);
            this.materialLabel4.TabIndex = 212;
            this.materialLabel4.Text = "Fecha de Presentación";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFPresentacion
            // 
            this.dtpFPresentacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFPresentacion.Location = new System.Drawing.Point(729, 147);
            this.dtpFPresentacion.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFPresentacion.Name = "dtpFPresentacion";
            this.dtpFPresentacion.Size = new System.Drawing.Size(150, 29);
            this.dtpFPresentacion.Style = MetroFramework.MetroColorStyle.Purple;
            this.dtpFPresentacion.TabIndex = 211;
            this.dtpFPresentacion.Value = new System.DateTime(2017, 9, 25, 0, 0, 0, 0);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(103, 112);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 19);
            this.materialLabel1.TabIndex = 119;
            this.materialLabel1.Text = "Tipo";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbxTipoDeclaracion
            // 
            this.cmbxTipoDeclaracion.DataSource = null;
            this.cmbxTipoDeclaracion.Depth = 0;
            this.cmbxTipoDeclaracion.DisplayMember = "";
            this.cmbxTipoDeclaracion.DropDownWidth = 155;
            this.cmbxTipoDeclaracion.Hint = "";
            this.cmbxTipoDeclaracion.Location = new System.Drawing.Point(107, 135);
            this.cmbxTipoDeclaracion.MaxLength = 0;
            this.cmbxTipoDeclaracion.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxTipoDeclaracion.Name = "cmbxTipoDeclaracion";
            this.cmbxTipoDeclaracion.PasswordChar = '\0';
            this.cmbxTipoDeclaracion.SelectedIndex = -1;
            this.cmbxTipoDeclaracion.SelectedItem = null;
            this.cmbxTipoDeclaracion.SelectedText = "";
            this.cmbxTipoDeclaracion.SelectedValue = null;
            this.cmbxTipoDeclaracion.Size = new System.Drawing.Size(155, 29);
            this.cmbxTipoDeclaracion.TabIndex = 118;
            this.cmbxTipoDeclaracion.TabStop = false;
            this.cmbxTipoDeclaracion.UseSystemPasswordChar = false;
            this.cmbxTipoDeclaracion.ValueMember = "";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(532, 112);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(62, 19);
            this.materialLabel3.TabIndex = 117;
            this.materialLabel3.Text = "Periódo";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(285, 112);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 19);
            this.materialLabel2.TabIndex = 117;
            this.materialLabel2.Text = "Declaración";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdConceptos
            // 
            this.grdConceptos.AllowUserToAddRows = false;
            this.grdConceptos.AllowUserToDeleteRows = false;
            this.grdConceptos.AllowUserToResizeColumns = false;
            this.grdConceptos.AllowUserToResizeRows = false;
            this.grdConceptos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grdConceptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdConceptos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdConceptos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdConceptos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdConceptos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.grdConceptos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConceptos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConceptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIdConcepto,
            this.sConcepto,
            this.sEstado,
            this.dCargo,
            this.dActualizacion,
            this.dRecargos,
            this.dMultas,
            this.dTodal});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdConceptos.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdConceptos.EnableHeadersVisualStyles = false;
            this.grdConceptos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdConceptos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdConceptos.Location = new System.Drawing.Point(107, 359);
            this.grdConceptos.MultiSelect = false;
            this.grdConceptos.Name = "grdConceptos";
            this.grdConceptos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConceptos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdConceptos.RowHeadersVisible = false;
            this.grdConceptos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdConceptos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConceptos.Size = new System.Drawing.Size(955, 128);
            this.grdConceptos.TabIndex = 116;
            // 
            // iIdConcepto
            // 
            this.iIdConcepto.HeaderText = "IdConcepto";
            this.iIdConcepto.Name = "iIdConcepto";
            this.iIdConcepto.ReadOnly = true;
            this.iIdConcepto.Visible = false;
            // 
            // sConcepto
            // 
            this.sConcepto.HeaderText = "Concepto";
            this.sConcepto.Name = "sConcepto";
            this.sConcepto.ReadOnly = true;
            // 
            // sEstado
            // 
            this.sEstado.HeaderText = "Estado";
            this.sEstado.Name = "sEstado";
            // 
            // dCargo
            // 
            dataGridViewCellStyle2.Format = "c";
            dataGridViewCellStyle2.NullValue = null;
            this.dCargo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dCargo.HeaderText = "Cargo";
            this.dCargo.Name = "dCargo";
            this.dCargo.ReadOnly = true;
            // 
            // dActualizacion
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dActualizacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dActualizacion.HeaderText = "Actualización";
            this.dActualizacion.Name = "dActualizacion";
            this.dActualizacion.ReadOnly = true;
            // 
            // dRecargos
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.dRecargos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dRecargos.HeaderText = "Recargos";
            this.dRecargos.Name = "dRecargos";
            this.dRecargos.ReadOnly = true;
            // 
            // dMultas
            // 
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.dMultas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dMultas.HeaderText = "Multas";
            this.dMultas.Name = "dMultas";
            this.dMultas.ReadOnly = true;
            // 
            // dTodal
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.dTodal.DefaultCellStyle = dataGridViewCellStyle6;
            this.dTodal.HeaderText = "Total";
            this.dTodal.Name = "dTodal";
            this.dTodal.ReadOnly = true;
            // 
            // btnAgregarConcepto
            // 
            this.btnAgregarConcepto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarConcepto.BGColor = "#607D8B";
            this.btnAgregarConcepto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarConcepto.FontColor = "#ffffff";
            this.btnAgregarConcepto.Location = new System.Drawing.Point(993, 332);
            this.btnAgregarConcepto.Name = "btnAgregarConcepto";
            this.btnAgregarConcepto.Size = new System.Drawing.Size(67, 20);
            this.btnAgregarConcepto.TabIndex = 112;
            this.btnAgregarConcepto.Text = "Agregar";
            this.btnAgregarConcepto.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // cmbxPeriodo
            // 
            this.cmbxPeriodo.DataSource = null;
            this.cmbxPeriodo.Depth = 0;
            this.cmbxPeriodo.DisplayMember = "";
            this.cmbxPeriodo.DropDownWidth = 165;
            this.cmbxPeriodo.Hint = "";
            this.cmbxPeriodo.Location = new System.Drawing.Point(536, 135);
            this.cmbxPeriodo.MaxLength = 0;
            this.cmbxPeriodo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxPeriodo.Name = "cmbxPeriodo";
            this.cmbxPeriodo.PasswordChar = '\0';
            this.cmbxPeriodo.SelectedIndex = -1;
            this.cmbxPeriodo.SelectedItem = null;
            this.cmbxPeriodo.SelectedText = "";
            this.cmbxPeriodo.SelectedValue = null;
            this.cmbxPeriodo.Size = new System.Drawing.Size(165, 29);
            this.cmbxPeriodo.TabIndex = 111;
            this.cmbxPeriodo.TabStop = false;
            this.cmbxPeriodo.UseSystemPasswordChar = false;
            this.cmbxPeriodo.ValueMember = "";
            // 
            // cmbxDeclaracion
            // 
            this.cmbxDeclaracion.DataSource = null;
            this.cmbxDeclaracion.Depth = 0;
            this.cmbxDeclaracion.DisplayMember = "";
            this.cmbxDeclaracion.DropDownWidth = 221;
            this.cmbxDeclaracion.Hint = "";
            this.cmbxDeclaracion.Location = new System.Drawing.Point(289, 135);
            this.cmbxDeclaracion.MaxLength = 0;
            this.cmbxDeclaracion.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxDeclaracion.Name = "cmbxDeclaracion";
            this.cmbxDeclaracion.PasswordChar = '\0';
            this.cmbxDeclaracion.SelectedIndex = -1;
            this.cmbxDeclaracion.SelectedItem = null;
            this.cmbxDeclaracion.SelectedText = "";
            this.cmbxDeclaracion.SelectedValue = null;
            this.cmbxDeclaracion.Size = new System.Drawing.Size(221, 29);
            this.cmbxDeclaracion.TabIndex = 110;
            this.cmbxDeclaracion.TabStop = false;
            this.cmbxDeclaracion.UseSystemPasswordChar = false;
            this.cmbxDeclaracion.ValueMember = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BGColor = "#795548";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FontColor = "#ffffff";
            this.btnGuardar.Location = new System.Drawing.Point(526, 518);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 20);
            this.btnGuardar.TabIndex = 109;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(87, 76);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(182, 19);
            this.lblTitulo.TabIndex = 101;
            this.lblTitulo.Text = "Declaraciones pendientes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1229, 648);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmPendientes";
            this.Text = "frmPendientes";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private MetroFramework.Components.MetroToolTip metroToolTip1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.Panel panel1;
		private MaterialSkin.Controls.MaterialLabel lblTitulo;
		private MaterialSkin.Controls.MaterialComboBox cmbxPeriodo;
		private MaterialSkin.Controls.MaterialComboBox cmbxDeclaracion;
		private LollipopButton btnAgregarConcepto;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MetroFramework.Controls.MetroGrid grdConceptos;
		private LollipopButton btnGuardar;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialComboBox cmbxTipoDeclaracion;
		private MaterialSkin.Controls.MaterialLabel materialLabel4;
		private MetroFramework.Controls.MetroDateTime dtpFPresentacion;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtNumOperacion;
		private MaterialSkin.Controls.MaterialLabel materialLabel5;
		private MetroFramework.Controls.MetroDateTime dtpFechaPago;
		private MaterialSkin.Controls.MaterialLabel materialLabel10;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtMonto;
		private MaterialSkin.Controls.MaterialLabel materialLabel9;
		private MaterialSkin.Controls.MaterialComboBox cbEstadoPago;
		private MaterialSkin.Controls.MaterialLabel materialLabel8;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtLlavePago;
		private MaterialSkin.Controls.MaterialLabel materialLabel7;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtLCaptura;
		private MaterialSkin.Controls.MaterialLabel materialLabel6;
		private MaterialSkin.Controls.MaterialLabel materialLabel15;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtMultas;
		private MaterialSkin.Controls.MaterialLabel materialLabel14;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtRecargos;
		private MaterialSkin.Controls.MaterialLabel materialLabel13;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtActualizacion;
		private MaterialSkin.Controls.MaterialLabel materialLabel12;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtImporte;
		private MaterialSkin.Controls.MaterialLabel materialLabel11;
		private MaterialSkin.Controls.MaterialComboBox cmbxConcepto;
		private LollipopButton btnFinalizar;
		private System.Windows.Forms.ErrorProvider MensajeError;
		private System.Windows.Forms.DataGridViewTextBoxColumn iIdConcepto;
		private System.Windows.Forms.DataGridViewTextBoxColumn sConcepto;
		private System.Windows.Forms.DataGridViewTextBoxColumn sEstado;
		private System.Windows.Forms.DataGridViewTextBoxColumn dCargo;
		private System.Windows.Forms.DataGridViewTextBoxColumn dActualizacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn dRecargos;
		private System.Windows.Forms.DataGridViewTextBoxColumn dMultas;
		private System.Windows.Forms.DataGridViewTextBoxColumn dTodal;
	}
}