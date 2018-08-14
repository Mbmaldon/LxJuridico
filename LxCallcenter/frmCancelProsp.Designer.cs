namespace LxCallcenter
{
    partial class frmCancelProsp
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
            this.components = new System.ComponentModel.Container();
            this.lblFecha = new System.Windows.Forms.Label();
            this.rdbMotivo1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbMotivo2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbMotivo3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtOtro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAceptar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.lollipopLabel1 = new LollipopLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblFecha.Location = new System.Drawing.Point(61, 25);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(277, 22);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Motivo de cancelación del prospecto.";
            // 
            // rdbMotivo1
            // 
            this.rdbMotivo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbMotivo1.AutoSize = true;
            this.rdbMotivo1.Depth = 0;
            this.rdbMotivo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbMotivo1.Location = new System.Drawing.Point(44, 61);
            this.rdbMotivo1.Margin = new System.Windows.Forms.Padding(0);
            this.rdbMotivo1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbMotivo1.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbMotivo1.Name = "rdbMotivo1";
            this.rdbMotivo1.Ripple = true;
            this.rdbMotivo1.Size = new System.Drawing.Size(145, 30);
            this.rdbMotivo1.TabIndex = 1;
            this.rdbMotivo1.TabStop = true;
            this.rdbMotivo1.Text = "No está interesado";
            this.rdbMotivo1.UseVisualStyleBackColor = true;
            this.rdbMotivo1.CheckedChanged += new System.EventHandler(this.rdbOpciones);
            // 
            // rdbMotivo2
            // 
            this.rdbMotivo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbMotivo2.AutoSize = true;
            this.rdbMotivo2.Depth = 0;
            this.rdbMotivo2.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.rdbMotivo2.Location = new System.Drawing.Point(44, 91);
            this.rdbMotivo2.Margin = new System.Windows.Forms.Padding(0);
            this.rdbMotivo2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbMotivo2.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbMotivo2.Name = "rdbMotivo2";
            this.rdbMotivo2.Ripple = true;
            this.rdbMotivo2.Size = new System.Drawing.Size(143, 30);
            this.rdbMotivo2.TabIndex = 2;
            this.rdbMotivo2.TabStop = true;
            this.rdbMotivo2.Text = "Tiene otro servicio";
            this.rdbMotivo2.UseVisualStyleBackColor = true;
            this.rdbMotivo2.CheckedChanged += new System.EventHandler(this.rdbOpciones);
            // 
            // rdbMotivo3
            // 
            this.rdbMotivo3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbMotivo3.AutoSize = true;
            this.rdbMotivo3.Depth = 0;
            this.rdbMotivo3.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.rdbMotivo3.Location = new System.Drawing.Point(44, 121);
            this.rdbMotivo3.Margin = new System.Windows.Forms.Padding(0);
            this.rdbMotivo3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbMotivo3.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbMotivo3.Name = "rdbMotivo3";
            this.rdbMotivo3.Ripple = true;
            this.rdbMotivo3.Size = new System.Drawing.Size(56, 30);
            this.rdbMotivo3.TabIndex = 3;
            this.rdbMotivo3.TabStop = true;
            this.rdbMotivo3.Text = "Otro";
            this.rdbMotivo3.UseVisualStyleBackColor = true;
            this.rdbMotivo3.CheckedChanged += new System.EventHandler(this.rdbOpciones);
            // 
            // txtOtro
            // 
            this.txtOtro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtOtro.Depth = 0;
            this.txtOtro.Enabled = false;
            this.txtOtro.Hint = "";
            this.txtOtro.Location = new System.Drawing.Point(152, 140);
            this.txtOtro.MaxLength = 32767;
            this.txtOtro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.PasswordChar = '\0';
            this.txtOtro.ReadOnly = false;
            this.txtOtro.SelectedText = "";
            this.txtOtro.SelectionLength = 0;
            this.txtOtro.SelectionStart = 0;
            this.txtOtro.Size = new System.Drawing.Size(146, 25);
            this.txtOtro.TabIndex = 5;
            this.txtOtro.TabStop = false;
            this.txtOtro.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOtro.UseSystemPasswordChar = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.BGColor = "#311B92";
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(86, 185);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = true;
            this.btnAceptar.Size = new System.Drawing.Size(112, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BGColor = "#B71C1C";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(211, 185);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(112, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(69, 145);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(81, 17);
            this.lollipopLabel1.TabIndex = 4;
            this.lollipopLabel1.Text = "Especifique";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCancelProsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(410, 223);
            this.Controls.Add(this.txtOtro);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.rdbMotivo3);
            this.Controls.Add(this.rdbMotivo2);
            this.Controls.Add(this.rdbMotivo1);
            this.Controls.Add(this.lblFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCancelProsp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCancelProsp";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private MaterialSkin.Controls.MaterialRadioButton rdbMotivo1;
        private MaterialSkin.Controls.MaterialRadioButton rdbMotivo2;
        private MaterialSkin.Controls.MaterialRadioButton rdbMotivo3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtOtro;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnAceptar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCancelar;
        private LollipopLabel lollipopLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}