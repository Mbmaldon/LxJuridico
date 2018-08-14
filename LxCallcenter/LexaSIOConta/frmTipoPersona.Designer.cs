namespace LxCallcenter.LexaSIOConta
{
    partial class frmTipoPersona
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaltarAsignacion = new LollipopFlatButton();
            this.btnPMoral = new LollipopFlatButton();
            this.btnPFisica = new LollipopFlatButton();
            this.lollipopCard2 = new LollipopCard();
            this.lollipopCard1 = new LollipopCard();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 79;
            this.label1.Text = "Tipo de Persona";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoEllipsis = true;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(28, 43);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(358, 22);
            this.lblFecha.TabIndex = 239;
            this.lblFecha.Text = "Seleccione el tipo de persona que será el cliente.";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelControl1.Controls.Add(this.panel3);
            this.panelControl1.Location = new System.Drawing.Point(31, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1177, 613);
            this.panelControl1.TabIndex = 241;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.btnSaltarAsignacion);
            this.panel3.Controls.Add(this.lblFecha);
            this.panel3.Controls.Add(this.btnPMoral);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnPFisica);
            this.panel3.Controls.Add(this.lollipopCard2);
            this.panel3.Controls.Add(this.lollipopCard1);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1173, 609);
            this.panel3.TabIndex = 242;
            // 
            // btnSaltarAsignacion
            // 
            this.btnSaltarAsignacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaltarAsignacion.BackColor = System.Drawing.Color.Transparent;
            this.btnSaltarAsignacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaltarAsignacion.FontColor = "#D50000";
            this.btnSaltarAsignacion.Location = new System.Drawing.Point(525, 520);
            this.btnSaltarAsignacion.Name = "btnSaltarAsignacion";
            this.btnSaltarAsignacion.Size = new System.Drawing.Size(127, 23);
            this.btnSaltarAsignacion.TabIndex = 4;
            this.btnSaltarAsignacion.Text = "Saltar Asignación";
            this.btnSaltarAsignacion.Visible = false;
            this.btnSaltarAsignacion.Click += new System.EventHandler(this.btnSaltarAsignacion_Click);
            // 
            // btnPMoral
            // 
            this.btnPMoral.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPMoral.BackColor = System.Drawing.Color.Transparent;
            this.btnPMoral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPMoral.FontColor = "#508ef5";
            this.btnPMoral.Location = new System.Drawing.Point(810, 379);
            this.btnPMoral.Name = "btnPMoral";
            this.btnPMoral.Size = new System.Drawing.Size(76, 30);
            this.btnPMoral.TabIndex = 3;
            this.btnPMoral.Text = "Aceptar";
            this.btnPMoral.Click += new System.EventHandler(this.btnPMoral_Click);
            // 
            // btnPFisica
            // 
            this.btnPFisica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPFisica.BackColor = System.Drawing.Color.Transparent;
            this.btnPFisica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPFisica.FontColor = "#508ef5";
            this.btnPFisica.Location = new System.Drawing.Point(464, 379);
            this.btnPFisica.Name = "btnPFisica";
            this.btnPFisica.Size = new System.Drawing.Size(76, 30);
            this.btnPFisica.TabIndex = 1;
            this.btnPFisica.Text = "Aceptar";
            this.btnPFisica.Click += new System.EventHandler(this.btnPFisica_Click);
            // 
            // lollipopCard2
            // 
            this.lollipopCard2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lollipopCard2.ButtonColor = "#33b679";
            this.lollipopCard2.ContentColor = "#444444";
            this.lollipopCard2.ContentText = "Asigne el tipo de persona moral al cliente.";
            this.lollipopCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.lollipopCard2.Image = global::LxCallcenter.Properties.Resources.p_morales;
            this.lollipopCard2.Location = new System.Drawing.Point(610, 128);
            this.lollipopCard2.Name = "lollipopCard2";
            this.lollipopCard2.Size = new System.Drawing.Size(294, 298);
            this.lollipopCard2.TabIndex = 2;
            this.lollipopCard2.Text = "Persona Moral";
            this.lollipopCard2.TitleColor = "#3F51B5";
            // 
            // lollipopCard1
            // 
            this.lollipopCard1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lollipopCard1.ButtonColor = "#33b679";
            this.lollipopCard1.ContentColor = "#444444";
            this.lollipopCard1.ContentText = "Asigne el tipo de persona física al cliente.";
            this.lollipopCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.lollipopCard1.Image = global::LxCallcenter.Properties.Resources.p_fisicas;
            this.lollipopCard1.Location = new System.Drawing.Point(264, 128);
            this.lollipopCard1.Name = "lollipopCard1";
            this.lollipopCard1.Size = new System.Drawing.Size(294, 298);
            this.lollipopCard1.TabIndex = 0;
            this.lollipopCard1.Text = "Persona Física";
            this.lollipopCard1.TitleColor = "#3F51B5";
            // 
            // frmTipoPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1229, 648);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmTipoPersona";
            this.Text = "Tipo Persona";
            this.Load += new System.EventHandler(this.frmTipoPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private LollipopCard lollipopCard1;
        private LollipopFlatButton btnPFisica;
        private System.Windows.Forms.Label lblFecha;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.Panel panel3;
        private LollipopFlatButton btnPMoral;
        private LollipopCard lollipopCard2;
        private LollipopFlatButton btnSaltarAsignacion;
    }
}