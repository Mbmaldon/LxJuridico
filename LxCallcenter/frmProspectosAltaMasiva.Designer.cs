namespace LxCallcenter
{
    partial class frmProspectosAltaMasiva
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
            this.lnkCerrar = new MetroFramework.Controls.MetroLink();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lnkSeleccionarArchivo = new MetroFramework.Controls.MetroLink();
            this.lnkPlantilla = new MetroFramework.Controls.MetroLink();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbxRegimen = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.pnlPlantilla = new System.Windows.Forms.Panel();
            this.btnGuardar = new LollipopButton();
            this.txtArchivoCarga = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pnlDescarga = new System.Windows.Forms.Panel();
            this.lbProgress = new LollipopLabel();
            this.pgbDescarga = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblStatus = new LollipopLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblRegistros = new MaterialSkin.Controls.MaterialLabel();
            this.lblPorcentaje = new MaterialSkin.Controls.MaterialLabel();
            this.lblArchivos = new MaterialSkin.Controls.MaterialLabel();
            this.pnlCarga = new System.Windows.Forms.Panel();
            this.pgbCargaBancos = new LollipopProgressBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ofdArchivoCarga = new System.Windows.Forms.OpenFileDialog();
            this.bgwCarga = new System.ComponentModel.BackgroundWorker();
            this.btnCancelar = new LollipopFlatButton();
            this.pnlPlantilla.SuspendLayout();
            this.pnlDescarga.SuspendLayout();
            this.pnlCarga.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkCerrar
            // 
            this.lnkCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.lnkCerrar.Image = global::LxCallcenter.Properties.Resources.delete_sign_filled_23px;
            this.lnkCerrar.ImageSize = 25;
            this.lnkCerrar.Location = new System.Drawing.Point(620, 7);
            this.lnkCerrar.Name = "lnkCerrar";
            this.lnkCerrar.NoFocusImage = global::LxCallcenter.Properties.Resources.delete_sign_23px;
            this.lnkCerrar.Size = new System.Drawing.Size(25, 25);
            this.lnkCerrar.TabIndex = 8;
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
            // lnkSeleccionarArchivo
            // 
            this.lnkSeleccionarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSeleccionarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkSeleccionarArchivo.Image = global::LxCallcenter.Properties.Resources.more_23px;
            this.lnkSeleccionarArchivo.ImageSize = 23;
            this.lnkSeleccionarArchivo.Location = new System.Drawing.Point(419, 18);
            this.lnkSeleccionarArchivo.Name = "lnkSeleccionarArchivo";
            this.lnkSeleccionarArchivo.NoFocusImage = global::LxCallcenter.Properties.Resources.more_23px;
            this.lnkSeleccionarArchivo.Size = new System.Drawing.Size(25, 7);
            this.lnkSeleccionarArchivo.TabIndex = 32;
            this.metroToolTip1.SetToolTip(this.lnkSeleccionarArchivo, "Seleccionar Archivo");
            this.lnkSeleccionarArchivo.UseSelectable = true;
            this.lnkSeleccionarArchivo.Click += new System.EventHandler(this.lnkSeleccionarArchivo_Click);
            // 
            // lnkPlantilla
            // 
            this.lnkPlantilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkPlantilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkPlantilla.ImageSize = 23;
            this.lnkPlantilla.Location = new System.Drawing.Point(40, 57);
            this.lnkPlantilla.Name = "lnkPlantilla";
            this.lnkPlantilla.Size = new System.Drawing.Size(109, 15);
            this.lnkPlantilla.TabIndex = 33;
            this.lnkPlantilla.Text = "Descargar Plantilla";
            this.metroToolTip1.SetToolTip(this.lnkPlantilla, "Seleccionar Archivo");
            this.lnkPlantilla.UseSelectable = true;
            this.lnkPlantilla.Click += new System.EventHandler(this.lnkPlantilla_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.Location = new System.Drawing.Point(4, 4);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(129, 20);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Nuevo Prospecto";
            // 
            // cmbxRegimen
            // 
            this.cmbxRegimen.DataSource = null;
            this.cmbxRegimen.Depth = 0;
            this.cmbxRegimen.DisplayMember = "";
            this.cmbxRegimen.DropDownWidth = 221;
            this.cmbxRegimen.Hint = "";
            this.cmbxRegimen.Location = new System.Drawing.Point(89, 100);
            this.cmbxRegimen.MaxLength = 0;
            this.cmbxRegimen.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbxRegimen.Name = "cmbxRegimen";
            this.cmbxRegimen.PasswordChar = '\0';
            this.cmbxRegimen.SelectedIndex = -1;
            this.cmbxRegimen.SelectedItem = null;
            this.cmbxRegimen.SelectedText = "";
            this.cmbxRegimen.SelectedValue = null;
            this.cmbxRegimen.Size = new System.Drawing.Size(221, 30);
            this.cmbxRegimen.TabIndex = 11;
            this.cmbxRegimen.TabStop = false;
            this.cmbxRegimen.UseSystemPasswordChar = false;
            this.cmbxRegimen.ValueMember = "";
            this.cmbxRegimen.SelectionChangeCommitted += new System.EventHandler(this.cmbxRegimen_SelectionChangeCommitted);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.Location = new System.Drawing.Point(85, 78);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(70, 20);
            this.materialLabel10.TabIndex = 10;
            this.materialLabel10.Text = "Regimen";
            // 
            // pnlPlantilla
            // 
            this.pnlPlantilla.Controls.Add(this.btnGuardar);
            this.pnlPlantilla.Controls.Add(this.lnkSeleccionarArchivo);
            this.pnlPlantilla.Controls.Add(this.txtArchivoCarga);
            this.pnlPlantilla.Controls.Add(this.materialLabel3);
            this.pnlPlantilla.Controls.Add(this.pnlDescarga);
            this.pnlPlantilla.Controls.Add(this.lnkPlantilla);
            this.pnlPlantilla.Location = new System.Drawing.Point(3, 3);
            this.pnlPlantilla.Name = "pnlPlantilla";
            this.pnlPlantilla.Size = new System.Drawing.Size(488, 122);
            this.pnlPlantilla.TabIndex = 0;
            this.pnlPlantilla.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BGColor = "#3f51b5";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FontColor = "#ffffff";
            this.btnGuardar.Location = new System.Drawing.Point(182, 96);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 22);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Realizar carga";
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtArchivoCarga
            // 
            this.txtArchivoCarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtArchivoCarga.Depth = 0;
            this.txtArchivoCarga.Hint = "";
            this.txtArchivoCarga.Location = new System.Drawing.Point(44, 28);
            this.txtArchivoCarga.MaxLength = 32767;
            this.txtArchivoCarga.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtArchivoCarga.Name = "txtArchivoCarga";
            this.txtArchivoCarga.PasswordChar = '\0';
            this.txtArchivoCarga.ReadOnly = true;
            this.txtArchivoCarga.SelectedText = "";
            this.txtArchivoCarga.SelectionLength = 0;
            this.txtArchivoCarga.SelectionStart = 0;
            this.txtArchivoCarga.Size = new System.Drawing.Size(400, 23);
            this.txtArchivoCarga.TabIndex = 31;
            this.txtArchivoCarga.TabStop = false;
            this.txtArchivoCarga.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtArchivoCarga.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.Location = new System.Drawing.Point(40, 5);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(62, 20);
            this.materialLabel3.TabIndex = 30;
            this.materialLabel3.Text = "Archivo";
            // 
            // pnlDescarga
            // 
            this.pnlDescarga.Controls.Add(this.lbProgress);
            this.pnlDescarga.Controls.Add(this.pgbDescarga);
            this.pnlDescarga.Controls.Add(this.lblStatus);
            this.pnlDescarga.Location = new System.Drawing.Point(38, 53);
            this.pnlDescarga.Name = "pnlDescarga";
            this.pnlDescarga.Size = new System.Drawing.Size(284, 43);
            this.pnlDescarga.TabIndex = 29;
            this.pnlDescarga.Visible = false;
            // 
            // lbProgress
            // 
            this.lbProgress.BackColor = System.Drawing.Color.Transparent;
            this.lbProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lbProgress.Location = new System.Drawing.Point(29, 4);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(252, 17);
            this.lbProgress.TabIndex = 30;
            this.lbProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pgbDescarga
            // 
            this.pgbDescarga.EnsureVisible = false;
            this.pgbDescarga.Location = new System.Drawing.Point(3, 2);
            this.pgbDescarga.Maximum = 100;
            this.pgbDescarga.Name = "pgbDescarga";
            this.pgbDescarga.Size = new System.Drawing.Size(22, 22);
            this.pgbDescarga.Spinning = false;
            this.pgbDescarga.Style = MetroFramework.MetroColorStyle.Red;
            this.pgbDescarga.TabIndex = 33;
            this.pgbDescarga.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pgbDescarga.UseSelectable = true;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblStatus.Location = new System.Drawing.Point(29, 21);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(252, 17);
            this.lblStatus.TabIndex = 31;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Enabled = false;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(85, 25);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(506, 40);
            this.materialLabel2.TabIndex = 26;
            this.materialLabel2.Text = "Seleccione el regimen y a continuación el archivo en Excel que contiene\r\nel lista" +
    "do de prospectos.";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Depth = 0;
            this.lblRegistros.Enabled = false;
            this.lblRegistros.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRegistros.Location = new System.Drawing.Point(38, 74);
            this.lblRegistros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(400, 19);
            this.lblRegistros.TabIndex = 29;
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Depth = 0;
            this.lblPorcentaje.Enabled = false;
            this.lblPorcentaje.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPorcentaje.Location = new System.Drawing.Point(182, 6);
            this.lblPorcentaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(114, 19);
            this.lblPorcentaje.TabIndex = 27;
            this.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchivos
            // 
            this.lblArchivos.Depth = 0;
            this.lblArchivos.Enabled = false;
            this.lblArchivos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblArchivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblArchivos.Location = new System.Drawing.Point(38, 51);
            this.lblArchivos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(400, 20);
            this.lblArchivos.TabIndex = 28;
            this.lblArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCarga
            // 
            this.pnlCarga.Controls.Add(this.pgbCargaBancos);
            this.pnlCarga.Controls.Add(this.lblArchivos);
            this.pnlCarga.Controls.Add(this.lblRegistros);
            this.pnlCarga.Controls.Add(this.lblPorcentaje);
            this.pnlCarga.Location = new System.Drawing.Point(3, 131);
            this.pnlCarga.Name = "pnlCarga";
            this.pnlCarga.Size = new System.Drawing.Size(488, 98);
            this.pnlCarga.TabIndex = 27;
            this.pnlCarga.Visible = false;
            // 
            // pgbCargaBancos
            // 
            this.pgbCargaBancos.BGColor = "#508ef5";
            this.pgbCargaBancos.Location = new System.Drawing.Point(38, 29);
            this.pgbCargaBancos.Maximum = 100;
            this.pgbCargaBancos.Name = "pgbCargaBancos";
            this.pgbCargaBancos.Size = new System.Drawing.Size(400, 4);
            this.pgbCargaBancos.TabIndex = 26;
            this.pgbCargaBancos.Text = "lollipopProgressBar1";
            this.pgbCargaBancos.Value = 0;
            this.pgbCargaBancos.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlPlantilla);
            this.flowLayoutPanel1.Controls.Add(this.pnlCarga);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(87, 141);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(493, 127);
            this.flowLayoutPanel1.TabIndex = 28;
            // 
            // ofdArchivoCarga
            // 
            this.ofdArchivoCarga.Filter = "Archivos Excel|*.xlsx; *.xls;";
            this.ofdArchivoCarga.Title = "Seleccionar Plantilla";
            // 
            // bgwCarga
            // 
            this.bgwCarga.WorkerReportsProgress = true;
            this.bgwCarga.WorkerSupportsCancellation = true;
            this.bgwCarga.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCarga_DoWork);
            this.bgwCarga.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwCarga_ProgressChanged);
            this.bgwCarga.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCarga_RunWorkerCompleted);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FontColor = "#B71C1C";
            this.btnCancelar.Location = new System.Drawing.Point(487, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.Click += new System.EventHandler(this.lnkCerrar_Click);
            // 
            // frmProspectosAltaMasiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.lnkCerrar;
            this.ClientSize = new System.Drawing.Size(652, 310);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cmbxRegimen);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lnkCerrar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(652, 310);
            this.MinimizeBox = false;
            this.Name = "frmProspectosAltaMasiva";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProspectosAltaMasiva";
            this.pnlPlantilla.ResumeLayout(false);
            this.pnlPlantilla.PerformLayout();
            this.pnlDescarga.ResumeLayout(false);
            this.pnlCarga.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkCerrar;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cmbxRegimen;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.Panel pnlPlantilla;
        private LollipopFlatButton btnCancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblRegistros;
        private MaterialSkin.Controls.MaterialLabel lblPorcentaje;
        private MaterialSkin.Controls.MaterialLabel lblArchivos;
        private LollipopProgressBar pgbCargaBancos;
        private LollipopButton btnGuardar;
        private MetroFramework.Controls.MetroLink lnkSeleccionarArchivo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtArchivoCarga;
        private MetroFramework.Controls.MetroLink lnkPlantilla;
        private System.Windows.Forms.Panel pnlCarga;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog ofdArchivoCarga;
        private System.ComponentModel.BackgroundWorker bgwCarga;
        private LollipopLabel lbProgress;
        private LollipopLabel lblStatus;
        private MetroFramework.Controls.MetroProgressSpinner pgbDescarga;
        private System.Windows.Forms.Panel pnlDescarga;
    }
}