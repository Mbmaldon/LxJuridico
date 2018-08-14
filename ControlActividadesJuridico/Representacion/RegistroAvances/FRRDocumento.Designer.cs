namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    partial class FRRDocumento
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
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.openFileDialogDocumento = new System.Windows.Forms.OpenFileDialog();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.frm1 = new DevExpress.XtraEditors.PanelControl();
            this.frm2 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnCerrar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnAdjuntar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.lblReq = new MaterialSkin.Controls.MaterialLabel();
            this.txtRequ = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.rbSI = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbNO = new MaterialSkin.Controls.MaterialRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).BeginInit();
            this.frm1.SuspendLayout();
            this.frm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.BackColor = System.Drawing.Color.White;
            this.txtRutaArchivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRutaArchivo.Enabled = false;
            this.txtRutaArchivo.Location = new System.Drawing.Point(117, 122);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(249, 14);
            this.txtRutaArchivo.TabIndex = 8;
            this.txtRutaArchivo.Visible = false;
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
            // frm1
            // 
            this.frm1.Controls.Add(this.frm2);
            this.frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm1.Location = new System.Drawing.Point(0, 0);
            this.frm1.Name = "frm1";
            this.frm1.Size = new System.Drawing.Size(516, 201);
            this.frm1.TabIndex = 9;
            // 
            // frm2
            // 
            this.frm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frm2.Controls.Add(this.rbNO);
            this.frm2.Controls.Add(this.rbSI);
            this.frm2.Controls.Add(this.label3);
            this.frm2.Controls.Add(this.txtRequ);
            this.frm2.Controls.Add(this.lblReq);
            this.frm2.Controls.Add(this.btnAdjuntar);
            this.frm2.Controls.Add(this.btnCerrar);
            this.frm2.Controls.Add(this.btnRegistrar);
            this.frm2.Controls.Add(this.txtRutaArchivo);
            this.frm2.Location = new System.Drawing.Point(2, 2);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(512, 197);
            this.frm2.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BGColor = "#3F51B5";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.Icon = null;
            this.btnRegistrar.Location = new System.Drawing.Point(280, 158);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Primary = true;
            this.btnRegistrar.Size = new System.Drawing.Size(112, 23);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BGColor = "#B71C1C";
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Depth = 0;
            this.btnCerrar.Icon = null;
            this.btnCerrar.Location = new System.Drawing.Point(398, 158);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Primary = true;
            this.btnCerrar.Size = new System.Drawing.Size(90, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.BGColor = "#508ef5";
            this.btnAdjuntar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjuntar.Depth = 0;
            this.btnAdjuntar.Icon = null;
            this.btnAdjuntar.Location = new System.Drawing.Point(36, 118);
            this.btnAdjuntar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Primary = true;
            this.btnAdjuntar.Size = new System.Drawing.Size(75, 23);
            this.btnAdjuntar.TabIndex = 11;
            this.btnAdjuntar.Text = "Adjuntar";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Visible = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // lblReq
            // 
            this.lblReq.AutoSize = true;
            this.lblReq.Depth = 0;
            this.lblReq.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblReq.Location = new System.Drawing.Point(32, 41);
            this.lblReq.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReq.Name = "lblReq";
            this.lblReq.Size = new System.Drawing.Size(41, 19);
            this.lblReq.TabIndex = 12;
            this.lblReq.Text = "label";
            // 
            // txtRequ
            // 
            this.txtRequ.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRequ.Depth = 0;
            this.txtRequ.Enabled = false;
            this.txtRequ.Hint = "";
            this.txtRequ.Location = new System.Drawing.Point(195, 37);
            this.txtRequ.MaxLength = 32767;
            this.txtRequ.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRequ.Name = "txtRequ";
            this.txtRequ.PasswordChar = '\0';
            this.txtRequ.ReadOnly = false;
            this.txtRequ.SelectedText = "";
            this.txtRequ.SelectionLength = 0;
            this.txtRequ.SelectionStart = 0;
            this.txtRequ.Size = new System.Drawing.Size(293, 23);
            this.txtRequ.TabIndex = 13;
            this.txtRequ.TabStop = false;
            this.txtRequ.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRequ.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.Location = new System.Drawing.Point(32, 81);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Requisición recibida:";
            // 
            // rbSI
            // 
            this.rbSI.AutoSize = true;
            this.rbSI.Depth = 0;
            this.rbSI.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbSI.Location = new System.Drawing.Point(195, 76);
            this.rbSI.Margin = new System.Windows.Forms.Padding(0);
            this.rbSI.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbSI.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbSI.Name = "rbSI";
            this.rbSI.Ripple = true;
            this.rbSI.Size = new System.Drawing.Size(41, 30);
            this.rbSI.TabIndex = 15;
            this.rbSI.Text = "Si";
            this.rbSI.UseVisualStyleBackColor = true;
            this.rbSI.CheckedChanged += new System.EventHandler(this.rbSI_CheckedChanged);
            // 
            // rbNO
            // 
            this.rbNO.AutoSize = true;
            this.rbNO.Checked = true;
            this.rbNO.Depth = 0;
            this.rbNO.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbNO.Location = new System.Drawing.Point(259, 76);
            this.rbNO.Margin = new System.Windows.Forms.Padding(0);
            this.rbNO.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbNO.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbNO.Name = "rbNO";
            this.rbNO.Ripple = true;
            this.rbNO.Size = new System.Drawing.Size(47, 30);
            this.rbNO.TabIndex = 16;
            this.rbNO.TabStop = true;
            this.rbNO.Text = "No";
            this.rbNO.UseVisualStyleBackColor = true;
            this.rbNO.CheckedChanged += new System.EventHandler(this.rbSI_CheckedChanged);
            // 
            // FRRDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 201);
            this.Controls.Add(this.frm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRRDocumento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepción de Documento";
            this.Load += new System.EventHandler(this.FRRDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).EndInit();
            this.frm1.ResumeLayout(false);
            this.frm2.ResumeLayout(false);
            this.frm2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialogDocumento;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private DevExpress.XtraEditors.PanelControl frm1;
        private System.Windows.Forms.Panel frm2;
        private MaterialSkin.Controls.MaterialRadioButton rbNO;
        private MaterialSkin.Controls.MaterialRadioButton rbSI;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRequ;
        private MaterialSkin.Controls.MaterialLabel lblReq;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnAdjuntar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCerrar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnRegistrar;
    }
}