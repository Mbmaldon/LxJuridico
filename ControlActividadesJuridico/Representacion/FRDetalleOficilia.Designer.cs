namespace ControlActividadesJuridico.Representacion
{
    partial class FRDetalleOficilia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcDetalles = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvOficialias = new System.Windows.Forms.DataGridView();
            this.IdEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpedienteOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumExpediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juzgado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraparte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoJuicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.tcDetalles.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOficialias)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).BeginInit();
            this.frm1.SuspendLayout();
            this.frm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcDetalles
            // 
            this.tcDetalles.Controls.Add(this.tabPage1);
            this.tcDetalles.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcDetalles.Location = new System.Drawing.Point(13, 125);
            this.tcDetalles.Name = "tcDetalles";
            this.tcDetalles.SelectedIndex = 0;
            this.tcDetalles.Size = new System.Drawing.Size(691, 264);
            this.tcDetalles.TabIndex = 32;
            this.tcDetalles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcDetalles_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvOficialias);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(683, 238);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Oficialia de Partes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvOficialias
            // 
            this.dgvOficialias.AllowUserToAddRows = false;
            this.dgvOficialias.AllowUserToDeleteRows = false;
            this.dgvOficialias.AllowUserToResizeRows = false;
            this.dgvOficialias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvOficialias.BackgroundColor = System.Drawing.Color.White;
            this.dgvOficialias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOficialias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOficialias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOficialias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOficialias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOficialias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEvento,
            this.Consultor,
            this.ExpedienteOrigen,
            this.NumExpediente,
            this.Juzgado,
            this.Contraparte,
            this.TipoJuicio,
            this.DescripcionEvento,
            this.Editar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOficialias.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOficialias.EnableHeadersVisualStyles = false;
            this.dgvOficialias.Location = new System.Drawing.Point(8, 12);
            this.dgvOficialias.Name = "dgvOficialias";
            this.dgvOficialias.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOficialias.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOficialias.RowHeadersVisible = false;
            this.dgvOficialias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOficialias.Size = new System.Drawing.Size(667, 212);
            this.dgvOficialias.TabIndex = 0;
            this.dgvOficialias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOficialias_CellContentClick);
            this.dgvOficialias.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOficialias_CellMouseMove);
            this.dgvOficialias.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvOficialias_CellPainting);
            // 
            // IdEvento
            // 
            this.IdEvento.HeaderText = "IdEvento";
            this.IdEvento.Name = "IdEvento";
            this.IdEvento.ReadOnly = true;
            this.IdEvento.Visible = false;
            // 
            // Consultor
            // 
            this.Consultor.FillWeight = 292.1647F;
            this.Consultor.HeaderText = "Consultor";
            this.Consultor.Name = "Consultor";
            this.Consultor.ReadOnly = true;
            this.Consultor.Width = 150;
            // 
            // ExpedienteOrigen
            // 
            this.ExpedienteOrigen.FillWeight = 184.3622F;
            this.ExpedienteOrigen.HeaderText = "Expediente de Origen";
            this.ExpedienteOrigen.Name = "ExpedienteOrigen";
            this.ExpedienteOrigen.ReadOnly = true;
            // 
            // NumExpediente
            // 
            this.NumExpediente.FillWeight = 144.7222F;
            this.NumExpediente.HeaderText = "Num. Expediente";
            this.NumExpediente.Name = "NumExpediente";
            this.NumExpediente.ReadOnly = true;
            // 
            // Juzgado
            // 
            this.Juzgado.FillWeight = 100.6161F;
            this.Juzgado.HeaderText = "Juzgado";
            this.Juzgado.Name = "Juzgado";
            this.Juzgado.ReadOnly = true;
            // 
            // Contraparte
            // 
            this.Contraparte.FillWeight = 109.7629F;
            this.Contraparte.HeaderText = "Contraparte";
            this.Contraparte.Name = "Contraparte";
            this.Contraparte.ReadOnly = true;
            // 
            // TipoJuicio
            // 
            this.TipoJuicio.FillWeight = 49.76497F;
            this.TipoJuicio.HeaderText = "Tipo de Juicio";
            this.TipoJuicio.Name = "TipoJuicio";
            this.TipoJuicio.ReadOnly = true;
            this.TipoJuicio.Width = 80;
            // 
            // DescripcionEvento
            // 
            this.DescripcionEvento.FillWeight = 58.15003F;
            this.DescripcionEvento.HeaderText = "Descripción Evento";
            this.DescripcionEvento.Name = "DescripcionEvento";
            this.DescripcionEvento.ReadOnly = true;
            this.DescripcionEvento.Width = 150;
            // 
            // Editar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 60;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblFolio);
            this.groupBox2.Location = new System.Drawing.Point(415, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 98);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles de Solicitud";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Folio Evento:";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Location = new System.Drawing.Point(133, 23);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(41, 13);
            this.lblFolio.TabIndex = 14;
            this.lblFolio.Text = "label12";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRFC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblNomCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNocliente1);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 98);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Cliente";
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Location = new System.Drawing.Point(133, 70);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(35, 13);
            this.lblRFC.TabIndex = 5;
            this.lblRFC.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RFC: ";
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Location = new System.Drawing.Point(133, 46);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(35, 13);
            this.lblNomCliente.TabIndex = 3;
            this.lblNomCliente.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Cliente: ";
            // 
            // lblNocliente1
            // 
            this.lblNocliente1.AutoSize = true;
            this.lblNocliente1.Location = new System.Drawing.Point(133, 23);
            this.lblNocliente1.Name = "lblNocliente1";
            this.lblNocliente1.Size = new System.Drawing.Size(35, 13);
            this.lblNocliente1.TabIndex = 1;
            this.lblNocliente1.Text = "label1";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(15, 23);
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
            this.frm1.Size = new System.Drawing.Size(719, 434);
            this.frm1.TabIndex = 34;
            // 
            // frm2
            // 
            this.frm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frm2.Controls.Add(this.btnCerrar);
            this.frm2.Controls.Add(this.groupBox1);
            this.frm2.Controls.Add(this.groupBox2);
            this.frm2.Controls.Add(this.tcDetalles);
            this.frm2.Location = new System.Drawing.Point(2, 2);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(715, 430);
            this.frm2.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BGColor = "#B71C1C";
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Depth = 0;
            this.btnCerrar.Icon = null;
            this.btnCerrar.Location = new System.Drawing.Point(629, 397);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Primary = true;
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 33;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FRDetalleOficilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 434);
            this.Controls.Add(this.frm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRDetalleOficilia";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRDetalleOficilia";
            this.tcDetalles.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOficialias)).EndInit();
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

        private System.Windows.Forms.TabControl tcDetalles;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvOficialias;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNocliente1;
        private System.Windows.Forms.Label Label1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpedienteOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumExpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juzgado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraparte;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoJuicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEvento;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private DevExpress.XtraEditors.PanelControl frm1;
        private System.Windows.Forms.Panel frm2;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCerrar;
    }
}