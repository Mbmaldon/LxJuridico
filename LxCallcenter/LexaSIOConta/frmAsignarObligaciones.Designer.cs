namespace LxCallcenter.LexaSIOConta
{
    partial class frmAsignarObligaciones
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNoCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.ptbLoader = new System.Windows.Forms.Panel();
            this.lbProgress = new LollipopLabel();
            this.pgbDescarga = new MetroFramework.Controls.MetroProgressSpinner();
            this.cbContaAsig = new MetroFramework.Controls.MetroComboBox();
            this.txbCorreoCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbMovil = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbExtension = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbAMaterno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbAPaterno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbCurp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbRfc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ckbActivo = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblMensajeBusqueda = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAsignarObligaciones = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.lnkBuscar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.lblProgress = new MaterialSkin.Controls.MaterialLabel();
            this.lollipopButton1 = new LollipopButton();
            this.ovalPictureBox1 = new LxCallcenter.OvalPictureBox();
            this.btnCancelar = new LollipopFlatButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ptbLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asigna por primera vez obligaciones fiscales a los clientes.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignar Obligaciones Fiscales";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(145, 102);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(144, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Buscar (No. Cliente)";
            // 
            // txtNoCliente
            // 
            this.txtNoCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNoCliente.Depth = 0;
            this.txtNoCliente.Hint = "No. Cliente";
            this.txtNoCliente.Location = new System.Drawing.Point(149, 124);
            this.txtNoCliente.MaxLength = 32767;
            this.txtNoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNoCliente.Name = "txtNoCliente";
            this.txtNoCliente.PasswordChar = '\0';
            this.txtNoCliente.ReadOnly = false;
            this.txtNoCliente.SelectedText = "";
            this.txtNoCliente.SelectionLength = 0;
            this.txtNoCliente.SelectionStart = 0;
            this.txtNoCliente.Size = new System.Drawing.Size(214, 23);
            this.txtNoCliente.TabIndex = 3;
            this.txtNoCliente.TabStop = false;
            this.txtNoCliente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNoCliente.UseSystemPasswordChar = false;
            this.txtNoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoCliente_KeyPress);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ptbLoader
            // 
            this.ptbLoader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbLoader.Controls.Add(this.lbProgress);
            this.ptbLoader.Controls.Add(this.pgbDescarga);
            this.ptbLoader.Location = new System.Drawing.Point(501, 416);
            this.ptbLoader.Name = "ptbLoader";
            this.ptbLoader.Size = new System.Drawing.Size(149, 66);
            this.ptbLoader.TabIndex = 28;
            this.ptbLoader.Visible = false;
            // 
            // lbProgress
            // 
            this.lbProgress.BackColor = System.Drawing.Color.Transparent;
            this.lbProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lbProgress.Location = new System.Drawing.Point(7, 31);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(136, 31);
            this.lbProgress.TabIndex = 1;
            this.lbProgress.Text = "Creando Expediente\r\nen Línea";
            this.lbProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgbDescarga
            // 
            this.pgbDescarga.EnsureVisible = false;
            this.pgbDescarga.Location = new System.Drawing.Point(63, 6);
            this.pgbDescarga.Maximum = 100;
            this.pgbDescarga.Name = "pgbDescarga";
            this.pgbDescarga.Size = new System.Drawing.Size(22, 22);
            this.pgbDescarga.Speed = 2F;
            this.pgbDescarga.Style = MetroFramework.MetroColorStyle.Red;
            this.pgbDescarga.TabIndex = 0;
            this.pgbDescarga.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pgbDescarga.UseSelectable = true;
            this.pgbDescarga.Value = 92;
            // 
            // cbContaAsig
            // 
            this.cbContaAsig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbContaAsig.Enabled = false;
            this.cbContaAsig.FormattingEnabled = true;
            this.cbContaAsig.ItemHeight = 23;
            this.cbContaAsig.Location = new System.Drawing.Point(787, 280);
            this.cbContaAsig.Name = "cbContaAsig";
            this.cbContaAsig.Size = new System.Drawing.Size(217, 29);
            this.cbContaAsig.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbContaAsig.TabIndex = 19;
            this.cbContaAsig.UseSelectable = true;
            this.cbContaAsig.Visible = false;
            // 
            // txbCorreoCliente
            // 
            this.txbCorreoCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbCorreoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbCorreoCliente.Depth = 0;
            this.txbCorreoCliente.Hint = "";
            this.txbCorreoCliente.Location = new System.Drawing.Point(787, 345);
            this.txbCorreoCliente.MaxLength = 32767;
            this.txbCorreoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbCorreoCliente.Name = "txbCorreoCliente";
            this.txbCorreoCliente.PasswordChar = '\0';
            this.txbCorreoCliente.ReadOnly = true;
            this.txbCorreoCliente.SelectedText = "";
            this.txbCorreoCliente.SelectionLength = 0;
            this.txbCorreoCliente.SelectionStart = 0;
            this.txbCorreoCliente.Size = new System.Drawing.Size(218, 23);
            this.txbCorreoCliente.TabIndex = 27;
            this.txbCorreoCliente.TabStop = false;
            this.txbCorreoCliente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbCorreoCliente.UseSystemPasswordChar = false;
            // 
            // txbMovil
            // 
            this.txbMovil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbMovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbMovil.Depth = 0;
            this.txbMovil.Hint = "";
            this.txbMovil.Location = new System.Drawing.Point(537, 345);
            this.txbMovil.MaxLength = 32767;
            this.txbMovil.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbMovil.Name = "txbMovil";
            this.txbMovil.PasswordChar = '\0';
            this.txbMovil.ReadOnly = true;
            this.txbMovil.SelectedText = "";
            this.txbMovil.SelectionLength = 0;
            this.txbMovil.SelectionStart = 0;
            this.txbMovil.Size = new System.Drawing.Size(218, 23);
            this.txbMovil.TabIndex = 25;
            this.txbMovil.TabStop = false;
            this.txbMovil.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbMovil.UseSystemPasswordChar = false;
            // 
            // txbExtension
            // 
            this.txbExtension.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbExtension.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbExtension.Depth = 0;
            this.txbExtension.Hint = "";
            this.txbExtension.Location = new System.Drawing.Point(447, 345);
            this.txbExtension.MaxLength = 32767;
            this.txbExtension.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbExtension.Name = "txbExtension";
            this.txbExtension.PasswordChar = '\0';
            this.txbExtension.ReadOnly = true;
            this.txbExtension.SelectedText = "";
            this.txbExtension.SelectionLength = 0;
            this.txbExtension.SelectionStart = 0;
            this.txbExtension.Size = new System.Drawing.Size(66, 23);
            this.txbExtension.TabIndex = 23;
            this.txbExtension.TabStop = false;
            this.txbExtension.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbExtension.UseSystemPasswordChar = false;
            // 
            // txbTelefono
            // 
            this.txbTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbTelefono.Depth = 0;
            this.txbTelefono.Hint = "";
            this.txbTelefono.Location = new System.Drawing.Point(295, 345);
            this.txbTelefono.MaxLength = 32767;
            this.txbTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.PasswordChar = '\0';
            this.txbTelefono.ReadOnly = true;
            this.txbTelefono.SelectedText = "";
            this.txbTelefono.SelectionLength = 0;
            this.txbTelefono.SelectionStart = 0;
            this.txbTelefono.Size = new System.Drawing.Size(149, 23);
            this.txbTelefono.TabIndex = 21;
            this.txbTelefono.TabStop = false;
            this.txbTelefono.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbTelefono.UseSystemPasswordChar = false;
            // 
            // txbAMaterno
            // 
            this.txbAMaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbAMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbAMaterno.Depth = 0;
            this.txbAMaterno.Hint = "";
            this.txbAMaterno.Location = new System.Drawing.Point(787, 226);
            this.txbAMaterno.MaxLength = 32767;
            this.txbAMaterno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbAMaterno.Name = "txbAMaterno";
            this.txbAMaterno.PasswordChar = '\0';
            this.txbAMaterno.ReadOnly = true;
            this.txbAMaterno.SelectedText = "";
            this.txbAMaterno.SelectionLength = 0;
            this.txbAMaterno.SelectionStart = 0;
            this.txbAMaterno.Size = new System.Drawing.Size(218, 23);
            this.txbAMaterno.TabIndex = 13;
            this.txbAMaterno.TabStop = false;
            this.txbAMaterno.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbAMaterno.UseSystemPasswordChar = false;
            // 
            // txbAPaterno
            // 
            this.txbAPaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbAPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbAPaterno.Depth = 0;
            this.txbAPaterno.Hint = "";
            this.txbAPaterno.Location = new System.Drawing.Point(536, 225);
            this.txbAPaterno.MaxLength = 32767;
            this.txbAPaterno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbAPaterno.Name = "txbAPaterno";
            this.txbAPaterno.PasswordChar = '\0';
            this.txbAPaterno.ReadOnly = true;
            this.txbAPaterno.SelectedText = "";
            this.txbAPaterno.SelectionLength = 0;
            this.txbAPaterno.SelectionStart = 0;
            this.txbAPaterno.Size = new System.Drawing.Size(218, 23);
            this.txbAPaterno.TabIndex = 11;
            this.txbAPaterno.TabStop = false;
            this.txbAPaterno.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbAPaterno.UseSystemPasswordChar = false;
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbNombre.Depth = 0;
            this.txbNombre.Hint = "";
            this.txbNombre.Location = new System.Drawing.Point(295, 226);
            this.txbNombre.MaxLength = 32767;
            this.txbNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.PasswordChar = '\0';
            this.txbNombre.ReadOnly = true;
            this.txbNombre.SelectedText = "";
            this.txbNombre.SelectionLength = 0;
            this.txbNombre.SelectionStart = 0;
            this.txbNombre.Size = new System.Drawing.Size(218, 23);
            this.txbNombre.TabIndex = 9;
            this.txbNombre.TabStop = false;
            this.txbNombre.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbNombre.UseSystemPasswordChar = false;
            // 
            // txbCurp
            // 
            this.txbCurp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbCurp.Depth = 0;
            this.txbCurp.Hint = "";
            this.txbCurp.Location = new System.Drawing.Point(536, 286);
            this.txbCurp.MaxLength = 32767;
            this.txbCurp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbCurp.Name = "txbCurp";
            this.txbCurp.PasswordChar = '\0';
            this.txbCurp.ReadOnly = true;
            this.txbCurp.SelectedText = "";
            this.txbCurp.SelectionLength = 0;
            this.txbCurp.SelectionStart = 0;
            this.txbCurp.Size = new System.Drawing.Size(218, 23);
            this.txbCurp.TabIndex = 17;
            this.txbCurp.TabStop = false;
            this.txbCurp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbCurp.UseSystemPasswordChar = false;
            // 
            // txbRfc
            // 
            this.txbRfc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbRfc.Depth = 0;
            this.txbRfc.Hint = "";
            this.txbRfc.Location = new System.Drawing.Point(295, 286);
            this.txbRfc.MaxLength = 32767;
            this.txbRfc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbRfc.Name = "txbRfc";
            this.txbRfc.PasswordChar = '\0';
            this.txbRfc.ReadOnly = true;
            this.txbRfc.SelectedText = "";
            this.txbRfc.SelectionLength = 0;
            this.txbRfc.SelectionStart = 0;
            this.txbRfc.Size = new System.Drawing.Size(218, 23);
            this.txbRfc.TabIndex = 15;
            this.txbRfc.TabStop = false;
            this.txbRfc.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbRfc.UseSystemPasswordChar = false;
            // 
            // ckbActivo
            // 
            this.ckbActivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Depth = 0;
            this.ckbActivo.Enabled = false;
            this.ckbActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckbActivo.Location = new System.Drawing.Point(160, 312);
            this.ckbActivo.Margin = new System.Windows.Forms.Padding(0);
            this.ckbActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Ripple = true;
            this.ckbActivo.Size = new System.Drawing.Size(69, 30);
            this.ckbActivo.TabIndex = 7;
            this.ckbActivo.Text = "Activo";
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // materialLabel17
            // 
            this.materialLabel17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(783, 260);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(138, 19);
            this.materialLabel17.TabIndex = 18;
            this.materialLabel17.Text = "Contador Asignado";
            this.materialLabel17.Visible = false;
            // 
            // materialLabel16
            // 
            this.materialLabel16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(783, 323);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(136, 19);
            this.materialLabel16.TabIndex = 26;
            this.materialLabel16.Text = "Correo Electrónico";
            // 
            // materialLabel15
            // 
            this.materialLabel15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(533, 323);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(46, 19);
            this.materialLabel15.TabIndex = 24;
            this.materialLabel15.Text = "Móvil";
            // 
            // materialLabel14
            // 
            this.materialLabel14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(450, 323);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(34, 19);
            this.materialLabel14.TabIndex = 22;
            this.materialLabel14.Text = "Ext.";
            // 
            // materialLabel13
            // 
            this.materialLabel13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(291, 323);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(69, 19);
            this.materialLabel13.TabIndex = 20;
            this.materialLabel13.Text = "Teléfono";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(783, 203);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(124, 19);
            this.materialLabel7.TabIndex = 12;
            this.materialLabel7.Text = "Apellido Materno";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(532, 204);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(120, 19);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "Apellido Paterno";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(291, 204);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(63, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Nombre";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(532, 264);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "CURP";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(291, 264);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(36, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "RFC";
            // 
            // lblMensajeBusqueda
            // 
            this.lblMensajeBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMensajeBusqueda.AutoSize = true;
            this.lblMensajeBusqueda.ForeColor = System.Drawing.Color.Maroon;
            this.lblMensajeBusqueda.Location = new System.Drawing.Point(395, 134);
            this.lblMensajeBusqueda.Name = "lblMensajeBusqueda";
            this.lblMensajeBusqueda.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeBusqueda.TabIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelControl1.Controls.Add(this.panel3);
            this.panelControl1.Location = new System.Drawing.Point(31, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1177, 613);
            this.panelControl1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.btnAsignarObligaciones);
            this.panel3.Controls.Add(this.lnkBuscar);
            this.panel3.Controls.Add(this.lblProgress);
            this.panel3.Controls.Add(this.lollipopButton1);
            this.panel3.Controls.Add(this.ptbLoader);
            this.panel3.Controls.Add(this.ovalPictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbContaAsig);
            this.panel3.Controls.Add(this.txtNoCliente);
            this.panel3.Controls.Add(this.txbCorreoCliente);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.txbMovil);
            this.panel3.Controls.Add(this.materialLabel1);
            this.panel3.Controls.Add(this.txbExtension);
            this.panel3.Controls.Add(this.lblMensajeBusqueda);
            this.panel3.Controls.Add(this.txbTelefono);
            this.panel3.Controls.Add(this.materialLabel5);
            this.panel3.Controls.Add(this.txbAMaterno);
            this.panel3.Controls.Add(this.materialLabel3);
            this.panel3.Controls.Add(this.txbAPaterno);
            this.panel3.Controls.Add(this.materialLabel4);
            this.panel3.Controls.Add(this.txbNombre);
            this.panel3.Controls.Add(this.materialLabel6);
            this.panel3.Controls.Add(this.txbCurp);
            this.panel3.Controls.Add(this.materialLabel7);
            this.panel3.Controls.Add(this.txbRfc);
            this.panel3.Controls.Add(this.materialLabel13);
            this.panel3.Controls.Add(this.ckbActivo);
            this.panel3.Controls.Add(this.materialLabel14);
            this.panel3.Controls.Add(this.materialLabel17);
            this.panel3.Controls.Add(this.materialLabel15);
            this.panel3.Controls.Add(this.materialLabel16);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1173, 609);
            this.panel3.TabIndex = 0;
            // 
            // btnAsignarObligaciones
            // 
            this.btnAsignarObligaciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAsignarObligaciones.BGColor = "#304FFE";
            this.btnAsignarObligaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarObligaciones.Depth = 0;
            this.btnAsignarObligaciones.Enabled = false;
            this.btnAsignarObligaciones.Icon = null;
            this.btnAsignarObligaciones.Location = new System.Drawing.Point(743, 396);
            this.btnAsignarObligaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsignarObligaciones.Name = "btnAsignarObligaciones";
            this.btnAsignarObligaciones.Primary = true;
            this.btnAsignarObligaciones.Size = new System.Drawing.Size(155, 23);
            this.btnAsignarObligaciones.TabIndex = 108;
            this.btnAsignarObligaciones.Text = "Asignar Obligaciones";
            this.btnAsignarObligaciones.UseVisualStyleBackColor = true;
            this.btnAsignarObligaciones.Click += new System.EventHandler(this.btnAsignarObligaciones_Click);
            // 
            // lnkBuscar
            // 
            this.lnkBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnkBuscar.BGColor = "#304FFE";
            this.lnkBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkBuscar.Depth = 0;
            this.lnkBuscar.Icon = null;
            this.lnkBuscar.Location = new System.Drawing.Point(373, 124);
            this.lnkBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lnkBuscar.Name = "lnkBuscar";
            this.lnkBuscar.Primary = true;
            this.lnkBuscar.Size = new System.Drawing.Size(75, 23);
            this.lnkBuscar.TabIndex = 107;
            this.lnkBuscar.Text = "Buscar";
            this.lnkBuscar.UseVisualStyleBackColor = true;
            this.lnkBuscar.Click += new System.EventHandler(this.lnkBuscar_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProgress.Depth = 0;
            this.lblProgress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProgress.ForeColor = System.Drawing.Color.Gray;
            this.lblProgress.Location = new System.Drawing.Point(125, 483);
            this.lblProgress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(897, 19);
            this.lblProgress.TabIndex = 31;
            this.lblProgress.Text = "--";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProgress.Visible = false;
            // 
            // lollipopButton1
            // 
            this.lollipopButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton1.BGColor = "#558B2F";
            this.lollipopButton1.FontColor = "#ffffff";
            this.lollipopButton1.Location = new System.Drawing.Point(148, 181);
            this.lollipopButton1.Name = "lollipopButton1";
            this.lollipopButton1.Size = new System.Drawing.Size(81, 15);
            this.lollipopButton1.TabIndex = 6;
            this.lollipopButton1.Text = "Información";
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ovalPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.ovalPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ovalPictureBox1.Location = new System.Drawing.Point(160, 218);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(91, 91);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox1.TabIndex = 106;
            this.ovalPictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FontColor = "#D32F2F";
            this.btnCancelar.Location = new System.Drawing.Point(914, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 23);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmAsignarObligaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1229, 648);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmAsignarObligaciones";
            this.Text = "frmAsignarObligaciones";
            this.ptbLoader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNoCliente;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Label lblMensajeBusqueda;
        private MetroFramework.Controls.MetroComboBox cbContaAsig;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbCorreoCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbMovil;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbExtension;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbAMaterno;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbAPaterno;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbCurp;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbRfc;
        private MaterialSkin.Controls.MaterialCheckBox ckbActivo;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private LollipopFlatButton btnCancelar;
        private OvalPictureBox ovalPictureBox1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.Panel panel3;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel ptbLoader;
        private LollipopLabel lbProgress;
        private MetroFramework.Controls.MetroProgressSpinner pgbDescarga;
        private LollipopButton lollipopButton1;
        private MaterialSkin.Controls.MaterialLabel lblProgress;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom lnkBuscar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnAsignarObligaciones;
    }
}