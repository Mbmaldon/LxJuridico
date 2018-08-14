using LogicaCC.LexaSIOContaLogica;
using MaterialSkin.Controls;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter.LexaSIOConta
{
    public partial class frmObligacionesEditarCliente : Form
    {
        public List<DetalleObligacion> obligacionesAsignadas;
        Cliente Cliente;
        FPrincipal _frmPrincipal;
		bool bISRH = false;
		bool bISRA = false;
		public frmObligacionesEditarCliente()
        {
            InitializeComponent();

			_frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;
        }

        void cargarObligaciones(string sCliente, int iIdCliente)
        {
            //OBTIENE UNA LISTA DE OBLIGACIONES CORRESPONDIENTES A AL REGIMEN DONDE SE ENCUENTRA EL CLIENTE
            DetalleObligacion obligacion  = new DetalleObligacion();
            obligacionesAsignadas         = obligacion.listaObligaciones(sCliente);

            if(obligacionesAsignadas.Count > 0)
            {
                pnlListaObligaciones.Controls.Clear();
				//CREA UNA LISTA DINAMICA DE OBLIGACIONES FISCALES
				List<DetalleObligacion> obligaciones = new DetalleObligacion().GetListObligaciones(16, 17, 18, 19, 20, 21, 22, 23, 24, 25);
				for (int i = 0; i < obligaciones.Count; i++)
				{
					MaterialSkin.Controls.MaterialLabel lblObligacion = new MaterialSkin.Controls.MaterialLabel();
					lblObligacion.Location		= new Point(2, 28 * i + 20);
					lblObligacion.Text			= string.Format("{0}. {1}", (i + 1).ToString(), obligaciones[i].sDetalleObligacion);
					lblObligacion.Width			= 400;
					lblObligacion.AutoEllipsis	= true;
					
					DevExpress.XtraEditors.SeparatorControl separador = new DevExpress.XtraEditors.SeparatorControl();
					separador.LineOrientation	= Orientation.Horizontal;
					separador.Size				= new Size(590, 18);// 937, 18
					separador.Location			= new Point(365, lblObligacion.Location.Y + 15);

					pnlListaObligaciones.Controls.Add(separador);

					pnlListaObligaciones.Controls.Add(lblObligacion);
					lblObligacion.BringToFront();

					int iDistancia = 480; // 600


					if (obligaciones[i].iR01 != null)
					{
						LollipopCheckBox chkbR1 = new LollipopCheckBox();
						chkbR1.Name			= obligaciones[i].iR01.Value.ToString();
						chkbR1.Location		= new Point(iDistancia, lblObligacion.Location.Y);
						chkbR1.Text			= "";
						chkbR1.Size			= new Size(20, 20);
						chkbR1.Cursor		= Cursors.Hand;
						chkbR1.CheckColor	= "#5d4037";

						//VALIDA SI EL CLIENTE TIENE UNA OBLIGACIÓN ASIGNADA, SE MARCA EL CHECK
						bool validar = false;
						validar = new DetalleObligacion().validarObligacion(obligaciones[i].iR01.Value, iIdCliente);
						if (validar != true)
							chkbR1.Checked = false;
						else
							chkbR1.Checked = true;

						pnlListaObligaciones.Controls.Add(chkbR1);
						chkbR1.BringToFront();
					}
					iDistancia = iDistancia + 50;

					if (obligaciones[i].iR02 != null)
					{
						LollipopCheckBox chkbR2 = new LollipopCheckBox();
						chkbR2.Name			= obligaciones[i].iR02.Value.ToString();
						chkbR2.Location		= new Point(iDistancia, lblObligacion.Location.Y);
						chkbR2.Text			= "";
						chkbR2.Size			= new Size(20, 20);
						chkbR2.Cursor		= Cursors.Hand;
						chkbR2.CheckColor	= "#558b2f";

						//VALIDA SI EL CLIENTE TIENE UNA OBLIGACIÓN ASIGNADA, SE MARCA EL CHECK
						bool validar = false;
						validar = new DetalleObligacion().validarObligacion(obligaciones[i].iR02.Value, iIdCliente);
						if (validar != true)
							chkbR2.Checked = false;
						else
							chkbR2.Checked = true;

						pnlListaObligaciones.Controls.Add(chkbR2);
						chkbR2.BringToFront();
					}
					iDistancia = iDistancia + 50;

					if (obligaciones[i].iR03 != null)
					{
						LollipopCheckBox chkbR3 = new LollipopCheckBox();
						chkbR3.Name			= obligaciones[i].iR03.Value.ToString();
						chkbR3.Location		= new Point(iDistancia, lblObligacion.Location.Y);
						chkbR3.Text			= "";
						chkbR3.Size			= new Size(20, 20);
						chkbR3.Cursor		= Cursors.Hand;
						chkbR3.CheckColor	= "#0277bd";

						//VALIDA SI EL CLIENTE TIENE UNA OBLIGACIÓN ASIGNADA, SE MARCA EL CHECK
						bool validar = false;
						validar = new DetalleObligacion().validarObligacion(obligaciones[i].iR03.Value, iIdCliente);
						if (validar != true)
							chkbR3.Checked = false;
						else
							chkbR3.Checked = true;

						pnlListaObligaciones.Controls.Add(chkbR3);
						chkbR3.BringToFront();
					}
					iDistancia = iDistancia + 50;

					if (obligaciones[i].iR04 != null)
					{
						LollipopCheckBox chkbR4 = new LollipopCheckBox();
						chkbR4.Name			= obligaciones[i].iR04.Value.ToString();
						chkbR4.Location		= new Point(iDistancia, lblObligacion.Location.Y);
						chkbR4.Text			= "";
						chkbR4.Size			= new Size(20, 20);
						chkbR4.Cursor		= Cursors.Hand;
						chkbR4.CheckColor	= "#F44336";

						//VALIDA SI EL CLIENTE TIENE UNA OBLIGACIÓN ASIGNADA, SE MARCA EL CHECK
						bool validar = false;
						validar = new DetalleObligacion().validarObligacion(obligaciones[i].iR04.Value, iIdCliente);
						if (validar != true)
							chkbR4.Checked = false;
						else
							chkbR4.Checked = true;

						pnlListaObligaciones.Controls.Add(chkbR4);
						chkbR4.BringToFront();
					}
					iDistancia = iDistancia + 50;

					if (obligaciones[i].iR05 != null)
					{
						LollipopCheckBox chkbR5 = new LollipopCheckBox();
						chkbR5.Name			= obligaciones[i].iR05.Value.ToString();
						chkbR5.Location		= new Point(iDistancia, lblObligacion.Location.Y);
						chkbR5.Text			= "";
						chkbR5.Size			= new Size(20, 20);
						chkbR5.Cursor		= Cursors.Hand;
						chkbR5.CheckColor	= "#9C27B0";

						//VALIDA SI EL CLIENTE TIENE UNA OBLIGACIÓN ASIGNADA, SE MARCA EL CHECK
						bool validar = false;
						validar = new DetalleObligacion().validarObligacion(obligaciones[i].iR05.Value, iIdCliente);
						if (validar != true)
							chkbR5.Checked = false;
						else
							chkbR5.Checked = true;

						pnlListaObligaciones.Controls.Add(chkbR5);
						chkbR5.BringToFront();
					}
					iDistancia = iDistancia + 50;

					if (obligaciones[i].iR06 != null)
					{
						LollipopCheckBox chkbR6 = new LollipopCheckBox();
						chkbR6.Name			= obligaciones[i].iR06.Value.ToString();
						chkbR6.Location		= new Point(iDistancia, lblObligacion.Location.Y);
						chkbR6.Text			= "";
						chkbR6.Size			= new Size(20, 20);
						chkbR6.Cursor		= Cursors.Hand;
						chkbR6.CheckColor	= "#0097A7";

						//VALIDA SI EL CLIENTE TIENE UNA OBLIGACIÓN ASIGNADA, SE MARCA EL CHECK
						bool validar = false;
						validar = new DetalleObligacion().validarObligacion(obligaciones[i].iR06.Value, iIdCliente);
						if (validar != true)
							chkbR6.Checked = false;
						else
							chkbR6.Checked = true;

						pnlListaObligaciones.Controls.Add(chkbR6);
						chkbR6.BringToFront();
					}
					iDistancia = iDistancia + 50;

					if (obligaciones[i].iR07 != null)
					{
						LollipopCheckBox chkbR7 = new LollipopCheckBox();
						chkbR7.Name			= obligaciones[i].iR07.Value.ToString();
						chkbR7.Location		= new Point(iDistancia, lblObligacion.Location.Y);
						chkbR7.Text			= "";
						chkbR7.Size			= new Size(20, 20);
						chkbR7.Cursor		= Cursors.Hand;
						chkbR7.CheckColor	= "#E65100";

						//VALIDA SI EL CLIENTE TIENE UNA OBLIGACIÓN ASIGNADA, SE MARCA EL CHECK
						bool validar = false;
						validar = new DetalleObligacion().validarObligacion(obligaciones[i].iR07.Value, iIdCliente);
						if (validar != true)
							chkbR7.Checked = false;
						else
							chkbR7.Checked = true;

						pnlListaObligaciones.Controls.Add(chkbR7);
						chkbR7.BringToFront();
					}
					iDistancia = iDistancia + 50;

					if (obligaciones[i].iR08 != null)
					{
						LollipopCheckBox chkbR8 = new LollipopCheckBox();
						chkbR8.Name			= obligaciones[i].iR08.Value.ToString();
						chkbR8.Location		= new Point(iDistancia, lblObligacion.Location.Y);
						chkbR8.Text			= "";
						chkbR8.Size			= new Size(20, 20);
						chkbR8.Cursor		= Cursors.Hand;
						chkbR8.CheckColor	= "#607D8B";

						//VALIDA SI EL CLIENTE TIENE UNA OBLIGACIÓN ASIGNADA, SE MARCA EL CHECK
						bool validar = false;
						validar = new DetalleObligacion().validarObligacion(obligaciones[i].iR08.Value, iIdCliente);
						if (validar != true)
							chkbR8.Checked = false;
						else
							chkbR8.Checked = true;

						pnlListaObligaciones.Controls.Add(chkbR8);
						chkbR8.BringToFront();
					}
					iDistancia = iDistancia + 50;

					if (obligaciones[i].iR09 != null)
					{
						LollipopCheckBox chkbR9 = new LollipopCheckBox();
						chkbR9.Name			= obligaciones[i].iR09.Value.ToString();
						chkbR9.Location		= new Point(iDistancia, lblObligacion.Location.Y);
						chkbR9.Text			= "";
						chkbR9.Size			= new Size(20, 20);
						chkbR9.Cursor		= Cursors.Hand;
						chkbR9.CheckColor	= "#827717";

						//VALIDA SI EL CLIENTE TIENE UNA OBLIGACIÓN ASIGNADA, SE MARCA EL CHECK
						bool validar = false;
						validar = new DetalleObligacion().validarObligacion(obligaciones[i].iR09.Value, iIdCliente);
						if (validar != true)
							chkbR9.Checked = false;
						else
							chkbR9.Checked = true;

						pnlListaObligaciones.Controls.Add(chkbR9);
						chkbR9.BringToFront();
					}
					iDistancia = iDistancia + 50;

					if (obligaciones[i].iR10 != null)
					{
						LollipopCheckBox chkbR10 = new LollipopCheckBox();
						chkbR10.Name			= obligaciones[i].iR10.Value.ToString();
						chkbR10.Location		= new Point(iDistancia, lblObligacion.Location.Y);
						chkbR10.Text			= "";
						chkbR10.Size			= new Size(20, 20);
						chkbR10.Cursor			= Cursors.Hand;
						chkbR10.CheckColor		= "#536DFE";

						//VALIDA SI EL CLIENTE TIENE UNA OBLIGACIÓN ASIGNADA, SE MARCA EL CHECK
						bool validar = false;
						validar = new DetalleObligacion().validarObligacion(obligaciones[i].iR10.Value, iIdCliente);
						if (validar != true)
							chkbR10.Checked = false;
						else
							chkbR10.Checked = true;

						pnlListaObligaciones.Controls.Add(chkbR10);
						chkbR10.BringToFront();
					}
					iDistancia = iDistancia + 50;


					separador.SendToBack();

					pnlListaObligaciones.AutoScroll = true;
				}
			}
			else
            {
                Label lblNotifica       = new Label();
                lblNotifica.Text        = string.Format("No Se Encontraron{0}Obligaciones Fiscales Asignadas.", Environment.NewLine);
                lblNotifica.Location    = new Point(380, 120);
                lblNotifica.Font        = new Font("Segoe UI", 13);
                lblNotifica.Width       = 180;
                lblNotifica.Height      = 100;
                lblNotifica.ForeColor   = Color.FromArgb(200, 200, 200);//105
                lblNotifica.TextAlign   = ContentAlignment.MiddleCenter;
                pnlListaObligaciones.Controls.Add(lblNotifica);
            }
        }

		void cargarObligacionesISN(string sCliente, int iIdCliente)
        {
            //OBTIENE UNA LISTA DE OBLIGACIONES CORRESPONDIENTES A AL REGIMEN DONDE SE ENCUENTRA EL CLIENTE
            DetalleObligacion obligacion  = new DetalleObligacion();
            obligacionesAsignadas         = obligacion.listaObligaciones(sCliente);

            if(obligacionesAsignadas.Count > 0)
            {
                pnlListaObligaciones.Controls.Clear();
				//CREA UNA LISTA DINAMICA DE OBLIGACIONES FISCALES
				List<DetalleObligacion> obligaciones = new DetalleObligacion().GetListObligacionesISR(16, 17);
				for (int i = 0; i < obligaciones.Count; i++)
				{
					MaterialSkin.Controls.MaterialLabel lblObligacion = new MaterialSkin.Controls.MaterialLabel();
					lblObligacion.Location		= new Point(2, 28 * i + 20);
					lblObligacion.Text			= string.Format("{0}. {1}", (i + 1).ToString(), obligaciones[i].sDetalleObligacion);
					lblObligacion.Width			= 400;
					lblObligacion.AutoEllipsis	= true;
					
					DevExpress.XtraEditors.SeparatorControl separador = new DevExpress.XtraEditors.SeparatorControl();
					separador.LineOrientation	= Orientation.Horizontal;
					separador.Size				= new Size(590, 18);// 937, 18
					separador.Location			= new Point(365, lblObligacion.Location.Y + 15);

					pnlListaObligaciones.Controls.Add(separador);

					pnlListaObligaciones.Controls.Add(lblObligacion);
					lblObligacion.BringToFront();

					int iDistancia = 480; // 600


					if (obligaciones[i].iR01 != null)
					{
						LollipopCheckBox chkbR1 = new LollipopCheckBox();
						chkbR1.Name			= obligaciones[i].iR01.Value.ToString();
						chkbR1.Location		= new Point(iDistancia, lblObligacion.Location.Y);
						chkbR1.Text			= "";
						chkbR1.Size			= new Size(20, 20);
						chkbR1.Cursor		= Cursors.Hand;
						chkbR1.CheckColor	= "#5d4037";

						//VALIDA SI EL CLIENTE TIENE UNA OBLIGACIÓN ASIGNADA, SE MARCA EL CHECK
						bool validar = false;
						validar = new DetalleObligacion().validarObligacion(obligaciones[i].iR01.Value, iIdCliente);
						if (validar != true)
							chkbR1.Checked = false;
						else
							chkbR1.Checked = true;

						pnlListaObligaciones.Controls.Add(chkbR1);
						chkbR1.BringToFront();
					}
					iDistancia = iDistancia + 200;

					if (obligaciones[i].iR02 != null)
					{
						LollipopCheckBox chkbR2 = new LollipopCheckBox();
						chkbR2.Name			= obligaciones[i].iR02.Value.ToString();
						chkbR2.Location		= new Point(iDistancia, lblObligacion.Location.Y);
						chkbR2.Text			= "";
						chkbR2.Size			= new Size(20, 20);
						chkbR2.Cursor		= Cursors.Hand;
						chkbR2.CheckColor	= "#558b2f";

						//VALIDA SI EL CLIENTE TIENE UNA OBLIGACIÓN ASIGNADA, SE MARCA EL CHECK
						bool validar = false;
						validar = new DetalleObligacion().validarObligacion(obligaciones[i].iR02.Value, iIdCliente);
						if (validar != true)
							chkbR2.Checked = false;
						else
							chkbR2.Checked = true;

						pnlListaObligaciones.Controls.Add(chkbR2);
						chkbR2.BringToFront();
					}
					iDistancia = iDistancia + 200;

					if (obligaciones[i].iR03 != null)
					{
						LollipopCheckBox chkbR3 = new LollipopCheckBox();
						chkbR3.Name			= obligaciones[i].iR03.Value.ToString();
						chkbR3.Location		= new Point(iDistancia, lblObligacion.Location.Y);
						chkbR3.Text			= "";
						chkbR3.Size			= new Size(20, 20);
						chkbR3.Cursor		= Cursors.Hand;
						chkbR3.CheckColor	= "#0277bd";

						//VALIDA SI EL CLIENTE TIENE UNA OBLIGACIÓN ASIGNADA, SE MARCA EL CHECK
						bool validar = false;
						validar = new DetalleObligacion().validarObligacion(obligaciones[i].iR03.Value, iIdCliente);
						if (validar != true)
							chkbR3.Checked = false;
						else
							chkbR3.Checked = true;

						pnlListaObligaciones.Controls.Add(chkbR3);
						chkbR3.BringToFront();
					}

					separador.SendToBack();

					pnlListaObligaciones.AutoScroll = true;
				}
			}
			else
            {
                Label lblNotifica       = new Label();
                lblNotifica.Text        = string.Format("No Se Encontraron{0}Obligaciones Fiscales Asignadas.", Environment.NewLine);
                lblNotifica.Location    = new Point(380, 120);
                lblNotifica.Font        = new Font("Segoe UI", 13);
                lblNotifica.Width       = 180;
                lblNotifica.Height      = 100;
                lblNotifica.ForeColor   = Color.FromArgb(200, 200, 200);//105
                lblNotifica.TextAlign   = ContentAlignment.MiddleCenter;
                pnlListaObligaciones.Controls.Add(lblNotifica);
            }
        }





        private void ChkbxObligacion_CheckedChanged(object sender, EventArgs e)
        {
            MaterialCheckBox check = sender as MaterialCheckBox;
            byte estado;
            if (check.Checked)
                estado = 1;
            else
                estado = 0;

            //SE GUARDA UN NUEVO REGISTRO SI EL CHECK ES MARCADO
            new RegistroObligacion().modificarRegistroObligacion(new RegistroObligacion()
            {
                iIdDetalleObligacion = int.Parse(check.Name),
                iIdCliente           = Cliente.iIdCliente,
                btEstado             = estado
            });
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCliente.Text))
            {
                lblCampoRequerido.Visible = true;
            }
            else
            {
				bISRH = false;
				bISRA = false;
                lblCampoRequerido.Visible = false;
                pnlListaObligaciones.Controls.Clear();
                cargarInformacion();
            }
        }

        public void cargarInformacion()
        {
            //INFORMACIÓN DEL CLIENTE        
            Cliente                     = new Cliente().InformacionCliente(txtCliente.Text, 0);
            if(Cliente != null)
            {
                lblCampoRequerido.Visible   = false;
                lblNombre.Text              = string.Format("{0} {1} {2}", Cliente.sNombre, Cliente.sAPaterno, Cliente.sAMaterno);
                lblRfc.Text                 = Cliente.sRfc;
                lblTelefono.Text            = Cliente.sTelefono;
                lblCelular.Text             = Cliente.sNumeroMovil;
                lblExtension.Text           = Cliente.sExtension;
                lblCorreoElectronico.Text   = Cliente.sCorreoElectronico;

                //CARGAMOS LISTA DE OBLIGACIONES FISCALES
                cargarObligaciones(txtCliente.Text, Cliente.iIdCliente);
                EstadoControles(true);

				materialLabel2.Visible		= true;
				//btnHonorarios.Visible		= true;
				//btnArrendamiento.Visible	= true;
				//btnAsimilados.Visible		= true;
				btnVHonorarios.Visible		= true;
				btnVArrendamiento.Visible	= true;
				btnVAsimilados.Visible		= true;
				btnVEnajenaBienes.Visible	= true;
				btnVEnajenaBolsa.Visible	= true;
				btnVAdquiBienes.Visible		= true;
				btnVIngresosInt.Visible		= true;
				btnVObtePremios.Visible		= true;
				btnVIngDividendos.Visible	= true;
				btnVOtrosIngresos.Visible	= true;

				btnGuardar.Visible			= true;
				btnGuardarISR.Visible		= false;
            }
            else
            {
                lblNombre.Text              = "--";
                lblRfc.Text                 = "--";
                lblTelefono.Text            = "--";
                lblCelular.Text             = "--";
                lblExtension.Text           = "--";
                lblCorreoElectronico.Text   = "--";

                EstadoControles(false);
                lblCampoRequerido.Text              = "*No se encontro el cliente";
                lblCampoRequerido.Visible           = true;
            }
        }

        void EstadoControles(bool bEstado)
        {
			btnGuardarISR.Enabled = bEstado;
            btnGuardar.Enabled    = bEstado;
            btnCancelar.Enabled   = bEstado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if(MessageBox.Show("¿Está seguro de guardar los cambios?", "Adevertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            if (FlatMessageBox.Show("¿Está seguro de guardar los cambios?", "SI", "NO", FlatMessageBoxIcon.Warning) == DialogResult.Yes)
            { 
                LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
                //RECORREMOS LA LISTA PARA GUARDAR LOS REGISTROS DE LAS OBLIGACIONES MARCADAS
                foreach (Control control in this.pnlListaObligaciones.Controls)
                {
                    if (control is LollipopCheckBox)
                    {
						LollipopCheckBox checkbox = control as LollipopCheckBox;
                        if (checkbox.Checked)
                        {
                            new RegistroObligacion().insertarRegistroObligacion(new RegistroObligacion()
                            {
                                iIdUsuarioRegistra   = int.Parse(AUsuarioData.sIdusuario),
                                iIdDetalleObligacion = int.Parse(checkbox.Name),
                                iIdCliente           = Cliente.iIdCliente
                            });

							if (checkbox.Name == "427")
								bISRH = true;

							if (checkbox.Name == "461")
								bISRA = true;
						}
                    }
                }

				if (bISRH || bISRA)
				{
					btnVHonorarios.Visible		= false;
					btnVArrendamiento.Visible	= false;
					btnVAsimilados.Visible		= false;
					btnVEnajenaBienes.Visible	= false;
					btnVEnajenaBolsa.Visible	= false;
					btnVAdquiBienes.Visible		= false;
					btnVIngresosInt.Visible		= false;
					btnVObtePremios.Visible		= false;
					btnVIngDividendos.Visible	= false;
					btnVOtrosIngresos.Visible	= false;


					//btnAsimilados.Visible	= false;
					btnHonorarios.Visible		= true;
					btnArrendamiento.Visible	= true;

					btnGuardarISR.Location	= btnGuardar.Location;
					btnGuardarISR.Visible	= true;
					btnGuardar.Visible		= false;
					cargarObligacionesISN(txtCliente.Text, Cliente.iIdCliente);
				}
				else
				{
					FlatMessageBox.Show("Cambios Guardados Correctamente", "OK", string.Empty, FlatMessageBoxIcon.Information);

					EstadoControles(false);
					lblNombre.Text              = "--";
					lblRfc.Text                 = "--";
					lblTelefono.Text            = "--";
					lblCelular.Text             = "--";
					lblExtension.Text           = "--";
					lblCorreoElectronico.Text   = "--";
					materialLabel2.Visible		= false;
					btnHonorarios.Visible		= false;
					btnArrendamiento.Visible	= false;
					btnAsimilados.Visible		= false;

					pnlListaObligaciones.Controls.Clear();
					txtCliente.Clear();
					txtCliente.Focus();
				}
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EstadoControles(false);
            lblNombre.Text              = "--";
            lblRfc.Text                 = "--";
            lblTelefono.Text            = "--";
            lblCelular.Text             = "--";
            lblExtension.Text           = "--";
            lblCorreoElectronico.Text   = "--";
            pnlListaObligaciones.Controls.Clear();
            txtCliente.Clear();
            txtCliente.Focus();

			materialLabel2.Visible		= false;
			btnHonorarios.Visible		= false;
			btnArrendamiento.Visible	= false;
			btnAsimilados.Visible		= false;
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
			/*Convierte en mayusculas*/
			e.KeyChar = Char.ToUpper(e.KeyChar);

			/*Si la tecla es un enter, se ejecuta el evento click del botón Buscar*/
			if (e.KeyChar == (char)13)
				btnBuscarCliente_Click(sender, e);
		}

		private void btnGuardarISR_Click(Object sender, EventArgs e)
		{
			LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
            //RECORREMOS LA LISTA PARA GUARDAR LOS REGISTROS DE LAS OBLIGACIONES MARCADAS
            foreach (Control control in this.pnlListaObligaciones.Controls)
            {
                if (control is LollipopCheckBox)
                {
					LollipopCheckBox checkbox = control as LollipopCheckBox;
                    if (checkbox.Checked)
                    {
                        new RegistroObligacion().insertarRegistroObligacion(new RegistroObligacion()
                        {
                            iIdUsuarioRegistra   = int.Parse(AUsuarioData.sIdusuario),
                            iIdDetalleObligacion = int.Parse(checkbox.Name),
                            iIdCliente           = Cliente.iIdCliente
                        });
					}
                }
            }
			bISRH = false;
			bISRA = false;

			FlatMessageBox.Show("Cambios Guardados Correctamente", "OK", string.Empty, FlatMessageBoxIcon.Information);

			EstadoControles(false);
			lblNombre.Text              = "--";
			lblRfc.Text                 = "--";
			lblTelefono.Text            = "--";
			lblCelular.Text             = "--";
			lblExtension.Text           = "--";
			lblCorreoElectronico.Text   = "--";
			materialLabel2.Visible		= false;
			btnHonorarios.Visible		= false;
			btnArrendamiento.Visible	= false;
			btnAsimilados.Visible		= false;

			pnlListaObligaciones.Controls.Clear();
			txtCliente.Clear();
			txtCliente.Focus();
		}
	}
}
