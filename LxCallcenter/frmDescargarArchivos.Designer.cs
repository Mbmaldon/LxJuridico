namespace LxCallcenter
{
    partial class frmDescargarArchivos
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
            this.lblNombreArchivo = new MaterialSkin.Controls.MaterialLabel();
            this.pnlDescarga = new System.Windows.Forms.Panel();
            this.pgbDescarga = new MetroFramework.Controls.MetroProgressSpinner();
            this.btnAbrir = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnOpciones = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.pnlBtms = new System.Windows.Forms.Panel();
            this.btnCerrar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEnCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbProgress = new LollipopLabel();
            this.lblStatus = new LollipopLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlDescarga.SuspendLayout();
            this.pnlBtms.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoEllipsis = true;
            this.lblNombreArchivo.Depth = 0;
            this.lblNombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombreArchivo.Location = new System.Drawing.Point(24, 7);
            this.lblNombreArchivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(284, 18);
            this.lblNombreArchivo.TabIndex = 0;
            this.lblNombreArchivo.Text = "Descarga de archivo";
            // 
            // pnlDescarga
            // 
            this.pnlDescarga.Controls.Add(this.lbProgress);
            this.pnlDescarga.Controls.Add(this.pgbDescarga);
            this.pnlDescarga.Controls.Add(this.lblStatus);
            this.pnlDescarga.Location = new System.Drawing.Point(24, 29);
            this.pnlDescarga.Name = "pnlDescarga";
            this.pnlDescarga.Size = new System.Drawing.Size(284, 43);
            this.pnlDescarga.TabIndex = 30;
            // 
            // pgbDescarga
            // 
            this.pgbDescarga.EnsureVisible = false;
            this.pgbDescarga.Location = new System.Drawing.Point(3, 7);
            this.pgbDescarga.Maximum = 100;
            this.pgbDescarga.Name = "pgbDescarga";
            this.pgbDescarga.Size = new System.Drawing.Size(27, 27);
            this.pgbDescarga.Spinning = false;
            this.pgbDescarga.Style = MetroFramework.MetroColorStyle.Red;
            this.pgbDescarga.TabIndex = 33;
            this.pgbDescarga.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pgbDescarga.UseSelectable = true;
            // 
            // btnAbrir
            // 
            this.btnAbrir.BGColor = "#1A237E";
            this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrir.Depth = 0;
            this.btnAbrir.Icon = null;
            this.btnAbrir.Location = new System.Drawing.Point(92, 4);
            this.btnAbrir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Primary = true;
            this.btnAbrir.Size = new System.Drawing.Size(96, 23);
            this.btnAbrir.TabIndex = 32;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnOpciones
            // 
            this.btnOpciones.BGColor = "#1A237E";
            this.btnOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpciones.Depth = 0;
            this.btnOpciones.Icon = null;
            this.btnOpciones.Location = new System.Drawing.Point(188, 4);
            this.btnOpciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Primary = true;
            this.btnOpciones.Size = new System.Drawing.Size(15, 23);
            this.btnOpciones.TabIndex = 33;
            this.btnOpciones.Text = "⮟";
            this.btnOpciones.UseVisualStyleBackColor = true;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // pnlBtms
            // 
            this.pnlBtms.Controls.Add(this.btnCerrar);
            this.pnlBtms.Controls.Add(this.btnOpciones);
            this.pnlBtms.Controls.Add(this.btnAbrir);
            this.pnlBtms.Location = new System.Drawing.Point(24, 78);
            this.pnlBtms.Name = "pnlBtms";
            this.pnlBtms.Size = new System.Drawing.Size(284, 32);
            this.pnlBtms.TabIndex = 35;
            this.pnlBtms.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BGColor = "#B71C1C";
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Depth = 0;
            this.btnCerrar.Icon = null;
            this.btnCerrar.Location = new System.Drawing.Point(206, 4);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Primary = true;
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 37;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.mostrarEnCarpetaToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(174, 48);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // mostrarEnCarpetaToolStripMenuItem
            // 
            this.mostrarEnCarpetaToolStripMenuItem.Name = "mostrarEnCarpetaToolStripMenuItem";
            this.mostrarEnCarpetaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.mostrarEnCarpetaToolStripMenuItem.Text = "Mostrar en carpeta";
            this.mostrarEnCarpetaToolStripMenuItem.Click += new System.EventHandler(this.mostrarEnCarpetaToolStripMenuItem_Click);
            // 
            // lbProgress
            // 
            this.lbProgress.BackColor = System.Drawing.Color.Transparent;
            this.lbProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lbProgress.Location = new System.Drawing.Point(36, 4);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(246, 17);
            this.lbProgress.TabIndex = 30;
            this.lbProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblStatus.Location = new System.Drawing.Point(36, 21);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(246, 17);
            this.lblStatus.TabIndex = 31;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmDescargarArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(329, 119);
            this.Controls.Add(this.pnlDescarga);
            this.Controls.Add(this.lblNombreArchivo);
            this.Controls.Add(this.pnlBtms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDescargarArchivos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDescargarArchivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDescargarArchivos_FormClosing);
            this.Shown += new System.EventHandler(this.frmDescargarArchivos_Shown);
            this.pnlDescarga.ResumeLayout(false);
            this.pnlBtms.ResumeLayout(false);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblNombreArchivo;
        private System.Windows.Forms.Panel pnlDescarga;
        private LollipopLabel lbProgress;
        private MetroFramework.Controls.MetroProgressSpinner pgbDescarga;
        private LollipopLabel lblStatus;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnAbrir;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnOpciones;
        private System.Windows.Forms.Panel pnlBtms;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEnCarpetaToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCerrar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}