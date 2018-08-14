namespace LxCallcenter
{
    partial class frmProspectosAlta
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
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lnkCerrar = new MetroFramework.Controls.MetroLink();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAPaterno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEdad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAMaterno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCorreoE = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigoPostal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbxGenero = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbxEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbxRegimen = new MaterialSkin.Controls.MaterialComboBox();
            this.pnlFormFisica = new System.Windows.Forms.Panel();
            this.cmbxAgenteFisica = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbxGrupoFisica = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDomicilio = new LollipopTextBox();
            this.pnlFormMoral = new System.Windows.Forms.Panel();
            this.cmbxAgenteMoral = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel27 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbxGrupoMoral = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel29 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigoPostalMoral = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreMoral = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAPaternoMoral = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAMaternoMoral = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPuesto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCorreoMoral = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTelefonoMoral = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDomicilioMoral = new LollipopTextBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbxEstadoMoral = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRFC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RFC = new MaterialSkin.Controls.MaterialLabel();
            this.txtRazonSocial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelar = new LollipopFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlFormFisica.SuspendLayout();
            this.pnlFormMoral.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lnkCerrar
            // 
            this.lnkCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.lnkCerrar.Image = global::LxCallcenter.Properties.Resources.delete_sign_filled_23px;
            this.lnkCerrar.ImageSize = 25;
            this.lnkCerrar.Location = new System.Drawing.Point(620, 7);
            this.lnkCerrar.Name = "lnkCerrar";
            this.lnkCerrar.NoFocusImage = global::LxCallcenter.Properties.Resources.delete_sign_23px;
            this.lnkCerrar.Size = new System.Drawing.Size(25, 25);
            this.lnkCerrar.TabIndex = 7;
            this.metroToolTip1.SetToolTip(this.lnkCerrar, "Cerrar");
            this.lnkCerrar.UseSelectable = true;
            this.lnkCerrar.Click += new System.EventHandler(this.lnkCerrar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.Location = new System.Drawing.Point(4, 4);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(188, 20);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Nuevo Prospecto 652, 619";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.Location = new System.Drawing.Point(3, 6);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 20);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(7, 29);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ReadOnly = false;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(221, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAPaterno.Depth = 0;
            this.txtAPaterno.Hint = "";
            this.txtAPaterno.Location = new System.Drawing.Point(263, 29);
            this.txtAPaterno.MaxLength = 32767;
            this.txtAPaterno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.PasswordChar = '\0';
            this.txtAPaterno.ReadOnly = false;
            this.txtAPaterno.SelectedText = "";
            this.txtAPaterno.SelectionLength = 0;
            this.txtAPaterno.SelectionStart = 0;
            this.txtAPaterno.Size = new System.Drawing.Size(221, 23);
            this.txtAPaterno.TabIndex = 3;
            this.txtAPaterno.TabStop = false;
            this.txtAPaterno.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAPaterno.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.Location = new System.Drawing.Point(259, 6);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(124, 20);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Apellido Paterno";
            // 
            // txtEdad
            // 
            this.txtEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEdad.Depth = 0;
            this.txtEdad.Hint = "";
            this.txtEdad.Location = new System.Drawing.Point(263, 85);
            this.txtEdad.MaxLength = 32767;
            this.txtEdad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.PasswordChar = '\0';
            this.txtEdad.ReadOnly = false;
            this.txtEdad.SelectedText = "";
            this.txtEdad.SelectionLength = 0;
            this.txtEdad.SelectionStart = 0;
            this.txtEdad.Size = new System.Drawing.Size(221, 23);
            this.txtEdad.TabIndex = 7;
            this.txtEdad.TabStop = false;
            this.txtEdad.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEdad.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.Location = new System.Drawing.Point(259, 62);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(44, 20);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Edad";
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAMaterno.Depth = 0;
            this.txtAMaterno.Hint = "";
            this.txtAMaterno.Location = new System.Drawing.Point(7, 85);
            this.txtAMaterno.MaxLength = 32767;
            this.txtAMaterno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.PasswordChar = '\0';
            this.txtAMaterno.ReadOnly = false;
            this.txtAMaterno.SelectedText = "";
            this.txtAMaterno.SelectionLength = 0;
            this.txtAMaterno.SelectionStart = 0;
            this.txtAMaterno.Size = new System.Drawing.Size(221, 23);
            this.txtAMaterno.TabIndex = 5;
            this.txtAMaterno.TabStop = false;
            this.txtAMaterno.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAMaterno.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.Location = new System.Drawing.Point(3, 62);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(127, 20);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Apellido Materno";
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "";
            this.txtTelefono.Location = new System.Drawing.Point(263, 140);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.ReadOnly = false;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(221, 23);
            this.txtTelefono.TabIndex = 11;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.UseSystemPasswordChar = false;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumbers);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.Location = new System.Drawing.Point(259, 117);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(69, 20);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "Teléfono";
            // 
            // txtCorreoE
            // 
            this.txtCorreoE.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCorreoE.Depth = 0;
            this.txtCorreoE.Hint = "";
            this.txtCorreoE.Location = new System.Drawing.Point(7, 140);
            this.txtCorreoE.MaxLength = 32767;
            this.txtCorreoE.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCorreoE.Name = "txtCorreoE";
            this.txtCorreoE.PasswordChar = '\0';
            this.txtCorreoE.ReadOnly = false;
            this.txtCorreoE.SelectedText = "";
            this.txtCorreoE.SelectionLength = 0;
            this.txtCorreoE.SelectionStart = 0;
            this.txtCorreoE.Size = new System.Drawing.Size(221, 23);
            this.txtCorreoE.TabIndex = 9;
            this.txtCorreoE.TabStop = false;
            this.txtCorreoE.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreoE.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.Location = new System.Drawing.Point(3, 117);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(137, 20);
            this.materialLabel7.TabIndex = 8;
            this.materialLabel7.Text = "Correo Electrónico";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigoPostal.Depth = 0;
            this.txtCodigoPostal.Hint = "";
            this.txtCodigoPostal.Location = new System.Drawing.Point(263, 198);
            this.txtCodigoPostal.MaxLength = 32767;
            this.txtCodigoPostal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.PasswordChar = '\0';
            this.txtCodigoPostal.ReadOnly = false;
            this.txtCodigoPostal.SelectedText = "";
            this.txtCodigoPostal.SelectionLength = 0;
            this.txtCodigoPostal.SelectionStart = 0;
            this.txtCodigoPostal.Size = new System.Drawing.Size(221, 23);
            this.txtCodigoPostal.TabIndex = 15;
            this.txtCodigoPostal.TabStop = false;
            this.txtCodigoPostal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoPostal.UseSystemPasswordChar = false;
            this.txtCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumbers);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.Location = new System.Drawing.Point(259, 174);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(107, 20);
            this.materialLabel8.TabIndex = 14;
            this.materialLabel8.Text = "Código Postal";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.Location = new System.Drawing.Point(3, 174);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(58, 20);
            this.materialLabel9.TabIndex = 12;
            this.materialLabel9.Text = "Genero";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.Location = new System.Drawing.Point(3, 230);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(57, 20);
            this.materialLabel11.TabIndex = 16;
            this.materialLabel11.Text = "Estado";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.Location = new System.Drawing.Point(3, 289);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(74, 20);
            this.materialLabel12.TabIndex = 18;
            this.materialLabel12.Text = "Domicilio";
            // 
            // cmbxGenero
            // 
            this.cmbxGenero.DataSource = null;
            this.cmbxGenero.Depth = 0;
            this.cmbxGenero.DisplayMember = "";
            this.cmbxGenero.DropDownWidth = 221;
            this.cmbxGenero.Hint = "";
            this.cmbxGenero.Location = new System.Drawing.Point(7, 193);
            this.cmbxGenero.MaxLength = 0;
            this.cmbxGenero.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxGenero.Name = "cmbxGenero";
            this.cmbxGenero.PasswordChar = '\0';
            this.cmbxGenero.SelectedIndex = -1;
            this.cmbxGenero.SelectedItem = null;
            this.cmbxGenero.SelectedText = "";
            this.cmbxGenero.SelectedValue = null;
            this.cmbxGenero.Size = new System.Drawing.Size(221, 30);
            this.cmbxGenero.TabIndex = 13;
            this.cmbxGenero.TabStop = false;
            this.cmbxGenero.UseSystemPasswordChar = false;
            this.cmbxGenero.ValueMember = "";
            // 
            // cmbxEstado
            // 
            this.cmbxEstado.DataSource = null;
            this.cmbxEstado.Depth = 0;
            this.cmbxEstado.DisplayMember = "";
            this.cmbxEstado.DropDownWidth = 221;
            this.cmbxEstado.Hint = "";
            this.cmbxEstado.Location = new System.Drawing.Point(7, 252);
            this.cmbxEstado.MaxLength = 0;
            this.cmbxEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxEstado.Name = "cmbxEstado";
            this.cmbxEstado.PasswordChar = '\0';
            this.cmbxEstado.SelectedIndex = -1;
            this.cmbxEstado.SelectedItem = null;
            this.cmbxEstado.SelectedText = "";
            this.cmbxEstado.SelectedValue = null;
            this.cmbxEstado.Size = new System.Drawing.Size(221, 30);
            this.cmbxEstado.TabIndex = 17;
            this.cmbxEstado.TabStop = false;
            this.cmbxEstado.UseSystemPasswordChar = false;
            this.cmbxEstado.ValueMember = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BGColor = "#1A237E";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(363, 580);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(102, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.Location = new System.Drawing.Point(85, 45);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(70, 20);
            this.materialLabel10.TabIndex = 1;
            this.materialLabel10.Text = "Regimen";
            // 
            // cmbxRegimen
            // 
            this.cmbxRegimen.DataSource = null;
            this.cmbxRegimen.Depth = 0;
            this.cmbxRegimen.DisplayMember = "";
            this.cmbxRegimen.DropDownWidth = 221;
            this.cmbxRegimen.Hint = "";
            this.cmbxRegimen.Location = new System.Drawing.Point(89, 67);
            this.cmbxRegimen.MaxLength = 0;
            this.cmbxRegimen.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxRegimen.Name = "cmbxRegimen";
            this.cmbxRegimen.PasswordChar = '\0';
            this.cmbxRegimen.SelectedIndex = -1;
            this.cmbxRegimen.SelectedItem = null;
            this.cmbxRegimen.SelectedText = "";
            this.cmbxRegimen.SelectedValue = null;
            this.cmbxRegimen.Size = new System.Drawing.Size(221, 30);
            this.cmbxRegimen.TabIndex = 2;
            this.cmbxRegimen.TabStop = false;
            this.cmbxRegimen.UseSystemPasswordChar = false;
            this.cmbxRegimen.ValueMember = "";
            this.cmbxRegimen.SelectionChangeCommitted += new System.EventHandler(this.cmbxRegimen_SelectionChangeCommitted);
            // 
            // pnlFormFisica
            // 
            this.pnlFormFisica.Controls.Add(this.cmbxAgenteFisica);
            this.pnlFormFisica.Controls.Add(this.materialLabel26);
            this.pnlFormFisica.Controls.Add(this.materialLabel25);
            this.pnlFormFisica.Controls.Add(this.cmbxGrupoFisica);
            this.pnlFormFisica.Controls.Add(this.materialLabel24);
            this.pnlFormFisica.Controls.Add(this.materialLabel2);
            this.pnlFormFisica.Controls.Add(this.txtNombre);
            this.pnlFormFisica.Controls.Add(this.materialLabel3);
            this.pnlFormFisica.Controls.Add(this.txtAPaterno);
            this.pnlFormFisica.Controls.Add(this.materialLabel5);
            this.pnlFormFisica.Controls.Add(this.cmbxEstado);
            this.pnlFormFisica.Controls.Add(this.txtAMaterno);
            this.pnlFormFisica.Controls.Add(this.cmbxGenero);
            this.pnlFormFisica.Controls.Add(this.materialLabel4);
            this.pnlFormFisica.Controls.Add(this.txtDomicilio);
            this.pnlFormFisica.Controls.Add(this.txtEdad);
            this.pnlFormFisica.Controls.Add(this.materialLabel12);
            this.pnlFormFisica.Controls.Add(this.materialLabel7);
            this.pnlFormFisica.Controls.Add(this.materialLabel11);
            this.pnlFormFisica.Controls.Add(this.txtCorreoE);
            this.pnlFormFisica.Controls.Add(this.txtCodigoPostal);
            this.pnlFormFisica.Controls.Add(this.materialLabel6);
            this.pnlFormFisica.Controls.Add(this.materialLabel8);
            this.pnlFormFisica.Controls.Add(this.txtTelefono);
            this.pnlFormFisica.Controls.Add(this.materialLabel9);
            this.pnlFormFisica.Location = new System.Drawing.Point(84, 105);
            this.pnlFormFisica.Name = "pnlFormFisica";
            this.pnlFormFisica.Size = new System.Drawing.Size(513, 457);
            this.pnlFormFisica.TabIndex = 3;
            this.pnlFormFisica.Visible = false;
            // 
            // cmbxAgenteFisica
            // 
            this.cmbxAgenteFisica.DataSource = null;
            this.cmbxAgenteFisica.Depth = 0;
            this.cmbxAgenteFisica.DisplayMember = "";
            this.cmbxAgenteFisica.DropDownWidth = 222;
            this.cmbxAgenteFisica.Hint = "";
            this.cmbxAgenteFisica.Location = new System.Drawing.Point(262, 424);
            this.cmbxAgenteFisica.MaxLength = 0;
            this.cmbxAgenteFisica.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxAgenteFisica.Name = "cmbxAgenteFisica";
            this.cmbxAgenteFisica.PasswordChar = '\0';
            this.cmbxAgenteFisica.SelectedIndex = -1;
            this.cmbxAgenteFisica.SelectedItem = null;
            this.cmbxAgenteFisica.SelectedText = "";
            this.cmbxAgenteFisica.SelectedValue = null;
            this.cmbxAgenteFisica.Size = new System.Drawing.Size(222, 30);
            this.cmbxAgenteFisica.TabIndex = 24;
            this.cmbxAgenteFisica.TabStop = false;
            this.cmbxAgenteFisica.UseSystemPasswordChar = false;
            this.cmbxAgenteFisica.ValueMember = "";
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel26.Location = new System.Drawing.Point(4, 381);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(259, 20);
            this.materialLabel26.TabIndex = 20;
            this.materialLabel26.Text = "Asignación de agente de Call Center";
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel25.Location = new System.Drawing.Point(259, 405);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(158, 20);
            this.materialLabel25.TabIndex = 23;
            this.materialLabel25.Text = "Agente de Call Center";
            // 
            // cmbxGrupoFisica
            // 
            this.cmbxGrupoFisica.DataSource = null;
            this.cmbxGrupoFisica.Depth = 0;
            this.cmbxGrupoFisica.DisplayMember = "";
            this.cmbxGrupoFisica.DropDownWidth = 221;
            this.cmbxGrupoFisica.Hint = "";
            this.cmbxGrupoFisica.Location = new System.Drawing.Point(8, 424);
            this.cmbxGrupoFisica.MaxLength = 0;
            this.cmbxGrupoFisica.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxGrupoFisica.Name = "cmbxGrupoFisica";
            this.cmbxGrupoFisica.PasswordChar = '\0';
            this.cmbxGrupoFisica.SelectedIndex = -1;
            this.cmbxGrupoFisica.SelectedItem = null;
            this.cmbxGrupoFisica.SelectedText = "";
            this.cmbxGrupoFisica.SelectedValue = null;
            this.cmbxGrupoFisica.Size = new System.Drawing.Size(221, 30);
            this.cmbxGrupoFisica.TabIndex = 22;
            this.cmbxGrupoFisica.TabStop = false;
            this.cmbxGrupoFisica.UseSystemPasswordChar = false;
            this.cmbxGrupoFisica.ValueMember = "";
            this.cmbxGrupoFisica.SelectionChangeCommitted += new System.EventHandler(this.cmbxGrupoFisica_SelectionChangeCommitted);
            // 
            // materialLabel24
            // 
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel24.Location = new System.Drawing.Point(4, 405);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(51, 20);
            this.materialLabel24.TabIndex = 21;
            this.materialLabel24.Text = "Grupo";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.FocusedColor = "#508ef5";
            this.txtDomicilio.FontColor = "#999999";
            this.txtDomicilio.IsEnabled = true;
            this.txtDomicilio.Location = new System.Drawing.Point(8, 311);
            this.txtDomicilio.MaxLength = 32767;
            this.txtDomicilio.Multiline = true;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = false;
            this.txtDomicilio.Size = new System.Drawing.Size(473, 45);
            this.txtDomicilio.TabIndex = 19;
            this.txtDomicilio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDomicilio.UseSystemPasswordChar = false;
            // 
            // pnlFormMoral
            // 
            this.pnlFormMoral.Controls.Add(this.cmbxAgenteMoral);
            this.pnlFormMoral.Controls.Add(this.materialLabel27);
            this.pnlFormMoral.Controls.Add(this.materialLabel28);
            this.pnlFormMoral.Controls.Add(this.cmbxGrupoMoral);
            this.pnlFormMoral.Controls.Add(this.materialLabel29);
            this.pnlFormMoral.Controls.Add(this.txtCodigoPostalMoral);
            this.pnlFormMoral.Controls.Add(this.materialLabel14);
            this.pnlFormMoral.Controls.Add(this.materialLabel18);
            this.pnlFormMoral.Controls.Add(this.txtNombreMoral);
            this.pnlFormMoral.Controls.Add(this.materialLabel19);
            this.pnlFormMoral.Controls.Add(this.txtAPaternoMoral);
            this.pnlFormMoral.Controls.Add(this.materialLabel20);
            this.pnlFormMoral.Controls.Add(this.txtAMaternoMoral);
            this.pnlFormMoral.Controls.Add(this.materialLabel21);
            this.pnlFormMoral.Controls.Add(this.txtPuesto);
            this.pnlFormMoral.Controls.Add(this.materialLabel22);
            this.pnlFormMoral.Controls.Add(this.txtCorreoMoral);
            this.pnlFormMoral.Controls.Add(this.materialLabel23);
            this.pnlFormMoral.Controls.Add(this.txtTelefonoMoral);
            this.pnlFormMoral.Controls.Add(this.materialLabel17);
            this.pnlFormMoral.Controls.Add(this.txtDomicilioMoral);
            this.pnlFormMoral.Controls.Add(this.materialLabel16);
            this.pnlFormMoral.Controls.Add(this.cmbxEstadoMoral);
            this.pnlFormMoral.Controls.Add(this.materialLabel15);
            this.pnlFormMoral.Controls.Add(this.txtRFC);
            this.pnlFormMoral.Controls.Add(this.RFC);
            this.pnlFormMoral.Controls.Add(this.txtRazonSocial);
            this.pnlFormMoral.Controls.Add(this.materialLabel13);
            this.pnlFormMoral.Location = new System.Drawing.Point(598, 105);
            this.pnlFormMoral.Name = "pnlFormMoral";
            this.pnlFormMoral.Size = new System.Drawing.Size(513, 457);
            this.pnlFormMoral.TabIndex = 4;
            this.pnlFormMoral.Visible = false;
            // 
            // cmbxAgenteMoral
            // 
            this.cmbxAgenteMoral.DataSource = null;
            this.cmbxAgenteMoral.Depth = 0;
            this.cmbxAgenteMoral.DisplayMember = "";
            this.cmbxAgenteMoral.DropDownWidth = 221;
            this.cmbxAgenteMoral.Hint = "";
            this.cmbxAgenteMoral.Location = new System.Drawing.Point(263, 424);
            this.cmbxAgenteMoral.MaxLength = 0;
            this.cmbxAgenteMoral.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxAgenteMoral.Name = "cmbxAgenteMoral";
            this.cmbxAgenteMoral.PasswordChar = '\0';
            this.cmbxAgenteMoral.SelectedIndex = -1;
            this.cmbxAgenteMoral.SelectedItem = null;
            this.cmbxAgenteMoral.SelectedText = "";
            this.cmbxAgenteMoral.SelectedValue = null;
            this.cmbxAgenteMoral.Size = new System.Drawing.Size(221, 30);
            this.cmbxAgenteMoral.TabIndex = 27;
            this.cmbxAgenteMoral.TabStop = false;
            this.cmbxAgenteMoral.UseSystemPasswordChar = false;
            this.cmbxAgenteMoral.ValueMember = "";
            // 
            // materialLabel27
            // 
            this.materialLabel27.AutoSize = true;
            this.materialLabel27.Depth = 0;
            this.materialLabel27.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel27.Location = new System.Drawing.Point(3, 381);
            this.materialLabel27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel27.Name = "materialLabel27";
            this.materialLabel27.Size = new System.Drawing.Size(259, 20);
            this.materialLabel27.TabIndex = 23;
            this.materialLabel27.Text = "Asignación de agente de Call Center";
            // 
            // materialLabel28
            // 
            this.materialLabel28.AutoSize = true;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel28.Location = new System.Drawing.Point(258, 405);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(158, 20);
            this.materialLabel28.TabIndex = 26;
            this.materialLabel28.Text = "Agente de Call Center";
            // 
            // cmbxGrupoMoral
            // 
            this.cmbxGrupoMoral.DataSource = null;
            this.cmbxGrupoMoral.Depth = 0;
            this.cmbxGrupoMoral.DisplayMember = "";
            this.cmbxGrupoMoral.DropDownWidth = 221;
            this.cmbxGrupoMoral.Hint = "";
            this.cmbxGrupoMoral.Location = new System.Drawing.Point(7, 424);
            this.cmbxGrupoMoral.MaxLength = 0;
            this.cmbxGrupoMoral.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxGrupoMoral.Name = "cmbxGrupoMoral";
            this.cmbxGrupoMoral.PasswordChar = '\0';
            this.cmbxGrupoMoral.SelectedIndex = -1;
            this.cmbxGrupoMoral.SelectedItem = null;
            this.cmbxGrupoMoral.SelectedText = "";
            this.cmbxGrupoMoral.SelectedValue = null;
            this.cmbxGrupoMoral.Size = new System.Drawing.Size(221, 30);
            this.cmbxGrupoMoral.TabIndex = 25;
            this.cmbxGrupoMoral.TabStop = false;
            this.cmbxGrupoMoral.UseSystemPasswordChar = false;
            this.cmbxGrupoMoral.ValueMember = "";
            this.cmbxGrupoMoral.SelectionChangeCommitted += new System.EventHandler(this.cmbxGrupoMoral_SelectionChangeCommitted);
            // 
            // materialLabel29
            // 
            this.materialLabel29.AutoSize = true;
            this.materialLabel29.Depth = 0;
            this.materialLabel29.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel29.Location = new System.Drawing.Point(3, 405);
            this.materialLabel29.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel29.Name = "materialLabel29";
            this.materialLabel29.Size = new System.Drawing.Size(51, 20);
            this.materialLabel29.TabIndex = 24;
            this.materialLabel29.Text = "Grupo";
            // 
            // txtCodigoPostalMoral
            // 
            this.txtCodigoPostalMoral.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigoPostalMoral.Depth = 0;
            this.txtCodigoPostalMoral.Hint = "";
            this.txtCodigoPostalMoral.Location = new System.Drawing.Point(263, 85);
            this.txtCodigoPostalMoral.MaxLength = 32767;
            this.txtCodigoPostalMoral.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigoPostalMoral.Name = "txtCodigoPostalMoral";
            this.txtCodigoPostalMoral.PasswordChar = '\0';
            this.txtCodigoPostalMoral.ReadOnly = false;
            this.txtCodigoPostalMoral.SelectedText = "";
            this.txtCodigoPostalMoral.SelectionLength = 0;
            this.txtCodigoPostalMoral.SelectionStart = 0;
            this.txtCodigoPostalMoral.Size = new System.Drawing.Size(221, 23);
            this.txtCodigoPostalMoral.TabIndex = 7;
            this.txtCodigoPostalMoral.TabStop = false;
            this.txtCodigoPostalMoral.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoPostalMoral.UseSystemPasswordChar = false;
            this.txtCodigoPostalMoral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumbers);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.Location = new System.Drawing.Point(259, 57);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(107, 20);
            this.materialLabel14.TabIndex = 6;
            this.materialLabel14.Text = "Código Postal";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.Location = new System.Drawing.Point(3, 199);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(64, 20);
            this.materialLabel18.TabIndex = 11;
            this.materialLabel18.Text = "Nombre";
            // 
            // txtNombreMoral
            // 
            this.txtNombreMoral.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreMoral.Depth = 0;
            this.txtNombreMoral.Hint = "";
            this.txtNombreMoral.Location = new System.Drawing.Point(7, 222);
            this.txtNombreMoral.MaxLength = 32767;
            this.txtNombreMoral.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreMoral.Name = "txtNombreMoral";
            this.txtNombreMoral.PasswordChar = '\0';
            this.txtNombreMoral.ReadOnly = false;
            this.txtNombreMoral.SelectedText = "";
            this.txtNombreMoral.SelectionLength = 0;
            this.txtNombreMoral.SelectionStart = 0;
            this.txtNombreMoral.Size = new System.Drawing.Size(221, 23);
            this.txtNombreMoral.TabIndex = 12;
            this.txtNombreMoral.TabStop = false;
            this.txtNombreMoral.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreMoral.UseSystemPasswordChar = false;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.Location = new System.Drawing.Point(259, 199);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(124, 20);
            this.materialLabel19.TabIndex = 13;
            this.materialLabel19.Text = "Apellido Paterno";
            // 
            // txtAPaternoMoral
            // 
            this.txtAPaternoMoral.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAPaternoMoral.Depth = 0;
            this.txtAPaternoMoral.Hint = "";
            this.txtAPaternoMoral.Location = new System.Drawing.Point(263, 222);
            this.txtAPaternoMoral.MaxLength = 32767;
            this.txtAPaternoMoral.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAPaternoMoral.Name = "txtAPaternoMoral";
            this.txtAPaternoMoral.PasswordChar = '\0';
            this.txtAPaternoMoral.ReadOnly = false;
            this.txtAPaternoMoral.SelectedText = "";
            this.txtAPaternoMoral.SelectionLength = 0;
            this.txtAPaternoMoral.SelectionStart = 0;
            this.txtAPaternoMoral.Size = new System.Drawing.Size(221, 23);
            this.txtAPaternoMoral.TabIndex = 14;
            this.txtAPaternoMoral.TabStop = false;
            this.txtAPaternoMoral.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAPaternoMoral.UseSystemPasswordChar = false;
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel20.Location = new System.Drawing.Point(3, 255);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(127, 20);
            this.materialLabel20.TabIndex = 15;
            this.materialLabel20.Text = "Apellido Materno";
            // 
            // txtAMaternoMoral
            // 
            this.txtAMaternoMoral.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAMaternoMoral.Depth = 0;
            this.txtAMaternoMoral.Hint = "";
            this.txtAMaternoMoral.Location = new System.Drawing.Point(7, 278);
            this.txtAMaternoMoral.MaxLength = 32767;
            this.txtAMaternoMoral.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAMaternoMoral.Name = "txtAMaternoMoral";
            this.txtAMaternoMoral.PasswordChar = '\0';
            this.txtAMaternoMoral.ReadOnly = false;
            this.txtAMaternoMoral.SelectedText = "";
            this.txtAMaternoMoral.SelectionLength = 0;
            this.txtAMaternoMoral.SelectionStart = 0;
            this.txtAMaternoMoral.Size = new System.Drawing.Size(221, 23);
            this.txtAMaternoMoral.TabIndex = 16;
            this.txtAMaternoMoral.TabStop = false;
            this.txtAMaternoMoral.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAMaternoMoral.UseSystemPasswordChar = false;
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel21.Location = new System.Drawing.Point(259, 255);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(58, 20);
            this.materialLabel21.TabIndex = 17;
            this.materialLabel21.Text = "Puesto";
            // 
            // txtPuesto
            // 
            this.txtPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPuesto.Depth = 0;
            this.txtPuesto.Hint = "";
            this.txtPuesto.Location = new System.Drawing.Point(263, 278);
            this.txtPuesto.MaxLength = 32767;
            this.txtPuesto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.PasswordChar = '\0';
            this.txtPuesto.ReadOnly = false;
            this.txtPuesto.SelectedText = "";
            this.txtPuesto.SelectionLength = 0;
            this.txtPuesto.SelectionStart = 0;
            this.txtPuesto.Size = new System.Drawing.Size(221, 23);
            this.txtPuesto.TabIndex = 18;
            this.txtPuesto.TabStop = false;
            this.txtPuesto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPuesto.UseSystemPasswordChar = false;
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel22.Location = new System.Drawing.Point(3, 310);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(137, 20);
            this.materialLabel22.TabIndex = 19;
            this.materialLabel22.Text = "Correo Electrónico";
            // 
            // txtCorreoMoral
            // 
            this.txtCorreoMoral.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCorreoMoral.Depth = 0;
            this.txtCorreoMoral.Hint = "";
            this.txtCorreoMoral.Location = new System.Drawing.Point(7, 333);
            this.txtCorreoMoral.MaxLength = 32767;
            this.txtCorreoMoral.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCorreoMoral.Name = "txtCorreoMoral";
            this.txtCorreoMoral.PasswordChar = '\0';
            this.txtCorreoMoral.ReadOnly = false;
            this.txtCorreoMoral.SelectedText = "";
            this.txtCorreoMoral.SelectionLength = 0;
            this.txtCorreoMoral.SelectionStart = 0;
            this.txtCorreoMoral.Size = new System.Drawing.Size(221, 23);
            this.txtCorreoMoral.TabIndex = 20;
            this.txtCorreoMoral.TabStop = false;
            this.txtCorreoMoral.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreoMoral.UseSystemPasswordChar = false;
            // 
            // materialLabel23
            // 
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel23.Location = new System.Drawing.Point(259, 310);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(69, 20);
            this.materialLabel23.TabIndex = 21;
            this.materialLabel23.Text = "Teléfono";
            // 
            // txtTelefonoMoral
            // 
            this.txtTelefonoMoral.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefonoMoral.Depth = 0;
            this.txtTelefonoMoral.Hint = "";
            this.txtTelefonoMoral.Location = new System.Drawing.Point(263, 333);
            this.txtTelefonoMoral.MaxLength = 32767;
            this.txtTelefonoMoral.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefonoMoral.Name = "txtTelefonoMoral";
            this.txtTelefonoMoral.PasswordChar = '\0';
            this.txtTelefonoMoral.ReadOnly = false;
            this.txtTelefonoMoral.SelectedText = "";
            this.txtTelefonoMoral.SelectionLength = 0;
            this.txtTelefonoMoral.SelectionStart = 0;
            this.txtTelefonoMoral.Size = new System.Drawing.Size(221, 23);
            this.txtTelefonoMoral.TabIndex = 22;
            this.txtTelefonoMoral.TabStop = false;
            this.txtTelefonoMoral.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefonoMoral.UseSystemPasswordChar = false;
            this.txtTelefonoMoral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumbers);
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.Location = new System.Drawing.Point(3, 176);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(180, 20);
            this.materialLabel17.TabIndex = 10;
            this.materialLabel17.Text = "Información de Contacto";
            // 
            // txtDomicilioMoral
            // 
            this.txtDomicilioMoral.FocusedColor = "#508ef5";
            this.txtDomicilioMoral.FontColor = "#999999";
            this.txtDomicilioMoral.IsEnabled = true;
            this.txtDomicilioMoral.Location = new System.Drawing.Point(7, 138);
            this.txtDomicilioMoral.MaxLength = 32767;
            this.txtDomicilioMoral.Multiline = true;
            this.txtDomicilioMoral.Name = "txtDomicilioMoral";
            this.txtDomicilioMoral.ReadOnly = false;
            this.txtDomicilioMoral.Size = new System.Drawing.Size(473, 29);
            this.txtDomicilioMoral.TabIndex = 9;
            this.txtDomicilioMoral.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDomicilioMoral.UseSystemPasswordChar = false;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.Location = new System.Drawing.Point(2, 116);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(74, 20);
            this.materialLabel16.TabIndex = 8;
            this.materialLabel16.Text = "Domicilio";
            // 
            // cmbxEstadoMoral
            // 
            this.cmbxEstadoMoral.DataSource = null;
            this.cmbxEstadoMoral.Depth = 0;
            this.cmbxEstadoMoral.DisplayMember = "";
            this.cmbxEstadoMoral.DropDownWidth = 221;
            this.cmbxEstadoMoral.Hint = "";
            this.cmbxEstadoMoral.Location = new System.Drawing.Point(7, 79);
            this.cmbxEstadoMoral.MaxLength = 0;
            this.cmbxEstadoMoral.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxEstadoMoral.Name = "cmbxEstadoMoral";
            this.cmbxEstadoMoral.PasswordChar = '\0';
            this.cmbxEstadoMoral.SelectedIndex = -1;
            this.cmbxEstadoMoral.SelectedItem = null;
            this.cmbxEstadoMoral.SelectedText = "";
            this.cmbxEstadoMoral.SelectedValue = null;
            this.cmbxEstadoMoral.Size = new System.Drawing.Size(221, 30);
            this.cmbxEstadoMoral.TabIndex = 5;
            this.cmbxEstadoMoral.TabStop = false;
            this.cmbxEstadoMoral.UseSystemPasswordChar = false;
            this.cmbxEstadoMoral.ValueMember = "";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.Location = new System.Drawing.Point(3, 57);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(57, 20);
            this.materialLabel15.TabIndex = 4;
            this.materialLabel15.Text = "Estado";
            // 
            // txtRFC
            // 
            this.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRFC.Depth = 0;
            this.txtRFC.Hint = "";
            this.txtRFC.Location = new System.Drawing.Point(263, 29);
            this.txtRFC.MaxLength = 32767;
            this.txtRFC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.PasswordChar = '\0';
            this.txtRFC.ReadOnly = false;
            this.txtRFC.SelectedText = "";
            this.txtRFC.SelectionLength = 0;
            this.txtRFC.SelectionStart = 0;
            this.txtRFC.Size = new System.Drawing.Size(221, 23);
            this.txtRFC.TabIndex = 3;
            this.txtRFC.TabStop = false;
            this.txtRFC.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRFC.UseSystemPasswordChar = false;
            // 
            // RFC
            // 
            this.RFC.AutoSize = true;
            this.RFC.Depth = 0;
            this.RFC.Font = new System.Drawing.Font("Roboto", 11F);
            this.RFC.Location = new System.Drawing.Point(259, 6);
            this.RFC.MouseState = MaterialSkin.MouseState.HOVER;
            this.RFC.Name = "RFC";
            this.RFC.Size = new System.Drawing.Size(38, 20);
            this.RFC.TabIndex = 2;
            this.RFC.Text = "RFC";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRazonSocial.Depth = 0;
            this.txtRazonSocial.Hint = "";
            this.txtRazonSocial.Location = new System.Drawing.Point(7, 29);
            this.txtRazonSocial.MaxLength = 32767;
            this.txtRazonSocial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PasswordChar = '\0';
            this.txtRazonSocial.ReadOnly = false;
            this.txtRazonSocial.SelectedText = "";
            this.txtRazonSocial.SelectionLength = 0;
            this.txtRazonSocial.SelectionStart = 0;
            this.txtRazonSocial.Size = new System.Drawing.Size(221, 23);
            this.txtRazonSocial.TabIndex = 1;
            this.txtRazonSocial.TabStop = false;
            this.txtRazonSocial.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRazonSocial.UseSystemPasswordChar = false;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.Location = new System.Drawing.Point(3, 6);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(99, 20);
            this.materialLabel13.TabIndex = 0;
            this.materialLabel13.Text = "Razón Social";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FontColor = "#B71C1C";
            this.btnCancelar.Location = new System.Drawing.Point(471, 580);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.lnkCerrar_Click);
            // 
            // frmProspectosAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.lnkCerrar;
            this.ClientSize = new System.Drawing.Size(652, 619);
            this.Controls.Add(this.pnlFormMoral);
            this.Controls.Add(this.pnlFormFisica);
            this.Controls.Add(this.cmbxRegimen);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lnkCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProspectosAlta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProspectosAlta";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlFormFisica.ResumeLayout(false);
            this.pnlFormFisica.PerformLayout();
            this.pnlFormMoral.ResumeLayout(false);
            this.pnlFormMoral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLink lnkCerrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAPaterno;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEdad;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAMaterno;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreoE;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigoPostal;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private LollipopTextBox txtDomicilio;
        private MaterialSkin.Controls.MaterialComboBox cmbxGenero;
        private MaterialSkin.Controls.MaterialComboBox cmbxEstado;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnGuardar;
        private LollipopFlatButton btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnlFormFisica;
        private MaterialSkin.Controls.MaterialComboBox cmbxRegimen;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.Panel pnlFormMoral;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRazonSocial;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private LollipopTextBox txtDomicilioMoral;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialComboBox cmbxEstadoMoral;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRFC;
        private MaterialSkin.Controls.MaterialLabel RFC;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreMoral;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAPaternoMoral;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAMaternoMoral;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPuesto;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreoMoral;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefonoMoral;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigoPostalMoral;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialComboBox cmbxGrupoFisica;
        private MaterialSkin.Controls.MaterialLabel materialLabel24;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private MaterialSkin.Controls.MaterialLabel materialLabel27;
        private MaterialSkin.Controls.MaterialLabel materialLabel28;
        private MaterialSkin.Controls.MaterialComboBox cmbxGrupoMoral;
        private MaterialSkin.Controls.MaterialLabel materialLabel29;
        private MaterialSkin.Controls.MaterialComboBox cmbxAgenteMoral;
        private MaterialSkin.Controls.MaterialComboBox cmbxAgenteFisica;
    }
}