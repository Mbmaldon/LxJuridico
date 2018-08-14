namespace LxCallcenter
{
    partial class frmNuevaCarpeta
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
            this.txtNombreCarpeta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCrear = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel1.Location = new System.Drawing.Point(24, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Nueva Carpeta";
            // 
            // txtNombreCarpeta
            // 
            this.txtNombreCarpeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreCarpeta.Depth = 0;
            this.txtNombreCarpeta.Hint = "";
            this.txtNombreCarpeta.Location = new System.Drawing.Point(28, 43);
            this.txtNombreCarpeta.MaxLength = 32767;
            this.txtNombreCarpeta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreCarpeta.Name = "txtNombreCarpeta";
            this.txtNombreCarpeta.PasswordChar = '\0';
            this.txtNombreCarpeta.ReadOnly = false;
            this.txtNombreCarpeta.SelectedText = "";
            this.txtNombreCarpeta.SelectionLength = 0;
            this.txtNombreCarpeta.SelectionStart = 0;
            this.txtNombreCarpeta.Size = new System.Drawing.Size(226, 25);
            this.txtNombreCarpeta.TabIndex = 1;
            this.txtNombreCarpeta.TabStop = false;
            this.txtNombreCarpeta.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreCarpeta.UseSystemPasswordChar = false;
            // 
            // btnCrear
            // 
            this.btnCrear.BGColor = "#1A237E";
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.Depth = 0;
            this.btnCrear.Icon = null;
            this.btnCrear.Location = new System.Drawing.Point(62, 82);
            this.btnCrear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Primary = true;
            this.btnCrear.Size = new System.Drawing.Size(105, 23);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BGColor = "#B71C1C";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(173, 82);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(81, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmNuevaCarpeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(281, 121);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtNombreCarpeta);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevaCarpeta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevaCarpeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreCarpeta;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCrear;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCancelar;
    }
}