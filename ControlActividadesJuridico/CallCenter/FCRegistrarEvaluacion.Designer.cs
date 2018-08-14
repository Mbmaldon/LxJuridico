namespace ControlActividadesJuridico.CallCenter
{
    partial class FCRegistrarEvaluacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNO = new System.Windows.Forms.RadioButton();
            this.rbSI = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbP1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbP2 = new System.Windows.Forms.ComboBox();
            this.cmbP3 = new System.Windows.Forms.ComboBox();
            this.cmbP4 = new System.Windows.Forms.ComboBox();
            this.cmbP5 = new System.Windows.Forms.ComboBox();
            this.cmbP6 = new System.Windows.Forms.ComboBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbNO);
            this.groupBox1.Controls.Add(this.rbSI);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valoración de Evaluación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Se contacta al cliente:";
            // 
            // rbNO
            // 
            this.rbNO.AutoSize = true;
            this.rbNO.BackColor = System.Drawing.Color.White;
            this.rbNO.Location = new System.Drawing.Point(312, 23);
            this.rbNO.Name = "rbNO";
            this.rbNO.Size = new System.Drawing.Size(41, 17);
            this.rbNO.TabIndex = 1;
            this.rbNO.Text = "NO";
            this.rbNO.UseVisualStyleBackColor = false;
            this.rbNO.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbSI
            // 
            this.rbSI.AutoSize = true;
            this.rbSI.BackColor = System.Drawing.Color.White;
            this.rbSI.Location = new System.Drawing.Point(271, 23);
            this.rbSI.Name = "rbSI";
            this.rbSI.Size = new System.Drawing.Size(35, 17);
            this.rbSI.TabIndex = 0;
            this.rbSI.Text = "SI";
            this.rbSI.UseVisualStyleBackColor = false;
            this.rbSI.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::ControlActividadesJuridico.Properties.Resources.Form_delete_01_WF_1;
            this.btnCancelar.Location = new System.Drawing.Point(21, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 27);
            this.btnCancelar.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(4)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = global::ControlActividadesJuridico.Properties.Resources.send_file_22px;
            this.btnRegistrar.Location = new System.Drawing.Point(553, 380);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(60, 27);
            this.btnRegistrar.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.btnRegistrar, "Registrar");
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Visible = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "1. - ¿En que nivel de satisfacción considera que se encuentra nuestro servicio?";
            // 
            // cmbP1
            // 
            this.cmbP1.FormattingEnabled = true;
            this.cmbP1.Location = new System.Drawing.Point(456, 26);
            this.cmbP1.Name = "cmbP1";
            this.cmbP1.Size = new System.Drawing.Size(145, 21);
            this.cmbP1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "2. - ¿Cómo calificas la calidad del servicio?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "3. -  Nuestro servicio cumple tus necesidades";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(432, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "4. - ¿Resolvimos tus preguntas, dudas o sugerencias acerca de nuestro servicio of" +
    "ertado?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "5. - ¿Como calificas la atención de nuestros asesores?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(423, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "6. - ¿Cómo calificarías las tecnologias de la información otorgadas por nuestra e" +
    "mpresa?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "7. - ¿Tienes algún comentario, pregunta o sugerencia?";
            // 
            // cmbP2
            // 
            this.cmbP2.FormattingEnabled = true;
            this.cmbP2.Location = new System.Drawing.Point(456, 53);
            this.cmbP2.Name = "cmbP2";
            this.cmbP2.Size = new System.Drawing.Size(145, 21);
            this.cmbP2.TabIndex = 8;
            // 
            // cmbP3
            // 
            this.cmbP3.FormattingEnabled = true;
            this.cmbP3.Location = new System.Drawing.Point(456, 80);
            this.cmbP3.Name = "cmbP3";
            this.cmbP3.Size = new System.Drawing.Size(145, 21);
            this.cmbP3.TabIndex = 9;
            // 
            // cmbP4
            // 
            this.cmbP4.FormattingEnabled = true;
            this.cmbP4.Location = new System.Drawing.Point(456, 107);
            this.cmbP4.Name = "cmbP4";
            this.cmbP4.Size = new System.Drawing.Size(145, 21);
            this.cmbP4.TabIndex = 10;
            // 
            // cmbP5
            // 
            this.cmbP5.FormattingEnabled = true;
            this.cmbP5.Location = new System.Drawing.Point(456, 134);
            this.cmbP5.Name = "cmbP5";
            this.cmbP5.Size = new System.Drawing.Size(145, 21);
            this.cmbP5.TabIndex = 11;
            // 
            // cmbP6
            // 
            this.cmbP6.FormattingEnabled = true;
            this.cmbP6.Location = new System.Drawing.Point(456, 161);
            this.cmbP6.Name = "cmbP6";
            this.cmbP6.Size = new System.Drawing.Size(145, 21);
            this.cmbP6.TabIndex = 12;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(9, 213);
            this.txtComentario.MaxLength = 4000;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.Size = new System.Drawing.Size(592, 77);
            this.txtComentario.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtComentario);
            this.groupBox2.Controls.Add(this.cmbP6);
            this.groupBox2.Controls.Add(this.cmbP5);
            this.groupBox2.Controls.Add(this.cmbP4);
            this.groupBox2.Controls.Add(this.cmbP3);
            this.groupBox2.Controls.Add(this.cmbP2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbP1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 296);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Evaluación";
            this.groupBox2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Observaciones y/o Comentarios:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(9, 46);
            this.txtObservaciones.MaxLength = 4000;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(592, 88);
            this.txtObservaciones.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtObservaciones);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 150);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comentarios";
            this.groupBox3.Visible = false;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FCRegistrarEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 423);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FCRegistrarEvaluacion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCRegistrarEvaluacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNO;
        private System.Windows.Forms.RadioButton rbSI;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbP1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbP2;
        private System.Windows.Forms.ComboBox cmbP3;
        private System.Windows.Forms.ComboBox cmbP4;
        private System.Windows.Forms.ComboBox cmbP5;
        private System.Windows.Forms.ComboBox cmbP6;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}