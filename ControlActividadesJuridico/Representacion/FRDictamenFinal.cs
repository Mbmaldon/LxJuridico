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
    public partial class FRDictamenFinal : Form
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
        public FRDictamenFinal() : this(false) { }

        public FRDictamenFinal(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
        }


        int     iIdSol;
        int     iCaso;
        int     iUsuario;
        int     iContador;
        int     iBanderaDictamen = 0;
        string  sUrlCitas;

        ISDetalleServicio detalle;

        //NetworkCredential _NetworkCredential = new NetworkCredential(AccessFiles.sUsuario, AccessFiles.sContraseña);
        //string PathFolderShared = @"\\192.169.143.34\Data_Files";


        static FRDictamenFinal _Dictamen;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show(int iIdSolicitud, int iIdCaso)
        {
            _Dictamen = new FRDictamenFinal();
            Form frmSet = Application.OpenForms["FPrincipal"];
            FBandeja _FBandeja = Application.OpenForms["FBandeja"] as FBandeja;

            _Dictamen.FormClosed += new FormClosedEventHandler(_FBandeja.ActualizarSolPendientes_FormClosed);

            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _Dictamen.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _Dictamen.Location = new Point(x, y);


            _Dictamen.iIdSol = iIdSolicitud;
            _Dictamen.iCaso = iIdCaso;

            //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
            LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
            _Dictamen.iUsuario = int.Parse(AUsuarioData.sIdusuario);

            DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
            _Dictamen.detalle = detalleSolicitud.InfoSolicitud(iIdSolicitud);
            _Dictamen.SolicitudDetalle(_Dictamen.detalle);
            _Dictamen.cargarDataGrid();

            _DialogResult = DialogResult.No;

            _Dictamen.Activate();
            _Dictamen.ShowDialog();

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


        /*Funciones que se inicializan cuando el formulario es llamado*/
        //public FRDictamenFinal(int iIdSolicitud, int iIdCaso)
        //{
        //    InitializeComponent();
        //    iIdSol      = iIdSolicitud;
        //    iCaso       = iIdCaso;

        //    //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
        //    LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
        //    iUsuario    = int.Parse(AUsuarioData.sIdusuario);

        //    DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
        //    detalle = detalleSolicitud.InfoSolicitud(iIdSolicitud);
        //    SolicitudDetalle(detalle);
        //    cargarDataGrid();
        //}

        /*Función para vaciar la información en los controles visibles en diseño*/
        private void SolicitudDetalle(ISDetalleServicio detSolicitud)
        {
            lblNocliente1.Text          = detSolicitud.sNumCliente;
            lblNomCliente.Text          = detSolicitud.sNombreCliente;
            lblRFC.Text                 = detSolicitud.sRFC;
            lblTelCelular.Text          = detSolicitud.sTelefonoMovil;
            lblTipoPersona.Text         = detSolicitud.sTipoPersona;
            lblServicio.Text            = detSolicitud.sTipoServicio;
            lblFolio.Text               = detSolicitud.sIdCaso;
            lblFechaRegistro.Text       = detSolicitud.sFechaRegistro;
            lblRegistro.Text            = detSolicitud.sRegistro;
            lblCoordinador.Text         = detSolicitud.sCoordinador;
            lblConsultor.Text           = detSolicitud.sConsultor;
            lblTipoEvento.Text          = detSolicitud.sTipoEvento;
            txtSolicitud.Text           = detSolicitud.sSolicitud;
            sUrlCitas                   = detSolicitud.sUrlCitas;
        }

        /*Función para cargar los datagrid*/
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
                                        "Detalles");
                    iContador++;
                }

            }


            List<ESolicitudesInformacion> SolicitudesRegistradss    = new List<ESolicitudesInformacion>();
            CInfoDetalles ASolicitudesR                             = new CInfoDetalles();

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
                                        "Detalles");
                    iContador++;
                }
            }

            List<EPropuestaRespuesta> RegistroPropuestas    = new List<EPropuestaRespuesta>();
            CInfoDetalles APropuestas                       = new CInfoDetalles();

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

        /*Evento click del boton Enviar tramite el cual actualiza la información de la solicitud ya con el dictamen final dado por el gerente*/
        private void btnEnviarTramite_Click(object sender, EventArgs e)
        {
            if(txtDictamenF.Text !=  string.Empty)
            {
                DialogResult ed = MessageBox.Show("¿Esta seguro de enviar el dictamen final de la solicitud?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ed == DialogResult.Yes)
                {
                    iBanderaDictamen = 1;

                    new Solicitud().DictamenFinal(iIdSol, iUsuario, txtDictamenF.Text);
                    if (txtRutaArchivo.Text != string.Empty)
                    {
                        cargaArchivo();
                    }
                    DialogResult rs = MessageBox.Show("Se ha registrado correctamente el dictamen y se ha enviado al consultor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (rs == DialogResult.OK)
                    {
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Es necesario registrar el Dictamen Final para dar respuesta al cliente", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                MessageBox.Show("No existen llamadas de este folio", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*Evento click del boton citas, al dar click en este boton direcciona a una ventana en la cual permite registrar y visualizar las citas agendadas con el cliente*/
        private void btnCitas_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(sUrlCitas);
            }
            catch (Exception ex)
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
                if (dgvPropuestas.SelectedCells[2].FormattedValue.ToString() == "APROBADA")
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

        /*Evento click del boton adjuntar el cual abre control openFileDialog para permitir seleccionar el archivo que sera cargado*/
        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            //ASIGNA NOMBRE Y FILTROS DEL CONTROL OPENFILEDIALOG
            openFileDialogDocumento.Title       = "Subir Archivos";
            //openFileDialogDocumento.Filter = "Pdf Files|*.pdf |JPG|*.jpg;*.jpeg |Excel Files|*.xls;*.xlsx;*.xlsm |txt files (*.txt)|*.txt|Zip Files|*.zip;*.rar";
            openFileDialogDocumento.FileName    = "";
            openFileDialogDocumento.ShowDialog();
            txtRutaArchivo.Text                 = openFileDialogDocumento.FileName;
        }

        /*Funcion para cargar archivo */
        public void cargaArchivo()
        {
            try
            {
                //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
                //{
                    if (!Directory.Exists(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "DictamenFinal" + "\\" + iIdSol))
                    {
                        Directory.CreateDirectory(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "DictamenFinal" + "\\" + iIdSol);
                    }

                    //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO
                    var fileCount = (from file in Directory.EnumerateFiles(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "DictamenFinal" + "\\" + iIdSol) select file).Count();
                    int i = fileCount - 1;


                    foreach (string fileName in openFileDialogDocumento.FileNames)
                    {
                        //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
                        i++;
                        File.Copy(fileName, rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "DictamenFinal" + "\\" + iIdSol + "\\" + Path.GetFileName(fileName));

                        File.Move(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "DictamenFinal" + "\\" + iIdSol + "\\" + Path.GetFileName(fileName),
                                  rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "DictamenFinal" + "\\" + iIdSol + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));


                        EscribirLog("Se copió el archivo " + rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "DictamenFinal" + "\\" + iIdSol + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));


                        string ruta = rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + "DictamenFinal" + "\\" + iIdSol + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName));

                        ////GUARDA UN REGISTRO DE LA RUTA DONDE SE GUARDO EL ARCHIVO
                        new Adjunto().RegistrarRutaAdjunto(iIdSol, int.Parse(detalle.sIdCaso), 5, iUsuario, ruta);
                    }
                    txtRutaArchivo.Text = string.Empty;
                    openFileDialogDocumento.FileName = "";
                //}
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Método Público para escribir un log de los cambios de los archivos del expediente en linea
        /// </summary>
        /// <param name="strMessage">Mensaje que se guardara en el log.</param>
        public void EscribirLog(string strMessage)
        {
            //VALIDACIÓN SI EL ARCHIVO EXISTE
            if (!File.Exists(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + @"DictamenFinal\Log.txt"))
            {
                var myFile = File.Create(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + @"DictamenFinal\Log.txt");
                myFile.Close();
            }

            //RUTA DE ACCESO DEL ARCHIVO LOG
            string logFile = rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + "SolicitudesJuridicas" + "\\" + detalle.sIdCaso + "\\" + @"DictamenFinal\Log.txt";

            //APLICA FORMATO AL LOG Y ESCRIBE EL MENSAJE QUE SE PASA EN EL PARAMETRO STRMENSAJE.
            string line = DateTime.Now.ToString() + " | ";
            line += strMessage;
            FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter swFromFileStream = new StreamWriter(fs);
            swFromFileStream.WriteLine(line);
            swFromFileStream.Flush();
            swFromFileStream.Close();
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

        /*Evento click boton cerrar, cierra formulario*/
        private void button1_Click(object sender, EventArgs e)
        {
            //Close();
            if (iBanderaDictamen == 0)
            {
                DialogResult rs = MessageBox.Show("No se ha enviado la resolución del servicio" + Environment.NewLine + "¿Desea salir sin realizar dicha acción?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //e.Cancel = true;
                    _DialogResult = DialogResult.No;
                    _Dictamen.Close();
                }
            }
        }

        /*Evento formClosing, informa al usuario que no se ha registrado la resolución de la solicitud y solicita autorización para cerrar sin realizar dicha acción*/
        private void FRDictamenFinal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (iBanderaDictamen == 0)
            //{
            //    DialogResult rs = MessageBox.Show("No se ha enviado la resolución del servicio" + Environment.NewLine + "¿Desea salir sin realizar dicha acción?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            SolidBrush TextBrush = new SolidBrush(Color.FromArgb(33, 150, 243));
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            //If we are currently painting the Selected TabItem we'll
            //change the brush colors and inflate the rectangle.
            if (System.Convert.ToBoolean(e.State & DrawItemState.Selected))
            {
                FillBrush.Color = Color.FromArgb(33, 150, 243);
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
    }
}
