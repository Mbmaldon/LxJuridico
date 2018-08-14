namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    partial class frmComisionesPago
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComisionesPago));
			DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
			this.lblFecha = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.pnlParcentaje = new System.Windows.Forms.Panel();
			this.btnCancelarPorcentaje = new System.Windows.Forms.Button();
			this.btnGuardarPorcentaje = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.txtPorcentaje = new MetroFramework.Controls.MetroTextBox();
			this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
			this.lnkCerrarPagoComisiones = new MetroFramework.Controls.MetroLink();
			this.pnlPagoComisiones = new System.Windows.Forms.Panel();
			this.btnComisionPagada = new LollipopButton();
			this.txtNoOperacionBancaria = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.dtFechaFactura = new MetroFramework.Controls.MetroDateTime();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.lblImporteTotal = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.lblNoFactura = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lblVendedor = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lblNoOperacion = new System.Windows.Forms.Label();
			this.lblTotalImporte = new System.Windows.Forms.Label();
			this.lblNoSemana = new System.Windows.Forms.Label();
			this.btnMostrarPagadas = new System.Windows.Forms.Button();
			this.cmbxNoSemana = new MetroFramework.Controls.MetroComboBox();
			this.cmbxMostrar = new MetroFramework.Controls.MetroComboBox();
			this.btnPagarTodas = new System.Windows.Forms.Button();
			this.btnExportar = new System.Windows.Forms.Button();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.IdOperacionComisionista = new DevExpress.XtraGrid.Columns.GridColumn();
			this.IdOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.IdVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.NombreVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.NoOperacionBancaria = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Importe = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Semana = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Pagado = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Ventas = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FacturaPagada = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FechaPago = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Porcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Comision = new DevExpress.XtraGrid.Columns.GridColumn();
			this.NoFactura = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FacPagada = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TipoComision = new DevExpress.XtraGrid.Columns.GridColumn();
			this.UsuarioTipo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
			this.NoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grdComisionistas = new DevExpress.XtraGrid.GridControl();
			this.label1 = new MaterialSkin.Controls.MaterialLabel();
			this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.label11 = new MaterialSkin.Controls.MaterialLabel();
			this.label95 = new MaterialSkin.Controls.MaterialLabel();
			this.label2 = new LollipopLabel();
			this.lblTotalComision = new LollipopLabel();
			this.label7 = new LollipopLabel();
			this.label5 = new LollipopLabel();
			this.lollipopLabel1 = new LollipopLabel();
			this.cmbxAño = new MetroFramework.Controls.MetroComboBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.panel6 = new System.Windows.Forms.Panel();
			this.pnlParcentaje.SuspendLayout();
			this.pnlPagoComisiones.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdComisionistas)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.lblFecha.Location = new System.Drawing.Point(32, 31);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(799, 22);
			this.lblFecha.TabIndex = 97;
			this.lblFecha.Text = "Verifica y controla el  pago de comisiones correspondientes a los ejecutivos, sup" +
    "ervisores y gerentes de ventas.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
			this.label4.Location = new System.Drawing.Point(28, -1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 33);
			this.label4.TabIndex = 96;
			this.label4.Text = "Comisiones";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Archivo Excel | *.xlsx";
			// 
			// pnlParcentaje
			// 
			this.pnlParcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlParcentaje.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pnlParcentaje.Controls.Add(this.btnCancelarPorcentaje);
			this.pnlParcentaje.Controls.Add(this.btnGuardarPorcentaje);
			this.pnlParcentaje.Controls.Add(this.label9);
			this.pnlParcentaje.Controls.Add(this.txtPorcentaje);
			this.pnlParcentaje.Location = new System.Drawing.Point(1236, 13);
			this.pnlParcentaje.Name = "pnlParcentaje";
			this.pnlParcentaje.Size = new System.Drawing.Size(12, 19);
			this.pnlParcentaje.TabIndex = 212;
			this.pnlParcentaje.Visible = false;
			// 
			// btnCancelarPorcentaje
			// 
			this.btnCancelarPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelarPorcentaje.BackColor = System.Drawing.Color.Gray;
			this.btnCancelarPorcentaje.FlatAppearance.BorderSize = 0;
			this.btnCancelarPorcentaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
			this.btnCancelarPorcentaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
			this.btnCancelarPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelarPorcentaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCancelarPorcentaje.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCancelarPorcentaje.Location = new System.Drawing.Point(-71, 37);
			this.btnCancelarPorcentaje.Name = "btnCancelarPorcentaje";
			this.btnCancelarPorcentaje.Size = new System.Drawing.Size(71, 21);
			this.btnCancelarPorcentaje.TabIndex = 212;
			this.btnCancelarPorcentaje.Text = "Cancelar";
			this.btnCancelarPorcentaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancelarPorcentaje.UseVisualStyleBackColor = false;
			this.btnCancelarPorcentaje.Click += new System.EventHandler(this.btnCancelarPorcentaje_Click);
			// 
			// btnGuardarPorcentaje
			// 
			this.btnGuardarPorcentaje.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnGuardarPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
			this.btnGuardarPorcentaje.FlatAppearance.BorderSize = 0;
			this.btnGuardarPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardarPorcentaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnGuardarPorcentaje.Location = new System.Drawing.Point(-2, 37);
			this.btnGuardarPorcentaje.Name = "btnGuardarPorcentaje";
			this.btnGuardarPorcentaje.Size = new System.Drawing.Size(99, 21);
			this.btnGuardarPorcentaje.TabIndex = 211;
			this.btnGuardarPorcentaje.Text = "Guardar";
			this.btnGuardarPorcentaje.UseVisualStyleBackColor = false;
			this.btnGuardarPorcentaje.Click += new System.EventHandler(this.btnGuardarPorcentaje_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label9.Location = new System.Drawing.Point(17, 15);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 19);
			this.label9.TabIndex = 210;
			this.label9.Text = "Porcentaje";
			// 
			// txtPorcentaje
			// 
			// 
			// 
			// 
			this.txtPorcentaje.CustomButton.Image = null;
			this.txtPorcentaje.CustomButton.Location = new System.Drawing.Point(120, 1);
			this.txtPorcentaje.CustomButton.Name = "";
			this.txtPorcentaje.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtPorcentaje.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPorcentaje.CustomButton.TabIndex = 1;
			this.txtPorcentaje.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPorcentaje.CustomButton.UseSelectable = true;
			this.txtPorcentaje.CustomButton.Visible = false;
			this.txtPorcentaje.Lines = new string[0];
			this.txtPorcentaje.Location = new System.Drawing.Point(20, 36);
			this.txtPorcentaje.MaxLength = 32767;
			this.txtPorcentaje.Name = "txtPorcentaje";
			this.txtPorcentaje.PasswordChar = '\0';
			this.txtPorcentaje.PromptText = "%";
			this.txtPorcentaje.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPorcentaje.SelectedText = "";
			this.txtPorcentaje.SelectionLength = 0;
			this.txtPorcentaje.SelectionStart = 0;
			this.txtPorcentaje.ShortcutsEnabled = true;
			this.txtPorcentaje.Size = new System.Drawing.Size(142, 23);
			this.txtPorcentaje.Style = MetroFramework.MetroColorStyle.Yellow;
			this.txtPorcentaje.TabIndex = 209;
			this.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtPorcentaje.UseSelectable = true;
			this.txtPorcentaje.WaterMark = "%";
			this.txtPorcentaje.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPorcentaje.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentaje_KeyPress);
			// 
			// metroToolTip1
			// 
			this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroToolTip1.StyleManager = null;
			this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// lnkCerrarPagoComisiones
			// 
			this.lnkCerrarPagoComisiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
			this.lnkCerrarPagoComisiones.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lnkCerrarPagoComisiones.Image = global::LxCallcenter.Properties.Resources.cancel_16px;
			this.lnkCerrarPagoComisiones.Location = new System.Drawing.Point(481, -3);
			this.lnkCerrarPagoComisiones.Name = "lnkCerrarPagoComisiones";
			this.lnkCerrarPagoComisiones.Size = new System.Drawing.Size(18, 20);
			this.lnkCerrarPagoComisiones.TabIndex = 201;
			this.metroToolTip1.SetToolTip(this.lnkCerrarPagoComisiones, "Cerrar");
			this.lnkCerrarPagoComisiones.UseCustomBackColor = true;
			this.lnkCerrarPagoComisiones.UseSelectable = true;
			this.lnkCerrarPagoComisiones.Click += new System.EventHandler(this.lnkCerrarPagoComisiones_Click);
			// 
			// pnlPagoComisiones
			// 
			this.pnlPagoComisiones.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlPagoComisiones.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pnlPagoComisiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlPagoComisiones.Controls.Add(this.btnComisionPagada);
			this.pnlPagoComisiones.Controls.Add(this.txtNoOperacionBancaria);
			this.pnlPagoComisiones.Controls.Add(this.dtFechaFactura);
			this.pnlPagoComisiones.Controls.Add(this.label17);
			this.pnlPagoComisiones.Controls.Add(this.label18);
			this.pnlPagoComisiones.Controls.Add(this.lblImporteTotal);
			this.pnlPagoComisiones.Controls.Add(this.label16);
			this.pnlPagoComisiones.Controls.Add(this.lblNoFactura);
			this.pnlPagoComisiones.Controls.Add(this.label12);
			this.pnlPagoComisiones.Controls.Add(this.lblVendedor);
			this.pnlPagoComisiones.Controls.Add(this.label6);
			this.pnlPagoComisiones.Controls.Add(this.panel1);
			this.pnlPagoComisiones.Controls.Add(this.panel3);
			this.pnlPagoComisiones.Controls.Add(this.panel4);
			this.pnlPagoComisiones.Location = new System.Drawing.Point(370, 259);
			this.pnlPagoComisiones.Name = "pnlPagoComisiones";
			this.pnlPagoComisiones.Size = new System.Drawing.Size(504, 303);
			this.pnlPagoComisiones.TabIndex = 206;
			this.pnlPagoComisiones.Visible = false;
			this.pnlPagoComisiones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPagoComisiones_MouseDown);
			this.pnlPagoComisiones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPagoComisiones_MouseMove);
			// 
			// btnComisionPagada
			// 
			this.btnComisionPagada.BackColor = System.Drawing.Color.Transparent;
			this.btnComisionPagada.BGColor = "#001489";
			this.btnComisionPagada.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnComisionPagada.FontColor = "#ffffff";
			this.btnComisionPagada.Location = new System.Drawing.Point(347, 256);
			this.btnComisionPagada.Name = "btnComisionPagada";
			this.btnComisionPagada.Size = new System.Drawing.Size(111, 27);
			this.btnComisionPagada.TabIndex = 214;
			this.btnComisionPagada.Text = "Comisión Pagada";
			this.btnComisionPagada.Click += new System.EventHandler(this.btnComisionPagada_Click);
			// 
			// txtNoOperacionBancaria
			// 
			this.txtNoOperacionBancaria.Depth = 0;
			this.txtNoOperacionBancaria.Hint = "";
			this.txtNoOperacionBancaria.Location = new System.Drawing.Point(263, 209);
			this.txtNoOperacionBancaria.MaxLength = 32767;
			this.txtNoOperacionBancaria.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtNoOperacionBancaria.Name = "txtNoOperacionBancaria";
			this.txtNoOperacionBancaria.PasswordChar = '\0';
			this.txtNoOperacionBancaria.SelectedText = "";
			this.txtNoOperacionBancaria.SelectionLength = 0;
			this.txtNoOperacionBancaria.SelectionStart = 0;
			this.txtNoOperacionBancaria.Size = new System.Drawing.Size(195, 23);
			this.txtNoOperacionBancaria.TabIndex = 213;
			this.txtNoOperacionBancaria.TabStop = false;
			this.txtNoOperacionBancaria.UseSystemPasswordChar = false;
			this.txtNoOperacionBancaria.Visible = false;
			// 
			// dtFechaFactura
			// 
			this.dtFechaFactura.Location = new System.Drawing.Point(27, 203);
			this.dtFechaFactura.MinimumSize = new System.Drawing.Size(0, 29);
			this.dtFechaFactura.Name = "dtFechaFactura";
			this.dtFechaFactura.Size = new System.Drawing.Size(196, 29);
			this.dtFechaFactura.Style = MetroFramework.MetroColorStyle.Teal;
			this.dtFechaFactura.TabIndex = 211;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.label17.ForeColor = System.Drawing.Color.DimGray;
			this.label17.Location = new System.Drawing.Point(259, 179);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(199, 22);
			this.label17.TabIndex = 210;
			this.label17.Text = "No. de Operación Bancaria";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label17.Visible = false;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.label18.ForeColor = System.Drawing.Color.DimGray;
			this.label18.Location = new System.Drawing.Point(23, 179);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(112, 22);
			this.label18.TabIndex = 210;
			this.label18.Text = "Fecha de pago";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblImporteTotal
			// 
			this.lblImporteTotal.AutoSize = true;
			this.lblImporteTotal.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.lblImporteTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
			this.lblImporteTotal.Location = new System.Drawing.Point(259, 146);
			this.lblImporteTotal.Name = "lblImporteTotal";
			this.lblImporteTotal.Size = new System.Drawing.Size(32, 22);
			this.lblImporteTotal.TabIndex = 209;
			this.lblImporteTotal.Text = "$ --";
			this.lblImporteTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.label16.ForeColor = System.Drawing.Color.DimGray;
			this.label16.Location = new System.Drawing.Point(259, 124);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(105, 22);
			this.label16.TabIndex = 208;
			this.label16.Text = "Importe Total";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNoFactura
			// 
			this.lblNoFactura.AutoSize = true;
			this.lblNoFactura.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.lblNoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
			this.lblNoFactura.Location = new System.Drawing.Point(23, 146);
			this.lblNoFactura.Name = "lblNoFactura";
			this.lblNoFactura.Size = new System.Drawing.Size(200, 22);
			this.lblNoFactura.TabIndex = 207;
			this.lblNoFactura.Text = "QWERTYUIOP1234567890";
			this.lblNoFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.label12.ForeColor = System.Drawing.Color.DimGray;
			this.label12.Location = new System.Drawing.Point(23, 124);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(91, 22);
			this.label12.TabIndex = 206;
			this.label12.Text = "No. Factura";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblVendedor
			// 
			this.lblVendedor.AutoSize = true;
			this.lblVendedor.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.lblVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
			this.lblVendedor.Location = new System.Drawing.Point(23, 85);
			this.lblVendedor.Name = "lblVendedor";
			this.lblVendedor.Size = new System.Drawing.Size(163, 22);
			this.lblVendedor.TabIndex = 205;
			this.lblVendedor.Text = "Nombre de Vendedor";
			this.lblVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri Light", 13F);
			this.label6.ForeColor = System.Drawing.Color.DimGray;
			this.label6.Location = new System.Drawing.Point(23, 63);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 22);
			this.label6.TabIndex = 204;
			this.label6.Text = "Vendedor";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.panel1.Location = new System.Drawing.Point(11, 55);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(482, 1);
			this.panel1.TabIndex = 203;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
			this.panel3.Controls.Add(this.lnkCerrarPagoComisiones);
			this.panel3.Location = new System.Drawing.Point(-1, -1);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(503, 16);
			this.panel3.TabIndex = 215;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
			this.panel4.Controls.Add(this.lblNoOperacion);
			this.panel4.Location = new System.Drawing.Point(-1, 14);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(503, 33);
			this.panel4.TabIndex = 216;
			// 
			// lblNoOperacion
			// 
			this.lblNoOperacion.AutoSize = true;
			this.lblNoOperacion.BackColor = System.Drawing.Color.Transparent;
			this.lblNoOperacion.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNoOperacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblNoOperacion.Location = new System.Drawing.Point(166, 2);
			this.lblNoOperacion.Name = "lblNoOperacion";
			this.lblNoOperacion.Size = new System.Drawing.Size(167, 27);
			this.lblNoOperacion.TabIndex = 96;
			this.lblNoOperacion.Text = "Pago de Comisión";
			this.lblNoOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTotalImporte
			// 
			this.lblTotalImporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblTotalImporte.AutoSize = true;
			this.lblTotalImporte.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
			this.lblTotalImporte.Location = new System.Drawing.Point(965, 24);
			this.lblTotalImporte.Name = "lblTotalImporte";
			this.lblTotalImporte.Size = new System.Drawing.Size(33, 19);
			this.lblTotalImporte.TabIndex = 111;
			this.lblTotalImporte.Text = "$ --";
			this.lblTotalImporte.Visible = false;
			// 
			// lblNoSemana
			// 
			this.lblNoSemana.AutoSize = true;
			this.lblNoSemana.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNoSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
			this.lblNoSemana.Location = new System.Drawing.Point(721, 30);
			this.lblNoSemana.Name = "lblNoSemana";
			this.lblNoSemana.Size = new System.Drawing.Size(22, 25);
			this.lblNoSemana.TabIndex = 115;
			this.lblNoSemana.Text = "0";
			// 
			// btnMostrarPagadas
			// 
			this.btnMostrarPagadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMostrarPagadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
			this.btnMostrarPagadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnMostrarPagadas.FlatAppearance.BorderSize = 0;
			this.btnMostrarPagadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
			this.btnMostrarPagadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
			this.btnMostrarPagadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMostrarPagadas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnMostrarPagadas.Image = global::LxCallcenter.Properties.Resources.refund_16px;
			this.btnMostrarPagadas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnMostrarPagadas.Location = new System.Drawing.Point(1173, 42);
			this.btnMostrarPagadas.Name = "btnMostrarPagadas";
			this.btnMostrarPagadas.Size = new System.Drawing.Size(0, 0);
			this.btnMostrarPagadas.TabIndex = 203;
			this.btnMostrarPagadas.Text = "Pagar Seleccionada";
			this.btnMostrarPagadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnMostrarPagadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMostrarPagadas.UseVisualStyleBackColor = false;
			this.btnMostrarPagadas.Visible = false;
			this.btnMostrarPagadas.Click += new System.EventHandler(this.btnMostrarPagadas_Click);
			// 
			// cmbxNoSemana
			// 
			this.cmbxNoSemana.FormattingEnabled = true;
			this.cmbxNoSemana.ItemHeight = 23;
			this.cmbxNoSemana.Location = new System.Drawing.Point(841, 46);
			this.cmbxNoSemana.Name = "cmbxNoSemana";
			this.cmbxNoSemana.Size = new System.Drawing.Size(84, 29);
			this.cmbxNoSemana.Style = MetroFramework.MetroColorStyle.Purple;
			this.cmbxNoSemana.TabIndex = 204;
			this.cmbxNoSemana.UseSelectable = true;
			this.cmbxNoSemana.SelectionChangeCommitted += new System.EventHandler(this.cmbxNoSemana_SelectionChangeCommitted);
			// 
			// cmbxMostrar
			// 
			this.cmbxMostrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cmbxMostrar.FormattingEnabled = true;
			this.cmbxMostrar.ItemHeight = 23;
			this.cmbxMostrar.Items.AddRange(new object[] {
            "Todos",
            "Vendedores",
            "Supervisores",
            "Gerentes"});
			this.cmbxMostrar.Location = new System.Drawing.Point(1159, 10);
			this.cmbxMostrar.Name = "cmbxMostrar";
			this.cmbxMostrar.Size = new System.Drawing.Size(28, 29);
			this.cmbxMostrar.Style = MetroFramework.MetroColorStyle.Yellow;
			this.cmbxMostrar.TabIndex = 206;
			this.cmbxMostrar.UseSelectable = true;
			this.cmbxMostrar.Visible = false;
			this.cmbxMostrar.SelectionChangeCommitted += new System.EventHandler(this.cmbxMostrar_SelectionChangeCommitted);
			// 
			// btnPagarTodas
			// 
			this.btnPagarTodas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPagarTodas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
			this.btnPagarTodas.FlatAppearance.BorderSize = 0;
			this.btnPagarTodas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
			this.btnPagarTodas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(82)))), ((int)(((byte)(154)))));
			this.btnPagarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPagarTodas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnPagarTodas.Image = global::LxCallcenter.Properties.Resources.Payments_01_WF;
			this.btnPagarTodas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnPagarTodas.Location = new System.Drawing.Point(1234, 42);
			this.btnPagarTodas.Name = "btnPagarTodas";
			this.btnPagarTodas.Size = new System.Drawing.Size(0, 0);
			this.btnPagarTodas.TabIndex = 207;
			this.btnPagarTodas.Text = "Pagar Todas";
			this.btnPagarTodas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPagarTodas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPagarTodas.UseVisualStyleBackColor = false;
			this.btnPagarTodas.Visible = false;
			this.btnPagarTodas.Click += new System.EventHandler(this.btnPagarTodas_Click);
			// 
			// btnExportar
			// 
			this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(71)))));
			this.btnExportar.FlatAppearance.BorderSize = 0;
			this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(80)))), ((int)(((byte)(71)))));
			this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(100)))), ((int)(((byte)(71)))));
			this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnExportar.Image = global::LxCallcenter.Properties.Resources.Excel_Export;
			this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnExportar.Location = new System.Drawing.Point(1202, 42);
			this.btnExportar.Name = "btnExportar";
			this.btnExportar.Size = new System.Drawing.Size(0, 0);
			this.btnExportar.TabIndex = 205;
			this.btnExportar.Text = "Exportar";
			this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExportar.UseVisualStyleBackColor = false;
			this.btnExportar.Visible = false;
			this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
			// 
			// gridView1
			// 
			this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
			this.gridView1.Appearance.FixedLine.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
			this.gridView1.Appearance.FixedLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
			this.gridView1.Appearance.FixedLine.ForeColor = System.Drawing.Color.White;
			this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
			this.gridView1.Appearance.FixedLine.Options.UseBorderColor = true;
			this.gridView1.Appearance.FixedLine.Options.UseForeColor = true;
			this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.gridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.gridView1.Appearance.GroupPanel.BorderColor = System.Drawing.Color.White;
			this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
			this.gridView1.Appearance.GroupPanel.Options.UseBorderColor = true;
			this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
			this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
			this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
			this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
			this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
			this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
			this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
			this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
			this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdOperacionComisionista,
            this.IdOperacion,
            this.IdVendedor,
            this.NombreVendedor,
            this.NoOperacionBancaria,
            this.Importe,
            this.Semana,
            this.Pagado,
            this.Ventas,
            this.FacturaPagada,
            this.FechaPago,
            this.Porcentaje,
            this.Comision,
            this.NoFactura,
            this.FacPagada,
            this.TipoComision,
            this.UsuarioTipo,
            this.gridColumn1,
            this.TUsuario,
            this.FechaFactura,
            this.NoCuenta});
			this.gridView1.GridControl = this.grdComisionistas;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.Editable = false;
			this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
			this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
			this.gridView1.OptionsMenu.EnableFooterMenu = false;
			this.gridView1.OptionsView.ColumnAutoWidth = false;
			this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
			this.gridView1.OptionsView.RowAutoHeight = true;
			this.gridView1.OptionsView.ShowFooter = true;
			this.gridView1.OptionsView.ShowIndicator = false;
			this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
			this.gridView1.PaintStyleName = "Web";
			this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
			this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
			// 
			// IdOperacionComisionista
			// 
			this.IdOperacionComisionista.Caption = "Id Operación Comisionista";
			this.IdOperacionComisionista.FieldName = "iIdOperacionComisionista";
			this.IdOperacionComisionista.Name = "IdOperacionComisionista";
			this.IdOperacionComisionista.OptionsColumn.AllowEdit = false;
			// 
			// IdOperacion
			// 
			this.IdOperacion.Caption = "Id Operación";
			this.IdOperacion.FieldName = "iIdOperacion";
			this.IdOperacion.Name = "IdOperacion";
			// 
			// IdVendedor
			// 
			this.IdVendedor.Caption = "Id Vendedor";
			this.IdVendedor.FieldName = "iIdVendedor";
			this.IdVendedor.Name = "IdVendedor";
			// 
			// NombreVendedor
			// 
			this.NombreVendedor.Caption = "Comisionista";
			this.NombreVendedor.FieldName = "sNombreVendedor";
			this.NombreVendedor.Name = "NombreVendedor";
			this.NombreVendedor.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.NombreVendedor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "sFechaDeposito", "TOTALES")});
			this.NombreVendedor.Visible = true;
			this.NombreVendedor.VisibleIndex = 0;
			// 
			// NoOperacionBancaria
			// 
			this.NoOperacionBancaria.Caption = "No. Operación Bancaria";
			this.NoOperacionBancaria.FieldName = "sNoOperacionBancaria";
			this.NoOperacionBancaria.Name = "NoOperacionBancaria";
			this.NoOperacionBancaria.Visible = true;
			this.NoOperacionBancaria.VisibleIndex = 9;
			// 
			// Importe
			// 
			this.Importe.Caption = "Importe";
			this.Importe.DisplayFormat.FormatString = "c2";
			this.Importe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.Importe.FieldName = "dImporte";
			this.Importe.Name = "Importe";
			this.Importe.Visible = true;
			this.Importe.VisibleIndex = 5;
			// 
			// Semana
			// 
			this.Semana.Caption = "Semana";
			this.Semana.FieldName = "iSemana";
			this.Semana.Name = "Semana";
			// 
			// Pagado
			// 
			this.Pagado.Caption = "Pagada";
			this.Pagado.FieldName = "sPagado";
			this.Pagado.Name = "Pagado";
			// 
			// Ventas
			// 
			this.Ventas.Caption = "Ventas";
			this.Ventas.FieldName = "iVentas";
			this.Ventas.Name = "Ventas";
			// 
			// FacturaPagada
			// 
			this.FacturaPagada.Caption = "Factura Pagada";
			this.FacturaPagada.FieldName = "sFacturaPagada";
			this.FacturaPagada.Name = "FacturaPagada";
			// 
			// FechaPago
			// 
			this.FechaPago.Caption = "Fecha de Pago";
			this.FechaPago.FieldName = "sFechaPago";
			this.FechaPago.Name = "FechaPago";
			this.FechaPago.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateAlt;
			this.FechaPago.Visible = true;
			this.FechaPago.VisibleIndex = 10;
			// 
			// Porcentaje
			// 
			this.Porcentaje.Caption = "Porcentaje Total";
			this.Porcentaje.DisplayFormat.FormatString = "P3";
			this.Porcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.Porcentaje.FieldName = "dPorcentaje";
			this.Porcentaje.Name = "Porcentaje";
			this.Porcentaje.UnboundExpression = resources.GetString("Porcentaje.UnboundExpression");
			this.Porcentaje.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.Porcentaje.Visible = true;
			this.Porcentaje.VisibleIndex = 7;
			// 
			// Comision
			// 
			this.Comision.Caption = "Comisión";
			this.Comision.DisplayFormat.FormatString = "c2";
			this.Comision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.Comision.FieldName = "dComision";
			this.Comision.Name = "Comision";
			this.Comision.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dComision", "{0:c2}")});
			this.Comision.UnboundExpression = "[dImporte] * [dPorcentaje]";
			this.Comision.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.Comision.Visible = true;
			this.Comision.VisibleIndex = 8;
			// 
			// NoFactura
			// 
			this.NoFactura.Caption = "No. de Factura";
			this.NoFactura.FieldName = "sNoFactura";
			this.NoFactura.Name = "NoFactura";
			this.NoFactura.Visible = true;
			this.NoFactura.VisibleIndex = 3;
			// 
			// FacPagada
			// 
			this.FacPagada.AppearanceCell.Options.UseTextOptions = true;
			this.FacPagada.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.FacPagada.Caption = "Factura Pagada";
			this.FacPagada.FieldName = "sFacPagada";
			this.FacPagada.Name = "FacPagada";
			this.FacPagada.UnboundExpression = "Iif([sFacturaPagada] = 1, \'SI\', \'NO\')";
			this.FacPagada.UnboundType = DevExpress.Data.UnboundColumnType.String;
			// 
			// TipoComision
			// 
			this.TipoComision.Caption = "Tipo de Comisión";
			this.TipoComision.FieldName = "sTipoComision";
			this.TipoComision.Name = "TipoComision";
			// 
			// UsuarioTipo
			// 
			this.UsuarioTipo.Caption = "Tipo de Usuario";
			this.UsuarioTipo.FieldName = "iIdTipoUsuario";
			this.UsuarioTipo.Name = "UsuarioTipo";
			// 
			// gridColumn1
			// 
			this.gridColumn1.AppearanceCell.ForeColor = System.Drawing.Color.White;
			this.gridColumn1.AppearanceCell.Options.UseForeColor = true;
			this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.gridColumn1.Caption = "Comisión Pagada";
			this.gridColumn1.FieldName = "sComPagada";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.UnboundExpression = "Iif([sPagado] = True, \'Si\', \'No\')";
			this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String;
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 6;
			// 
			// TUsuario
			// 
			this.TUsuario.Caption = "Tipo de Comisionista";
			this.TUsuario.FieldName = "sUTipo";
			this.TUsuario.Name = "TUsuario";
			this.TUsuario.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.TUsuario.Visible = true;
			this.TUsuario.VisibleIndex = 1;
			// 
			// FechaFactura
			// 
			this.FechaFactura.Caption = "Fecha de Factura";
			this.FechaFactura.FieldName = "sFechaFactura";
			this.FechaFactura.Name = "FechaFactura";
			this.FechaFactura.Visible = true;
			this.FechaFactura.VisibleIndex = 4;
			// 
			// NoCuenta
			// 
			this.NoCuenta.Caption = "No. Cuenta Comisionista";
			this.NoCuenta.FieldName = "sCuentaBancaria";
			this.NoCuenta.Name = "NoCuenta";
			this.NoCuenta.Visible = true;
			this.NoCuenta.VisibleIndex = 2;
			// 
			// grdComisionistas
			// 
			this.grdComisionistas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			gridLevelNode1.RelationName = "Level1";
			this.grdComisionistas.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
			this.grdComisionistas.Location = new System.Drawing.Point(15, 83);
			this.grdComisionistas.MainView = this.gridView1;
			this.grdComisionistas.Name = "grdComisionistas";
			this.grdComisionistas.Size = new System.Drawing.Size(1182, 414);
			this.grdComisionistas.TabIndex = 204;
			this.grdComisionistas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Depth = 0;
			this.label1.Font = new System.Drawing.Font("Roboto", 11F);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(16, 29);
			this.label1.MouseState = MaterialSkin.MouseState.HOVER;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 20);
			this.label1.TabIndex = 210;
			this.label1.Text = "Buscar";
			// 
			// txtBuscar
			// 
			this.txtBuscar.Depth = 0;
			this.txtBuscar.Hint = "Comisionista";
			this.txtBuscar.Location = new System.Drawing.Point(20, 52);
			this.txtBuscar.MaxLength = 32767;
			this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.PasswordChar = '\0';
			this.txtBuscar.SelectedText = "";
			this.txtBuscar.SelectionLength = 0;
			this.txtBuscar.SelectionStart = 0;
			this.txtBuscar.Size = new System.Drawing.Size(194, 23);
			this.txtBuscar.TabIndex = 213;
			this.txtBuscar.TabStop = false;
			this.txtBuscar.UseSystemPasswordChar = false;
			this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label11.AutoSize = true;
			this.label11.Depth = 0;
			this.label11.Font = new System.Drawing.Font("Roboto", 11F);
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label11.Location = new System.Drawing.Point(1095, 9);
			this.label11.MouseState = MaterialSkin.MouseState.HOVER;
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(62, 20);
			this.label11.TabIndex = 227;
			this.label11.Text = "Mostrar";
			this.label11.Visible = false;
			// 
			// label95
			// 
			this.label95.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label95.AutoSize = true;
			this.label95.Depth = 0;
			this.label95.Font = new System.Drawing.Font("Roboto", 11F);
			this.label95.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label95.Location = new System.Drawing.Point(955, 7);
			this.label95.MouseState = MaterialSkin.MouseState.HOVER;
			this.label95.Name = "label95";
			this.label95.Size = new System.Drawing.Size(128, 20);
			this.label95.TabIndex = 230;
			this.label95.Text = "Total de Ingresos";
			this.label95.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.label2.Location = new System.Drawing.Point(269, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 17);
			this.label2.TabIndex = 231;
			this.label2.Text = "Total de Comisiones";
			// 
			// lblTotalComision
			// 
			this.lblTotalComision.AutoSize = true;
			this.lblTotalComision.BackColor = System.Drawing.Color.Transparent;
			this.lblTotalComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblTotalComision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
			this.lblTotalComision.Location = new System.Drawing.Point(412, 36);
			this.lblTotalComision.Name = "lblTotalComision";
			this.lblTotalComision.Size = new System.Drawing.Size(30, 17);
			this.lblTotalComision.TabIndex = 232;
			this.lblTotalComision.Text = "$ --";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.label7.Location = new System.Drawing.Point(601, 34);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(121, 17);
			this.label7.TabIndex = 233;
			this.label7.Text = "Semana en Curso";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.label5.Location = new System.Drawing.Point(777, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 17);
			this.label5.TabIndex = 234;
			this.label5.Text = "Semana";
			// 
			// lollipopLabel1
			// 
			this.lollipopLabel1.AutoSize = true;
			this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
			this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.lollipopLabel1.Location = new System.Drawing.Point(776, 13);
			this.lollipopLabel1.Name = "lollipopLabel1";
			this.lollipopLabel1.Size = new System.Drawing.Size(33, 17);
			this.lollipopLabel1.TabIndex = 235;
			this.lollipopLabel1.Text = "Año";
			// 
			// cmbxAño
			// 
			this.cmbxAño.FormattingEnabled = true;
			this.cmbxAño.ItemHeight = 23;
			this.cmbxAño.Location = new System.Drawing.Point(841, 11);
			this.cmbxAño.Name = "cmbxAño";
			this.cmbxAño.Size = new System.Drawing.Size(84, 29);
			this.cmbxAño.Style = MetroFramework.MetroColorStyle.Purple;
			this.cmbxAño.TabIndex = 236;
			this.cmbxAño.UseSelectable = true;
			this.cmbxAño.SelectionChangeCommitted += new System.EventHandler(this.cmbxAño_SelectionChangeCommitted);
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel5.Controls.Add(this.panel2);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.lblFecha);
			this.panel5.Controls.Add(this.pnlParcentaje);
			this.panel5.Location = new System.Drawing.Point(-2, -1);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1278, 57);
			this.panel5.TabIndex = 237;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 56);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1278, 1);
			this.panel2.TabIndex = 227;
			// 
			// panelControl1
			// 
			this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelControl1.Controls.Add(this.panel6);
			this.panelControl1.Location = new System.Drawing.Point(28, 74);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1215, 514);
			this.panelControl1.TabIndex = 238;
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel6.Controls.Add(this.label1);
			this.panel6.Controls.Add(this.cmbxAño);
			this.panel6.Controls.Add(this.grdComisionistas);
			this.panel6.Controls.Add(this.lollipopLabel1);
			this.panel6.Controls.Add(this.lblTotalImporte);
			this.panel6.Controls.Add(this.label5);
			this.panel6.Controls.Add(this.lblNoSemana);
			this.panel6.Controls.Add(this.label7);
			this.panel6.Controls.Add(this.cmbxNoSemana);
			this.panel6.Controls.Add(this.lblTotalComision);
			this.panel6.Controls.Add(this.cmbxMostrar);
			this.panel6.Controls.Add(this.label2);
			this.panel6.Controls.Add(this.txtBuscar);
			this.panel6.Controls.Add(this.label95);
			this.panel6.Controls.Add(this.label11);
			this.panel6.Location = new System.Drawing.Point(2, 2);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(1211, 510);
			this.panel6.TabIndex = 0;
			// 
			// frmComisionesPago
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
			this.ClientSize = new System.Drawing.Size(1271, 612);
			this.Controls.Add(this.pnlPagoComisiones);
			this.Controls.Add(this.btnPagarTodas);
			this.Controls.Add(this.btnExportar);
			this.Controls.Add(this.btnMostrarPagadas);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panelControl1);
			this.Name = "frmComisionesPago";
			this.Text = "frmComisionesPago";
			this.Load += new System.EventHandler(this.frmComisionesPago_Load);
			this.pnlParcentaje.ResumeLayout(false);
			this.pnlParcentaje.PerformLayout();
			this.pnlPagoComisiones.ResumeLayout(false);
			this.pnlPagoComisiones.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdComisionistas)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel pnlParcentaje;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox txtPorcentaje;
        private System.Windows.Forms.Button btnCancelarPorcentaje;
        private System.Windows.Forms.Button btnGuardarPorcentaje;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Panel pnlPagoComisiones;
        private MetroFramework.Controls.MetroDateTime dtFechaFactura;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblNoFactura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLink lnkCerrarPagoComisiones;
        private System.Windows.Forms.Label lblNoOperacion;
        private System.Windows.Forms.Label lblTotalImporte;
        private System.Windows.Forms.Label lblNoSemana;
        private System.Windows.Forms.Button btnMostrarPagadas;
        private MetroFramework.Controls.MetroComboBox cmbxNoSemana;
        private MetroFramework.Controls.MetroComboBox cmbxMostrar;
        private System.Windows.Forms.Button btnPagarTodas;
        private System.Windows.Forms.Button btnExportar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdOperacionComisionista;
        private DevExpress.XtraGrid.Columns.GridColumn IdOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn IdVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn NombreVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn NoOperacionBancaria;
        private DevExpress.XtraGrid.Columns.GridColumn Importe;
        private DevExpress.XtraGrid.Columns.GridColumn Semana;
        private DevExpress.XtraGrid.Columns.GridColumn Pagado;
        private DevExpress.XtraGrid.Columns.GridColumn Ventas;
        private DevExpress.XtraGrid.Columns.GridColumn FacturaPagada;
        private DevExpress.XtraGrid.Columns.GridColumn FechaPago;
        private DevExpress.XtraGrid.Columns.GridColumn Porcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn Comision;
        private DevExpress.XtraGrid.Columns.GridColumn NoFactura;
        private DevExpress.XtraGrid.Columns.GridColumn FacPagada;
        private DevExpress.XtraGrid.Columns.GridColumn TipoComision;
        private DevExpress.XtraGrid.Columns.GridColumn UsuarioTipo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn TUsuario;
        private DevExpress.XtraGrid.GridControl grdComisionistas;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialLabel label11;
        private MaterialSkin.Controls.MaterialLabel label95;
        private LollipopButton btnComisionPagada;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNoOperacionBancaria;
        private LollipopLabel label2;
        private LollipopLabel lblTotalComision;
        private LollipopLabel label7;
        private LollipopLabel label5;
        private LollipopLabel lollipopLabel1;
        private MetroFramework.Controls.MetroComboBox cmbxAño;
        private DevExpress.XtraGrid.Columns.GridColumn FechaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn NoCuenta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel2;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.Panel panel6;
	}
}