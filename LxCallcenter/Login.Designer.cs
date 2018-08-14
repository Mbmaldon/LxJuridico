namespace LxCallcenter
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lnkConfigurar = new MetroFramework.Controls.MetroLink();
            this.bgwLogin = new System.ComponentModel.BackgroundWorker();
            this.txbUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbContrasena = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnIngresar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.lnkOptions = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mnstpMas = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.btnConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.v1100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tglRecordarme = new LollipopToggle();
            this.lollipopLabel1 = new LollipopLabel();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.mnstpMas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblUsuario.Location = new System.Drawing.Point(155, 109);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 22);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblContraseña.Location = new System.Drawing.Point(154, 169);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(91, 22);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(86, 87);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(338, 23);
            this.separatorControl1.TabIndex = 0;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lnkConfigurar
            // 
            this.lnkConfigurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkConfigurar.Image = global::LxCallcenter.Properties.Resources.delete_sign_filled_23px;
            this.lnkConfigurar.ImageSize = 25;
            this.lnkConfigurar.Location = new System.Drawing.Point(479, 4);
            this.lnkConfigurar.Name = "lnkConfigurar";
            this.lnkConfigurar.NoFocusImage = global::LxCallcenter.Properties.Resources.delete_sign_23px;
            this.lnkConfigurar.Size = new System.Drawing.Size(25, 25);
            this.lnkConfigurar.TabIndex = 9;
            this.metroToolTip1.SetToolTip(this.lnkConfigurar, "Cerrar");
            this.lnkConfigurar.UseSelectable = true;
            this.lnkConfigurar.Click += new System.EventHandler(this.lnkConfigurar_Click);
            // 
            // bgwLogin
            // 
            this.bgwLogin.WorkerReportsProgress = true;
            this.bgwLogin.WorkerSupportsCancellation = true;
            this.bgwLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLogin_DoWork);
            this.bgwLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLogin_RunWorkerCompleted);
            // 
            // txbUsuario
            // 
            this.txbUsuario.AllowDrop = true;
            this.txbUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbUsuario.Depth = 0;
            this.txbUsuario.Hint = "";
            this.txbUsuario.Location = new System.Drawing.Point(159, 135);
            this.txbUsuario.MaxLength = 32767;
            this.txbUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PasswordChar = '\0';
            this.txbUsuario.ReadOnly = false;
            this.txbUsuario.SelectedText = "";
            this.txbUsuario.SelectionLength = 0;
            this.txbUsuario.SelectionStart = 0;
            this.txbUsuario.Size = new System.Drawing.Size(190, 23);
            this.txbUsuario.TabIndex = 2;
            this.txbUsuario.TabStop = false;
            this.txbUsuario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbUsuario.UseSystemPasswordChar = false;
            this.txbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbContrasena_KeyPress);
            // 
            // txbContrasena
            // 
            this.txbContrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbContrasena.Depth = 0;
            this.txbContrasena.Hint = "";
            this.txbContrasena.Location = new System.Drawing.Point(159, 194);
            this.txbContrasena.MaxLength = 32767;
            this.txbContrasena.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbContrasena.Name = "txbContrasena";
            this.txbContrasena.PasswordChar = '●';
            this.txbContrasena.ReadOnly = false;
            this.txbContrasena.SelectedText = "";
            this.txbContrasena.SelectionLength = 0;
            this.txbContrasena.SelectionStart = 0;
            this.txbContrasena.Size = new System.Drawing.Size(190, 23);
            this.txbContrasena.TabIndex = 4;
            this.txbContrasena.TabStop = false;
            this.txbContrasena.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbContrasena.UseSystemPasswordChar = false;
            this.txbContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbContrasena_KeyPress);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BGColor = "#3f51b5";
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Depth = 0;
            this.btnIngresar.Icon = null;
            this.btnIngresar.Location = new System.Drawing.Point(192, 279);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Primary = true;
            this.btnIngresar.Size = new System.Drawing.Size(116, 23);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lnkOptions
            // 
            this.lnkOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkOptions.Image = global::LxCallcenter.Properties.Resources.more_23px;
            this.lnkOptions.ImageSize = 23;
            this.lnkOptions.Location = new System.Drawing.Point(479, 303);
            this.lnkOptions.Name = "lnkOptions";
            this.lnkOptions.NoFocusImage = global::LxCallcenter.Properties.Resources.more_23px;
            this.lnkOptions.Size = new System.Drawing.Size(25, 12);
            this.lnkOptions.TabIndex = 8;
            this.lnkOptions.UseSelectable = true;
            this.lnkOptions.Click += new System.EventHandler(this.lnkOptions_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::LxCallcenter.Properties.Resources.LogoSAS;
            this.pictureBox1.Location = new System.Drawing.Point(114, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LxCallcenter.Properties.Resources._7a8cbb7079d70bd64c469435a71b4db9;
            this.pictureBox2.Location = new System.Drawing.Point(231, 270);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 240;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // mnstpMas
            // 
            this.mnstpMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mnstpMas.Depth = 0;
            this.mnstpMas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfiguracion,
            this.v1100ToolStripMenuItem});
            this.mnstpMas.MouseState = MaterialSkin.MouseState.HOVER;
            this.mnstpMas.Name = "mnstpMas";
            this.mnstpMas.Size = new System.Drawing.Size(151, 48);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Image = global::LxCallcenter.Properties.Resources.settings_20px;
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(150, 22);
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // v1100ToolStripMenuItem
            // 
            this.v1100ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.v1100ToolStripMenuItem.Enabled = false;
            this.v1100ToolStripMenuItem.Name = "v1100ToolStripMenuItem";
            this.v1100ToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.v1100ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.v1100ToolStripMenuItem.Text = "V. 1.1.0.63";
            this.v1100ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.v1100ToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.v1100ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tglRecordarme
            // 
            this.tglRecordarme.AutoSize = true;
            this.tglRecordarme.EllipseBorderColor = "#3b73d1";
            this.tglRecordarme.EllipseColor = "#508ef5";
            this.tglRecordarme.Location = new System.Drawing.Point(272, 241);
            this.tglRecordarme.Name = "tglRecordarme";
            this.tglRecordarme.Size = new System.Drawing.Size(47, 19);
            this.tglRecordarme.TabIndex = 6;
            this.tglRecordarme.Text = "lollipopToggle1";
            this.tglRecordarme.UseVisualStyleBackColor = true;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(182, 241);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(86, 17);
            this.lollipopLabel1.TabIndex = 5;
            this.lollipopLabel1.Text = "Recordarme";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(512, 325);
            this.Controls.Add(this.lnkOptions);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lnkConfigurar);
            this.Controls.Add(this.tglRecordarme);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txbContrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiPyME | SAS";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.mnstpMas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbContrasena;
		private DevExpress.XtraEditors.SeparatorControl separatorControl1;
		private LollipopToggle tglRecordarme;
		private LollipopLabel lollipopLabel1;
		private MetroFramework.Controls.MetroLink lnkConfigurar;
		private MetroFramework.Components.MetroToolTip metroToolTip1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.ComponentModel.BackgroundWorker bgwLogin;
		private MaterialSkin.Controls.MaterialRaisedButtonCustom btnIngresar;
        private MetroFramework.Controls.MetroLink lnkOptions;
        private MaterialSkin.Controls.MaterialContextMenuStrip mnstpMas;
        private System.Windows.Forms.ToolStripMenuItem btnConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem v1100ToolStripMenuItem;
    }
}