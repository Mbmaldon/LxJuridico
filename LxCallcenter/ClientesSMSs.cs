using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using LogicaCC.Logica;

namespace LxCallcenter
{
	public partial class ClientesSMSs : Form
	{
		UsuarioData AUsuario;

		// CONSTRUCTOR
		public ClientesSMSs()
		{
			InitializeComponent();
			AUsuario = UsuarioData.Instancia;

            cmbxMensaje.DataSource    = new Mensaje().lMensajes();
            cmbxMensaje.ValueMember   = "iIdMensaje";
            cmbxMensaje.DisplayMember = "sMensaje";
            cmbxMensaje.SelectedIndex = -1;
        }

		#region EVENTOS_CONTROLES

		// EVENTO ENVIAR MENSAJE
		private void btnEnviar_Click(Object sender, EventArgs e)
		{
			if(ValidarMensaje() == 0)
			{
				if(Mensaje(txbMensaje.Text))
				{
					MensajeCrear AMensaje = new MensajeCrear();
					if(AMensaje.Mensaje(AUsuario.sIdusuario, "1", "2", txbMensaje.Text) == 0)
					{
						lblCaracteres.Text = "Caracteres: 0 de 140.";

						EnviarMensajes AMensajes = new EnviarMensajes();
						AMensajes.Mensaje = txbMensaje.Text;
						txbMensaje.Text = "";
						AMensajes.Show();
					}
					else
					{
						FlatMessageBox.Show("Error al enviar el mensaje."," ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
					}
				}
				else
				{
					FlatMessageBox.Show("El mensaje no debe contener caracteres especiales.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
				}
			}
		}

		// EVENTO PARA IR CONTANDO EL NUMEOR DE CARACTERES
		private void txbMensaje_KeyUp(object sender, KeyEventArgs e)
		{
			//int tamaño = txbMensaje.Text.Length;
			//lblCaracteres.Text = "Caracteres: " + tamaño.ToString() + " de 140.";
		}

		// EVENTO PARA CONVERTIR EL TEXTO EN MAYUSCULAS
		private void txbMensaje_KeyPress(object sender, KeyPressEventArgs e)
		{
			//e.KeyChar = Char.ToUpper(e.KeyChar);
		}

		#endregion EVENTOS_CONTROLES

		#region FUNCIONES

		// VALIDA QUE EL MENSAJE NO ESTE VACIO
		private int ValidarMensaje()
		{
			int iResultado = 0;

			MensajeError.Clear();

			if(txbMensaje.Text.Equals(""))
			{
				iResultado = 1;
				MensajeError.SetError(txbMensaje, "Debe seleccionar un mensaje.");
			}
			return iResultado;
		}

		// VALIDA QUE EL MENSAJE SE ALFANUMERICO
		private bool Mensaje(string sMensaje)
		{
			Regex AAlfaNumMess = new Regex("[^A-Z0-9\\s\\.]");
			return !AAlfaNumMess.IsMatch(sMensaje);
		}

        #endregion FUNCIONES

        private void txbMensaje_TextChanged(object sender, EventArgs e)
        {
            //int tamaño = txbMensaje.Text.Length;
            //lblCaracteres.Text = "Caracteres: " + tamaño.ToString() + " de 140.";

            //string sMensaje = txbMensaje.Text;
            //txbMensaje.Text = sMensaje.ToUpper().ToString();
            //SendKeys.Send("^{END}");
        }

        private void cmbxMensaje_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Mensaje sms     = new Mensaje().obtenerMensaje(int.Parse(cmbxMensaje.SelectedValue.ToString()));
            txbMensaje.Text = string.Empty;
            txbMensaje.Text = sms.sMensajeContenido;
        }
    }
}
