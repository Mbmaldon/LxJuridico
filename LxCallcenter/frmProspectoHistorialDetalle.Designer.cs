namespace LxCallcenter
{
    partial class frmProspectoHistorialDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProspectoHistorialDetalle));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbTipoLlamada = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lnkCerrar = new MetroFramework.Controls.MetroLink();
            this.lblNoRegitros = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdLlamadas = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdLlamada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaLlamada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoraLlamada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.pnlDetalles = new System.Windows.Forms.Panel();
            this.btnMarca = new LollipopButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtComentariosLlamadaAgendada = new LollipopTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtComentarioLlamada = new LollipopTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlDescarga = new System.Windows.Forms.Panel();
            this.lbProgress = new LollipopLabel();
            this.pgbDescarga = new MetroFramework.Controls.MetroProgressSpinner();
            this.TrackBar = new LollipopProgressBar();
            this.lnkPlay = new MetroFramework.Controls.MetroLink();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblHora = new MaterialSkin.Controls.MaterialLabel();
            this.lblFecha = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelar = new LollipopFlatButton();
            this.tmrPlayer = new System.Windows.Forms.Timer(this.components);
            this.tbTipoLlamada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLlamadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.pnlDetalles.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlDescarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tbTipoLlamada;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(681, 30);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tbTipoLlamada
            // 
            this.tbTipoLlamada.Controls.Add(this.tabPage1);
            this.tbTipoLlamada.Controls.Add(this.tabPage2);
            this.tbTipoLlamada.Depth = 0;
            this.tbTipoLlamada.ItemSize = new System.Drawing.Size(57, 18);
            this.tbTipoLlamada.Location = new System.Drawing.Point(328, 5);
            this.tbTipoLlamada.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbTipoLlamada.Name = "tbTipoLlamada";
            this.tbTipoLlamada.SelectedIndex = 0;
            this.tbTipoLlamada.Size = new System.Drawing.Size(12, 16);
            this.tbTipoLlamada.TabIndex = 1;
            this.tbTipoLlamada.SelectedIndexChanged += new System.EventHandler(this.tbTipoLlamada_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(4, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Llamadas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(4, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Llamadas Agendadas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lnkCerrar
            // 
            this.lnkCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.lnkCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.lnkCerrar.Image = global::LxCallcenter.Properties.Resources.delete_sign_18px;
            this.lnkCerrar.ImageSize = 18;
            this.lnkCerrar.Location = new System.Drawing.Point(654, 5);
            this.lnkCerrar.Name = "lnkCerrar";
            this.lnkCerrar.NoFocusImage = global::LxCallcenter.Properties.Resources.delete_sign_18px;
            this.lnkCerrar.Size = new System.Drawing.Size(25, 18);
            this.lnkCerrar.TabIndex = 8;
            this.lnkCerrar.UseCustomBackColor = true;
            this.lnkCerrar.UseSelectable = true;
            this.lnkCerrar.Click += new System.EventHandler(this.lnkCerrar_Click);
            // 
            // lblNoRegitros
            // 
            this.lblNoRegitros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNoRegitros.AutoSize = true;
            this.lblNoRegitros.Depth = 0;
            this.lblNoRegitros.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNoRegitros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoRegitros.Location = new System.Drawing.Point(17, 394);
            this.lblNoRegitros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoRegitros.Name = "lblNoRegitros";
            this.lblNoRegitros.Size = new System.Drawing.Size(137, 19);
            this.lblNoRegitros.TabIndex = 253;
            this.lblNoRegitros.Text = "No. de Registros: --";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(19, 45);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(55, 19);
            this.materialLabel6.TabIndex = 251;
            this.materialLabel6.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Introduzca texto a buscar...";
            this.txtBuscar.Location = new System.Drawing.Point(23, 69);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(204, 23);
            this.txtBuscar.TabIndex = 250;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(21, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 47);
            this.panel2.TabIndex = 252;
            // 
            // grdLlamadas
            // 
            this.grdLlamadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdLlamadas.Location = new System.Drawing.Point(21, 55);
            this.grdLlamadas.MainView = this.gridView1;
            this.grdLlamadas.Name = "grdLlamadas";
            this.grdLlamadas.Size = new System.Drawing.Size(252, 337);
            this.grdLlamadas.TabIndex = 249;
            this.grdLlamadas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.IdLlamada,
            this.FechaLlamada,
            this.HoraLlamada,
            this.Telefono});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.grdLlamadas;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.PaintStyleName = "Web";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // IdLlamada
            // 
            this.IdLlamada.Caption = "Id Llamada";
            this.IdLlamada.FieldName = "iIdLlamada";
            this.IdLlamada.Name = "IdLlamada";
            // 
            // FechaLlamada
            // 
            this.FechaLlamada.Caption = "Fecha";
            this.FechaLlamada.FieldName = "dtFecha";
            this.FechaLlamada.Name = "FechaLlamada";
            this.FechaLlamada.Visible = true;
            this.FechaLlamada.VisibleIndex = 0;
            // 
            // HoraLlamada
            // 
            this.HoraLlamada.Caption = "Hora";
            this.HoraLlamada.FieldName = "tsHora";
            this.HoraLlamada.Name = "HoraLlamada";
            this.HoraLlamada.Visible = true;
            this.HoraLlamada.VisibleIndex = 1;
            // 
            // Telefono
            // 
            this.Telefono.Caption = "Teléfono";
            this.Telefono.FieldName = "sTelefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Visible = true;
            this.Telefono.VisibleIndex = 2;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(279, 45);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(19, 372);
            this.separatorControl1.TabIndex = 254;
            // 
            // pnlDetalles
            // 
            this.pnlDetalles.Controls.Add(this.btnMarca);
            this.pnlDetalles.Controls.Add(this.flowLayoutPanel1);
            this.pnlDetalles.Controls.Add(this.lblHora);
            this.pnlDetalles.Controls.Add(this.lblFecha);
            this.pnlDetalles.Location = new System.Drawing.Point(304, 49);
            this.pnlDetalles.Name = "pnlDetalles";
            this.pnlDetalles.Size = new System.Drawing.Size(356, 339);
            this.pnlDetalles.TabIndex = 255;
            this.pnlDetalles.Visible = false;
            // 
            // btnMarca
            // 
            this.btnMarca.BackColor = System.Drawing.Color.Transparent;
            this.btnMarca.BGColor = "#43A047";
            this.btnMarca.FontColor = "#ffffff";
            this.btnMarca.Location = new System.Drawing.Point(261, 13);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(73, 15);
            this.btnMarca.TabIndex = 6;
            this.btnMarca.Text = "Realizada";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.materialLabel3);
            this.flowLayoutPanel1.Controls.Add(this.txtComentariosLlamadaAgendada);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.materialLabel4);
            this.flowLayoutPanel1.Controls.Add(this.txtComentarioLlamada);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(310, 276);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.Location = new System.Drawing.Point(3, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(263, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Comentarios de la Llamada Agendada";
            this.materialLabel3.Visible = false;
            // 
            // txtComentariosLlamadaAgendada
            // 
            this.txtComentariosLlamadaAgendada.FocusedColor = "#508ef5";
            this.txtComentariosLlamadaAgendada.FontColor = "#999999";
            this.txtComentariosLlamadaAgendada.IsEnabled = true;
            this.txtComentariosLlamadaAgendada.Location = new System.Drawing.Point(3, 22);
            this.txtComentariosLlamadaAgendada.MaxLength = 32767;
            this.txtComentariosLlamadaAgendada.Multiline = true;
            this.txtComentariosLlamadaAgendada.Name = "txtComentariosLlamadaAgendada";
            this.txtComentariosLlamadaAgendada.ReadOnly = true;
            this.txtComentariosLlamadaAgendada.Size = new System.Drawing.Size(300, 60);
            this.txtComentariosLlamadaAgendada.TabIndex = 2;
            this.txtComentariosLlamadaAgendada.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComentariosLlamadaAgendada.UseSystemPasswordChar = false;
            this.txtComentariosLlamadaAgendada.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 10);
            this.panel3.TabIndex = 5;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.Location = new System.Drawing.Point(3, 101);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(193, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Comentarios de la Llamada";
            // 
            // txtComentarioLlamada
            // 
            this.txtComentarioLlamada.FocusedColor = "#508ef5";
            this.txtComentarioLlamada.FontColor = "#999999";
            this.txtComentarioLlamada.IsEnabled = true;
            this.txtComentarioLlamada.Location = new System.Drawing.Point(3, 123);
            this.txtComentarioLlamada.MaxLength = 32767;
            this.txtComentarioLlamada.Multiline = true;
            this.txtComentarioLlamada.Name = "txtComentarioLlamada";
            this.txtComentarioLlamada.ReadOnly = true;
            this.txtComentarioLlamada.Size = new System.Drawing.Size(300, 60);
            this.txtComentarioLlamada.TabIndex = 4;
            this.txtComentarioLlamada.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComentarioLlamada.UseSystemPasswordChar = false;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 9);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbProgress);
            this.panel5.Controls.Add(this.pnlDescarga);
            this.panel5.Controls.Add(this.TrackBar);
            this.panel5.Controls.Add(this.lnkPlay);
            this.panel5.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel5.Controls.Add(this.lblTiempo);
            this.panel5.Location = new System.Drawing.Point(3, 204);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(305, 69);
            this.panel5.TabIndex = 7;
            // 
            // pnlDescarga
            // 
            this.pnlDescarga.Controls.Add(this.pgbDescarga);
            this.pnlDescarga.Location = new System.Drawing.Point(130, 42);
            this.pnlDescarga.Name = "pnlDescarga";
            this.pnlDescarga.Size = new System.Drawing.Size(28, 26);
            this.pnlDescarga.TabIndex = 257;
            this.pnlDescarga.Visible = false;
            // 
            // lbProgress
            // 
            this.lbProgress.BackColor = System.Drawing.Color.Transparent;
            this.lbProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lbProgress.Location = new System.Drawing.Point(22, 19);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(252, 17);
            this.lbProgress.TabIndex = 30;
            this.lbProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbProgress.Visible = false;
            // 
            // pgbDescarga
            // 
            this.pgbDescarga.EnsureVisible = false;
            this.pgbDescarga.Location = new System.Drawing.Point(3, 2);
            this.pgbDescarga.Maximum = 100;
            this.pgbDescarga.Name = "pgbDescarga";
            this.pgbDescarga.Size = new System.Drawing.Size(22, 22);
            this.pgbDescarga.Spinning = false;
            this.pgbDescarga.Style = MetroFramework.MetroColorStyle.Red;
            this.pgbDescarga.TabIndex = 33;
            this.pgbDescarga.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pgbDescarga.UseSelectable = true;
            // 
            // TrackBar
            // 
            this.TrackBar.BGColor = "#508ef5";
            this.TrackBar.Location = new System.Drawing.Point(66, 10);
            this.TrackBar.Maximum = 100;
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(160, 3);
            this.TrackBar.TabIndex = 265;
            this.TrackBar.Text = "lollipopProgressBar1";
            this.TrackBar.Value = 0;
            this.TrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseDown);
            this.TrackBar.MouseLeave += new System.EventHandler(this.TrackBar_MouseLeave);
            this.TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseUp);
            // 
            // lnkPlay
            // 
            this.lnkPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.lnkPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkPlay.Image = global::LxCallcenter.Properties.Resources.play_52px;
            this.lnkPlay.ImageSize = 37;
            this.lnkPlay.Location = new System.Drawing.Point(134, 41);
            this.lnkPlay.Name = "lnkPlay";
            this.lnkPlay.NoFocusImage = global::LxCallcenter.Properties.Resources.play_52px;
            this.lnkPlay.Size = new System.Drawing.Size(25, 25);
            this.lnkPlay.TabIndex = 264;
            this.lnkPlay.UseSelectable = true;
            this.lnkPlay.Click += new System.EventHandler(this.lnkPlay_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(2, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(11, 9);
            this.axWindowsMediaPlayer1.TabIndex = 258;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // lblTiempo
            // 
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTiempo.Location = new System.Drawing.Point(73, 14);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(146, 12);
            this.lblTiempo.TabIndex = 266;
            this.lblTiempo.Text = "--/--";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Depth = 0;
            this.lblHora.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHora.Location = new System.Drawing.Point(20, 28);
            this.lblHora.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(108, 19);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "materialLabel2";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Depth = 0;
            this.lblFecha.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFecha.Location = new System.Drawing.Point(20, 8);
            this.lblFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(108, 19);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "materialLabel1";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FontColor = "#B71C1C";
            this.btnCancelar.Location = new System.Drawing.Point(565, 394);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 23);
            this.btnCancelar.TabIndex = 256;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.Click += new System.EventHandler(this.lnkCerrar_Click);
            // 
            // tmrPlayer
            // 
            this.tmrPlayer.Tick += new System.EventHandler(this.tmrPlayer_Tick);
            // 
            // frmProspectoHistorialDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.lnkCerrar;
            this.ClientSize = new System.Drawing.Size(681, 429);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlDetalles);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.lblNoRegitros);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grdLlamadas);
            this.Controls.Add(this.lnkCerrar);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tbTipoLlamada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProspectoHistorialDetalle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProspectoHistorialDetalle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProspectoHistorialDetalle_FormClosing);
            this.tbTipoLlamada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLlamadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.pnlDetalles.ResumeLayout(false);
            this.pnlDetalles.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.pnlDescarga.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tbTipoLlamada;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroLink lnkCerrar;
        private MaterialSkin.Controls.MaterialLabel lblNoRegitros;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private System.Windows.Forms.Panel panel2;
        public DevExpress.XtraGrid.GridControl grdLlamadas;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdLlamada;
        private DevExpress.XtraGrid.Columns.GridColumn FechaLlamada;
        private DevExpress.XtraGrid.Columns.GridColumn HoraLlamada;
        private DevExpress.XtraGrid.Columns.GridColumn Telefono;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Panel pnlDetalles;
        private MaterialSkin.Controls.MaterialLabel lblFecha;
        private MaterialSkin.Controls.MaterialLabel lblHora;
        private LollipopTextBox txtComentariosLlamadaAgendada;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private LollipopTextBox txtComentarioLlamada;
        private LollipopFlatButton btnCancelar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private MetroFramework.Controls.MetroLink lnkPlay;
        private System.Windows.Forms.Timer tmrPlayer;
        private LollipopProgressBar TrackBar;
        private System.Windows.Forms.Label lblTiempo;
        private LollipopButton btnMarca;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Panel pnlDescarga;
        private LollipopLabel lbProgress;
        private MetroFramework.Controls.MetroProgressSpinner pgbDescarga;
    }
}