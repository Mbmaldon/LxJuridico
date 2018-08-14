namespace LxCallcenter
{
    partial class frmSubirArchivos
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
            this.pnlDescarga = new System.Windows.Forms.Panel();
            this.pgbDescarga = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblNombreArchivo = new MaterialSkin.Controls.MaterialLabel();
            this.pnlBtms = new System.Windows.Forms.Panel();
            this.btnCerrar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbProgress = new LollipopLabel();
            this.lblStatus = new LollipopLabel();
            this.pnlDescarga.SuspendLayout();
            this.pnlBtms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDescarga
            // 
            this.pnlDescarga.Controls.Add(this.lbProgress);
            this.pnlDescarga.Controls.Add(this.pgbDescarga);
            this.pnlDescarga.Controls.Add(this.lblStatus);
            this.pnlDescarga.Location = new System.Drawing.Point(22, 30);
            this.pnlDescarga.Name = "pnlDescarga";
            this.pnlDescarga.Size = new System.Drawing.Size(284, 43);
            this.pnlDescarga.TabIndex = 37;
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
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoEllipsis = true;
            this.lblNombreArchivo.Depth = 0;
            this.lblNombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombreArchivo.Location = new System.Drawing.Point(22, 8);
            this.lblNombreArchivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(284, 18);
            this.lblNombreArchivo.TabIndex = 36;
            this.lblNombreArchivo.Text = "Carga de archivo";
            // 
            // pnlBtms
            // 
            this.pnlBtms.Controls.Add(this.btnCerrar);
            this.pnlBtms.Location = new System.Drawing.Point(22, 79);
            this.pnlBtms.Name = "pnlBtms";
            this.pnlBtms.Size = new System.Drawing.Size(284, 32);
            this.pnlBtms.TabIndex = 38;
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
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
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
            // frmSubirArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(329, 119);
            this.Controls.Add(this.pnlDescarga);
            this.Controls.Add(this.lblNombreArchivo);
            this.Controls.Add(this.pnlBtms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubirArchivos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSubirArchivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSubirArchivos_FormClosing);
            this.Shown += new System.EventHandler(this.frmSubirArchivos_Shown);
            this.pnlDescarga.ResumeLayout(false);
            this.pnlBtms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDescarga;
        private LollipopLabel lbProgress;
        private MetroFramework.Controls.MetroProgressSpinner pgbDescarga;
        private LollipopLabel lblStatus;
        private MaterialSkin.Controls.MaterialLabel lblNombreArchivo;
        private System.Windows.Forms.Panel pnlBtms;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCerrar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}