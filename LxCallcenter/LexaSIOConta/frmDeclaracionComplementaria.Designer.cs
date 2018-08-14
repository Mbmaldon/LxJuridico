namespace LxCallcenter.LexaSIOConta
{
    partial class frmDeclaracionComplementaria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDeclaracion = new System.Windows.Forms.GroupBox();
            this.cmbxConcepto = new MetroFramework.Controls.MetroComboBox();
            this.grdConceptos = new MetroFramework.Controls.MetroGrid();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPeriodo = new MetroFramework.Controls.MetroComboBox();
            this.cbDecTipo = new MetroFramework.Controls.MetroComboBox();
            this.cbEstadoPago = new MetroFramework.Controls.MetroComboBox();
            this.cmbxAnioDeclaracion = new MetroFramework.Controls.MetroComboBox();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.btnSubirArchivo = new System.Windows.Forms.Button();
            this.lblLlavePago = new System.Windows.Forms.Label();
            this.txbLlavePago = new System.Windows.Forms.TextBox();
            this.lblNumOperacion = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txbNumOperacion = new System.Windows.Forms.TextBox();
            this.lblDecTipo = new System.Windows.Forms.Label();
            this.btnAgregarConcepto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.txbLCaptura = new System.Windows.Forms.TextBox();
            this.lblLCaptura = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.gbBuscarCliente = new System.Windows.Forms.GroupBox();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblCActivo = new System.Windows.Forms.Label();
            this.btnNDeclracion = new System.Windows.Forms.Button();
            this.openFileDialogDocumento = new System.Windows.Forms.OpenFileDialog();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNCliente = new MaterialSkin.Controls.MaterialLabel();
            this.txbNCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblOtro = new MaterialSkin.Controls.MaterialLabel();
            this.lblRfc = new MaterialSkin.Controls.MaterialLabel();
            this.txbRfc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscar = new MetroFramework.Controls.MetroLink();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.txbNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCorreoE = new MaterialSkin.Controls.MaterialLabel();
            this.txbEMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAño = new MaterialSkin.Controls.MaterialLabel();
            this.lblFPresentacion = new MaterialSkin.Controls.MaterialLabel();
            this.dpFPresentacion = new MetroFramework.Controls.MetroDateTime();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txbMonto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.gbDeclaracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConceptos)).BeginInit();
            this.gbBuscarCliente.SuspendLayout();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.label4.Location = new System.Drawing.Point(26, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 33);
            this.label4.TabIndex = 86;
            this.label4.Text = "Declaraciones Complementarias";
            // 
            // gbDeclaracion
            // 
            this.gbDeclaracion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDeclaracion.Controls.Add(this.txbMonto);
            this.gbDeclaracion.Controls.Add(this.materialLabel1);
            this.gbDeclaracion.Controls.Add(this.dpFPresentacion);
            this.gbDeclaracion.Controls.Add(this.lblFPresentacion);
            this.gbDeclaracion.Controls.Add(this.lblAño);
            this.gbDeclaracion.Controls.Add(this.cmbxConcepto);
            this.gbDeclaracion.Controls.Add(this.grdConceptos);
            this.gbDeclaracion.Controls.Add(this.cbPeriodo);
            this.gbDeclaracion.Controls.Add(this.cbDecTipo);
            this.gbDeclaracion.Controls.Add(this.cbEstadoPago);
            this.gbDeclaracion.Controls.Add(this.cmbxAnioDeclaracion);
            this.gbDeclaracion.Controls.Add(this.txtRutaArchivo);
            this.gbDeclaracion.Controls.Add(this.btnSubirArchivo);
            this.gbDeclaracion.Controls.Add(this.lblLlavePago);
            this.gbDeclaracion.Controls.Add(this.txbLlavePago);
            this.gbDeclaracion.Controls.Add(this.lblNumOperacion);
            this.gbDeclaracion.Controls.Add(this.txtImporte);
            this.gbDeclaracion.Controls.Add(this.txbNumOperacion);
            this.gbDeclaracion.Controls.Add(this.lblDecTipo);
            this.gbDeclaracion.Controls.Add(this.btnAgregarConcepto);
            this.gbDeclaracion.Controls.Add(this.btnCancelar);
            this.gbDeclaracion.Controls.Add(this.btnGuardar);
            this.gbDeclaracion.Controls.Add(this.label6);
            this.gbDeclaracion.Controls.Add(this.label5);
            this.gbDeclaracion.Controls.Add(this.label3);
            this.gbDeclaracion.Controls.Add(this.label2);
            this.gbDeclaracion.Controls.Add(this.dpFechaPago);
            this.gbDeclaracion.Controls.Add(this.txbLCaptura);
            this.gbDeclaracion.Controls.Add(this.lblLCaptura);
            this.gbDeclaracion.Controls.Add(this.lblPeriodo);
            this.gbDeclaracion.Location = new System.Drawing.Point(-2, 280);
            this.gbDeclaracion.Name = "gbDeclaracion";
            this.gbDeclaracion.Size = new System.Drawing.Size(1213, 421);
            this.gbDeclaracion.TabIndex = 90;
            this.gbDeclaracion.TabStop = false;
            this.gbDeclaracion.Visible = false;
            // 
            // cmbxConcepto
            // 
            this.cmbxConcepto.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbxConcepto.FormattingEnabled = true;
            this.cmbxConcepto.ItemHeight = 19;
            this.cmbxConcepto.Location = new System.Drawing.Point(624, 259);
            this.cmbxConcepto.Name = "cmbxConcepto";
            this.cmbxConcepto.Size = new System.Drawing.Size(217, 25);
            this.cmbxConcepto.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cmbxConcepto.TabIndex = 122;
            this.cmbxConcepto.UseSelectable = true;
            // 
            // grdConceptos
            // 
            this.grdConceptos.AllowUserToAddRows = false;
            this.grdConceptos.AllowUserToDeleteRows = false;
            this.grdConceptos.AllowUserToResizeRows = false;
            this.grdConceptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdConceptos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdConceptos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdConceptos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdConceptos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConceptos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grdConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConceptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdConceptos.DefaultCellStyle = dataGridViewCellStyle15;
            this.grdConceptos.EnableHeadersVisualStyles = false;
            this.grdConceptos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdConceptos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdConceptos.Location = new System.Drawing.Point(862, 259);
            this.grdConceptos.Name = "grdConceptos";
            this.grdConceptos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConceptos.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grdConceptos.RowHeadersVisible = false;
            this.grdConceptos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdConceptos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConceptos.Size = new System.Drawing.Size(319, 100);
            this.grdConceptos.TabIndex = 121;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "IdConcepto";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Concepto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column2.HeaderText = "Importe";
            this.Column2.Name = "Column2";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.ItemHeight = 19;
            this.cbPeriodo.Location = new System.Drawing.Point(964, 103);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(216, 25);
            this.cbPeriodo.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbPeriodo.TabIndex = 120;
            this.cbPeriodo.UseSelectable = true;
            // 
            // cbDecTipo
            // 
            this.cbDecTipo.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbDecTipo.FormattingEnabled = true;
            this.cbDecTipo.ItemHeight = 19;
            this.cbDecTipo.Location = new System.Drawing.Point(964, 73);
            this.cbDecTipo.Name = "cbDecTipo";
            this.cbDecTipo.Size = new System.Drawing.Size(216, 25);
            this.cbDecTipo.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbDecTipo.TabIndex = 119;
            this.cbDecTipo.UseSelectable = true;
            this.cbDecTipo.SelectedIndexChanged += new System.EventHandler(this.cbDecTipo_SelectedIndexChanged);
            // 
            // cbEstadoPago
            // 
            this.cbEstadoPago.DisplayMember = "DeclaracionEstado";
            this.cbEstadoPago.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbEstadoPago.FormattingEnabled = true;
            this.cbEstadoPago.ItemHeight = 19;
            this.cbEstadoPago.Location = new System.Drawing.Point(676, 182);
            this.cbEstadoPago.Name = "cbEstadoPago";
            this.cbEstadoPago.Size = new System.Drawing.Size(166, 25);
            this.cbEstadoPago.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbEstadoPago.TabIndex = 118;
            this.cbEstadoPago.UseSelectable = true;
            this.cbEstadoPago.ValueMember = "IdDeclaracionEstado";
            this.cbEstadoPago.SelectedIndexChanged += new System.EventHandler(this.cbEstadoPago_SelectedIndexChanged);
            // 
            // cmbxAnioDeclaracion
            // 
            this.cmbxAnioDeclaracion.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbxAnioDeclaracion.FormattingEnabled = true;
            this.cmbxAnioDeclaracion.ItemHeight = 19;
            this.cmbxAnioDeclaracion.Location = new System.Drawing.Point(122, 50);
            this.cmbxAnioDeclaracion.Name = "cmbxAnioDeclaracion";
            this.cmbxAnioDeclaracion.Size = new System.Drawing.Size(166, 25);
            this.cmbxAnioDeclaracion.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cmbxAnioDeclaracion.TabIndex = 117;
            this.cmbxAnioDeclaracion.UseSelectable = true;
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRutaArchivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRutaArchivo.Enabled = false;
            this.txtRutaArchivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaArchivo.Location = new System.Drawing.Point(664, 387);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(202, 18);
            this.txtRutaArchivo.TabIndex = 112;
            this.txtRutaArchivo.Visible = false;
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.BackColor = System.Drawing.Color.Gray;
            this.btnSubirArchivo.FlatAppearance.BorderSize = 0;
            this.btnSubirArchivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.btnSubirArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.btnSubirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirArchivo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirArchivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubirArchivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubirArchivo.Location = new System.Drawing.Point(575, 384);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(83, 24);
            this.btnSubirArchivo.TabIndex = 111;
            this.btnSubirArchivo.Text = "Subir Archivo";
            this.btnSubirArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSubirArchivo.UseVisualStyleBackColor = false;
            this.btnSubirArchivo.Visible = false;
            this.btnSubirArchivo.Click += new System.EventHandler(this.btnSubirArchivo_Click);
            // 
            // lblLlavePago
            // 
            this.lblLlavePago.AutoSize = true;
            this.lblLlavePago.Location = new System.Drawing.Point(879, 165);
            this.lblLlavePago.Name = "lblLlavePago";
            this.lblLlavePago.Size = new System.Drawing.Size(79, 13);
            this.lblLlavePago.TabIndex = 19;
            this.lblLlavePago.Text = "Llave de Pago:";
            // 
            // txbLlavePago
            // 
            this.txbLlavePago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbLlavePago.Location = new System.Drawing.Point(964, 158);
            this.txbLlavePago.Name = "txbLlavePago";
            this.txbLlavePago.Size = new System.Drawing.Size(217, 20);
            this.txbLlavePago.TabIndex = 18;
            // 
            // lblNumOperacion
            // 
            this.lblNumOperacion.AutoSize = true;
            this.lblNumOperacion.Location = new System.Drawing.Point(859, 138);
            this.lblNumOperacion.Name = "lblNumOperacion";
            this.lblNumOperacion.Size = new System.Drawing.Size(99, 13);
            this.lblNumOperacion.TabIndex = 17;
            this.lblNumOperacion.Text = "Número Operación:";
            // 
            // txtImporte
            // 
            this.txtImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtImporte.Location = new System.Drawing.Point(625, 295);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(217, 20);
            this.txtImporte.TabIndex = 16;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // txbNumOperacion
            // 
            this.txbNumOperacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbNumOperacion.Location = new System.Drawing.Point(964, 132);
            this.txbNumOperacion.Name = "txbNumOperacion";
            this.txbNumOperacion.Size = new System.Drawing.Size(217, 20);
            this.txbNumOperacion.TabIndex = 16;
            // 
            // lblDecTipo
            // 
            this.lblDecTipo.AutoSize = true;
            this.lblDecTipo.Location = new System.Drawing.Point(867, 81);
            this.lblDecTipo.Name = "lblDecTipo";
            this.lblDecTipo.Size = new System.Drawing.Size(91, 13);
            this.lblDecTipo.TabIndex = 15;
            this.lblDecTipo.Text = "Declaración Tipo:";
            // 
            // btnAgregarConcepto
            // 
            this.btnAgregarConcepto.BackColor = System.Drawing.Color.Gray;
            this.btnAgregarConcepto.FlatAppearance.BorderSize = 0;
            this.btnAgregarConcepto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.btnAgregarConcepto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.btnAgregarConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarConcepto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarConcepto.Location = new System.Drawing.Point(780, 321);
            this.btnAgregarConcepto.Name = "btnAgregarConcepto";
            this.btnAgregarConcepto.Size = new System.Drawing.Size(62, 23);
            this.btnAgregarConcepto.TabIndex = 13;
            this.btnAgregarConcepto.Text = "Agregar";
            this.btnAgregarConcepto.UseVisualStyleBackColor = false;
            this.btnAgregarConcepto.Click += new System.EventHandler(this.btnAgregarConcepto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(991, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(1105, 385);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Importe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Concepto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Estado Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha Límite Pago:";
            // 
            // dpFechaPago
            // 
            this.dpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaPago.Location = new System.Drawing.Point(676, 156);
            this.dpFechaPago.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dpFechaPago.Name = "dpFechaPago";
            this.dpFechaPago.Size = new System.Drawing.Size(166, 20);
            this.dpFechaPago.TabIndex = 8;
            // 
            // txbLCaptura
            // 
            this.txbLCaptura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbLCaptura.Location = new System.Drawing.Point(964, 184);
            this.txbLCaptura.MaxLength = 250;
            this.txbLCaptura.Multiline = true;
            this.txbLCaptura.Name = "txbLCaptura";
            this.txbLCaptura.Size = new System.Drawing.Size(217, 41);
            this.txbLCaptura.TabIndex = 5;
            // 
            // lblLCaptura
            // 
            this.lblLCaptura.AutoSize = true;
            this.lblLCaptura.Location = new System.Drawing.Point(867, 191);
            this.lblLCaptura.Margin = new System.Windows.Forms.Padding(3);
            this.lblLCaptura.Name = "lblLCaptura";
            this.lblLCaptura.Size = new System.Drawing.Size(93, 13);
            this.lblLCaptura.TabIndex = 4;
            this.lblLCaptura.Text = "Línea de Captura:";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(912, 108);
            this.lblPeriodo.Margin = new System.Windows.Forms.Padding(3);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(46, 13);
            this.lblPeriodo.TabIndex = 2;
            this.lblPeriodo.Text = "Periodo:";
            // 
            // gbBuscarCliente
            // 
            this.gbBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBuscarCliente.Controls.Add(this.btnBuscar);
            this.gbBuscarCliente.Controls.Add(this.txbRfc);
            this.gbBuscarCliente.Controls.Add(this.lblRfc);
            this.gbBuscarCliente.Controls.Add(this.lblOtro);
            this.gbBuscarCliente.Controls.Add(this.txbNCliente);
            this.gbBuscarCliente.Controls.Add(this.lblNCliente);
            this.gbBuscarCliente.Controls.Add(this.lblBuscarCliente);
            this.gbBuscarCliente.Location = new System.Drawing.Point(-1, 74);
            this.gbBuscarCliente.Name = "gbBuscarCliente";
            this.gbBuscarCliente.Size = new System.Drawing.Size(609, 197);
            this.gbBuscarCliente.TabIndex = 89;
            this.gbBuscarCliente.TabStop = false;
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCliente.ForeColor = System.Drawing.Color.Red;
            this.lblBuscarCliente.Location = new System.Drawing.Point(125, 158);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(134, 13);
            this.lblBuscarCliente.TabIndex = 7;
            this.lblBuscarCliente.Text = "* Cliente no encontrado.";
            this.lblBuscarCliente.Visible = false;
            // 
            // gbCliente
            // 
            this.gbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCliente.Controls.Add(this.txbEMail);
            this.gbCliente.Controls.Add(this.lblCorreoE);
            this.gbCliente.Controls.Add(this.txbNombre);
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.lblCActivo);
            this.gbCliente.Controls.Add(this.btnNDeclracion);
            this.gbCliente.Location = new System.Drawing.Point(596, 74);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(613, 197);
            this.gbCliente.TabIndex = 91;
            this.gbCliente.TabStop = false;
            // 
            // lblCActivo
            // 
            this.lblCActivo.AutoSize = true;
            this.lblCActivo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCActivo.ForeColor = System.Drawing.Color.Red;
            this.lblCActivo.Location = new System.Drawing.Point(52, 164);
            this.lblCActivo.Name = "lblCActivo";
            this.lblCActivo.Size = new System.Drawing.Size(104, 13);
            this.lblCActivo.TabIndex = 14;
            this.lblCActivo.Text = "* Cliente no activo.";
            this.lblCActivo.Visible = false;
            // 
            // btnNDeclracion
            // 
            this.btnNDeclracion.BackColor = System.Drawing.Color.Gray;
            this.btnNDeclracion.Enabled = false;
            this.btnNDeclracion.FlatAppearance.BorderSize = 0;
            this.btnNDeclracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.btnNDeclracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.btnNDeclracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNDeclracion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNDeclracion.Location = new System.Drawing.Point(393, 152);
            this.btnNDeclracion.Name = "btnNDeclracion";
            this.btnNDeclracion.Size = new System.Drawing.Size(114, 23);
            this.btnNDeclracion.TabIndex = 4;
            this.btnNDeclracion.Text = "Generar Declaración";
            this.btnNDeclracion.UseVisualStyleBackColor = false;
            this.btnNDeclracion.Click += new System.EventHandler(this.btnNDeclracion_Click);
            // 
            // openFileDialogDocumento
            // 
            this.openFileDialogDocumento.FileName = "openFileDialog1";
            // 
            // MensajeError
            // 
            this.MensajeError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.MensajeError.ContainerControl = this;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoEllipsis = true;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(27, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(460, 22);
            this.lblFecha.TabIndex = 222;
            this.lblFecha.Text = "Realiza el alta de declaraciones complementarias de un cliente.\r\n";
            // 
            // lblNCliente
            // 
            this.lblNCliente.AutoSize = true;
            this.lblNCliente.Depth = 0;
            this.lblNCliente.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblNCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNCliente.Location = new System.Drawing.Point(125, 16);
            this.lblNCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNCliente.Name = "lblNCliente";
            this.lblNCliente.Size = new System.Drawing.Size(134, 19);
            this.lblNCliente.TabIndex = 8;
            this.lblNCliente.Text = "Número de Cliente";
            // 
            // txbNCliente
            // 
            this.txbNCliente.Depth = 0;
            this.txbNCliente.Hint = "";
            this.txbNCliente.Location = new System.Drawing.Point(129, 38);
            this.txbNCliente.MaxLength = 32767;
            this.txbNCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbNCliente.Name = "txbNCliente";
            this.txbNCliente.PasswordChar = '\0';
            this.txbNCliente.SelectedText = "";
            this.txbNCliente.SelectionLength = 0;
            this.txbNCliente.SelectionStart = 0;
            this.txbNCliente.Size = new System.Drawing.Size(242, 25);
            this.txbNCliente.TabIndex = 9;
            this.txbNCliente.TabStop = false;
            this.txbNCliente.UseSystemPasswordChar = false;
            // 
            // lblOtro
            // 
            this.lblOtro.AutoSize = true;
            this.lblOtro.Depth = 0;
            this.lblOtro.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblOtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOtro.Location = new System.Drawing.Point(124, 71);
            this.lblOtro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOtro.Name = "lblOtro";
            this.lblOtro.Size = new System.Drawing.Size(18, 19);
            this.lblOtro.TabIndex = 10;
            this.lblOtro.Text = "o";
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.Depth = 0;
            this.lblRfc.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblRfc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRfc.Location = new System.Drawing.Point(125, 101);
            this.lblRfc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(36, 19);
            this.lblRfc.TabIndex = 11;
            this.lblRfc.Text = "RFC";
            // 
            // txbRfc
            // 
            this.txbRfc.Depth = 0;
            this.txbRfc.Hint = "";
            this.txbRfc.Location = new System.Drawing.Point(129, 123);
            this.txbRfc.MaxLength = 32767;
            this.txbRfc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbRfc.Name = "txbRfc";
            this.txbRfc.PasswordChar = '\0';
            this.txbRfc.SelectedText = "";
            this.txbRfc.SelectionLength = 0;
            this.txbRfc.SelectionStart = 0;
            this.txbRfc.Size = new System.Drawing.Size(242, 25);
            this.txbRfc.TabIndex = 12;
            this.txbRfc.TabStop = false;
            this.txbRfc.UseSystemPasswordChar = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::LxCallcenter.Properties.Resources.find_user_male_48px;
            this.btnBuscar.ImageSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(387, 87);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoFocusImage = global::LxCallcenter.Properties.Resources.find_user_male_48px;
            this.btnBuscar.Size = new System.Drawing.Size(21, 21);
            this.btnBuscar.TabIndex = 13;
            this.metroToolTip1.SetToolTip(this.btnBuscar, "Buscar Cliente");
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(51, 22);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 19);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // txbNombre
            // 
            this.txbNombre.Depth = 0;
            this.txbNombre.Enabled = false;
            this.txbNombre.Hint = "";
            this.txbNombre.Location = new System.Drawing.Point(55, 44);
            this.txbNombre.MaxLength = 32767;
            this.txbNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.PasswordChar = '\0';
            this.txbNombre.SelectedText = "";
            this.txbNombre.SelectionLength = 0;
            this.txbNombre.SelectionStart = 0;
            this.txbNombre.Size = new System.Drawing.Size(286, 25);
            this.txbNombre.TabIndex = 16;
            this.txbNombre.TabStop = false;
            this.txbNombre.UseSystemPasswordChar = false;
            // 
            // lblCorreoE
            // 
            this.lblCorreoE.AutoSize = true;
            this.lblCorreoE.Depth = 0;
            this.lblCorreoE.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblCorreoE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCorreoE.Location = new System.Drawing.Point(51, 107);
            this.lblCorreoE.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCorreoE.Name = "lblCorreoE";
            this.lblCorreoE.Size = new System.Drawing.Size(51, 19);
            this.lblCorreoE.TabIndex = 17;
            this.lblCorreoE.Text = "E-mail";
            // 
            // txbEMail
            // 
            this.txbEMail.Depth = 0;
            this.txbEMail.Enabled = false;
            this.txbEMail.Hint = "";
            this.txbEMail.Location = new System.Drawing.Point(55, 129);
            this.txbEMail.MaxLength = 32767;
            this.txbEMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbEMail.Name = "txbEMail";
            this.txbEMail.PasswordChar = '\0';
            this.txbEMail.SelectedText = "";
            this.txbEMail.SelectionLength = 0;
            this.txbEMail.SelectionStart = 0;
            this.txbEMail.Size = new System.Drawing.Size(286, 25);
            this.txbEMail.TabIndex = 18;
            this.txbEMail.TabStop = false;
            this.txbEMail.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(-1, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 22);
            this.panel1.TabIndex = 223;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Depth = 0;
            this.lblAño.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblAño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAño.Location = new System.Drawing.Point(118, 28);
            this.lblAño.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(138, 19);
            this.lblAño.TabIndex = 123;
            this.lblAño.Text = "Año de declaración";
            // 
            // lblFPresentacion
            // 
            this.lblFPresentacion.AutoSize = true;
            this.lblFPresentacion.Depth = 0;
            this.lblFPresentacion.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblFPresentacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFPresentacion.Location = new System.Drawing.Point(118, 82);
            this.lblFPresentacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFPresentacion.Name = "lblFPresentacion";
            this.lblFPresentacion.Size = new System.Drawing.Size(142, 19);
            this.lblFPresentacion.TabIndex = 124;
            this.lblFPresentacion.Text = "Fecha Presentación";
            // 
            // dpFPresentacion
            // 
            this.dpFPresentacion.Location = new System.Drawing.Point(122, 104);
            this.dpFPresentacion.MinimumSize = new System.Drawing.Size(0, 29);
            this.dpFPresentacion.Name = "dpFPresentacion";
            this.dpFPresentacion.Size = new System.Drawing.Size(166, 29);
            this.dpFPresentacion.TabIndex = 125;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(118, 143);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(53, 19);
            this.materialLabel1.TabIndex = 126;
            this.materialLabel1.Text = "Monto";
            // 
            // txbMonto
            // 
            this.txbMonto.Depth = 0;
            this.txbMonto.Hint = "";
            this.txbMonto.Location = new System.Drawing.Point(122, 163);
            this.txbMonto.MaxLength = 32767;
            this.txbMonto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.PasswordChar = '\0';
            this.txbMonto.SelectedText = "";
            this.txbMonto.SelectionLength = 0;
            this.txbMonto.SelectionStart = 0;
            this.txbMonto.Size = new System.Drawing.Size(166, 25);
            this.txbMonto.TabIndex = 127;
            this.txbMonto.TabStop = false;
            this.txbMonto.UseSystemPasswordChar = false;
            // 
            // frmDeclaracionComplementaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1207, 713);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbDeclaracion);
            this.Controls.Add(this.gbBuscarCliente);
            this.Controls.Add(this.label4);
            this.Name = "frmDeclaracionComplementaria";
            this.Text = "frmDeclaracionComplementaria";
            this.gbDeclaracion.ResumeLayout(false);
            this.gbDeclaracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConceptos)).EndInit();
            this.gbBuscarCliente.ResumeLayout(false);
            this.gbBuscarCliente.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbDeclaracion;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Button btnSubirArchivo;
        private System.Windows.Forms.Label lblLlavePago;
        private System.Windows.Forms.TextBox txbLlavePago;
        private System.Windows.Forms.Label lblNumOperacion;
        private System.Windows.Forms.TextBox txbNumOperacion;
        private System.Windows.Forms.Label lblDecTipo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpFechaPago;
        private System.Windows.Forms.TextBox txbLCaptura;
        private System.Windows.Forms.Label lblLCaptura;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.GroupBox gbBuscarCliente;
        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblCActivo;
        private System.Windows.Forms.Button btnNDeclracion;
        private System.Windows.Forms.OpenFileDialog openFileDialogDocumento;
        public System.Windows.Forms.ErrorProvider MensajeError;
        private MetroFramework.Controls.MetroComboBox cmbxAnioDeclaracion;
        private MetroFramework.Controls.MetroComboBox cbEstadoPago;
        private MetroFramework.Controls.MetroComboBox cbDecTipo;
        private MetroFramework.Controls.MetroComboBox cbPeriodo;
        private MetroFramework.Controls.MetroComboBox cmbxConcepto;
        private MetroFramework.Controls.MetroGrid grdConceptos;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lblFecha;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbNCliente;
        private MaterialSkin.Controls.MaterialLabel lblNCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbRfc;
        private MaterialSkin.Controls.MaterialLabel lblRfc;
        private MaterialSkin.Controls.MaterialLabel lblOtro;
        private MetroFramework.Controls.MetroLink btnBuscar;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbEMail;
        private MaterialSkin.Controls.MaterialLabel lblCorreoE;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbNombre;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lblAño;
        private MaterialSkin.Controls.MaterialLabel lblFPresentacion;
        private MetroFramework.Controls.MetroDateTime dpFPresentacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbMonto;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}