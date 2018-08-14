namespace LxCallcenter
{
    partial class frmDirectorio
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
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.grdClientes = new DevExpress.XtraGrid.GridControl();
			this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
			this.IdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
			this.NoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
			this.NombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Rfc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Correo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TelMovil = new DevExpress.XtraGrid.Columns.GridColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lnkCerrar = new MetroFramework.Controls.MetroLink();
			this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// materialLabel2
			// 
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(23, 77);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(55, 19);
			this.materialLabel2.TabIndex = 1;
			this.materialLabel2.Text = "Buscar";
			this.materialLabel2.Visible = false;
			// 
			// txtBuscar
			// 
			this.txtBuscar.Depth = 0;
			this.txtBuscar.Hint = "Introduzca texto a buscar...";
			this.txtBuscar.Location = new System.Drawing.Point(29, 98);
			this.txtBuscar.MaxLength = 32767;
			this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.PasswordChar = '\0';
			this.txtBuscar.SelectedText = "";
			this.txtBuscar.SelectionLength = 0;
			this.txtBuscar.SelectionStart = 0;
			this.txtBuscar.Size = new System.Drawing.Size(196, 23);
			this.txtBuscar.TabIndex = 2;
			this.txtBuscar.TabStop = false;
			this.txtBuscar.UseSystemPasswordChar = false;
			this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
			// 
			// grdClientes
			// 
			this.grdClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.grdClientes.Location = new System.Drawing.Point(22, 76);
			this.grdClientes.LookAndFeel.SkinName = "Seven Classic";
			this.grdClientes.LookAndFeel.UseDefaultLookAndFeel = false;
			this.grdClientes.MainView = this.cardView1;
			this.grdClientes.Name = "grdClientes";
			this.grdClientes.Size = new System.Drawing.Size(310, 486);
			this.grdClientes.TabIndex = 240;
			this.grdClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
			// 
			// cardView1
			// 
			this.cardView1.Appearance.CardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
			this.cardView1.Appearance.CardCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
			this.cardView1.Appearance.CardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
			this.cardView1.Appearance.CardCaption.ForeColor = System.Drawing.Color.DimGray;
			this.cardView1.Appearance.CardCaption.Options.UseBackColor = true;
			this.cardView1.Appearance.CardCaption.Options.UseBorderColor = true;
			this.cardView1.Appearance.CardCaption.Options.UseForeColor = true;
			this.cardView1.Appearance.FieldValue.BackColor = System.Drawing.SystemColors.Control;
			this.cardView1.Appearance.FieldValue.BackColor2 = System.Drawing.SystemColors.Control;
			this.cardView1.Appearance.FieldValue.BorderColor = System.Drawing.SystemColors.Control;
			this.cardView1.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black;
			this.cardView1.Appearance.FieldValue.Options.UseBackColor = true;
			this.cardView1.Appearance.FieldValue.Options.UseBorderColor = true;
			this.cardView1.Appearance.FieldValue.Options.UseForeColor = true;
			this.cardView1.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
			this.cardView1.Appearance.FocusedCardCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
			this.cardView1.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
			this.cardView1.Appearance.FocusedCardCaption.Options.UseBackColor = true;
			this.cardView1.Appearance.FocusedCardCaption.Options.UseBorderColor = true;
			this.cardView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.cardView1.CardInterval = 4;
			this.cardView1.CardScrollButtonBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
			this.cardView1.CardWidth = 300;
			this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdCliente,
            this.NoCliente,
            this.NombreCliente,
            this.Rfc,
            this.Correo,
            this.TelMovil});
			this.cardView1.FocusedCardTopFieldIndex = 0;
			this.cardView1.GridControl = this.grdClientes;
			this.cardView1.Name = "cardView1";
			this.cardView1.OptionsBehavior.ReadOnly = true;
			this.cardView1.OptionsFilter.AllowColumnMRUFilterList = false;
			this.cardView1.OptionsFind.AlwaysVisible = true;
			this.cardView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
			this.cardView1.OptionsView.ShowCardExpandButton = false;
			this.cardView1.OptionsView.ShowQuickCustomizeButton = false;
			this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
			// 
			// IdCliente
			// 
			this.IdCliente.Caption = "Id Cliente";
			this.IdCliente.FieldName = "iIdCliente";
			this.IdCliente.Name = "IdCliente";
			// 
			// NoCliente
			// 
			this.NoCliente.Caption = "No. Cliente";
			this.NoCliente.FieldName = "sCliente";
			this.NoCliente.Name = "NoCliente";
			this.NoCliente.Visible = true;
			this.NoCliente.VisibleIndex = 0;
			// 
			// NombreCliente
			// 
			this.NombreCliente.Caption = "Nombre";
			this.NombreCliente.FieldName = "sNombre";
			this.NombreCliente.Name = "NombreCliente";
			this.NombreCliente.Visible = true;
			this.NombreCliente.VisibleIndex = 1;
			// 
			// Rfc
			// 
			this.Rfc.Caption = "RFC";
			this.Rfc.FieldName = "sRfc";
			this.Rfc.Name = "Rfc";
			this.Rfc.Visible = true;
			this.Rfc.VisibleIndex = 2;
			// 
			// Correo
			// 
			this.Correo.Caption = "Correo Electrónico";
			this.Correo.FieldName = "sCorreoElectronico";
			this.Correo.Name = "Correo";
			this.Correo.Visible = true;
			this.Correo.VisibleIndex = 3;
			// 
			// TelMovil
			// 
			this.TelMovil.Caption = "Teléfono Móvil";
			this.TelMovil.FieldName = "sNumeroMovil";
			this.TelMovil.Name = "TelMovil";
			this.TelMovil.Visible = true;
			this.TelMovil.VisibleIndex = 4;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::LxCallcenter.Properties.Resources.circled_user_male_45px;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(22, 17);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(36, 37);
			this.pictureBox1.TabIndex = 245;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri Light", 16F);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
			this.label1.Location = new System.Drawing.Point(55, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 27);
			this.label1.TabIndex = 246;
			this.label1.Text = "Mis Clientes";
			// 
			// lnkCerrar
			// 
			this.lnkCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lnkCerrar.Image = global::LxCallcenter.Properties.Resources.delete_sign_23px;
			this.lnkCerrar.Location = new System.Drawing.Point(304, 5);
			this.lnkCerrar.Name = "lnkCerrar";
			this.lnkCerrar.Size = new System.Drawing.Size(30, 27);
			this.lnkCerrar.TabIndex = 247;
			this.metroToolTip1.SetToolTip(this.lnkCerrar, "Cerrar");
			this.lnkCerrar.UseSelectable = true;
			this.lnkCerrar.Click += new System.EventHandler(this.lnkCerrar_Click);
			// 
			// metroToolTip1
			// 
			this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroToolTip1.StyleManager = null;
			this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
			this.panel1.Location = new System.Drawing.Point(0, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(2, 592);
			this.panel1.TabIndex = 248;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(22, 76);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(309, 47);
			this.panel2.TabIndex = 249;
			this.panel2.Visible = false;
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Enabled = false;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(56, 50);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(237, 19);
			this.materialLabel1.TabIndex = 250;
			this.materialLabel1.Text = "Visualice el directorio de clientes.";
			// 
			// frmDirectorio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(343, 591);
			this.Controls.Add(this.materialLabel1);
			this.Controls.Add(this.materialLabel2);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lnkCerrar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.grdClientes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmDirectorio";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmDirectorio";
			this.Load += new System.EventHandler(this.frmDirectorio_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        public DevExpress.XtraGrid.GridControl grdClientes;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn NoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn NombreCliente;
        private DevExpress.XtraGrid.Columns.GridColumn Rfc;
        private DevExpress.XtraGrid.Columns.GridColumn Correo;
        private DevExpress.XtraGrid.Columns.GridColumn TelMovil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLink lnkCerrar;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
	}
}