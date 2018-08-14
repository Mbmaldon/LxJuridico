namespace LxCallcenter
{
	partial class ClientesSMSs
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
            this.gbMensaje = new System.Windows.Forms.GroupBox();
            this.btnEnviar = new MetroFramework.Controls.MetroLink();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.cmbxMensaje = new MetroFramework.Controls.MetroComboBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.lblCaracteres = new LollipopLabel();
            this.txbMensaje = new LollipopTextBox();
            this.gbMensaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMensaje
            // 
            this.gbMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMensaje.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbMensaje.Controls.Add(this.cmbxMensaje);
            this.gbMensaje.Controls.Add(this.lollipopLabel2);
            this.gbMensaje.Controls.Add(this.lollipopLabel1);
            this.gbMensaje.Controls.Add(this.btnEnviar);
            this.gbMensaje.Controls.Add(this.lblCaracteres);
            this.gbMensaje.Controls.Add(this.txbMensaje);
            this.gbMensaje.Location = new System.Drawing.Point(-1, -7);
            this.gbMensaje.Name = "gbMensaje";
            this.gbMensaje.Size = new System.Drawing.Size(312, 240);
            this.gbMensaje.TabIndex = 3;
            this.gbMensaje.TabStop = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Image = global::LxCallcenter.Properties.Resources.sent_96px;
            this.btnEnviar.ImageSize = 47;
            this.btnEnviar.Location = new System.Drawing.Point(239, 175);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.NoFocusImage = global::LxCallcenter.Properties.Resources.sent_96px;
            this.btnEnviar.Size = new System.Drawing.Size(51, 51);
            this.btnEnviar.TabIndex = 6;
            this.metroToolTip1.SetToolTip(this.btnEnviar, "Enviar SMS");
            this.btnEnviar.UseSelectable = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
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
            // cmbxMensaje
            // 
            this.cmbxMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxMensaje.FormattingEnabled = true;
            this.cmbxMensaje.ItemHeight = 23;
            this.cmbxMensaje.Location = new System.Drawing.Point(13, 37);
            this.cmbxMensaje.Name = "cmbxMensaje";
            this.cmbxMensaje.Size = new System.Drawing.Size(270, 29);
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
            this.lollipopLabel2.Location = new System.Drawing.Point(10, 16);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(113, 17);
            this.lollipopLabel2.TabIndex = 8;
            this.lollipopLabel2.Text = "Tipo de Mensaje";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(11, 79);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(61, 17);
            this.lollipopLabel1.TabIndex = 7;
            this.lollipopLabel1.Text = "Mensaje";
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.BackColor = System.Drawing.Color.Transparent;
            this.lblCaracteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCaracteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblCaracteres.Location = new System.Drawing.Point(10, 172);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(145, 17);
            this.lblCaracteres.TabIndex = 5;
            this.lblCaracteres.Text = "Caracteres: 0 de 140.";
            this.lblCaracteres.Visible = false;
            // 
            // txbMensaje
            // 
            this.txbMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMensaje.FocusedColor = "#FFA300";
            this.txbMensaje.FontColor = "#00000";
            this.txbMensaje.IsEnabled = true;
            this.txbMensaje.Location = new System.Drawing.Point(13, 100);
            this.txbMensaje.MaxLength = 140;
            this.txbMensaje.Multiline = true;
            this.txbMensaje.Name = "txbMensaje";
            this.txbMensaje.ReadOnly = false;
            this.txbMensaje.Size = new System.Drawing.Size(270, 69);
            this.txbMensaje.TabIndex = 3;
            this.txbMensaje.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbMensaje.UseSystemPasswordChar = false;
            this.txbMensaje.TextChanged += new System.EventHandler(this.txbMensaje_TextChanged);
            this.txbMensaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMensaje_KeyPress);
            this.txbMensaje.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbMensaje_KeyUp);
            // 
            // ClientesSMSs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(306, 228);
            this.Controls.Add(this.gbMensaje);
            this.Name = "ClientesSMSs";
            this.Text = "ClientesSMSs";
            this.gbMensaje.ResumeLayout(false);
            this.gbMensaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbMensaje;
		private System.Windows.Forms.ErrorProvider MensajeError;
        private LollipopTextBox txbMensaje;
        private LollipopLabel lblCaracteres;
        private MetroFramework.Controls.MetroLink btnEnviar;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroComboBox cmbxMensaje;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel1;
    }
}