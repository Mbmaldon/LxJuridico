namespace LxCallcenter.LexaSIOConta
{
    partial class frmEditarDeclaracion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdConceptos = new MetroFramework.Controls.MetroGrid();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpFechaPago = new MetroFramework.Controls.MetroDateTime();
            this.dpFPresentacion = new MetroFramework.Controls.MetroDateTime();
            this.pnlDeclaraciones = new System.Windows.Forms.Panel();
            this.openFileDialogDocumento = new System.Windows.Forms.OpenFileDialog();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lnkCerrar = new MetroFramework.Controls.MetroLink();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dtFechaPago = new MetroFramework.Controls.MetroDateTime();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.cbEstadoPago = new MaterialSkin.Controls.MaterialComboBox();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.txtRutaArchivo = new LollipopSmallCard();
            this.lblAño = new MaterialSkin.Controls.MaterialLabel();
            this.txbMonto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblNumOperacion = new MaterialSkin.Controls.MaterialLabel();
            this.txtPeriodo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbNumOperacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblPeriodo = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTipoDeclaracion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFPresentacion = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDecTipo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbLCaptura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblLlavePago = new MaterialSkin.Controls.MaterialLabel();
            this.lblDecTipo = new MaterialSkin.Controls.MaterialLabel();
            this.lblLCaptura = new MaterialSkin.Controls.MaterialLabel();
            this.txbLlavePago = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbAño = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.pgbCarga = new System.Windows.Forms.PictureBox();
            this.bgwDeclaracion = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.grdConceptos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // grdConceptos
            // 
            this.grdConceptos.AllowUserToAddRows = false;
            this.grdConceptos.AllowUserToDeleteRows = false;
            this.grdConceptos.AllowUserToResizeRows = false;
            this.grdConceptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdConceptos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdConceptos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdConceptos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
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
            this.Column3,
            this.Column1,
            this.sEstado,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdConceptos.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdConceptos.EnableHeadersVisualStyles = false;
            this.grdConceptos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdConceptos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdConceptos.Location = new System.Drawing.Point(52, 367);
            this.grdConceptos.Name = "grdConceptos";
            this.grdConceptos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConceptos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdConceptos.RowHeadersVisible = false;
            this.grdConceptos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdConceptos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConceptos.Size = new System.Drawing.Size(947, 104);
            this.grdConceptos.TabIndex = 29;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "iIdConcepto";
            this.Column3.HeaderText = "IdConcepto";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sConcepto";
            this.Column1.HeaderText = "Concepto";
            this.Column1.Name = "Column1";
            // 
            // sEstado
            // 
            this.sEstado.DataPropertyName = "sEstado";
            this.sEstado.HeaderText = "Estado";
            this.sEstado.Name = "sEstado";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "dMonto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Cargo";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dActualizacion";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Actualización";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "dRecargos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "Recargos";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "dMultas";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column6.HeaderText = "Multas";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "dTotal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column7.HeaderText = "Total";
            this.Column7.Name = "Column7";
            // 
            // dpFechaPago
            // 
            this.dpFechaPago.Enabled = false;
            this.dpFechaPago.Location = new System.Drawing.Point(249, 296);
            this.dpFechaPago.MinimumSize = new System.Drawing.Size(0, 29);
            this.dpFechaPago.Name = "dpFechaPago";
            this.dpFechaPago.Size = new System.Drawing.Size(215, 29);
            this.dpFechaPago.TabIndex = 24;
            // 
            // dpFPresentacion
            // 
            this.dpFPresentacion.Enabled = false;
            this.dpFPresentacion.Location = new System.Drawing.Point(51, 296);
            this.dpFPresentacion.MinimumSize = new System.Drawing.Size(0, 29);
            this.dpFPresentacion.Name = "dpFPresentacion";
            this.dpFPresentacion.Size = new System.Drawing.Size(166, 29);
            this.dpFPresentacion.TabIndex = 22;
            // 
            // pnlDeclaraciones
            // 
            this.pnlDeclaraciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDeclaraciones.AutoScroll = true;
            this.pnlDeclaraciones.Location = new System.Drawing.Point(44, 50);
            this.pnlDeclaraciones.Name = "pnlDeclaraciones";
            this.pnlDeclaraciones.Size = new System.Drawing.Size(976, 80);
            this.pnlDeclaraciones.TabIndex = 2;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lnkCerrar
            // 
            this.lnkCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.lnkCerrar.Image = global::LxCallcenter.Properties.Resources.delete_sign_filled_23px;
            this.lnkCerrar.ImageSize = 25;
            this.lnkCerrar.Location = new System.Drawing.Point(1036, 6);
            this.lnkCerrar.Name = "lnkCerrar";
            this.lnkCerrar.NoFocusImage = global::LxCallcenter.Properties.Resources.delete_sign_23px;
            this.lnkCerrar.Size = new System.Drawing.Size(25, 25);
            this.lnkCerrar.TabIndex = 37;
            this.metroToolTip1.SetToolTip(this.lnkCerrar, "Cerrar");
            this.lnkCerrar.UseSelectable = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(488, 276);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(109, 19);
            this.materialLabel6.TabIndex = 25;
            this.materialLabel6.Text = "Fecha de Pago";
            this.materialLabel6.Visible = false;
            // 
            // dtFechaPago
            // 
            this.dtFechaPago.Location = new System.Drawing.Point(492, 296);
            this.dtFechaPago.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFechaPago.Name = "dtFechaPago";
            this.dtFechaPago.Size = new System.Drawing.Size(267, 29);
            this.dtFechaPago.TabIndex = 26;
            this.dtFechaPago.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(44, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 17);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(3, -2);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Declaraciones Pendientes";
            // 
            // cbEstadoPago
            // 
            this.cbEstadoPago.DataSource = null;
            this.cbEstadoPago.Depth = 0;
            this.cbEstadoPago.DisplayMember = "";
            this.cbEstadoPago.DropDownWidth = 163;
            this.cbEstadoPago.Hint = "";
            this.cbEstadoPago.Location = new System.Drawing.Point(51, 239);
            this.cbEstadoPago.MaxLength = 0;
            this.cbEstadoPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbEstadoPago.Name = "cbEstadoPago";
            this.cbEstadoPago.PasswordChar = '\0';
            this.cbEstadoPago.SelectedIndex = -1;
            this.cbEstadoPago.SelectedItem = null;
            this.cbEstadoPago.SelectedText = "";
            this.cbEstadoPago.SelectedValue = null;
            this.cbEstadoPago.Size = new System.Drawing.Size(163, 29);
            this.cbEstadoPago.TabIndex = 14;
            this.cbEstadoPago.TabStop = false;
            this.cbEstadoPago.UseSystemPasswordChar = false;
            this.cbEstadoPago.ValueMember = "";
            this.cbEstadoPago.SelectionChangeCommitted += new System.EventHandler(this.cbEstadoPago_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(34, 9);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(34, 127);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(988, 18);
            this.separatorControl1.TabIndex = 3;
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRutaArchivo.FontColor = "#3f51b5";
            this.txtRutaArchivo.Image = global::LxCallcenter.Properties.Resources.file_48px;
            this.txtRutaArchivo.Info = "Adjunto";
            this.txtRutaArchivo.Location = new System.Drawing.Point(52, 517);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(201, 52);
            this.txtRutaArchivo.TabIndex = 34;
            this.txtRutaArchivo.Text = "Seleccionar Archivo";
            this.txtRutaArchivo.ThumbnailColor = "#3f51b5";
            this.txtRutaArchivo.Visible = false;
            this.txtRutaArchivo.Click += new System.EventHandler(this.txtRutaArchivo_Click);
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Depth = 0;
            this.lblAño.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblAño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAño.Location = new System.Drawing.Point(48, 164);
            this.lblAño.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(120, 19);
            this.lblAño.TabIndex = 5;
            this.lblAño.Text = "Año Declaración";
            // 
            // txbMonto
            // 
            this.txbMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbMonto.Depth = 0;
            this.txbMonto.Hint = "";
            this.txbMonto.Location = new System.Drawing.Point(832, 475);
            this.txbMonto.MaxLength = 32767;
            this.txbMonto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.PasswordChar = '\0';
            this.txbMonto.ReadOnly = true;
            this.txbMonto.SelectedText = "";
            this.txbMonto.SelectionLength = 0;
            this.txbMonto.SelectionStart = 0;
            this.txbMonto.Size = new System.Drawing.Size(166, 25);
            this.txbMonto.TabIndex = 31;
            this.txbMonto.TabStop = false;
            this.txbMonto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbMonto.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(728, 479);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(100, 19);
            this.materialLabel1.TabIndex = 30;
            this.materialLabel1.Text = "Total a Pagar";
            // 
            // lblNumOperacion
            // 
            this.lblNumOperacion.AutoSize = true;
            this.lblNumOperacion.Depth = 0;
            this.lblNumOperacion.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblNumOperacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumOperacion.Location = new System.Drawing.Point(246, 220);
            this.lblNumOperacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumOperacion.Name = "lblNumOperacion";
            this.lblNumOperacion.Size = new System.Drawing.Size(155, 19);
            this.lblNumOperacion.TabIndex = 15;
            this.lblNumOperacion.Text = "Número de Operación";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPeriodo.Depth = 0;
            this.txtPeriodo.Enabled = false;
            this.txtPeriodo.Hint = "";
            this.txtPeriodo.Location = new System.Drawing.Point(788, 186);
            this.txtPeriodo.MaxLength = 32767;
            this.txtPeriodo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.PasswordChar = '\0';
            this.txtPeriodo.ReadOnly = false;
            this.txtPeriodo.SelectedText = "";
            this.txtPeriodo.SelectionLength = 0;
            this.txtPeriodo.SelectionStart = 0;
            this.txtPeriodo.Size = new System.Drawing.Size(215, 25);
            this.txtPeriodo.TabIndex = 12;
            this.txtPeriodo.TabStop = false;
            this.txtPeriodo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPeriodo.UseSystemPasswordChar = false;
            // 
            // txbNumOperacion
            // 
            this.txbNumOperacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbNumOperacion.Depth = 0;
            this.txbNumOperacion.Enabled = false;
            this.txbNumOperacion.Hint = "";
            this.txbNumOperacion.Location = new System.Drawing.Point(249, 242);
            this.txbNumOperacion.MaxLength = 32767;
            this.txbNumOperacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbNumOperacion.Name = "txbNumOperacion";
            this.txbNumOperacion.PasswordChar = '\0';
            this.txbNumOperacion.ReadOnly = false;
            this.txbNumOperacion.SelectedText = "";
            this.txbNumOperacion.SelectionLength = 0;
            this.txbNumOperacion.SelectionStart = 0;
            this.txbNumOperacion.Size = new System.Drawing.Size(215, 25);
            this.txbNumOperacion.TabIndex = 16;
            this.txbNumOperacion.TabStop = false;
            this.txbNumOperacion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbNumOperacion.UseSystemPasswordChar = false;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Depth = 0;
            this.lblPeriodo.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPeriodo.Location = new System.Drawing.Point(785, 164);
            this.lblPeriodo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(62, 19);
            this.lblPeriodo.TabIndex = 11;
            this.lblPeriodo.Text = "Periódo";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(245, 276);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(155, 19);
            this.materialLabel2.TabIndex = 23;
            this.materialLabel2.Text = "Fecha Límite de Pago";
            // 
            // txtTipoDeclaracion
            // 
            this.txtTipoDeclaracion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTipoDeclaracion.Depth = 0;
            this.txtTipoDeclaracion.Enabled = false;
            this.txtTipoDeclaracion.Hint = "";
            this.txtTipoDeclaracion.Location = new System.Drawing.Point(250, 186);
            this.txtTipoDeclaracion.MaxLength = 32767;
            this.txtTipoDeclaracion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTipoDeclaracion.Name = "txtTipoDeclaracion";
            this.txtTipoDeclaracion.PasswordChar = '\0';
            this.txtTipoDeclaracion.ReadOnly = false;
            this.txtTipoDeclaracion.SelectedText = "";
            this.txtTipoDeclaracion.SelectionLength = 0;
            this.txtTipoDeclaracion.SelectionStart = 0;
            this.txtTipoDeclaracion.Size = new System.Drawing.Size(214, 25);
            this.txtTipoDeclaracion.TabIndex = 8;
            this.txtTipoDeclaracion.TabStop = false;
            this.txtTipoDeclaracion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTipoDeclaracion.UseSystemPasswordChar = false;
            // 
            // lblFPresentacion
            // 
            this.lblFPresentacion.AutoSize = true;
            this.lblFPresentacion.Depth = 0;
            this.lblFPresentacion.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblFPresentacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFPresentacion.Location = new System.Drawing.Point(47, 276);
            this.lblFPresentacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFPresentacion.Name = "lblFPresentacion";
            this.lblFPresentacion.Size = new System.Drawing.Size(162, 19);
            this.lblFPresentacion.TabIndex = 21;
            this.lblFPresentacion.Text = "Fecha de Presentación";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(246, 164);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(143, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Tipo de Declaración";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(48, 216);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(115, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Estado de Pago";
            // 
            // txtDecTipo
            // 
            this.txtDecTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDecTipo.Depth = 0;
            this.txtDecTipo.Enabled = false;
            this.txtDecTipo.Hint = "";
            this.txtDecTipo.Location = new System.Drawing.Point(494, 187);
            this.txtDecTipo.MaxLength = 32767;
            this.txtDecTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDecTipo.Name = "txtDecTipo";
            this.txtDecTipo.PasswordChar = '\0';
            this.txtDecTipo.ReadOnly = false;
            this.txtDecTipo.SelectedText = "";
            this.txtDecTipo.SelectionLength = 0;
            this.txtDecTipo.SelectionStart = 0;
            this.txtDecTipo.Size = new System.Drawing.Size(265, 25);
            this.txtDecTipo.TabIndex = 10;
            this.txtDecTipo.TabStop = false;
            this.txtDecTipo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDecTipo.UseSystemPasswordChar = false;
            // 
            // txbLCaptura
            // 
            this.txbLCaptura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbLCaptura.Depth = 0;
            this.txbLCaptura.Enabled = false;
            this.txbLCaptura.Hint = "";
            this.txbLCaptura.Location = new System.Drawing.Point(492, 242);
            this.txbLCaptura.MaxLength = 32767;
            this.txbLCaptura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbLCaptura.Name = "txbLCaptura";
            this.txbLCaptura.PasswordChar = '\0';
            this.txbLCaptura.ReadOnly = false;
            this.txbLCaptura.SelectedText = "";
            this.txbLCaptura.SelectionLength = 0;
            this.txbLCaptura.SelectionStart = 0;
            this.txbLCaptura.Size = new System.Drawing.Size(267, 25);
            this.txbLCaptura.TabIndex = 18;
            this.txbLCaptura.TabStop = false;
            this.txbLCaptura.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbLCaptura.UseSystemPasswordChar = false;
            // 
            // lblLlavePago
            // 
            this.lblLlavePago.AutoSize = true;
            this.lblLlavePago.Depth = 0;
            this.lblLlavePago.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblLlavePago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLlavePago.Location = new System.Drawing.Point(785, 220);
            this.lblLlavePago.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLlavePago.Name = "lblLlavePago";
            this.lblLlavePago.Size = new System.Drawing.Size(104, 19);
            this.lblLlavePago.TabIndex = 19;
            this.lblLlavePago.Text = "Llave de Pago";
            // 
            // lblDecTipo
            // 
            this.lblDecTipo.AutoSize = true;
            this.lblDecTipo.Depth = 0;
            this.lblDecTipo.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblDecTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDecTipo.Location = new System.Drawing.Point(490, 164);
            this.lblDecTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDecTipo.Name = "lblDecTipo";
            this.lblDecTipo.Size = new System.Drawing.Size(89, 19);
            this.lblDecTipo.TabIndex = 9;
            this.lblDecTipo.Text = "Declaración";
            // 
            // lblLCaptura
            // 
            this.lblLCaptura.AutoSize = true;
            this.lblLCaptura.Depth = 0;
            this.lblLCaptura.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblLCaptura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLCaptura.Location = new System.Drawing.Point(490, 220);
            this.lblLCaptura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLCaptura.Name = "lblLCaptura";
            this.lblLCaptura.Size = new System.Drawing.Size(121, 19);
            this.lblLCaptura.TabIndex = 17;
            this.lblLCaptura.Text = "Línea de Captura";
            // 
            // txbLlavePago
            // 
            this.txbLlavePago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbLlavePago.Depth = 0;
            this.txbLlavePago.Hint = "";
            this.txbLlavePago.Location = new System.Drawing.Point(784, 242);
            this.txbLlavePago.MaxLength = 32767;
            this.txbLlavePago.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbLlavePago.Name = "txbLlavePago";
            this.txbLlavePago.PasswordChar = '\0';
            this.txbLlavePago.ReadOnly = false;
            this.txbLlavePago.SelectedText = "";
            this.txbLlavePago.SelectionLength = 0;
            this.txbLlavePago.SelectionStart = 0;
            this.txbLlavePago.Size = new System.Drawing.Size(215, 25);
            this.txbLlavePago.TabIndex = 20;
            this.txbLlavePago.TabStop = false;
            this.txbLlavePago.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbLlavePago.UseSystemPasswordChar = false;
            // 
            // txbAño
            // 
            this.txbAño.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbAño.Depth = 0;
            this.txbAño.Enabled = false;
            this.txbAño.Hint = "";
            this.txbAño.Location = new System.Drawing.Point(52, 187);
            this.txbAño.MaxLength = 32767;
            this.txbAño.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbAño.Name = "txbAño";
            this.txbAño.PasswordChar = '\0';
            this.txbAño.ReadOnly = false;
            this.txbAño.SelectedText = "";
            this.txbAño.SelectionLength = 0;
            this.txbAño.SelectionStart = 0;
            this.txbAño.Size = new System.Drawing.Size(166, 25);
            this.txbAño.TabIndex = 6;
            this.txbAño.TabStop = false;
            this.txbAño.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbAño.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::LxCallcenter.Properties.Resources.circled_user_male_skin_type_1_2_96px;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 248;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(24, 142);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "DECLARACIÓN";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.materialLabel11.Location = new System.Drawing.Point(24, 334);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(102, 19);
            this.materialLabel11.TabIndex = 27;
            this.materialLabel11.Text = "DESPLEGADO";
            // 
            // separatorControl2
            // 
            this.separatorControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.separatorControl2.Location = new System.Drawing.Point(12, 349);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(1043, 18);
            this.separatorControl2.TabIndex = 28;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.materialLabel12.Location = new System.Drawing.Point(24, 486);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(163, 19);
            this.materialLabel12.TabIndex = 32;
            this.materialLabel12.Text = "ARCHIVOS ADJUNTOS";
            // 
            // separatorControl3
            // 
            this.separatorControl3.Location = new System.Drawing.Point(12, 500);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(1043, 18);
            this.separatorControl3.TabIndex = 33;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BGColor = "#3f51b5";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(836, 549);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(98, 23);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BGColor = "#B71C1C";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(942, 549);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pgbCarga
            // 
            this.pgbCarga.Image = global::LxCallcenter.Properties.Resources._7a8cbb7079d70bd64c469435a71b4db9;
            this.pgbCarga.Location = new System.Drawing.Point(865, 539);
            this.pgbCarga.Name = "pgbCarga";
            this.pgbCarga.Size = new System.Drawing.Size(40, 41);
            this.pgbCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pgbCarga.TabIndex = 256;
            this.pgbCarga.TabStop = false;
            this.pgbCarga.Visible = false;
            // 
            // bgwDeclaracion
            // 
            this.bgwDeclaracion.WorkerReportsProgress = true;
            this.bgwDeclaracion.WorkerSupportsCancellation = true;
            this.bgwDeclaracion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDeclaracion_DoWork);
            this.bgwDeclaracion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDeclaracion_RunWorkerCompleted);
            // 
            // frmEditarDeclaracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.lnkCerrar;
            this.ClientSize = new System.Drawing.Size(1067, 587);
            this.Controls.Add(this.lnkCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pgbCarga);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.separatorControl3);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.dtFechaPago);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbAño);
            this.Controls.Add(this.cbEstadoPago);
            this.Controls.Add(this.txbLlavePago);
            this.Controls.Add(this.lblLCaptura);
            this.Controls.Add(this.lblDecTipo);
            this.Controls.Add(this.lblLlavePago);
            this.Controls.Add(this.txbLCaptura);
            this.Controls.Add(this.txtDecTipo);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lblFPresentacion);
            this.Controls.Add(this.pnlDeclaraciones);
            this.Controls.Add(this.dpFechaPago);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.txtTipoDeclaracion);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.dpFPresentacion);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.grdConceptos);
            this.Controls.Add(this.txbMonto);
            this.Controls.Add(this.txbNumOperacion);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblNumOperacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarDeclaracion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmEditarDeclaracion";
            ((System.ComponentModel.ISupportInitialize)(this.grdConceptos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbCarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlDeclaraciones;
        private System.Windows.Forms.OpenFileDialog openFileDialogDocumento;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbAño;
        private MaterialSkin.Controls.MaterialLabel lblAño;
        private MaterialSkin.Controls.MaterialLabel lblDecTipo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDecTipo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbNumOperacion;
        private MaterialSkin.Controls.MaterialLabel lblNumOperacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbMonto;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPeriodo;
        private MaterialSkin.Controls.MaterialLabel lblPeriodo;
        private MetroFramework.Controls.MetroDateTime dpFPresentacion;
        private MaterialSkin.Controls.MaterialLabel lblFPresentacion;
        private MetroFramework.Controls.MetroDateTime dpFechaPago;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbLlavePago;
        private MaterialSkin.Controls.MaterialLabel lblLlavePago;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbLCaptura;
        private MaterialSkin.Controls.MaterialLabel lblLCaptura;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTipoDeclaracion;
        private MetroFramework.Controls.MetroGrid grdConceptos;
		private LollipopSmallCard txtRutaArchivo;
		private DevExpress.XtraEditors.SeparatorControl separatorControl1;
		private MaterialSkin.Controls.MaterialLabel lblNombre;
		private MaterialSkin.Controls.MaterialComboBox cbEstadoPago;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MetroFramework.Controls.MetroDateTime dtFechaPago;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnGuardar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCancelar;
        private System.Windows.Forms.PictureBox pgbCarga;
        private MetroFramework.Controls.MetroLink lnkCerrar;
        private System.ComponentModel.BackgroundWorker bgwDeclaracion;
    }
}