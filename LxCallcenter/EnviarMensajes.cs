using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LogicaCC.Logica;
using System.Collections;
using System.Net.Mail;

namespace LxCallcenter
{
	public partial class EnviarMensajes : Form
	{
		const int MF_BYPOSITION = 0x400;
		string sMensaje;
		ArrayList AClientesL = new ArrayList();

        // CONSTRUCTOR
        public EnviarMensajes()
        {
            InitializeComponent();
        }

		#region EVENTOS

		// DESHABILITA EL BOTON CERRAR DEL FORMULARIO.
		[DllImport("User32")]
		private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
		[DllImport("User32")]
		private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
		[DllImport("User32")]
		private static extern int GetMenuItemCount(IntPtr hWnd);

        // ELIMINA EL BOTON DE CERRAR VENTANA
		private void EnviarMensajes_Load(Object sender, EventArgs e)
		{
			IntPtr hMenu = GetSystemMenu(this.Handle, false);
			int menuItemCount = GetMenuItemCount(hMenu);
			RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
            // EJECUTA EL PROCESO EN SEGUNDO PLANO
			backgroundWorker1.RunWorkerAsync();
		}

        // EVENTO QUE ENVIA EL MENSAJE
        private void backgroundWorker1_DoWork(Object sender, DoWorkEventArgs e)
        {
            EnviarMensaje();
        }

        // EVENTO QUE MANEJA LOS CONTROLES, ACTUALIZA LA BARRA DE CARGA
        private void backgroundWorker1_ProgressChanged(Object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        // EVENTO QUE MANEJA EL ESTADO DE LA VENTANA
        private void backgroundWorker1_RunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                FlatMessageBox.Show("La operacion ha sido cancelada", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
            }
            else if (e.Error != null)
            {
                FlatMessageBox.Show("Error al tratar de enviar los mensajes.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
            }
            else
            {
                FlatMessageBox.Show("Los mensaje fueron enviados exitosamente.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
            }
            this.Close();
        }

		#endregion

		#region FUNCIONES

        // GET:SET MENSAJE
        public string Mensaje
        {
            set
            {
                sMensaje = value;
            }
        }

        // FUNCION QUE OBTIENE EL LISTADO DE CLIENTES A SER ENVIADOS EL MENSAJE
		private void EnviarMensaje()
		{
			UsuarioData AUsuario = UsuarioData.Instancia;
			ClientesAsignados AClientes = new ClientesAsignados(AUsuario.sIdusuario);
			int i = 0;
			int Sumas;
			

			AClientesL = AClientes.ListaClientes();

			Sumas = 100/AClientesL.Count;

			foreach(ClienteInfoSMS Client in AClientesL)
			{
				i = i + Sumas;
				backgroundWorker1.ReportProgress(i, DateTime.Now);
				EnviarCorreo(Client.TelMovil, sMensaje);
			}
		}

        // FUNCION QUE ENVIA EL MENSAJE (EMAIL)
		private void EnviarCorreo(string sNumero, string sMensaje)
		{
			MailMessage mMensaje = new MailMessage();

			mMensaje.To.Add("lexa.sio@lexatax.com.mx");
			mMensaje.From = new MailAddress("soporte@lexa.com.mx", "Lexa Medic"/*"MIPyME 360"*/, System.Text.Encoding.UTF8);
			mMensaje.Subject = sNumero;
			mMensaje.SubjectEncoding = System.Text.Encoding.UTF8;
			mMensaje.Body = sMensaje;
			mMensaje.BodyEncoding = System.Text.Encoding.UTF8;
			mMensaje.IsBodyHtml = false;

			//Aquí es donde se hace lo especial
			SmtpClient client = new SmtpClient();
			client.Credentials = new System.Net.NetworkCredential("soporte@lexa.com.mx", "SysLex@1216");
			client.Port = 587;
			client.Host = "smtp.gmail.com";
			client.EnableSsl = true;

			try
			{
				client.Send(mMensaje);
			}
			catch(System.Net.Mail.SmtpException ex)
			{
				Console.WriteLine(ex.Message);
				Console.ReadLine();
			}
		}

		#endregion
	}
}