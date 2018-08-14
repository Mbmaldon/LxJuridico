namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	partial class frmComisionAsigIdBancBat
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
			this.lnkConfigurar = new MetroFramework.Controls.MetroLink();
			this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
			this.SuspendLayout();
			// 
			// lnkConfigurar
			// 
			this.lnkConfigurar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lnkConfigurar.Image = global::LxCallcenter.Properties.Resources.delete_sign_filled_23px;
			this.lnkConfigurar.ImageSize = 25;
			this.lnkConfigurar.Location = new System.Drawing.Point(510, 11);
			this.lnkConfigurar.Name = "lnkConfigurar";
			this.lnkConfigurar.NoFocusImage = global::LxCallcenter.Properties.Resources.delete_sign_23px;
			this.lnkConfigurar.Size = new System.Drawing.Size(25, 25);
			this.lnkConfigurar.TabIndex = 240;
			this.metroToolTip1.SetToolTip(this.lnkConfigurar, "Cerrar");
			this.lnkConfigurar.UseSelectable = true;
			// 
			// metroToolTip1
			// 
			this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroToolTip1.StyleManager = null;
			this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// frmComisionAsigIdBancBat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(539, 332);
			this.Controls.Add(this.lnkConfigurar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmComisionAsigIdBancBat";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmComisionAsigIdBancBat";
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroLink lnkConfigurar;
		private MetroFramework.Components.MetroToolTip metroToolTip1;
	}
}