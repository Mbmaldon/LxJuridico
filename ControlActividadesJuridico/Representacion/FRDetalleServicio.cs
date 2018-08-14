using ClaseData.Clases;
using ClaseData.Clases.AccesoArchivos;
using ClaseData.Clases.ListServicio;
using ClaseData.Clases.Solicitud;
using ClaseData.Clases.Solicitud.DetalleServicio;
using ClaseData.Clases.Solicitud.Entidades;
using ControlActividadesJuridico.Representacion.RegistroAvances;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion
{
    public partial class FRDetalleServicio : Form
    {
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
        public FRDetalleServicio() : this(false) { }

        public FRDetalleServicio(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
        }

        static FRDetalleServicio _DetalleServicio;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show(int iIdSolicitud, int iIdCaso)
        {
            _DetalleServicio = new FRDetalleServicio();
            Form frmSet = Application.OpenForms["FPrincipal"];
            FBandeja _FBandeja = Application.OpenForms["FBandeja"] as FBandeja;

            _DetalleServicio.FormClosed += new FormClosedEventHandler(_FBandeja.ActualizarSolPendientes_FormClosed);


            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _DetalleServicio.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _DetalleServicio.Location = new Point(x, y);

            //_NuevaSolicitud.label1.Text = string.Format("Hola {0},", sNombre);
            //_NuevaSolicitud.InitializeControls();
            _DetalleServicio.iIdSol = iIdSolicitud;
            _DetalleServicio.iCaso = iIdCaso;

            //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
            LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
            _DetalleServicio.iIdUser = int.Parse(AUsuarioData.sIdusuario);
            //iIdMateria = int.Parse(ADatosUsuario.sIdMateria);
            if (AUsuarioData.sTipoUsuario == "20082")
                _DetalleServicio.iIdMateria = 2;
            else if (AUsuarioData.sTipoUsuario == "20083")
                _DetalleServicio.iIdMateria = 3;
            else
                _DetalleServicio.iIdMateria = 1;

            _DetalleServicio.detalle = null;
            DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
            _DetalleServicio.detalle = detalleSolicitud.InfoSolicitud(iIdSolicitud);

            _DetalleServicio.SolicitudDetalle(_DetalleServicio.detalle);

            _DetalleServicio.cargarDataGrid();

            _DetalleServicio.timer.Interval = 200;
            _DetalleServicio.timer.Tick += new EventHandler(_DetalleServicio.timer_Tick);

            if (_DetalleServicio.iIdSolicitudTipo == 2)
            {
                _DetalleServicio.tabPage5.Text = "Bitacora";
            }
            if (_DetalleServicio.iIdSolicitudTipo == 3)
            {
                _DetalleServicio.tcDetalles.TabPages.Remove(_DetalleServicio.tabPage5);
            }
            if (_DetalleServicio.iIdSolicitudTipo == 4)
            {
                //_DetalleServicio.tabPage5.Text = "Expediente";
                _DetalleServicio.tcDetalles.TabPages.Remove(_DetalleServicio.tabPage5);
            }

            if (_DetalleServicio.dgvPropuestas.Rows.Count > 0)
            {
                _DetalleServicio.btnEnviarTramite.Visible = true;
            }


            _DialogResult = DialogResult.No;

            _DetalleServicio.Activate();
            _DetalleServicio.ShowDialog();

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


        int     iIdSol;
        int     iCaso;
        int     iIdUser;
        int     iIdMateria;
        int     iContador;
        int     idContadorAsignado;
        int     iBanderaProp = 0;
        int     iIdSolicitudTipo;
        int     iTipificacion;

        string  sNumero;
        string  sUrlCitas;
        string  sCorreoCliente;
        string  sConsul;
        string  sTipEvento;
        private int nIndex = 0;
        ISDetalleServicio detalle;

        //NetworkCredential _NetworkCredential = new NetworkCredential(AccessFiles.sUsuario, AccessFiles.sContraseña);
        //string PathFolderShared = @"\\192.169.143.34\Data_Files";

        // Node being dragged
        private TreeNode dragNode = null;
        //TreeView trvFolder;
        // Temporary drop node for selection
        private TreeNode tempDropNode = null;

        // Timer for scrolling
        private Timer timer = new Timer();

        string sNodeSeleccionado = null;
        string sFolderSeleccionado = null;
        string sFolderFullPath = null;

        #region CODIGO FORMULARIO
        /*Funciones que se inicializan cuando el formulario es llamado*/
        //public FRDetalleServicio(int iIdSolicitud, int iIdCaso)
        //{
        //    InitializeComponent();
        //    iIdSol = iIdSolicitud;
        //    iCaso = iIdCaso;

        //    //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
        //    LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
        //    iIdUser = int.Parse(AUsuarioData.sIdusuario);
        //    //iIdMateria = int.Parse(ADatosUsuario.sIdMateria);
        //    if (AUsuarioData.sTipoUsuario == "20082")
        //        iIdMateria = 2;
        //    else if (AUsuarioData.sTipoUsuario == "20083")
        //        iIdMateria = 3;
        //    else
        //        iIdMateria = 1;

        //    detalle = null;
        //    DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
        //    detalle = detalleSolicitud.InfoSolicitud(iIdSolicitud);

        //    SolicitudDetalle(detalle);

        //    cargarDataGrid();

        //    timer.Interval = 200;
        //    timer.Tick += new EventHandler(timer_Tick);

        //    if (iIdSolicitudTipo == 2)
        //    {
        //        tabPage5.Text = "Bitacora";
        //    }
        //    if (iIdSolicitudTipo == 3)
        //    {
        //        tcDetalles.TabPages.Remove(tabPage5);
        //    }
        //    if (iIdSolicitudTipo == 4)
        //    {
        //        tabPage5.Text = "Expediente";
        //    }

        //}

        /*Función para limpiar la selección de los registros cargados en los datagrid*/
        public void seleccion()
        {
            dgvEventos.ClearSelection();
            dgvSolicitudInformacion.ClearSelection();
            dgvDocumentos.ClearSelection();
            dgvPropuestas.ClearSelection();
        }

        /*Función para vaciar la información en los controles visibles del diseño*/
        private void SolicitudDetalle(ISDetalleServicio detSolicitud)
        {
            lblNocliente1.Text      = detSolicitud.sNumCliente;
            lblNomCliente.Text      = detSolicitud.sNombreCliente;
            lblRFC.Text             = detSolicitud.sRFC;
            lblTelCelular.Text      = detSolicitud.sTelefonoMovil;
            sNumero                 = detSolicitud.sTelefonoMovil; //detSolicitud.sTelefonoMovil; 2225771837
            lblTipoPersona.Text     = detSolicitud.sTipoPersona;
            lblServicio.Text        = detSolicitud.sTipoServicio;
            lblFolio.Text           = detSolicitud.sIdCaso;
            lblFechaRegistro.Text   = detSolicitud.sFechaRegistro;
            lblRegistro.Text        = detSolicitud.sRegistro;
            lblCoordinador.Text     = detSolicitud.sCoordinador;
            iIdSolicitudTipo        = int.Parse(detSolicitud.sIdTipoSolicitud);
            lblTipoEvento.Text      = detSolicitud.sTipoEvento;
            txtSolicitud.Text       = detSolicitud.sSolicitud;
            sUrlCitas               = detSolicitud.sUrlCitas;
            sCorreoCliente          = detSolicitud.sCorreo;
            sConsul                 = detSolicitud.sConsultor;
            sTipEvento              = detSolicitud.sTipoEvento;
            idContadorAsignado      = int.Parse(detSolicitud.sidMPYCC);
            lblTipificacion.Text    = detSolicitud.sTipificacion; 
        }

        /*Evento click del boton registrar y dar de un nuevo evento*/
        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
            FRREventos.Show(iIdMateria, iIdUser, iIdSol, lblNocliente1.Text, iCaso, iIdSolicitudTipo);
        }

        /*Evento click del boton registrar y dar de alta una solicitud de información al contador asignado al cliente*/
        private void btnRegistrarS_Click(object sender, EventArgs e)
        {
            //FRRSolicitarInformacion.Show(iIdSol, iIdUser, idContadorAsignado);
            FRRSolicitarInformacion.Show(iIdSol, iIdUser, idContadorAsignado, int.Parse(lblFolio.Text));
        }

        /*Evento click del boton registrar y dar de alta un documento solcitado al cliente*/
        private void btnRegistrarD_Click(object sender, EventArgs e)
        {
            FRRRegistroDocumento.Show(iIdSol, iIdUser);
        }

        /*Evento click del boton registrar y dar de alta una propuesta de respuesta de la solicitud*/
        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            int iContador = dgvPropuestas.Rows.Count;

            bool bPendiente;
            if (iContador < 3)
            {
                bPendiente = false;
                for (int i = 0; i < dgvPropuestas.RowCount; i++)
                {
                    if (dgvPropuestas.Rows[i].Cells[2].Value.ToString() == "SIN SOLICITAR")
                    {
                        bPendiente = true;
                    }
                }

                if (bPendiente == true)
                {
                    MessageBox.Show("Existe una propuesta pendiente por aprobar" + Environment.NewLine +  
                                    "Es necesario enviarla al coordinador", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FRRRegistrarPropuesta.Show(iIdSol, iIdUser);
                }
            }
            else
            {
                MessageBox.Show("Ya existen tres propuestas registradas las cuales deben ser aprobadas por el coordinador", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*Metodos para cargar los datagrid*/
        public void cargarDataGrid()
        {
            List<EEventos> EventosRegistrados   = new List<EEventos>();
            CInfoDetalles ARegistros            = new CInfoDetalles();

            EventosRegistrados = ARegistros.obtenerEventoS(iIdSol);

            iContador = 0;
            if (EventosRegistrados.Any())
            {
                foreach (EEventos vRow in EventosRegistrados)
                {
                    dgvEventos.Rows.Add(vRow.sIdSolicitudEvento,
                                        //vRow.sConsultor,
                                        //vRow.sExpOrigen,
                                        vRow.sNumExpediente,
                                        vRow.sJuzgado,
                                        vRow.sContraparte,
                                        vRow.sTipoJuicio,
                                        vRow.sEvento,
                                        vRow.sTarea,
                                        vRow.sFTerInterno,
                                        vRow.sFTerLegal,
                                        vRow.sPropuesta,
                                        "Editar");
                    iContador++;
                }
            }

            List<ESolicitudesInformacion> SolicitudesRegistradss = new List<ESolicitudesInformacion>();
            CInfoDetalles ASolicitudesR = new CInfoDetalles();

            SolicitudesRegistradss = ASolicitudesR.obtenerSolicitudesI(iIdSol);

            iContador = 0;
            if (SolicitudesRegistradss.Any())
            {
                foreach (ESolicitudesInformacion vRow in SolicitudesRegistradss)
                {
                    dgvSolicitudInformacion.Rows.Add(vRow.sIdSolicitudInformacion,
                                                     vRow.sConsultor,
                                                     vRow.sSolicitud,
                                                     vRow.sFechaRegistro,
                                                     vRow.sFechaVigencia,
                                                     vRow.sResponsable,
                                                     vRow.sEstatus,
                                                     "Detalles");
                    iContador++;
                }
            }

            List<EDocumento> DocumentosSolicitados  = new List<EDocumento>();
            CInfoDetalles ADocumentos               = new CInfoDetalles();

            DocumentosSolicitados = ADocumentos.obtenerDocumentosSolicitados(iIdSol);

            iContador = 0;
            if (DocumentosSolicitados.Any())
            {
                foreach (EDocumento vRow in DocumentosSolicitados)
                {
                    dgvDocumentos.Rows.Add(vRow.sIdIdSolicitudDocumento,
                                        vRow.sRequisicion,
                                        vRow.sTipoReq,
                                        vRow.sRecibido,
                                        "Recepción");
                    iContador++;
                }
            }
            
            List<EPropuestaRespuesta> RegistroPropuestas = new List<EPropuestaRespuesta>();
            CInfoDetalles APropuestas = new CInfoDetalles();

            RegistroPropuestas = APropuestas.obtenerPropuestasRegistradas(iIdSol);

            iContador = 0;
            if (RegistroPropuestas.Any())
            {
                foreach (EPropuestaRespuesta vRow in RegistroPropuestas)
                {
                    dgvPropuestas.Rows.Add(vRow.sIdPropuestaRespuesta,
                                        vRow.sPropuesta,
                                        vRow.sAprobacion,
                                        vRow.sDescripcionRechazo,
                                        vRow.sCoordinador,
                                        "Detalles y/o Editar");
                    iContador++;
                }
            }
            estatusSI();
            documento();
            seleccion();
        }

        /*Función para modificar el tipo de recepción del documento*/
        public void documento()
        {
            for (int i = 0; i < dgvDocumentos.RowCount; i++)
            {
                if (dgvDocumentos.Rows[i].Cells[3].FormattedValue.ToString() == "True")
                {
                    dgvDocumentos.Rows[i].Cells[3].Value = "SI";
                }
                else if (dgvDocumentos.Rows[i].Cells[3].FormattedValue.ToString() == "False")
                {
                    dgvDocumentos.Rows[i].Cells[3].Value = "NO";
                }
            }
        }

        /*Función para semaforizar la entrega de la solicitud de información*/
        public void estatusSI()
        {
            for (int i = 0; i < dgvSolicitudInformacion.RowCount; i++)
            {
                string s = dgvSolicitudInformacion.Rows[i].Cells[6].FormattedValue.ToString();

                if (dgvSolicitudInformacion.Rows[i].Cells[6].FormattedValue.ToString().Equals("P"))
                {
                    dgvSolicitudInformacion.Rows[i].Cells[6].Style.BackColor    = Color.FromArgb(244, 67, 54);
                    dgvSolicitudInformacion.Rows[i].Cells[6].Style.ForeColor    = Color.FromArgb(244, 67, 54);
                    dgvSolicitudInformacion.Rows[i].Cells[6].Style.Alignment    = DataGridViewContentAlignment.MiddleCenter;
                    dgvSolicitudInformacion.Rows[i].Cells[6].Value              = string.Empty;
                }
                else if (dgvSolicitudInformacion.Rows[i].Cells[6].FormattedValue.ToString() == "E")
                {
                    dgvSolicitudInformacion.Rows[i].Cells[6].Style.BackColor    = Color.FromArgb(76, 175, 80);
                    dgvSolicitudInformacion.Rows[i].Cells[6].Style.ForeColor    = Color.FromArgb(76, 175, 80);
                    dgvSolicitudInformacion.Rows[i].Cells[6].Style.Alignment    = DataGridViewContentAlignment.MiddleCenter;
                    dgvSolicitudInformacion.Rows[i].Cells[6].Value              = string.Empty;
                }
            }
        }

        /*Función para limpiar los registros de los datagrid del formulario*/
        public void limpiaDataGrid()
        {
            dgvEventos.Rows.Clear();
            dgvSolicitudInformacion.Rows.Clear();
            dgvDocumentos.Rows.Clear();
            dgvPropuestas.Rows.Clear();
        }

        /*Evento FormClosed para detonar funciones al cerrar ventanas emergentes*/
        public void ActualizarDetalles_FormClosed(object sender, FormClosedEventArgs e)
        {
            limpiaDataGrid();
            cargarDataGrid();
           
        }

        /*Evento CheckedChanged para habilitar o deshabilitar el boton de enviar tramite*/
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEnviaraAprobacion.Checked == true)
            {
                btnEnviarTramite.Visible = true;
            }
            else
            {
                btnEnviarTramite.Visible = false;
            }
        }

        /*Evento click boton Enviar Trámite, Enviar la solicitud al coordinador ya alimentada por el consultor 
          para su revisión y aprobacion de la propuesta de respuesta registrada por el consultor */
        private void btnEnviarTramite_Click(object sender, EventArgs e)
        {
            bool bSoliciP       = false;
            bool bPendiente     = false;
            bool bDocumentos    = false;
            int  iIdPropuesta   = 0;
           

            for (int i = 0; i < dgvSolicitudInformacion.RowCount; i++)
            {
                if (dgvSolicitudInformacion.Rows[i].Cells[6].Style.BackColor == Color.FromArgb(244, 67, 54))
                {
                    bSoliciP = true;
                }
            }
       
            for (int i = 0; i < dgvPropuestas.RowCount; i++)
            {
                if (dgvPropuestas.Rows[i].Cells[2].Value.ToString() != "RECHAZADA")
                {
                    bPendiente = true;
                }
            }

            for (int i = 0; i < dgvDocumentos.RowCount; i++)
            {
                if (dgvDocumentos.Rows[i].Cells[3].Value.ToString() == "NO")
                {
                    bDocumentos = true;
                }
            }

            for (int i = 0; i < dgvPropuestas.RowCount; i++)
            {
                if (dgvPropuestas.Rows[i].Cells[2].Value.ToString() == "SIN SOLICITAR")
                {
                    iIdPropuesta = int.Parse(dgvPropuestas.Rows[i].Cells[0].Value.ToString());
                }
            }

            if (bSoliciP != true)
            {
                iBanderaProp = 1;
                if (bDocumentos == true)
                {

                    DialogResult doc = MessageBox.Show("Existen documentos pendientes" + Environment.NewLine + "¿Deseas enviar la propuesta para su aprobación?" , "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (doc == DialogResult.Yes)
                    {

                        if (bPendiente == true)
                        {
                            DialogResult rs = MessageBox.Show("¿Estás seguro de enviar la solicitud al gerente para su aprobación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (rs == DialogResult.Yes)
                            {
                                new Solicitud().SolicitudAprobacion(iIdSol, iIdPropuesta);
                                Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Es necesario registrar una nueva propuesta de respuesta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            chbEnviaraAprobacion.Checked = false;
                        }
                    }
                }
                else
                {
                    if (bPendiente == true)
                    {
                        DialogResult rs = MessageBox.Show("¿Estás seguro de enviar la solicitud al gerente para su aprobación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                        {
                            new Solicitud().SolicitudAprobacion(iIdSol, iIdPropuesta);
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Es necesario registrar una nueva propuesta de respuesta", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chbEnviaraAprobacion.Checked = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Existen solicitudes de información pendientes" + Environment.NewLine + "Es necesario recabar la información solicitada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*Evento click boton consultar llamadas, muestra ventana modal si existen llamadas del folio*/
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
                MessageBox.Show("No existen llamadas de este folio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*Evento click del boton citas, al dar click en este boton direcciona a una ventana en la cual permite registrar y visualizar las citas agendadas con el cliente*/
        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(sUrlCitas);
            }
            catch
            {
            }
        }

        /* Evento SelectedIndexChanged del tcDetalles para visualizar u ocultar datagrid dependiendo el seleccionado*/
        private void tcDetalles_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvEventos.Rows.Clear();
            dgvSolicitudInformacion.Rows.Clear();
            dgvDocumentos.Rows.Clear();
            dgvPropuestas.Rows.Clear();

            dgvEventos.Visible              = false;
            dgvSolicitudInformacion.Visible = false;
            dgvDocumentos.Visible           = false;
            dgvPropuestas.Visible           = false;

            
            if (tcDetalles.SelectedTab.Name =="tabPage1")
            {
                //tcDetalles.SelectedTab.BackColor = tabPage1.BackColor.ToArgb(Color.Blue);
                
                dgvEventos.Visible = true;
                cargarDataGrid();
            }
            else if (tcDetalles.SelectedTab.Name == "tabPage2")
            {
                //tcDetalles.SelectedTab.BackColor = Color.Blue;

                dgvSolicitudInformacion.Visible = true;
                cargarDataGrid();
            }
            else if (tcDetalles.SelectedTab.Name == "tabPage3")
            {
                //tcDetalles.SelectedTab.BackColor = Color.Blue;

                dgvDocumentos.Visible = true;
                cargarDataGrid();
            }
            else if (tcDetalles.SelectedTab.Name == "tabPage4")
            {
                //tcDetalles.SelectedTab.BackColor = Color.Blue;

                dgvPropuestas.Visible = true;
                cargarDataGrid();
            }

            else if(tcDetalles.SelectedTab.Name == "tabPage5")
            {
                lecturaCarpetas();
            }
        }

        /*Evento CheckedChanged para detonar el envio de correo al cliente de la documentacion faltante*/
        private void chbNotificar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNotificar.Checked == true)
            {
                int RDoc = dgvDocumentos.RowCount;
                if (RDoc != 0)
                {
                    string sRequisicion = null;
                    DialogResult rs = MessageBox.Show("¿Estás seguro de enviar la notificación al cliente de la requisición faltante?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        for (int i = 0; i < dgvDocumentos.RowCount; i++)
                        {
                            if (dgvDocumentos.Rows[i].Cells[3].Value.ToString() == "NO")
                            {
                                if (sRequisicion == null)
                                {
                                    sRequisicion = "* " + dgvDocumentos.Rows[i].Cells[1].Value.ToString() + "   -   " + dgvDocumentos.Rows[i].Cells[2].Value.ToString();
                                }
                                else
                                {
                                    sRequisicion += "<br>" + "* " + dgvDocumentos.Rows[i].Cells[1].Value.ToString() + "   -   " + dgvDocumentos.Rows[i].Cells[2].Value.ToString();
                                }
                            }
                        }
                        string sAsunto = "Requisición de Documento(s) o Testigo(s)";
                        string sContenido = string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}", "El consultor", sConsul, "que lleva el servicio de tipo", sTipEvento, "con No. folio", iCaso, "requiere la siguiente información para poder avanzar y darle una respuesta.", "<br><br>", "Requisición     -    Tipo Requisición", "<br>", sRequisicion);
                        string sMensaje = string.Format("{0} {1} {2} {3} {4} {5}{6}", "El consultor", sConsul, "que lleva el servicio de tipo", sTipEvento, "con No. folio", iCaso, ". requiere informacion. Favor de revisar su correo electronico");

                        enviarCorreo(sCorreoCliente, sAsunto, sContenido);

                        try
                        {
                            new DSDetalleServicio().enviarMensaje(sMensaje, sNumero);
                        }
                        catch (Exception ex)
                        {
                        }
                       
                        chbNotificar.Checked = false;
                    }
                    else
                    {
                        chbNotificar.Checked = false;
                    }
                }
                else
                {
                    DialogResult rd = MessageBox.Show("No existe registro de documentos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (rd == DialogResult.OK)
                    {
                        chbNotificar.Checked = false;
                    }
                }
            }
        }

        /*Función para enviar correo al cliente de los  documentos que el contador le ha solicitado y no han sido entregados por el cliente*/
        private void enviarCorreo(string correo, string _asunto, string _contenido)
        {
            try
            {
                SmtpClient _client = new SmtpClient("smtp.gmail.com", 587);

                //AGREGAS LAS CREDENCIALES DEL CORREO DEL CUAL SE ENVIARA EL MENSAJE
                //NetworkCredential _credential = new NetworkCredential("marketing@lexa.com.mx", "*10*lexa*1090");
                NetworkCredential _credential = new NetworkCredential("soporte@lexa.com.mx", "SysLex@1216");
                MailMessage _message = new MailMessage();

                _message.From = new MailAddress("soporte@lexa.com.mx", "Requisición de Documento(s) o Testigo(s)");
                _message.To.Add(correo);
                _message.Subject = _asunto;

                //AGREGAS EL CONTENIDO (YA ESTA CON UN ESTILO DE HTML)
                string htmlBody = "<html><body><p style='color:#16216A;font-size:17px;font-weight:bold; text-align:left;'>" + _contenido + "</p><p style='color:#C9C9C9;font-size:14px;font-weight:bold; text-align:left;'>Este es un mensaje automático. Favor no contestar a este e-mail.</p></body></html>";
                AlternateView avHtml = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);
                //AGREGAMOS LA VISTA ALTERNATIVA
                _message.AlternateViews.Add(avHtml);

                //ASIGNACIÓN DE CREDENCIAL Y ENVIO DE CORREO
                _client.Credentials = _credential;
                _client.EnableSsl = true;
                _client.Send(_message);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Eventos CellContentClick para lanzar modal segun el click en la columna detalles de los datagrid
        private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvEventos.Columns[e.ColumnIndex].Name.Equals("Editar"))
                {
                    FRREditEvento aFormulario   = new FRREditEvento(int.Parse(dgvEventos.SelectedCells[0].FormattedValue.ToString()), lblNocliente1.Text, iCaso, iIdUser);
                    aFormulario.FormClosed      += new FormClosedEventHandler(ActualizarDetalles_FormClosed);
                    aFormulario.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvSolicitudInformacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvSolicitudInformacion.Columns[e.ColumnIndex].Name.Equals("detallesSI"))
                {
                    //FRRRSolicitudInformacion aFormulario = new FRRRSolicitudInformacion(int.Parse(dgvSolicitudInformacion.SelectedCells[0].FormattedValue.ToString()));
                    //aFormulario.ShowDialog();
                    FRRRSolicitudInformacion.Show(int.Parse(dgvSolicitudInformacion.SelectedCells[0].FormattedValue.ToString()));
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void dgvDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvDocumentos.Columns[e.ColumnIndex].Name.Equals("Recepcion"))
                {
                    if (dgvDocumentos.SelectedCells[3].FormattedValue.ToString() == "SI")
                    {
                        FRRDocumento aFormulario    = new FRRDocumento(iIdSol, int.Parse(dgvDocumentos.SelectedCells[0].FormattedValue.ToString()), 1);
                        aFormulario.FormClosed      += new FormClosedEventHandler(ActualizarDetalles_FormClosed);
                        aFormulario.ShowDialog();
                        //dgvDocumentos.Rows.Clear();
                    }
                    else
                    {
                        FRRDocumento aFormulario    = new FRRDocumento(iIdSol, int.Parse(dgvDocumentos.SelectedCells[0].FormattedValue.ToString()), 0);
                        aFormulario.FormClosed      += new FormClosedEventHandler(ActualizarDetalles_FormClosed);
                        aFormulario.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvPropuestas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvPropuestas.Columns[e.ColumnIndex].Name.Equals("Detalles"))
                {
                    if (dgvPropuestas.SelectedCells[2].FormattedValue.ToString() == "SIN SOLICITAR")
                    {
                        FRREditPropuesta aFormulario    = new FRREditPropuesta(iIdSol, int.Parse(dgvPropuestas.SelectedCells[0].FormattedValue.ToString()), 0);
                        aFormulario.FormClosed          += new FormClosedEventHandler(ActualizarDetalles_FormClosed);
                        aFormulario.ShowDialog();
                    }
                    else if (dgvPropuestas.SelectedCells[2].FormattedValue.ToString() == "APROBADA")
                    {
                        FRRAprobarPropuesta aFormulario = new FRRAprobarPropuesta(int.Parse(dgvPropuestas.SelectedCells[0].FormattedValue.ToString()), 1, 1);
                        aFormulario.ShowDialog();
                    }
                    else if (dgvPropuestas.SelectedCells[2].FormattedValue.ToString() == "RECHAZADA")
                    {
                        FRRAprobarPropuesta aFormulario = new FRRAprobarPropuesta(int.Parse(dgvPropuestas.SelectedCells[0].FormattedValue.ToString()), 2, 1);
                        aFormulario.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        #endregion

        /*Evento click de boton cancelar para cerrar formulario*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            int iBDocumentos = 0;
            int iBProp = 0;
            for (int i = 0; i < dgvDocumentos.RowCount; i++)
            {
                if (dgvDocumentos.Rows[i].Cells[3].FormattedValue.ToString() == "NO")
                {
                    iBDocumentos = 1;
                }
            }

            for (int i = 0; i < dgvPropuestas.RowCount; i++)
            {
                if (dgvPropuestas.Rows[i].Cells[2].FormattedValue.ToString() == "SIN SOLICITAR")
                {
                    iBProp = 1;
                }
            }

            if (iBDocumentos > 0)
            {

                DialogResult rs = MessageBox.Show("Existen solicitudes de documentos abiertas" + Environment.NewLine +
                                                  "¿Desea salir sin notificarle al cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //e.Cancel = true;
                    _DialogResult = DialogResult.No;
                    _DetalleServicio.Close();
                }
                else if (iBProp > 0 && iBanderaProp == 0)
                {
                    DialogResult pro = MessageBox.Show("Existen propuestas sin solicitar aprobación" + Environment.NewLine +
                                                       "¿Desea salir sin enviar a su aprobación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (pro == DialogResult.Yes)
                    {
                        //e.Cancel = true;
                        _DialogResult = DialogResult.No;
                        _DetalleServicio.Close();
                    }
                }
            }
            else if (iBProp > 0 && iBanderaProp == 0)
            {
                DialogResult pro = MessageBox.Show("Existen propuestas sin solicitar aprobación" + Environment.NewLine +
                                                   "¿Desea salir sin enviar a su aprobación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pro == DialogResult.Yes)
                {
                    //e.Cancel = true;
                    _DialogResult = DialogResult.No;
                    _DetalleServicio.Close();
                }
            }
            else
            {
                _DialogResult = DialogResult.No;
                _DetalleServicio.Close();
            }
        }

        /*Evento formClosing, solicita autorización para cerrar el formulario ya que contempla varias validaciones para poder realizar la accion de cierre de formulario*/
        private void FRDetalleServicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            //int iBDocumentos = 0;
            //int iBProp = 0;
            //for (int i = 0; i < dgvDocumentos.RowCount; i++)
            //{
            //    if (dgvDocumentos.Rows[i].Cells[3].FormattedValue.ToString() == "NO")
            //    {
            //        iBDocumentos = 1;
            //    }
            //}

            //for (int i = 0; i < dgvPropuestas.RowCount; i++)
            //{
            //    if (dgvPropuestas.Rows[i].Cells[2].FormattedValue.ToString() == "SIN SOLICITAR")
            //    {
            //        iBProp = 1;
            //    }
            //}

            //if (iBDocumentos > 0)
            //{
                
            //    DialogResult rs = MessageBox.Show("Existen solicitudes de documentos abiertas" + Environment.NewLine + 
            //                                      "¿Desea salir sin notificarle al cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (rs == DialogResult.No)
            //    {
            //       e.Cancel = true;
            //    }
            //    else if (iBProp > 0 && iBanderaProp == 0)
            //    {
            //        DialogResult pro = MessageBox.Show("Existen propuestas sin solicitar aprobación" + Environment.NewLine + 
            //                                           "¿Desea salir sin enviar a su aprobación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (pro == DialogResult.No)
            //        {
            //            e.Cancel = true;
            //        }
            //    }
            //}
            //else if (iBProp > 0 && iBanderaProp == 0)
            //{
            //    DialogResult pro = MessageBox.Show("Existen propuestas sin solicitar aprobación" + Environment.NewLine + 
            //                                       "¿Desea salir sin enviar a su aprobación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (pro == DialogResult.No)
            //    {
            //        e.Cancel = true;
            //    }
            //}
        }

        public MaterialSkin.MaterialSkinManager SkinManager { get { return MaterialSkin.MaterialSkinManager.Instance; } }

        private void tcDetalles_DrawItem(object sender, DrawItemEventArgs e)
        {
            //switch (e.Index)
            //{
            //    case 0:
            //        e.Graphics.FillRectangle(new SolidBrush(Color.Red), e.Bounds);
            //        break;
            //    case 1:
            //        e.Graphics.FillRectangle(new SolidBrush(Color.Blue), e.Bounds);
            //        break;
            //    default:
            //        break;
            //}

            //// Then draw the current tab button text 
            //Rectangle paddedBounds = e.Bounds;
            //paddedBounds.Inflate(-2, -2);
            //e.Graphics.DrawString(tcDetalles.TabPages[e.Index].Text, this.Font, SystemBrushes.HighlightText, paddedBounds);

            TabPage CurrentTab = tcDetalles.TabPages[e.Index];
            Rectangle ItemRect = tcDetalles.GetTabRect(e.Index);
            //SolidBrush FillBrush = new SolidBrush(Color.FromArgb(0, 99, 177));
            //SolidBrush TextBrush = new SolidBrush(Color.White);
            SolidBrush FillBrush = new SolidBrush(Color.White);
            SolidBrush TextBrush = new SolidBrush(Color.Black);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            //If we are currently painting the Selected TabItem we'll
            //change the brush colors and inflate the rectangle.
            if (System.Convert.ToBoolean(e.State & DrawItemState.Selected))
            {
                FillBrush.Color = Color.FromArgb(7, 22, 127);
                TextBrush.Color = Color.White;
                ItemRect.Inflate(2, 2);
            }

            //Set up rotation for left and right aligned tabs
            if (tcDetalles.Alignment == TabAlignment.Left || tcDetalles.Alignment == TabAlignment.Right)
            {
                float RotateAngle = 90;
                if (tcDetalles.Alignment == TabAlignment.Left)
                    RotateAngle = 270;
                PointF cp = new PointF(ItemRect.Left + (ItemRect.Width / 2), ItemRect.Top + (ItemRect.Height / 2));
                e.Graphics.TranslateTransform(cp.X, cp.Y);
                e.Graphics.RotateTransform(RotateAngle);
                ItemRect = new Rectangle(-(ItemRect.Height / 2), -(ItemRect.Width / 2), ItemRect.Height, ItemRect.Width);
            }

            Font _tabFont = SkinManager.ROBOTO_REGULAR_7;

            //Next we'll paint the TabItem with our Fill Brush
            e.Graphics.FillRectangle(FillBrush, ItemRect);

            //Now draw the text.
            //e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, (RectangleF)ItemRect, sf);
            e.Graphics.DrawString(CurrentTab.Text, _tabFont, TextBrush, (RectangleF)ItemRect, sf);

            //Reset any Graphics rotation
            e.Graphics.ResetTransform();

            //Finally, we should Dispose of our brushes.
            FillBrush.Dispose();
            TextBrush.Dispose();
        }

        #region Evento CellPainting de datagrid para colocar imagen en la columna detalles
        private void dgvSolicitudInformacion_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvSolicitudInformacion.Columns[e.ColumnIndex].Name == "detallesSI" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvSolicitudInformacion.Rows[e.RowIndex].Cells["detallesSI"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.content_20px, e.CellBounds.Left + 14, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }

        private void dgvPropuestas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvPropuestas.Columns[e.ColumnIndex].Name == "Detalles" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvPropuestas.Rows[e.RowIndex].Cells["Detalles"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.content_20px, e.CellBounds.Left + 25, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }

        private void dgvEventos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvEventos.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvEventos.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.edit_row_20px, e.CellBounds.Left + 20, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }

        private void dgvDocumentos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvDocumentos.Columns[e.ColumnIndex].Name == "Recepcion" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvDocumentos.Rows[e.RowIndex].Cells["Recepcion"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.form_20px, e.CellBounds.Left + 23, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }
        #endregion

        #region Eventos CellMouseMove para cambiar el cursor cuando pase por la columna detalles de cada data grid
        private void dgvEventos_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEventos.Columns[e.ColumnIndex].Name.ToString() == "Editar")
            {
                dgvEventos.Cursor = Cursors.Hand;
            }
            else
            {
                dgvEventos.Cursor = Cursors.Default;
            }
        }

        private void dgvSolicitudInformacion_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvSolicitudInformacion.Columns[e.ColumnIndex].Name.ToString() == "detallesSI")
            {
                dgvSolicitudInformacion.Cursor = Cursors.Hand;
            }
            else
            {
                dgvSolicitudInformacion.Cursor = Cursors.Default;
            }
        }

        private void dgvDocumentos_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvDocumentos.Columns[e.ColumnIndex].Name.ToString() == "Recepcion")
            {
                dgvDocumentos.Cursor = Cursors.Hand;
            }
            else
            {
                dgvDocumentos.Cursor = Cursors.Default;
            }
        }

        private void dgvPropuestas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPropuestas.Columns[e.ColumnIndex].Name.ToString() == "Detalles")
            {
                dgvPropuestas.Cursor = Cursors.Hand;
            }
            else
            {
                dgvPropuestas.Cursor = Cursors.Default;
            }
        }

        #endregion

        #endregion

        #region codigo expediente
       
        string rutaInicial;
        public void lecturaCarpetas()
        {
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{

                if (!Directory.Exists(rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente"))
                {
                    Directory.CreateDirectory(rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente");
                }

                if (iIdSolicitudTipo == 2)
                {
                    if (!Directory.Exists(rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente\\" + "Bitacoras"))
                    {
                        Directory.CreateDirectory(rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente\\" + "Bitacoras");
                    }

                    if (!Directory.Exists(rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente\\" + "Otros Documentos"))
                    {
                        Directory.CreateDirectory(rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente\\" + "Otros Documentos");
                    }
                }

                //OBTIENE EL DIRECTORIO DEL CLIENTE SELECCIONADO
                DirectoryInfo dir = new DirectoryInfo(rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente");

                rutaInicial = dir.ToString();
              //OBTIENE LOS DIRECTORIOS DEL SERVIDOR
              DirectoryInfo[] dirInfos = dir.GetDirectories();
                foreach (DirectoryInfo directorio in dirInfos)
                {
                    try
                    {
                        cargarFolders(trvCarpetas, directorio.Name);

                        //trvCarpetas.AfterSelect += trvCarpetas_AfterSelect;
                        //trvCarpetas.NodeMouseClick += trvCarpetas_NodeMouseClick;
                        //trvCarpetas.LostFocus += TrvCarpetas2_LostFocus;
                        //trvCarpetas.GotFocus += TrvCarpetas2_GotFocus;
                                            
                        tabPage5.Controls.Add(trvCarpetas);
                        if (trvCarpetas.Nodes.Count > 0)
                        {
                            trvCarpetas.SelectedNode = trvCarpetas.SelectedNode.FirstNode;
                        }
                        trvCarpetas.ExpandAll();
                        //tbCarpetas.TabPages.Add(_TabPage);
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Error leyendo los discos: " + ex.Message, "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
                    }
                }

             
                // tabPage5. += TbCarpetas_SelectedIndexChanged;
            //}
        }

        public void cargarFolders(TreeView _TreeView, string sFolder)
        {
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                _TreeView.Nodes.Clear();
                //_TreeView.ShowPlusMinus = true;

                lblRuta.Text = rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente";

                ////OBTIENE LA RUTA DE LA CARPETA SELECCIONADA
                imageList1.ColorDepth = ColorDepth.Depth16Bit;
                _TreeView.ImageList = imageList1;
                string unidad = rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente";

                //RECORRE EL CONTENIDO PARA DETECTAR CARPETAS
                DirectoryInfo di = new DirectoryInfo(unidad);
                int color = 0;
                //string dirPrincipal = "";
                int index = 0;
                foreach (DirectoryInfo sub in di.GetDirectories())
                {
                    TreeNode aNode = new TreeNode(sub.Name, 0, 0);
                    aNode.ImageIndex = 0;
                    index = aNode.Index;

                    _TreeView.Nodes.Add(aNode);
                    lblRuta.Text = rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente" + "\\" + sub.Name;
                    aNode.Expand();
                }
                _TreeView.ShowPlusMinus = true;
                //_TreeView.ExpandAll();
            //}
        }
      
        private void trvCarpetas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //trvFolder = sender as TreeView;
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                //BUSCAR OTROS DIRECTORIO DE LA CARPETA SELECCIONADA
                if (trvCarpetas.SelectedNode.GetNodeCount(false) == 0)
                {
                    string carpeta = trvCarpetas.SelectedNode.FullPath;
                    string Disco = rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente";
                    DirectoryInfo file = new DirectoryInfo(Disco + "\\" + carpeta);

                    String atributos = file.Attributes.ToString();
                    if (atributos.Contains(FileAttributes.Directory.ToString()))
                    {
                        try
                        {
                            //RECORRE EL CONTENIDO PARA DETECTAR CARPETAS
                            //int color = 0;
                            foreach (DirectoryInfo sub in file.GetDirectories())
                            {
                                TreeNode aNode = new TreeNode(sub.Name, 0, 0);
                                aNode.ImageIndex = 0;

                                trvCarpetas.SelectedNode.Nodes.Add(aNode);
                            }
                            //RECORRE EL CONTENIDO PARA ASIGNAR ICONO POR TIPO DE ARCHIVO
                            foreach (var fi in file.GetFiles())
                            {
                                TreeNode nodo = new TreeNode();
                                nodo.Text = fi.Name;
                                if (fi.Extension == ".png"
                                    || fi.Extension == ".JPG"
                                    || fi.Extension == ".JPEG"
                                    || fi.Extension == ".jpg"
                                    || fi.Extension == ".ico")
                                {
                                    nodo.ImageIndex = 1;
                                    nodo.SelectedImageIndex = 1;
                                }
                                else if (fi.Extension == ".txt")
                                {
                                    nodo.ImageIndex = 2;
                                    nodo.SelectedImageIndex = 2;
                                }
                                else if (fi.Extension == ".pdf")
                                {
                                    nodo.ImageIndex = 3;
                                    nodo.SelectedImageIndex = 3;
                                }
                                else if (fi.Extension == ".bak" || fi.Extension == ".sql")
                                {
                                    nodo.ImageIndex = 4;
                                    nodo.SelectedImageIndex = 4;
                                }
                                else if (fi.Extension == ".zip" || fi.Extension == ".rar")
                                {
                                    nodo.ImageIndex = 5;
                                    nodo.SelectedImageIndex = 5;
                                }
                                else if (fi.Extension == ".xlsx" || fi.Extension == ".xls")
                                {
                                    nodo.ImageIndex = 6;
                                    nodo.SelectedImageIndex = 6;
                                }
                                else if (fi.Extension == ".xml" || fi.Extension == ".XML")
                                {
                                    nodo.ImageIndex = 7;
                                    nodo.SelectedImageIndex = 7;
                                }
                                else if (fi.Extension == ".cer")
                                {
                                    nodo.ImageIndex = 8;
                                    nodo.SelectedImageIndex = 8;
                                }
                                else if (fi.Extension == ".docx" || fi.Extension == ".doc")
                                {
                                    nodo.ImageIndex = 10;
                                    nodo.SelectedImageIndex = 10;
                                }
                                else
                                {
                                    nodo.ImageIndex = 9;
                                    nodo.SelectedImageIndex = 9;
                                }

                                nIndex++;

                                trvCarpetas.SelectedNode.Nodes.Add(nodo);
                            }

                            //EXPANDE EL NODO SELECCIONADO
                            trvCarpetas.SelectedNode.Expand();
                           
                        }
                        catch (Exception ex)
                        {
                             MessageBox.Show("Se presentó un problema leyendo el directorio, error: " + ex.Message, "Atención...",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            //}
        }

        int dCarpeta = 0;
        private void trvCarpetas_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            dCarpeta = 0;
            sFolderFullPath = null;
             trvCarpetas = sender as TreeView;
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                //MUESTRA MENÚ SI SE PULSA BOTÓN DERECHO SOBRE UN ARCHIVO O NODO
                if (e.Button == MouseButtons.Right)
                {
                    this.abrirToolStripMenuItem.Visible = true;
                    this.renombrarToolStripMenuItem.Visible = false;

                    trvCarpetas.SelectedNode = e.Node;

                    if (trvCarpetas.SelectedNode.Text.Contains("."))
                    {
                        trvCarpetas.SelectedNode = e.Node;
                        if (e.Node != null) //CLICK EN EL ROOT
                        {
                            String carpeta = trvCarpetas.SelectedNode.FullPath;
                            String Disco = trvCarpetas.Name.ToString();
                            DirectoryInfo file = new DirectoryInfo(Path.Combine(Disco, carpeta));
                            String atributos = file.Attributes.ToString();

                            dCarpeta = 1;
                            if (!atributos.Contains(FileAttributes.Directory.ToString()))
                            {
                                this.contextMenuStrip1.Show(trvCarpetas, e.Location);
                            }
                        }
                    }
                    else
                    {
                        String carpeta = trvCarpetas.Name.ToString();
                        //String Disco = trvFolder.Name.ToString();
                        DirectoryInfo file = new DirectoryInfo(Path.Combine(carpeta));
                        String atributos = file.Attributes.ToString();

                        this.abrirToolStripMenuItem.Visible = false;
                        this.renombrarToolStripMenuItem.Visible = true;
                        this.contextMenuStrip1.Show(trvCarpetas, e.Location);
                    }
                }

                //OBTIENE LA RUTA DEL ARCHIVO O CARPETA SI SE PULSA EL BOTÓN IZQUIERDO SOBRE UN NODO O ARCHIVO
                if (e.Button == MouseButtons.Left)
                {
                    trvCarpetas.SelectedNode = e.Node;
                    if (e.Node != null) //CLICK EN EL ROOT
                    {
                        String carpeta = trvCarpetas.SelectedNode.FullPath;
                        //String Disco = trvFolder.Name.ToString();
                        DirectoryInfo file = new DirectoryInfo(Path.Combine(carpeta));
                        String atributos = file.Attributes.ToString();
                        if (!atributos.Contains(FileAttributes.Directory.ToString()))
                        {
                            lblRuta.Text = file.ToString();
                            try
                            {
                                lblRuta.Text = rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente" + "\\" + file.ToString();
                            }
                            catch
                            {
                                lblRuta.Text = rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente" + "\\" + trvCarpetas.Name + "\\" + file.ToString();
                            }
                        }
                    }
                }

                sNodeSeleccionado = trvCarpetas.SelectedNode.Text;
                sFolderSeleccionado = trvCarpetas.Name;
                try
                {
                    sFolderFullPath = trvCarpetas.SelectedNode.Parent.FullPath;
                }
                catch
                {
                }
            //}
        }

        //private void TrvCarpetas2_LostFocus(object sender, EventArgs e)
        //{
        //    //TreeView trvFolder = sender as TreeView;
        //    //lblRuta.Text = string.Empty;

        //    //trvFolder.SelectedNode = null;
        //}

        //private void TrvCarpetas2_GotFocus(object sender, EventArgs e)
        //{
        //    TreeView trvFolder = sender as TreeView;
        //    lblRuta.Text = string.Empty;

        //    trvFolder.SelectedNode = null;
        //}

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            pnlNuevaCarpeta.Visible = true;
          
            pnlNuevaCarpeta.Location = new Point(300, 360);
            EstadoControles(false);
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                //ASIGNA NOMBRE Y FILTRO DE ARCHIVOS AL CONTROL OPENFILEDIALOG
                openFileDialogDocumentos.Title = "Subir Archivos";
                //openFileDialogDocumentos.Filter = "Pdf Files|*.pdf |JPG|*.jpg;*.jpeg |Excel Files|*.xls;*.xlsx;*.xlsm |txt files (*.txt)|*.txt|Zip Files|*.zip;*.rar";
                openFileDialogDocumentos.FileName = "";

                string sRuta = lblRuta.Text;

                if (openFileDialogDocumentos.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string carpeta = string.Empty;
                        //RECORRE LOS ARCHIVOS SELCCIONADOS DEL CONTROL OPENFILEDIALOG Y LOS COPIA AL SERVIDOR
                        //Y SE GUARDA UN REGISTRO EN EL LOG
                        foreach (string fileName in openFileDialogDocumentos.FileNames)
                        {
                            //trvCarpetas.BeginUpdate();
                            File.Copy(fileName, sRuta + @"\" + Path.GetFileName(fileName));
                            //trvCarpetas.EndUpdate();
                            EscribirLog("Se copió el archivo " + sRuta + @"\" + Path.GetFileName(fileName));

                            TreeNode nodo = new TreeNode();
                            nodo.Text = Path.GetFileName(fileName);

                            string extension = Path.GetExtension(fileName);

                            if (extension == ".png"
                                || extension == ".JPG"
                                || extension == ".JPEG"
                                || extension == ".jpg"
                                || extension == ".ico")
                            {
                                nodo.ImageIndex = 1;
                                nodo.SelectedImageIndex = 1;
                            }
                            else if (extension == ".txt")
                            {
                                nodo.ImageIndex = 2;
                                nodo.SelectedImageIndex = 2;
                            }
                            else if (extension == ".pdf")
                            {
                                nodo.ImageIndex = 3;
                                nodo.SelectedImageIndex = 3;
                            }
                            else if (extension == ".bak" || extension == ".sql")
                            {
                                nodo.ImageIndex = 4;
                                nodo.SelectedImageIndex = 4;
                            }
                            else if (extension == ".zip" || extension == ".rar")
                            {
                                nodo.ImageIndex = 5;
                                nodo.SelectedImageIndex = 5;
                            }
                            else if (extension == ".xlsx" || extension == ".xls")
                            {
                                nodo.ImageIndex = 6;
                                nodo.SelectedImageIndex = 6;
                            }
                            else if (extension == ".xml" || extension == ".XML")
                            {
                                nodo.ImageIndex = 7;
                                nodo.SelectedImageIndex = 7;
                            }
                            else if (extension == ".cer")
                            {
                                nodo.ImageIndex = 8;
                                nodo.SelectedImageIndex = 8;
                            }
                            else if (extension == ".docx" || extension == ".doc")
                            {
                                nodo.ImageIndex = 10;
                                nodo.SelectedImageIndex = 10;
                            }
                            else
                            {
                                nodo.ImageIndex = 9;
                                nodo.SelectedImageIndex = 9;
                            }

                            try
                            {
                                trvCarpetas.SelectedNode.Nodes.Add(nodo);
                            }
                            catch
                            {
                                trvCarpetas.Nodes.Add(nodo);
                            }
                        }
                       
                        //FlatMessageBox.Show("Archivo copiado.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
                        MessageBox.Show("Archivo copiado.", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        //metroProgressSpinner1.Visible = false;
                        //FlatMessageBox.Show(ex.Message, "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
                        MessageBox.Show(ex.Message, "ACEPTAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            //}
        }

        /// <summary>
        /// Método Público para escribir un log de los cambios de los archivos del expediente en linea
        /// </summary>
        /// <param name="strMessage">Mensaje que se guardara en el log.</param>
        public void EscribirLog(string strMessage)
        {
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                //VALIDACIÓN SI EL ARCHIVO EXISTE
                if (!File.Exists(rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + @"Expediente\Log.txt"))
                  
                {
                    var myFile = File.Create(rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + @"Expediente\Log.txt");
                    myFile.Close();
                }

                //RUTA DE ACCESO DEL ARCHIVO LOG
                string logFile = rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + @"Expediente\Log.txt";

                //APLICA FORMATO AL LOG Y ESCRIBE EL MENSAJE QUE SE PASA EN EL PARAMETRO STRMENSAJE.
                string line = string.Format("{0} | {1} | ", DateTime.Now, iIdUser);
                line += strMessage;
                FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
                StreamWriter swFromFileStream = new StreamWriter(fs);
                swFromFileStream.WriteLine(line);
                swFromFileStream.Flush();
                swFromFileStream.Close();
            //}
        }

        int renomFolder = 0;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string rutaRaiz = rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente";

            if (!string.IsNullOrEmpty(txtNomFolder.Text))
            {
                //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
                //{
                    //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO

                    if (trvCarpetas.SelectedNode != null)
                    {
                        if (renomFolder == 1)
                        {
                            if (lblRuta.Text != string.Empty)
                            {

                                // RENOMBRAR CARPETA
                                Directory.Move(carpeta + @"\" + nombreArchivo, carpeta + @"\" + txtNomFolder.Text);
                                this.trvCarpetas.SelectedNode.Text = txtNomFolder.Text;
                                this.trvCarpetas.SelectedNode.Name = txtNomFolder.Text;

                                // Oculta y limpia el panel para nueva carpeta
                                pnlNuevaCarpeta.Visible = false;
                                txtNomFolder.Clear();
                                
                                EstadoControles(true);
                            }
                        }
                        else
                        {

                            if (lblRuta.Text != string.Empty)
                            {
                                // Crea la carpeta
                                Directory.CreateDirectory(lblRuta.Text + @"\" + txtNomFolder.Text);
                                // Agrega la carpeta como nodo al treeview seleccionado
                                TreeNode aNode = new TreeNode(txtNomFolder.Text, 0, 0);
                                trvCarpetas.SelectedNode.Nodes.Add(aNode);

                                // Oculta y limpia el panel para nueva carpeta
                                pnlNuevaCarpeta.Visible = false;
                                txtNomFolder.Clear();
                                
                                EstadoControles(true);
                            }
                        }
                    }

                    else
                    {
                        //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO
                        var fileCount = (from direct in Directory.EnumerateDirectories(rutaRaiz) select direct).Count();
                        int i = fileCount;

                        if (i < 1)
                        {
                            Directory.CreateDirectory(rutaRaiz + @"\" + txtNomFolder.Text);

                            // Agrega la carpeta como nodo al treeview seleccionado
                            TreeNode aNode = new TreeNode(txtNomFolder.Text, 0, 0);
                            trvCarpetas.Nodes.Add(aNode);


                            // Oculta y limpia el panel para nueva carpeta
                            pnlNuevaCarpeta.Visible = false;
                            txtNomFolder.Clear();
                            EstadoControles(true);
                            lecturaCarpetas();
                        }
                        else
                        {
                            MessageBox.Show("Es necesario seleccionar la ruta donde se creara la nueva carpeta", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                //}
            }
            else
            {
                MessageBox.Show("Es necesario ingresar el nombre de la carpeta", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelarCrearCarpeta_Click(object sender, EventArgs e)
        {
            // Oculta el panel para crear una nueva carpeta
            pnlNuevaCarpeta.Visible = false;
            txtNomFolder.Clear();
            EstadoControles(true);
        }

        public void EstadoControles(bool Status)
        {
            btnConsultarllamadas.Enabled = Status;
            btnRegistrarCita.Enabled = Status;
            tcDetalles.Enabled = Status;
            btnCancelar.Enabled = Status;
            chbEnviaraAprobacion.Enabled = Status;
            btnEnviarTramite.Enabled = Status;
        }

        //OBTIENE LA RUTA DE LA CARPETA SELECCIONADA
        string carpeta = string.Empty;
        string nombreArchivo;

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                carpeta = string.Empty;
                try
                {
                    carpeta = rutaAdjuntarArchivo.Path + lblNocliente1.Text + @"\SolicitudesJuridicas\" + lblFolio.Text + @"\Expediente" + @"\" + sFolderFullPath;
                }
                catch
                {
                    carpeta = rutaAdjuntarArchivo.Path + lblNocliente1.Text + @"\SolicitudesJuridicas" + lblFolio.Text + @"\Expediente\" + sFolderFullPath;
                }

                //String nombreArchivo = trvCarpetas.SelectedNode.Text;
                 nombreArchivo = sNodeSeleccionado;
                string Disco = string.Format(rutaAdjuntarArchivo.Path + lblNocliente1.Text + @"\SolicitudesJuridicas\" + lblFolio.Text + @"\Expediente\" + sFolderFullPath);


                //OPCIONES QUE SE MUESTRAN AL PULSAR CLICK DERECHO SOBRE UN ARCHIVO
                if (contextMenuStrip1.Items[0].Selected)
                {
                    //ABRE EL ARCHIVO
                    EjecutarArchivo(carpeta, nombreArchivo);
                }
                else if (contextMenuStrip1.Items[1].Selected)
                {
                    contextMenuStrip1.Visible = false;
                    //TreeView _TreeView = this.ActiveControl as TreeView;
                    trvCarpetas = this.ActiveControl as TreeView;
                    //TreeNode node = _TreeView.Nodes.Cast<TreeNode>().FirstOrDefault(x => x.Text == nombreArchivo);
                    TreeNode node = trvCarpetas.SelectedNode;
                    //ELIMINA EL ARCHIVO
                    if (MessageBox.Show("¿Está seguro de eliminar la carpeta o archivos seleccionados?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            if (dCarpeta > 0)
                            {
                                //ELIMINA EL ARCHIVO Y ACTUALIZA EL TREEVIEW
                                File.Delete(carpeta + "\\" + nombreArchivo);
                                //trvCarpetas.SelectedNode.Remove();
                                trvCarpetas.Nodes.Remove(node);
                                MessageBox.Show("Se eliminó el archivo: " + nombreArchivo, "ACEPTAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                EscribirLog("Se eliminó el archivo " + carpeta + "\\" + nombreArchivo);
                            }
                            else
                            {
                                Directory.Delete(carpeta + "\\" + nombreArchivo, true);

                                trvCarpetas.Nodes.Remove(node);
                                MessageBox.Show("Se eliminó la carpeta: " + nombreArchivo, "ACEPTAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                EscribirLog("Se eliminó carpeta " + carpeta);
                                //lecturaCarpetas();
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("No se pudo eliminar.", "ACEPTAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                else if (contextMenuStrip1.Items[2].Selected)
                {
                    renomFolder = 1;
                    string path = carpeta;

                    //String nombreArchivo = trvCarpetas.SelectedNode.Text;
                    string seleccion = sNodeSeleccionado;

                    pnlNuevaCarpeta.Visible = true;

                    pnlNuevaCarpeta.Location = new Point(300, 360);
                    txtNomFolder.Text = seleccion.ToString();
                    EstadoControles(false);
                   
                    //Directory.Move(path + Fromfol, path + Tofol);
                }
            //}
        }

        /// <summary>
        /// Método Público para ejecutar un archivo
        /// </summary>
        /// <param name="pathFile"></param>
        /// <param name="nameFile"></param>
        private void EjecutarArchivo(String pathFile, String nameFile)
        {
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                //SE INICIA EL PROCESO CORRESPODIENTE AL TIPO DE ARCHIVO Y SE ABRE EL ARCHIVO
                using (Process pr = new Process())
                {
                    pr.StartInfo.FileName = pathFile + "\\" + nameFile;
                    pr.Start();
                }
            //}
        }

        private void trvCarpetas_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            if (e.Effect == DragDropEffects.Move)
            {
                // Show pointer cursor while dragging
                e.UseDefaultCursors = false;
                trvCarpetas.Cursor = Cursors.Default;
            }
            else e.UseDefaultCursors = true;
        }

        private void trvCarpetas_DragOver(object sender, DragEventArgs e)
        {
            // Compute drag position and move image
            Point formP = trvCarpetas.PointToClient(new Point(e.X, e.Y));
            //DragHelper.ImageList_DragMove(formP.X - trvFolder.Left, formP.Y - trvFolder.Top);
            DragHelper.ImageList_DragMove(formP.X, formP.Y);

            // Get actual drop node
            TreeNode dropNode = trvCarpetas.GetNodeAt(trvCarpetas.PointToClient(new Point(e.X, e.Y)));
            if (dropNode == null)
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            e.Effect = DragDropEffects.Move;

            // if mouse is on a new node select it
            if (this.tempDropNode != dropNode)
            {
                DragHelper.ImageList_DragShowNolock(false);
                trvCarpetas.SelectedNode = dropNode;
                DragHelper.ImageList_DragShowNolock(true);
                tempDropNode = dropNode;
            }

            // Avoid that drop node is child of drag node 
            TreeNode tmpNode = dropNode;
            while (tmpNode.Parent != null)
            {
                if (tmpNode.Parent == this.dragNode) e.Effect = DragDropEffects.None;
                tmpNode = tmpNode.Parent;
            }
        }

        private void trvCarpetas_DragLeave(object sender, EventArgs e)
        {
            DragHelper.ImageList_DragLeave(trvCarpetas.Handle);

            // Disable timer for scrolling dragged item
            this.timer.Enabled = false;
        }

        private void trvCarpetas_DragDrop(object sender, DragEventArgs e)
        {
            // Unlock updates
            DragHelper.ImageList_DragLeave(trvCarpetas.Handle);

            // Get drop node
            TreeNode dropNode = trvCarpetas.GetNodeAt(trvCarpetas.PointToClient(new Point(e.X, e.Y)));
            string Disco = string.Format(@"\\192.169.143.34\\Data_Files\\Documentos\\Clientes\\{0}\SolicitudesJuridicas\\{1}\Expediente\", lblNocliente1.Text, lblFolio.Text);
        

            string RutaMover = string.Empty;

            // If drop node isn't equal to drag node, add drag node as child of drop node
            if (this.dragNode != dropNode && !dropNode.Text.Contains("."))
            {
                // Código aquí para mover el archivo
                // Antigua ubicación: this.dragNode.FullPath
                // Nueva ubicación:   trvFolder.GetNodeAt(trvFolder.PointToClient(new Point(e.X, e.Y))).FullPath
                // Validación si es archivo o carpeta

                string antiguo = string.Format(@"{0}\{1}", Disco, this.dragNode.FullPath);
                string nuevo = string.Format(@"{0}\{1}", Disco, trvCarpetas.GetNodeAt(trvCarpetas.PointToClient(new Point(e.X, e.Y))).FullPath);
                // Remove drag node from parent
                if (this.dragNode.Parent == null)
                {
                    if (this.dragNode.Text.Contains("."))
                    {
                        // Es archivo
                        File.Move(antiguo, string.Format(@"{0}\{1}", nuevo, this.dragNode.Text));
                        EscribirLog(string.Format("Se movió el archivo {0} Antes: {1} Ahora: {2}", this.dragNode.Text, antiguo, string.Format(@"{0}\{1}", nuevo, this.dragNode.Text)));
                    }
                    else
                    {
                        // Es Directorio
                        Directory.Move(antiguo + @"\", string.Format(@"{0}\{1}", nuevo, this.dragNode.Text));
                        EscribirLog(string.Format(@"Se movió la carpeta {0} Antes: {1}\ Ahora: {2}", this.dragNode.Text, antiguo, string.Format(@"{0}\{1}", nuevo, this.dragNode.Text)));
                    }
                    trvCarpetas.Nodes.Remove(this.dragNode);
                }
                else
                {
                    if (this.dragNode.Text.Contains("."))
                    {
                        // Es archivo
                        File.Move(antiguo, string.Format(@"{0}\{1}", nuevo, this.dragNode.Text));
                        EscribirLog(string.Format("Se movió el archivo {0} Antes: {1} Ahora: {2}", this.dragNode.Text, antiguo, string.Format(@"{0}\{1}", nuevo, this.dragNode.Text)));
                    }
                    else
                    {
                        // Es Directorio
                        Directory.Move(antiguo + @"\", string.Format(@"{0}\{1}", nuevo, this.dragNode.Text));
                        EscribirLog(string.Format(@"Se movió la carpeta {0} Antes: {1}\ Ahora: {2}", this.dragNode.Text, antiguo, string.Format(@"{0}\{1}", nuevo, this.dragNode.Text)));
                    }
                    this.dragNode.Parent.Nodes.Remove(this.dragNode);
                }

                // Add drag node to drop node
                dropNode.Nodes.Add(this.dragNode);
                dropNode.ExpandAll();

                // Set drag node to null
                this.dragNode = null;

                // Disable scroll timer
                this.timer.Enabled = false;
            }
        }

        private void trvCarpetas_DragEnter(object sender, DragEventArgs e)
        {
            DragHelper.ImageList_DragEnter(trvCarpetas.Handle, e.X - trvCarpetas.Left,
                e.Y - trvCarpetas.Top);

            // Enable timer for scrolling dragged item
            this.timer.Enabled = true;
        }

        private void trvCarpetas_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // Get drag node and select it
            this.dragNode = (TreeNode)e.Item;
            trvCarpetas.SelectedNode = this.dragNode;

            // Reset image list used for drag image
            this.imageListDrag.Images.Clear();
            this.imageListDrag.ImageSize = new Size(this.dragNode.Bounds.Size.Width/* + trvFolder.Indent*/, this.dragNode.Bounds.Height);

            // Create new bitmap
            // This bitmap will contain the tree node image to be dragged
            Bitmap bmp = new Bitmap(this.dragNode.Bounds.Width + trvCarpetas.Indent, this.dragNode.Bounds.Height);

            // Get graphics from bitmap
            Graphics gfx = Graphics.FromImage(bmp);

            // Draw node icon into the bitmap
            //gfx.DrawImage(this.imageList1.Images[0], 0, 0);
            gfx.DrawImage(this.imageList1.Images[this.dragNode.ImageIndex], 0, 0);

            // Draw node label into bitmap
            gfx.DrawString(this.dragNode.Text,
                trvCarpetas.Font,
                new SolidBrush(trvCarpetas.ForeColor),
                (float)trvCarpetas.Indent, 1.0f);

            // Add bitmap to imagelist
            this.imageListDrag.Images.Add(bmp);

            // Get mouse position in client coordinates
            Point p = trvCarpetas.PointToClient(Control.MousePosition);

            // Compute delta between mouse position and node bounds
            int dx = p.X + trvCarpetas.Indent - this.dragNode.Bounds.Left;
            int dy = p.Y - this.dragNode.Bounds.Top;

            // Begin dragging image
            if (DragHelper.ImageList_BeginDrag(this.imageListDrag.Handle, 0, dx, dy))
            {
                // Begin dragging
                trvCarpetas.DoDragDrop(bmp, DragDropEffects.Move);
                // End dragging image
                DragHelper.ImageList_EndDrag();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // get node at mouse position
            Point pt = PointToClient(Control.MousePosition);
            TreeNode node = trvCarpetas.GetNodeAt(pt);

            if (node == null) return;

            // if mouse is near to the top, scroll up
            if (pt.Y < 30)
            {
                // set actual node to the upper one
                if (node.PrevVisibleNode != null)
                {
                    node = node.PrevVisibleNode;

                    // hide drag image
                    DragHelper.ImageList_DragShowNolock(false);
                    // scroll and refresh
                    node.EnsureVisible();
                    trvCarpetas.Refresh();
                    // show drag image
                    DragHelper.ImageList_DragShowNolock(true);

                }
            }
            // if mouse is near to the bottom, scroll down
            else if (pt.Y > trvCarpetas.Size.Height - 30)
            {
                if (node.NextVisibleNode != null)
                {
                    node = node.NextVisibleNode;

                    DragHelper.ImageList_DragShowNolock(false);
                    node.EnsureVisible();
                    trvCarpetas.Refresh();
                    DragHelper.ImageList_DragShowNolock(true);
                }
            }
        }

        #endregion

    }
}
