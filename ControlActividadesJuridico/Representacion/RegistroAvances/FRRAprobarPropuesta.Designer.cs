namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    partial class FRRAprobarPropuesta
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
            this.listArchivos = new System.Windows.Forms.Panel();
            this.txtPropuesta = new System.Windows.Forms.TextBox();
            this.txtMotivoRechazo = new System.Windows.Forms.TextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.frm1 = new DevExpress.XtraEditors.PanelControl();
            this.frm2 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.rbSI = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbNO = new MaterialSkin.Controls.MaterialRadioButton();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).BeginInit();
            this.frm1.SuspendLayout();
            this.frm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listArchivos
            // 
            this.listArchivos.AutoScroll = true;
            this.listArchivos.Location = new System.Drawing.Point(39, 123);
            this.listArchivos.Name = "listArchivos";
            this.listArchivos.Size = new System.Drawing.Size(439, 62);
            this.listArchivos.TabIndex = 31;
            // 
            // txtPropuesta
            // 
            this.txtPropuesta.BackColor = System.Drawing.Color.White;
            this.txtPropuesta.Location = new System.Drawing.Point(39, 54);
            this.txtPropuesta.MaxLength = 4000;
            this.txtPropuesta.Multiline = true;
            this.txtPropuesta.Name = "txtPropuesta";
            this.txtPropuesta.ReadOnly = true;
            this.txtPropuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPropuesta.Size = new System.Drawing.Size(439, 54);
            this.txtPropuesta.TabIndex = 9;
            // 
            // txtMotivoRechazo
            // 
            this.txtMotivoRechazo.Location = new System.Drawing.Point(39, 275);
            this.txtMotivoRechazo.MaxLength = 4000;
            this.txtMotivoRechazo.Multiline = true;
            this.txtMotivoRechazo.Name = "txtMotivoRechazo";
            this.txtMotivoRechazo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivoRechazo.Size = new System.Drawing.Size(439, 61);
            this.txtMotivoRechazo.TabIndex = 8;
            this.txtMotivoRechazo.Visible = false;
            this.txtMotivoRechazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotivoRechazo_KeyPress);
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
            this.frm1.Size = new System.Drawing.Size(518, 404);
            this.frm1.TabIndex = 32;
            // 
            // frm2
            // 
            this.frm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frm2.Controls.Add(this.label1);
            this.frm2.Controls.Add(this.label4);
            this.frm2.Controls.Add(this.label3);
            this.frm2.Controls.Add(this.rbNO);
            this.frm2.Controls.Add(this.rbSI);
            this.frm2.Controls.Add(this.btnCancelar);
            this.frm2.Controls.Add(this.btnRegistrar);
            this.frm2.Controls.Add(this.txtPropuesta);
            this.frm2.Controls.Add(this.listArchivos);
            this.frm2.Controls.Add(this.txtMotivoRechazo);
            this.frm2.Location = new System.Drawing.Point(2, 2);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(514, 400);
            this.frm2.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BGColor = "#3F51B5";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.Icon = null;
            this.btnRegistrar.Location = new System.Drawing.Point(306, 358);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Primary = true;
            this.btnRegistrar.Size = new System.Drawing.Size(91, 23);
            this.btnRegistrar.TabIndex = 32;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Visible = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BGColor = "#B71C1C";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(403, 358);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rbSI
            // 
            this.rbSI.AutoSize = true;
            this.rbSI.Depth = 0;
            this.rbSI.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbSI.Location = new System.Drawing.Point(272, 207);
            this.rbSI.Margin = new System.Windows.Forms.Padding(0);
            this.rbSI.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbSI.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbSI.Name = "rbSI";
            this.rbSI.Ripple = true;
            this.rbSI.Size = new System.Drawing.Size(41, 30);
            this.rbSI.TabIndex = 34;
            this.rbSI.TabStop = true;
            this.rbSI.Text = "Si";
            this.rbSI.UseVisualStyleBackColor = true;
            this.rbSI.CheckedChanged += new System.EventHandler(this.Check_CheckedChanged);
            // 
            // rbNO
            // 
            this.rbNO.AutoSize = true;
            this.rbNO.Depth = 0;
            this.rbNO.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbNO.Location = new System.Drawing.Point(340, 207);
            this.rbNO.Margin = new System.Windows.Forms.Padding(0);
            this.rbNO.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbNO.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbNO.Name = "rbNO";
            this.rbNO.Ripple = true;
            this.rbNO.Size = new System.Drawing.Size(47, 30);
            this.rbNO.TabIndex = 35;
            this.rbNO.TabStop = true;
            this.rbNO.Text = "No";
            this.rbNO.UseVisualStyleBackColor = true;
            this.rbNO.CheckedChanged += new System.EventHandler(this.Check_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.Location = new System.Drawing.Point(35, 207);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 38);
            this.label3.TabIndex = 36;
            this.label3.Text = "La Propuesta de Respuesta \r\nes Aprobada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.Location = new System.Drawing.Point(35, 253);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Motivo de Rechazo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Propuesta de Respuesta:";
            // 
            // FRRAprobarPropuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 404);
            this.Controls.Add(this.frm1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRRAprobarPropuesta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprobar Propuesta";
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).EndInit();
            this.frm1.ResumeLayout(false);
            this.frm2.ResumeLayout(false);
            this.frm2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMotivoRechazo;
        private System.Windows.Forms.TextBox txtPropuesta;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Panel listArchivos;
        private DevExpress.XtraEditors.PanelControl frm1;
        private System.Windows.Forms.Panel frm2;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnRegistrar;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialRadioButton rbNO;
        private MaterialSkin.Controls.MaterialRadioButton rbSI;
    }
}