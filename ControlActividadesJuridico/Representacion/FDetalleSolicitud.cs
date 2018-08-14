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
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion
{
    public partial class FDetalleSolicitud : Form
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
        public FDetalleSolicitud() : this(false) { }

        public FDetalleSolicitud(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
        }

        int iSol;
        int iCaso;
        int iContador;
        int iIdSolicitudTipo;

        string sUrlCitas;
        //string UrlArchRespu;
        string linkArchivo;
        string ArchivoRes;

        ISDetalleSolicitud detalle;
        ISRutaDocumento rutaArchivo;
        ISRutaArchivo rutaArchivoResolucion;
        LinkLabel link;
        LinkLabel linkAr;

        //NetworkCredential _NetworkCredential = new NetworkCredential(AccessFiles.sUsuario, AccessFiles.sContraseña);
        //string PathFolderShared = @"\\192.169.143.34\Data_Files";
        private int nIndex = 0;

        string sNodeSeleccionado = null;
        string sFolderSeleccionado = null;
        string sFolderFullPath = null;

        static FDetalleSolicitud _DetalleSolicitud;
        static DialogResult _DialogResult = DialogResult.No;


        public static DialogResult Show(int iIdSolicitud, int iIdCaso)
        {
            _DetalleSolicitud = new FDetalleSolicitud();
            Form frmSet = Application.OpenForms["FPrincipal"];
            FBandeja _FBandeja = Application.OpenForms["FBandeja"] as FBandeja;

            _DetalleSolicitud.FormClosed += new FormClosedEventHandler(_FBandeja.ActualizarSolPendientes_FormClosed);


            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _DetalleSolicitud.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _DetalleSolicitud.Location = new Point(x, y);

            //_NuevaSolicitud.label1.Text = string.Format("Hola {0},", sNombre);
            //_NuevaSolicitud.InitializeControls();

            _DetalleSolicitud.iSol = iIdSolicitud;
            _DetalleSolicitud.iCaso = iIdCaso;

            DDetallesSolicitud detalleSolicitud = new DDetallesSolicitud();
            _DetalleSolicitud.detalle = detalleSolicitud.IDetalleSolicitud(iIdSolicitud);

            _DetalleSolicitud.rutaArchivo = null;
            DSDetalleServicio detalleSolicitudR = new DSDetalleServicio();
            _DetalleSolicitud.rutaArchivo = detalleSolicitudR.rutaArchivoDictamen(iIdSolicitud);
            _DetalleSolicitud.rutaDocument(_DetalleSolicitud.rutaArchivo);

            _DetalleSolicitud.rutaArchivoResolucion = null;
            _DetalleSolicitud.rutaArchivoResolucion = detalleSolicitud.rutaArchivoResolucion(iIdSolicitud);
            _DetalleSolicitud.rutaArchivoRes(_DetalleSolicitud.rutaArchivoResolucion);

            _DetalleSolicitud.informacionSolicitud(_DetalleSolicitud.detalle);
            _DetalleSolicitud.cargarDataGrid();

            if (_DetalleSolicitud.iIdSolicitudTipo == 2)
            {
                _DetalleSolicitud.tabPage5.Text = "Bitacora";
            }
            if (_DetalleSolicitud.iIdSolicitudTipo == 3)
            {
                _DetalleSolicitud.tabControl1.TabPages.Remove(_DetalleSolicitud.tabPage5);
            }
            if (_DetalleSolicitud.iIdSolicitudTipo == 4)
            {
                _DetalleSolicitud.tabPage5.Text = "Expediente";
            }





            _DialogResult = DialogResult.No;

            _DetalleSolicitud.Activate();
            _DetalleSolicitud.ShowDialog();

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

        ///*Funciones que se inicializan cuando el formulario es llamado*/
        //public FDetalleSolicitud(int iIdSolicitud, int iIdCaso)
        //{
        //    InitializeComponent();
        //    iSol    = iIdSolicitud;
        //    iCaso   = iIdCaso;

        //    DDetallesSolicitud detalleSolicitud = new DDetallesSolicitud();
        //    detalle = detalleSolicitud.IDetalleSolicitud(iIdSolicitud);

        //    rutaArchivo = null;
        //    DSDetalleServicio detalleSolicitudR = new DSDetalleServicio();
        //    rutaArchivo = detalleSolicitudR.rutaArchivoDictamen(iIdSolicitud);
        //    rutaDocument(rutaArchivo);

        //    rutaArchivoResolucion   = null;
        //    rutaArchivoResolucion   = detalleSolicitud.rutaArchivoResolucion(iIdSolicitud);
        //    rutaArchivoRes(rutaArchivoResolucion);

        //    informacionSolicitud(detalle);
        //    cargarDataGrid();

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
        //    }
        //}

        /*Función para vaciar la información en los controles visibles del diseño*/
        public void informacionSolicitud(ISDetalleSolicitud solicitud)
        {
            lblNocliente1.Text = solicitud.sNumCliente;
            lblNomCliente.Text = solicitud.sNombreCliente;
            lblRFC.Text = solicitud.sRFC;
            lblTelCelular.Text = solicitud.sTelefonoMovil;
            lblTipoPersona.Text = solicitud.sTipoPersona;
            lblServicio.Text = solicitud.sTipoServicio;
            lblFolio.Text = solicitud.sIdCaso;
            lblFechaRegistro.Text = solicitud.sFechaRegistro;
            lblRegistro.Text = solicitud.sRegistro;
            lblCoordinador.Text = solicitud.sCoordinador;
            iIdSolicitudTipo = int.Parse(solicitud.sIdTipoSolicitud);
            lblConsultor.Text = solicitud.sConsultor;
            lblTipoEvento.Text = solicitud.sTipoEvento;
            lblTipificacion.Text = solicitud.sTipificacion;
            txtResolucion.Text = solicitud.sResolucion;
            txtSolicitud.Text = solicitud.sSolicitud;

            sUrlCitas = solicitud.sUrlCitas;
            //UrlArchRespu            = solicitud.sUrlArchResp;

            if (solicitud.sDictamen != string.Empty)
            {
                gbDictamen.Visible = true;
                lblGerente.Text = solicitud.sGerente;
                txtDictamen.Text = solicitud.sDictamen;
            }
            else
            {
                gbDictamen.Visible = false;
                gbResolucion.Size = new Size(394, 260);//491, 302//394, 302
                gbResolucion.Location = new Point(827, 14);

                //btnFinalizarR.Location = new Point(1218, 250);
                txtDictamen.Text = solicitud.sDictamen;
            }

            if (solicitud.sResolucionServicio != "N/A")
            {
                label18.Visible = true;
                lblResolucion.Visible = true;

                lblResolucion.Text = solicitud.sResolucionServicio;
            }
        }

        /*Función para generar LinkLabel del archivo adjunto en el dictamen final de la solicitud*/
        public void rutaDocument(ISRutaDocumento rta)
        {
            try
            {
                if (rta != null)
                {
                    linkArchivo = rta.sRutaArchivo.ToString();
                    string nomArchivo = Path.GetFileName(rta.sRutaArchivo.ToString());
                    link = new LinkLabel();
                    link.Location = new Point(45, 235);
                    link.AutoSize = true;
                    link.Text = nomArchivo;
                    link.Name = linkArchivo;
                    link.Click += Link_Click;
                    gbDictamen.Controls.Add(link);
                }
            }
            catch (Exception ex)
            {
            }
        }

        /*Función para generar LinkLabel del archivo adjunto en la resolucion de la solicitud*/
        public void rutaArchivoRes(ISRutaArchivo rut)
        {
            try
            {
                if (rut != null)
                {
                    ArchivoRes = rut.sRutaArchivo.ToString();
                    string nomArchivoR = Path.GetFileName(rut.sRutaArchivo.ToString());
                    linkAr = new LinkLabel();
                    linkAr.Location = new Point(45, 225);
                    linkAr.AutoSize = true;
                    linkAr.Text = nomArchivoR;
                    linkAr.Name = ArchivoRes;
                    linkAr.Click += LinkAr_Click;
                    gbResolucion.Controls.Add(linkAr);
                }
            }
            catch (Exception ex)
            {
            }
        }

        /*Función click al seleccionar el archivo adjunto en la resolución de la solicitud*/
        private void LinkAr_Click(object sender, EventArgs e)
        {
            LinkLabel ruta = sender as LinkLabel;
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
            System.Diagnostics.Process.Start(ruta.Name);
            //}
        }

        /*Función click al seleccionar el archivo adjunto en dictamen final de la solicitud*/
        private void Link_Click(object sender, EventArgs e)
        {
            LinkLabel ruta = sender as LinkLabel;
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
            System.Diagnostics.Process.Start(ruta.Name);
            //}
        }

        /*Funciónes para cargar los datagrid*/
        public void cargarDataGrid()
        {
            List<EEventos> EventosRegistrados = new List<EEventos>();
            CInfoDetalles ARegistros = new CInfoDetalles();

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

            List<EDocumento> DocumentosSolicitados = new List<EDocumento>();
            CInfoDetalles ADocumentos = new CInfoDetalles();

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

            List<EPropuestaRespuesta> RegistroPropuestas = new List<EPropuestaRespuesta>();
            CInfoDetalles APropuestas = new CInfoDetalles();

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

        /* Evento SelectedIndexChanged del tcDetalles para visualizar u ocultar datagrid dependiendo el seleccionado*/
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvEventos.Rows.Clear();
            dgvSolicitudInformacion.Rows.Clear();
            dgvDocumentos.Rows.Clear();
            dgvPropuestas.Rows.Clear();
            dgvEventos.Visible = false;
            dgvSolicitudInformacion.Visible = false;
            dgvDocumentos.Visible = false;
            dgvPropuestas.Visible = false;

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

        /*Evento click de boton Cancelar y cerrar el formulario */
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            _DialogResult = DialogResult.No;
            _DetalleSolicitud.Close();
            //Close();
        }

        public MaterialSkin.MaterialSkinManager SkinManager { get { return MaterialSkin.MaterialSkinManager.Instance; } }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage CurrentTab = tabControl1.TabPages[e.Index];
            Rectangle ItemRect = tabControl1.GetTabRect(e.Index);
            //SolidBrush FillBrush = new SolidBrush(Color.FromArgb(0, 99, 177));
            //SolidBrush TextBrush = new SolidBrush(Color.White);
            SolidBrush FillBrush = new SolidBrush(Color.White);
            SolidBrush TextBrush = new SolidBrush(Color.Black);//0, 99, 177
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            //If we are currently painting the Selected TabItem we'll
            //change the brush colors and inflate the rectangle.
            if (System.Convert.ToBoolean(e.State & DrawItemState.Selected))
            {
                FillBrush.Color = Color.FromArgb(7, 22, 127);//0, 99, 177
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

            //Next we'll paint the TabItem with our Fill Brush
            e.Graphics.FillRectangle(FillBrush, ItemRect);

            Font _tabFont = SkinManager.ROBOTO_REGULAR_7;

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
    }
}
