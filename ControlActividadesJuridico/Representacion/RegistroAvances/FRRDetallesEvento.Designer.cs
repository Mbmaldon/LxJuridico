namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    partial class FRRDetallesEvento
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.frm1 = new DevExpress.XtraEditors.PanelControl();
            this.frm2 = new System.Windows.Forms.Panel();
            this.dtpTerminoInterno = new MetroFramework.Controls.MetroDateTime();
            this.dtpTeminoLegal = new MetroFramework.Controls.MetroDateTime();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTarea = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEvento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTJuicio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContraparte = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtJuzgado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumExp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCerrar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).BeginInit();
            this.frm1.SuspendLayout();
            this.frm2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // listArchivos
            // 
            this.listArchivos.Location = new System.Drawing.Point(186, 433);
            this.listArchivos.Name = "listArchivos";
            this.listArchivos.Size = new System.Drawing.Size(332, 60);
            this.listArchivos.TabIndex = 30;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(186, 361);
            this.txtDescripcion.MaxLength = 4000;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(332, 67);
            this.txtDescripcion.TabIndex = 9;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
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
            this.frm1.Size = new System.Drawing.Size(572, 550);
            this.frm1.TabIndex = 42;
            // 
            // frm2
            // 
            this.frm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frm2.Controls.Add(this.separatorControl1);
            this.frm2.Controls.Add(this.materialLabel9);
            this.frm2.Controls.Add(this.materialLabel8);
            this.frm2.Controls.Add(this.materialLabel7);
            this.frm2.Controls.Add(this.materialLabel6);
            this.frm2.Controls.Add(this.materialLabel5);
            this.frm2.Controls.Add(this.materialLabel3);
            this.frm2.Controls.Add(this.materialLabel2);
            this.frm2.Controls.Add(this.materialLabel1);
            this.frm2.Controls.Add(this.dtpTerminoInterno);
            this.frm2.Controls.Add(this.dtpTeminoLegal);
            this.frm2.Controls.Add(this.txtTarea);
            this.frm2.Controls.Add(this.txtEvento);
            this.frm2.Controls.Add(this.txtTJuicio);
            this.frm2.Controls.Add(this.txtContraparte);
            this.frm2.Controls.Add(this.txtJuzgado);
            this.frm2.Controls.Add(this.label2);
            this.frm2.Controls.Add(this.txtNumExp);
            this.frm2.Controls.Add(this.btnCerrar);
            this.frm2.Controls.Add(this.listArchivos);
            this.frm2.Controls.Add(this.txtDescripcion);
            this.frm2.Location = new System.Drawing.Point(2, 2);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(568, 546);
            this.frm2.TabIndex = 0;
            // 
            // dtpTerminoInterno
            // 
            this.dtpTerminoInterno.Enabled = false;
            this.dtpTerminoInterno.Location = new System.Drawing.Point(186, 325);
            this.dtpTerminoInterno.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpTerminoInterno.Name = "dtpTerminoInterno";
            this.dtpTerminoInterno.Size = new System.Drawing.Size(331, 29);
            this.dtpTerminoInterno.Style = MetroFramework.MetroColorStyle.Green;
            this.dtpTerminoInterno.TabIndex = 131;
            // 
            // dtpTeminoLegal
            // 
            this.dtpTeminoLegal.Enabled = false;
            this.dtpTeminoLegal.Location = new System.Drawing.Point(186, 288);
            this.dtpTeminoLegal.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpTeminoLegal.Name = "dtpTeminoLegal";
            this.dtpTeminoLegal.Size = new System.Drawing.Size(331, 29);
            this.dtpTeminoLegal.Style = MetroFramework.MetroColorStyle.Green;
            this.dtpTeminoLegal.TabIndex = 131;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.Location = new System.Drawing.Point(38, 361);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(113, 38);
            this.materialLabel9.TabIndex = 140;
            this.materialLabel9.Text = "Descripción del\r\nEvento:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.Location = new System.Drawing.Point(37, 331);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(120, 19);
            this.materialLabel8.TabIndex = 139;
            this.materialLabel8.Text = "Término Interno:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.Location = new System.Drawing.Point(36, 294);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(109, 19);
            this.materialLabel7.TabIndex = 138;
            this.materialLabel7.Text = "Término Legal:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.Location = new System.Drawing.Point(37, 262);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(51, 19);
            this.materialLabel6.TabIndex = 137;
            this.materialLabel6.Text = "Tarea:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.Location = new System.Drawing.Point(37, 233);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(59, 19);
            this.materialLabel5.TabIndex = 136;
            this.materialLabel5.Text = "Evento:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.Location = new System.Drawing.Point(37, 123);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(108, 19);
            this.materialLabel3.TabIndex = 134;
            this.materialLabel3.Text = "Tipo de Juicio:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.Location = new System.Drawing.Point(37, 92);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 19);
            this.materialLabel2.TabIndex = 133;
            this.materialLabel2.Text = "Contraparte:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.Location = new System.Drawing.Point(37, 59);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(78, 19);
            this.materialLabel1.TabIndex = 132;
            this.materialLabel1.Text = "Autoridad:";
            // 
            // txtTarea
            // 
            this.txtTarea.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTarea.Depth = 0;
            this.txtTarea.Hint = "";
            this.txtTarea.Location = new System.Drawing.Point(186, 258);
            this.txtTarea.MaxLength = 32767;
            this.txtTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.PasswordChar = '\0';
            this.txtTarea.ReadOnly = true;
            this.txtTarea.SelectedText = "";
            this.txtTarea.SelectionLength = 0;
            this.txtTarea.SelectionStart = 0;
            this.txtTarea.Size = new System.Drawing.Size(332, 23);
            this.txtTarea.TabIndex = 49;
            this.txtTarea.TabStop = false;
            this.txtTarea.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTarea.UseSystemPasswordChar = false;
            // 
            // txtEvento
            // 
            this.txtEvento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEvento.Depth = 0;
            this.txtEvento.Hint = "";
            this.txtEvento.Location = new System.Drawing.Point(186, 229);
            this.txtEvento.MaxLength = 32767;
            this.txtEvento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.PasswordChar = '\0';
            this.txtEvento.ReadOnly = true;
            this.txtEvento.SelectedText = "";
            this.txtEvento.SelectionLength = 0;
            this.txtEvento.SelectionStart = 0;
            this.txtEvento.Size = new System.Drawing.Size(332, 23);
            this.txtEvento.TabIndex = 48;
            this.txtEvento.TabStop = false;
            this.txtEvento.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEvento.UseSystemPasswordChar = false;
            // 
            // txtTJuicio
            // 
            this.txtTJuicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTJuicio.Depth = 0;
            this.txtTJuicio.Hint = "";
            this.txtTJuicio.Location = new System.Drawing.Point(186, 119);
            this.txtTJuicio.MaxLength = 32767;
            this.txtTJuicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTJuicio.Name = "txtTJuicio";
            this.txtTJuicio.PasswordChar = '\0';
            this.txtTJuicio.ReadOnly = false;
            this.txtTJuicio.SelectedText = "";
            this.txtTJuicio.SelectionLength = 0;
            this.txtTJuicio.SelectionStart = 0;
            this.txtTJuicio.Size = new System.Drawing.Size(332, 23);
            this.txtTJuicio.TabIndex = 47;
            this.txtTJuicio.TabStop = false;
            this.txtTJuicio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTJuicio.UseSystemPasswordChar = false;
            // 
            // txtContraparte
            // 
            this.txtContraparte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContraparte.Depth = 0;
            this.txtContraparte.Hint = "";
            this.txtContraparte.Location = new System.Drawing.Point(186, 88);
            this.txtContraparte.MaxLength = 32767;
            this.txtContraparte.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContraparte.Name = "txtContraparte";
            this.txtContraparte.PasswordChar = '\0';
            this.txtContraparte.ReadOnly = true;
            this.txtContraparte.SelectedText = "";
            this.txtContraparte.SelectionLength = 0;
            this.txtContraparte.SelectionStart = 0;
            this.txtContraparte.Size = new System.Drawing.Size(332, 23);
            this.txtContraparte.TabIndex = 46;
            this.txtContraparte.TabStop = false;
            this.txtContraparte.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraparte.UseSystemPasswordChar = false;
            // 
            // txtJuzgado
            // 
            this.txtJuzgado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtJuzgado.Depth = 0;
            this.txtJuzgado.Hint = "";
            this.txtJuzgado.Location = new System.Drawing.Point(186, 55);
            this.txtJuzgado.MaxLength = 32767;
            this.txtJuzgado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtJuzgado.Name = "txtJuzgado";
            this.txtJuzgado.PasswordChar = '\0';
            this.txtJuzgado.ReadOnly = true;
            this.txtJuzgado.SelectedText = "";
            this.txtJuzgado.SelectionLength = 0;
            this.txtJuzgado.SelectionStart = 0;
            this.txtJuzgado.Size = new System.Drawing.Size(332, 23);
            this.txtJuzgado.TabIndex = 45;
            this.txtJuzgado.TabStop = false;
            this.txtJuzgado.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJuzgado.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.Location = new System.Drawing.Point(37, 28);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "No. Expediente:";
            // 
            // txtNumExp
            // 
            this.txtNumExp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumExp.Depth = 0;
            this.txtNumExp.Hint = "";
            this.txtNumExp.Location = new System.Drawing.Point(186, 24);
            this.txtNumExp.MaxLength = 32767;
            this.txtNumExp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumExp.Name = "txtNumExp";
            this.txtNumExp.PasswordChar = '\0';
            this.txtNumExp.ReadOnly = true;
            this.txtNumExp.SelectedText = "";
            this.txtNumExp.SelectionLength = 0;
            this.txtNumExp.SelectionStart = 0;
            this.txtNumExp.Size = new System.Drawing.Size(332, 23);
            this.txtNumExp.TabIndex = 43;
            this.txtNumExp.TabStop = false;
            this.txtNumExp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumExp.UseSystemPasswordChar = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BGColor = "#B71C1C";
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Depth = 0;
            this.btnCerrar.Icon = null;
            this.btnCerrar.Location = new System.Drawing.Point(412, 513);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Primary = true;
            this.btnCerrar.Size = new System.Drawing.Size(106, 23);
            this.btnCerrar.TabIndex = 42;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(3, 183);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(562, 23);
            this.separatorControl1.TabIndex = 141;
            // 
            // FRRDetallesEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 550);
            this.Controls.Add(this.frm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRRDetallesEvento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRRDetallesEvento";
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).EndInit();
            this.frm1.ResumeLayout(false);
            this.frm2.ResumeLayout(false);
            this.frm2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel listArchivos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private DevExpress.XtraEditors.PanelControl frm1;
        private System.Windows.Forms.Panel frm2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumExp;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCerrar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTarea;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEvento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTJuicio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContraparte;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtJuzgado;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MetroFramework.Controls.MetroDateTime dtpTerminoInterno;
        private MetroFramework.Controls.MetroDateTime dtpTeminoLegal;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}