namespace ControlActividadesJuridico.Representacion.AddFolders
{
    partial class FAddFolder
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
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.txtNomFolder = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.frm1 = new DevExpress.XtraEditors.PanelControl();
            this.frm2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).BeginInit();
            this.frm1.SuspendLayout();
            this.frm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BGColor = "#3F51B5";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(167, 71);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(87, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BGColor = "#B71C1C";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(261, 71);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(71, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNomFolder
            // 
            this.txtNomFolder.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNomFolder.Depth = 0;
            this.txtNomFolder.Hint = "";
            this.txtNomFolder.Location = new System.Drawing.Point(22, 37);
            this.txtNomFolder.MaxLength = 32767;
            this.txtNomFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomFolder.Name = "txtNomFolder";
            this.txtNomFolder.PasswordChar = '\0';
            this.txtNomFolder.ReadOnly = false;
            this.txtNomFolder.SelectedText = "";
            this.txtNomFolder.SelectionLength = 0;
            this.txtNomFolder.SelectionStart = 0;
            this.txtNomFolder.Size = new System.Drawing.Size(310, 23);
            this.txtNomFolder.TabIndex = 8;
            this.txtNomFolder.TabStop = false;
            this.txtNomFolder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNomFolder.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.Location = new System.Drawing.Point(18, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(155, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Nombre de la Carpeta";
            // 
            // frm1
            // 
            this.frm1.Controls.Add(this.frm2);
            this.frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm1.Location = new System.Drawing.Point(0, 0);
            this.frm1.Name = "frm1";
            this.frm1.Size = new System.Drawing.Size(356, 109);
            this.frm1.TabIndex = 10;
            // 
            // frm2
            // 
            this.frm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frm2.Controls.Add(this.txtNomFolder);
            this.frm2.Controls.Add(this.materialLabel1);
            this.frm2.Controls.Add(this.btnAgregar);
            this.frm2.Controls.Add(this.btnCancelar);
            this.frm2.Location = new System.Drawing.Point(2, 2);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(352, 105);
            this.frm2.TabIndex = 0;
            // 
            // FAddFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(356, 109);
            this.Controls.Add(this.frm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAddFolder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Carpeta";
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).EndInit();
            this.frm1.ResumeLayout(false);
            this.frm2.ResumeLayout(false);
            this.frm2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnAgregar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCancelar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomFolder;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private DevExpress.XtraEditors.PanelControl frm1;
        private System.Windows.Forms.Panel frm2;
    }
}