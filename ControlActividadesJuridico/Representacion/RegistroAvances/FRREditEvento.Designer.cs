namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    partial class FRREditEvento
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
            this.listArchivos = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.openFileDialogDocumento = new System.Windows.Forms.OpenFileDialog();
            this.frm1 = new DevExpress.XtraEditors.PanelControl();
            this.frm2 = new System.Windows.Forms.Panel();
            this.dtpTerminoInterno = new MetroFramework.Controls.MetroDateTime();
            this.dtpTeminoLegal = new MetroFramework.Controls.MetroDateTime();
            this.txtTarea = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEvento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTJuicio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContraparte = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtJuzgado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumExp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCargarArchivo = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.cbhActivarCampos = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).BeginInit();
            this.frm1.SuspendLayout();
            this.frm2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.BackColor = System.Drawing.Color.White;
            this.txtRutaArchivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRutaArchivo.Enabled = false;
            this.txtRutaArchivo.Location = new System.Drawing.Point(195, 464);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(270, 14);
            this.txtRutaArchivo.TabIndex = 35;
            // 
            // listArchivos
            // 
            this.listArchivos.Location = new System.Drawing.Point(195, 487);
            this.listArchivos.Name = "listArchivos";
            this.listArchivos.Size = new System.Drawing.Size(332, 60);
            this.listArchivos.TabIndex = 30;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(195, 388);
            this.txtDescripcion.MaxLength = 4000;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(332, 64);
            this.txtDescripcion.TabIndex = 9;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // openFileDialogDocumento
            // 
            this.openFileDialogDocumento.FileName = "openFileDialog1";
            this.openFileDialogDocumento.Multiselect = true;
            // 
            // frm1
            // 
            this.frm1.Controls.Add(this.frm2);
            this.frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm1.Location = new System.Drawing.Point(0, 0);
            this.frm1.Name = "frm1";
            this.frm1.Size = new System.Drawing.Size(576, 614);
            this.frm1.TabIndex = 40;
            // 
            // frm2
            // 
            this.frm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frm2.Controls.Add(this.separatorControl1);
            this.frm2.Controls.Add(this.dtpTerminoInterno);
            this.frm2.Controls.Add(this.dtpTeminoLegal);
            this.frm2.Controls.Add(this.txtTarea);
            this.frm2.Controls.Add(this.txtEvento);
            this.frm2.Controls.Add(this.txtTJuicio);
            this.frm2.Controls.Add(this.txtContraparte);
            this.frm2.Controls.Add(this.txtJuzgado);
            this.frm2.Controls.Add(this.txtNumExp);
            this.frm2.Controls.Add(this.materialLabel9);
            this.frm2.Controls.Add(this.materialLabel8);
            this.frm2.Controls.Add(this.materialLabel7);
            this.frm2.Controls.Add(this.materialLabel6);
            this.frm2.Controls.Add(this.materialLabel5);
            this.frm2.Controls.Add(this.materialLabel3);
            this.frm2.Controls.Add(this.materialLabel2);
            this.frm2.Controls.Add(this.materialLabel1);
            this.frm2.Controls.Add(this.label2);
            this.frm2.Controls.Add(this.btnCargarArchivo);
            this.frm2.Controls.Add(this.cbhActivarCampos);
            this.frm2.Controls.Add(this.btnCancelar);
            this.frm2.Controls.Add(this.btnActualizar);
            this.frm2.Controls.Add(this.txtRutaArchivo);
            this.frm2.Controls.Add(this.txtDescripcion);
            this.frm2.Controls.Add(this.listArchivos);
            this.frm2.Location = new System.Drawing.Point(2, 2);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(572, 610);
            this.frm2.TabIndex = 0;
            // 
            // dtpTerminoInterno
            // 
            this.dtpTerminoInterno.Enabled = false;
            this.dtpTerminoInterno.Location = new System.Drawing.Point(195, 352);
            this.dtpTerminoInterno.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpTerminoInterno.Name = "dtpTerminoInterno";
            this.dtpTerminoInterno.Size = new System.Drawing.Size(331, 29);
            this.dtpTerminoInterno.Style = MetroFramework.MetroColorStyle.Green;
            this.dtpTerminoInterno.TabIndex = 158;
            // 
            // dtpTeminoLegal
            // 
            this.dtpTeminoLegal.Enabled = false;
            this.dtpTeminoLegal.Location = new System.Drawing.Point(195, 315);
            this.dtpTeminoLegal.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpTeminoLegal.Name = "dtpTeminoLegal";
            this.dtpTeminoLegal.Size = new System.Drawing.Size(331, 29);
            this.dtpTeminoLegal.Style = MetroFramework.MetroColorStyle.Green;
            this.dtpTeminoLegal.TabIndex = 157;
            // 
            // txtTarea
            // 
            this.txtTarea.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTarea.Depth = 0;
            this.txtTarea.Enabled = false;
            this.txtTarea.Hint = "";
            this.txtTarea.Location = new System.Drawing.Point(195, 285);
            this.txtTarea.MaxLength = 32767;
            this.txtTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.PasswordChar = '\0';
            this.txtTarea.ReadOnly = false;
            this.txtTarea.SelectedText = "";
            this.txtTarea.SelectionLength = 0;
            this.txtTarea.SelectionStart = 0;
            this.txtTarea.Size = new System.Drawing.Size(332, 23);
            this.txtTarea.TabIndex = 156;
            this.txtTarea.TabStop = false;
            this.txtTarea.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTarea.UseSystemPasswordChar = false;
            // 
            // txtEvento
            // 
            this.txtEvento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEvento.Depth = 0;
            this.txtEvento.Enabled = false;
            this.txtEvento.Hint = "";
            this.txtEvento.Location = new System.Drawing.Point(195, 256);
            this.txtEvento.MaxLength = 32767;
            this.txtEvento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.PasswordChar = '\0';
            this.txtEvento.ReadOnly = false;
            this.txtEvento.SelectedText = "";
            this.txtEvento.SelectionLength = 0;
            this.txtEvento.SelectionStart = 0;
            this.txtEvento.Size = new System.Drawing.Size(332, 23);
            this.txtEvento.TabIndex = 155;
            this.txtEvento.TabStop = false;
            this.txtEvento.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEvento.UseSystemPasswordChar = false;
            // 
            // txtTJuicio
            // 
            this.txtTJuicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTJuicio.Depth = 0;
            this.txtTJuicio.Enabled = false;
            this.txtTJuicio.Hint = "";
            this.txtTJuicio.Location = new System.Drawing.Point(195, 143);
            this.txtTJuicio.MaxLength = 32767;
            this.txtTJuicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTJuicio.Name = "txtTJuicio";
            this.txtTJuicio.PasswordChar = '\0';
            this.txtTJuicio.ReadOnly = true;
            this.txtTJuicio.SelectedText = "";
            this.txtTJuicio.SelectionLength = 0;
            this.txtTJuicio.SelectionStart = 0;
            this.txtTJuicio.Size = new System.Drawing.Size(332, 23);
            this.txtTJuicio.TabIndex = 154;
            this.txtTJuicio.TabStop = false;
            this.txtTJuicio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTJuicio.UseSystemPasswordChar = false;
            // 
            // txtContraparte
            // 
            this.txtContraparte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContraparte.Depth = 0;
            this.txtContraparte.Enabled = false;
            this.txtContraparte.Hint = "";
            this.txtContraparte.Location = new System.Drawing.Point(195, 112);
            this.txtContraparte.MaxLength = 32767;
            this.txtContraparte.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContraparte.Name = "txtContraparte";
            this.txtContraparte.PasswordChar = '\0';
            this.txtContraparte.ReadOnly = false;
            this.txtContraparte.SelectedText = "";
            this.txtContraparte.SelectionLength = 0;
            this.txtContraparte.SelectionStart = 0;
            this.txtContraparte.Size = new System.Drawing.Size(332, 23);
            this.txtContraparte.TabIndex = 153;
            this.txtContraparte.TabStop = false;
            this.txtContraparte.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraparte.UseSystemPasswordChar = false;
            // 
            // txtJuzgado
            // 
            this.txtJuzgado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtJuzgado.Depth = 0;
            this.txtJuzgado.Enabled = false;
            this.txtJuzgado.Hint = "";
            this.txtJuzgado.Location = new System.Drawing.Point(195, 82);
            this.txtJuzgado.MaxLength = 32767;
            this.txtJuzgado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtJuzgado.Name = "txtJuzgado";
            this.txtJuzgado.PasswordChar = '\0';
            this.txtJuzgado.ReadOnly = false;
            this.txtJuzgado.SelectedText = "";
            this.txtJuzgado.SelectionLength = 0;
            this.txtJuzgado.SelectionStart = 0;
            this.txtJuzgado.Size = new System.Drawing.Size(332, 23);
            this.txtJuzgado.TabIndex = 152;
            this.txtJuzgado.TabStop = false;
            this.txtJuzgado.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJuzgado.UseSystemPasswordChar = false;
            // 
            // txtNumExp
            // 
            this.txtNumExp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumExp.Depth = 0;
            this.txtNumExp.Enabled = false;
            this.txtNumExp.Hint = "";
            this.txtNumExp.Location = new System.Drawing.Point(195, 51);
            this.txtNumExp.MaxLength = 32767;
            this.txtNumExp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumExp.Name = "txtNumExp";
            this.txtNumExp.PasswordChar = '\0';
            this.txtNumExp.ReadOnly = false;
            this.txtNumExp.SelectedText = "";
            this.txtNumExp.SelectionLength = 0;
            this.txtNumExp.SelectionStart = 0;
            this.txtNumExp.Size = new System.Drawing.Size(332, 23);
            this.txtNumExp.TabIndex = 151;
            this.txtNumExp.TabStop = false;
            this.txtNumExp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumExp.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.Location = new System.Drawing.Point(27, 388);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(113, 38);
            this.materialLabel9.TabIndex = 150;
            this.materialLabel9.Text = "Descripción del\r\nEvento:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.Location = new System.Drawing.Point(26, 358);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(120, 19);
            this.materialLabel8.TabIndex = 149;
            this.materialLabel8.Text = "Término Interno:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.Location = new System.Drawing.Point(25, 321);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(109, 19);
            this.materialLabel7.TabIndex = 148;
            this.materialLabel7.Text = "Término Legal:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.Location = new System.Drawing.Point(26, 289);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(51, 19);
            this.materialLabel6.TabIndex = 147;
            this.materialLabel6.Text = "Tarea:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.Location = new System.Drawing.Point(26, 260);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(59, 19);
            this.materialLabel5.TabIndex = 146;
            this.materialLabel5.Text = "Evento:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.Location = new System.Drawing.Point(26, 147);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(108, 19);
            this.materialLabel3.TabIndex = 144;
            this.materialLabel3.Text = "Tipo de Juicio:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.Location = new System.Drawing.Point(26, 119);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 19);
            this.materialLabel2.TabIndex = 143;
            this.materialLabel2.Text = "Contraparte:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.Location = new System.Drawing.Point(26, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(78, 19);
            this.materialLabel1.TabIndex = 142;
            this.materialLabel1.Text = "Autoridad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 141;
            this.label2.Text = "No. Expediente:";
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BGColor = "#508ef5";
            this.btnCargarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarArchivo.Depth = 0;
            this.btnCargarArchivo.Icon = null;
            this.btnCargarArchivo.Location = new System.Drawing.Point(105, 459);
            this.btnCargarArchivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Primary = true;
            this.btnCargarArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnCargarArchivo.TabIndex = 43;
            this.btnCargarArchivo.Text = "Adjuntar";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // cbhActivarCampos
            // 
            this.cbhActivarCampos.AutoSize = true;
            this.cbhActivarCampos.Depth = 0;
            this.cbhActivarCampos.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbhActivarCampos.Location = new System.Drawing.Point(401, 7);
            this.cbhActivarCampos.Margin = new System.Windows.Forms.Padding(0);
            this.cbhActivarCampos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbhActivarCampos.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbhActivarCampos.Name = "cbhActivarCampos";
            this.cbhActivarCampos.Ripple = true;
            this.cbhActivarCampos.Size = new System.Drawing.Size(126, 30);
            this.cbhActivarCampos.TabIndex = 42;
            this.cbhActivarCampos.Text = "Activar campos \r\npara su edición";
            this.cbhActivarCampos.UseVisualStyleBackColor = true;
            this.cbhActivarCampos.CheckedChanged += new System.EventHandler(this.cbhActivarCampos_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BGColor = "#B71C1C";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(452, 573);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BGColor = "#3F51B5";
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(330, 573);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(110, 23);
            this.btnActualizar.TabIndex = 40;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(3, 209);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(566, 23);
            this.separatorControl1.TabIndex = 159;
            // 
            // FRREditEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 614);
            this.Controls.Add(this.frm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRREditEvento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Evento";
            this.Load += new System.EventHandler(this.FRREditEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).EndInit();
            this.frm1.ResumeLayout(false);
            this.frm2.ResumeLayout(false);
            this.frm2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel listArchivos;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialogDocumento;
        private DevExpress.XtraEditors.PanelControl frm1;
        private System.Windows.Forms.Panel frm2;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCargarArchivo;
        private MaterialSkin.Controls.MaterialCheckBox cbhActivarCampos;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumExp;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtJuzgado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContraparte;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTJuicio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEvento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTarea;
        private MetroFramework.Controls.MetroDateTime dtpTeminoLegal;
        private MetroFramework.Controls.MetroDateTime dtpTerminoInterno;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}