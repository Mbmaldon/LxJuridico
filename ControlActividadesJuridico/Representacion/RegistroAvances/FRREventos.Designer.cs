namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    partial class FRREventos
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
            this.dtpTerminoInterno = new MetroFramework.Controls.MetroDateTime();
            this.dtpTeminoLegal = new MetroFramework.Controls.MetroDateTime();
            this.btnAddTarea = new System.Windows.Forms.Button();
            this.btnAddEvento = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.openFileDialogDocumento = new System.Windows.Forms.OpenFileDialog();
            this.frm1 = new DevExpress.XtraEditors.PanelControl();
            this.frm2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.btnRegistrarE = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbTarea = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbEvento = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCargarArchivo = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.cbhActivarCampos = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumExp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtJuzgado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTJuicio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContraparte = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.pnlAdd = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.txtAdd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnAddCanc = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).BeginInit();
            this.frm1.SuspendLayout();
            this.frm2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAdd)).BeginInit();
            this.pnlAdd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpTerminoInterno
            // 
            this.dtpTerminoInterno.Enabled = false;
            this.dtpTerminoInterno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTerminoInterno.Location = new System.Drawing.Point(195, 320);
            this.dtpTerminoInterno.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpTerminoInterno.Name = "dtpTerminoInterno";
            this.dtpTerminoInterno.Size = new System.Drawing.Size(143, 29);
            this.dtpTerminoInterno.Style = MetroFramework.MetroColorStyle.Green;
            this.dtpTerminoInterno.TabIndex = 130;
            // 
            // dtpTeminoLegal
            // 
            this.dtpTeminoLegal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTeminoLegal.Location = new System.Drawing.Point(195, 283);
            this.dtpTeminoLegal.MinDate = new System.DateTime(2018, 1, 3, 0, 0, 0, 0);
            this.dtpTeminoLegal.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpTeminoLegal.Name = "dtpTeminoLegal";
            this.dtpTeminoLegal.Size = new System.Drawing.Size(143, 29);
            this.dtpTeminoLegal.Style = MetroFramework.MetroColorStyle.Green;
            this.dtpTeminoLegal.TabIndex = 130;
            this.dtpTeminoLegal.ValueChanged += new System.EventHandler(this.dtpTeminoLegal_ValueChanged);
            // 
            // btnAddTarea
            // 
            this.btnAddTarea.Enabled = false;
            this.btnAddTarea.FlatAppearance.BorderSize = 0;
            this.btnAddTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTarea.Image = global::ControlActividadesJuridico.Properties.Resources.plus_20px;
            this.btnAddTarea.Location = new System.Drawing.Point(521, 249);
            this.btnAddTarea.Name = "btnAddTarea";
            this.btnAddTarea.Size = new System.Drawing.Size(23, 23);
            this.btnAddTarea.TabIndex = 35;
            this.metroToolTip1.SetToolTip(this.btnAddTarea, "Agregar Tarea");
            this.btnAddTarea.UseVisualStyleBackColor = true;
            this.btnAddTarea.Click += new System.EventHandler(this.btnAddTarea_Click);
            // 
            // btnAddEvento
            // 
            this.btnAddEvento.FlatAppearance.BorderSize = 0;
            this.btnAddEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvento.ForeColor = System.Drawing.Color.Black;
            this.btnAddEvento.Image = global::ControlActividadesJuridico.Properties.Resources.plus_20px;
            this.btnAddEvento.Location = new System.Drawing.Point(521, 213);
            this.btnAddEvento.Name = "btnAddEvento";
            this.btnAddEvento.Size = new System.Drawing.Size(23, 23);
            this.btnAddEvento.TabIndex = 34;
            this.metroToolTip1.SetToolTip(this.btnAddEvento, "Agregar Evento");
            this.btnAddEvento.UseVisualStyleBackColor = true;
            this.btnAddEvento.Click += new System.EventHandler(this.btnAddEvento_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(195, 356);
            this.txtDescripcion.MaxLength = 4000;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(324, 80);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.BackColor = System.Drawing.Color.White;
            this.txtRutaArchivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRutaArchivo.Enabled = false;
            this.txtRutaArchivo.Location = new System.Drawing.Point(195, 456);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(325, 14);
            this.txtRutaArchivo.TabIndex = 33;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // openFileDialogDocumento
            // 
            this.openFileDialogDocumento.FileName = "openFileDialog1";
            this.openFileDialogDocumento.Multiselect = true;
            // 
            // frm1
            // 
            this.frm1.Controls.Add(this.frm2);
            this.frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm1.Location = new System.Drawing.Point(0, 0);
            this.frm1.Name = "frm1";
            this.frm1.Size = new System.Drawing.Size(592, 551);
            this.frm1.TabIndex = 39;
            // 
            // frm2
            // 
            this.frm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frm2.Controls.Add(this.pnlAdd);
            this.frm2.Controls.Add(this.btnRegistrarE);
            this.frm2.Controls.Add(this.btnCancelar);
            this.frm2.Controls.Add(this.groupBox1);
            this.frm2.Location = new System.Drawing.Point(2, 2);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(588, 547);
            this.frm2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.separatorControl1);
            this.groupBox1.Controls.Add(this.materialLabel10);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.txtRutaArchivo);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.btnAddEvento);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.btnAddTarea);
            this.groupBox1.Controls.Add(this.cmbTarea);
            this.groupBox1.Controls.Add(this.cmbEvento);
            this.groupBox1.Controls.Add(this.btnCargarArchivo);
            this.groupBox1.Controls.Add(this.cbhActivarCampos);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.txtNumExp);
            this.groupBox1.Controls.Add(this.dtpTerminoInterno);
            this.groupBox1.Controls.Add(this.txtJuzgado);
            this.groupBox1.Controls.Add(this.dtpTeminoLegal);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtTJuicio);
            this.groupBox1.Controls.Add(this.txtContraparte);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 489);
            this.groupBox1.TabIndex = 39;
            // 
            // btnRegistrarE
            // 
            this.btnRegistrarE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarE.BGColor = "#3F51B5";
            this.btnRegistrarE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarE.Depth = 0;
            this.btnRegistrarE.Icon = null;
            this.btnRegistrarE.Location = new System.Drawing.Point(350, 514);
            this.btnRegistrarE.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarE.Name = "btnRegistrarE";
            this.btnRegistrarE.Primary = true;
            this.btnRegistrarE.Size = new System.Drawing.Size(131, 23);
            this.btnRegistrarE.TabIndex = 38;
            this.btnRegistrarE.Text = "Registrar";
            this.btnRegistrarE.UseVisualStyleBackColor = true;
            this.btnRegistrarE.Click += new System.EventHandler(this.btnRegistrarE_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BGColor = "#B71C1C";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(487, 514);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(27, 356);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(166, 19);
            this.materialLabel10.TabIndex = 135;
            this.materialLabel10.Text = "Descripción del evento:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(27, 47);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 19);
            this.materialLabel1.TabIndex = 41;
            this.materialLabel1.Text = "No. Expediente:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(27, 326);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(120, 19);
            this.materialLabel9.TabIndex = 134;
            this.materialLabel9.Text = "Término Interno:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(27, 289);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(109, 19);
            this.materialLabel8.TabIndex = 133;
            this.materialLabel8.Text = "Término Legal:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(27, 258);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(51, 19);
            this.materialLabel7.TabIndex = 132;
            this.materialLabel7.Text = "Tarea:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(27, 223);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(59, 19);
            this.materialLabel6.TabIndex = 131;
            this.materialLabel6.Text = "Evento:";
            // 
            // cmbTarea
            // 
            this.cmbTarea.DataSource = null;
            this.cmbTarea.Depth = 0;
            this.cmbTarea.DisplayMember = "";
            this.cmbTarea.DropDownWidth = 324;
            this.cmbTarea.Enabled = false;
            this.cmbTarea.Hint = "";
            this.cmbTarea.Location = new System.Drawing.Point(195, 248);
            this.cmbTarea.MaxLength = 0;
            this.cmbTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.PasswordChar = '\0';
            this.cmbTarea.SelectedIndex = -1;
            this.cmbTarea.SelectedItem = null;
            this.cmbTarea.SelectedText = "";
            this.cmbTarea.SelectedValue = null;
            this.cmbTarea.Size = new System.Drawing.Size(324, 29);
            this.cmbTarea.TabIndex = 50;
            this.cmbTarea.TabStop = false;
            this.cmbTarea.UseSystemPasswordChar = false;
            this.cmbTarea.ValueMember = "";
            // 
            // cmbEvento
            // 
            this.cmbEvento.DataSource = null;
            this.cmbEvento.Depth = 0;
            this.cmbEvento.DisplayMember = "";
            this.cmbEvento.DropDownWidth = 324;
            this.cmbEvento.Hint = "";
            this.cmbEvento.Location = new System.Drawing.Point(195, 213);
            this.cmbEvento.MaxLength = 0;
            this.cmbEvento.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.PasswordChar = '\0';
            this.cmbEvento.SelectedIndex = -1;
            this.cmbEvento.SelectedItem = null;
            this.cmbEvento.SelectedText = "";
            this.cmbEvento.SelectedValue = null;
            this.cmbEvento.Size = new System.Drawing.Size(324, 29);
            this.cmbEvento.TabIndex = 49;
            this.cmbEvento.TabStop = false;
            this.cmbEvento.UseSystemPasswordChar = false;
            this.cmbEvento.ValueMember = "";
            this.cmbEvento.SelectionChangeCommitted += new System.EventHandler(this.cmbEvento_SelectionChangeCommitted);
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BGColor = "#508ef5";
            this.btnCargarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarArchivo.Depth = 0;
            this.btnCargarArchivo.Icon = null;
            this.btnCargarArchivo.Location = new System.Drawing.Point(102, 451);
            this.btnCargarArchivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Primary = true;
            this.btnCargarArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnCargarArchivo.TabIndex = 38;
            this.btnCargarArchivo.Text = "Adjuntar";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // cbhActivarCampos
            // 
            this.cbhActivarCampos.AutoSize = true;
            this.cbhActivarCampos.Depth = 0;
            this.cbhActivarCampos.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbhActivarCampos.Location = new System.Drawing.Point(304, 10);
            this.cbhActivarCampos.Margin = new System.Windows.Forms.Padding(0);
            this.cbhActivarCampos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbhActivarCampos.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbhActivarCampos.Name = "cbhActivarCampos";
            this.cbhActivarCampos.Ripple = true;
            this.cbhActivarCampos.Size = new System.Drawing.Size(223, 30);
            this.cbhActivarCampos.TabIndex = 39;
            this.cbhActivarCampos.Text = "Activar campos para su edición";
            this.cbhActivarCampos.UseVisualStyleBackColor = true;
            this.cbhActivarCampos.CheckedChanged += new System.EventHandler(this.cbhActivarCampos_CheckedChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(27, 135);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(108, 19);
            this.materialLabel4.TabIndex = 47;
            this.materialLabel4.Text = "Tipo de Juicio:";
            // 
            // txtNumExp
            // 
            this.txtNumExp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumExp.Depth = 0;
            this.txtNumExp.Enabled = false;
            this.txtNumExp.Hint = "";
            this.txtNumExp.Location = new System.Drawing.Point(195, 43);
            this.txtNumExp.MaxLength = 32767;
            this.txtNumExp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumExp.Name = "txtNumExp";
            this.txtNumExp.PasswordChar = '\0';
            this.txtNumExp.ReadOnly = false;
            this.txtNumExp.SelectedText = "";
            this.txtNumExp.SelectionLength = 0;
            this.txtNumExp.SelectionStart = 0;
            this.txtNumExp.Size = new System.Drawing.Size(324, 23);
            this.txtNumExp.TabIndex = 40;
            this.txtNumExp.TabStop = false;
            this.txtNumExp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumExp.UseSystemPasswordChar = false;
            // 
            // txtJuzgado
            // 
            this.txtJuzgado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtJuzgado.Depth = 0;
            this.txtJuzgado.Enabled = false;
            this.txtJuzgado.Hint = "";
            this.txtJuzgado.Location = new System.Drawing.Point(195, 73);
            this.txtJuzgado.MaxLength = 32767;
            this.txtJuzgado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtJuzgado.Name = "txtJuzgado";
            this.txtJuzgado.PasswordChar = '\0';
            this.txtJuzgado.ReadOnly = false;
            this.txtJuzgado.SelectedText = "";
            this.txtJuzgado.SelectionLength = 0;
            this.txtJuzgado.SelectionStart = 0;
            this.txtJuzgado.Size = new System.Drawing.Size(324, 23);
            this.txtJuzgado.TabIndex = 42;
            this.txtJuzgado.TabStop = false;
            this.txtJuzgado.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJuzgado.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(27, 77);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 43;
            this.materialLabel2.Text = "Autoridad:";
            // 
            // txtTJuicio
            // 
            this.txtTJuicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTJuicio.Depth = 0;
            this.txtTJuicio.Enabled = false;
            this.txtTJuicio.Hint = "";
            this.txtTJuicio.Location = new System.Drawing.Point(195, 131);
            this.txtTJuicio.MaxLength = 32767;
            this.txtTJuicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTJuicio.Name = "txtTJuicio";
            this.txtTJuicio.PasswordChar = '\0';
            this.txtTJuicio.ReadOnly = false;
            this.txtTJuicio.SelectedText = "";
            this.txtTJuicio.SelectionLength = 0;
            this.txtTJuicio.SelectionStart = 0;
            this.txtTJuicio.Size = new System.Drawing.Size(324, 23);
            this.txtTJuicio.TabIndex = 46;
            this.txtTJuicio.TabStop = false;
            this.txtTJuicio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTJuicio.UseSystemPasswordChar = false;
            // 
            // txtContraparte
            // 
            this.txtContraparte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContraparte.Depth = 0;
            this.txtContraparte.Enabled = false;
            this.txtContraparte.Hint = "";
            this.txtContraparte.Location = new System.Drawing.Point(195, 102);
            this.txtContraparte.MaxLength = 32767;
            this.txtContraparte.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContraparte.Name = "txtContraparte";
            this.txtContraparte.PasswordChar = '\0';
            this.txtContraparte.ReadOnly = false;
            this.txtContraparte.SelectedText = "";
            this.txtContraparte.SelectionLength = 0;
            this.txtContraparte.SelectionStart = 0;
            this.txtContraparte.Size = new System.Drawing.Size(324, 23);
            this.txtContraparte.TabIndex = 44;
            this.txtContraparte.TabStop = false;
            this.txtContraparte.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraparte.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(27, 106);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(92, 19);
            this.materialLabel3.TabIndex = 45;
            this.materialLabel3.Text = "Contraparte:";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(5, 178);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(559, 23);
            this.separatorControl1.TabIndex = 136;
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.panel1);
            this.pnlAdd.Location = new System.Drawing.Point(179, 158);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(334, 92);
            this.pnlAdd.TabIndex = 137;
            this.pnlAdd.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnAddCanc);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtAdd);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 88);
            this.panel1.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombre.Location = new System.Drawing.Point(6, 7);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 19);
            this.lblNombre.TabIndex = 38;
            this.lblNombre.Text = "label1";
            // 
            // txtAdd
            // 
            this.txtAdd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAdd.Depth = 0;
            this.txtAdd.Hint = "";
            this.txtAdd.Location = new System.Drawing.Point(10, 29);
            this.txtAdd.MaxLength = 32767;
            this.txtAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.PasswordChar = '\0';
            this.txtAdd.ReadOnly = false;
            this.txtAdd.SelectedText = "";
            this.txtAdd.SelectionLength = 0;
            this.txtAdd.SelectionStart = 0;
            this.txtAdd.Size = new System.Drawing.Size(312, 23);
            this.txtAdd.TabIndex = 39;
            this.txtAdd.TabStop = false;
            this.txtAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdd.UseSystemPasswordChar = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BGColor = "#3F51B5";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Depth = 0;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(159, 58);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(86, 23);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddCanc
            // 
            this.btnAddCanc.BGColor = "#B71C1C";
            this.btnAddCanc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCanc.Depth = 0;
            this.btnAddCanc.Icon = null;
            this.btnAddCanc.Location = new System.Drawing.Point(251, 58);
            this.btnAddCanc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCanc.Name = "btnAddCanc";
            this.btnAddCanc.Primary = true;
            this.btnAddCanc.Size = new System.Drawing.Size(71, 23);
            this.btnAddCanc.TabIndex = 41;
            this.btnAddCanc.Text = "Cancelar";
            this.btnAddCanc.UseVisualStyleBackColor = true;
            this.btnAddCanc.Click += new System.EventHandler(this.btnAddCanc_Click);
            // 
            // FRREventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 551);
            this.Controls.Add(this.frm1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRREventos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Evento";
            this.Load += new System.EventHandler(this.FRREventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).EndInit();
            this.frm1.ResumeLayout(false);
            this.frm2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAdd)).EndInit();
            this.pnlAdd.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcion;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialogDocumento;
        private System.Windows.Forms.Button btnAddTarea;
        private System.Windows.Forms.Button btnAddEvento;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnRegistrarE;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCargarArchivo;
        private MaterialSkin.Controls.MaterialCheckBox cbhActivarCampos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumExp;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContraparte;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtJuzgado;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTJuicio;
        private MaterialSkin.Controls.MaterialComboBox cmbEvento;
        private MaterialSkin.Controls.MaterialComboBox cmbTarea;
        private MetroFramework.Controls.MetroDateTime dtpTeminoLegal;
        private MetroFramework.Controls.MetroDateTime dtpTerminoInterno;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private DevExpress.XtraEditors.PanelControl frm1;
        private System.Windows.Forms.Panel frm2;
        private System.Windows.Forms.Panel groupBox1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.PanelControl pnlAdd;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnAddCanc;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAdd;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
    }
}