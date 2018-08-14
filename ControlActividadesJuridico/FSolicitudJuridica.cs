using ClaseData.Clases;
using ClaseData.Clases.Cliente;
using ClaseData.Clases.ListCoordinadores;
using ClaseData.Clases.Solicitud;
using ClaseData.Clases.Solicitud.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ControlActividadesJuridico
{
    public partial class FSolicitudJuridica : Form
    {
        ClienteData AClienteData;
        CoordinadorData slc;

        int iOpcionBusqueda = 1;


        //private const int CS_DROPSHADOW = 0x20000;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ClassStyle |= CS_DROPSHADOW;
        //        return cp;
        //    }
        //}
        //Constants
        const int AW_HIDE = 0X10000;
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;
        const int AW_VER_POSITIVE = 0x00000004;
        const int AW_VER_NEGATIVE = 0x00000008;


        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        private bool _UseSlideAnimation;
        public FSolicitudJuridica() : this(false) { }

        public FSolicitudJuridica(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
        }

        //public FSolicitudJuridica()
        //{
        //    InitializeComponent();
        //    //DatosUsuario ADatosUsuario      = DatosUsuario.Instancia;
        //    LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;

        //    /*Consumo de funcion para la carga de coordinadores en el combobox*/
        //    DatosCoordinadores ACoordinador         = new DatosCoordinadores();
        //    List<CoordinadorData> LCoordinadores    = ACoordinador.listaCoordinadores();

        //    this.cmbCoordinador.DataSource          = LCoordinadores;
        //    this.cmbCoordinador.ValueMember         = "sIdUsuario";
        //    this.cmbCoordinador.DisplayMember       = "sMateria";
        //    this.cmbCoordinador.SelectedIndex       = -1;
        //    //this.cmbCoordinador.SelectedItem        = 1;
        //    //cmbCoordinador.Enabled                  = false;

        //    txtNoCliente.MaxLength = 11;
        //}

        static FSolicitudJuridica _NuevaSolicitud;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show()
        {
            _NuevaSolicitud = new FSolicitudJuridica();
            Form frmSet = Application.OpenForms["FPrincipal"];
            FBandeja _FBandeja = Application.OpenForms["FBandeja"] as FBandeja;

            _NuevaSolicitud.FormClosed += new FormClosedEventHandler(_FBandeja.ActualizarSolPendientes_FormClosed);


            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _NuevaSolicitud.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _NuevaSolicitud.Location = new Point(x, y);

            //_NuevaSolicitud.label1.Text = string.Format("Hola {0},", sNombre);
            //_NuevaSolicitud.InitializeControls();

            //DatosUsuario ADatosUsuario      = DatosUsuario.Instancia;
            LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;

            /*Consumo de funcion para la carga de coordinadores en el combobox*/
            DatosCoordinadores ACoordinador = new DatosCoordinadores();
            List<CoordinadorData> LCoordinadores = ACoordinador.listaCoordinadores();

            _NuevaSolicitud.cmbCoordinador.DataSource       = LCoordinadores;
            _NuevaSolicitud.cmbCoordinador.ValueMember      = "sIdUsuario";
            _NuevaSolicitud.cmbCoordinador.DisplayMember    = "sMateria";
            _NuevaSolicitud.cmbCoordinador.SelectedIndex    = -1;
            //this.cmbCoordinador.SelectedItem        = 1;
            //cmbCoordinador.Enabled                  = false;

            _NuevaSolicitud.txtNoCliente.MaxLength = 11;





            _DialogResult = DialogResult.No;

            _NuevaSolicitud.Activate();
            _NuevaSolicitud.ShowDialog();

            return _DialogResult;
        }

        protected override void OnLoad(EventArgs e)
        {
            //Animate form
            base.OnLoad(e);
            AnimateWindow(this.Handle, 100, AW_SLIDE | AW_VER_POSITIVE);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (e.Cancel == false)
                AnimateWindow(this.Handle, 200, AW_HIDE | AW_SLIDE | AW_VER_NEGATIVE);
        }

        /*Funcion para buscar al cliente ingresado en el textbox*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            limpiarInfoCliente();
            AClienteData = null;

            ClienteInfo ACliente = new ClienteInfo();

            if (txtNoCliente.Text != string.Empty)
            {
                AClienteData = ACliente.informacionCliente(txtNoCliente.Text, iOpcionBusqueda);

                if (AClienteData != null)
                {
                    InfoCliente(AClienteData);
                    txtFolio.Enabled        = true;
                    btnRegistrar.Visible    = true;
                }
                else
                {
                    txtFolio.Text       = string.Empty;
                    txtFolio.Enabled    = false;
                    lblError.Visible    = true;
                    lblError.Text       = "*Cliente inactivo o no registrado";
                }
            }
            else
            {
                txtFolio.Text       = string.Empty;
                txtFolio.Enabled    = false;
                lblError.Visible    = true;
                lblError.Text       = "*No existe ningún parámetro de búsqueda";
            }
        }

        /*Función para mostrar la información del cliente*/
        private void InfoCliente(ClienteData ACliente)
        {
            lblNocliente.Text   = ACliente.sNoCliente;
            lblNomCliente.Text  = ACliente.sNombreCliente;
            lblRFC.Text         = ACliente.sRFC;
            lblTelCelular.Text  = ACliente.sNumeroMovil;
            lblTipoPersona.Text = ACliente.sTipoPersona;
            lblServicio.Text    = ACliente.sServicioTipo;
        }

        /*Función para registrar la solicitud del cliente*/
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int iSolicitante;
            int iCoordinador;
            int iCliente;
            int iMateria;
            EIValidaFolio iFolExistente;

            LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
            //DatosUsuario ADatosUsuario  = DatosUsuario.Instancia;
            
            iSolicitante                = int.Parse(AUsuarioData.sIdusuario.ToString());

            iCliente = int.Parse(AClienteData.sIdCliente.ToString());

            if (txtFolio.Text != string.Empty)
            {

                lblErrorFolio.Visible = false;

                if (cmbCoordinador.Text != string.Empty)
                {
                    CValidaFolio folioMPYCC = new CValidaFolio();
                    iFolExistente           = folioMPYCC.ValidaFolioMPYCC(int.Parse(txtFolio.Text));

                    if (iFolExistente.sExiste != "0")
                    {
                        iFolExistente       = null;
                        CValidaFolio folio  = new CValidaFolio();
                        iFolExistente       = folio.ValidaFolio(int.Parse(txtFolio.Text));

                        if (iFolExistente.sExiste == "1")
                        {
                            MessageBox.Show("El folio ingresado ya existe. Favor de ingresar uno nuevo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            slc             = (CoordinadorData)cmbCoordinador.SelectedItem;
                            iCoordinador    = int.Parse(slc.sIdUsuario.ToString());
                            iMateria        = int.Parse(slc.sIdMateria.ToString());

                            //comboBox1.SelectedItem

                            try
                            {
                                new Solicitud().RegistrarSolicitud(iCoordinador, iCliente, iCoordinador, iSolicitante, iMateria, int.Parse(txtFolio.Text), txtSolicitud.Text);

                                DialogResult rs = MessageBox.Show("Se ha realizado el registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (rs == DialogResult.OK)
                                {
                                    Close();
                                }
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                    else
                    {
                      MessageBox.Show("El folio ingresado no ha sido generado en el sistema SGMPY", "Advertencia",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha asignado un coordinador", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                lblErrorFolio.Visible = true;
                MessageBox.Show("Es necesario ingresar el folio que se generó en el sistema MiPyme360", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /*Función limpiar controles de información del cliente*/
        public void limpiarInfoCliente()
        {
            lblNocliente.Text       = string.Empty;
            lblNomCliente.Text      = string.Empty;
            lblRFC.Text             = string.Empty;
            lblTelCelular.Text      = string.Empty;
            lblTipoPersona.Text     = string.Empty;
            lblServicio.Text        = string.Empty;
            lblError.Visible        = false;
            btnRegistrar.Visible    = false;
        }

        /*Función para evitar escritura en el control*/
        private void cmbCoordinador_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /*Función que valida que solo sea ingresados numeros en el control folio*/
        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                lblErrorFolio.Text      = "*Solo se permiten números";
                lblErrorFolio.Visible   = true;
                e.Handled               = true;
                return;
            }
            else
            {
                lblErrorFolio.Visible   = false;
            }
        }

        /*Función para cambiar a mayusculas el numero de cliente ingresado*/
        private void txtNoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                btnBuscar_Click(sender, e);
        }

        /*Función click del boton cancelar para cerrar el formulario*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*Evento TextChanged del control TextBox para cambiar el texto a mayusculas*/
        private void txtNoCliente_TextChanged(object sender, EventArgs e)
        {
            txtNoCliente.CharacterCasing = CharacterCasing.Upper;
        }

        private void rbNoCliente_CheckedChanged(object sender, EventArgs e)
        {
            txtNoCliente.Text = string.Empty;
            if (rbNoCliente.Checked == true)
            {
                iOpcionBusqueda = 1;
                txtNoCliente.MaxLength = 11;
                rbRFC.Checked = false;
                rbNombre.Checked = false;
            }

            if (rbRFC.Checked == true)
            {
                iOpcionBusqueda = 2;
                txtNoCliente.MaxLength = 13;
                rbNoCliente.Checked = false;
                rbNombre.Checked = false;
            }
            if (rbNombre.Checked == true)
            {
                iOpcionBusqueda = 3;
                txtNoCliente.MaxLength = 80;
                rbRFC.Checked = false;
                rbNoCliente.Checked = false;
            }
        }
    }
}
