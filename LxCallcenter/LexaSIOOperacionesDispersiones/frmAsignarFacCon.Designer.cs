namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	partial class frmAsignarFacCon
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
			this.lnkSalir = new MetroFramework.Controls.MetroLink();
			this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			this.txtConcepto = new LollipopTextBox();
			this.label1 = new MaterialSkin.Controls.MaterialLabel();
			this.txtNoFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.btnGuardar = new LollipopButton();
			this.btnSalir = new LollipopFlatButton();
			this.cmbxAnios = new MaterialSkin.Controls.MaterialComboBox();
			this.cmbxSemanas = new MaterialSkin.Controls.MaterialComboBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// lnkSalir
			// 
			this.lnkSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lnkSalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lnkSalir.ForeColor = System.Drawing.Color.Transparent;
			this.lnkSalir.Image = global::LxCallcenter.Properties.Resources.delete_sign_filled_23px;
			this.lnkSalir.ImageSize = 23;
			this.lnkSalir.Location = new System.Drawing.Point(361, 12);
			this.lnkSalir.Name = "lnkSalir";
			this.lnkSalir.NoFocusImage = global::LxCallcenter.Properties.Resources.delete_sign_23px;
			this.lnkSalir.Size = new System.Drawing.Size(23, 23);
			this.lnkSalir.TabIndex = 8;
			this.lnkSalir.Tag = "2";
			this.lnkSalir.Text = "2";
			this.metroToolTip1.SetToolTip(this.lnkSalir, "Salir");
			this.lnkSalir.UseCustomForeColor = true;
			this.lnkSalir.UseSelectable = true;
			this.lnkSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// metroToolTip1
			// 
			this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroToolTip1.StyleManager = null;
			this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(20, 410);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 17);
			this.textBox1.TabIndex = 218;
			this.textBox1.Visible = false;
			// 
			// materialLabel4
			// 
			this.materialLabel4.AutoSize = true;
			this.materialLabel4.Depth = 0;
			this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel4.Location = new System.Drawing.Point(85, 261);
			this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel4.Name = "materialLabel4";
			this.materialLabel4.Size = new System.Drawing.Size(74, 19);
			this.materialLabel4.TabIndex = 217;
			this.materialLabel4.Text = "Concepto";
			// 
			// txtConcepto
			// 
			this.txtConcepto.FocusedColor = "#508ef5";
			this.txtConcepto.FontColor = "#999999";
			this.txtConcepto.IsEnabled = true;
			this.txtConcepto.Location = new System.Drawing.Point(88, 284);
			this.txtConcepto.MaxLength = 32767;
			this.txtConcepto.Multiline = true;
			this.txtConcepto.Name = "txtConcepto";
			this.txtConcepto.ReadOnly = false;
			this.txtConcepto.Size = new System.Drawing.Size(208, 81);
			this.txtConcepto.TabIndex = 216;
			this.txtConcepto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtConcepto.UseSystemPasswordChar = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Depth = 0;
			this.label1.Font = new System.Drawing.Font("Roboto", 11F);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(85, 193);
			this.label1.MouseState = MaterialSkin.MouseState.HOVER;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 19);
			this.label1.TabIndex = 215;
			this.label1.Text = "No. de Factura";
			// 
			// txtNoFactura
			// 
			this.txtNoFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNoFactura.Depth = 0;
			this.txtNoFactura.Hint = "";
			this.txtNoFactura.Location = new System.Drawing.Point(88, 215);
			this.txtNoFactura.MaxLength = 32767;
			this.txtNoFactura.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtNoFactura.Name = "txtNoFactura";
			this.txtNoFactura.PasswordChar = '\0';
			this.txtNoFactura.ReadOnly = false;
			this.txtNoFactura.SelectedText = "";
			this.txtNoFactura.SelectionLength = 0;
			this.txtNoFactura.SelectionStart = 0;
			this.txtNoFactura.Size = new System.Drawing.Size(208, 23);
			this.txtNoFactura.TabIndex = 214;
			this.txtNoFactura.TabStop = false;
			this.txtNoFactura.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNoFactura.UseSystemPasswordChar = false;
			// 
			// materialLabel3
			// 
			this.materialLabel3.AutoSize = true;
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel3.Location = new System.Drawing.Point(202, 127);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(63, 19);
			this.materialLabel3.TabIndex = 213;
			this.materialLabel3.Text = "Semana";
			// 
			// materialLabel2
			// 
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(84, 127);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(36, 19);
			this.materialLabel2.TabIndex = 213;
			this.materialLabel2.Text = "Año";
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Enabled = false;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(22, 58);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(311, 38);
			this.materialLabel1.TabIndex = 11;
			this.materialLabel1.Text = "Asigne no. de factura y concepto a los pagos\r\nfiltrando por número de semana.";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
			this.btnGuardar.BGColor = "#3f51b5";
			this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardar.FontColor = "#ffffff";
			this.btnGuardar.Location = new System.Drawing.Point(170, 425);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(112, 22);
			this.btnGuardar.TabIndex = 10;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalir.BackColor = System.Drawing.Color.Transparent;
			this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalir.FontColor = "#d50000";
			this.btnSalir.Location = new System.Drawing.Point(288, 425);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(88, 22);
			this.btnSalir.TabIndex = 9;
			this.btnSalir.Text = "Salir";
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// cmbxAnios
			// 
			this.cmbxAnios.DataSource = null;
			this.cmbxAnios.Depth = 0;
			this.cmbxAnios.DisplayMember = "";
			this.cmbxAnios.Hint = "";
			this.cmbxAnios.Location = new System.Drawing.Point(88, 149);
			this.cmbxAnios.MaxLength = 0;
			this.cmbxAnios.MouseState = MaterialSkin.MouseState.HOVER;
			this.cmbxAnios.Name = "cmbxAnios";
			this.cmbxAnios.PasswordChar = '\0';
			this.cmbxAnios.SelectedIndex = -1;
			this.cmbxAnios.SelectedText = "";
			this.cmbxAnios.SelectedValue = null;
			this.cmbxAnios.Size = new System.Drawing.Size(91, 29);
			this.cmbxAnios.TabIndex = 219;
			this.cmbxAnios.TabStop = false;
			this.cmbxAnios.UseSystemPasswordChar = false;
			this.cmbxAnios.ValueMember = "";
			this.cmbxAnios.SelectionChangeCommitted += new System.EventHandler(this.cmbxAnios_SelectionChangeCommitted);
			// 
			// cmbxSemanas
			// 
			this.cmbxSemanas.DataSource = null;
			this.cmbxSemanas.Depth = 0;
			this.cmbxSemanas.DisplayMember = "";
			this.cmbxSemanas.Hint = "";
			this.cmbxSemanas.Location = new System.Drawing.Point(206, 149);
			this.cmbxSemanas.MaxLength = 0;
			this.cmbxSemanas.MouseState = MaterialSkin.MouseState.HOVER;
			this.cmbxSemanas.Name = "cmbxSemanas";
			this.cmbxSemanas.PasswordChar = '\0';
			this.cmbxSemanas.SelectedIndex = -1;
			this.cmbxSemanas.SelectedText = "";
			this.cmbxSemanas.SelectedValue = null;
			this.cmbxSemanas.Size = new System.Drawing.Size(90, 29);
			this.cmbxSemanas.TabIndex = 220;
			this.cmbxSemanas.TabStop = false;
			this.cmbxSemanas.UseSystemPasswordChar = false;
			this.cmbxSemanas.ValueMember = "";
			// 
			// frmAsignarFacCon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(392, 461);
			this.Controls.Add(this.cmbxSemanas);
			this.Controls.Add(this.cmbxAnios);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.materialLabel4);
			this.Controls.Add(this.txtConcepto);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNoFactura);
			this.Controls.Add(this.materialLabel3);
			this.Controls.Add(this.materialLabel2);
			this.Controls.Add(this.materialLabel1);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.lnkSalir);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmAsignarFacCon";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmAsignarFacCon";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLink lnkSalir;
		private LollipopFlatButton btnSalir;
		private LollipopButton btnGuardar;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private MetroFramework.Components.MetroToolTip metroToolTip1;
		private MaterialSkin.Controls.MaterialLabel label1;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtNoFactura;
		private LollipopTextBox txtConcepto;
		private MaterialSkin.Controls.MaterialLabel materialLabel4;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox textBox1;
		private MaterialSkin.Controls.MaterialComboBox cmbxSemanas;
		private MaterialSkin.Controls.MaterialComboBox cmbxAnios;
	}
}