namespace LxCallcenter
{
	partial class ClienteSMS
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
			if(disposing && (components != null))
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
            this.gbBuscarCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new MetroFramework.Controls.MetroLink();
            this.txbRfc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbNCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblRfc = new MaterialSkin.Controls.MaterialLabel();
            this.lblOtro = new MaterialSkin.Controls.MaterialLabel();
            this.lblNCliente = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txbEMail = new LollipopLabel();
            this.txbCelular = new LollipopLabel();
            this.txbNombre = new LollipopLabel();
            this.lblCorreoE = new MaterialSkin.Controls.MaterialLabel();
            this.lblCelular = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.lblCActivo = new System.Windows.Forms.Label();
            this.gbMensaje = new System.Windows.Forms.GroupBox();
            this.cmbxMensaje = new MetroFramework.Controls.MetroComboBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.btnEnviar = new MetroFramework.Controls.MetroLink();
            this.lblCaracteres = new LollipopLabel();
            this.txbMensaje = new LollipopTextBox();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ovalPictureBox1 = new LxCallcenter.OvalPictureBox();
            this.gbBuscarCliente.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbMensaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuscarCliente
            // 
            this.gbBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBuscarCliente.Controls.Add(this.btnBuscar);
            this.gbBuscarCliente.Controls.Add(this.txbRfc);
            this.gbBuscarCliente.Controls.Add(this.txbNCliente);
            this.gbBuscarCliente.Controls.Add(this.lblRfc);
            this.gbBuscarCliente.Controls.Add(this.lblOtro);
            this.gbBuscarCliente.Controls.Add(this.lblNCliente);
            this.gbBuscarCliente.Controls.Add(this.label1);
            this.gbBuscarCliente.Controls.Add(this.lblBuscarCliente);
            this.gbBuscarCliente.Location = new System.Drawing.Point(-1, -8);
            this.gbBuscarCliente.Name = "gbBuscarCliente";
            this.gbBuscarCliente.Size = new System.Drawing.Size(332, 184);
            this.gbBuscarCliente.TabIndex = 0;
            this.gbBuscarCliente.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::LxCallcenter.Properties.Resources.find_user_male_48px;
            this.btnBuscar.ImageSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(264, 100);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoFocusImage = global::LxCallcenter.Properties.Resources.find_user_male_48px;
            this.btnBuscar.Size = new System.Drawing.Size(21, 21);
            this.btnBuscar.TabIndex = 231;
            this.metroToolTip1.SetToolTip(this.btnBuscar, "Buscar Cliente");
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbRfc
            // 
            this.txbRfc.Depth = 0;
            this.txbRfc.Hint = "";
            this.txbRfc.Location = new System.Drawing.Point(55, 125);
            this.txbRfc.MaxLength = 32767;
            this.txbRfc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbRfc.Name = "txbRfc";
            this.txbRfc.PasswordChar = '\0';
            this.txbRfc.SelectedText = "";
            this.txbRfc.SelectionLength = 0;
            this.txbRfc.SelectionStart = 0;
            this.txbRfc.Size = new System.Drawing.Size(194, 23);
            this.txbRfc.TabIndex = 230;
            this.txbRfc.TabStop = false;
            this.txbRfc.UseSystemPasswordChar = false;
            this.txbRfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mayusculas);
            this.txbRfc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbRfc_MouseClick);
            // 
            // txbNCliente
            // 
            this.txbNCliente.Depth = 0;
            this.txbNCliente.Hint = "";
            this.txbNCliente.Location = new System.Drawing.Point(55, 63);
            this.txbNCliente.MaxLength = 32767;
            this.txbNCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbNCliente.Name = "txbNCliente";
            this.txbNCliente.PasswordChar = '\0';
            this.txbNCliente.SelectedText = "";
            this.txbNCliente.SelectionLength = 0;
            this.txbNCliente.SelectionStart = 0;
            this.txbNCliente.Size = new System.Drawing.Size(194, 23);
            this.txbNCliente.TabIndex = 229;
            this.txbNCliente.TabStop = false;
            this.txbNCliente.UseSystemPasswordChar = false;
            this.txbNCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mayusculas);
            this.txbNCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbNCliente_MouseClick);
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.Depth = 0;
            this.lblRfc.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRfc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRfc.Location = new System.Drawing.Point(51, 103);
            this.lblRfc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(38, 20);
            this.lblRfc.TabIndex = 228;
            this.lblRfc.Text = "RFC";
            // 
            // lblOtro
            // 
            this.lblOtro.AutoSize = true;
            this.lblOtro.Depth = 0;
            this.lblOtro.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOtro.Location = new System.Drawing.Point(16, 72);
            this.lblOtro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOtro.Name = "lblOtro";
            this.lblOtro.Size = new System.Drawing.Size(18, 20);
            this.lblOtro.TabIndex = 227;
            this.lblOtro.Text = "o";
            // 
            // lblNCliente
            // 
            this.lblNCliente.AutoSize = true;
            this.lblNCliente.Depth = 0;
            this.lblNCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNCliente.Location = new System.Drawing.Point(51, 41);
            this.lblNCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNCliente.Name = "lblNCliente";
            this.lblNCliente.Size = new System.Drawing.Size(137, 20);
            this.lblNCliente.TabIndex = 226;
            this.lblNCliente.Text = "Número de Cliente";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 225;
            this.label1.Text = "Buscar Cliente";
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCliente.ForeColor = System.Drawing.Color.Red;
            this.lblBuscarCliente.Location = new System.Drawing.Point(89, 151);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(136, 15);
            this.lblBuscarCliente.TabIndex = 7;
            this.lblBuscarCliente.Text = "* Cliente no encontrado.";
            this.lblBuscarCliente.Visible = false;
            // 
            // gbCliente
            // 
            this.gbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCliente.Controls.Add(this.ovalPictureBox1);
            this.gbCliente.Controls.Add(this.txbEMail);
            this.gbCliente.Controls.Add(this.txbCelular);
            this.gbCliente.Controls.Add(this.txbNombre);
            this.gbCliente.Controls.Add(this.lblCorreoE);
            this.gbCliente.Controls.Add(this.lblCelular);
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.lblCActivo);
            this.gbCliente.Location = new System.Drawing.Point(-1, 178);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(332, 191);
            this.gbCliente.TabIndex = 1;
            this.gbCliente.TabStop = false;
            // 
            // txbEMail
            // 
            this.txbEMail.AutoSize = true;
            this.txbEMail.BackColor = System.Drawing.Color.Transparent;
            this.txbEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbEMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.txbEMail.Location = new System.Drawing.Point(90, 141);
            this.txbEMail.Name = "txbEMail";
            this.txbEMail.Size = new System.Drawing.Size(0, 17);
            this.txbEMail.TabIndex = 17;
            // 
            // txbCelular
            // 
            this.txbCelular.AutoSize = true;
            this.txbCelular.BackColor = System.Drawing.Color.Transparent;
            this.txbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.txbCelular.Location = new System.Drawing.Point(90, 94);
            this.txbCelular.Name = "txbCelular";
            this.txbCelular.Size = new System.Drawing.Size(0, 17);
            this.txbCelular.TabIndex = 16;
            // 
            // txbNombre
            // 
            this.txbNombre.AutoSize = true;
            this.txbNombre.BackColor = System.Drawing.Color.Transparent;
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.txbNombre.Location = new System.Drawing.Point(90, 47);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(0, 17);
            this.txbNombre.TabIndex = 15;
            // 
            // lblCorreoE
            // 
            this.lblCorreoE.AutoSize = true;
            this.lblCorreoE.Depth = 0;
            this.lblCorreoE.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCorreoE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCorreoE.Location = new System.Drawing.Point(90, 123);
            this.lblCorreoE.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCorreoE.Name = "lblCorreoE";
            this.lblCorreoE.Size = new System.Drawing.Size(51, 20);
            this.lblCorreoE.TabIndex = 11;
            this.lblCorreoE.Text = "E-mail";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Depth = 0;
            this.lblCelular.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCelular.Location = new System.Drawing.Point(90, 76);
            this.lblCelular.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(57, 20);
            this.lblCelular.TabIndex = 10;
            this.lblCelular.Text = "Celular";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(90, 29);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCActivo
            // 
            this.lblCActivo.AutoSize = true;
            this.lblCActivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCActivo.ForeColor = System.Drawing.Color.Red;
            this.lblCActivo.Location = new System.Drawing.Point(10, 137);
            this.lblCActivo.Name = "lblCActivo";
            this.lblCActivo.Size = new System.Drawing.Size(69, 30);
            this.lblCActivo.TabIndex = 8;
            this.lblCActivo.Text = "* Cliente no\r\nactivo.";
            this.lblCActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCActivo.Visible = false;
            // 
            // gbMensaje
            // 
            this.gbMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMensaje.Controls.Add(this.cmbxMensaje);
            this.gbMensaje.Controls.Add(this.lollipopLabel2);
            this.gbMensaje.Controls.Add(this.lollipopLabel1);
            this.gbMensaje.Controls.Add(this.btnEnviar);
            this.gbMensaje.Controls.Add(this.lblCaracteres);
            this.gbMensaje.Controls.Add(this.txbMensaje);
            this.gbMensaje.Location = new System.Drawing.Point(-1, 366);
            this.gbMensaje.Name = "gbMensaje";
            this.gbMensaje.Size = new System.Drawing.Size(332, 246);
            this.gbMensaje.TabIndex = 2;
            this.gbMensaje.TabStop = false;
            this.gbMensaje.Visible = false;
            // 
            // cmbxMensaje
            // 
            this.cmbxMensaje.FormattingEnabled = true;
            this.cmbxMensaje.ItemHeight = 23;
            this.cmbxMensaje.Location = new System.Drawing.Point(10, 49);
            this.cmbxMensaje.Name = "cmbxMensaje";
            this.cmbxMensaje.Size = new System.Drawing.Size(290, 29);
            this.cmbxMensaje.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cmbxMensaje.TabIndex = 9;
            this.cmbxMensaje.UseSelectable = true;
            this.cmbxMensaje.SelectionChangeCommitted += new System.EventHandler(this.cmbxMensaje_SelectionChangeCommitted);
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(10, 85);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(61, 17);
            this.lollipopLabel2.TabIndex = 8;
            this.lollipopLabel2.Text = "Mensaje";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(7, 28);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(113, 17);
            this.lollipopLabel1.TabIndex = 7;
            this.lollipopLabel1.Text = "Tipo de Mensaje";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Image = global::LxCallcenter.Properties.Resources.sent_96px;
            this.btnEnviar.ImageSize = 47;
            this.btnEnviar.Location = new System.Drawing.Point(256, 182);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.NoFocusImage = global::LxCallcenter.Properties.Resources.sent_96px;
            this.btnEnviar.Size = new System.Drawing.Size(51, 51);
            this.btnEnviar.TabIndex = 5;
            this.metroToolTip1.SetToolTip(this.btnEnviar, "Enviar SMS");
            this.btnEnviar.UseSelectable = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.BackColor = System.Drawing.Color.Transparent;
            this.lblCaracteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCaracteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblCaracteres.Location = new System.Drawing.Point(7, 177);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(145, 17);
            this.lblCaracteres.TabIndex = 4;
            this.lblCaracteres.Text = "Caracteres: 0 de 140.";
            this.lblCaracteres.Visible = false;
            // 
            // txbMensaje
            // 
            this.txbMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMensaje.FocusedColor = "#FFA300";
            this.txbMensaje.FontColor = "#000000";
            this.txbMensaje.IsEnabled = true;
            this.txbMensaje.Location = new System.Drawing.Point(10, 103);
            this.txbMensaje.MaxLength = 140;
            this.txbMensaje.Multiline = true;
            this.txbMensaje.Name = "txbMensaje";
            this.txbMensaje.ReadOnly = true;
            this.txbMensaje.Size = new System.Drawing.Size(291, 71);
            this.txbMensaje.TabIndex = 3;
            this.txbMensaje.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbMensaje.UseSystemPasswordChar = false;
            this.txbMensaje.TextChanged += new System.EventHandler(this.txbMensaje_TextChanged);
            this.txbMensaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMensaje_KeyPress);
            this.txbMensaje.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbMensaje_KeyUp);
            // 
            // MensajeError
            // 
            this.MensajeError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.MensajeError.ContainerControl = this;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.panel1.Location = new System.Drawing.Point(-1, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 13);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.panel2.Location = new System.Drawing.Point(-1, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 13);
            this.panel2.TabIndex = 4;
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.ovalPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ovalPictureBox1.Image = global::LxCallcenter.Properties.Resources.circled_user_male_skin_type_1_2_96px;
            this.ovalPictureBox1.Location = new System.Drawing.Point(6, 41);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(84, 84);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox1.TabIndex = 18;
            this.ovalPictureBox1.TabStop = false;
            // 
            // ClienteSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(328, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbMensaje);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbBuscarCliente);
            this.Name = "ClienteSMS";
            this.Text = "ClienteSMS";
            this.gbBuscarCliente.ResumeLayout(false);
            this.gbBuscarCliente.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbMensaje.ResumeLayout(false);
            this.gbMensaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbBuscarCliente;
		private System.Windows.Forms.GroupBox gbCliente;
		private System.Windows.Forms.GroupBox gbMensaje;
		private System.Windows.Forms.ErrorProvider MensajeError;
		private System.Windows.Forms.Label lblBuscarCliente;
		private System.Windows.Forms.Label lblCActivo;
        private MaterialSkin.Controls.MaterialLabel lblRfc;
        private MaterialSkin.Controls.MaterialLabel lblOtro;
        private MaterialSkin.Controls.MaterialLabel lblNCliente;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLink btnBuscar;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbRfc;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbNCliente;
        private MaterialSkin.Controls.MaterialLabel lblCorreoE;
        private MaterialSkin.Controls.MaterialLabel lblCelular;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private LollipopTextBox txbMensaje;
        private LollipopLabel lblCaracteres;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLink btnEnviar;
        private LollipopLabel txbEMail;
        private LollipopLabel txbCelular;
        private LollipopLabel txbNombre;
        private LollipopLabel lollipopLabel1;
        private LollipopLabel lollipopLabel2;
        private MetroFramework.Controls.MetroComboBox cmbxMensaje;
        private OvalPictureBox ovalPictureBox1;
    }
}