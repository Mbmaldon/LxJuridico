namespace LxCallcenter
{
    partial class frmComentarioCerrarFolio
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txbDescripcion = new LollipopTextBox();
            this.btnCerrarFolio = new LollipopButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new LollipopFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(38, 57);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(96, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Comentarios";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(38, 20);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(88, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Cerrar Folio";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.FocusedColor = "#FFA300";
            this.txbDescripcion.FontColor = "#999999";
            this.txbDescripcion.IsEnabled = true;
            this.txbDescripcion.Location = new System.Drawing.Point(42, 80);
            this.txbDescripcion.MaxLength = 32767;
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.ReadOnly = false;
            this.txbDescripcion.Size = new System.Drawing.Size(517, 114);
            this.txbDescripcion.TabIndex = 2;
            this.txbDescripcion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbDescripcion.UseSystemPasswordChar = false;
            // 
            // btnCerrarFolio
            // 
            this.btnCerrarFolio.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarFolio.BGColor = "#001489";
            this.btnCerrarFolio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarFolio.FontColor = "#ffffff";
            this.btnCerrarFolio.Location = new System.Drawing.Point(368, 204);
            this.btnCerrarFolio.Name = "btnCerrarFolio";
            this.btnCerrarFolio.Size = new System.Drawing.Size(102, 30);
            this.btnCerrarFolio.TabIndex = 3;
            this.btnCerrarFolio.Text = "Cerrar Folio";
            this.btnCerrarFolio.Click += new System.EventHandler(this.btnCerrarFolio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.panel1.Location = new System.Drawing.Point(-1, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 3);
            this.panel1.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FontColor = "#508ef5";
            this.btnCancelar.Location = new System.Drawing.Point(476, 204);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 30);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmComentarioCerrarFolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(608, 246);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrarFolio);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComentarioCerrarFolio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmComentarioCerrarFolio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private LollipopTextBox txbDescripcion;
        private LollipopButton btnCerrarFolio;
        private System.Windows.Forms.Panel panel1;
        private LollipopFlatButton btnCancelar;
    }
}