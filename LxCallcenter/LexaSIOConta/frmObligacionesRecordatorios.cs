using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.LexaSIOContaLogica;

namespace LxCallcenter.LexaSIOConta
{
	public partial class frmObligacionesRecordatorios : Form
	{
		Cliente Cliente;
		LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
		public int iIdUsuario;
		public List<DetalleObligacion> obligaciones;

		public frmObligacionesRecordatorios()
		{
			InitializeComponent();
			iIdUsuario = int.Parse(AUsuarioData.sIdusuario);
		}

		private void btnBuscarCliente_Click(Object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtCliente.Text))
			{
				lblCampoRequerido.Visible = false;
				cargarInformacion();
			}
			else
			{
				lblCampoRequerido.Text				= "*Campo Requerido";
				lblCampoRequerido.Visible			= true;
				//pnlInformacionObligacion.Visible	= false;
				ControlesVisibles(false);
			}
		}

		void ControlesVisibles(bool bEstado)
		{
			pnlSemaforo.Visible				= bEstado;
			lollipopButton1.Visible			= bEstado;
			lblDetalleObligacion.Visible	= bEstado;
			//lblRegimen.Visible				= bEstado;
			//flowLayoutPanel1.Visible		= bEstado;
			materialLabel2.Visible			= bEstado;
			separatorControl1.Visible		= bEstado;
			txtObservaciones.Visible		= bEstado;
			btnGenerarDeclaracion.Visible	= bEstado;
            lblRegimen.Visible              = bEstado;
		}


		public void cargarInformacion()
        {
            //INFORMACIÓN DEL CLIENTE        
            Cliente                     = new Cliente().InformacionCliente(txtCliente.Text, iIdUsuario);
            if(Cliente != null)
            {
                lblCampoRequerido.Visible   = false;
                //lblCliente.Text             = string.Format("{0} {1} {2}", Cliente.sNombre, Cliente.sAPaterno, Cliente.sAMaterno);
                txtNombre.Text              = string.Format("{0} {1} {2}", Cliente.sNombre, Cliente.sAPaterno, Cliente.sAMaterno);
                txtRfc.Text                 = Cliente.sRfc;
                txtTelefono.Text            = Cliente.sTelefono;
                txtCelular.Text             = Cliente.sNumeroMovil;
                txtExtension.Text           = Cliente.sExtension;
                txtCorreoElectronico.Text   = Cliente.sCorreoElectronico;

                if (Cliente.iIdRegimen == 2)
                    ovalPictureBox1.Image = Properties.Resources.skyscrapers_96px;
                else
                    ovalPictureBox1.Image = Properties.Resources.circled_user_male_skin_type_1_2_96px;

                pnlInformacion.Visible      = true;


                //lblDomicilio.Text           = string.Format("{0}, {1}", Cliente.sDireccion, Cliente.sMunicipio);
                //lblCp.Text                  = Cliente.sCodigoPostal;

                //CARGAMOS LISTA DE OBLIGACIONES FISCALES
                cargarObligaciones(txtCliente.Text);
                //EstadoControles(true);
                //pnlInformacionObligacion.Visible = false;
            }
            else
            {
                //EstadoControles(false);
                //lblCampoRequerido.Text              = "*No se encontro el cliente";
                
                //pnlInformacionObligacion.Visible    = false;
                FlatMessageBox.Show(string.Format("El cliente que intentas buscar, aun no tiene{0}obligaciones fiscales asignadas, contacte{1}con sus supervisor.", Environment.NewLine, Environment.NewLine), "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
            }
        }

		private void txtCliente_KeyPress(Object sender, KeyPressEventArgs e)
		{
			/*Convierte en mayusculas*/
			e.KeyChar = Char.ToUpper(e.KeyChar);

			/*Si la tecla es un enter, se ejecuta el evento click del botón Buscar*/
			if (e.KeyChar == (char)13)
				btnBuscarCliente_Click(sender, e);
		}

		void cargarObligaciones(string sCliente)
		{
			//OBTIENE UNA LISTA DE OBLIGACIONES CORRESPONDIENTES A AL REGIMEN DONDE SE ENCUENTRA EL CLIENTE
			DetalleObligacion obligacion = new DetalleObligacion();
			obligaciones = obligacion.GetListObligacionesRecordatorios(sCliente);

			if (obligaciones.Count > 0)
			{
				pnlListaObligaciones.Controls.Clear();
				//CREA UNA LISTA DINAMICA DE OBLIGACIONES FISCALES
				for (int i = 0; i < obligaciones.Count; i++)
				{
					Button btnObligacion                      = new Button();
					btnObligacion.Location                    = new Point(5, 24 * i + 0);
					//btnObligacion.Name                        = obligaciones[i].iIdDetalleObligacion.ToString();
					btnObligacion.Text                        = obligaciones[i].sDetalleObligacion;
					btnObligacion.Font                        = new Font("Segoe UI", 9);
					btnObligacion.Width                       = 222;
					btnObligacion.Height                      = 24;
					btnObligacion.FlatStyle                   = FlatStyle.Flat;
					btnObligacion.FlatAppearance.BorderSize   = 0;
					btnObligacion.Cursor                      = Cursors.Hand;

					Panel ptbEstado     = new Panel();
					ptbEstado.Location  = new Point(0, 24 * i + 0);
					ptbEstado.Width     = 5;
					ptbEstado.Height    = 24;

					ptbEstado.BackColor = Color.FromArgb(48, 63, 159);
					btnObligacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 81, 181);

					DetalleObligacion _Detail = new DetalleObligacion();
					int? iNull = null;
                    _Detail.iIdObligacion = obligaciones[i].iIdObligacion;
                    _Detail.iIdDetalleObligacion = obligaciones[i].iIdDetalleObligacion;
                    _Detail.sDetalleObligacion	= obligaciones[i].sDetalleObligacion;
                    _Detail.sObligacion = obligaciones[i].sObligacion;

					btnObligacion.ImageAlign         = ContentAlignment.TopLeft;
					btnObligacion.TextAlign          = ContentAlignment.MiddleLeft;
					btnObligacion.TextImageRelation  = TextImageRelation.ImageBeforeText;
					btnObligacion.AutoEllipsis       = true;
					//CREAMOS EL EVENTO CLICK DEL BOTON
					//btnObligacion.Click += BtnObligacion_Click;
					btnObligacion.Click += delegate (object sender, EventArgs e) { BtnObligacion_Click(sender, e, _Detail); };
					pnlListaObligaciones.Controls.Add(ptbEstado);
					pnlListaObligaciones.Controls.Add(btnObligacion);

					pnlListaObligaciones.Controls.Add(btnObligacion);
				}
			}
			else
			{
				pnlListaObligaciones.Controls.Clear();
				Label lblNotifica		= new Label();
				lblNotifica.Text		= string.Format("No Se Encontraron{0}Obligaciones Fiscales{0}Asignadas.", Environment.NewLine);
				lblNotifica.Font		= new Font("Segoe UI", 13);
				lblNotifica.Size		= new Size(179, 75);
				lblNotifica.ForeColor	= Color.FromArgb(200, 200, 200);//105
				lblNotifica.TextAlign	= ContentAlignment.MiddleCenter;

				lblNotifica.Left	= (pnlListaObligaciones.ClientSize.Width - lblNotifica.Width) / 2;
				lblNotifica.Top		= (pnlListaObligaciones.ClientSize.Height - lblNotifica.Height) / 2;

				pnlListaObligaciones.Controls.Add(lblNotifica);
			}
		}

		static DetalleObligacion _DetalleObligacion = new DetalleObligacion();
		public static int iIdRegistroObligacionSeleccionada;
		public static int iIdObligacionDetalle;
		DetalleObligacion detalleObligacion = null;
		private void BtnObligacion_Click(Object sender, EventArgs e, DetalleObligacion _Detalle)
		{
			Button button = sender as Button;

			_DetalleObligacion = _Detalle;

			int iIdDetaleObligacion = 0;
            iIdDetaleObligacion = _DetalleObligacion.iIdDetalleObligacion;

            //INFORMACIÓN DE LAS OBLIGACIONES FISCALES
            detalleObligacion = new DetalleObligacion().GetDetalleObligacion(iIdDetaleObligacion);

            iIdRegistroObligacionSeleccionada = detalleObligacion.iIdDetalleObligacion;
            lblDetalleObligacion.Text         = detalleObligacion.sDetalleObligacion;
			txtObservaciones.Text			  = detalleObligacion.sFormaPresentacion;
            lblRegimen.Text                   = _Detalle.sObligacion;

            ControlesVisibles(true);

			if (detalleObligacion.sfechaVerde == detalleObligacion.sfechaAmarillo && detalleObligacion.sfechaVerde == detalleObligacion.sfechaRojo)
			{
				pictureBox1.Visible			= false;
				lblFechaVerde.Visible		= false;
				lblFechaAmarillo.Visible	= false;
				lblFechaRojo.Visible		= false;
				lblCumplimientoInmediato.Visible = true;
			}
			else
			{
				lblCumplimientoInmediato.Visible = false;
				pictureBox1.Visible			= true;
				lblFechaVerde.Visible		= true;
				lblFechaAmarillo.Visible	= true;
				lblFechaRojo.Visible		= true;
			}

			lblFechaVerde.Text                  = String.Format("{0:d}", DateTime.Parse(detalleObligacion.sfechaVerde));
			lblFechaAmarillo.Text               = String.Format("{0:d}", DateTime.Parse(detalleObligacion.sfechaAmarillo));
			lblFechaRojo.Text                   = String.Format("{0:d}", DateTime.Parse(detalleObligacion.sfechaRojo));


			iIdObligacionDetalle = detalleObligacion.iIdDetalleObligacion;

            cambiarColor(button.Text);
		}

		/// <summary>
		/// Cambia el color de la obligación seleccionada en el listado de estas
		/// </summary>
		/// <param name="IdObligacion">Id de la obligación seleccionada</param>
		public void cambiarColor(string sObligacion)
		{
			foreach (Control x in pnlListaObligaciones.Controls)
			{
				if (x is Button)
				{
					if (x.Text == sObligacion.ToString())
						x.BackColor = Color.FromArgb(0xB3, 0xB3, 0xB3);
					else
						x.BackColor = Color.White;
				}
			}
		}

		private void btnGenerarDeclaracion_Click(Object sender, EventArgs e)
		{
			if (FlatMessageBox.Show("¿Esta seguro de generar este recordatorio?", "SI", "NO", FlatMessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
                    if (_DetalleObligacion.iIdDetalleObligacion > 0)
					{
                        int iResultado = 1;
                        iResultado = new RegistroObligacion().AddRecordatorio(new RegistroObligacion()
						{
							iIdDetalleObligacion		= _DetalleObligacion.iIdDetalleObligacion,
							iIdCliente					= Cliente.iIdCliente,
							iIdUsuarioRegistra			= int.Parse(AUsuarioData.sIdusuario),
							sFechaCumplimientoVerde		= detalleObligacion.sfechaVerde,
							sFechaCumplimientoAmarillo	= detalleObligacion.sfechaAmarillo,
							sFechaCumplimientoRojo		= detalleObligacion.sfechaRojo
						});
					
					    if (iResultado > 0)
					    {
						    FlatMessageBox.Show("Recordatorio Guardado", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
					    }
					    else if(iResultado == 0)
					    {
						    FlatMessageBox.Show("Error al guardar en la base de datos", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
					    }
					    else if (iResultado == -1)
					    {
						    FlatMessageBox.Show("Error de conexión, reintente en un momento", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
					    }
                    }
                }
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
	}
}
