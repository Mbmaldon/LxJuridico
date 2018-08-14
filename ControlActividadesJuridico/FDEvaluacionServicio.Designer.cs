namespace ControlActividadesJuridico
{
    partial class FDEvaluacionServicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvEvaluaciones = new System.Windows.Forms.DataGridView();
            this.idEvaluacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUCallCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFResolucion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblConsultor = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblFechaSolicitud = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTelLocal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTelCelular = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNocliente1 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.frm1 = new DevExpress.XtraEditors.PanelControl();
            this.frm2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).BeginInit();
            this.frm1.SuspendLayout();
            this.frm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 338);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 218);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvEvaluaciones);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(548, 192);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Evaluaciones Registradas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvEvaluaciones
            // 
            this.dgvEvaluaciones.AllowUserToAddRows = false;
            this.dgvEvaluaciones.AllowUserToDeleteRows = false;
            this.dgvEvaluaciones.AllowUserToResizeRows = false;
            this.dgvEvaluaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEvaluaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvaluaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvaluaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEvaluaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEvaluaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvaluaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEvaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEvaluacion,
            this.idUCallCenter,
            this.FechaRegistro,
            this.ContactoCliente,
            this.detalles});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvaluaciones.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEvaluaciones.EnableHeadersVisualStyles = false;
            this.dgvEvaluaciones.Location = new System.Drawing.Point(6, 6);
            this.dgvEvaluaciones.MultiSelect = false;
            this.dgvEvaluaciones.Name = "dgvEvaluaciones";
            this.dgvEvaluaciones.ReadOnly = true;
            this.dgvEvaluaciones.RowHeadersVisible = false;
            this.dgvEvaluaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvaluaciones.Size = new System.Drawing.Size(536, 180);
            this.dgvEvaluaciones.TabIndex = 1;
            this.dgvEvaluaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvaluaciones_CellContentClick);
            this.dgvEvaluaciones.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEvaluaciones_CellMouseMove);
            this.dgvEvaluaciones.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvEvaluaciones_CellPainting);
            // 
            // idEvaluacion
            // 
            this.idEvaluacion.HeaderText = "idEvaluacion";
            this.idEvaluacion.Name = "idEvaluacion";
            this.idEvaluacion.ReadOnly = true;
            this.idEvaluacion.Visible = false;
            // 
            // idUCallCenter
            // 
            this.idUCallCenter.FillWeight = 166.359F;
            this.idUCallCenter.HeaderText = "Call Center";
            this.idUCallCenter.Name = "idUCallCenter";
            this.idUCallCenter.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.FillWeight = 121.8274F;
            this.FechaRegistro.HeaderText = "Fecha de Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // ContactoCliente
            // 
            this.ContactoCliente.FillWeight = 65.44818F;
            this.ContactoCliente.HeaderText = "Cliente Contactado";
            this.ContactoCliente.Name = "ContactoCliente";
            this.ContactoCliente.ReadOnly = true;
            // 
            // detalles
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Transparent;
            this.detalles.DefaultCellStyle = dataGridViewCellStyle8;
            this.detalles.FillWeight = 46.36539F;
            this.detalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detalles.HeaderText = "";
            this.detalles.Name = "detalles";
            this.detalles.ReadOnly = true;
            this.detalles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFResolucion);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblFechaRegistro);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblTipoEvento);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblConsultor);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblFolio);
            this.groupBox2.Controls.Add(this.lblFechaSolicitud);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(10, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 178);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles de Solicitud";
            // 
            // lblFResolucion
            // 
            this.lblFResolucion.AutoSize = true;
            this.lblFResolucion.Location = new System.Drawing.Point(166, 97);
            this.lblFResolucion.Name = "lblFResolucion";
            this.lblFResolucion.Size = new System.Drawing.Size(38, 13);
            this.lblFResolucion.TabIndex = 19;
            this.lblFResolucion.Text = "Label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fecha Resolución:";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(166, 145);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(35, 13);
            this.lblFechaRegistro.TabIndex = 17;
            this.lblFechaRegistro.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha Solicitud Evaluación: ";
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Location = new System.Drawing.Point(166, 49);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(41, 13);
            this.lblTipoEvento.TabIndex = 1;
            this.lblTipoEvento.Text = "label13";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Atendio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Evento: ";
            // 
            // lblConsultor
            // 
            this.lblConsultor.AutoSize = true;
            this.lblConsultor.Location = new System.Drawing.Point(166, 121);
            this.lblConsultor.Name = "lblConsultor";
            this.lblConsultor.Size = new System.Drawing.Size(41, 13);
            this.lblConsultor.TabIndex = 2;
            this.lblConsultor.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Folio Evento:";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Location = new System.Drawing.Point(166, 25);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(41, 13);
            this.lblFolio.TabIndex = 14;
            this.lblFolio.Text = "label12";
            // 
            // lblFechaSolicitud
            // 
            this.lblFechaSolicitud.AutoSize = true;
            this.lblFechaSolicitud.Location = new System.Drawing.Point(166, 73);
            this.lblFechaSolicitud.Name = "lblFechaSolicitud";
            this.lblFechaSolicitud.Size = new System.Drawing.Size(41, 13);
            this.lblFechaSolicitud.TabIndex = 13;
            this.lblFechaSolicitud.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Fecha Solicitud:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTelLocal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblTelCelular);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblRFC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblNomCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNocliente1);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 138);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Cliente";
            // 
            // lblTelLocal
            // 
            this.lblTelLocal.AutoSize = true;
            this.lblTelLocal.Location = new System.Drawing.Point(166, 119);
            this.lblTelLocal.Name = "lblTelLocal";
            this.lblTelLocal.Size = new System.Drawing.Size(38, 13);
            this.lblTelLocal.TabIndex = 9;
            this.lblTelLocal.Text = "Label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Teléfono Local:";
            // 
            // lblTelCelular
            // 
            this.lblTelCelular.AutoSize = true;
            this.lblTelCelular.Location = new System.Drawing.Point(166, 95);
            this.lblTelCelular.Name = "lblTelCelular";
            this.lblTelCelular.Size = new System.Drawing.Size(35, 13);
            this.lblTelCelular.TabIndex = 7;
            this.lblTelCelular.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono Celular: ";
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Location = new System.Drawing.Point(166, 70);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(35, 13);
            this.lblRFC.TabIndex = 5;
            this.lblRFC.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RFC: ";
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Location = new System.Drawing.Point(166, 46);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(35, 13);
            this.lblNomCliente.TabIndex = 3;
            this.lblNomCliente.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Cliente: ";
            // 
            // lblNocliente1
            // 
            this.lblNocliente1.AutoSize = true;
            this.lblNocliente1.Location = new System.Drawing.Point(166, 23);
            this.lblNocliente1.Name = "lblNocliente1";
            this.lblNocliente1.Size = new System.Drawing.Size(35, 13);
            this.lblNocliente1.TabIndex = 1;
            this.lblNocliente1.Text = "label1";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(82, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "No. de Cliente: ";
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
            this.frm1.Size = new System.Drawing.Size(580, 595);
            this.frm1.TabIndex = 30;
            // 
            // frm2
            // 
            this.frm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frm2.Controls.Add(this.btnCerrar);
            this.frm2.Controls.Add(this.groupBox1);
            this.frm2.Controls.Add(this.tabControl1);
            this.frm2.Controls.Add(this.groupBox2);
            this.frm2.Location = new System.Drawing.Point(2, 2);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(576, 591);
            this.frm2.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BGColor = "#B71C1C";
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Depth = 0;
            this.btnCerrar.Icon = null;
            this.btnCerrar.Location = new System.Drawing.Point(489, 562);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Primary = true;
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FDEvaluacionServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 595);
            this.Controls.Add(this.frm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FDEvaluacionServicio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FDEvaluacionServicio";
            this.Load += new System.EventHandler(this.FDEvaluacionServicio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).EndInit();
            this.frm1.ResumeLayout(false);
            this.frm2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvEvaluaciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFResolucion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTipoEvento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblConsultor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblFechaSolicitud;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTelCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNocliente1;
        private System.Windows.Forms.Label Label1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Label lblTelLocal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUCallCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactoCliente;
        private System.Windows.Forms.DataGridViewButtonColumn detalles;
        private DevExpress.XtraEditors.PanelControl frm1;
        private System.Windows.Forms.Panel frm2;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCerrar;
    }
}