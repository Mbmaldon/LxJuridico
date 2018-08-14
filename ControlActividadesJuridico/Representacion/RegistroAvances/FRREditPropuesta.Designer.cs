namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    partial class FRREditPropuesta
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
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.txtPropuesta = new System.Windows.Forms.TextBox();
            this.openFileDialogDocumento = new System.Windows.Forms.OpenFileDialog();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.frm1 = new DevExpress.XtraEditors.PanelControl();
            this.frm2 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnCerrar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnAdjuntar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).BeginInit();
            this.frm1.SuspendLayout();
            this.frm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listArchivos
            // 
            this.listArchivos.AutoScroll = true;
            this.listArchivos.Location = new System.Drawing.Point(129, 197);
            this.listArchivos.Name = "listArchivos";
            this.listArchivos.Size = new System.Drawing.Size(368, 60);
            this.listArchivos.TabIndex = 30;
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.BackColor = System.Drawing.Color.White;
            this.txtRutaArchivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRutaArchivo.Enabled = false;
            this.txtRutaArchivo.Location = new System.Drawing.Point(129, 172);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(276, 14);
            this.txtRutaArchivo.TabIndex = 6;
            // 
            // txtPropuesta
            // 
            this.txtPropuesta.Location = new System.Drawing.Point(36, 47);
            this.txtPropuesta.MaxLength = 4000;
            this.txtPropuesta.Multiline = true;
            this.txtPropuesta.Name = "txtPropuesta";
            this.txtPropuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPropuesta.Size = new System.Drawing.Size(461, 115);
            this.txtPropuesta.TabIndex = 2;
            this.txtPropuesta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPropuesta_KeyPress);
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
            this.frm1.Size = new System.Drawing.Size(541, 323);
            this.frm1.TabIndex = 31;
            // 
            // frm2
            // 
            this.frm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frm2.Controls.Add(this.label1);
            this.frm2.Controls.Add(this.btnAdjuntar);
            this.frm2.Controls.Add(this.btnCerrar);
            this.frm2.Controls.Add(this.btnRegistrar);
            this.frm2.Controls.Add(this.txtPropuesta);
            this.frm2.Controls.Add(this.listArchivos);
            this.frm2.Controls.Add(this.txtRutaArchivo);
            this.frm2.Location = new System.Drawing.Point(2, 2);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(537, 319);
            this.frm2.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BGColor = "#3F51B5";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.Icon = null;
            this.btnRegistrar.Location = new System.Drawing.Point(308, 275);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Primary = true;
            this.btnRegistrar.Size = new System.Drawing.Size(108, 23);
            this.btnRegistrar.TabIndex = 31;
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
            this.btnCerrar.Location = new System.Drawing.Point(422, 275);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Primary = true;
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 32;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.BGColor = "#508ef5";
            this.btnAdjuntar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjuntar.Depth = 0;
            this.btnAdjuntar.Icon = null;
            this.btnAdjuntar.Location = new System.Drawing.Point(36, 167);
            this.btnAdjuntar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Primary = true;
            this.btnAdjuntar.Size = new System.Drawing.Size(75, 23);
            this.btnAdjuntar.TabIndex = 33;
            this.btnAdjuntar.Text = "Adjuntar";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Describir propuesta:";
            // 
            // FRREditPropuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 323);
            this.Controls.Add(this.frm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRREditPropuesta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRREditPropuesta";
            this.Load += new System.EventHandler(this.FRREditPropuesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).EndInit();
            this.frm1.ResumeLayout(false);
            this.frm2.ResumeLayout(false);
            this.frm2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPropuesta;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialogDocumento;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Panel listArchivos;
        private DevExpress.XtraEditors.PanelControl frm1;
        private System.Windows.Forms.Panel frm2;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnAdjuntar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCerrar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnRegistrar;
        private MaterialSkin.Controls.MaterialLabel label1;
    }
}