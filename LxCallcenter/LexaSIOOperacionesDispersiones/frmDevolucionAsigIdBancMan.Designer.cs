namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	partial class frmDevolucionAsigIdBancMan
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
			this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
			this.lnkCerrar = new MetroFramework.Controls.MetroLink();
			this.btnGuardar = new LollipopButton();
			this.txtIdBancario = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			this.txtNoCuenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.txtComisionista = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.btnSalir = new LollipopFlatButton();
			this.txtBanco = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
			this.txtClabeInterbancaria = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
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
			this.lnkCerrar.Image = global::LxCallcenter.Properties.Resources.delete_sign_filled_23px;
			this.lnkCerrar.ImageSize = 25;
			this.lnkCerrar.Location = new System.Drawing.Point(434, 9);
			this.lnkCerrar.Name = "lnkCerrar";
			this.lnkCerrar.NoFocusImage = global::LxCallcenter.Properties.Resources.delete_sign_23px;
			this.lnkCerrar.Size = new System.Drawing.Size(25, 25);
			this.lnkCerrar.TabIndex = 253;
			this.metroToolTip1.SetToolTip(this.lnkCerrar, "Cerrar");
			this.lnkCerrar.UseSelectable = true;
			this.lnkCerrar.Click += new System.EventHandler(this.lnkConfigurar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
			this.btnGuardar.BGColor = "#3f51b5";
			this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardar.FontColor = "#ffffff";
			this.btnGuardar.Location = new System.Drawing.Point(230, 284);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(103, 20);
			this.btnGuardar.TabIndex = 262;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// txtIdBancario
			// 
			this.txtIdBancario.Depth = 0;
			this.txtIdBancario.Hint = "";
			this.txtIdBancario.Location = new System.Drawing.Point(58, 234);
			this.txtIdBancario.MaxLength = 32767;
			this.txtIdBancario.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtIdBancario.Name = "txtIdBancario";
			this.txtIdBancario.PasswordChar = '\0';
			this.txtIdBancario.ReadOnly = false;
			this.txtIdBancario.SelectedText = "";
			this.txtIdBancario.SelectionLength = 0;
			this.txtIdBancario.SelectionStart = 0;
			this.txtIdBancario.Size = new System.Drawing.Size(166, 25);
			this.txtIdBancario.TabIndex = 261;
			this.txtIdBancario.TabStop = false;
			this.txtIdBancario.UseSystemPasswordChar = false;
			// 
			// materialLabel4
			// 
			this.materialLabel4.AutoSize = true;
			this.materialLabel4.Depth = 0;
			this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 11F);
			this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel4.Location = new System.Drawing.Point(54, 210);
			this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel4.Name = "materialLabel4";
			this.materialLabel4.Size = new System.Drawing.Size(84, 19);
			this.materialLabel4.TabIndex = 260;
			this.materialLabel4.Text = "Id Bancario";
			// 
			// txtNoCuenta
			// 
			this.txtNoCuenta.Depth = 0;
			this.txtNoCuenta.Hint = "";
			this.txtNoCuenta.Location = new System.Drawing.Point(58, 171);
			this.txtNoCuenta.MaxLength = 32767;
			this.txtNoCuenta.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtNoCuenta.Name = "txtNoCuenta";
			this.txtNoCuenta.PasswordChar = '\0';
			this.txtNoCuenta.ReadOnly = true;
			this.txtNoCuenta.SelectedText = "";
			this.txtNoCuenta.SelectionLength = 0;
			this.txtNoCuenta.SelectionStart = 0;
			this.txtNoCuenta.Size = new System.Drawing.Size(166, 25);
			this.txtNoCuenta.TabIndex = 259;
			this.txtNoCuenta.TabStop = false;
			this.txtNoCuenta.UseSystemPasswordChar = false;
			// 
			// materialLabel3
			// 
			this.materialLabel3.AutoSize = true;
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 11F);
			this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel3.Location = new System.Drawing.Point(54, 147);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(104, 19);
			this.materialLabel3.TabIndex = 258;
			this.materialLabel3.Text = "No. de Cuenta";
			// 
			// txtComisionista
			// 
			this.txtComisionista.Depth = 0;
			this.txtComisionista.Enabled = false;
			this.txtComisionista.Hint = "";
			this.txtComisionista.Location = new System.Drawing.Point(58, 104);
			this.txtComisionista.MaxLength = 32767;
			this.txtComisionista.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtComisionista.Name = "txtComisionista";
			this.txtComisionista.PasswordChar = '\0';
			this.txtComisionista.ReadOnly = false;
			this.txtComisionista.SelectedText = "";
			this.txtComisionista.SelectionLength = 0;
			this.txtComisionista.SelectionStart = 0;
			this.txtComisionista.Size = new System.Drawing.Size(349, 25);
			this.txtComisionista.TabIndex = 257;
			this.txtComisionista.TabStop = false;
			this.txtComisionista.UseSystemPasswordChar = false;
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(54, 80);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(56, 19);
			this.materialLabel1.TabIndex = 256;
			this.materialLabel1.Text = "Cliente";
			// 
			// materialLabel2
			// 
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Enabled = false;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(41, 33);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(204, 19);
			this.materialLabel2.TabIndex = 255;
			this.materialLabel2.Text = "Asigne Id Bancario al cliente.";
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalir.BackColor = System.Drawing.Color.Transparent;
			this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalir.FontColor = "#d50000";
			this.btnSalir.Location = new System.Drawing.Point(339, 284);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(68, 20);
			this.btnSalir.TabIndex = 254;
			this.btnSalir.Text = "Salir";
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// txtBanco
			// 
			this.txtBanco.Depth = 0;
			this.txtBanco.Hint = "";
			this.txtBanco.Location = new System.Drawing.Point(247, 234);
			this.txtBanco.MaxLength = 32767;
			this.txtBanco.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtBanco.Name = "txtBanco";
			this.txtBanco.PasswordChar = '\0';
			this.txtBanco.ReadOnly = false;
			this.txtBanco.SelectedText = "";
			this.txtBanco.SelectionLength = 0;
			this.txtBanco.SelectionStart = 0;
			this.txtBanco.Size = new System.Drawing.Size(160, 25);
			this.txtBanco.TabIndex = 262;
			this.txtBanco.TabStop = false;
			this.txtBanco.UseSystemPasswordChar = false;
			// 
			// materialLabel5
			// 
			this.materialLabel5.AutoSize = true;
			this.materialLabel5.Depth = 0;
			this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 11F);
			this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel5.Location = new System.Drawing.Point(243, 210);
			this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel5.Name = "materialLabel5";
			this.materialLabel5.Size = new System.Drawing.Size(51, 19);
			this.materialLabel5.TabIndex = 265;
			this.materialLabel5.Text = "Banco";
			// 
			// txtClabeInterbancaria
			// 
			this.txtClabeInterbancaria.Depth = 0;
			this.txtClabeInterbancaria.Hint = "";
			this.txtClabeInterbancaria.Location = new System.Drawing.Point(247, 171);
			this.txtClabeInterbancaria.MaxLength = 32767;
			this.txtClabeInterbancaria.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtClabeInterbancaria.Name = "txtClabeInterbancaria";
			this.txtClabeInterbancaria.PasswordChar = '\0';
			this.txtClabeInterbancaria.ReadOnly = true;
			this.txtClabeInterbancaria.SelectedText = "";
			this.txtClabeInterbancaria.SelectionLength = 0;
			this.txtClabeInterbancaria.SelectionStart = 0;
			this.txtClabeInterbancaria.Size = new System.Drawing.Size(160, 25);
			this.txtClabeInterbancaria.TabIndex = 260;
			this.txtClabeInterbancaria.TabStop = false;
			this.txtClabeInterbancaria.UseSystemPasswordChar = false;
			// 
			// materialLabel6
			// 
			this.materialLabel6.AutoSize = true;
			this.materialLabel6.Depth = 0;
			this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 11F);
			this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel6.Location = new System.Drawing.Point(243, 147);
			this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel6.Name = "materialLabel6";
			this.materialLabel6.Size = new System.Drawing.Size(145, 19);
			this.materialLabel6.TabIndex = 263;
			this.materialLabel6.Text = "CLABE Interbancaria";
			// 
			// frmDevolucionAsigIdBancMan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(464, 323);
			this.Controls.Add(this.txtBanco);
			this.Controls.Add(this.materialLabel5);
			this.Controls.Add(this.txtClabeInterbancaria);
			this.Controls.Add(this.materialLabel6);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtIdBancario);
			this.Controls.Add(this.materialLabel4);
			this.Controls.Add(this.txtNoCuenta);
			this.Controls.Add(this.materialLabel3);
			this.Controls.Add(this.txtComisionista);
			this.Controls.Add(this.materialLabel1);
			this.Controls.Add(this.materialLabel2);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.lnkCerrar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmDevolucionAsigIdBancMan";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmDevolucionAsigIdBancMan";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Components.MetroToolTip metroToolTip1;
		private LollipopButton btnGuardar;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtIdBancario;
		private MaterialSkin.Controls.MaterialLabel materialLabel4;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtNoCuenta;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtComisionista;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private LollipopFlatButton btnSalir;
		private MetroFramework.Controls.MetroLink lnkCerrar;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtBanco;
		private MaterialSkin.Controls.MaterialLabel materialLabel5;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtClabeInterbancaria;
		private MaterialSkin.Controls.MaterialLabel materialLabel6;
	}
}