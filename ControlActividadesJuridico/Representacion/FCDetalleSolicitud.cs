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
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion
{
    public partial class FCDetalleSolicitud : Form
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
        public FCDetalleSolicitud() : this(false) { }

        public FCDetalleSolicitud(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
        }

        //public static Screen PrimaryScreen { get; }
        int     iSol;
        int     iCaso;
        int     iContador;
        string  sUrlCitas;
        //string UrlArchRespu;
        string  sArchivoRes;

        ISDetalleSolicitud  detalle;
        ISRutaArchivo       rutaArchivoResolucion;
        LinkLabel           linkAr;

        //NetworkCredential _NetworkCredential = new NetworkCredential(AccessFiles.sUsuario, AccessFiles.sContraseña);
        //string PathFolderShared = @"\\192.169.143.34\Data_Files";


        static FCDetalleSolicitud _DetalleSolicitud;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show(int iIdSolicitud, int iIdCaso)
        {
            _DetalleSolicitud = new FCDetalleSolicitud();
            Form frmSet = Application.OpenForms["FPrincipal"];
            FBandeja _FBandeja = Application.OpenForms["FBandeja"] as FBandeja;

            _DetalleSolicitud.FormClosed += new FormClosedEventHandler(_FBandeja.ActualizarSolPendientes_FormClosed);

            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _DetalleSolicitud.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _DetalleSolicitud.Location = new Point(x, y);

            _DetalleSolicitud.iSol = iIdSolicitud;
            _DetalleSolicitud.iCaso = iIdCaso;
            DDetallesSolicitud detalleSolicitud = new DDetallesSolicitud();
            _DetalleSolicitud.detalle = detalleSolicitud.IDetalleSolicitud(iIdSolicitud);

            _DetalleSolicitud.rutaArchivoResolucion = null;
            _DetalleSolicitud.rutaArchivoResolucion = detalleSolicitud.rutaArchivoResolucion(iIdSolicitud);
            _DetalleSolicitud.rutaArchivoRes(_DetalleSolicitud.rutaArchivoResolucion);

            _DetalleSolicitud.informacionSolicitud(_DetalleSolicitud.detalle);
            _DetalleSolicitud.cargarDataGrid();

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


        /*Funciones que se inicializan cuando el formulario es llamado*/
        //public FCDetalleSolicitud(int iIdSolicitud, int iIdCaso)
        //{
        //    InitializeComponent();
        //    iSol        = iIdSolicitud;
        //    iCaso       = iIdCaso;
        //    DDetallesSolicitud detalleSolicitud = new DDetallesSolicitud();
        //    detalle     = detalleSolicitud.IDetalleSolicitud(iIdSolicitud);

        //    rutaArchivoResolucion = null;
        //    rutaArchivoResolucion = detalleSolicitud.rutaArchivoResolucion(iIdSolicitud);
        //    rutaArchivoRes(rutaArchivoResolucion);

        //    informacionSolicitud(detalle);
        //    cargarDataGrid();
        //}

        /*Función para vaciar la información en los controles visibles del diseño*/
        public void informacionSolicitud(ISDetalleSolicitud solicitud)
        {
            lblNocliente1.Text      = solicitud.sNumCliente;
            lblNomCliente.Text      = solicitud.sNombreCliente;
            lblRFC.Text             = solicitud.sRFC;
            lblTelCelular.Text      = solicitud.sTelefonoMovil;
            lblTipoPersona.Text     = solicitud.sTipoPersona;
            lblServicio.Text        = solicitud.sTipoServicio;
            lblFolio.Text           = solicitud.sIdCaso;
            lblFechaRegistro.Text   = solicitud.sFechaRegistro;
            lblRegistro.Text        = solicitud.sRegistro;
            lblCoordinador.Text     = solicitud.sCoordinador;
            lblConsultor.Text       = solicitud.sConsultor;
            lblTipoEvento.Text      = solicitud.sTipoEvento;
            txtResolucion.Text      = solicitud.sResolucion;
            txtSolicitud.Text       = solicitud.sSolicitud;
            sUrlCitas               = solicitud.sUrlCitas;
            //UrlArchRespu            = solicitud.sUrlArchResp;
        }

        /*Función para generar LinkLabel del archivo adjunto en la resolucion de la solicitud*/
        public void rutaArchivoRes(ISRutaArchivo rut)
        {
            try
            {
                if (rut != null)
                {
                    sArchivoRes             = rut.sRutaArchivo.ToString();
                    string nomArchivoR      = Path.GetFileName(rut.sRutaArchivo.ToString());
                    linkAr                  = new LinkLabel();
                    linkAr.Location         = new Point(18, 122);
                    linkAr.AutoSize         = true;
                    linkAr.Text             = nomArchivoR;
                    linkAr.Name             = sArchivoRes;
                    linkAr.Click            += LinkAr_Click;
                    gbResolucion.Controls.Add(linkAr);
                }
            }
            catch (Exception)
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
                MessageBox.Show("No existen llamadas de este folio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        /*Evento CellPainting de datagrid para colocar imagen en la columna Detalles*/
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

        /*Evento CellMouseMove para cambiar el cursor cuando pase por la columna Detalles del data grid*/
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

        /*Evento click de boton cancelar para cerrar formulario*/
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
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
