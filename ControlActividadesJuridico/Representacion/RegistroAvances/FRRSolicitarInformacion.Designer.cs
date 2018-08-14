namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    partial class FRRSolicitarInformacion
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
            this.txtSolicitud = new System.Windows.Forms.TextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.dtpFechaEntrega = new MetroFramework.Controls.MetroDateTime();
            this.dtpHoraEntrega = new DevExpress.XtraEditors.TimeEdit();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbResponsable = new MaterialSkin.Controls.MaterialComboBox();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.frm1 = new DevExpress.XtraEditors.PanelControl();
            this.frm2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHoraEntrega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).BeginInit();
            this.frm1.SuspendLayout();
            this.frm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSolicitud
            // 
            this.txtSolicitud.Location = new System.Drawing.Point(236, 22);
            this.txtSolicitud.MaxLength = 4000;
            this.txtSolicitud.Multiline = true;
            this.txtSolicitud.Name = "txtSolicitud";
            this.txtSolicitud.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSolicitud.Size = new System.Drawing.Size(367, 96);
            this.txtSolicitud.TabIndex = 3;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(236, 173);
            this.dtpFechaEntrega.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(162, 29);
            this.dtpFechaEntrega.Style = MetroFramework.MetroColorStyle.Green;
            this.dtpFechaEntrega.TabIndex = 130;
            // 
            // dtpHoraEntrega
            // 
            this.dtpHoraEntrega.EditValue = new System.DateTime(2017, 12, 4, 0, 0, 0, 0);
            this.dtpHoraEntrega.Location = new System.Drawing.Point(236, 212);
            this.dtpHoraEntrega.Name = "dtpHoraEntrega";
            this.dtpHoraEntrega.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dtpHoraEntrega.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.dtpHoraEntrega.Properties.Appearance.Options.UseFont = true;
            this.dtpHoraEntrega.Properties.Appearance.Options.UseForeColor = true;
            this.dtpHoraEntrega.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dtpHoraEntrega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpHoraEntrega.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dtpHoraEntrega.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.dtpHoraEntrega.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dtpHoraEntrega.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.dtpHoraEntrega.Size = new System.Drawing.Size(163, 26);
            this.dtpHoraEntrega.TabIndex = 132;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.Location = new System.Drawing.Point(32, 219);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "Hora de Entrega:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.Location = new System.Drawing.Point(32, 179);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Fecha de Entrega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Descripción de Solicitud:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Responsable de la Solicitud:";
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.DataSource = null;
            this.cmbResponsable.Depth = 0;
            this.cmbResponsable.DisplayMember = "";
            this.cmbResponsable.DropDownWidth = 367;
            this.cmbResponsable.Hint = "";
            this.cmbResponsable.Location = new System.Drawing.Point(236, 133);
            this.cmbResponsable.MaxLength = 0;
            this.cmbResponsable.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.PasswordChar = '\0';
            this.cmbResponsable.SelectedIndex = -1;
            this.cmbResponsable.SelectedItem = null;
            this.cmbResponsable.SelectedText = "";
            this.cmbResponsable.SelectedValue = null;
            this.cmbResponsable.Size = new System.Drawing.Size(367, 29);
            this.cmbResponsable.TabIndex = 40;
            this.cmbResponsable.TabStop = false;
            this.cmbResponsable.UseSystemPasswordChar = false;
            this.cmbResponsable.ValueMember = "";
            this.cmbResponsable.Visible = false;
            this.cmbResponsable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbResponsable_KeyPress);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BGColor = "#3F51B5";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.Icon = null;
            this.btnRegistrar.Location = new System.Drawing.Point(376, 283);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Primary = true;
            this.btnRegistrar.Size = new System.Drawing.Size(131, 23);
            this.btnRegistrar.TabIndex = 39;
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
            this.btnCancelar.Location = new System.Drawing.Point(513, 283);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frm1
            // 
            this.frm1.Controls.Add(this.frm2);
            this.frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm1.Location = new System.Drawing.Point(0, 0);
            this.frm1.Name = "frm1";
            this.frm1.Size = new System.Drawing.Size(643, 328);
            this.frm1.TabIndex = 133;
            // 
            // frm2
            // 
            this.frm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frm2.Controls.Add(this.label1);
            this.frm2.Controls.Add(this.dtpHoraEntrega);
            this.frm2.Controls.Add(this.txtSolicitud);
            this.frm2.Controls.Add(this.label4);
            this.frm2.Controls.Add(this.btnCancelar);
            this.frm2.Controls.Add(this.label3);
            this.frm2.Controls.Add(this.btnRegistrar);
            this.frm2.Controls.Add(this.dtpFechaEntrega);
            this.frm2.Controls.Add(this.label2);
            this.frm2.Controls.Add(this.cmbResponsable);
            this.frm2.Location = new System.Drawing.Point(2, 2);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(639, 324);
            this.frm2.TabIndex = 0;
            // 
            // FRRSolicitarInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 328);
            this.Controls.Add(this.frm1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRRSolicitarInformacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitar Informacion";
            ((System.ComponentModel.ISupportInitialize)(this.dtpHoraEntrega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).EndInit();
            this.frm1.ResumeLayout(false);
            this.frm2.ResumeLayout(false);
            this.frm2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSolicitud;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnRegistrar;
        private MaterialSkin.Controls.MaterialComboBox cmbResponsable;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MetroFramework.Controls.MetroDateTime dtpFechaEntrega;
        private DevExpress.XtraEditors.TimeEdit dtpHoraEntrega;
        private DevExpress.XtraEditors.PanelControl frm1;
        private System.Windows.Forms.Panel frm2;
    }
}