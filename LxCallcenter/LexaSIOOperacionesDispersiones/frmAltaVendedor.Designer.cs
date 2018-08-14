namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    partial class frmAltaVendedor
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNumCliente = new System.Windows.Forms.Label();
            this.gbVendedor = new System.Windows.Forms.GroupBox();
            this.txbNoExpediente = new System.Windows.Forms.TextBox();
            this.cbEstados = new MetroFramework.Controls.MetroComboBox();
            this.cbComisionista = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNivel = new MetroFramework.Controls.MetroComboBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.txbCorreoCliente = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txbMovil = new System.Windows.Forms.TextBox();
            this.lblMovil = new System.Windows.Forms.Label();
            this.txbExtension = new System.Windows.Forms.TextBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txbCP = new System.Windows.Forms.TextBox();
            this.lblCodigoP = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txbMunicipio = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txbCurp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbRfc = new System.Windows.Forms.TextBox();
            this.lblRfc = new System.Windows.Forms.Label();
            this.txbAMaterno = new System.Windows.Forms.TextBox();
            this.lblAMaterno = new System.Windows.Forms.Label();
            this.txbAPaterno = new System.Windows.Forms.TextBox();
            this.lblAPaterno = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.ckbActivo = new System.Windows.Forms.CheckBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.txbNVendedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbBVendedor = new MetroFramework.Controls.MetroTextBox();
            this.gbVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(90, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(117, 27);
            this.lblFecha.TabIndex = 87;
            this.lblFecha.Text = "Vendedores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 33);
            this.label4.TabIndex = 86;
            this.label4.Text = "Alta Vendedor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Image = global::LxCallcenter.Properties.Resources.Search_WF;
            this.btnBuscar.Location = new System.Drawing.Point(269, 101);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(22, 23);
            this.btnBuscar.TabIndex = 89;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNumCliente
            // 
            this.lblNumCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumCliente.AutoSize = true;
            this.lblNumCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumCliente.Location = new System.Drawing.Point(92, 86);
            this.lblNumCliente.Margin = new System.Windows.Forms.Padding(10);
            this.lblNumCliente.Name = "lblNumCliente";
            this.lblNumCliente.Size = new System.Drawing.Size(82, 13);
            this.lblNumCliente.TabIndex = 90;
            this.lblNumCliente.Text = "Numero Cliente:";
            // 
            // gbVendedor
            // 
            this.gbVendedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbVendedor.Controls.Add(this.txbNoExpediente);
            this.gbVendedor.Controls.Add(this.cbEstados);
            this.gbVendedor.Controls.Add(this.cbComisionista);
            this.gbVendedor.Controls.Add(this.label3);
            this.gbVendedor.Controls.Add(this.cbNivel);
            this.gbVendedor.Controls.Add(this.lblContador);
            this.gbVendedor.Controls.Add(this.lblServicio);
            this.gbVendedor.Controls.Add(this.txbCorreoCliente);
            this.gbVendedor.Controls.Add(this.lblCorreo);
            this.gbVendedor.Controls.Add(this.txbMovil);
            this.gbVendedor.Controls.Add(this.lblMovil);
            this.gbVendedor.Controls.Add(this.txbExtension);
            this.gbVendedor.Controls.Add(this.lblExtension);
            this.gbVendedor.Controls.Add(this.txbTelefono);
            this.gbVendedor.Controls.Add(this.lblTelefono);
            this.gbVendedor.Controls.Add(this.txbCP);
            this.gbVendedor.Controls.Add(this.lblCodigoP);
            this.gbVendedor.Controls.Add(this.lblEstado);
            this.gbVendedor.Controls.Add(this.txbMunicipio);
            this.gbVendedor.Controls.Add(this.lblMunicipio);
            this.gbVendedor.Controls.Add(this.txbDireccion);
            this.gbVendedor.Controls.Add(this.lblDireccion);
            this.gbVendedor.Controls.Add(this.txbCurp);
            this.gbVendedor.Controls.Add(this.label2);
            this.gbVendedor.Controls.Add(this.txbRfc);
            this.gbVendedor.Controls.Add(this.lblRfc);
            this.gbVendedor.Controls.Add(this.txbAMaterno);
            this.gbVendedor.Controls.Add(this.lblAMaterno);
            this.gbVendedor.Controls.Add(this.txbAPaterno);
            this.gbVendedor.Controls.Add(this.lblAPaterno);
            this.gbVendedor.Controls.Add(this.txbNombre);
            this.gbVendedor.Controls.Add(this.lblNombre);
            this.gbVendedor.Controls.Add(this.ckbActivo);
            this.gbVendedor.Controls.Add(this.lblActivo);
            this.gbVendedor.Controls.Add(this.txbNVendedor);
            this.gbVendedor.Controls.Add(this.label1);
            this.gbVendedor.Enabled = false;
            this.gbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVendedor.Location = new System.Drawing.Point(95, 149);
            this.gbVendedor.Name = "gbVendedor";
            this.gbVendedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbVendedor.Size = new System.Drawing.Size(863, 274);
            this.gbVendedor.TabIndex = 91;
            this.gbVendedor.TabStop = false;
            this.gbVendedor.Text = "INFORMACIÓN VENDEDOR";
            // 
            // txbNoExpediente
            // 
            this.txbNoExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNoExpediente.Location = new System.Drawing.Point(123, 85);
            this.txbNoExpediente.MaxLength = 45;
            this.txbNoExpediente.Name = "txbNoExpediente";
            this.txbNoExpediente.Size = new System.Drawing.Size(158, 20);
            this.txbNoExpediente.TabIndex = 41;
            // 
            // cbEstados
            // 
            this.cbEstados.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.ItemHeight = 19;
            this.cbEstados.Location = new System.Drawing.Point(413, 118);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(158, 25);
            this.cbEstados.TabIndex = 39;
            this.cbEstados.UseSelectable = true;
            // 
            // cbComisionista
            // 
            this.cbComisionista.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbComisionista.FormattingEnabled = true;
            this.cbComisionista.ItemHeight = 19;
            this.cbComisionista.Location = new System.Drawing.Point(413, 220);
            this.cbComisionista.Name = "cbComisionista";
            this.cbComisionista.Size = new System.Drawing.Size(276, 25);
            this.cbComisionista.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbComisionista.TabIndex = 38;
            this.cbComisionista.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "No. Expediente:";
            // 
            // cbNivel
            // 
            this.cbNivel.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.ItemHeight = 19;
            this.cbNivel.Location = new System.Drawing.Point(123, 220);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(158, 25);
            this.cbNivel.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbNivel.TabIndex = 37;
            this.cbNivel.UseSelectable = true;
            this.cbNivel.SelectedIndexChanged += new System.EventHandler(this.cbNivel_SelectedIndexChanged);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContador.Location = new System.Drawing.Point(76, 227);
            this.lblContador.Margin = new System.Windows.Forms.Padding(10);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(34, 13);
            this.lblContador.TabIndex = 36;
            this.lblContador.Text = "Nivel:";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServicio.Location = new System.Drawing.Point(332, 227);
            this.lblServicio.Margin = new System.Windows.Forms.Padding(10);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(68, 13);
            this.lblServicio.TabIndex = 28;
            this.lblServicio.Text = "Comisionista:";
            // 
            // txbCorreoCliente
            // 
            this.txbCorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCorreoCliente.Location = new System.Drawing.Point(123, 188);
            this.txbCorreoCliente.MaxLength = 45;
            this.txbCorreoCliente.Name = "txbCorreoCliente";
            this.txbCorreoCliente.Size = new System.Drawing.Size(370, 20);
            this.txbCorreoCliente.TabIndex = 27;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCorreo.Location = new System.Drawing.Point(13, 191);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(10);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(97, 13);
            this.lblCorreo.TabIndex = 26;
            this.lblCorreo.Text = "Correo Electrónico:";
            // 
            // txbMovil
            // 
            this.txbMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMovil.Location = new System.Drawing.Point(686, 155);
            this.txbMovil.MaxLength = 45;
            this.txbMovil.Name = "txbMovil";
            this.txbMovil.Size = new System.Drawing.Size(158, 20);
            this.txbMovil.TabIndex = 25;
            // 
            // lblMovil
            // 
            this.lblMovil.AutoSize = true;
            this.lblMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMovil.Location = new System.Drawing.Point(641, 158);
            this.lblMovil.Margin = new System.Windows.Forms.Padding(10);
            this.lblMovil.Name = "lblMovil";
            this.lblMovil.Size = new System.Drawing.Size(35, 13);
            this.lblMovil.TabIndex = 24;
            this.lblMovil.Text = "Movil:";
            // 
            // txbExtension
            // 
            this.txbExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbExtension.Location = new System.Drawing.Point(413, 155);
            this.txbExtension.MaxLength = 10;
            this.txbExtension.Name = "txbExtension";
            this.txbExtension.Size = new System.Drawing.Size(80, 20);
            this.txbExtension.TabIndex = 23;
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtension.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExtension.Location = new System.Drawing.Point(344, 158);
            this.lblExtension.Margin = new System.Windows.Forms.Padding(10);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(56, 13);
            this.lblExtension.TabIndex = 22;
            this.lblExtension.Text = "Extensión:";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefono.Location = new System.Drawing.Point(123, 155);
            this.txbTelefono.MaxLength = 45;
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(158, 20);
            this.txbTelefono.TabIndex = 21;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTelefono.Location = new System.Drawing.Point(58, 158);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(10);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 20;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txbCP
            // 
            this.txbCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCP.Location = new System.Drawing.Point(686, 118);
            this.txbCP.MaxLength = 45;
            this.txbCP.Name = "txbCP";
            this.txbCP.Size = new System.Drawing.Size(158, 20);
            this.txbCP.TabIndex = 19;
            // 
            // lblCodigoP
            // 
            this.lblCodigoP.AutoSize = true;
            this.lblCodigoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodigoP.Location = new System.Drawing.Point(598, 125);
            this.lblCodigoP.Margin = new System.Windows.Forms.Padding(10);
            this.lblCodigoP.Name = "lblCodigoP";
            this.lblCodigoP.Size = new System.Drawing.Size(75, 13);
            this.lblCodigoP.TabIndex = 18;
            this.lblCodigoP.Text = "Codigo Postal:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEstado.Location = new System.Drawing.Point(357, 125);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(10);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado:";
            // 
            // txbMunicipio
            // 
            this.txbMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMunicipio.Location = new System.Drawing.Point(123, 122);
            this.txbMunicipio.MaxLength = 45;
            this.txbMunicipio.Name = "txbMunicipio";
            this.txbMunicipio.Size = new System.Drawing.Size(158, 20);
            this.txbMunicipio.TabIndex = 15;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMunicipio.Location = new System.Drawing.Point(55, 125);
            this.lblMunicipio.Margin = new System.Windows.Forms.Padding(10);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(55, 13);
            this.lblMunicipio.TabIndex = 14;
            this.lblMunicipio.Text = "Municipio:";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDireccion.Location = new System.Drawing.Point(413, 85);
            this.txbDireccion.MaxLength = 250;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(431, 20);
            this.txbDireccion.TabIndex = 13;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDireccion.Location = new System.Drawing.Point(345, 88);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(10);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txbCurp
            // 
            this.txbCurp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurp.Location = new System.Drawing.Point(686, 23);
            this.txbCurp.MaxLength = 45;
            this.txbCurp.Name = "txbCurp";
            this.txbCurp.Size = new System.Drawing.Size(158, 20);
            this.txbCurp.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(633, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CURP:";
            // 
            // txbRfc
            // 
            this.txbRfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRfc.Location = new System.Drawing.Point(413, 23);
            this.txbRfc.MaxLength = 45;
            this.txbRfc.Name = "txbRfc";
            this.txbRfc.Size = new System.Drawing.Size(158, 20);
            this.txbRfc.TabIndex = 11;
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRfc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRfc.Location = new System.Drawing.Point(369, 26);
            this.lblRfc.Margin = new System.Windows.Forms.Padding(10);
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(31, 13);
            this.lblRfc.TabIndex = 10;
            this.lblRfc.Text = "RFC:";
            // 
            // txbAMaterno
            // 
            this.txbAMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAMaterno.Location = new System.Drawing.Point(686, 56);
            this.txbAMaterno.MaxLength = 45;
            this.txbAMaterno.Name = "txbAMaterno";
            this.txbAMaterno.Size = new System.Drawing.Size(158, 20);
            this.txbAMaterno.TabIndex = 9;
            // 
            // lblAMaterno
            // 
            this.lblAMaterno.AutoSize = true;
            this.lblAMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMaterno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAMaterno.Location = new System.Drawing.Point(584, 59);
            this.lblAMaterno.Margin = new System.Windows.Forms.Padding(10);
            this.lblAMaterno.Name = "lblAMaterno";
            this.lblAMaterno.Size = new System.Drawing.Size(89, 13);
            this.lblAMaterno.TabIndex = 8;
            this.lblAMaterno.Text = "Apellido Materno:";
            // 
            // txbAPaterno
            // 
            this.txbAPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAPaterno.Location = new System.Drawing.Point(413, 56);
            this.txbAPaterno.MaxLength = 45;
            this.txbAPaterno.Name = "txbAPaterno";
            this.txbAPaterno.Size = new System.Drawing.Size(158, 20);
            this.txbAPaterno.TabIndex = 7;
            // 
            // lblAPaterno
            // 
            this.lblAPaterno.AutoSize = true;
            this.lblAPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPaterno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAPaterno.Location = new System.Drawing.Point(313, 59);
            this.lblAPaterno.Margin = new System.Windows.Forms.Padding(10);
            this.lblAPaterno.Name = "lblAPaterno";
            this.lblAPaterno.Size = new System.Drawing.Size(87, 13);
            this.lblAPaterno.TabIndex = 6;
            this.lblAPaterno.Text = "Apellido Paterno:";
            // 
            // txbNombre
            // 
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(123, 56);
            this.txbNombre.MaxLength = 45;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(158, 20);
            this.txbNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(63, 59);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Location = new System.Drawing.Point(824, 223);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Size = new System.Drawing.Size(15, 14);
            this.ckbActivo.TabIndex = 3;
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblActivo.Location = new System.Drawing.Point(771, 223);
            this.lblActivo.Margin = new System.Windows.Forms.Padding(10);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(40, 13);
            this.lblActivo.TabIndex = 2;
            this.lblActivo.Text = "Activo:";
            // 
            // txbNVendedor
            // 
            this.txbNVendedor.Enabled = false;
            this.txbNVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNVendedor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbNVendedor.HideSelection = false;
            this.txbNVendedor.Location = new System.Drawing.Point(123, 23);
            this.txbNVendedor.Name = "txbNVendedor";
            this.txbNVendedor.Size = new System.Drawing.Size(158, 20);
            this.txbNVendedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Vendedor:";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditar.BackColor = System.Drawing.Color.Gray;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(705, 436);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 24);
            this.btnEditar.TabIndex = 93;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(845, 436);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 24);
            this.btnGuardar.TabIndex = 92;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMensajeError.AutoSize = true;
            this.lblMensajeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeError.Location = new System.Drawing.Point(92, 125);
            this.lblMensajeError.Margin = new System.Windows.Forms.Padding(10);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(117, 13);
            this.lblMensajeError.TabIndex = 94;
            this.lblMensajeError.Text = "Vendedor no existente*";
            this.lblMensajeError.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // tbBVendedor
            // 
            // 
            // 
            // 
            this.tbBVendedor.CustomButton.Image = null;
            this.tbBVendedor.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.tbBVendedor.CustomButton.Name = "";
            this.tbBVendedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbBVendedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbBVendedor.CustomButton.TabIndex = 1;
            this.tbBVendedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbBVendedor.CustomButton.UseSelectable = true;
            this.tbBVendedor.CustomButton.Visible = false;
            this.tbBVendedor.Lines = new string[0];
            this.tbBVendedor.Location = new System.Drawing.Point(95, 101);
            this.tbBVendedor.MaxLength = 32767;
            this.tbBVendedor.Name = "tbBVendedor";
            this.tbBVendedor.PasswordChar = '\0';
            this.tbBVendedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbBVendedor.SelectedText = "";
            this.tbBVendedor.SelectionLength = 0;
            this.tbBVendedor.SelectionStart = 0;
            this.tbBVendedor.ShortcutsEnabled = true;
            this.tbBVendedor.Size = new System.Drawing.Size(175, 23);
            this.tbBVendedor.Style = MetroFramework.MetroColorStyle.Yellow;
            this.tbBVendedor.TabIndex = 95;
            this.tbBVendedor.UseSelectable = true;
            this.tbBVendedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbBVendedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmAltaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1039, 514);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBVendedor);
            this.Controls.Add(this.lblMensajeError);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbVendedor);
            this.Controls.Add(this.lblNumCliente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Name = "frmAltaVendedor";
            this.Text = "frmAltaVendedor";
            this.gbVendedor.ResumeLayout(false);
            this.gbVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNumCliente;
        private System.Windows.Forms.GroupBox gbVendedor;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.TextBox txbCorreoCliente;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txbMovil;
        private System.Windows.Forms.Label lblMovil;
        private System.Windows.Forms.TextBox txbExtension;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txbCP;
        private System.Windows.Forms.Label lblCodigoP;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txbMunicipio;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txbRfc;
        private System.Windows.Forms.Label lblRfc;
        private System.Windows.Forms.TextBox txbAMaterno;
        private System.Windows.Forms.Label lblAMaterno;
        private System.Windows.Forms.TextBox txbAPaterno;
        private System.Windows.Forms.Label lblAPaterno;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.CheckBox ckbActivo;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.TextBox txbNVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMensajeError;
        private MetroFramework.Controls.MetroComboBox cbNivel;
        private MetroFramework.Controls.MetroComboBox cbComisionista;
        private MetroFramework.Controls.MetroComboBox cbEstados;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txbCurp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNoExpediente;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox tbBVendedor;
    }
}