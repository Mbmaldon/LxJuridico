namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	partial class frmConciliacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlOperaciones = new DevExpress.XtraEditors.PanelControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblRegistros = new MaterialSkin.Controls.MaterialLabel();
            this.lblPorcentaje = new MaterialSkin.Controls.MaterialLabel();
            this.lblArchivos = new MaterialSkin.Controls.MaterialLabel();
            this.pgbCargaBancos = new LollipopProgressBar();
            this.btnBanco3 = new LollipopSmallCard();
            this.btnBanco2 = new LollipopSmallCard();
            this.btnBanco1 = new LollipopSmallCard();
            this.btnGuardar = new LollipopButton();
            this.ofdBanco1 = new System.Windows.Forms.OpenFileDialog();
            this.ofdBanco2 = new System.Windows.Forms.OpenFileDialog();
            this.ofdBanco3 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.bgwCargas = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOperaciones)).BeginInit();
            this.pnlOperaciones.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 64);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1330, 1);
            this.panel4.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.label4.Location = new System.Drawing.Point(27, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 33);
            this.label4.TabIndex = 92;
            this.label4.Text = "Carga de Pagos Bancarios";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.lblFecha.Location = new System.Drawing.Point(28, 35);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(269, 22);
            this.lblFecha.TabIndex = 93;
            this.lblFecha.Text = "Realiza la carga de pagos bancarios...";
            // 
            // pnlOperaciones
            // 
            this.pnlOperaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlOperaciones.Controls.Add(this.panel7);
            this.pnlOperaciones.Location = new System.Drawing.Point(129, 80);
            this.pnlOperaciones.Name = "pnlOperaciones";
            this.pnlOperaciones.Size = new System.Drawing.Size(1056, 604);
            this.pnlOperaciones.TabIndex = 99;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Controls.Add(this.materialLabel1);
            this.panel7.Controls.Add(this.lblRegistros);
            this.panel7.Controls.Add(this.lblPorcentaje);
            this.panel7.Controls.Add(this.lblArchivos);
            this.panel7.Controls.Add(this.pgbCargaBancos);
            this.panel7.Controls.Add(this.btnBanco3);
            this.panel7.Controls.Add(this.btnBanco2);
            this.panel7.Controls.Add(this.btnBanco1);
            this.panel7.Controls.Add(this.btnGuardar);
            this.panel7.Location = new System.Drawing.Point(2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1052, 600);
            this.panel7.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Enabled = false;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(135, 53);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(768, 19);
            this.materialLabel1.TabIndex = 25;
            this.materialLabel1.Text = "Seleccione los archivos que contengas los pagos bancarios de los clientes. Estos " +
    "deben ir separados por banco.";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Depth = 0;
            this.lblRegistros.Enabled = false;
            this.lblRegistros.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRegistros.Location = new System.Drawing.Point(329, 350);
            this.lblRegistros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(400, 19);
            this.lblRegistros.TabIndex = 24;
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Depth = 0;
            this.lblPorcentaje.Enabled = false;
            this.lblPorcentaje.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPorcentaje.Location = new System.Drawing.Point(473, 282);
            this.lblPorcentaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(114, 19);
            this.lblPorcentaje.TabIndex = 23;
            this.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchivos
            // 
            this.lblArchivos.Depth = 0;
            this.lblArchivos.Enabled = false;
            this.lblArchivos.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblArchivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblArchivos.Location = new System.Drawing.Point(329, 327);
            this.lblArchivos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(400, 20);
            this.lblArchivos.TabIndex = 23;
            this.lblArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgbCargaBancos
            // 
            this.pgbCargaBancos.BGColor = "#508ef5";
            this.pgbCargaBancos.Location = new System.Drawing.Point(329, 305);
            this.pgbCargaBancos.Name = "pgbCargaBancos";
            this.pgbCargaBancos.Size = new System.Drawing.Size(400, 4);
            this.pgbCargaBancos.TabIndex = 22;
            this.pgbCargaBancos.Text = "lollipopProgressBar1";
            this.pgbCargaBancos.Value = 0;
            this.pgbCargaBancos.Visible = false;
            // 
            // btnBanco3
            // 
            this.btnBanco3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanco3.FontColor = "#EC0000";
            this.btnBanco3.Image = global::LxCallcenter.Properties.Resources._8s_3eZNf_400x400;
            this.btnBanco3.Info = "Santander";
            this.btnBanco3.Location = new System.Drawing.Point(725, 112);
            this.btnBanco3.Name = "btnBanco3";
            this.btnBanco3.Size = new System.Drawing.Size(182, 52);
            this.btnBanco3.TabIndex = 21;
            this.btnBanco3.Text = "Seleccionar Archivo";
            this.btnBanco3.ThumbnailColor = "#EC0000";
            this.btnBanco3.Click += new System.EventHandler(this.btnBanco3_Click);
            // 
            // btnBanco2
            // 
            this.btnBanco2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanco2.FontColor = "#0E2B89";
            this.btnBanco2.Image = global::LxCallcenter.Properties.Resources.bancomer;
            this.btnBanco2.Info = "Bancomer";
            this.btnBanco2.Location = new System.Drawing.Point(432, 112);
            this.btnBanco2.Name = "btnBanco2";
            this.btnBanco2.Size = new System.Drawing.Size(182, 52);
            this.btnBanco2.TabIndex = 20;
            this.btnBanco2.Text = "Seleccionar Archivo";
            this.btnBanco2.ThumbnailColor = "#1C5BA2";
            this.btnBanco2.Click += new System.EventHandler(this.btnBanco2_Click);
            // 
            // btnBanco1
            // 
            this.btnBanco1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanco1.FontColor = "#90191C";
            this.btnBanco1.Image = global::LxCallcenter.Properties.Resources.banorte1;
            this.btnBanco1.Info = "Banorte";
            this.btnBanco1.Location = new System.Drawing.Point(139, 112);
            this.btnBanco1.Name = "btnBanco1";
            this.btnBanco1.Size = new System.Drawing.Size(182, 52);
            this.btnBanco1.TabIndex = 19;
            this.btnBanco1.Text = "Seleccionar Archivo";
            this.btnBanco1.ThumbnailColor = "#90191C";
            this.btnBanco1.Click += new System.EventHandler(this.btnBanco1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BGColor = "#3f51b5";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FontColor = "#ffffff";
            this.btnGuardar.Location = new System.Drawing.Point(473, 242);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 22);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Realizar carga";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ofdBanco1
            // 
            this.ofdBanco1.Filter = "Archivos Excel|*.xlsx; *.xls;";
            // 
            // ofdBanco2
            // 
            this.ofdBanco2.Filter = "Archivos Excel|*.xlsx; *.xls;";
            // 
            // ofdBanco3
            // 
            this.ofdBanco3.Filter = "Archivos CSV(*.csv)|*.csv";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // bgwCargas
            // 
            this.bgwCargas.WorkerReportsProgress = true;
            this.bgwCargas.WorkerSupportsCancellation = true;
            this.bgwCargas.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCargas_DoWork);
            this.bgwCargas.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwCargas_ProgressChanged);
            this.bgwCargas.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCargas_RunWorkerCompleted);
            // 
            // frmConciliacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1325, 724);
            this.Controls.Add(this.pnlOperaciones);
            this.Controls.Add(this.panel1);
            this.Name = "frmConciliacion";
            this.Text = "frmConciliacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOperaciones)).EndInit();
            this.pnlOperaciones.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblFecha;
		private DevExpress.XtraEditors.PanelControl pnlOperaciones;
		private System.Windows.Forms.Panel panel7;
		private LollipopButton btnGuardar;
		private LollipopSmallCard btnBanco1;
		private LollipopSmallCard btnBanco3;
		private LollipopSmallCard btnBanco2;
		private System.Windows.Forms.OpenFileDialog ofdBanco1;
		private System.Windows.Forms.OpenFileDialog ofdBanco2;
		private System.Windows.Forms.OpenFileDialog ofdBanco3;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private MetroFramework.Components.MetroToolTip metroToolTip1;
		private LollipopProgressBar pgbCargaBancos;
		private System.ComponentModel.BackgroundWorker bgwCargas;
		private MaterialSkin.Controls.MaterialLabel lblArchivos;
		private MaterialSkin.Controls.MaterialLabel lblRegistros;
		private MaterialSkin.Controls.MaterialLabel lblPorcentaje;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
	}
}