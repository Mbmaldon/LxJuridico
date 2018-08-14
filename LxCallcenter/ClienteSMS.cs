using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.Logica;
using System.IO;
using System.Net;

namespace LxCallcenter
{
	public partial class ClienteSMS : Form
	{
		UsuarioData AUsuario;
		ClienteData ACliente;
        //NetworkCredential _NetworkCredential = new NetworkCredential(ServerFile.sUser, ServerFile.sPassword);
        //string PathFolderShared = @"\\192.169.143.34\MiPyme_Files";

        // CONSTRUCOTOR
        public ClienteSMS()
		{
			InitializeComponent();
			AUsuario = UsuarioData.Instancia;
			ACliente = null;            
		}

        

        #region Eventos

        // EVENTO BOTON CUENTA EL NUMERO DE CARACTERES Y CONVERSION A MAYUSCULAS
        private void txbMensaje_KeyPress(Object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Char.ToUpper(e.KeyChar);
		}
		
		// EVENTO AL SELECCIONAR EL TEXBOX NUMERO DE CLIENTE
		private void txbNCliente_MouseClick(Object sender, MouseEventArgs e)
		{
			txbRfc.Text = "";
		}

		// EVENTO AL SELECCIONAR EL TEXBOX DE RFC
		private void txbRfc_MouseClick(Object sender, MouseEventArgs e)
		{
			txbNCliente.Text = "";
		}

		// EVENTO BOTON BUSCAR AL CLIENTE
		private void btnBuscar_Click(Object sender, EventArgs e)
		{
			ACliente = null;
			
			lblBuscarCliente.Visible = false;
			LimpiarControles();
			MensajeError.Clear();

			if(ValidarBusqueda() == 0)
			{
				ClienteBuscar ABuscar = new ClienteBuscar();

				ACliente = ABuscar.Buscar(txbNCliente.Text, 
										  txbRfc.Text, 
										  AUsuario.sIdusuario);

				if(ACliente != null)
				{
					txbNombre.Text = ACliente.sNombre + " " + 
									 ACliente.sAPaterno + " " + 
									 ACliente.sAMaterno;

					txbCelular.Text = ACliente.sTelefonoCelular;
					txbEMail.Text	= ACliente.sCorreoElectronico;
                    asignarFotografia(int.Parse(ACliente.sIdCliente));

                    cmbxMensaje.DataSource    = new Mensaje().lMensajes();
                    cmbxMensaje.ValueMember   = "iIdMensaje";
                    cmbxMensaje.DisplayMember = "sMensaje";
                    cmbxMensaje.SelectedIndex = -1;

                    //cmbxMensaje.DropDownWidth = DropDownWidth(cmbxMensaje);

                    if (ACliente.sActivo.Equals("True"))
					{
						gbMensaje.Visible = true;
					}
					else
					{
						lblCActivo.Visible = true;
					}
				}
				else
				{
					lblBuscarCliente.Visible = true;
				}
			}
		}

        /// <summary>
        /// Obtiene y asigna la foto de perfil de un cliente, si este no tiene, se le asigna una por default
        /// </summary>
        /// <param name="iIdCliente">Id del Cliente</param>
        void asignarFotografia(int iIdCliente)
        {
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
            //    if (File.Exists(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.jpg", iIdCliente)))
            //    {
            //        ovalPictureBox1.Load(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.jpg", iIdCliente));
            //    }
            //    else if (File.Exists(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.JPG", iIdCliente)))
            //    {
            //        ovalPictureBox1.Load(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.JPG", iIdCliente));
            //    }
            //    else if (File.Exists(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.jpeg", iIdCliente)))
            //    {
            //        ovalPictureBox1.Load(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.jpeg", iIdCliente));
            //    }
            //    else if (File.Exists(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.JPEG", iIdCliente)))
            //    {
            //        ovalPictureBox1.Load(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.JPEG", iIdCliente));
            //    }
            //    else if (File.Exists(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.png", iIdCliente)))
            //    {
            //        ovalPictureBox1.Load(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.png", iIdCliente));
            //    }
            //    else if (File.Exists(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.PNG", iIdCliente)))
            //    {
            //        ovalPictureBox1.Load(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.PNG", iIdCliente));
            //    }
            //    else
            //    {
            //        ovalPictureBox1.Image = Properties.Resources.circled_user_male_skin_type_1_2_96px;
            //    }
            //}
			ovalPictureBox1.Image = Properties.Resources.circled_user_male_skin_type_1_2_96px;
		}

