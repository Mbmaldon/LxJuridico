namespace LxCallcenter.LexaSIOConta
{
    partial class frmExpedienteLineaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpedienteLineaClientes));
            this.lblFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialogDocumentos = new System.Windows.Forms.OpenFileDialog();
            this.lblRuta = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCampoRequerido = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lnkAtras = new MetroFramework.Controls.MetroLink();
            this.lnkAdelante = new MetroFramework.Controls.MetroLink();
            this.lnkHome = new MetroFramework.Controls.MetroLink();
            this.imageListDrag = new System.Windows.Forms.ImageList(this.components);
            this.svdDocumento = new System.Windows.Forms.SaveFileDialog();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pgbCarga = new MetroFramework.Controls.MetroProgressSpinner();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bgwLinks = new System.ComponentModel.BackgroundWorker();
            this.bgwUpdate = new System.ComponentModel.BackgroundWorker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lvCarpetas = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.contextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.descargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lollipopButton1 = new LollipopButton();
            this.lblNombre = new LollipopLabel();
            this.lblCorreoE = new LollipopLabel();
            this.ovalPictureBox1 = new LxCallcenter.OvalPictureBox();
            this.lblTelefonoM = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.lblRfc = new LollipopLabel();
            this.lollipopLabel3 = new LollipopLabel();
            this.lblNoCliente = new LollipopLabel();
            this.lollipopLabel5 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel6 = new LollipopLabel();
            this.btnBuscarCliente = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblFecha.Location = new System.Drawing.Point(12, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(693, 22);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Administra el archivo en línea de los clientes agregando, eliminando y visualizan" +
    "do su contenido.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.label4.Location = new System.Drawing.Point(11, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Expediente en Línea";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_30px.png");
            this.imageList1.Images.SetKeyName(1, "image_file_30px.png");
            this.imageList1.Images.SetKeyName(2, "note_30px.png");
            this.imageList1.Images.SetKeyName(3, "pdf_2_30px.png");
            this.imageList1.Images.SetKeyName(4, "database_30px.png");
            this.imageList1.Images.SetKeyName(5, "winrar_30px.png");
            this.imageList1.Images.SetKeyName(6, "ms_excel_30px.png");
            this.imageList1.Images.SetKeyName(7, "file_30px.png");
            this.imageList1.Images.SetKeyName(8, "best_seller_48px.png");
            this.imageList1.Images.SetKeyName(9, "questions_30px.png");
            this.imageList1.Images.SetKeyName(10, "ms_word_30px.png");
            this.imageList1.Images.SetKeyName(11, "clipboard_48px.png");
            // 
            // openFileDialogDocumentos
            // 
            this.openFileDialogDocumentos.FileName = "openFileDialog1";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(1041, 7);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(35, 13);
            this.lblRuta.TabIndex = 2;
            this.lblRuta.Text = "label1";
            this.lblRuta.Visible = false;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.lblCliente.Location = new System.Drawing.Point(795, 11);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 23);
            this.lblCliente.TabIndex = 7;
            // 
            // lblCampoRequerido
            // 
            this.lblCampoRequerido.AutoSize = true;
            this.lblCampoRequerido.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblCampoRequerido.Location = new System.Drawing.Point(27, 125);
            this.lblCampoRequerido.Name = "lblCampoRequerido";
            this.lblCampoRequerido.Size = new System.Drawing.Size(99, 14);
            this.lblCampoRequerido.TabIndex = 6;
            this.lblCampoRequerido.Text = "*Campo Requerido";
            this.lblCampoRequerido.Visible = false;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lnkAtras
            // 
            this.lnkAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkAtras.Enabled = false;
            this.lnkAtras.Image = global::LxCallcenter.Properties.Resources.angle_left_24px;
            this.lnkAtras.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkAtras.ImageSize = 24;
            this.lnkAtras.Location = new System.Drawing.Point(3, 3);
            this.lnkAtras.Name = "lnkAtras";
            this.lnkAtras.NoFocusImage = global::LxCallcenter.Properties.Resources.angle_left_24px;
            this.lnkAtras.Size = new System.Drawing.Size(23, 21);
            this.lnkAtras.TabIndex = 0;
            this.metroToolTip1.SetToolTip(this.lnkAtras, "Atras");
            this.lnkAtras.UseSelectable = true;
            this.lnkAtras.Visible = false;
            // 
            // lnkAdelante
            // 
            this.lnkAdelante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkAdelante.Enabled = false;
            this.lnkAdelante.Image = global::LxCallcenter.Properties.Resources.angle_right_24px;
            this.lnkAdelante.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkAdelante.ImageSize = 24;
            this.lnkAdelante.Location = new System.Drawing.Point(32, 3);
            this.lnkAdelante.Name = "lnkAdelante";
            this.lnkAdelante.NoFocusImage = global::LxCallcenter.Properties.Resources.angle_right_24px;
            this.lnkAdelante.Size = new System.Drawing.Size(23, 21);
            this.lnkAdelante.TabIndex = 1;
            this.metroToolTip1.SetToolTip(this.lnkAdelante, "Adelante");
            this.lnkAdelante.UseSelectable = true;
            this.lnkAdelante.Visible = false;
            // 
            // lnkHome
            // 
            this.lnkHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkHome.Image = global::LxCallcenter.Properties.Resources.home_24px;
            this.lnkHome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkHome.ImageSize = 18;
            this.lnkHome.Location = new System.Drawing.Point(61, 3);
            this.lnkHome.Name = "lnkHome";
            this.lnkHome.NoFocusImage = global::LxCallcenter.Properties.Resources.home_24px;
            this.lnkHome.Size = new System.Drawing.Size(18, 19);
            this.lnkHome.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.lnkHome, "Inicio");
            this.lnkHome.UseSelectable = true;
            this.lnkHome.Visible = false;
            this.lnkHome.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // imageListDrag
            // 
            this.imageListDrag.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDrag.ImageStream")));
            this.imageListDrag.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDrag.Images.SetKeyName(0, "folder_48px.png");
            this.imageListDrag.Images.SetKeyName(1, "picture_48px.png");
            this.imageListDrag.Images.SetKeyName(2, "note_48px.png");
            this.imageListDrag.Images.SetKeyName(3, "pdf_48px.png");
            this.imageListDrag.Images.SetKeyName(4, "database_48px.png");
            this.imageListDrag.Images.SetKeyName(5, "archive_48px.png");
            this.imageListDrag.Images.SetKeyName(6, "ms_excel_48px.png");
            this.imageListDrag.Images.SetKeyName(7, "file_48px.png");
            this.imageListDrag.Images.SetKeyName(8, "best_seller_48px.png");
            this.imageListDrag.Images.SetKeyName(9, "questions_48px.png");
            this.imageListDrag.Images.SetKeyName(10, "ms_word_logo_48px.png");
            this.imageListDrag.Images.SetKeyName(11, "clipboard_48px.png");
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.panel1);
            this.panelControl3.Location = new System.Drawing.Point(31, 23);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1177, 613);
            this.panelControl3.TabIndex = 244;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lollipopButton1);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblRuta);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.lblCorreoE);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ovalPictureBox1);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.lblTelefonoM);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.lollipopLabel1);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblRfc);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.lollipopLabel3);
            this.panel1.Controls.Add(this.lblCampoRequerido);
            this.panel1.Controls.Add(this.lblNoCliente);
            this.panel1.Controls.Add(this.lollipopLabel5);
            this.panel1.Controls.Add(this.lollipopLabel2);
            this.panel1.Controls.Add(this.lollipopLabel6);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 609);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.separatorControl1);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Controls.Add(this.lvCarpetas);
            this.panel4.Location = new System.Drawing.Point(30, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1115, 449);
            this.panel4.TabIndex = 0;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl1.Location = new System.Drawing.Point(0, 31);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(1116, 18);
            this.separatorControl1.TabIndex = 239;
            this.separatorControl1.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lnkAtras);
            this.flowLayoutPanel1.Controls.Add(this.lnkAdelante);
            this.flowLayoutPanel1.Controls.Add(this.lnkHome);
            this.flowLayoutPanel1.Controls.Add(this.pgbCarga);
            this.flowLayoutPanel1.Controls.Add(this.materialLabel3);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1115, 36);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pgbCarga
            // 
            this.pgbCarga.EnsureVisible = false;
            this.pgbCarga.Location = new System.Drawing.Point(85, 3);
            this.pgbCarga.Maximum = 100;
            this.pgbCarga.Name = "pgbCarga";
            this.pgbCarga.Size = new System.Drawing.Size(22, 22);
            this.pgbCarga.Speed = 2F;
            this.pgbCarga.Style = MetroFramework.MetroColorStyle.Red;
            this.pgbCarga.TabIndex = 2;
            this.pgbCarga.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pgbCarga.UseSelectable = true;
            this.pgbCarga.Value = 90;
            this.pgbCarga.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Location = new System.Drawing.Point(119, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(869, 31);
            this.panel3.TabIndex = 242;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel2.Controls.Add(this.materialLabel4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, -5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(866, 34);
            this.flowLayoutPanel2.TabIndex = 240;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::LxCallcenter.Properties.Resources.File_Upload1;
            this.btnNuevo.Location = new System.Drawing.Point(1122, 28);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 33);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Subir Archivo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Visible = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // bgwLinks
            // 
            this.bgwLinks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLinks_DoWork);
            this.bgwLinks.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // bgwUpdate
            // 
            this.bgwUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwUpdate_DoWork);
            this.bgwUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwUpdate_RunWorkerCompleted);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.Location = new System.Drawing.Point(113, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(0, 18);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabel3.Visible = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.Location = new System.Drawing.Point(3, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(14, 27);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "➤";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabel4.Visible = false;
            // 
            // lvCarpetas
            // 
            this.lvCarpetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCarpetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCarpetas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvCarpetas.Depth = 0;
            this.lvCarpetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lvCarpetas.FullRowSelect = true;
            this.lvCarpetas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCarpetas.LargeImageList = this.imageList1;
            this.lvCarpetas.Location = new System.Drawing.Point(0, 37);
            this.lvCarpetas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvCarpetas.MouseState = MaterialSkin.MouseState.OUT;
            this.lvCarpetas.MultiSelect = false;
            this.lvCarpetas.Name = "lvCarpetas";
            this.lvCarpetas.OwnerDraw = true;
            this.lvCarpetas.Size = new System.Drawing.Size(1115, 412);
            this.lvCarpetas.SmallImageList = this.imageList1;
            this.lvCarpetas.TabIndex = 1;
            this.lvCarpetas.UseCompatibleStateImageBehavior = false;
            this.lvCarpetas.View = System.Windows.Forms.View.Details;
            this.lvCarpetas.Visible = false;
            this.lvCarpetas.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvCarpetas_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 747;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Peso";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha de modificación";
            this.columnHeader3.Width = 226;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo";
            this.columnHeader4.Width = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(26, 82);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(104, 18);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Buscar Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCliente.Depth = 0;
            this.txtCliente.Hint = "RFC, No. Cliente";
            this.txtCliente.Location = new System.Drawing.Point(30, 102);
            this.txtCliente.MaxLength = 32767;
            this.txtCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.ReadOnly = false;
            this.txtCliente.SelectedText = "";
            this.txtCliente.SelectionLength = 0;
            this.txtCliente.SelectionStart = 0;
            this.txtCliente.Size = new System.Drawing.Size(199, 25);
            this.txtCliente.TabIndex = 5;
            this.txtCliente.TabStop = false;
            this.txtCliente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCliente.UseSystemPasswordChar = false;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contextMenuStrip1.Depth = 0;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.descargarToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 98);
            this.contextMenuStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem1.Text = "Abrir";
            this.toolStripMenuItem1.Visible = false;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::LxCallcenter.Properties.Resources.delete_24px;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem3.Text = "Eliminar";
            // 
            // descargarToolStripMenuItem
            // 
            this.descargarToolStripMenuItem.Image = global::LxCallcenter.Properties.Resources.download_24px;
            this.descargarToolStripMenuItem.Name = "descargarToolStripMenuItem";
            this.descargarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.descargarToolStripMenuItem.Text = "Descargar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::LxCallcenter.Properties.Resources.recurring_appointment_24px;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem2.Text = "Actualizar lista";
            // 
            // lollipopButton1
            // 
            this.lollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton1.BGColor = "#558b2f";
            this.lollipopButton1.FontColor = "#ffffff";
            this.lollipopButton1.Location = new System.Drawing.Point(705, 17);
            this.lollipopButton1.Name = "lollipopButton1";
            this.lollipopButton1.Size = new System.Drawing.Size(84, 16);
            this.lollipopButton1.TabIndex = 9;
            this.lollipopButton1.Text = "Información";
            this.lollipopButton1.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.lblNombre.Location = new System.Drawing.Point(1002, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(143, 17);
            this.lblNombre.TabIndex = 10;
            // 
            // lblCorreoE
            // 
            this.lblCorreoE.AutoSize = true;
            this.lblCorreoE.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCorreoE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.lblCorreoE.Location = new System.Drawing.Point(941, 53);
            this.lblCorreoE.Name = "lblCorreoE";
            this.lblCorreoE.Size = new System.Drawing.Size(0, 17);
            this.lblCorreoE.TabIndex = 19;
            this.lblCorreoE.Visible = false;
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ovalPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.ovalPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ovalPictureBox1.Image = global::LxCallcenter.Properties.Resources.circled_user_male_skin_type_1_2_96px;
            this.ovalPictureBox1.Location = new System.Drawing.Point(965, 96);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(35, 35);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ovalPictureBox1.TabIndex = 238;
            this.ovalPictureBox1.TabStop = false;
            // 
            // lblTelefonoM
            // 
            this.lblTelefonoM.AutoSize = true;
            this.lblTelefonoM.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefonoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTelefonoM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.lblTelefonoM.Location = new System.Drawing.Point(761, 54);
            this.lblTelefonoM.Name = "lblTelefonoM";
            this.lblTelefonoM.Size = new System.Drawing.Size(0, 17);
            this.lblTelefonoM.TabIndex = 17;
            this.lblTelefonoM.Visible = false;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(1002, 113);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(51, 17);
            this.lollipopLabel1.TabIndex = 11;
            this.lollipopLabel1.Text = "Cliente";
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.BackColor = System.Drawing.Color.Transparent;
            this.lblRfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRfc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.lblRfc.Location = new System.Drawing.Point(948, 40);
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(0, 17);
            this.lblRfc.TabIndex = 15;
            this.lblRfc.Visible = false;
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(943, 20);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(35, 17);
            this.lollipopLabel3.TabIndex = 14;
            this.lollipopLabel3.Text = "RFC";
            this.lollipopLabel3.Visible = false;
            // 
            // lblNoCliente
            // 
            this.lblNoCliente.AutoSize = true;
            this.lblNoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.lblNoCliente.Location = new System.Drawing.Point(866, 41);
            this.lblNoCliente.Name = "lblNoCliente";
            this.lblNoCliente.Size = new System.Drawing.Size(0, 17);
            this.lblNoCliente.TabIndex = 13;
            this.lblNoCliente.Visible = false;
            // 
            // lollipopLabel5
            // 
            this.lollipopLabel5.AutoSize = true;
            this.lollipopLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel5.Location = new System.Drawing.Point(760, 36);
            this.lollipopLabel5.Name = "lollipopLabel5";
            this.lollipopLabel5.Size = new System.Drawing.Size(100, 17);
            this.lollipopLabel5.TabIndex = 16;
            this.lollipopLabel5.Text = "Teléfono Móvil";
            this.lollipopLabel5.Visible = false;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(860, 23);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(77, 17);
            this.lollipopLabel2.TabIndex = 12;
            this.lollipopLabel2.Text = "No. Cliente";
            this.lollipopLabel2.Visible = false;
            // 
            // lollipopLabel6
            // 
            this.lollipopLabel6.AutoSize = true;
            this.lollipopLabel6.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel6.Location = new System.Drawing.Point(940, 36);
            this.lollipopLabel6.Name = "lollipopLabel6";
            this.lollipopLabel6.Size = new System.Drawing.Size(125, 17);
            this.lollipopLabel6.TabIndex = 18;
            this.lollipopLabel6.Text = "Correo Electrónico";
            this.lollipopLabel6.Visible = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BGColor = "#6200EA";
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.Depth = 0;
            this.btnBuscarCliente.Icon = null;
            this.btnBuscarCliente.Location = new System.Drawing.Point(236, 103);
            this.btnBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Primary = true;
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 239;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // frmExpedienteLineaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1229, 648);
            this.Controls.Add(this.panelControl3);
            this.Name = "frmExpedienteLineaClientes";
            this.Text = "frmExpedienteLineaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialogDocumentos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblCampoRequerido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private LollipopLabel lollipopLabel6;
        private LollipopLabel lollipopLabel5;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel3;
        private LollipopLabel lollipopLabel1;
        private LollipopLabel lblNombre;
        private LollipopLabel lblCorreoE;
        private LollipopLabel lblTelefonoM;
        private LollipopLabel lblRfc;
        private LollipopLabel lblNoCliente;
        private MaterialSkin.Controls.MaterialContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private OvalPictureBox ovalPictureBox1;
        private System.Windows.Forms.ImageList imageListDrag;
		private LollipopButton lollipopButton1;
		private System.Windows.Forms.ToolStripMenuItem descargarToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog svdDocumento;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialListView lvCarpetas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MetroFramework.Controls.MetroProgressSpinner pgbCarga;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroLink lnkAtras;
        private MetroFramework.Controls.MetroLink lnkAdelante;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.ComponentModel.BackgroundWorker bgwLinks;
        private MetroFramework.Controls.MetroLink lnkHome;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.ComponentModel.BackgroundWorker bgwUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private MaterialSkin.Controls.MaterialRaisedButtonCustom btnBuscarCliente;
    }
}