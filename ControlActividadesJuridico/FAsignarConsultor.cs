using ClaseData.Clases;
using ClaseData.Clases.AccesoArchivos;
using ClaseData.Clases.ListConsultores;
using ClaseData.Clases.ListCoordinadores;
using ClaseData.Clases.ListServicio;
using ClaseData.Clases.ListTEventos;
using ClaseData.Clases.Solicitud;
using ClaseData.Clases.Solicitud.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico
{
    public partial class FAsignarConsultor : Form
    {
        //Constants
        const int AW_HIDE           = 0X10000;
        const int AW_SLIDE          = 0X40000;
        const int AW_HOR_POSITIVE   = 0X1;
        const int AW_HOR_NEGATIVE   = 0X2;
        const int AW_BLEND          = 0X80000;
        const int AW_VER_POSITIVE   = 0x00000004;
        const int AW_VER_NEGATIVE   = 0x00000008;


        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        private bool _UseSlideAnimation;
        public FAsignarConsultor() : this(false) { }

        public FAsignarConsultor(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
        }

        static FAsignarConsultor _AsignarConsultor;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show(int iIdSolicitud, int iIdCaso)
        {
            _AsignarConsultor = new FAsignarConsultor();
            Form frmSet = Application.OpenForms["FPrincipal"];
            FBandeja _FBandeja = Application.OpenForms["FBandeja"] as FBandeja;

            _AsignarConsultor.FormClosed += new FormClosedEventHandler(_FBandeja.ActualizarSolPendientes_FormClosed);


            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _AsignarConsultor.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _AsignarConsultor.Location = new Point(x, y);


            _AsignarConsultor.IdSolicitud = iIdSolicitud;
            _AsignarConsultor.iCaso = iIdCaso;

            //Se consume intancia para obtener información en variables del usuario logueado
            //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
            LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
            _AsignarConsultor.iUser = int.Parse(AUsuarioData.sIdusuario);
            if (AUsuarioData.sTipoUsuario == "20082")
                _AsignarConsultor.idMateria = 2;
            else if (AUsuarioData.sTipoUsuario == "20083")
                _AsignarConsultor.idMateria = 3;
            else
                _AsignarConsultor.idMateria = 1;

            //idMateria   = int.Parse(ADatosUsuario.sIdMateria);

            //Se realiza el consumo de instancia para cargar los detalles de la solicitud levantada
            _AsignarConsultor.detalle = null;
            DSAsignarConsultor detalleSolicitud = new DSAsignarConsultor();
            _AsignarConsultor.detalle = detalleSolicitud.InfoSolicitud(iIdSolicitud);
            _AsignarConsultor.SolicitudDetalle(_AsignarConsultor.detalle);






            _DialogResult = DialogResult.No;

            _AsignarConsultor.Activate();
            _AsignarConsultor.ShowDialog();

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




        int     idMateria;
        int     IdSolicitud;
        int     iCaso;
        int     iUser;
        int     idContador;
        string  UrlLlamadas;
        int     iIdSolicitudTipo;
        int     iTipificacion;
        string  sResolucion = "N/A";

        ISAsignarConsultor  detalle;
        ConsultorData       slcons;
        CoordinadorData     slcoor = null;
        ISContadorCliente   contador;
        TipoEventosData     ste;

        ServicioData sTipificacion;

        DExisteTipificacion idTipifExis;

        //public FAsignarConsultor(int iIdSolicitud, int iIdCaso)
        //{
        //    InitializeComponent();
        //    IdSolicitud = iIdSolicitud;
        //    iCaso       = iIdCaso;

        //    //Se consume intancia para obtener información en variables del usuario logueado
        //    //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
        //    LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
        //    iUser       = int.Parse(AUsuarioData.sIdusuario);
        //    if (AUsuarioData.sTipoUsuario == "20082")
        //        idMateria = 2;
        //    else if (AUsuarioData.sTipoUsuario == "20083")
        //        idMateria = 3;
        //    else
        //        idMateria = 1;

        //    //idMateria   = int.Parse(ADatosUsuario.sIdMateria);

        //    //Se realiza el consumo de instancia para cargar los detalles de la solicitud levantada
        //    detalle = null;
        //    DSAsignarConsultor detalleSolicitud = new DSAsignarConsultor();
        //    detalle = detalleSolicitud.InfoSolicitud(iIdSolicitud);
        //    SolicitudDetalle(detalle);
        //}

        /*Se crea función para vaciar la informacion obtenida en los controles correspondientes del diseño*/
        private void SolicitudDetalle(ISAsignarConsultor detSolicitud)
        {
            lblNocliente1.Text      = detSolicitud.sNumCliente;
            lblNomCliente.Text      = detSolicitud.sNombreCliente;
            lblRFC.Text             = detSolicitud.sRFC;
            lblTelCelular.Text      = detSolicitud.sTelefonoMovil;
            lblTipoPersona.Text     = detSolicitud.sTipoPersona;
            lblServicio.Text        = detSolicitud.sTipoServicio;
            lblFolio.Text           = detSolicitud.sIdCaso;
            lblFechaRegistro.Text   = detSolicitud.sFechaRegistro;
            lblRegistro.Text        = detSolicitud.sRegistro;
            txtDescripcion.Text     = detSolicitud.sSolicitud;
            UrlLlamadas             = detSolicitud.sUrlLlamadas;

            contador = null;
            DSAsignarConsultor AContador = new DSAsignarConsultor();
            contador            = AContador.InfoContador(int.Parse(detSolicitud.sContadorAsignado));
            idContador          = int.Parse(contador.sIdContador);
            txtContador.Text    = contador.sNomContador;
        }

        //public void cargarContador(int iIdContador)
        //{
        //    contador = null;
        //    DSAsignarConsultor AContador = new DSAsignarConsultor();
        //    contador = AContador.InfoContador(iIdContador);
        //    txtContador.Text = contador.sNomContador;
        //}

        /*Evento para consumir instacias y cargar los combobox*/
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSi.Checked == true)
            {
                btnEnviar.Visible   = true;
                ckbContador.Visible = false;
                ckbContador.Checked = false;
                plSI.Visible        = true;
                plNO.Visible        = false;


                DatosTipoEventos ATipoEvento        = new DatosTipoEventos();
                List<TipoEventosData> LTipoEventos  = ATipoEvento.listaTipoEventos();
                this.cmbTipoEvento.DataSource       = LTipoEventos;
                this.cmbTipoEvento.ValueMember      = "sIdTipoEvento";
                this.cmbTipoEvento.DisplayMember    = "sTipoEvento";
                this.cmbTipoEvento.SelectedIndex    = -1;

               

                DatosConsultores AConsultor         = new DatosConsultores();
                List<ConsultorData> LConsultores    = AConsultor.listaConsultores(idMateria);

                this.cmbConsultor.DataSource        = LConsultores;
                this.cmbConsultor.ValueMember       = "sIdUsuario";
                this.cmbConsultor.DisplayMember     = "sUsuario";
                this.cmbConsultor.SelectedIndex     = -1;

            }
            else if (rbNo.Checked == true)
            {
                sResolucion = "N/A";
                btnEnviar.Visible   = true;
                plSI.Visible        = false;
                plNO.Visible        = true;
                ckbContador.Visible = true;
                plNO.Location       = new Point(6, 59);

                DatosCoordinadores ACoordinador         = new DatosCoordinadores();
                List<CoordinadorData> LCoordinadores    = ACoordinador.listaCoordinadoresNoAsignados(IdSolicitud);

                this.cmbCoordinador.DataSource      = LCoordinadores;
                this.cmbCoordinador.ValueMember     = "sIdUsuario";
                this.cmbCoordinador.DisplayMember   = "sNombre";
                this.cmbCoordinador.SelectedIndex   = -1;
            }
        }

        /*Evento click de boton Registrar el cual actualiza la solicitud dependiendo de la asignación del coordinador*/
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int     iIdSol          = IdSolicitud;
            int     IdUsuarioAsigna = iUser;
            int     Decision;
            int     IdTipoEvento;
            int     IdUsuarioAsignado;
            int     idTipificacion;
            string  Observaciones;

            if (ckbContador.Checked == true)
            {
                Decision = 2;
                if (txtMotivoContador.Text !=  string.Empty)
                {
                    try
                    {
                        new Solicitud().ACActualizarSolicitud(Decision, iIdSol, IdUsuarioAsigna, idContador, 3, 1, txtMotivoContador.Text, sResolucion);
                        DialogResult rs = MessageBox.Show("Se ha realizado la asignación correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (rs == DialogResult.OK)
                        {
                            //Close();
                            _DialogResult = DialogResult.Yes;
                            _AsignarConsultor.Close();
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Es necesario registrar el motivo de reasignación", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                if (rbSi.Checked == true)
                {
                    Decision        = 1;
                    Observaciones   = " ";

                    if (cmbTipoEvento.Text != string.Empty)
                    {
                        ste = (TipoEventosData)cmbTipoEvento.SelectedItem;
                        IdTipoEvento = int.Parse(ste.sIdTipoEvento.ToString());

                        if (cmbTipificacion.Text != string.Empty)
                        {
                            sTipificacion = (ServicioData)cmbTipificacion.SelectedItem;
                            idTipificacion = int .Parse(sTipificacion.sIdServicio.ToString());

                            if (cmbConsultor.Text != string.Empty)
                            {
                                slcons = (ConsultorData)cmbConsultor.SelectedItem;
                                IdUsuarioAsignado = int.Parse(slcons.sIdUsuario.ToString());

                                try
                                {
                                    new Solicitud().ACActualizarSolicitud(Decision, iIdSol, IdUsuarioAsigna, IdUsuarioAsignado, IdTipoEvento, idTipificacion, Observaciones, sResolucion);
                                    DialogResult rs = MessageBox.Show("Se ha realizado la asignación correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (rs == DialogResult.OK)
                                    {
                                        _DialogResult = DialogResult.Yes;
                                        _AsignarConsultor.Close();
                                        //Close();
                                    }
                                }
                                catch (Exception ex)
                                {
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se ha asignado a un consultor", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {


                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha tipificado el tipo de evento", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (rbNo.Checked == true)
                {
                    Decision        = 0;
                    IdTipoEvento    = 1;

                    if (cmbCoordinador.Text != string.Empty)
                    {
                        slcoor              = (CoordinadorData)cmbCoordinador.SelectedItem;
                        IdUsuarioAsignado   = int.Parse(slcoor.sIdUsuario.ToString());

                        if (txtObservaciones.Text != string.Empty)
                        {
                            Observaciones = txtObservaciones.Text;
                            try
                            {
                                new Solicitud().ACActualizarSolicitud(Decision, iIdSol, IdUsuarioAsigna, IdUsuarioAsignado, IdTipoEvento, 1, Observaciones, sResolucion);
                                DialogResult rs = MessageBox.Show("Se ha realizado la reasignación correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (rs == DialogResult.OK)
                                {
                                    _DialogResult = DialogResult.Yes;
                                    _AsignarConsultor.Close();
                                    //Close();
                                }
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                        else
                        {
                            MessageBox.Show("Es necesario registrar el motivo de reasignación", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha asignado a un coordinador", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        /*Funcion que consume instancia y consulta las grabaciones del folio*/
        private void btnConsultarllamadas_Click(object sender, EventArgs e)
        {
            try
            {
                //FSeguimientoFolios llamadas = new FSeguimientoFolios(iCaso);
                //llamadas.ShowDialog();
                FSeguimientoFolios.Show(iCaso);
            }
            catch (Exception)
            {
                MessageBox.Show("No existen llamadas de este folio", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*Evento para evitar escrituta en los controles combobox*/
        private void LimitarEscritura(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /*Evento click boton Cancelar para cerrar formulario*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _DialogResult = DialogResult.No;
            _AsignarConsultor.Close();
            //Close();
        }

        /*Evento CheckedChanged para visualizar controles dependiendo su selección*/
        private void ckbContador_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbContador.Checked == true)
            {
                rbSi.Enabled        = false;
                rbNo.Enabled        = false;
                plNO.Visible        = false;
                plContador.Visible  = true;
                plContador.Location = new Point(6, 59);
                //cargarContador(idContador);
            }
            else
            {
                rbSi.Enabled        = true;
                rbNo.Enabled        = true;
                plNO.Visible        = true;
                plContador.Visible  = false;
            }
        }

        private void cmbTipoEvento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnAddTipificacion.Enabled = false;
            cmbTipificacion.Enabled = false;
            //cmbTipoEvento.DataSource = null;
            //cmbTipoEvento.Items.Clear();

            sResolucion = "N/A";

            if (cmbTipoEvento.SelectedItem != null)
            {
                TipoEventosData sIdEmpresa = (TipoEventosData)cmbTipoEvento.SelectedItem;
                iIdSolicitudTipo = int.Parse(sIdEmpresa.sIdTipoEvento.ToString());

                if (iIdSolicitudTipo > 1)
                {

                    if (iIdSolicitudTipo > 3)
                    {
                        sResolucion = "EN PROCESO";
                    }

                    btnAddTipificacion.Enabled = true;
                     /*Consumo de funcion para la carga de tipificaciones ya registradas en el combobox*/
                     DatosServicios AServicios = new DatosServicios();
                    List<ServicioData> LServicios = AServicios.listaServicios(idMateria, iIdSolicitudTipo);

                    if (LServicios.Count > 0)
                    {
                        this.cmbTipificacion.DataSource = LServicios;
                        this.cmbTipificacion.ValueMember = "sIdServicio";
                        this.cmbTipificacion.DisplayMember = "sTipificacion";
                        this.cmbTipificacion.SelectedIndex = -1;
                        cmbTipificacion.Enabled = true;

                        if (iTipificacion != 0)
                        {
                            this.cmbTipificacion.SelectedValue = iTipificacion.ToString();
                        }
                    }
                }
            }
        }
        
       
        private void btnAddTipificacion_Click(object sender, EventArgs e)
        {
            pnlAddServicio.Visible = true;
            //pnlAddServicio.Location = new Point(622, 297);
            EstadoControles(false);
        }

        private void btnCancelTip_Click(object sender, EventArgs e)
        {
            // Oculta el panel para crear una nueva carpeta
            pnlAddServicio.Visible = false;
            txtServicio.Clear();
            cmbTipoEvento_SelectionChangeCommitted(sender, e);
            EstadoControles(true);
        }

        private void btnRegTip_Click(object sender, EventArgs e)
        {
            iTipificacion = 0;
            if (txtServicio.Text != string.Empty)
            {
                DSDetalleServicio addServicio = new DSDetalleServicio();

                idTipifExis = addServicio.existeTipif(idMateria, iIdSolicitudTipo, txtServicio.Text.ToUpper());

                if (idTipifExis == null)
                {
                    DialogResult reg = MessageBox.Show(string.Format("{0} {1} {2}", "¿Estás seguro de agregar la tipificación ", txtServicio.Text.ToUpper(), " al catalogo?"), "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (reg == DialogResult.Yes)
                    {

                        try
                        {
                            iTipificacion = addServicio.addServicio(idMateria, iIdSolicitudTipo, txtServicio.Text.ToUpper());

                            // Oculta y limpia el panel para nueva carpeta
                            pnlAddServicio.Visible = false;
                            txtServicio.Clear();
                            EstadoControles(true);
                            cmbTipoEvento_SelectionChangeCommitted(sender, e);

                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                else
                {
                    MessageBox.Show(string.Format("{0} {1} {2}", "La tipificación: ", txtServicio.Text.ToUpper(), " ya se encuentra registrada"), "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Es necesario ingresar la tipificación del servicio", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void EstadoControles(bool Status)
        {
            cmbTipoEvento.Enabled           = Status;
            btnAddTipificacion.Enabled      = Status;
            
            //cmbTipificacion.Enabled = Status;
            cmbConsultor.Enabled            = Status;
            btnConsultarllamadas.Enabled    = Status;
            rbSi.Enabled                    = Status;
            rbNo.Enabled                    = Status;
            //cmbTipificacion.Enabled = Status;
            txtDescripcion.Enabled          = Status;
            btnEnviar.Enabled               = Status;
            btnCancelar.Enabled             = Status;
        }
    }
}