		// EVENTO BOTON ENVIAR EL MENSAJE
		private void btnEnviar_Click(Object sender, EventArgs e)
		{
			if(ValidarMensaje() == 0)
			{
				MensajeCrear AMensaje = new MensajeCrear();
				if(AMensaje.Mensaje(AUsuario.sIdusuario, ACliente.sIdCliente, "2", txbMensaje.Text) == 0)
				{
                    LimpiarControles();
					FlatMessageBox.Show("Mensaje enviado correctamente","ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
				}
				else
				{
					FlatMessageBox.Show("Error al enviar el mensaje.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
				}
			}
		}

		// CONVIERTE EL TEXTO EN MAYUSCULAS
		private void Mayusculas(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)13)
            {
                btnBuscar_Click(sender, e);
            }
        }

		private void txbMensaje_KeyUp(Object sender, KeyEventArgs e)
		{
			//int tamaño = txbMensaje.Text.Length;
   //         lblCaracteres.Text = "Caracteres: " + tamaño.ToString() + " de 140.";
		}

		#endregion

		#region Funciones

		// VALIDA LOS TEXBOX DE BUSQUEDA DE CLIENTE
		private int ValidarBusqueda()
		{
			int iResultado = 0;

			if(txbNCliente.Text.Equals("") && txbRfc.Text.Equals(""))
			{
				FlatMessageBox.Show("Debe buscar un cliente por RFC o Número de cliente.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
				iResultado = 1;
			}

			return iResultado;
		}

		// VALIDA EL ENVIO DEL MENSAJE
		private int ValidarMensaje()
		{
			int iResultado = 0;
			MensajeError.Clear();

			if(txbNombre.Text.Equals(""))
			{
				MensajeError.SetError(txbNombre, "Debe buscar un cliente.");
				iResultado = 1;
			}

			if(txbMensaje.Text.Equals(""))
			{
				MensajeError.SetError(txbMensaje,"Debe seleccionar un mensaje");
				iResultado = 1;
			}

			if(!Mensaje(txbMensaje.Text))
			{
				FlatMessageBox.Show("El mensaje no debe contener caracteres especiales.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
				iResultado = 1;
			}

			return iResultado;
		}

		// LIMPIA LOS CONTROLES DEL CLIENTE
		private void LimpiarControles()
		{
			txbNombre.Text	= "";
			txbCelular.Text = "";
			txbEMail.Text	= "";
			txbMensaje.Text = "";
			lblCaracteres.Text = "Caracteres: 0 de 140.";
			gbMensaje.Visible = false;
			lblCActivo.Visible = false;
            asignarFotografia(-1);
        }

		// VALIDA QUE NO SE CONTENGA CARACTERES ESPECIALES
		private bool Mensaje(string sMensaje)
		{
			Regex AAlfaNumMess = new Regex("[^A-Z0-9\\s]");
			return !AAlfaNumMess.IsMatch(sMensaje);
		}

        #endregion

        private void txbMensaje_TextChanged(object sender, EventArgs e)
        {
            //int tamaño = txbMensaje.Text.Length;
            //lblCaracteres.Text = "Caracteres: " + tamaño.ToString() + " de 140.";

            //string sMensaje = txbMensaje.Text;
            //txbMensaje.Text = sMensaje.ToUpper().ToString();
            //SendKeys.Send("^{END}");
        }


        /// <summary>
        /// Obtiene el tamaño maximo que tendra un combobox de acuerdo al tamaño de sus items
        /// </summary>
        /// <param name="myCombo">ComboBox del cual se obtendran los items para establecer el tamaño</param>
        /// <returns></returns>
        //int DropDownWidth(MetroFramework.Controls.MetroComboBox myCombo)
        //{
        //    int widestStringInPixels = 0;
        //    foreach (Object o in myCombo.Items)
        //    {
        //        string toCheck;
        //        System.Reflection.PropertyInfo pinfo;
        //        Type objectType = o.GetType();
        //        if (myCombo.DisplayMember.CompareTo("") == 0)
        //        {
        //            toCheck = o.ToString();

        //        }
        //        else
        //        {
        //            pinfo = objectType.GetProperty(myCombo.DisplayMember);
        //            toCheck = pinfo.GetValue(o, null).ToString();

        //        }
        //        if (TextRenderer.MeasureText(toCheck, myCombo.Font).Width > widestStringInPixels)
        //            widestStringInPixels = TextRenderer.MeasureText(toCheck, myCombo.Font).Width;
        //    }
        //    return widestStringInPixels + 35;
        //}

        private void cmbxMensaje_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Mensaje sms     = new Mensaje().obtenerMensaje(int.Parse(cmbxMensaje.SelectedValue.ToString()));
            txbMensaje.Text = string.Empty;
            txbMensaje.Text = sms.sMensajeContenido;
        }
    }
}
