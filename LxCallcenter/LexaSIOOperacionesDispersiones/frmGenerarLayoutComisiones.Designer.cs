namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	partial class frmGenerarLayoutComisiones
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
			this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.label1 = new MaterialSkin.Controls.MaterialLabel();
			this.txtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txtRfcOrdenante = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.txtReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.lnkCerrar = new MetroFramework.Controls.MetroLink();
			this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
			this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
			this.bgwProgreso = new System.ComponentModel.BackgroundWorker();
			this.lblTiempo = new MaterialSkin.Controls.MaterialLabel();
			this.lblNumArchivos = new MaterialSkin.Controls.MaterialLabel();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnGenerarLayout = new LollipopButton();
			this.pgrbProgreso = new LollipopProgressBar();
			this.cmbxCuentaOrigen = new MaterialSkin.Controls.MaterialComboBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Depth = 0;
			this.lblTitulo.Enabled = false;
			this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitulo.Location = new System.Drawing.Point(20, 30);
			this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(110, 19);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Generar Layout";
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(50, 64);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(123, 19);
			this.materialLabel1.TabIndex = 1;
			this.materialLabel1.Text = "Cuenta de Origen";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Depth = 0;
			this.label1.Font = new System.Drawing.Font("Roboto", 11F);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(50, 145);
			this.label1.MouseState = MaterialSkin.MouseState.HOVER;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 19);
			this.label1.TabIndex = 225;
			this.label1.Text = "Descripción";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDescripcion.Depth = 0;
			this.txtDescripcion.Enabled = false;
			this.txtDescripcion.Hint = "";
			this.txtDescripcion.Location = new System.Drawing.Point(53, 166);
			this.txtDescripcion.MaxLength = 32767;
			this.txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.PasswordChar = '\0';
			this.txtDescripcion.ReadOnly = false;
			this.txtDescripcion.SelectedText = "";
			this.txtDescripcion.SelectionLength = 0;
			this.txtDescripcion.SelectionStart = 0;
			this.txtDescripcion.Size = new System.Drawing.Size(204, 23);
			this.txtDescripcion.TabIndex = 226;
			this.txtDescripcion.TabStop = false;
			this.txtDescripcion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDescripcion.UseSystemPasswordChar = false;
			// 
			// txtRfcOrdenante
			// 
			this.txtRfcOrdenante.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtRfcOrdenante.Depth = 0;
			this.txtRfcOrdenante.Enabled = false;
			this.txtRfcOrdenante.Hint = "";
			this.txtRfcOrdenante.Location = new System.Drawing.Point(285, 165);
			this.txtRfcOrdenante.MaxLength = 32767;
			this.txtRfcOrdenante.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtRfcOrdenante.Name = "txtRfcOrdenante";
			this.txtRfcOrdenante.PasswordChar = '\0';
			this.txtRfcOrdenante.ReadOnly = false;
			this.txtRfcOrdenante.SelectedText = "";
			this.txtRfcOrdenante.SelectionLength = 0;
			this.txtRfcOrdenante.SelectionStart = 0;
			this.txtRfcOrdenante.Size = new System.Drawing.Size(204, 23);
			this.txtRfcOrdenante.TabIndex = 228;
			this.txtRfcOrdenante.TabStop = false;
			this.txtRfcOrdenante.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtRfcOrdenante.UseSystemPasswordChar = false;
			// 
			// materialLabel2
			// 
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(282, 144);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(108, 19);
			this.materialLabel2.TabIndex = 227;
			this.materialLabel2.Text = "RFC Ordenante";
			// 
			// txtReferencia
			// 
			this.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtReferencia.Depth = 0;
			this.txtReferencia.Hint = "";
			this.txtReferencia.Location = new System.Drawing.Point(285, 92);
			this.txtReferencia.MaxLength = 32767;
			this.txtReferencia.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtReferencia.Name = "txtReferencia";
			this.txtReferencia.PasswordChar = '\0';
			this.txtReferencia.ReadOnly = false;
			this.txtReferencia.SelectedText = "";
			this.txtReferencia.SelectionLength = 0;
			this.txtReferencia.SelectionStart = 0;
			this.txtReferencia.Size = new System.Drawing.Size(204, 23);
			this.txtReferencia.TabIndex = 230;
			this.txtReferencia.TabStop = false;
			this.txtReferencia.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtReferencia.UseSystemPasswordChar = false;
			// 
			// materialLabel3
			// 
			this.materialLabel3.AutoSize = true;
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel3.Location = new System.Drawing.Point(282, 64);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(80, 19);
			this.materialLabel3.TabIndex = 229;
			this.materialLabel3.Text = "Referencia";
			// 
			// lnkCerrar
			// 
			this.lnkCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lnkCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lnkCerrar.Image = global::LxCallcenter.Properties.Resources.delete_sign_filled_23px;
			this.lnkCerrar.ImageSize = 25;
			this.lnkCerrar.Location = new System.Drawing.Point(507, 13);
			this.lnkCerrar.Name = "lnkCerrar";
			this.lnkCerrar.NoFocusImage = global::LxCallcenter.Properties.Resources.delete_sign_23px;
			this.lnkCerrar.Size = new System.Drawing.Size(25, 25);
			this.lnkCerrar.TabIndex = 240;
			this.metroToolTip1.SetToolTip(this.lnkCerrar, "Cerrar");
			this.lnkCerrar.UseSelectable = true;
			this.lnkCerrar.Click += new System.EventHandler(this.lnkCerrar_Click);
			// 
			// metroToolTip1
			// 
			this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroToolTip1.StyleManager = null;
			this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// sfdRuta
			// 
			this.sfdRuta.Filter = "Archivo Excel | *.xlsx";
			// 
			// bgwProgreso
			// 
			this.bgwProgreso.WorkerReportsProgress = true;
			this.bgwProgreso.WorkerSupportsCancellation = true;
			this.bgwProgreso.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwProgreso_DoWork);
			this.bgwProgreso.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwProgreso_ProgressChanged);
			this.bgwProgreso.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwProgreso_RunWorkerCompleted);
			// 
			// lblTiempo
			// 
			this.lblTiempo.Depth = 0;
			this.lblTiempo.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTiempo.Location = new System.Drawing.Point(87, 220);
			this.lblTiempo.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblTiempo.Name = "lblTiempo";
			this.lblTiempo.Size = new System.Drawing.Size(363, 18);
			this.lblTiempo.TabIndex = 242;
			this.lblTiempo.Text = "INICIANDO";
			this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblTiempo.Visible = false;
			// 
			// lblNumArchivos
			// 
			this.lblNumArchivos.Depth = 0;
			this.lblNumArchivos.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblNumArchivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblNumArchivos.Location = new System.Drawing.Point(83, 254);
			this.lblNumArchivos.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblNumArchivos.Name = "lblNumArchivos";
			this.lblNumArchivos.Size = new System.Drawing.Size(363, 18);
			this.lblNumArchivos.TabIndex = 243;
			this.lblNumArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblNumArchivos.Visible = false;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// btnGenerarLayout
			// 
			this.btnGenerarLayout.BackColor = System.Drawing.Color.Transparent;
			this.btnGenerarLayout.BGColor = "#3f51b5";
			this.btnGenerarLayout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGenerarLayout.FontColor = "#ffffff";
			this.btnGenerarLayout.Location = new System.Drawing.Point(206, 241);
			this.btnGenerarLayout.Name = "btnGenerarLayout";
			this.btnGenerarLayout.Size = new System.Drawing.Size(115, 21);
			this.btnGenerarLayout.TabIndex = 244;
			this.btnGenerarLayout.Text = "Generar";
			this.btnGenerarLayout.Click += new System.EventHandler(this.btnGenerarLayout_Click);
			// 
			// pgrbProgreso
			// 
			this.pgrbProgreso.BGColor = "#508ef5";
			this.pgrbProgreso.Location = new System.Drawing.Point(87, 242);
			this.pgrbProgreso.Name = "pgrbProgreso";
			this.pgrbProgreso.Size = new System.Drawing.Size(363, 4);
			this.pgrbProgreso.TabIndex = 241;
			this.pgrbProgreso.Text = "lollipopProgressBar1";
			this.pgrbProgreso.Value = 0;
			this.pgrbProgreso.Visible = false;
			// 
			// cmbxCuentaOrigen
			// 
			this.cmbxCuentaOrigen.DataSource = null;
			this.cmbxCuentaOrigen.Depth = 0;
			this.cmbxCuentaOrigen.DisplayMember = "";
			this.cmbxCuentaOrigen.Hint = "";
			this.cmbxCuentaOrigen.Location = new System.Drawing.Point(55, 86);
			this.cmbxCuentaOrigen.MaxLength = 0;
			this.cmbxCuentaOrigen.MouseState = MaterialSkin.MouseState.HOVER;
			this.cmbxCuentaOrigen.Name = "cmbxCuentaOrigen";
			this.cmbxCuentaOrigen.PasswordChar = '\0';
			this.cmbxCuentaOrigen.SelectedIndex = -1;
			this.cmbxCuentaOrigen.SelectedText = "";
			this.cmbxCuentaOrigen.SelectedValue = null;
			this.cmbxCuentaOrigen.Size = new System.Drawing.Size(202, 29);
			this.cmbxCuentaOrigen.TabIndex = 245;
			this.cmbxCuentaOrigen.TabStop = false;
			this.cmbxCuentaOrigen.UseSystemPasswordChar = false;
			this.cmbxCuentaOrigen.ValueMember = "";
			// 
			// frmGenerarLayoutComisiones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(535, 286);
			this.Controls.Add(this.cmbxCuentaOrigen);
			this.Controls.Add(this.btnGenerarLayout);
			this.Controls.Add(this.lblNumArchivos);
			this.Controls.Add(this.lblTiempo);
			this.Controls.Add(this.pgrbProgreso);
			this.Controls.Add(this.lnkCerrar);
			this.Controls.Add(this.txtReferencia);
			this.Controls.Add(this.materialLabel3);
			this.Controls.Add(this.txtRfcOrdenante);
			this.Controls.Add(this.materialLabel2);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.materialLabel1);
			this.Controls.Add(this.lblTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmGenerarLayoutComisiones";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmGenerarLayoutComisiones";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialLabel lblTitulo;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialLabel label1;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcion;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtRfcOrdenante;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtReferencia;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private MetroFramework.Controls.MetroLink lnkCerrar;
		private MetroFramework.Components.MetroToolTip metroToolTip1;
		private System.Windows.Forms.SaveFileDialog sfdRuta;
		private System.ComponentModel.BackgroundWorker bgwProgreso;
		private LollipopProgressBar pgrbProgreso;
		private MaterialSkin.Controls.MaterialLabel lblTiempo;
		private MaterialSkin.Controls.MaterialLabel lblNumArchivos;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private LollipopButton btnGenerarLayout;
		private MaterialSkin.Controls.MaterialComboBox cmbxCuentaOrigen;
	}
}