namespace LxCallcenter
{
    partial class RegistrarLlamadaModal
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
            this.pnlBusquedaCliente = new System.Windows.Forms.Panel();
            this.lnkBuscarCliente = new LollipopButton();
            this.lnkDirectorio = new MetroFramework.Controls.MetroLink();
            this.lblResultado = new LollipopLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlComentarioFolio = new System.Windows.Forms.Panel();
            this.btnGuardaHistorial = new LollipopButton();
            this.pnlNuevoTipoLlamada = new System.Windows.Forms.Panel();
            this.btnCancelarAgregarTipoLlamada = new LollipopFlatButton();
            this.btnAgregarTipoLlamada = new LollipopButton();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNuevoTipoLlamada = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnNuevoTipoLlamada = new MetroFramework.Controls.MetroLink();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lnkGuardarLlamada = new LollipopButton();
            this.txbDescripcion = new LollipopTextBox();
            this.lblDescripcion = new MaterialSkin.Controls.MaterialLabel();
            this.cbTipoLlamada = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.pnlInformacionCliente = new System.Windows.Forms.Panel();
            this.ovalPictureBox1 = new LxCallcenter.OvalPictureBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.ckbActivo = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnAsignarFolio = new LollipopButton();
            this.lblTelMovil = new LollipopLabel();
            this.lollipopLabel6 = new LollipopLabel();
            this.lollipopLabel7 = new LollipopLabel();
            this.lblCorreoElectronico = new LollipopLabel();
            this.lollipopLabel5 = new LollipopLabel();
            this.lblNombreCliente = new LollipopLabel();
            this.lblNoCliente = new LollipopLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.scFoliosAbiertos = new System.Windows.Forms.SplitContainer();
            this.flpFolios = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPersonalInterno = new LollipopFlatButton();
            this.btnCliente = new LollipopFlatButton();
            this.lollipopCard2 = new LollipopCard();
            this.lollipopCard1 = new LollipopCard();
            this.cmbCoordinador = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pnlBusquedaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlComentarioFolio.SuspendLayout();
            this.pnlNuevoTipoLlamada.SuspendLayout();
            this.pnlInformacionCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scFoliosAbiertos)).BeginInit();
            this.scFoliosAbiertos.Panel1.SuspendLayout();
            this.scFoliosAbiertos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBusquedaCliente
            // 
            this.pnlBusquedaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBusquedaCliente.Controls.Add(this.lnkBuscarCliente);
            this.pnlBusquedaCliente.Controls.Add(this.lnkDirectorio);
            this.pnlBusquedaCliente.Controls.Add(this.lblResultado);
            this.pnlBusquedaCliente.Controls.Add(this.materialLabel1);
            this.pnlBusquedaCliente.Controls.Add(this.txtBuscarCliente);
            this.pnlBusquedaCliente.Location = new System.Drawing.Point(-1, 6);
            this.pnlBusquedaCliente.Name = "pnlBusquedaCliente";
            this.pnlBusquedaCliente.Size = new System.Drawing.Size(973, 66);
            this.pnlBusquedaCliente.TabIndex = 87;
            this.pnlBusquedaCliente.Visible = false;
            // 
            // lnkBuscarCliente
            // 
            this.lnkBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.lnkBuscarCliente.BGColor = "#508ef5";
            this.lnkBuscarCliente.FontColor = "#ffffff";
            this.lnkBuscarCliente.Location = new System.Drawing.Point(262, 37);
            this.lnkBuscarCliente.Name = "lnkBuscarCliente";
            this.lnkBuscarCliente.Size = new System.Drawing.Size(72, 24);
            this.lnkBuscarCliente.TabIndex = 6;
            this.lnkBuscarCliente.Text = "Buscar";
            this.lnkBuscarCliente.Click += new System.EventHandler(this.lnkBuscarCliente_Click);
            // 
            // lnkDirectorio
            // 
            this.lnkDirectorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkDirectorio.Image = global::LxCallcenter.Properties.Resources.address_book_48px;
            this.lnkDirectorio.ImageSize = 25;
            this.lnkDirectorio.Location = new System.Drawing.Point(934, 35);
            this.lnkDirectorio.Name = "lnkDirectorio";
            this.lnkDirectorio.NoFocusImage = global::LxCallcenter.Properties.Resources.address_book_48px;
            this.lnkDirectorio.Size = new System.Drawing.Size(25, 25);
            this.lnkDirectorio.TabIndex = 5;
            this.metroToolTip1.SetToolTip(this.lnkDirectorio, "Ver Directorio de Clientes");
            this.lnkDirectorio.UseSelectable = true;
            this.lnkDirectorio.Click += new System.EventHandler(this.lnkDirectorio_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultado.ForeColor = System.Drawing.Color.Maroon;
            this.lblResultado.Location = new System.Drawing.Point(286, 42);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 17);
            this.lblResultado.TabIndex = 4;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(37, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 20);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Buscar Cliente";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscarCliente.Depth = 0;
            this.txtBuscarCliente.Hint = "No. Cliente o RFC";
            this.txtBuscarCliente.Location = new System.Drawing.Point(41, 36);
            this.txtBuscarCliente.MaxLength = 32767;
            this.txtBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.PasswordChar = '\0';
            this.txtBuscarCliente.ReadOnly = false;
            this.txtBuscarCliente.SelectedText = "";
            this.txtBuscarCliente.SelectionLength = 0;
            this.txtBuscarCliente.SelectionStart = 0;
            this.txtBuscarCliente.Size = new System.Drawing.Size(209, 25);
            this.txtBuscarCliente.TabIndex = 0;
            this.txtBuscarCliente.TabStop = false;
            this.txtBuscarCliente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscarCliente.UseSystemPasswordChar = false;
            this.txtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mayusculas);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LxCallcenter.Properties.Resources.info_25px;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(889, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 18);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pnlComentarioFolio
            // 
            this.pnlComentarioFolio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlComentarioFolio.Controls.Add(this.cmbCoordinador);
            this.pnlComentarioFolio.Controls.Add(this.materialLabel2);
            this.pnlComentarioFolio.Controls.Add(this.btnGuardaHistorial);
            this.pnlComentarioFolio.Controls.Add(this.pnlNuevoTipoLlamada);
            this.pnlComentarioFolio.Controls.Add(this.btnNuevoTipoLlamada);
            this.pnlComentarioFolio.Controls.Add(this.panel5);
            this.pnlComentarioFolio.Controls.Add(this.lnkGuardarLlamada);
            this.pnlComentarioFolio.Controls.Add(this.txbDescripcion);
            this.pnlComentarioFolio.Controls.Add(this.lblDescripcion);
            this.pnlComentarioFolio.Controls.Add(this.cbTipoLlamada);
            this.pnlComentarioFolio.Controls.Add(this.label1);
            this.pnlComentarioFolio.Location = new System.Drawing.Point(-1, 257);
            this.pnlComentarioFolio.Name = "pnlComentarioFolio";
            this.pnlComentarioFolio.Size = new System.Drawing.Size(973, 232);
            this.pnlComentarioFolio.TabIndex = 5;
            this.pnlComentarioFolio.Visible = false;
            // 
            // btnGuardaHistorial
            // 
            this.btnGuardaHistorial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardaHistorial.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardaHistorial.BGColor = "#001489";
            this.btnGuardaHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardaHistorial.FontColor = "#ffffff";
            this.btnGuardaHistorial.Location = new System.Drawing.Point(634, 192);
            this.btnGuardaHistorial.Name = "btnGuardaHistorial";
            this.btnGuardaHistorial.Size = new System.Drawing.Size(126, 24);
            this.btnGuardaHistorial.TabIndex = 65;
            this.btnGuardaHistorial.Text = "Guardar";
            this.btnGuardaHistorial.Visible = false;
            this.btnGuardaHistorial.Click += new System.EventHandler(this.btnGuardaHistorial_Click);
            // 
            // pnlNuevoTipoLlamada
            // 
            this.pnlNuevoTipoLlamada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlNuevoTipoLlamada.Controls.Add(this.btnCancelarAgregarTipoLlamada);
            this.pnlNuevoTipoLlamada.Controls.Add(this.btnAgregarTipoLlamada);
            this.pnlNuevoTipoLlamada.Controls.Add(this.label2);
            this.pnlNuevoTipoLlamada.Controls.Add(this.txtNuevoTipoLlamada);
            this.pnlNuevoTipoLlamada.Location = new System.Drawing.Point(262, 20);
            this.pnlNuevoTipoLlamada.Name = "pnlNuevoTipoLlamada";
            this.pnlNuevoTipoLlamada.Size = new System.Drawing.Size(389, 71);
            this.pnlNuevoTipoLlamada.TabIndex = 63;
            this.pnlNuevoTipoLlamada.Visible = false;
            // 
            // btnCancelarAgregarTipoLlamada
            // 
            this.btnCancelarAgregarTipoLlamada.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarAgregarTipoLlamada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarAgregarTipoLlamada.FontColor = "#508ef5";
            this.btnCancelarAgregarTipoLlamada.Location = new System.Drawing.Point(301, 35);
            this.btnCancelarAgregarTipoLlamada.Name = "btnCancelarAgregarTipoLlamada";
            this.btnCancelarAgregarTipoLlamada.Size = new System.Drawing.Size(76, 24);
            this.btnCancelarAgregarTipoLlamada.TabIndex = 52;
            this.btnCancelarAgregarTipoLlamada.Text = "Cancelar";
            this.btnCancelarAgregarTipoLlamada.Click += new System.EventHandler(this.btnNuevoTipoLlamada_Click);
            // 
            // btnAgregarTipoLlamada
            // 
            this.btnAgregarTipoLlamada.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarTipoLlamada.BGColor = "#001489";
            this.btnAgregarTipoLlamada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTipoLlamada.FontColor = "#ffffff";
            this.btnAgregarTipoLlamada.Location = new System.Drawing.Point(205, 35);
            this.btnAgregarTipoLlamada.Name = "btnAgregarTipoLlamada";
            this.btnAgregarTipoLlamada.Size = new System.Drawing.Size(90, 24);
            this.btnAgregarTipoLlamada.TabIndex = 51;
            this.btnAgregarTipoLlamada.Text = "Agregar";
            this.btnAgregarTipoLlamada.Click += new System.EventHandler(this.btnAgregarTipoLlamada_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nuevo Tipo de Llamada";
            // 
            // txtNuevoTipoLlamada
            // 
            this.txtNuevoTipoLlamada.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNuevoTipoLlamada.Depth = 0;
            this.txtNuevoTipoLlamada.Hint = "";
            this.txtNuevoTipoLlamada.Location = new System.Drawing.Point(11, 34);
            this.txtNuevoTipoLlamada.MaxLength = 32767;
            this.txtNuevoTipoLlamada.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNuevoTipoLlamada.Name = "txtNuevoTipoLlamada";
            this.txtNuevoTipoLlamada.PasswordChar = '\0';
            this.txtNuevoTipoLlamada.ReadOnly = false;
            this.txtNuevoTipoLlamada.SelectedText = "";
            this.txtNuevoTipoLlamada.SelectionLength = 0;
            this.txtNuevoTipoLlamada.SelectionStart = 0;
            this.txtNuevoTipoLlamada.Size = new System.Drawing.Size(180, 25);
            this.txtNuevoTipoLlamada.TabIndex = 49;
            this.txtNuevoTipoLlamada.TabStop = false;
            this.txtNuevoTipoLlamada.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNuevoTipoLlamada.UseSystemPasswordChar = false;
            // 
            // btnNuevoTipoLlamada
            // 
            this.btnNuevoTipoLlamada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevoTipoLlamada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoTipoLlamada.Image = global::LxCallcenter.Properties.Resources.plus_48px;
            this.btnNuevoTipoLlamada.ImageSize = 25;
            this.btnNuevoTipoLlamada.Location = new System.Drawing.Point(263, 51);
            this.btnNuevoTipoLlamada.Name = "btnNuevoTipoLlamada";
            this.btnNuevoTipoLlamada.Size = new System.Drawing.Size(26, 26);
            this.btnNuevoTipoLlamada.TabIndex = 64;
            this.btnNuevoTipoLlamada.UseSelectable = true;
            this.btnNuevoTipoLlamada.Click += new System.EventHandler(this.btnNuevoTipoLlamada_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(213)))), ((int)(((byte)(129)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(973, 2);
            this.panel5.TabIndex = 62;
            // 
            // lnkGuardarLlamada
            // 
            this.lnkGuardarLlamada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnkGuardarLlamada.BackColor = System.Drawing.Color.Transparent;
            this.lnkGuardarLlamada.BGColor = "#001489";
            this.lnkGuardarLlamada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkGuardarLlamada.FontColor = "#ffffff";
            this.lnkGuardarLlamada.Location = new System.Drawing.Point(766, 192);
            this.lnkGuardarLlamada.Name = "lnkGuardarLlamada";
            this.lnkGuardarLlamada.Size = new System.Drawing.Size(126, 24);
            this.lnkGuardarLlamada.TabIndex = 61;
            this.lnkGuardarLlamada.Text = "Guardar";
            this.lnkGuardarLlamada.Click += new System.EventHandler(this.lnkGuardarLlamada_Click);
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbDescripcion.FocusedColor = "#FFA300";
            this.txbDescripcion.FontColor = "#999999";
            this.txbDescripcion.IsEnabled = true;
            this.txbDescripcion.Location = new System.Drawing.Point(49, 106);
            this.txbDescripcion.MaxLength = 32767;
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.ReadOnly = false;
            this.txbDescripcion.Size = new System.Drawing.Size(843, 49);
            this.txbDescripcion.TabIndex = 60;
            this.txbDescripcion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbDescripcion.UseSystemPasswordChar = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Depth = 0;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescripcion.Location = new System.Drawing.Point(47, 83);
            this.lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 20);
            this.lblDescripcion.TabIndex = 59;
            this.lblDescripcion.Text = "Descripción";
            // 
            // cbTipoLlamada
            // 
            this.cbTipoLlamada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTipoLlamada.FormattingEnabled = true;
            this.cbTipoLlamada.ItemHeight = 23;
            this.cbTipoLlamada.Location = new System.Drawing.Point(49, 49);
            this.cbTipoLlamada.Name = "cbTipoLlamada";
            this.cbTipoLlamada.Size = new System.Drawing.Size(209, 29);
            this.cbTipoLlamada.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbTipoLlamada.TabIndex = 58;
            this.cbTipoLlamada.UseSelectable = true;
            this.cbTipoLlamada.SelectionChangeCommitted += new System.EventHandler(this.cbTipoLlamada_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tipo de Llamada";
            // 
            // pnlInformacionCliente
            // 
            this.pnlInformacionCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInformacionCliente.AutoScroll = true;
            this.pnlInformacionCliente.Controls.Add(this.ovalPictureBox1);
            this.pnlInformacionCliente.Controls.Add(this.lblFolio);
            this.pnlInformacionCliente.Controls.Add(this.pictureBox2);
            this.pnlInformacionCliente.Controls.Add(this.ckbActivo);
            this.pnlInformacionCliente.Controls.Add(this.btnAsignarFolio);
            this.pnlInformacionCliente.Controls.Add(this.lblTelMovil);
            this.pnlInformacionCliente.Controls.Add(this.lollipopLabel6);
            this.pnlInformacionCliente.Controls.Add(this.lollipopLabel7);
            this.pnlInformacionCliente.Controls.Add(this.lblCorreoElectronico);
            this.pnlInformacionCliente.Controls.Add(this.lollipopLabel5);
            this.pnlInformacionCliente.Controls.Add(this.lblNombreCliente);
            this.pnlInformacionCliente.Controls.Add(this.lblNoCliente);
            this.pnlInformacionCliente.Controls.Add(this.panel6);
            this.pnlInformacionCliente.Location = new System.Drawing.Point(-1, 71);
            this.pnlInformacionCliente.Name = "pnlInformacionCliente";
            this.pnlInformacionCliente.Size = new System.Drawing.Size(973, 187);
            this.pnlInformacionCliente.TabIndex = 3;
            this.pnlInformacionCliente.Visible = false;
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.ovalPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ovalPictureBox1.Image = global::LxCallcenter.Properties.Resources.circled_user_male_skin_type_1_2_96px;
            this.ovalPictureBox1.Location = new System.Drawing.Point(41, 24);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(90, 90);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox1.TabIndex = 52;
            this.ovalPictureBox1.TabStop = false;
            // 
            // lblFolio
            // 
            this.lblFolio.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.lblFolio.Location = new System.Drawing.Point(840, 44);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(106, 23);
            this.lblFolio.TabIndex = 51;
            this.lblFolio.Text = "--";
            this.lblFolio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Depth = 0;
            this.ckbActivo.Enabled = false;
            this.ckbActivo.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.ckbActivo.Location = new System.Drawing.Point(57, 118);
            this.ckbActivo.Margin = new System.Windows.Forms.Padding(0);
            this.ckbActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Ripple = true;
            this.ckbActivo.Size = new System.Drawing.Size(69, 30);
            this.ckbActivo.TabIndex = 50;
            this.ckbActivo.Text = "Activo";
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // btnAsignarFolio
            // 
            this.btnAsignarFolio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAsignarFolio.BackColor = System.Drawing.Color.Transparent;
            this.btnAsignarFolio.BGColor = "#001489";
            this.btnAsignarFolio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarFolio.FontColor = "#ffffff";
            this.btnAsignarFolio.Location = new System.Drawing.Point(766, 148);
            this.btnAsignarFolio.Name = "btnAsignarFolio";
            this.btnAsignarFolio.Size = new System.Drawing.Size(126, 24);
            this.btnAsignarFolio.TabIndex = 10;
            this.btnAsignarFolio.Text = "Asignar Folio";
            this.btnAsignarFolio.Click += new System.EventHandler(this.btnAsignarFolio_Click);
            // 
            // lblTelMovil
            // 
            this.lblTelMovil.AutoEllipsis = true;
            this.lblTelMovil.BackColor = System.Drawing.Color.Transparent;
            this.lblTelMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTelMovil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.lblTelMovil.Location = new System.Drawing.Point(397, 107);
            this.lblTelMovil.Name = "lblTelMovil";
            this.lblTelMovil.Size = new System.Drawing.Size(215, 17);
            this.lblTelMovil.TabIndex = 9;
            this.lblTelMovil.Text = "--";
            // 
            // lollipopLabel6
            // 
            this.lollipopLabel6.AutoSize = true;
            this.lollipopLabel6.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel6.Location = new System.Drawing.Point(396, 86);
            this.lollipopLabel6.Name = "lollipopLabel6";
            this.lollipopLabel6.Size = new System.Drawing.Size(68, 17);
            this.lollipopLabel6.TabIndex = 8;
            this.lollipopLabel6.Text = "Tel. móvil";
            // 
            // lollipopLabel7
            // 
            this.lollipopLabel7.AutoSize = true;
            this.lollipopLabel7.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel7.Location = new System.Drawing.Point(904, 25);
            this.lollipopLabel7.Name = "lollipopLabel7";
            this.lollipopLabel7.Size = new System.Drawing.Size(38, 17);
            this.lollipopLabel7.TabIndex = 11;
            this.lollipopLabel7.Text = "Folio";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoEllipsis = true;
            this.lblCorreoElectronico.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCorreoElectronico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.lblCorreoElectronico.Location = new System.Drawing.Point(396, 64);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(215, 17);
            this.lblCorreoElectronico.TabIndex = 7;
            this.lblCorreoElectronico.Text = "--";
            // 
            // lollipopLabel5
            // 
            this.lollipopLabel5.AutoSize = true;
            this.lollipopLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel5.Location = new System.Drawing.Point(396, 45);
            this.lollipopLabel5.Name = "lollipopLabel5";
            this.lollipopLabel5.Size = new System.Drawing.Size(125, 17);
            this.lollipopLabel5.TabIndex = 6;
            this.lollipopLabel5.Text = "Correo Electrónico";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoEllipsis = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.lblNombreCliente.Location = new System.Drawing.Point(145, 73);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(215, 17);
            this.lblNombreCliente.TabIndex = 5;
            this.lblNombreCliente.Text = "--";
            // 
            // lblNoCliente
            // 
            this.lblNoCliente.AutoSize = true;
            this.lblNoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblNoCliente.Location = new System.Drawing.Point(145, 54);
            this.lblNoCliente.Name = "lblNoCliente";
            this.lblNoCliente.Size = new System.Drawing.Size(18, 17);
            this.lblNoCliente.TabIndex = 4;
            this.lblNoCliente.Text = "--";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(973, 9);
            this.panel6.TabIndex = 3;
            // 
            // MensajeError
            // 
            this.MensajeError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.MensajeError.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 605);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 3);
            this.panel1.TabIndex = 88;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // scFoliosAbiertos
            // 
            this.scFoliosAbiertos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scFoliosAbiertos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.scFoliosAbiertos.Location = new System.Drawing.Point(0, 501);
            this.scFoliosAbiertos.Name = "scFoliosAbiertos";
            // 
            // scFoliosAbiertos.Panel1
            // 
            this.scFoliosAbiertos.Panel1.AutoScroll = true;
            this.scFoliosAbiertos.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.scFoliosAbiertos.Panel1.Controls.Add(this.flpFolios);
            this.scFoliosAbiertos.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // scFoliosAbiertos.Panel2
            // 
            this.scFoliosAbiertos.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.scFoliosAbiertos.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scFoliosAbiertos.Size = new System.Drawing.Size(970, 332);
            this.scFoliosAbiertos.SplitterDistance = 143;
            this.scFoliosAbiertos.SplitterWidth = 1;
            this.scFoliosAbiertos.TabIndex = 89;
            this.scFoliosAbiertos.Visible = false;
            // 
            // flpFolios
            // 
            this.flpFolios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpFolios.AutoScroll = true;
            this.flpFolios.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFolios.Location = new System.Drawing.Point(0, 82);
            this.flpFolios.Name = "flpFolios";
            this.flpFolios.Size = new System.Drawing.Size(143, 250);
            this.flpFolios.TabIndex = 0;
            this.flpFolios.WrapContents = false;
            // 
            // btnPersonalInterno
            // 
            this.btnPersonalInterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPersonalInterno.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonalInterno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonalInterno.FontColor = "#508ef5";
            this.btnPersonalInterno.Location = new System.Drawing.Point(713, 329);
            this.btnPersonalInterno.Name = "btnPersonalInterno";
            this.btnPersonalInterno.Size = new System.Drawing.Size(76, 30);
            this.btnPersonalInterno.TabIndex = 86;
            this.btnPersonalInterno.Text = "Aceptar";
            this.btnPersonalInterno.Visible = false;
            this.btnPersonalInterno.Click += new System.EventHandler(this.btnPersonalInterno_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.FontColor = "#508ef5";
            this.btnCliente.Location = new System.Drawing.Point(362, 329);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(76, 30);
            this.btnCliente.TabIndex = 84;
            this.btnCliente.Text = "Aceptar";
            this.btnCliente.Visible = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // lollipopCard2
            // 
            this.lollipopCard2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lollipopCard2.ButtonColor = "#33b679";
            this.lollipopCard2.ContentColor = "#444444";
            this.lollipopCard2.ContentText = "Asigne la llamada a un personal interno.";
            this.lollipopCard2.Image = global::LxCallcenter.Properties.Resources.Imagen2;
            this.lollipopCard2.Location = new System.Drawing.Point(513, 75);
            this.lollipopCard2.Name = "lollipopCard2";
            this.lollipopCard2.Size = new System.Drawing.Size(294, 299);
            this.lollipopCard2.TabIndex = 85;
            this.lollipopCard2.Text = "Llamada Interna";
            this.lollipopCard2.TitleColor = "#3F51B5";
            // 
            // lollipopCard1
            // 
            this.lollipopCard1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lollipopCard1.ButtonColor = "#33b679";
            this.lollipopCard1.ContentColor = "#444444";
            this.lollipopCard1.ContentText = "Asigne la llamada a un cliente.";
            this.lollipopCard1.Image = global::LxCallcenter.Properties.Resources.Imagen1;
            this.lollipopCard1.Location = new System.Drawing.Point(168, 75);
            this.lollipopCard1.Name = "lollipopCard1";
            this.lollipopCard1.Size = new System.Drawing.Size(294, 299);
            this.lollipopCard1.TabIndex = 83;
            this.lollipopCard1.Text = "Llamada Externa";
            this.lollipopCard1.TitleColor = "#3F51B5";
            // 
            // cmbCoordinador
            // 
            this.cmbCoordinador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCoordinador.FormattingEnabled = true;
            this.cmbCoordinador.ItemHeight = 23;
            this.cmbCoordinador.Location = new System.Drawing.Point(49, 187);
            this.cmbCoordinador.Name = "cmbCoordinador";
            this.cmbCoordinador.Size = new System.Drawing.Size(209, 29);
            this.cmbCoordinador.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cmbCoordinador.TabIndex = 67;
            this.cmbCoordinador.UseSelectable = true;
            this.cmbCoordinador.Visible = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(47, 165);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(40, 20);
            this.materialLabel2.TabIndex = 66;
            this.materialLabel2.Text = "Area";
            this.materialLabel2.Visible = false;
            // 
            // RegistrarLlamadaModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(970, 608);
            this.Controls.Add(this.scFoliosAbiertos);
            this.Controls.Add(this.pnlInformacionCliente);
            this.Controls.Add(this.pnlComentarioFolio);
            this.Controls.Add(this.pnlBusquedaCliente);
            this.Controls.Add(this.btnPersonalInterno);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lollipopCard2);
            this.Controls.Add(this.lollipopCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarLlamadaModal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RegistrarLlamadaModal";
            this.pnlBusquedaCliente.ResumeLayout(false);
            this.pnlBusquedaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlComentarioFolio.ResumeLayout(false);
            this.pnlComentarioFolio.PerformLayout();
            this.pnlNuevoTipoLlamada.ResumeLayout(false);
            this.pnlNuevoTipoLlamada.PerformLayout();
            this.pnlInformacionCliente.ResumeLayout(false);
            this.pnlInformacionCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.scFoliosAbiertos.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scFoliosAbiertos)).EndInit();
            this.scFoliosAbiertos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LollipopFlatButton btnCliente;
        private LollipopCard lollipopCard1;
        private LollipopFlatButton btnPersonalInterno;
        private LollipopCard lollipopCard2;
        private System.Windows.Forms.Panel pnlBusquedaCliente;
        private LollipopLabel lblResultado;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarCliente;
        private System.Windows.Forms.Panel pnlComentarioFolio;
        private System.Windows.Forms.Panel panel5;
        private LollipopButton lnkGuardarLlamada;
        private LollipopTextBox txbDescripcion;
        private MaterialSkin.Controls.MaterialLabel lblDescripcion;
        private MetroFramework.Controls.MetroComboBox cbTipoLlamada;
        private MaterialSkin.Controls.MaterialLabel label1;
        private System.Windows.Forms.Panel pnlInformacionCliente;
        private LollipopLabel lollipopLabel7;
        private LollipopButton btnAsignarFolio;
        private LollipopLabel lblTelMovil;
        private LollipopLabel lollipopLabel6;
        private LollipopLabel lblCorreoElectronico;
        private LollipopLabel lollipopLabel5;
        private LollipopLabel lblNombreCliente;
        private LollipopLabel lblNoCliente;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialCheckBox ckbActivo;
        private System.Windows.Forms.Panel pnlNuevoTipoLlamada;
        private LollipopFlatButton btnCancelarAgregarTipoLlamada;
        private LollipopButton btnAgregarTipoLlamada;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNuevoTipoLlamada;
        private MetroFramework.Controls.MetroLink btnNuevoTipoLlamada;
        private System.Windows.Forms.ErrorProvider MensajeError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private LollipopButton btnGuardaHistorial;
        private System.Windows.Forms.SplitContainer scFoliosAbiertos;
        private System.Windows.Forms.Label lblFolio;
        private MetroFramework.Controls.MetroLink lnkDirectorio;
        private System.Windows.Forms.FlowLayoutPanel flpFolios;
        private OvalPictureBox ovalPictureBox1;
        private LollipopButton lnkBuscarCliente;
        private MetroFramework.Controls.MetroComboBox cmbCoordinador;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}