﻿namespace LxCallcenter.LexaSIOConta
{
	partial class frmRecordatorios
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
			this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pnlObligaciones = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnBuscar = new MetroFramework.Controls.MetroLink();
			this.label3 = new System.Windows.Forms.Label();
			this.btnOK = new LollipopButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// metroToolTip1
			// 
			this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroToolTip1.StyleManager = null;
			this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(98, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 30);
			this.label1.TabIndex = 226;
			this.label1.Text = "Hola,";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(100, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(463, 42);
			this.label2.TabIndex = 226;
			this.label2.Text = "te recordamos revisar con los medicos asignados si tienen alguna\r\nde las siguient" +
    "es obligaciones fiscales por cumplir.";
			// 
			// pnlObligaciones
			// 
			this.pnlObligaciones.AutoScroll = true;
			this.pnlObligaciones.Location = new System.Drawing.Point(45, 105);
			this.pnlObligaciones.Name = "pnlObligaciones";
			this.pnlObligaciones.Size = new System.Drawing.Size(564, 175);
			this.pnlObligaciones.TabIndex = 227;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LxCallcenter.Properties.Resources.alarm_clock_99px;
			this.pictureBox1.Location = new System.Drawing.Point(-19, -34);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(99, 99);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 225;
			this.pictureBox1.TabStop = false;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.Image = global::LxCallcenter.Properties.Resources.appointment_reminders_20px;
			this.btnBuscar.ImageSize = 20;
			this.btnBuscar.Location = new System.Drawing.Point(16, 274);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.NoFocusImage = global::LxCallcenter.Properties.Resources.appointment_reminders_20px;
			this.btnBuscar.Size = new System.Drawing.Size(23, 23);
			this.btnBuscar.TabIndex = 224;
			this.metroToolTip1.SetToolTip(this.btnBuscar, "Buscar Cliente");
			this.btnBuscar.UseSelectable = true;
			this.btnBuscar.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label3.Location = new System.Drawing.Point(17, 297);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(496, 30);
			this.label3.TabIndex = 228;
			this.label3.Text = "Nota:\r\nPara realizar estas obligaciones, ingresa al menu Obligaciones Fiscales, o" +
    "pción Recordatorios.";
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.Transparent;
			this.btnOK.BGColor = "#3f51b5";
			this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOK.FontColor = "#ffffff";
			this.btnOK.Location = new System.Drawing.Point(537, 307);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(99, 21);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// frmRecordatorios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(657, 340);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pnlObligaciones);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmRecordatorios";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmRecordatorios";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private LollipopButton btnOK;
		private MetroFramework.Components.MetroToolTip metroToolTip1;
		private MetroFramework.Controls.MetroLink btnBuscar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel pnlObligaciones;
		private System.Windows.Forms.Label label3;
	}
}