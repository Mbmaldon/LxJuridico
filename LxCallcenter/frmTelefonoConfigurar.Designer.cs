namespace LxCallcenter
{
    partial class frmTelefonoConfigurar
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
            this.txtPuerto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIp4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIp3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIp2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIp1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtContrasenia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDisplayName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lnkExpCol = new MetroFramework.Controls.MetroLink();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnActualizar = new LollipopButton();
            this.btnGuardar = new LollipopButton();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPuerto
            // 
            this.txtPuerto.Depth = 0;
            this.txtPuerto.Hint = "";
            this.txtPuerto.Location = new System.Drawing.Point(37, 344);
            this.txtPuerto.MaxLength = 32767;
            this.txtPuerto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.PasswordChar = '\0';
            this.txtPuerto.SelectedText = "";
            this.txtPuerto.SelectionLength = 0;
            this.txtPuerto.SelectionStart = 0;
            this.txtPuerto.Size = new System.Drawing.Size(101, 23);
            this.txtPuerto.TabIndex = 25;
            this.txtPuerto.TabStop = false;
            this.txtPuerto.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(33, 322);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(52, 18);
            this.materialLabel5.TabIndex = 24;
            this.materialLabel5.Text = "Puerto";
            // 
            // txtIp4
            // 
            this.txtIp4.Depth = 0;
            this.txtIp4.Hint = "";
            this.txtIp4.Location = new System.Drawing.Point(156, 289);
            this.txtIp4.MaxLength = 3;
            this.txtIp4.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIp4.Name = "txtIp4";
            this.txtIp4.PasswordChar = '\0';
            this.txtIp4.SelectedText = "";
            this.txtIp4.SelectionLength = 0;
            this.txtIp4.SelectionStart = 0;
            this.txtIp4.Size = new System.Drawing.Size(32, 23);
            this.txtIp4.TabIndex = 23;
            this.txtIp4.TabStop = false;
            this.txtIp4.UseSystemPasswordChar = false;
            this.txtIp4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtIp3
            // 
            this.txtIp3.Depth = 0;
            this.txtIp3.Hint = "";
            this.txtIp3.Location = new System.Drawing.Point(117, 289);
            this.txtIp3.MaxLength = 3;
            this.txtIp3.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIp3.Name = "txtIp3";
            this.txtIp3.PasswordChar = '\0';
            this.txtIp3.SelectedText = "";
            this.txtIp3.SelectionLength = 0;
            this.txtIp3.SelectionStart = 0;
            this.txtIp3.Size = new System.Drawing.Size(32, 23);
            this.txtIp3.TabIndex = 22;
            this.txtIp3.TabStop = false;
            this.txtIp3.UseSystemPasswordChar = false;
            this.txtIp3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtIp2
            // 
            this.txtIp2.Depth = 0;
            this.txtIp2.Hint = "";
            this.txtIp2.Location = new System.Drawing.Point(77, 289);
            this.txtIp2.MaxLength = 3;
            this.txtIp2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIp2.Name = "txtIp2";
            this.txtIp2.PasswordChar = '\0';
            this.txtIp2.SelectedText = "";
            this.txtIp2.SelectionLength = 0;
            this.txtIp2.SelectionStart = 0;
            this.txtIp2.Size = new System.Drawing.Size(32, 23);
            this.txtIp2.TabIndex = 21;
            this.txtIp2.TabStop = false;
            this.txtIp2.UseSystemPasswordChar = false;
            this.txtIp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtIp1
            // 
            this.txtIp1.Depth = 0;
            this.txtIp1.Hint = "";
            this.txtIp1.Location = new System.Drawing.Point(37, 289);
            this.txtIp1.MaxLength = 3;
            this.txtIp1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIp1.Name = "txtIp1";
            this.txtIp1.PasswordChar = '\0';
            this.txtIp1.SelectedText = "";
            this.txtIp1.SelectionLength = 0;
            this.txtIp1.SelectionStart = 0;
            this.txtIp1.Size = new System.Drawing.Size(32, 23);
            this.txtIp1.TabIndex = 20;
            this.txtIp1.TabStop = false;
            this.txtIp1.UseSystemPasswordChar = false;
            this.txtIp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(33, 266);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(55, 18);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "PBX IP";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Depth = 0;
            this.txtContrasenia.Hint = "";
            this.txtContrasenia.Location = new System.Drawing.Point(37, 232);
            this.txtContrasenia.MaxLength = 32767;
            this.txtContrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '●';
            this.txtContrasenia.SelectedText = "";
            this.txtContrasenia.SelectionLength = 0;
            this.txtContrasenia.SelectionStart = 0;
            this.txtContrasenia.Size = new System.Drawing.Size(193, 23);
            this.txtContrasenia.TabIndex = 18;
            this.txtContrasenia.TabStop = false;
            this.txtContrasenia.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(33, 210);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(85, 18);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "";
            this.txtUsuario.Location = new System.Drawing.Point(37, 177);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(193, 23);
            this.txtUsuario.TabIndex = 16;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(33, 155);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(60, 18);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Usuario";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Depth = 0;
            this.txtDisplayName.Hint = "";
            this.txtDisplayName.Location = new System.Drawing.Point(37, 125);
            this.txtDisplayName.MaxLength = 32767;
            this.txtDisplayName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.PasswordChar = '\0';
            this.txtDisplayName.SelectedText = "";
            this.txtDisplayName.SelectionLength = 0;
            this.txtDisplayName.SelectionStart = 0;
            this.txtDisplayName.Size = new System.Drawing.Size(193, 23);
            this.txtDisplayName.TabIndex = 14;
            this.txtDisplayName.TabStop = false;
            this.txtDisplayName.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(33, 105);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 18);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Alias";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LxCallcenter.Properties.Resources.customer_support_48px;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(7, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 32);
            this.pictureBox2.TabIndex = 238;
            this.pictureBox2.TabStop = false;
            // 
            // MensajeError
            // 
            this.MensajeError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.MensajeError.ContainerControl = this;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(67, 296);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(12, 18);
            this.materialLabel7.TabIndex = 243;
            this.materialLabel7.Text = ".";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(108, 296);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(12, 18);
            this.materialLabel6.TabIndex = 244;
            this.materialLabel6.Text = ".";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(147, 296);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(12, 18);
            this.materialLabel8.TabIndex = 245;
            this.materialLabel8.Text = ".";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lnkExpCol
            // 
            this.lnkExpCol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.lnkExpCol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkExpCol.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnkExpCol.Image = global::LxCallcenter.Properties.Resources.Arrowhead_Right;
            this.lnkExpCol.ImageSize = 18;
            this.lnkExpCol.Location = new System.Drawing.Point(0, 0);
            this.lnkExpCol.Name = "lnkExpCol";
            this.lnkExpCol.Size = new System.Drawing.Size(6, 522);
            this.lnkExpCol.TabIndex = 246;
            this.metroToolTip1.SetToolTip(this.lnkExpCol, "Ocultar");
            this.lnkExpCol.UseCustomBackColor = true;
            this.lnkExpCol.UseSelectable = true;
            this.lnkExpCol.Click += new System.EventHandler(this.lnkExpCol_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BGColor = "#001489";
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FontColor = "#ffffff";
            this.btnActualizar.Location = new System.Drawing.Point(59, 422);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(143, 25);
            this.btnActualizar.TabIndex = 240;
            this.btnActualizar.Text = "Actuallizar";
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BGColor = "#001489";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FontColor = "#ffffff";
            this.btnGuardar.Location = new System.Drawing.Point(59, 391);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(143, 25);
            this.btnGuardar.TabIndex = 239;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(41, 28);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(183, 51);
            this.lollipopLabel2.TabIndex = 237;
            this.lollipopLabel2.Text = "Configura la línea telefónica\r\npara realizar y recibir\r\nllamadas.";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.Black;
            this.lollipopLabel1.Location = new System.Drawing.Point(41, 9);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(113, 17);
            this.lollipopLabel1.TabIndex = 236;
            this.lollipopLabel1.Text = "Configurar Línea";
            // 
            // frmTelefonoConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(239, 522);
            this.Controls.Add(this.lnkExpCol);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtIp4);
            this.Controls.Add(this.txtIp3);
            this.Controls.Add(this.txtIp2);
            this.Controls.Add(this.txtIp1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel8);
            this.Name = "frmTelefonoConfigurar";
            this.Text = "frmTelefonoConfigurar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtPuerto;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIp4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIp3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIp2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIp1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasenia;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDisplayName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel1;
        private LollipopButton btnGuardar;
        private System.Windows.Forms.ErrorProvider MensajeError;
        private LollipopButton btnActualizar;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLink lnkExpCol;
        private System.Windows.Forms.Timer timer2;
    }
}