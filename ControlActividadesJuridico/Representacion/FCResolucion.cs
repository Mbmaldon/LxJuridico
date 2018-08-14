using ClaseData.Clases;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion
{
    public partial class FCResolucion : Form
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
        public FCResolucion() : this(false) { }

        public FCResolucion(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
        }

        static FCResolucion _Resolucion;
        static DialogResult _DialogResult = DialogResult.No;


        public static DialogResult Show(int iIdSolicitud, int iIdCaso)
        {
            _Resolucion = new FCResolucion();
            Form frmSet = Application.OpenForms["FPrincipal"];
            FBandeja _FBandeja = Application.OpenForms["FBandeja"] as FBandeja;

            _Resolucion.FormClosed += new FormClosedEventHandler(_FBandeja.ActualizarSolPendientes_FormClosed);

            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _Resolucion.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _Resolucion.Location = new Point(x, y);


            _Resolucion.iSol = iIdSolicitud;
            _Resolucion.iCaso = iIdCaso;

            LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
            //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
            _Resolucion.iIdUser = int.Parse(AUsuarioData.sIdusuario);

            DSDetalleServicio detalleSolicitudR = new DSDetalleServicio();
            _Resolucion.detalle = detalleSolicitudR.InfoSolicitudR(iIdSolicitud);

            _Resolucion.SolicitudDetalle(_Resolucion.detalle);
            _Resolucion.cargarDataGrid();

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






        int iSol;
        int iCaso;
        int iIdUser;
        int iContador;
        int iBTicketCerrado = 0;
        string UrlCitas;

        //string UrlArchRespu;
        //string linkArchivo;
        ISDetalleServicioR detalle;

        /*Funciones que se inicializan cuando el formulario es llamado*/
        //public FCResolucion(int iIdSolicitud, int iIdCaso)
        //{
        //    InitializeComponent();
        //    iSol = iIdSolicitud;
        //    iCaso = iIdCaso;

        //    LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
        //    //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
        //    iIdUser = int.Parse(AUsuarioData.sIdusuario);

        //    DSDetalleServicio detalleSolicitudR = new DSDetalleServicio();
        //    detalle = detalleSolicitudR.InfoSolicitudR(iIdSolicitud);

        //    SolicitudDetalle(detalle);
        //    cargarDataGrid();
        //}

        /*Función para vaciar la información en los controles visibles del diseño*/
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
            lblTipoEvento.Text      = detSolicitud.sTipoEvento;
            txtSolicitud.Text       = detSolicitud.sSolicitud;
            UrlCitas                = detSolicitud.sUrlCitas;
            //UrlArchRespu            = detSolicitud.sUrlArchResp; /* Borrar este dato del procedimiento almacenado */
        }

        /*Funciónes para cargar los datagrid*/
        public void cargarDataGrid()
        {
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
        }

        /*Evento CellPainting de datagrid para colocar imagen en la columna Aprobar*/
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

        /*Evento CellMouseMove para cambiar el cursor cuando pase por la columna Aprobar del data grid*/
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
                System.Diagnostics.Process.Start(UrlCitas);
            }
            catch
            {
            }
        }

        /*Evento CellContentClick para lanzar modal segun el click en la columna Detalles del datagrid*/
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

        /*Evento click del boton adjuntar el cual abre control openFileDialog para permitir seleccionar el archivo que sera cargado*/
        private void btnAdjuntarRespuesta_Click(object sender, EventArgs e)
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
                if (!Directory.Exists(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol))
                {
                    Directory.CreateDirectory(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol);
                }

                //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO
                var fileCount = (from file in Directory.EnumerateFiles(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol) select file).Count();
                int i = fileCount - 1;

                foreach (string fileName in openFileDialogDocumento.FileNames)
                {
                    //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
                    i++;
                    File.Copy(fileName, rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol + "\\" + Path.GetFileName(fileName));

                    File.Move(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol + "\\" + Path.GetFileName(fileName),
                              rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));

                    EscribirLog("Se copió el archivo " + rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));

                    string ruta = rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + detalle.sIdCaso + "\\" + "ResolucionRespuesta" + "\\" + iSol + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName));

                    ////GUARDA UN REGISTRO DE LA RUTA DONDE SE GUARDO EL ARCHIVO
                    new Adjunto().RegistrarRutaAdjunto(iSol, int.Parse(detalle.sIdCaso), 6, iIdUser, ruta);
                }
                txtRutaArchivo.Text = string.Empty;
                openFileDialogDocumento.FileName = "";
            }
            catch (Exception )
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
            if (!File.Exists(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + detalle.sIdCaso + "\\" + @"ResolucionRespuesta\Log.txt"))
            {
                var myFile = File.Create(rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + detalle.sIdCaso + "\\" + @"ResolucionRespuesta\Log.txt");
                myFile.Close();
            }

            //RUTA DE ACCESO DEL ARCHIVO LOG
            string logFile = rutaAdjuntarArchivo.Path + detalle.sNumCliente + "\\" + detalle.sIdCaso + "\\" + @"ResolucionRespuesta\Log.txt";

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
            Close();
        }

        /*Evento formClosing, solicita autorizacion para cerrar el formulario ya que no se ha descrito la resolución*/
        private void FCResolucion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (iBTicketCerrado == 0)
            {
                DialogResult rs = MessageBox.Show("No se ha registrado la resolución del servicio" + Environment.NewLine + "¿Deseas salir sin realizar el registro de la resolución?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        /*Evento click boton Finalizar para cerrar el folio y cargar la resolución de la solicitud*/
        private void btnFinalizarR_Click(object sender, EventArgs e)
        {
            if (txtResolucion.Text != string.Empty)
            {
                DialogResult conf = MessageBox.Show("¿Estás seguro de cerrar el ticket y dar la resolución al cliente?.", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (conf == DialogResult.Yes)
                {
                    iBTicketCerrado = 1;
                    new Solicitud().ResolucionContador(iSol, txtResolucion.Text);

                    if (txtRutaArchivo.Text != string.Empty)
                    {
                        cargaArchivo();
                    }

                    DialogResult ac = MessageBox.Show("Se ha registrado correctamente la resolución de la solicitud.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ac == DialogResult.OK)
                    {
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Es necesario registrar la resolución para el cliente", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

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
