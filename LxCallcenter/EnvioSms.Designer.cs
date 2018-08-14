namespace LxCallcenter
{
	partial class EnvioSms
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbClientesTodos = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbCliente = new MaterialSkin.Controls.MaterialRadioButton();
            this.pnlforms = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lnkCerrar = new MetroFramework.Controls.MetroLink();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecciona la forma de enviar un SMS";
            // 
            // rbClientesTodos
            // 
            this.rbClientesTodos.AutoCheck = false;
            this.rbClientesTodos.AutoSize = true;
            this.rbClientesTodos.Depth = 0;
            this.rbClientesTodos.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbClientesTodos.Location = new System.Drawing.Point(30, 64);
            this.rbClientesTodos.Margin = new System.Windows.Forms.Padding(0);
            this.rbClientesTodos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbClientesTodos.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbClientesTodos.Name = "rbClientesTodos";
            this.rbClientesTodos.Ripple = true;
            this.rbClientesTodos.Size = new System.Drawing.Size(143, 30);
            this.rbClientesTodos.TabIndex = 7;
            this.rbClientesTodos.TabStop = true;
            this.rbClientesTodos.Text = "Todos los Clientes";
            this.rbClientesTodos.UseVisualStyleBackColor = true;
            this.rbClientesTodos.CheckedChanged += new System.EventHandler(this.rbMasivo_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoCheck = false;
            this.rbCliente.AutoSize = true;
            this.rbCliente.Depth = 0;
            this.rbCliente.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbCliente.Location = new System.Drawing.Point(30, 31);
            this.rbCliente.Margin = new System.Windows.Forms.Padding(0);
            this.rbCliente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Ripple = true;
            this.rbCliente.Size = new System.Drawing.Size(139, 30);
            this.rbCliente.TabIndex = 6;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente Especifico";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // pnlforms
            // 
            this.pnlforms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlforms.Location = new System.Drawing.Point(2, 274);
            this.pnlforms.Name = "pnlforms";
            this.pnlforms.Size = new System.Drawing.Size(347, 406);
            this.pnlforms.TabIndex = 8;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoEllipsis = true;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(27, 66);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(241, 66);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Envía mensajes SMS a un cliente\r\nen específico o masivamente a\r\ntodos los cliente" +
    "s.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.label4.Location = new System.Drawing.Point(47, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enviar SMS";
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
            this.lnkCerrar.Image = global::LxCallcenter.Properties.Resources.delete_sign_filled_23px;
            this.lnkCerrar.ImageSize = 22;
            this.lnkCerrar.Location = new System.Drawing.Point(304, 12);
            this.lnkCerrar.Name = "lnkCerrar";
            this.lnkCerrar.NoFocusImage = global::LxCallcenter.Properties.Resources.delete_sign_23px;
            this.lnkCerrar.Size = new System.Drawing.Size(27, 23);
            this.lnkCerrar.TabIndex = 225;
            this.metroToolTip1.SetToolTip(this.lnkCerrar, "Cerrar");
            this.lnkCerrar.UseSelectable = true;
            this.lnkCerrar.Click += new System.EventHandler(this.lnkCerrar_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 677);
            this.panel3.TabIndex = 249;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LxCallcenter.Properties.Resources.speech_bubble_48px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(16, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 35);
            this.pictureBox1.TabIndex = 250;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbClientesTodos);
            this.panel1.Controls.Add(this.rbCliente);
            this.panel1.Location = new System.Drawing.Point(2, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 135);
            this.panel1.TabIndex = 569;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(-2, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 20);
            this.panel2.TabIndex = 570;
            // 
            // EnvioSms
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(344, 674);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lnkCerrar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlforms);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnvioSms";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EnvioSms";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel pnlforms;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRadioButton rbClientesTodos;
        private MaterialSkin.Controls.MaterialRadioButton rbCliente;
        private MetroFramework.Controls.MetroLink lnkCerrar;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}