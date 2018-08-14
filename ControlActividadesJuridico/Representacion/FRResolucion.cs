using ClaseData.Clases;
using ClaseData.Clases.AccesoArchivos;
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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion
{
    public partial class FRResolucion : Form
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
        public FRResolucion() : this(false) { }

        public FRResolucion(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
        }

        //NetworkCredential _NetworkCredential = new NetworkCredential(AccessFiles.sUsuario, AccessFiles.sContraseña);
        //string PathFolderShared = @"\\192.169.143.34\Data_Files";

        int     iSol;
        int     iCaso;
        int     iIdUser;
        int     iContador;
        int     iBTicketCerrado = 0;
        int     iIdSolicitudTipo;

        private int nIndex = 0;

        string  sUrlCitas;

        //string UrlArchRespu;
        //string linkArchivo;

        ISDetalleServicioR detalle;
        ISRutaDocumento rutaArchivo;
        LinkLabel link;

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


        static FRResolucion _Resolucion;
        static DialogResult _DialogResult = DialogResult.No;

        List<ClaseData.Clases.Archivo.ArchivoEntidades.ERArchivo> LRuta;

        public static DialogResult Show(int iIdSolicitud, int iIdCaso)
        {
            _Resolucion = new FRResolucion();
            Form frmSet = Application.OpenForms["FPrincipal"];
            FBandeja _FBandeja = Application.OpenForms["FBandeja"] as FBandeja;

            _Resolucion.FormClosed += new FormClosedEventHandler(_FBandeja.ActualizarSolPendientes_FormClosed);

            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _Resolucion.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _Resolucion.Location = new Point(x, y);


            _Resolucion.iSol = iIdSolicitud;
            _Resolucion.iCaso = iIdCaso;

            _Resolucion.label19.Visible = false;
            _Resolucion.cmbResolucion.Visible = false;

            //Consume instancia para obtener información del usuario logueado
            //DatosUsuario ADatosUsuario  = DatosUsuario.Instancia;
            LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
            _Resolucion.iIdUser = int.Parse(AUsuarioData.sIdusuario);

            //Consume instancia para obtener los detalles de la solicitud 
            DSDetalleServicio detalleSolicitudR = new DSDetalleServicio();
            _Resolucion.detalle = detalleSolicitudR.InfoSolicitudR(iIdSolicitud);

             _Resolucion.rutaArchivo = null;
             _Resolucion.rutaArchivo = detalleSolicitudR.rutaArchivoDictamen(iIdSolicitud);
            _Resolucion.rutaDocument(_Resolucion.rutaArchivo);

             _Resolucion.SolicitudDetalle(_Resolucion.detalle);
            _Resolucion.cargarDataGrid();

             _Resolucion.timer.Interval = 200;
            _Resolucion.timer.Tick += new EventHandler(_Resolucion.timer_Tick);

            if (_Resolucion.iIdSolicitudTipo == 2)
            {
                _Resolucion.tabPage5.Text = "Bitacora";
            }
            if (_Resolucion.iIdSolicitudTipo == 3)
            {
                _Resolucion.tabControl1.TabPages.Remove(_Resolucion.tabPage5);
            }
            if (_Resolucion.iIdSolicitudTipo == 4)
            {
                //_Resolucion.tabPage5.Text = "Expediente";
                _Resolucion.tabControl1.TabPages.Remove(_Resolucion.tabPage5);

                _Resolucion.label19.Visible = true;
                 _Resolucion.cmbResolucion.Visible = true;
                _Resolucion.cargarResolucion();
            }

            // Sí existe una propuesta de propuesta aprobada,
            // cargamos la información.
            _Resolucion.LoadPropuesta(iIdSolicitud);


            _DialogResult = DialogResult.No;

            _Resolucion.Activate();
            _Resolucion.ShowDialog();

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

        /// <summary>
        /// Si existe una propuesta de respuesta aprobada,
        /// esta se carga para mostrar la información
        /// </summary>
        /// <param name="iIdSolicitud">Id de la solicitud</param>
        void LoadPropuesta(int iIdSolicitud)
        {
            Propuesta _Prop = new Propuesta().GetSucces(iIdSolicitud);
            if (_Prop != null)
                _Resolucion.txtResolucion.Text = _Prop.sPropuesta;

            _Resolucion.LRuta = null;
            ClaseData.Clases.Archivo.CDocumentosOficialia lRuta = new ClaseData.Clases.Archivo.CDocumentosOficialia();
            _Resolucion.LRuta = lRuta.rutaArchivosPropuesta(_Prop.iIdPropuesta);

            if (_Resolucion.LRuta.Any())
            {
                lnkAdjuntos.Visible = true;
                //for (int i = 0; i < _Resolucion.LRuta.Count; i++)
                //{
                //    txtResolucion.Text += Environment.NewLine + _Resolucion.LRuta[i].sRuta;
                //    //string nomArchivo   = Path.GetFileName(_Resolucion.LRuta[i].sRuta);
                //    //openFileDialogDocumento.FileName
                //    //link                = new LinkLabel();
                //    //link.Location       = new Point(20, 15 * i + 2);
                //    //link.AutoSize       = true;
                //    //link.Text           = nomArchivo;
                //    //link.Name           = _Resolucion.LRuta[i].sRuta;
                //    //link.Click          += Link_Click; ;
                //    //listArchivos.Controls.Add(link);
                //}
            }
        }





        //public FRResolucion(int iIdSolicitud, int iIdCaso)
        //{
        //    InitializeComponent();
        //    iSol    = iIdSolicitud;
        //    iCaso   = iIdCaso;

        //    label19.Visible = false;
        //    cmbResolucion.Visible = false;

        //    //Consume instancia para obtener información del usuario logueado
        //    //DatosUsuario ADatosUsuario  = DatosUsuario.Instancia;
        //    LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
        //    iIdUser                     = int.Parse(AUsuarioData.sIdusuario);

        //    //Consume instancia para obtener los detalles de la solicitud 
        //    DSDetalleServicio detalleSolicitudR = new DSDetalleServicio();
        //    detalle                             = detalleSolicitudR.InfoSolicitudR(iIdSolicitud);

        //    rutaArchivo         = null;
        //    rutaArchivo         = detalleSolicitudR.rutaArchivoDictamen(iIdSolicitud);
        //    rutaDocument(rutaArchivo);

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
        //        tabControl1.TabPages.Remove(tabPage5);
        //    }
        //    if (iIdSolicitudTipo == 4)
        //    {
        //        tabPage5.Text = "Expediente";

        //        label19.Visible = true;
        //        cmbResolucion.Visible = true;
        //        cargarResolucion();
        //    }
        //}

        public class Item
        {
            public string Name { get; set; }

            public Item(string name)
            {
                Name = name;
            }
            public override string ToString()
            {
                return Name;
            }
        }

        void cargarResolucion()
        {
            List<Item> lista = new List<Item>();

            lista.Add(new Item(" "));
            lista.Add(new Item("GANADO"));
            lista.Add(new Item("PERDIDO"));

            cmbResolucion.DataSource = lista;
            cmbResolucion.DisplayMember = "Name";
            cmbResolucion.ValueMember = "Name";
        }

        /*Función para generar linklabel del archivo cargado en el dictamen final*/
        public void rutaDocument(ISRutaDocumento rta)
        {
            try
            {
                if (rta != null)
                {
                    string nomArchivo   = Path.GetFileName(rta.sRutaArchivo);
                    link                = new LinkLabel();
                    //link.Location       = new Point(45, 235);
                    link.Location = new Point(146, 218);
                    link.AutoSize       = true;
                    link.Text           = nomArchivo;
                    link.Name           = rta.sRutaArchivo;
                    link.Click          += Link_Click; ;
                    gbDictamen.Controls.Add(link);
                }
            }
            catch (Exception ex)
            {
            }
        }

        /*Funcion click para lanzar la apertura del archivo seleccionado*/
        private void Link_Click(object sender, EventArgs e)
        {
            LinkLabel ruta = sender as LinkLabel;
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                System.Diagnostics.Process.Start(ruta.Name);
            //}
        }

        /*Función para vaciar la información en los controles visibles en diseño*/
        private void SolicitudDetalle(ISDetalleServicioR detSolicitud)
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
            lblCoordinador.Text     = detSolicitud.sCoordinador;
            iIdSolicitudTipo        = int.Parse(detSolicitud.sIdTipoSolicitud);
            lblTipoEvento.Text      = detSolicitud.sTipoEvento;
            lblTipificacion.Text = detSolicitud.sTipificacion;
            txtSolicitud.Text       = detSolicitud.sSolicitud;
            sUrlCitas               = detSolicitud.sUrlCitas;
            //UrlArchRespu            = detSolicitud.sUrlArchResp; /* Borrar este dato del procedimiento almacenado */

            if (detSolicitud.sDictamen != string.Empty)
            {
                gbDictamen.Visible  = true;
                lblGerente.Text     = detSolicitud.sGerente;
                txtDictamen.Text    = detSolicitud.sDictamen;
            }
            else
            {
                gbDictamen.Visible      = false;
                gbResolucion.Location   = new Point(827, 14);

                //btnCancelar.Location    = new Point(875, 288);
                //btnFinalizarR.Location  = new Point(1240, 288);

                btnCancelar.Location    = new Point(btnCancelar.Location.X, 288);
                btnFinalizarR.Location  = new Point(btnFinalizarR.Location.X, 288);


                txtDictamen.Text        = detSolicitud.sDictamen;
            }

        }

        /*Función para cargar los datagrid*/
        public void cargarDataGrid()
        {
            List<EEventos> EventosRegistrados   = new List<EEventos>();
            CInfoDetalles ARegistros            = new CInfoDetalles();

            EventosRegistrados = ARegistros.obtenerEventoS(iSol);

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
                                        "Detalles");
                    iContador++;
                }
            }

            List<ESolicitudesInformacion> SolicitudesRegistradss = new List<ESolicitudesInformacion>();
            CInfoDetalles ASolicitudesR = new CInfoDetalles();

            SolicitudesRegistradss = ASolicitudesR.obtenerSolicitudesI(iSol);

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
                                        "Detalles");
                    iContador++;
                }
            }

            List<EDocumento> DocumentosSolicitados  = new List<EDocumento>();
            CInfoDetalles ADocumentos               = new CInfoDetalles();

            DocumentosSolicitados = ADocumentos.obtenerDocumentosSolicitados(iSol);

            iContador = 0;
            if (DocumentosSolicitados.Any())
            {
                foreach (EDocumento vRow in DocumentosSolicitados)
                {
                    dgvDocumentos.Rows.Add(vRow.sIdIdSolicitudDocumento,
                                        vRow.sRequisicion,
                                        vRow.sTipoReq,
                                        vRow.sRecibido,
                                        "Detalles");
                    iContador++;
                }
            }

            List<EPropuestaRespuesta> RegistroPropuestas    = new List<EPropuestaRespuesta>();
            CInfoDetalles APropuestas                       = new CInfoDetalles();

            RegistroPropuestas = APropuestas.obtenerPropuestasRegistradas(iSol);

            iContador = 0;
            if (RegistroPropuestas.Any())
            {
                foreach (EPropuestaRespuesta vRow in RegistroPropuestas)
                {
                    dgvPropuestas.Rows.Add(vRow.sIdPropuestaRespuesta,
                                        vRow.sPropuesta,
                                        vRow.sArchivo,
                                        vRow.sAprobacion,
                                        vRow.sDescripcionRechazo,
                                        vRow.sCoordinador,
                                        "Detalles");
                    iContador++;
                }
            }
            documento();
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

        string resolucionServicio;
        /*Evento click boton Finalizar para cerrar el folio y cargar la resolución de la solicitud*/
        private void btnFinalizarR_Click(object sender, EventArgs e)
        {
            resolucionServicio = "N/A";
            if (txtResolucion.Text != string.Empty)
            {
                if (iIdSolicitudTipo > 3)
                {
                    Item sServicioResol = (Item)cmbResolucion.SelectedItem;
                    resolucionServicio = sServicioResol.Name.ToString();

                    if (cmbResolucion.Text != " " && cmbResolucion.Text != string.Empty)
                    {

                        DialogResult conf = MessageBox.Show("¿Estás seguro de cerrar el ticket y dar la resolución al cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (conf == DialogResult.Yes)
                        {
                            iBTicketCerrado = 1;
                            new Solicitud().Resolucion(iSol, txtResolucion.Text, resolucionServicio);

                            //if (txtRutaArchivo.Text != string.Empty)
                            //{
                            //    cargaArchivo();
                            //}
                            if (_Resolucion.LRuta.Any())
                                cargaArchivo();

                            DialogResult ac = MessageBox.Show("Se ha registrado correctamente la resolución de la solicitud", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (ac == DialogResult.OK)
                            {
                                Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Es necesario seleccionar la resolución de la representación", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    DialogResult conf = MessageBox.Show("¿Estás seguro de cerrar el ticket y dar la resolución al cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (conf == DialogResult.Yes)
                    {
                        iBTicketCerrado = 1;
                        new Solicitud().Resolucion(iSol, txtResolucion.Text, resolucionServicio);

                        //if (txtRutaArchivo.Text != string.Empty)
                        //{
                        //    cargaArchivo();
                        //}
                        if (_Resolucion.LRuta.Any())
                            cargaArchivo();

                        DialogResult ac = MessageBox.Show("Se ha registrado correctamente la resolución de la solicitud", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (ac == DialogResult.OK)
                        {
                            Close();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Es necesario registrar la resolución para el cliente", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /*Evento click boton consultar llamadas, muestra ventana modal si existen llamadas del folio*/
        private void btnLlamadas_Click(object sender, EventArgs e)
        {
            try
            {
                //FSeguimientoFolios llamadas = new FSeguimientoFolios(iCaso);
                //llamadas.ShowDialog();
                FSeguimientoFolios.Show(iCaso);
            }
            catch (Exception)
            {
                MessageBox.Show("No existen llamadas de este folio");
            }
        }

        /*Evento click del boton citas, al dar click en este boton direcciona a una ventana en la cual permite registrar y visualizar las citas agendadas con el cliente*/
        private void btnCitas_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(sUrlCitas);
            }
            catch
            {
            }
        }

        /*Evento click del boton adjuntar el cual abre control openFileDialog para permitir seleccionar el archivo que sera cargado*/
        //private void btnAdjuntarRespuesta_Click(object sender, EventArgs e)
        //{
        //    //ASIGNA NOMBRE Y FILTROS DEL CONTROL OPENFILEDIALOG
        //    openFileDialogDocumento.Title       = "Subir Archivos";
        //    //openFileDialogDocumento.Filter = "Pdf Files|*.pdf |JPG|*.jpg;*.jpeg |Excel Files|*.xls;*.xlsx;*.xlsm |txt files (*.txt)|*.txt|Zip Files|*.zip;*.rar";
        //    openFileDialogDocumento.FileName    = "";
        //    openFileDialogDocumento.ShowDialog();
        //    txtRutaArchivo.Text                 = openFileDialogDocumento.FileName;
        //}

        #region Eventos CellContentClick para lanzar modal segun el click en la columna detalles de los datagrid
                
        private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvEventos.Columns[e.ColumnIndex].Name.Equals("Detalles"))
                {
                    FRRDetallesEvento aFormulario = new FRRDetallesEvento(int.Parse(dgvEventos.SelectedCells[0].FormattedValue.ToString()));
                    aFormulario.ShowDialog();
                }
            }
            catch
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
            catch (Exception)
            {
            }
        }

        private void dgvDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvDocumentos.Columns[e.ColumnIndex].Name.Equals("DetallesDoc"))
                {
                    if (dgvDocumentos.SelectedCells[3].FormattedValue.ToString() == "SI")
                    {
                        FRRegistroDocumento aFormulario = new FRRegistroDocumento(int.Parse(dgvDocumentos.SelectedCells[0].FormattedValue.ToString()), 1);
                        aFormulario.ShowDialog();
                    }
                    else
                    {
                        FRRegistroDocumento aFormulario = new FRRegistroDocumento(int.Parse(dgvDocumentos.SelectedCells[0].FormattedValue.ToString()), 1);
                        aFormulario.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvPropuestas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvPropuestas.Columns[e.ColumnIndex].Name.Equals("DetallesPro"))
            {
                if (dgvPropuestas.SelectedCells[3].FormattedValue.ToString() == "APROBADA")
                {
                    FRRAprobarPropuesta aFormulario = new FRRAprobarPropuesta(int.Parse(dgvPropuestas.SelectedCells[0].FormattedValue.ToString()), 1, 1);
                    aFormulario.ShowDialog();
                }
                else
                {
                    FRRAprobarPropuesta aFormulario = new FRRAprobarPropuesta(int.Parse(dgvPropuestas.SelectedCells[0].FormattedValue.ToString()), 2, 1);
                    aFormulario.ShowDialog();
                }
            }
        }

        #endregion

        /*Función para remover acentos al nombre del archivo cargado*/
        static string RemoveDiacritics(string text)
        {
            var normalizedString    = text.Normalize(NormalizationForm.FormD);
            var stringBuilder       = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }
            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        /*Funcion para cargar archivo */
        public void cargaArchivo()
        {
            try
            {
                //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
                //{
                    if (!Directory.Exists(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol))
                    {
                        Directory.CreateDirectory(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol);
                    }

                    //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO
                    var fileCount = (from file in Directory.EnumerateFiles(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol) select file).Count();
                    int i = fileCount - 1;

                foreach (ClaseData.Clases.Archivo.ArchivoEntidades.ERArchivo Attachment in _Resolucion.LRuta)
                {
                    //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
                    i++;

                    File.Copy(Attachment.sRuta, rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol + "\\" + Path.GetFileName(Attachment.sRuta));

                    File.Move(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol + "\\" + Path.GetFileName(Attachment.sRuta), rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(Attachment.sRuta)));

                    EscribirLog("Se copió el archivo " + rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(Attachment.sRuta)));

                    string ruta = rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(Attachment.sRuta));

                    ////GUARDA UN REGISTRO DE LA RUTA DONDE SE GUARDO EL ARCHIVO
                    new Adjunto().RegistrarRutaAdjunto(iSol, int.Parse(detalle.sIdCaso), 6, iIdUser, ruta);
                }

                    //foreach (string fileName in openFileDialogDocumento.FileNames)
                    //{
                    //    //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
                    //    i++;

                    //    File.Copy(fileName, rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol + "\\" + Path.GetFileName(fileName));

                    //    File.Move(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol + "\\" + Path.GetFileName(fileName), rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));

                    //    EscribirLog("Se copió el archivo " + rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));

                    //    string ruta = rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName));

                    //    ////GUARDA UN REGISTRO DE LA RUTA DONDE SE GUARDO EL ARCHIVO
                    //       new Adjunto().RegistrarRutaAdjunto(iSol, int.Parse(detalle.sIdCaso), 6, iIdUser, ruta);
                    //}
                    //txtRutaArchivo.Text = string.Empty;
                    //openFileDialogDocumento.FileName = "";
                //}
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Método Público para escribir un log de los cambios de los archivos del expediente en linea
        /// </summary>
        /// <param name = "strMessage" > Mensaje que se guardara en el log.</param>
        public void EscribirLog(string strMessage)
        {
            //VALIDACIÓN SI EL ARCHIVO EXISTE
            if (!File.Exists(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + @"ResolucionRespuesta\Log.txt"))
            {
                var myFile = File.Create(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + @"ResolucionRespuesta\Log.txt");
                myFile.Close();
            }

            //RUTA DE ACCESO DEL ARCHIVO LOG
            string logFile = rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + @"ResolucionRespuesta\Log.txt";

            //APLICA FORMATO AL LOG Y ESCRIBE EL MENSAJE QUE SE PASA EN EL PARAMETRO STRMENSAJE.
            string line = DateTime.Now.ToString() + " | ";
            line += strMessage;
            FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter swFromFileStream = new StreamWriter(fs);
            swFromFileStream.WriteLine(line);
            swFromFileStream.Flush();
            swFromFileStream.Close();
        }

        /*Evento click de boton cancelar para cerrar formulario*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Close();
            if (iBTicketCerrado == 0)
            {
                DialogResult rs = MessageBox.Show("No se ha registrado la resolución del servicio" + Environment.NewLine + "¿Deseas salir sin realizar el registro de la resolución?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //e.Cancel = true;
                    Close();
                }
            }
        }

        #region Evento CellPainting de datagrid para colocar imagen en la columna detalles
        private void dgvEventos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvEventos.Columns[e.ColumnIndex].Name == "Detalles" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvEventos.Rows[e.RowIndex].Cells["Detalles"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.content_20px, e.CellBounds.Left + 20, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }

        private void dgvSolicitudInformacion_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvSolicitudInformacion.Columns[e.ColumnIndex].Name == "detallesSI" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvSolicitudInformacion.Rows[e.RowIndex].Cells["detallesSI"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.content_20px, e.CellBounds.Left + 20, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }

        private void dgvDocumentos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvDocumentos.Columns[e.ColumnIndex].Name == "DetallesDoc" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvDocumentos.Rows[e.RowIndex].Cells["DetallesDoc"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.content_20px, e.CellBounds.Left + 20, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }

        private void dgvPropuestas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvPropuestas.Columns[e.ColumnIndex].Name == "DetallesPro" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvPropuestas.Rows[e.RowIndex].Cells["DetallesPro"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.content_20px, e.CellBounds.Left + 20, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }

        #endregion

        /* Evento SelectedIndexChanged del tabControl1 para visualizar u ocultar datagrid dependiendo el seleccionado*/
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvEventos.Rows.Clear();
            dgvSolicitudInformacion.Rows.Clear();
            dgvDocumentos.Rows.Clear();
            dgvPropuestas.Rows.Clear();
            dgvEventos.Visible              = false;
            dgvSolicitudInformacion.Visible = false;
            dgvDocumentos.Visible           = false;
            dgvPropuestas.Visible           = false;

            if (tabControl1.SelectedTab.Name == "tabPage1")
            {
                cargarDataGrid();
                dgvEventos.Visible = true;
            }
            else if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                cargarDataGrid();
                dgvSolicitudInformacion.Visible = true;
            }
            else if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                cargarDataGrid();
                dgvDocumentos.Visible = true;
            }
            else if (tabControl1.SelectedTab.Name == "tabPage4")
            {
                cargarDataGrid();
                dgvPropuestas.Visible = true;
            }
            else if (tabControl1.SelectedTab.Name == "tabPage5")
            {
                lecturaCarpetas();
                //cargarFolders();
            }
        }

        #region Eventos CellMouseMove para cambiar el cursor cuando pase por la columna detalles de cada data grid
        private void dgvEventos_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEventos.Columns[e.ColumnIndex].Name.ToString() == "Detalles")
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
            if (dgvDocumentos.Columns[e.ColumnIndex].Name.ToString() == "DetallesDoc")
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
            if (dgvPropuestas.Columns[e.ColumnIndex].Name.ToString() == "DetallesPro")
            {
                dgvPropuestas.Cursor = Cursors.Hand;
            }
            else
            {
                dgvPropuestas.Cursor = Cursors.Default;
            }
        }
        
        #endregion

        /*Evento formClosing, solicita autorizacion para cerrar el formulario ya que no se ha descrito la resolución*/
        private void FRResolucion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (iBTicketCerrado == 0)
            //{
            //    DialogResult rs = MessageBox.Show("No se ha registrado la resolución del servicio" + Environment.NewLine + "¿Deseas salir sin realizar el registro de la resolución?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (rs == DialogResult.No)
            //    {
            //        e.Cancel = true;
            //    }
            //}
        }

        public MaterialSkin.MaterialSkinManager SkinManager { get { return MaterialSkin.MaterialSkinManager.Instance; } }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage CurrentTab = tabControl1.TabPages[e.Index];
            Rectangle ItemRect = tabControl1.GetTabRect(e.Index);
            //SolidBrush FillBrush = new SolidBrush(Color.FromArgb(0, 99, 177));
            //SolidBrush TextBrush = new SolidBrush(Color.White);
            SolidBrush FillBrush = new SolidBrush(Color.White);
            SolidBrush TextBrush = new SolidBrush(Color.Black);//33, 150, 243Color.FromArgb(7, 22, 127)
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            //If we are currently painting the Selected TabItem we'll
            //change the brush colors and inflate the rectangle.
            if (System.Convert.ToBoolean(e.State & DrawItemState.Selected))
            {
                FillBrush.Color = Color.FromArgb(7, 22, 127);//33, 150, 243
                TextBrush.Color = Color.White;
                ItemRect.Inflate(2, 2);
            }

            //Set up rotation for left and right aligned tabs
            if (tabControl1.Alignment == TabAlignment.Left || tabControl1.Alignment == TabAlignment.Right)
            {
                float RotateAngle = 90;
                if (tabControl1.Alignment == TabAlignment.Left)
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

        string rutaInicial;
        public void lecturaCarpetas()
        {
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                if (!Directory.Exists(rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente"))
                {
                    Directory.CreateDirectory(rutaAdjuntarArchivo.Path + lblNocliente1.Text + "\\" + "SolicitudesJuridicas" + "\\" + lblFolio.Text + "\\" + "Expediente");
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
                            MessageBox.Show("Se presentó un problema leyendo el directorio, error: " + ex.Message, "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                openFileDialogDocumento.Title = "Subir Archivos";
                //openFileDialogDocumentos.Filter = "Pdf Files|*.pdf |JPG|*.jpg;*.jpeg |Excel Files|*.xls;*.xlsx;*.xlsm |txt files (*.txt)|*.txt|Zip Files|*.zip;*.rar";
                openFileDialogDocumento.FileName = "";

                string sRuta = lblRuta.Text;

                if (openFileDialogDocumento.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string carpeta = string.Empty;
                        //RECORRE LOS ARCHIVOS SELCCIONADOS DEL CONTROL OPENFILEDIALOG Y LOS COPIA AL SERVIDOR
                        //Y SE GUARDA UN REGISTRO EN EL LOG
                        foreach (string fileName in openFileDialogDocumento.FileNames)
                        {
                            //trvCarpetas.BeginUpdate();
                            File.Copy(fileName, sRuta + @"\" + Path.GetFileName(fileName));
                            //trvCarpetas.EndUpdate();
                            EscribirLogExp("Se copió el archivo " + sRuta + @"\" + Path.GetFileName(fileName));

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

        /// Método Público para escribir un log de los cambios de los archivos del expediente en linea
        public void EscribirLogExp(string strMessage)
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
                        if (renomFolder != 0)
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
            btnLlamadas.Enabled = Status;
            //btnCitas.Enabled = Status;
            tabControl1.Enabled = Status;
            btnCancelar.Enabled = Status;
            gbResolucion.Enabled = Status;
            btnCancelar.Enabled = Status;
            btnFinalizarR.Enabled = Status;
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
                                EscribirLogExp("Se eliminó el archivo " + carpeta + "\\" + nombreArchivo);
                            }
                            else
                            {
                                Directory.Delete(carpeta + "\\" + nombreArchivo, true);

                                trvCarpetas.Nodes.Remove(node);
                                MessageBox.Show("Se eliminó la carpeta: " + nombreArchivo, "ACEPTAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                EscribirLogExp("Se eliminó carpeta " + carpeta);
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
            string Disco = string.Format(@"\\192.168.1.34\\Documentos\\{2}\\Documentos\\Clientes\\{0}\SolicitudesJuridicas\\{1}\Expediente\", lblNocliente1.Text, lblFolio.Text, LogicaCC.ConnectionString.FolderConnection);


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
                        EscribirLogExp(string.Format("Se movió el archivo {0} Antes: {1} Ahora: {2}", this.dragNode.Text, antiguo, string.Format(@"{0}\{1}", nuevo, this.dragNode.Text)));
                    }
                    else
                    {
                        // Es Directorio
                        Directory.Move(antiguo + @"\", string.Format(@"{0}\{1}", nuevo, this.dragNode.Text));
                        EscribirLogExp(string.Format(@"Se movió la carpeta {0} Antes: {1}\ Ahora: {2}", this.dragNode.Text, antiguo, string.Format(@"{0}\{1}", nuevo, this.dragNode.Text)));
                    }
                    trvCarpetas.Nodes.Remove(this.dragNode);
                }
                else
                {
                    if (this.dragNode.Text.Contains("."))
                    {
                        // Es archivo
                        File.Move(antiguo, string.Format(@"{0}\{1}", nuevo, this.dragNode.Text));
                        EscribirLogExp(string.Format("Se movió el archivo {0} Antes: {1} Ahora: {2}", this.dragNode.Text, antiguo, string.Format(@"{0}\{1}", nuevo, this.dragNode.Text)));
                    }
                    else
                    {
                        // Es Directorio
                        Directory.Move(antiguo + @"\", string.Format(@"{0}\{1}", nuevo, this.dragNode.Text));
                        EscribirLogExp(string.Format(@"Se movió la carpeta {0} Antes: {1}\ Ahora: {2}", this.dragNode.Text, antiguo, string.Format(@"{0}\{1}", nuevo, this.dragNode.Text)));
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
    }
}
