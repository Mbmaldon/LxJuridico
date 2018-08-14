namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    partial class frmOperacionesCargaBatch
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lnkNuevaCarga = new MetroFramework.Controls.MetroLink();
            this.lnkSubir = new MetroFramework.Controls.MetroLink();
            this.bgwCargarFacturas = new System.ComponentModel.BackgroundWorker();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.lblNumArchivos = new MaterialSkin.Controls.MaterialLabel();
            this.lblPorcentaje = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pbBarraCarga = new LollipopProgressBar();
            this.ofdCargaFacturas = new LollipopFileInput();
            this.btnCerrar = new LollipopFlatButton();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblFecha.Location = new System.Drawing.Point(13, 60);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(470, 22);
            this.lblFecha.TabIndex = 99;
            this.lblFecha.Text = "Realiza una carga masiva de facturas a traves de un archivo XLSX.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 33);
            this.label4.TabIndex = 98;
            this.label4.Text = "Carga Batch de Facturas";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lnkNuevaCarga
            // 
            this.lnkNuevaCarga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkNuevaCarga.Image = global::LxCallcenter.Properties.Resources.restart_24px;
            this.lnkNuevaCarga.ImageSize = 24;
            this.lnkNuevaCarga.Location = new System.Drawing.Point(269, 294);
            this.lnkNuevaCarga.Name = "lnkNuevaCarga";
            this.lnkNuevaCarga.NoFocusImage = global::LxCallcenter.Properties.Resources.restart_24px;
            this.lnkNuevaCarga.Size = new System.Drawing.Size(24, 24);
            this.lnkNuevaCarga.TabIndex = 108;
            this.metroToolTip1.SetToolTip(this.lnkNuevaCarga, "Nueva Carga");
            this.lnkNuevaCarga.UseSelectable = true;
            this.lnkNuevaCarga.Visible = false;
            this.lnkNuevaCarga.Click += new System.EventHandler(this.lnkNuevaCarga_Click);
            // 
            // lnkSubir
            // 
            this.lnkSubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkSubir.Image = global::LxCallcenter.Properties.Resources.external_96px;
            this.lnkSubir.ImageSize = 65;
            this.lnkSubir.Location = new System.Drawing.Point(249, 150);
            this.lnkSubir.Name = "lnkSubir";
            this.lnkSubir.NoFocusImage = global::LxCallcenter.Properties.Resources.external_96px;
            this.lnkSubir.Size = new System.Drawing.Size(42, 63);
            this.lnkSubir.TabIndex = 103;
            this.metroToolTip1.SetToolTip(this.lnkSubir, "Iniciar Carga");
            this.lnkSubir.UseSelectable = true;
            this.lnkSubir.Visible = false;
            this.lnkSubir.Click += new System.EventHandler(this.lnkSubir_Click);
            // 
            // bgwCargarFacturas
            // 
            this.bgwCargarFacturas.WorkerReportsProgress = true;
            this.bgwCargarFacturas.WorkerSupportsCancellation = true;
            this.bgwCargarFacturas.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.bgwCargarFacturas.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.bgwCargarFacturas.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pnlColor
            // 
            this.pnlColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.pnlColor.Location = new System.Drawing.Point(-1, 330);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(561, 3);
            this.pnlColor.TabIndex = 5;
            // 
            // lblNumArchivos
            // 
            this.lblNumArchivos.Depth = 0;
            this.lblNumArchivos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNumArchivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumArchivos.Location = new System.Drawing.Point(129, 265);
            this.lblNumArchivos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumArchivos.Name = "lblNumArchivos";
            this.lblNumArchivos.Size = new System.Drawing.Size(303, 23);
            this.lblNumArchivos.TabIndex = 107;
            this.lblNumArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Depth = 0;
            this.lblPorcentaje.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPorcentaje.Location = new System.Drawing.Point(129, 232);
            this.lblPorcentaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(303, 23);
            this.lblPorcentaje.TabIndex = 106;
            this.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(125, 100);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 19);
            this.materialLabel1.TabIndex = 102;
            this.materialLabel1.Text = "Archivo";
            // 
            // pbBarraCarga
            // 
            this.pbBarraCarga.BGColor = "#2196f3";
            this.pbBarraCarga.Location = new System.Drawing.Point(79, 225);
            this.pbBarraCarga.Name = "pbBarraCarga";
            this.pbBarraCarga.Size = new System.Drawing.Size(403, 4);
            this.pbBarraCarga.TabIndex = 104;
            this.pbBarraCarga.Text = "lollipopProgressBar1";
            this.pbBarraCarga.Value = 0;
            this.pbBarraCarga.Visible = false;
            // 
            // ofdCargaFacturas
            // 
            this.ofdCargaFacturas.Filter = "Archivo Excel | *.xlsx";
            this.ofdCargaFacturas.FocusedColor = "#FFA300";
            this.ofdCargaFacturas.FontColor = "#999999";
            this.ofdCargaFacturas.IsEnabled = true;
            this.ofdCargaFacturas.Location = new System.Drawing.Point(128, 121);
            this.ofdCargaFacturas.MaxLength = 32767;
            this.ofdCargaFacturas.Name = "ofdCargaFacturas";
            this.ofdCargaFacturas.ReadOnly = true;
            this.ofdCargaFacturas.Size = new System.Drawing.Size(303, 24);
            this.ofdCargaFacturas.TabIndex = 105;
            this.ofdCargaFacturas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ofdCargaFacturas.UseSystemPasswordChar = false;
            this.ofdCargaFacturas.TextChanged += new System.EventHandler(this.lollipopFileInput1_TextChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FontColor = "#B71C1C";
            this.btnCerrar.Location = new System.Drawing.Point(455, 290);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(80, 20);
            this.btnCerrar.TabIndex = 100;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmOperacionesCargaBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(559, 332);
            this.Controls.Add(this.lnkNuevaCarga);
            this.Controls.Add(this.lblNumArchivos);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.pbBarraCarga);
            this.Controls.Add(this.ofdCargaFacturas);
            this.Controls.Add(this.lnkSubir);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOperacionesCargaBatch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmOperacionesCargaBatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label4;
        private LollipopFlatButton btnCerrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroLink lnkSubir;
        private LollipopProgressBar pbBarraCarga;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private LollipopFileInput ofdCargaFacturas;
        private System.ComponentModel.BackgroundWorker bgwCargarFacturas;
        private System.Windows.Forms.Panel pnlColor;
        private MaterialSkin.Controls.MaterialLabel lblPorcentaje;
        private MaterialSkin.Controls.MaterialLabel lblNumArchivos;
        private MetroFramework.Controls.MetroLink lnkNuevaCarga;
    }
}