namespace LxCallcenter
{
    partial class FlatMessageBox
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
            this.lblMessage = new MetroFramework.Controls.MetroLabel();
            this.ptbImagenDescripcion = new System.Windows.Forms.PictureBox();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.btnYes = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnNo = new LollipopFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenDescripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblMessage.Location = new System.Drawing.Point(12, 83);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(414, 96);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Aquí va el mensaje";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.UseCustomBackColor = true;
            // 
            // ptbImagenDescripcion
            // 
            this.ptbImagenDescripcion.BackgroundImage = global::LxCallcenter.Properties.Resources.help_96px;
            this.ptbImagenDescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbImagenDescripcion.Location = new System.Drawing.Point(178, 7);
            this.ptbImagenDescripcion.Name = "ptbImagenDescripcion";
            this.ptbImagenDescripcion.Size = new System.Drawing.Size(77, 73);
            this.ptbImagenDescripcion.TabIndex = 0;
            this.ptbImagenDescripcion.TabStop = false;
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(184)))), ((int)(((byte)(87)))));
            this.pnlColor.Location = new System.Drawing.Point(-1, 225);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(439, 3);
            this.pnlColor.TabIndex = 4;
            // 
            // btnYes
            // 
            this.btnYes.BGColor = "#6200EA";
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.Depth = 0;
            this.btnYes.Icon = null;
            this.btnYes.Location = new System.Drawing.Point(128, 185);
            this.btnYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYes.Name = "btnYes";
            this.btnYes.Primary = true;
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 5;
            this.btnYes.Text = "SI";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.FontColor = "#B71C1C";
            this.btnNo.Location = new System.Drawing.Point(242, 185);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "NO";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // FlatMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 227);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.ptbImagenDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlatMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FlatMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenDescripcion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbImagenDescripcion;
        private MetroFramework.Controls.MetroLabel lblMessage;
        private System.Windows.Forms.Panel pnlColor;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnYes;
        private LollipopFlatButton btnNo;
    }
}