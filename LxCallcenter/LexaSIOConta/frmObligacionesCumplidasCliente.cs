using LogicaCC.LexaSIOContaLogica;
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
    public partial class frmObligacionesCumplidasCliente : Form
    {
        public List<DetalleObligacion> obligaciones;
        Cliente Cliente;

        LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
        public int iIdUsuario;

        public frmObligacionesCumplidasCliente()
        {
            InitializeComponent();
            iIdUsuario = int.Parse(AUsuarioData.sIdusuario);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCliente.Text))
            {
                lblCampoRequerido.Visible = false;
                cargarInformacion();
            }
            else
            {
                lblCampoRequerido.Text    = "*Campo Requerido";
                lblCampoRequerido.Visible = true;
                pnlInformacionObligacion.Visible    = false;
            }
        }


        void EstadoControles(bool estado)
        {
            //panel5.Visible                      = estado;
            pnlInformacionCliente.Visible       = estado;
            panel1.Visible                      = estado;
            pnlObligaciones.Visible             = estado;
            //pnlInformacionObligacion.Visible    = estado;
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

                //CARGAMOS LISTA DE OBLIGACIONES FISCALES
                cargarListaObligaciones(txtCliente.Text);
                EstadoControles(true);
                pnlInformacionObligacion.Visible = false;
            }
            else
            {
                EstadoControles(false);
                //lblCampoRequerido.Text              = "*No se encontro el cliente";
                //lblCampoRequerido.Visible           = true;
                pnlInformacionObligacion.Visible    = false;
                FlatMessageBox.Show(string.Format("El cliente que intentas buscar, aun no tiene{0}obligaciones fiscales asignadas, contacte{1}con sus supervisor.", Environment.NewLine, Environment.NewLine), "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
            }
        }



        /// <summary>
        /// Metodo Publico para realizar una busqueda
        /// de obligaciones fiscales filtrando por estado
        /// de realización.
        /// </summary>
        /// <param name="estado">Estado de obligación, 0 para realizadas y 1 para no realizadas</param>
        public void cargarListaObligaciones(string sCliente)
        {
            pnlObligaciones.Controls.Clear();
            //CREA UNA LISTA DINAMICA DE OBLIGACIONES FISCALES
            DetalleObligacion obligacion = new DetalleObligacion();
            obligaciones = obligacion.ObligacionesFiscalesCumplidas(txtCliente.Text);
            if(obligaciones.Count > 0)
            { 
                for (int i = 0; i < obligaciones.Count; i++)
                {
                    Button btnObligacion                    = new Button();
                    btnObligacion.Location                  = new Point(12, 24 * i + 0);
                    //btnObligacion.Name                      = obligaciones[i].iIdRegistroObligacion.ToString();
                    btnObligacion.Text                      = obligaciones[i].sDetalleObligacion;
                    btnObligacion.Font                      = new Font("Segoe UI", 9);
                    btnObligacion.Width                     = 225;
                    btnObligacion.Height                    = 24;
                    btnObligacion.FlatStyle                 = FlatStyle.Flat;
                    btnObligacion.FlatAppearance.BorderSize = 0;
                    btnObligacion.Cursor                    = Cursors.Hand;

                    Panel ptbEstado     = new Panel();
                    ptbEstado.Location  = new Point(7, 24 * i + 0);
                    //ptbEstado.Name      = "picture" + obligaciones[i].iIdRegistroObligacion.ToString();
                    ptbEstado.Width     = 5;
                    ptbEstado.Height    = 24;

                    DateTime fecha1 = Convert.ToDateTime(obligaciones[i].sfechaVerde);
                    DateTime fecha2 = Convert.ToDateTime(obligaciones[i].sfechaAmarillo);
                    DateTime fecha3 = Convert.ToDateTime(obligaciones[i].sfechaRojo);
                    DateTime fecha  = Convert.ToDateTime(obligaciones[i].sFechaEntrega);


                    //CONDICIONA PARA ASIGNAR EL ESTADO DE FECHA DE UNA OBLIGACIÓN
                    if ((fecha >= fecha1) && (fecha <= fecha2))
                    {
                        ptbEstado.BackColor = Color.FromArgb(3, 166, 0);
                        btnObligacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 166, 0);
                    }
                    else if ((fecha >= fecha2) && (fecha <= fecha3))
                    {
                        ptbEstado.BackColor = Color.FromArgb(255, 235, 0);
                        btnObligacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 235, 0);
                    }
                    else if (fecha >= fecha3)
                    {
                        ptbEstado.BackColor = Color.FromArgb(171, 30, 30);
                        btnObligacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(171, 30, 30);
                    }


					DetalleObligacion _Detail = new DetalleObligacion();
					int? iNull = null;
					_Detail.sDetalleObligacion	= obligaciones[i].sDetalleObligacion;
					_Detail.sFormaPresentacion	= obligaciones[i].sFormaPresentacion;
					_Detail.sfechaVerde			= obligaciones[i].sfechaVerde;
					_Detail.sfechaAmarillo		= obligaciones[i].sfechaAmarillo;
					_Detail.sfechaRojo			= obligaciones[i].sfechaRojo;
					_Detail.sFechaEntrega		= obligaciones[i].sFechaEntrega;
					_Detail.iR01				= obligaciones[i].iR01 == null ? iNull: obligaciones[i].iR01;
					_Detail.iR02				= obligaciones[i].iR02 == null ? iNull : obligaciones[i].iR02;
					_Detail.iR03				= obligaciones[i].iR03 == null ? iNull : obligaciones[i].iR03;

					_Detail.iR04				= obligaciones[i].iR04 == null ? iNull : obligaciones[i].iR04;
					_Detail.iR05				= obligaciones[i].iR05 == null ? iNull : obligaciones[i].iR05;
					_Detail.iR06				= obligaciones[i].iR06 == null ? iNull : obligaciones[i].iR06;
					_Detail.iR07				= obligaciones[i].iR07 == null ? iNull : obligaciones[i].iR07;
					_Detail.iR08				= obligaciones[i].iR08 == null ? iNull : obligaciones[i].iR08;
					_Detail.iR09				= obligaciones[i].iR09 == null ? iNull : obligaciones[i].iR09;
					_Detail.iR10				= obligaciones[i].iR10 == null ? iNull : obligaciones[i].iR10;
                    _Detail.sObligacion         = obligaciones[i].sObligacion;


					btnObligacion.ImageAlign        = ContentAlignment.TopLeft;
                    btnObligacion.TextAlign         = ContentAlignment.MiddleLeft;
                    btnObligacion.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btnObligacion.AutoEllipsis      = true;
					//CREAMOS EL EVENTO CLICK DEL BOTON
					//btnObligacion.Click += BtnObligacion_Click;
					btnObligacion.Click += delegate (object sender, EventArgs e) { BtnObligacion_Click(sender, e, _Detail); };
					pnlObligaciones.Controls.Add(ptbEstado);
                    pnlObligaciones.Controls.Add(btnObligacion);
                }
            }
            else
            {
                Label lblNotifica       = new Label();
                lblNotifica.Text        = string.Format("No Se Encontraron{0}Obligaciones Fiscales Cumplidas.", Environment.NewLine);
                lblNotifica.Location    = new Point(40, 100);
                lblNotifica.Font        = new Font("Segoe UI", 13);
                lblNotifica.Width       = 180;
                lblNotifica.Height      = 100;
                lblNotifica.ForeColor   = Color.FromArgb(200, 200, 200);//105
                lblNotifica.TextAlign   = ContentAlignment.MiddleCenter;
                pnlObligaciones.Controls.Add(lblNotifica);

            }
        }



        public static int iIdRegistroObligacionSeleccionada;
        public static int iIdObligacionDetalle;
        private void BtnObligacion_Click(object sender, EventArgs e, DetalleObligacion _Detalle)
        {
            Button button = sender as Button;

            pnlInformacionObligacion.Visible = true;
            
            //INFORMACIÓN DE LAS OBLIGACIONES FISCALES
            //RegistroObligacion detalleObligacion;
            //detalleObligacion = new RegistroObligacion().InformacionDetalleObligacion(int.Parse(button.Name));
			lblDetalleObligacion.Text = button.Text;
            txtFormaPago.Text         = _Detalle.sFormaPresentacion;
            lblFechaVerde.Text        = String.Format("{0:d}", DateTime.Parse(_Detalle.sfechaVerde));
            lblFechaAmarillo.Text     = String.Format("{0:d}", DateTime.Parse(_Detalle.sfechaAmarillo));
            lblFechaRojo.Text         = String.Format("{0:d}", DateTime.Parse(_Detalle.sfechaRojo));
            lblRegimen.Text           = _Detalle.sObligacion;

			if (button.FlatAppearance.MouseOverBackColor == Color.FromArgb(3, 166, 0))
            {
                lblFechaVerde.ForeColor    = Color.FromArgb(3, 166, 0);
                lblFechaAmarillo.ForeColor = Color.Black;
                lblFechaRojo.ForeColor     = Color.Black;
				stateIndicatorComponent1.StateIndex = 3;

			}
            else if (button.FlatAppearance.MouseOverBackColor == Color.FromArgb(255, 153, 0))
            {
                lblFechaVerde.ForeColor    = Color.Black;
                lblFechaAmarillo.ForeColor = Color.FromArgb(255, 153, 0);
                lblFechaRojo.ForeColor     = Color.Black;
				stateIndicatorComponent1.StateIndex = 2;
			}
            else if (button.FlatAppearance.MouseOverBackColor == Color.FromArgb(171, 30, 30))
            {
                lblFechaVerde.ForeColor    = Color.Black;
                lblFechaAmarillo.ForeColor = Color.Black;
                lblFechaRojo.ForeColor     = Color.FromArgb(171, 30, 30);
				stateIndicatorComponent1.StateIndex = 1;
			}

            string fechaCumplimiento = _Detalle.sFechaEntrega;

            //string fechaCumplimiento = detalleObligacion.sFechaCumplimiento;
            if(!string.IsNullOrEmpty(fechaCumplimiento))
            {
                //MessageBox.Show("Obligación Cumplida");

                lblFechaCumplimiento.Text = String.Format("{0:d}", DateTime.Parse(fechaCumplimiento));

                DateTime fechaV = Convert.ToDateTime(lblFechaVerde.Text);
                DateTime fechaA = Convert.ToDateTime(lblFechaAmarillo.Text);
                DateTime fechaR = Convert.ToDateTime(lblFechaRojo.Text);
                DateTime fechaC = Convert.ToDateTime(fechaCumplimiento);

                if ((fechaC >= fechaV) && (fechaC <= fechaA))
                {
                    //CUMPLIMIENTO EN VERDE
                    pctFechaCumplimiento.Image = Properties.Resources.CircledGreen;
                }
                else if ((fechaC >= fechaA) && (fechaC <= fechaR))
                {
                    //CUMPLIMIENTO EN AMARILLO
                    pctFechaCumplimiento.Image = Properties.Resources.CircledYellow;
                }
                else if (fechaC >= fechaR)
                {
                    //CUMPLIMIENTO EN ROJO
                    pctFechaCumplimiento.Image = Properties.Resources.CircledRed;
                }


                pctFechaCumplimiento.Visible = true;
                lblEtiquetaFC.Visible        = true;
                lblFechaCumplimiento.Visible = true;
                pnlSemaforo.Visible = true;
            }
            else
            {
                pctFechaCumplimiento.Visible = false;
                lblEtiquetaFC.Visible        = false;
                lblFechaCumplimiento.Visible = false;
                pnlSemaforo.Visible = false;
            }
            

            //iIdObligacionDetalle = detalleObligacion.iIdDetalleObligacion;
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
			/*Convierte en mayusculas*/
			e.KeyChar = Char.ToUpper(e.KeyChar);

			/*Si la tecla es un enter, se ejecuta el evento click del botón Buscar*/
			if (e.KeyChar == (char)13)
				btnBuscarCliente_Click(sender, e);
		}
    }
}
