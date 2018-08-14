namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    partial class FRRRegistroDocumento
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
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnCerrar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.txtRequisicion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblReq = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.rbDocumento = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbTestigo = new MaterialSkin.Controls.MaterialRadioButton();
            this.frm1 = new DevExpress.XtraEditors.PanelControl();
            this.frm2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).BeginInit();
            this.frm1.SuspendLayout();
            this.frm2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnRegistrar.Location = new System.Drawing.Point(275, 118);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Primary = true;
            this.btnRegistrar.Size = new System.Drawing.Size(107, 23);
            this.btnRegistrar.TabIndex = 10;
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
            this.btnCerrar.Location = new System.Drawing.Point(388, 118);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Primary = true;
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtRequisicion
            // 
            this.txtRequisicion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRequisicion.Depth = 0;
            this.txtRequisicion.Hint = "";
            this.txtRequisicion.Location = new System.Drawing.Point(135, 73);
            this.txtRequisicion.MaxLength = 32767;
            this.txtRequisicion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRequisicion.Name = "txtRequisicion";
            this.txtRequisicion.PasswordChar = '\0';
            this.txtRequisicion.ReadOnly = false;
            this.txtRequisicion.SelectedText = "";
            this.txtRequisicion.SelectionLength = 0;
            this.txtRequisicion.SelectionStart = 0;
            this.txtRequisicion.Size = new System.Drawing.Size(328, 23);
            this.txtRequisicion.TabIndex = 12;
            this.txtRequisicion.TabStop = false;
            this.txtRequisicion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRequisicion.UseSystemPasswordChar = false;
            this.txtRequisicion.Visible = false;
            // 
            // lblReq
            // 
            this.lblReq.AutoSize = true;
            this.lblReq.Depth = 0;
            this.lblReq.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblReq.Location = new System.Drawing.Point(16, 77);
            this.lblReq.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReq.Name = "lblReq";
            this.lblReq.Size = new System.Drawing.Size(45, 19);
            this.lblReq.TabIndex = 13;
            this.lblReq.Text = "Label";
            this.lblReq.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.Location = new System.Drawing.Point(16, 33);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tipo de Requisición";
            // 
            // rbDocumento
            // 
            this.rbDocumento.AutoSize = true;
            this.rbDocumento.Depth = 0;
            this.rbDocumento.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbDocumento.Location = new System.Drawing.Point(197, 28);
            this.rbDocumento.Margin = new System.Windows.Forms.Padding(0);
            this.rbDocumento.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDocumento.Name = "rbDocumento";
            this.rbDocumento.Ripple = true;
            this.rbDocumento.Size = new System.Drawing.Size(100, 30);
            this.rbDocumento.TabIndex = 15;
            this.rbDocumento.TabStop = true;
            this.rbDocumento.Text = "Documento";
            this.rbDocumento.UseVisualStyleBackColor = true;
            this.rbDocumento.CheckedChanged += new System.EventHandler(this.rbDocumento_CheckedChanged);
            // 
            // rbTestigo
            // 
            this.rbTestigo.AutoSize = true;
            this.rbTestigo.Depth = 0;
            this.rbTestigo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbTestigo.Location = new System.Drawing.Point(338, 28);
            this.rbTestigo.Margin = new System.Windows.Forms.Padding(0);
            this.rbTestigo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbTestigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbTestigo.Name = "rbTestigo";
            this.rbTestigo.Ripple = true;
            this.rbTestigo.Size = new System.Drawing.Size(75, 30);
            this.rbTestigo.TabIndex = 16;
            this.rbTestigo.TabStop = true;
            this.rbTestigo.Text = "Testigo";
            this.rbTestigo.UseVisualStyleBackColor = true;
            this.rbTestigo.CheckedChanged += new System.EventHandler(this.rbDocumento_CheckedChanged);
            // 
            // frm1
            // 
            this.frm1.Controls.Add(this.frm2);
            this.frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm1.Location = new System.Drawing.Point(0, 0);
            this.frm1.Name = "frm1";
            this.frm1.Size = new System.Drawing.Size(491, 163);
            this.frm1.TabIndex = 17;
            // 
            // frm2
            // 
            this.frm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frm2.Controls.Add(this.rbDocumento);
            this.frm2.Controls.Add(this.rbTestigo);
            this.frm2.Controls.Add(this.btnRegistrar);
            this.frm2.Controls.Add(this.btnCerrar);
            this.frm2.Controls.Add(this.label3);
            this.frm2.Controls.Add(this.txtRequisicion);
            this.frm2.Controls.Add(this.lblReq);
            this.frm2.Location = new System.Drawing.Point(2, 2);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(487, 159);
            this.frm2.TabIndex = 0;
            // 
            // FRRRegistroDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 163);
            this.Controls.Add(this.frm1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRRRegistroDocumento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Requisición";
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).EndInit();
            this.frm1.ResumeLayout(false);
            this.frm2.ResumeLayout(false);
            this.frm2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnRegistrar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCerrar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRequisicion;
        private MaterialSkin.Controls.MaterialLabel lblReq;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialRadioButton rbDocumento;
        private MaterialSkin.Controls.MaterialRadioButton rbTestigo;
        private DevExpress.XtraEditors.PanelControl frm1;
        private System.Windows.Forms.Panel frm2;
    }
}