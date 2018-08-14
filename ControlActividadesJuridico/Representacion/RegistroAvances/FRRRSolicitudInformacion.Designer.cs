namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    partial class FRRRSolicitudInformacion
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
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.txtSolicitud = new System.Windows.Forms.TextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.btnCerrar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.txtResponsable = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFechaEntrega = new MaterialSkin.Controls.MaterialLabel();
            this.lblVigencia = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.frm1 = new DevExpress.XtraEditors.PanelControl();
            this.frm2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).BeginInit();
            this.frm1.SuspendLayout();
            this.frm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(239, 224);
            this.txtRespuesta.MaxLength = 4000;
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuesta.Size = new System.Drawing.Size(356, 75);
            this.txtRespuesta.TabIndex = 10;
            this.txtRespuesta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bloqueoInsercion_KeyPress);
            // 
            // txtSolicitud
            // 
            this.txtSolicitud.Location = new System.Drawing.Point(239, 33);
            this.txtSolicitud.MaxLength = 4000;
            this.txtSolicitud.Multiline = true;
            this.txtSolicitud.Name = "txtSolicitud";
            this.txtSolicitud.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSolicitud.Size = new System.Drawing.Size(356, 96);
            this.txtSolicitud.TabIndex = 3;
            this.txtSolicitud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bloqueoInsercion_KeyPress);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BGColor = "#B71C1C";
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Depth = 0;
            this.btnCerrar.Icon = null;
            this.btnCerrar.Location = new System.Drawing.Point(495, 386);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Primary = true;
            this.btnCerrar.Size = new System.Drawing.Size(100, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtResponsable
            // 
            this.txtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtResponsable.Depth = 0;
            this.txtResponsable.Hint = "";
            this.txtResponsable.Location = new System.Drawing.Point(239, 141);
            this.txtResponsable.MaxLength = 32767;
            this.txtResponsable.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.PasswordChar = '\0';
            this.txtResponsable.ReadOnly = true;
            this.txtResponsable.SelectedText = "";
            this.txtResponsable.SelectionLength = 0;
            this.txtResponsable.SelectionStart = 0;
            this.txtResponsable.Size = new System.Drawing.Size(356, 23);
            this.txtResponsable.TabIndex = 15;
            this.txtResponsable.TabStop = false;
            this.txtResponsable.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtResponsable.UseSystemPasswordChar = false;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Depth = 0;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaEntrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaEntrega.Location = new System.Drawing.Point(235, 348);
            this.lblFechaEntrega.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(108, 19);
            this.lblFechaEntrega.TabIndex = 16;
            this.lblFechaEntrega.Text = "materialLabel1";
            // 
            // lblVigencia
            // 
            this.lblVigencia.AutoSize = true;
            this.lblVigencia.Depth = 0;
            this.lblVigencia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblVigencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVigencia.Location = new System.Drawing.Point(235, 183);
            this.lblVigencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVigencia.Name = "lblVigencia";
            this.lblVigencia.Size = new System.Drawing.Size(108, 19);
            this.lblVigencia.TabIndex = 17;
            this.lblVigencia.Text = "materialLabel1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(35, 33);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(176, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Descripción de Solicitud:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(35, 145);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(198, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Responsable de la Solicitud:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(35, 183);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(135, 19);
            this.materialLabel3.TabIndex = 20;
            this.materialLabel3.Text = "Fecha de Vigencia:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(35, 224);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(112, 19);
            this.materialLabel4.TabIndex = 21;
            this.materialLabel4.Text = "Observaciones:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(35, 348);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(147, 19);
            this.materialLabel5.TabIndex = 22;
            this.materialLabel5.Text = "Fecha de Respuesta:";
            // 
            // frm1
            // 
            this.frm1.Controls.Add(this.frm2);
            this.frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm1.Location = new System.Drawing.Point(0, 0);
            this.frm1.Name = "frm1";
            this.frm1.Size = new System.Drawing.Size(630, 433);
            this.frm1.TabIndex = 23;
            // 
            // frm2
            // 
            this.frm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frm2.Controls.Add(this.materialLabel5);
            this.frm2.Controls.Add(this.materialLabel1);
            this.frm2.Controls.Add(this.btnCerrar);
            this.frm2.Controls.Add(this.lblFechaEntrega);
            this.frm2.Controls.Add(this.materialLabel4);
            this.frm2.Controls.Add(this.txtResponsable);
            this.frm2.Controls.Add(this.materialLabel3);
            this.frm2.Controls.Add(this.lblVigencia);
            this.frm2.Controls.Add(this.txtRespuesta);
            this.frm2.Controls.Add(this.materialLabel2);
            this.frm2.Controls.Add(this.txtSolicitud);
            this.frm2.Location = new System.Drawing.Point(2, 2);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(626, 429);
            this.frm2.TabIndex = 0;
            // 
            // FRRRSolicitudInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 433);
            this.Controls.Add(this.frm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRRRSolicitudInformacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRRRSolicitudInformacion";
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).EndInit();
            this.frm1.ResumeLayout(false);
            this.frm2.ResumeLayout(false);
            this.frm2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSolicitud;
        private System.Windows.Forms.TextBox txtRespuesta;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCerrar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtResponsable;
        private MaterialSkin.Controls.MaterialLabel lblFechaEntrega;
        private MaterialSkin.Controls.MaterialLabel lblVigencia;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private DevExpress.XtraEditors.PanelControl frm1;
        private System.Windows.Forms.Panel frm2;
    }
}