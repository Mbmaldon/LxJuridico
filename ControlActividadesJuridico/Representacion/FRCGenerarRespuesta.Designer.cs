namespace ControlActividadesJuridico.Representacion
{
    partial class FRCGenerarRespuesta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcDetalles = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPropuestas = new System.Windows.Forms.DataGridView();
            this.idPropuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aprobacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotivoRechazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aprueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCoordinador = new System.Windows.Forms.Label();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsultarllamadas = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.txtSolicitud = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.btnEnviarTramite = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.chbEnviaraAprobacion = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnRegistrarP = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            this.tcDetalles.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropuestas)).BeginInit();
            this.groupBox5.SuspendLayout();
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
            this.tcDetalles.Location = new System.Drawing.Point(11, 301);
            this.tcDetalles.Name = "tcDetalles";
            this.tcDetalles.SelectedIndex = 0;
            this.tcDetalles.Size = new System.Drawing.Size(785, 223);
            this.tcDetalles.TabIndex = 33;
            this.tcDetalles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcDetalles_DrawItem);
            this.tcDetalles.SelectedIndexChanged += new System.EventHandler(this.tcDetalles_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.btnRegistrarP);
            this.tabPage1.Controls.Add(this.dgvPropuestas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(777, 197);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Registrar Propuesta de Respuesta";
            // 
            // dgvPropuestas
            // 
            this.dgvPropuestas.AllowUserToAddRows = false;
            this.dgvPropuestas.AllowUserToDeleteRows = false;
            this.dgvPropuestas.AllowUserToResizeColumns = false;
            this.dgvPropuestas.AllowUserToResizeRows = false;
            this.dgvPropuestas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPropuestas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPropuestas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPropuestas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPropuestas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPropuestas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPropuestas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPropuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPropuesta,
            this.dataGridViewTextBoxColumn1,
            this.Aprobacion,
            this.MotivoRechazo,
            this.Aprueba,
            this.Detalles});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPropuestas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPropuestas.EnableHeadersVisualStyles = false;
            this.dgvPropuestas.Location = new System.Drawing.Point(10, 12);
            this.dgvPropuestas.Name = "dgvPropuestas";
            this.dgvPropuestas.ReadOnly = true;
            this.dgvPropuestas.RowHeadersVisible = false;
            this.dgvPropuestas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPropuestas.Size = new System.Drawing.Size(756, 145);
            this.dgvPropuestas.TabIndex = 1;
            this.dgvPropuestas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPropuestas_CellContentClick);
            this.dgvPropuestas.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPropuestas_CellMouseMove);
            this.dgvPropuestas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvPropuestas_CellPainting);
            // 
            // idPropuesta
            // 
            this.idPropuesta.HeaderText = "";
            this.idPropuesta.Name = "idPropuesta";
            this.idPropuesta.ReadOnly = true;
            this.idPropuesta.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 121.7732F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Propuesta de Respuesta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Aprobacion
            // 
            this.Aprobacion.FillWeight = 121.7732F;
            this.Aprobacion.HeaderText = "Aprobación";
            this.Aprobacion.Name = "Aprobacion";
            this.Aprobacion.ReadOnly = true;
            // 
            // MotivoRechazo
            // 
            this.MotivoRechazo.FillWeight = 121.7732F;
            this.MotivoRechazo.HeaderText = "Motivo de Rechazo";
            this.MotivoRechazo.Name = "MotivoRechazo";
            this.MotivoRechazo.ReadOnly = true;
            // 
            // Aprueba
            // 
            this.Aprueba.FillWeight = 121.7732F;
            this.Aprueba.HeaderText = "Aprueba Propuesta";
            this.Aprueba.Name = "Aprueba";
            this.Aprueba.ReadOnly = true;
            // 
            // Detalles
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            this.Detalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.Detalles.FillWeight = 51.99306F;
            this.Detalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detalles.HeaderText = "";
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            this.Detalles.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detalles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.lblCoordinador);
            this.groupBox5.Controls.Add(this.lblTipoEvento);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(11, 203);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(384, 81);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tipo de evento";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Coordinador:";
            // 
            // lblCoordinador
            // 
            this.lblCoordinador.AutoSize = true;
            this.lblCoordinador.Location = new System.Drawing.Point(133, 23);
            this.lblCoordinador.Name = "lblCoordinador";
            this.lblCoordinador.Size = new System.Drawing.Size(41, 13);
            this.lblCoordinador.TabIndex = 2;
            this.lblCoordinador.Text = "label14";
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Location = new System.Drawing.Point(133, 48);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(41, 13);
            this.lblTipoEvento.TabIndex = 1;
            this.lblTipoEvento.Text = "label13";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Evento: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsultarllamadas);
            this.groupBox2.Controls.Add(this.txtSolicitud);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblFolio);
            this.groupBox2.Controls.Add(this.lblFechaRegistro);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblRegistro);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(413, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 268);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles de Solicitud";
            // 
            // btnConsultarllamadas
            // 
            this.btnConsultarllamadas.BGColor = "#508ef5";
            this.btnConsultarllamadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarllamadas.Depth = 0;
            this.btnConsultarllamadas.Icon = null;
            this.btnConsultarllamadas.Location = new System.Drawing.Point(28, 222);
            this.btnConsultarllamadas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultarllamadas.Name = "btnConsultarllamadas";
            this.btnConsultarllamadas.Primary = true;
            this.btnConsultarllamadas.Size = new System.Drawing.Size(139, 23);
            this.btnConsultarllamadas.TabIndex = 17;
            this.btnConsultarllamadas.Text = "Consultar Llamadas";
            this.btnConsultarllamadas.UseVisualStyleBackColor = true;
            this.btnConsultarllamadas.Click += new System.EventHandler(this.btnConsultarllamadas_Click);
            // 
            // txtSolicitud
            // 
            this.txtSolicitud.BackColor = System.Drawing.Color.White;
            this.txtSolicitud.Location = new System.Drawing.Point(28, 121);
            this.txtSolicitud.MaxLength = 4000;
            this.txtSolicitud.Multiline = true;
            this.txtSolicitud.Name = "txtSolicitud";
            this.txtSolicitud.ReadOnly = true;
            this.txtSolicitud.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSolicitud.Size = new System.Drawing.Size(340, 87);
            this.txtSolicitud.TabIndex = 16;
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
            this.lblFolio.Location = new System.Drawing.Point(164, 23);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(41, 13);
            this.lblFolio.TabIndex = 14;
            this.lblFolio.Text = "label12";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(164, 46);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(41, 13);
            this.lblFechaRegistro.TabIndex = 13;
            this.lblFechaRegistro.Text = "label10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Descripción Solicitud: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Fecha Registro:";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(164, 70);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(35, 13);
            this.lblRegistro.TabIndex = 1;
            this.lblRegistro.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Registro Solicitud: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblServicio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblTipoPersona);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTelCelular);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblRFC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblNomCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNocliente1);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 175);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Cliente";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(133, 145);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(35, 13);
            this.lblServicio.TabIndex = 11;
            this.lblServicio.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Servicio: ";
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Location = new System.Drawing.Point(133, 121);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(35, 13);
            this.lblTipoPersona.TabIndex = 9;
            this.lblTipoPersona.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo Persona: ";
            // 
            // lblTelCelular
            // 
            this.lblTelCelular.AutoSize = true;
            this.lblTelCelular.Location = new System.Drawing.Point(133, 95);
            this.lblTelCelular.Name = "lblTelCelular";
            this.lblTelCelular.Size = new System.Drawing.Size(35, 13);
            this.lblTelCelular.TabIndex = 7;
            this.lblTelCelular.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono Celular: ";
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
            this.frm1.Size = new System.Drawing.Size(813, 606);
            this.frm1.TabIndex = 37;
            // 
            // frm2
            // 
            this.frm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.frm2.Controls.Add(this.chbEnviaraAprobacion);
            this.frm2.Controls.Add(this.btnCancelar);
            this.frm2.Controls.Add(this.btnEnviarTramite);
            this.frm2.Controls.Add(this.groupBox1);
            this.frm2.Controls.Add(this.groupBox2);
            this.frm2.Controls.Add(this.groupBox5);
            this.frm2.Controls.Add(this.tcDetalles);
            this.frm2.Location = new System.Drawing.Point(2, 2);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(809, 602);
            this.frm2.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BGColor = "#B71C1C";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(721, 558);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviarTramite
            // 
            this.btnEnviarTramite.BGColor = "#3F51B5";
            this.btnEnviarTramite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarTramite.Depth = 0;
            this.btnEnviarTramite.Icon = null;
            this.btnEnviarTramite.Location = new System.Drawing.Point(590, 558);
            this.btnEnviarTramite.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnviarTramite.Name = "btnEnviarTramite";
            this.btnEnviarTramite.Primary = true;
            this.btnEnviarTramite.Size = new System.Drawing.Size(124, 23);
            this.btnEnviarTramite.TabIndex = 37;
            this.btnEnviarTramite.Text = "Enviar Trámite";
            this.btnEnviarTramite.UseVisualStyleBackColor = true;
            this.btnEnviarTramite.Visible = false;
            this.btnEnviarTramite.Click += new System.EventHandler(this.btnEnviarTramite_Click);
            // 
            // chbEnviaraAprobacion
            // 
            this.chbEnviaraAprobacion.AutoSize = true;
            this.chbEnviaraAprobacion.Depth = 0;
            this.chbEnviaraAprobacion.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbEnviaraAprobacion.Location = new System.Drawing.Point(25, 533);
            this.chbEnviaraAprobacion.Margin = new System.Windows.Forms.Padding(0);
            this.chbEnviaraAprobacion.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbEnviaraAprobacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbEnviaraAprobacion.Name = "chbEnviaraAprobacion";
            this.chbEnviaraAprobacion.Ripple = true;
            this.chbEnviaraAprobacion.Size = new System.Drawing.Size(223, 30);
            this.chbEnviaraAprobacion.TabIndex = 39;
            this.chbEnviaraAprobacion.Text = "Enviar propuestas de respuesta \r\npara su aprobación.";
            this.chbEnviaraAprobacion.UseVisualStyleBackColor = true;
            this.chbEnviaraAprobacion.CheckedChanged += new System.EventHandler(this.chbEnviaraAprobacion_CheckedChanged);
            // 
            // btnRegistrarP
            // 
            this.btnRegistrarP.BGColor = "#508ef5";
            this.btnRegistrarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarP.Depth = 0;
            this.btnRegistrarP.Icon = null;
            this.btnRegistrarP.Location = new System.Drawing.Point(633, 163);
            this.btnRegistrarP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarP.Name = "btnRegistrarP";
            this.btnRegistrarP.Primary = true;
            this.btnRegistrarP.Size = new System.Drawing.Size(133, 23);
            this.btnRegistrarP.TabIndex = 2;
            this.btnRegistrarP.Text = "Registrar Propuesta";
            this.btnRegistrarP.UseVisualStyleBackColor = true;
            this.btnRegistrarP.Click += new System.EventHandler(this.btnRegistrarP_Click);
            // 
            // FRCGenerarRespuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 606);
            this.Controls.Add(this.frm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRCGenerarRespuesta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FRCGenerarRespuesta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRCGenerarRespuesta_FormClosing);
            this.tcDetalles.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropuestas)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frm1)).EndInit();
            this.frm1.ResumeLayout(false);
            this.frm2.ResumeLayout(false);
            this.frm2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcDetalles;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvPropuestas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPropuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aprobacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotivoRechazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aprueba;
        private System.Windows.Forms.DataGridViewButtonColumn Detalles;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCoordinador;
        private System.Windows.Forms.Label lblTipoEvento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSolicitud;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTelCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNocliente1;
        private System.Windows.Forms.Label Label1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnConsultarllamadas;
        private DevExpress.XtraEditors.PanelControl frm1;
        private System.Windows.Forms.Panel frm2;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnEnviarTramite;
        private MaterialSkin.Controls.MaterialCheckBox chbEnviaraAprobacion;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnRegistrarP;
    }
}