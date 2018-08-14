namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    partial class FRRRegistrarPropuesta
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
            this.txtPropuesta = new System.Windows.Forms.TextBox();
            this.openFileDialogDocumento = new System.Windows.Forms.OpenFileDialog();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.txtRutaArchivo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAdjuntar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.frm1 = new DevExpress.XtraEditors.PanelControl();
            this.frm2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).BeginInit();
            this.frm1.SuspendLayout();
            this.frm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPropuesta
            // 
            this.txtPropuesta.Location = new System.Drawing.Point(30, 39);
            this.txtPropuesta.MaxLength = 4000;
            this.txtPropuesta.Multiline = true;
            this.txtPropuesta.Name = "txtPropuesta";
            this.txtPropuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPropuesta.Size = new System.Drawing.Size(461, 126);
            this.txtPropuesta.TabIndex = 2;
            // 
            // openFileDialogDocumento
            // 
            this.openFileDialogDocumento.FileName = "openFileDialog1";
            this.openFileDialogDocumento.Multiselect = true;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BGColor = "#3F51B5";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.Icon = null;
            this.btnRegistrar.Location = new System.Drawing.Point(283, 240);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Primary = true;
            this.btnRegistrar.Size = new System.Drawing.Size(126, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BGColor = "#B71C1C";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(416, 240);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRutaArchivo.Depth = 0;
            this.txtRutaArchivo.Hint = "Ruta del archivo";
            this.txtRutaArchivo.Location = new System.Drawing.Point(111, 188);
            this.txtRutaArchivo.MaxLength = 32767;
            this.txtRutaArchivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.PasswordChar = '\0';
            this.txtRutaArchivo.ReadOnly = true;
            this.txtRutaArchivo.SelectedText = "";
            this.txtRutaArchivo.SelectionLength = 0;
            this.txtRutaArchivo.SelectionStart = 0;
            this.txtRutaArchivo.Size = new System.Drawing.Size(380, 23);
            this.txtRutaArchivo.TabIndex = 7;
            this.txtRutaArchivo.TabStop = false;
            this.txtRutaArchivo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRutaArchivo.UseSystemPasswordChar = false;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.BGColor = "#508ef5";
            this.btnAdjuntar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjuntar.Depth = 0;
            this.btnAdjuntar.Icon = null;
            this.btnAdjuntar.Location = new System.Drawing.Point(30, 188);
            this.btnAdjuntar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Primary = true;
            this.btnAdjuntar.Size = new System.Drawing.Size(75, 23);
            this.btnAdjuntar.TabIndex = 8;
            this.btnAdjuntar.Text = "Adjuntar";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Describir Propuesta";
            // 
            // frm1
            // 
            this.frm1.Controls.Add(this.frm2);
            this.frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm1.Location = new System.Drawing.Point(0, 0);
            this.frm1.Name = "frm1";
            this.frm1.Size = new System.Drawing.Size(526, 279);
            this.frm1.TabIndex = 10;
            // 
            // frm2
            // 
            this.frm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frm2.Controls.Add(this.label1);
            this.frm2.Controls.Add(this.txtPropuesta);
            this.frm2.Controls.Add(this.btnAdjuntar);
            this.frm2.Controls.Add(this.btnRegistrar);
            this.frm2.Controls.Add(this.txtRutaArchivo);
            this.frm2.Controls.Add(this.btnCancelar);
            this.frm2.Location = new System.Drawing.Point(2, 2);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(522, 275);
            this.frm2.TabIndex = 0;
            // 
            // FRRRegistrarPropuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 279);
            this.Controls.Add(this.frm1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRRRegistrarPropuesta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRRRegistrarPropuesta";
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).EndInit();
            this.frm1.ResumeLayout(false);
            this.frm2.ResumeLayout(false);
            this.frm2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPropuesta;
        private System.Windows.Forms.OpenFileDialog openFileDialogDocumento;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnRegistrar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCancelar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRutaArchivo;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnAdjuntar;
        private MaterialSkin.Controls.MaterialLabel label1;
        private DevExpress.XtraEditors.PanelControl frm1;
        private System.Windows.Forms.Panel frm2;
    }
}