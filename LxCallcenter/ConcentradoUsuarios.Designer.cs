namespace LxCallcenter
{
    partial class ConcentradoUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.grdUsuarios = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.APaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AMaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TelefonoMovil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsuarioTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Activo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkExportar = new MetroFramework.Controls.MetroLink();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lnkDetalles = new MetroFramework.Controls.MetroLink();
            this.lnkCerrar = new MetroFramework.Controls.MetroLink();
            this.lblCorreoElectronico = new MetroFramework.Controls.MetroLink();
            this.lnkEditarCuenta = new MetroFramework.Controls.MetroLink();
            this.lnkGuardarNoCuenta = new MetroFramework.Controls.MetroLink();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDetalles = new System.Windows.Forms.Panel();
            this.txtNoCuenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label14 = new System.Windows.Forms.Label();
            this.chbxActivo = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTelMovil = new System.Windows.Forms.Label();
            this.lblExt = new System.Windows.Forms.Label();
            this.lblTelLocal = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCedulaProfesional = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnlDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(26, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 33);
            this.label1.TabIndex = 87;
            this.label1.Text = "Usuarios";
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUsuarios.Location = new System.Drawing.Point(51, 122);
            this.grdUsuarios.MainView = this.gridView1;
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.Size = new System.Drawing.Size(1069, 247);
            this.grdUsuarios.TabIndex = 205;
            this.grdUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.IdUsuario,
            this.Nombre,
            this.APaterno,
            this.AMaterno,
            this.TelefonoMovil,
            this.UsuarioTipo,
            this.FechaCreacion,
            this.Activo});
            this.gridView1.GridControl = this.grdUsuarios;
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
            // 
            // IdUsuario
            // 
            this.IdUsuario.Caption = "ID";
            this.IdUsuario.FieldName = "iIdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Visible = true;
            this.IdUsuario.VisibleIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "sNombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 1;
            // 
            // APaterno
            // 
            this.APaterno.Caption = "Apellido Paterno";
            this.APaterno.FieldName = "sAPaterno";
            this.APaterno.Name = "APaterno";
            this.APaterno.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.APaterno.Visible = true;
            this.APaterno.VisibleIndex = 2;
            // 
            // AMaterno
            // 
            this.AMaterno.Caption = "Apellido Materno";
            this.AMaterno.FieldName = "sAMaterno";
            this.AMaterno.Name = "AMaterno";
            this.AMaterno.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.AMaterno.Visible = true;
            this.AMaterno.VisibleIndex = 3;
            // 
            // TelefonoMovil
            // 
            this.TelefonoMovil.Caption = "Teléfono Movil";
            this.TelefonoMovil.FieldName = "sTelefonoMovil";
            this.TelefonoMovil.Name = "TelefonoMovil";
            this.TelefonoMovil.Visible = true;
            this.TelefonoMovil.VisibleIndex = 4;
            // 
            // UsuarioTipo
            // 
            this.UsuarioTipo.Caption = "Puesto";
            this.UsuarioTipo.FieldName = "sUsuarioTipo";
            this.UsuarioTipo.Name = "UsuarioTipo";
            this.UsuarioTipo.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.UsuarioTipo.Visible = true;
            this.UsuarioTipo.VisibleIndex = 5;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.Caption = "Fecha de Registro";
            this.FechaCreacion.FieldName = "sFechaCreacion";
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateAlt;
            this.FechaCreacion.Visible = true;
            this.FechaCreacion.VisibleIndex = 6;
            // 
            // Activo
            // 
            this.Activo.Caption = "Estatus";
            this.Activo.FieldName = "sActivo";
            this.Activo.Name = "Activo";
            this.Activo.Visible = true;
            this.Activo.VisibleIndex = 7;
            // 
            // lnkExportar
            // 
            this.lnkExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lnkExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkExportar.Image = global::LxCallcenter.Properties.Resources.ms_excel_filled_25px;
            this.lnkExportar.ImageSize = 25;
            this.lnkExportar.Location = new System.Drawing.Point(1086, 124);
            this.lnkExportar.Name = "lnkExportar";
            this.lnkExportar.NoFocusImage = global::LxCallcenter.Properties.Resources.ms_excel_25px3;
            this.lnkExportar.Size = new System.Drawing.Size(25, 26);
            this.lnkExportar.TabIndex = 212;
            this.metroToolTip1.SetToolTip(this.lnkExportar, "Exportar a Excel");
            this.lnkExportar.UseCustomBackColor = true;
            this.lnkExportar.UseSelectable = true;
            this.lnkExportar.Visible = false;
            this.lnkExportar.Click += new System.EventHandler(this.lnkExportar_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lnkDetalles
            // 
            this.lnkDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lnkDetalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkDetalles.Image = global::LxCallcenter.Properties.Resources.details_popup_filled_25px;
            this.lnkDetalles.ImageSize = 25;
            this.lnkDetalles.Location = new System.Drawing.Point(1049, 124);
            this.lnkDetalles.Name = "lnkDetalles";
            this.lnkDetalles.NoFocusImage = global::LxCallcenter.Properties.Resources.details_popup_25px3;
            this.lnkDetalles.Size = new System.Drawing.Size(25, 26);
            this.lnkDetalles.TabIndex = 213;
            this.metroToolTip1.SetToolTip(this.lnkDetalles, "Detalles del Usuario");
            this.lnkDetalles.UseCustomBackColor = true;
            this.lnkDetalles.UseSelectable = true;
            this.lnkDetalles.Visible = false;
            this.lnkDetalles.Click += new System.EventHandler(this.lnkDetalles_Click);
            // 
            // lnkCerrar
            // 
            this.lnkCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkCerrar.Image = global::LxCallcenter.Properties.Resources.delete_sign_filled_23px;
            this.lnkCerrar.ImageSize = 23;
            this.lnkCerrar.Location = new System.Drawing.Point(470, 3);
            this.lnkCerrar.Name = "lnkCerrar";
            this.lnkCerrar.NoFocusImage = global::LxCallcenter.Properties.Resources.delete_sign_23px;
            this.lnkCerrar.Size = new System.Drawing.Size(29, 23);
            this.lnkCerrar.TabIndex = 201;
            this.metroToolTip1.SetToolTip(this.lnkCerrar, "Cerrar");
            this.lnkCerrar.UseSelectable = true;
            this.lnkCerrar.Click += new System.EventHandler(this.lnkCerrar_Click);
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCorreoElectronico.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lblCorreoElectronico.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lblCorreoElectronico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.lblCorreoElectronico.Location = new System.Drawing.Point(19, 332);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(277, 23);
            this.lblCorreoElectronico.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lblCorreoElectronico.TabIndex = 227;
            this.lblCorreoElectronico.Text = "email@email.com";
            this.lblCorreoElectronico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroToolTip1.SetToolTip(this.lblCorreoElectronico, "Enviar Correo");
            this.lblCorreoElectronico.UseCustomForeColor = true;
            this.lblCorreoElectronico.UseSelectable = true;
            this.lblCorreoElectronico.Click += new System.EventHandler(this.lblCorreoElectronico_Click);
            // 
            // lnkEditarCuenta
            // 
            this.lnkEditarCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkEditarCuenta.Image = global::LxCallcenter.Properties.Resources.edit_25px;
            this.lnkEditarCuenta.ImageSize = 20;
            this.lnkEditarCuenta.Location = new System.Drawing.Point(197, 391);
            this.lnkEditarCuenta.Name = "lnkEditarCuenta";
            this.lnkEditarCuenta.Size = new System.Drawing.Size(20, 23);
            this.lnkEditarCuenta.TabIndex = 231;
            this.metroToolTip1.SetToolTip(this.lnkEditarCuenta, "Editar No. de Cuenta");
            this.lnkEditarCuenta.UseSelectable = true;
            this.lnkEditarCuenta.Click += new System.EventHandler(this.lnkEditarCuenta_Click);
            // 
            // lnkGuardarNoCuenta
            // 
            this.lnkGuardarNoCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkGuardarNoCuenta.Enabled = false;
            this.lnkGuardarNoCuenta.Image = global::LxCallcenter.Properties.Resources.save_48px;
            this.lnkGuardarNoCuenta.ImageSize = 22;
            this.lnkGuardarNoCuenta.Location = new System.Drawing.Point(223, 391);
            this.lnkGuardarNoCuenta.Name = "lnkGuardarNoCuenta";
            this.lnkGuardarNoCuenta.Size = new System.Drawing.Size(21, 23);
            this.lnkGuardarNoCuenta.TabIndex = 232;
            this.metroToolTip1.SetToolTip(this.lnkGuardarNoCuenta, "Guardar No. de Cuenta");
            this.lnkGuardarNoCuenta.UseSelectable = true;
            this.lnkGuardarNoCuenta.Click += new System.EventHandler(this.lnkGuardarNoCuenta_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(1040, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 214;
            this.label4.Text = "Acciones";
            this.label4.Visible = false;
            // 
            // pnlDetalles
            // 
            this.pnlDetalles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDetalles.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetalles.Controls.Add(this.lnkGuardarNoCuenta);
            this.pnlDetalles.Controls.Add(this.lnkEditarCuenta);
            this.pnlDetalles.Controls.Add(this.txtNoCuenta);
            this.pnlDetalles.Controls.Add(this.label14);
            this.pnlDetalles.Controls.Add(this.chbxActivo);
            this.pnlDetalles.Controls.Add(this.lblCorreoElectronico);
            this.pnlDetalles.Controls.Add(this.lblFechaCreacion);
            this.pnlDetalles.Controls.Add(this.label15);
            this.pnlDetalles.Controls.Add(this.lblTelMovil);
            this.pnlDetalles.Controls.Add(this.lblExt);
            this.pnlDetalles.Controls.Add(this.lblTelLocal);
            this.pnlDetalles.Controls.Add(this.lblContrasenia);
            this.pnlDetalles.Controls.Add(this.lblUsuario);
            this.pnlDetalles.Controls.Add(this.lblCedulaProfesional);
            this.pnlDetalles.Controls.Add(this.panel2);
            this.pnlDetalles.Controls.Add(this.lblId);
            this.pnlDetalles.Controls.Add(this.label7);
            this.pnlDetalles.Controls.Add(this.label19);
            this.pnlDetalles.Controls.Add(this.label5);
            this.pnlDetalles.Controls.Add(this.lblNombreUsuario);
            this.pnlDetalles.Controls.Add(this.label6);
            this.pnlDetalles.Controls.Add(this.panel1);
            this.pnlDetalles.Controls.Add(this.lnkCerrar);
            this.pnlDetalles.Controls.Add(this.label11);
            this.pnlDetalles.Controls.Add(this.lblDetalles);
            this.pnlDetalles.Controls.Add(this.label9);
            this.pnlDetalles.Controls.Add(this.label13);
            this.pnlDetalles.Controls.Add(this.label10);
            this.pnlDetalles.Controls.Add(this.label8);
            this.pnlDetalles.Controls.Add(this.label12);
            this.pnlDetalles.Controls.Add(this.lblTipoUsuario);
            this.pnlDetalles.Location = new System.Drawing.Point(382, 6);
            this.pnlDetalles.Name = "pnlDetalles";
            this.pnlDetalles.Size = new System.Drawing.Size(504, 443);
            this.pnlDetalles.TabIndex = 215;
            this.pnlDetalles.Visible = false;
            this.pnlDetalles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDetalles_MouseDown);
            this.pnlDetalles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDetalles_MouseMove);
            // 
            // txtNoCuenta
            // 
            this.txtNoCuenta.Depth = 0;
            this.txtNoCuenta.Enabled = false;
            this.txtNoCuenta.Hint = "";
            this.txtNoCuenta.Location = new System.Drawing.Point(23, 389);
            this.txtNoCuenta.MaxLength = 32767;
            this.txtNoCuenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNoCuenta.Name = "txtNoCuenta";
            this.txtNoCuenta.PasswordChar = '\0';
            this.txtNoCuenta.SelectedText = "";
            this.txtNoCuenta.SelectionLength = 0;
            this.txtNoCuenta.SelectionStart = 0;
            this.txtNoCuenta.Size = new System.Drawing.Size(168, 23);
            this.txtNoCuenta.TabIndex = 230;
            this.txtNoCuenta.TabStop = false;
            this.txtNoCuenta.UseSystemPasswordChar = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(19, 365);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 21);
            this.label14.TabIndex = 229;
            this.label14.Text = "No. Cuenta Bancaria";
            // 
            // chbxActivo
            // 
            this.chbxActivo.AutoSize = true;
            this.chbxActivo.Depth = 0;
            this.chbxActivo.Enabled = false;
            this.chbxActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbxActivo.Location = new System.Drawing.Point(359, 139);
            this.chbxActivo.Margin = new System.Windows.Forms.Padding(0);
            this.chbxActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbxActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbxActivo.Name = "chbxActivo";
            this.chbxActivo.Ripple = true;
            this.chbxActivo.Size = new System.Drawing.Size(69, 30);
            this.chbxActivo.TabIndex = 228;
            this.chbxActivo.Text = "Activo";
            this.chbxActivo.UseVisualStyleBackColor = true;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblFechaCreacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.lblFechaCreacion.Location = new System.Drawing.Point(360, 333);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(96, 22);
            this.lblFechaCreacion.TabIndex = 226;
            this.lblFechaCreacion.Text = "01/01/2001";
            this.lblFechaCreacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(359, 312);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 21);
            this.label15.TabIndex = 225;
            this.label15.Text = "Fecha de Registro";
            // 
            // lblTelMovil
            // 
            this.lblTelMovil.AutoSize = true;
            this.lblTelMovil.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblTelMovil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.lblTelMovil.Location = new System.Drawing.Point(359, 276);
            this.lblTelMovil.Name = "lblTelMovil";
            this.lblTelMovil.Size = new System.Drawing.Size(100, 22);
            this.lblTelMovil.TabIndex = 223;
            this.lblTelMovil.Text = "1234567890";
            this.lblTelMovil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.lblExt.Location = new System.Drawing.Point(193, 276);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(55, 22);
            this.lblExt.TabIndex = 222;
            this.lblExt.Text = "12345";
            this.lblExt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTelLocal
            // 
            this.lblTelLocal.AutoSize = true;
            this.lblTelLocal.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblTelLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.lblTelLocal.Location = new System.Drawing.Point(19, 276);
            this.lblTelLocal.Name = "lblTelLocal";
            this.lblTelLocal.Size = new System.Drawing.Size(100, 22);
            this.lblTelLocal.TabIndex = 221;
            this.lblTelLocal.Text = "1234567890";
            this.lblTelLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblContrasenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.lblContrasenia.Location = new System.Drawing.Point(359, 216);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(91, 22);
            this.lblContrasenia.TabIndex = 219;
            this.lblContrasenia.Text = "Contraseña";
            this.lblContrasenia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.lblUsuario.Location = new System.Drawing.Point(193, 216);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 22);
            this.lblUsuario.TabIndex = 218;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCedulaProfesional
            // 
            this.lblCedulaProfesional.AutoSize = true;
            this.lblCedulaProfesional.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblCedulaProfesional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.lblCedulaProfesional.Location = new System.Drawing.Point(287, 102);
            this.lblCedulaProfesional.Name = "lblCedulaProfesional";
            this.lblCedulaProfesional.Size = new System.Drawing.Size(172, 22);
            this.lblCedulaProfesional.TabIndex = 217;
            this.lblCedulaProfesional.Text = "XXXXXXXXXXXXXXXXXX";
            this.lblCedulaProfesional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel2.Location = new System.Drawing.Point(-1, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 24);
            this.panel2.TabIndex = 213;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.lblId.Location = new System.Drawing.Point(18, 102);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 22);
            this.lblId.TabIndex = 207;
            this.lblId.Text = "ID";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(18, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 22);
            this.label7.TabIndex = 206;
            this.label7.Text = "ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(287, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(139, 21);
            this.label19.TabIndex = 215;
            this.label19.Text = "Cedula Profesional";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(18, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 213;
            this.label5.Text = "Tipo de Usuario";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(18, 155);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(148, 22);
            this.lblNombreUsuario.TabIndex = 205;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(18, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 22);
            this.label6.TabIndex = 204;
            this.label6.Text = "Nombre";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(359, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 21);
            this.label11.TabIndex = 214;
            this.label11.Text = "Tel. Movil";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(214, 16);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(83, 27);
            this.lblDetalles.TabIndex = 96;
            this.lblDetalles.Text = "Detalles";
            this.lblDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(18, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 211;
            this.label9.Text = "Tel. Local";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(193, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 21);
            this.label13.TabIndex = 208;
            this.label13.Text = "Usuario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(193, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 21);
            this.label10.TabIndex = 212;
            this.label10.Text = "Ext.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(18, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 21);
            this.label8.TabIndex = 210;
            this.label8.Text = "Correo Electronico";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(359, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 21);
            this.label12.TabIndex = 209;
            this.label12.Text = "Contraseña";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoEllipsis = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.lblTipoUsuario.Location = new System.Drawing.Point(18, 216);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(169, 22);
            this.lblTipoUsuario.TabIndex = 220;
            this.lblTipoUsuario.Text = "Tipo de Usuario del Vendedor";
            this.lblTipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivo Excel | *.xlsx";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Nombre";
            this.txtBuscar.Location = new System.Drawing.Point(51, 93);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(225, 23);
            this.txtBuscar.TabIndex = 216;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(45, 71);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 217;
            this.label3.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 22);
            this.label2.TabIndex = 224;
            this.label2.Text = "Obtén el concentrado de usuarios registrados que administran los sistemas.";
            // 
            // ConcentradoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1192, 456);
            this.Controls.Add(this.pnlDetalles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lnkDetalles);
            this.Controls.Add(this.lnkExportar);
            this.Controls.Add(this.grdUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Name = "ConcentradoUsuarios";
            this.Text = "ConcentradoUsuarios";
            this.Load += new System.EventHandler(this.ConcentradoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnlDetalles.ResumeLayout(false);
            this.pnlDetalles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl grdUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn APaterno;
        private DevExpress.XtraGrid.Columns.GridColumn AMaterno;
        private DevExpress.XtraGrid.Columns.GridColumn TelefonoMovil;
        private DevExpress.XtraGrid.Columns.GridColumn UsuarioTipo;
        private DevExpress.XtraGrid.Columns.GridColumn FechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn Activo;
        private MetroFramework.Controls.MetroLink lnkExportar;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLink lnkDetalles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDetalles;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLink lnkCerrar;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTelMovil;
        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.Label lblTelLocal;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCedulaProfesional;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroLink lblCorreoElectronico;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialLabel label3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialCheckBox chbxActivo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNoCuenta;
        private System.Windows.Forms.Label label14;
        private MetroFramework.Controls.MetroLink lnkEditarCuenta;
        private MetroFramework.Controls.MetroLink lnkGuardarNoCuenta;
    }
}