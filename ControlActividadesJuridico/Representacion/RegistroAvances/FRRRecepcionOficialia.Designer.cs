namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    partial class FRRRecepcionOficialia
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.openFileDialogDocumento = new System.Windows.Forms.OpenFileDialog();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnCargar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.frm1 = new DevExpress.XtraEditors.PanelControl();
            this.frm2 = new System.Windows.Forms.Panel();
            this.btnCargarArchivo = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.txtExpOrigen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumExp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtJuzgado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContraparte = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTJuicio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.label10 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).BeginInit();
            this.frm1.SuspendLayout();
            this.frm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listArchivos
            // 
            this.listArchivos.Location = new System.Drawing.Point(223, 335);
            this.listArchivos.Name = "listArchivos";
            this.listArchivos.Size = new System.Drawing.Size(325, 87);
            this.listArchivos.TabIndex = 29;
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.BackColor = System.Drawing.Color.White;
            this.txtRutaArchivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRutaArchivo.Enabled = false;
            this.txtRutaArchivo.Location = new System.Drawing.Point(223, 303);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(270, 14);
            this.txtRutaArchivo.TabIndex = 28;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(223, 209);
            this.txtDescripcion.MaxLength = 4000;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(325, 80);
            this.txtDescripcion.TabIndex = 9;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
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
            // btnCancelar
            // 
            this.btnCancelar.BGColor = "#B71C1C";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(473, 439);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BGColor = "#3F51B5";
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.Depth = 0;
            this.btnCargar.Icon = null;
            this.btnCargar.Location = new System.Drawing.Point(346, 439);
            this.btnCargar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Primary = true;
            this.btnCargar.Size = new System.Drawing.Size(121, 23);
            this.btnCargar.TabIndex = 31;
            this.btnCargar.Text = "Actualizar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frm1
            // 
            this.frm1.Controls.Add(this.frm2);
            this.frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm1.Location = new System.Drawing.Point(0, 0);
            this.frm1.Name = "frm1";
            this.frm1.Size = new System.Drawing.Size(592, 479);
            this.frm1.TabIndex = 32;
            // 
            // frm2
            // 
            this.frm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frm2.Controls.Add(this.label10);
            this.frm2.Controls.Add(this.label5);
            this.frm2.Controls.Add(this.label4);
            this.frm2.Controls.Add(this.label3);
            this.frm2.Controls.Add(this.label2);
            this.frm2.Controls.Add(this.label1);
            this.frm2.Controls.Add(this.txtTJuicio);
            this.frm2.Controls.Add(this.txtContraparte);
            this.frm2.Controls.Add(this.txtJuzgado);
            this.frm2.Controls.Add(this.txtNumExp);
            this.frm2.Controls.Add(this.txtExpOrigen);
            this.frm2.Controls.Add(this.btnCargarArchivo);
            this.frm2.Controls.Add(this.btnCargar);
            this.frm2.Controls.Add(this.btnCancelar);
            this.frm2.Controls.Add(this.listArchivos);
            this.frm2.Controls.Add(this.txtRutaArchivo);
            this.frm2.Controls.Add(this.txtDescripcion);
            this.frm2.Location = new System.Drawing.Point(2, 2);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(588, 475);
            this.frm2.TabIndex = 0;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BGColor = "#508ef5";
            this.btnCargarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarArchivo.Depth = 0;
            this.btnCargarArchivo.Icon = null;
            this.btnCargarArchivo.Location = new System.Drawing.Point(133, 298);
            this.btnCargarArchivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Primary = true;
            this.btnCargarArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnCargarArchivo.TabIndex = 32;
            this.btnCargarArchivo.Text = "Adjuntar";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // txtExpOrigen
            // 
            this.txtExpOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtExpOrigen.Depth = 0;
            this.txtExpOrigen.Enabled = false;
            this.txtExpOrigen.Hint = "";
            this.txtExpOrigen.Location = new System.Drawing.Point(223, 31);
            this.txtExpOrigen.MaxLength = 32767;
            this.txtExpOrigen.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtExpOrigen.Name = "txtExpOrigen";
            this.txtExpOrigen.PasswordChar = '\0';
            this.txtExpOrigen.ReadOnly = false;
            this.txtExpOrigen.SelectedText = "";
            this.txtExpOrigen.SelectionLength = 0;
            this.txtExpOrigen.SelectionStart = 0;
            this.txtExpOrigen.Size = new System.Drawing.Size(325, 23);
            this.txtExpOrigen.TabIndex = 33;
            this.txtExpOrigen.TabStop = false;
            this.txtExpOrigen.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtExpOrigen.UseSystemPasswordChar = false;
            // 
            // txtNumExp
            // 
            this.txtNumExp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumExp.Depth = 0;
            this.txtNumExp.Enabled = false;
            this.txtNumExp.Hint = "";
            this.txtNumExp.Location = new System.Drawing.Point(223, 65);
            this.txtNumExp.MaxLength = 32767;
            this.txtNumExp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumExp.Name = "txtNumExp";
            this.txtNumExp.PasswordChar = '\0';
            this.txtNumExp.ReadOnly = false;
            this.txtNumExp.SelectedText = "";
            this.txtNumExp.SelectionLength = 0;
            this.txtNumExp.SelectionStart = 0;
            this.txtNumExp.Size = new System.Drawing.Size(325, 23);
            this.txtNumExp.TabIndex = 34;
            this.txtNumExp.TabStop = false;
            this.txtNumExp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumExp.UseSystemPasswordChar = false;
            // 
            // txtJuzgado
            // 
            this.txtJuzgado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtJuzgado.Depth = 0;
            this.txtJuzgado.Enabled = false;
            this.txtJuzgado.Hint = "";
            this.txtJuzgado.Location = new System.Drawing.Point(223, 101);
            this.txtJuzgado.MaxLength = 32767;
            this.txtJuzgado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtJuzgado.Name = "txtJuzgado";
            this.txtJuzgado.PasswordChar = '\0';
            this.txtJuzgado.ReadOnly = false;
            this.txtJuzgado.SelectedText = "";
            this.txtJuzgado.SelectionLength = 0;
            this.txtJuzgado.SelectionStart = 0;
            this.txtJuzgado.Size = new System.Drawing.Size(325, 23);
            this.txtJuzgado.TabIndex = 35;
            this.txtJuzgado.TabStop = false;
            this.txtJuzgado.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJuzgado.UseSystemPasswordChar = false;
            // 
            // txtContraparte
            // 
            this.txtContraparte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContraparte.Depth = 0;
            this.txtContraparte.Enabled = false;
            this.txtContraparte.Hint = "";
            this.txtContraparte.Location = new System.Drawing.Point(223, 137);
            this.txtContraparte.MaxLength = 32767;
            this.txtContraparte.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContraparte.Name = "txtContraparte";
            this.txtContraparte.PasswordChar = '\0';
            this.txtContraparte.ReadOnly = false;
            this.txtContraparte.SelectedText = "";
            this.txtContraparte.SelectionLength = 0;
            this.txtContraparte.SelectionStart = 0;
            this.txtContraparte.Size = new System.Drawing.Size(325, 23);
            this.txtContraparte.TabIndex = 36;
            this.txtContraparte.TabStop = false;
            this.txtContraparte.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraparte.UseSystemPasswordChar = false;
            // 
            // txtTJuicio
            // 
            this.txtTJuicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTJuicio.Depth = 0;
            this.txtTJuicio.Enabled = false;
            this.txtTJuicio.Hint = "";
            this.txtTJuicio.Location = new System.Drawing.Point(223, 172);
            this.txtTJuicio.MaxLength = 32767;
            this.txtTJuicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTJuicio.Name = "txtTJuicio";
            this.txtTJuicio.PasswordChar = '\0';
            this.txtTJuicio.ReadOnly = false;
            this.txtTJuicio.SelectedText = "";
            this.txtTJuicio.SelectionLength = 0;
            this.txtTJuicio.SelectionStart = 0;
            this.txtTJuicio.Size = new System.Drawing.Size(325, 23);
            this.txtTJuicio.TabIndex = 37;
            this.txtTJuicio.TabStop = false;
            this.txtTJuicio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTJuicio.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Expediente de Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Num. Expediente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.Location = new System.Drawing.Point(35, 105);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Juzgado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.Location = new System.Drawing.Point(35, 141);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Contraparte:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.label5.Location = new System.Drawing.Point(35, 176);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tipo de Juicio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Depth = 0;
            this.label10.Font = new System.Drawing.Font("Roboto", 11F);
            this.label10.Location = new System.Drawing.Point(35, 209);
            this.label10.MouseState = MaterialSkin.MouseState.HOVER;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 19);
            this.label10.TabIndex = 43;
            this.label10.Text = "Descripción del evento:";
            // 
            // FRRRecepcionOficialia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 479);
            this.Controls.Add(this.frm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRRRecepcionOficialia";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRRRecepcionOficialia";
            this.Load += new System.EventHandler(this.FRRRecepcionOficialia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).EndInit();
            this.frm1.ResumeLayout(false);
            this.frm2.ResumeLayout(false);
            this.frm2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.OpenFileDialog openFileDialogDocumento;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Panel listArchivos;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCargar;
        private DevExpress.XtraEditors.PanelControl frm1;
        private System.Windows.Forms.Panel frm2;
        private MaterialSkin.Controls.MaterialLabel label10;
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTJuicio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContraparte;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtJuzgado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumExp;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtExpOrigen;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCargarArchivo;
    }
}