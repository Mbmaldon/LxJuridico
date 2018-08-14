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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion
{
    public partial class FRCGenerarRespuesta : Form
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
        public FRCGenerarRespuesta() : this(false) { }

        public FRCGenerarRespuesta(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
        }

        static FRCGenerarRespuesta _Generar;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show(int iIdSolicitud, int iIdCaso)
        {
            _Generar = new FRCGenerarRespuesta();
            Form frmSet = Application.OpenForms["FPrincipal"];
            FBandeja _FBandeja = Application.OpenForms["FBandeja"] as FBandeja;

            _Generar.FormClosed += new FormClosedEventHandler(_FBandeja.ActualizarSolPendientes_FormClosed);

            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _Generar.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _Generar.Location = new Point(x, y);

            _Generar.iIdSol = iIdSolicitud;
            _Generar.iCaso = iIdCaso;
            //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
            LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
            _Generar.iIdUser = int.Parse(AUsuarioData.sIdusuario);
            if (AUsuarioData.sTipoUsuario == "20082")
                _Generar.iIdMateria = 2;
            else if (AUsuarioData.sTipoUsuario == "20083")
                _Generar.iIdMateria = 3;
            else
                _Generar.iIdMateria = 1;

            //iIdMateria  = int.Parse(ADatosUsuario.sIdMateria);

            _Generar.detalle = null;
            DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
            _Generar.detalle = detalleSolicitud.InfoSolicitud(iIdSolicitud);
            _Generar.SolicitudDetalle(_Generar.detalle);

            _Generar.cargarDataGrid();


            _DialogResult = DialogResult.No;

            _Generar.Activate();
            _Generar.ShowDialog();

            return _DialogResult;
        }




        int     iIdSol;
        int     iCaso;
        int     iIdUser;
        int     iIdMateria;
        int     idContadorAsignado;
        int     iBanderaProp = 0;

        string  sNumero;
        string  sUrlCitas;
        string  sCorreoCliente;
        string  sConsul;
        string  stipEvento;
       
        ISDetalleServicio detalle;

        /*Funciones que se inicializan cuando el formulario es llamado*/
        //public FRCGenerarRespuesta(int iIdSolicitud, int iIdCaso)
        //{
        //    InitializeComponent();
        //    iIdSol      = iIdSolicitud;
        //    iCaso       = iIdCaso;
        //    //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
        //    LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
        //    iIdUser     = int.Parse(AUsuarioData.sIdusuario);
        //    if (AUsuarioData.sTipoUsuario == "20082")
        //        iIdMateria = 2;
        //    else if (AUsuarioData.sTipoUsuario == "20083")
        //        iIdMateria = 3;
        //    else
        //        iIdMateria = 1;

        //    //iIdMateria  = int.Parse(ADatosUsuario.sIdMateria);

        //    detalle     = null;
        //    DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
        //    detalle     = detalleSolicitud.InfoSolicitud(iIdSolicitud);
        //    SolicitudDetalle(detalle);

        //    cargarDataGrid();

        //}

        /*Función para vaciar la información en los controles visibles del diseño*/
        private void SolicitudDetalle(ISDetalleServicio detSolicitud)
        {
            lblNocliente1.Text      = detSolicitud.sNumCliente;
            lblNomCliente.Text      = detSolicitud.sNombreCliente;
            lblRFC.Text             = detSolicitud.sRFC;
            lblTelCelular.Text      = detSolicitud.sTelefonoMovil;
            sNumero                 = detSolicitud.sTelefonoMovil; //detSolicitud.sTelefonoMovil;"2225771837"
            lblTipoPersona.Text     = detSolicitud.sTipoPersona;
            lblServicio.Text        = detSolicitud.sTipoServicio;
            lblFolio.Text           = detSolicitud.sIdCaso;
            lblFechaRegistro.Text   = detSolicitud.sFechaRegistro;
            lblRegistro.Text        = detSolicitud.sRegistro;
            lblCoordinador.Text     = detSolicitud.sCoordinador;
            lblTipoEvento.Text      = detSolicitud.sTipoEvento;
            txtSolicitud.Text       = detSolicitud.sSolicitud;
            sUrlCitas               = detSolicitud.sUrlCitas;
            sCorreoCliente          = detSolicitud.sCorreo;
            sConsul                 = detSolicitud.sConsultor;
            stipEvento              = detSolicitud.sTipoEvento;
            idContadorAsignado      = int.Parse(detSolicitud.sidMPYCC);
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
                MessageBox.Show("No existen llamadas de este folio", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* Evento click boton Registrarpara registrar nueva cita en el portal*/
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
            dgvPropuestas.Rows.Clear();
            dgvPropuestas.Visible = false;

            if (tcDetalles.SelectedTab.Name == "tabPage1")
            {
                dgvPropuestas.Visible = true;
                cargarDataGrid();
            }
        }

        /*Función para realizar la carga de información en el datagrid*/
        public void cargarDataGrid()
        {
            List<EPropuestaRespuesta> RegistroPropuestas = new List<EPropuestaRespuesta>();
            CInfoDetalles APropuestas = new CInfoDetalles();

            RegistroPropuestas = APropuestas.obtenerPropuestasRegistradas(iIdSol);

            int iContador = 0;
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
            seleccion();
        }

        /*Función para limpiar la seleccion de los registros cargados en el datagrid*/
        public void seleccion()
        {
            dgvPropuestas.ClearSelection();
        }

        /*Evento click del boton registrar y dar de alta una propuesta de respuesta de la solicitud*/
        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            //int iContador = dgvPropuestas.Rows.Count;

            bool bPendiente;
            //if (iContador < 3)
            //{
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
                    MessageBox.Show("Existe una propuesta sin enviar para su aprobación" + Environment.NewLine + 
                                    "Es necesario enviarla al supervisor", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    FRCRegistrarPropuesta RegistrarPropuesta = new FRCRegistrarPropuesta(iIdSol, iIdUser);
                    RegistrarPropuesta.FormClosed            += new FormClosedEventHandler(ActualizarDetalles_FormClosed);
                    RegistrarPropuesta.ShowDialog();
                }
            //}
            //else
            //{
            //    MessageBox.Show("Ya existen tres propuestas registradas las cuales deben ser aprobadas por el coordinador.");
            //}
        }

        /*Evento FormClosed para detonar funciones al cerrar ventanas emergentes*/
        private void ActualizarDetalles_FormClosed(object sender, FormClosedEventArgs e)
        {
            limpiaDataGrid();
            cargarDataGrid();
        }

        /*Función para limpiar registros del datagrid*/
        public void limpiaDataGrid()
        {
            dgvPropuestas.Rows.Clear();
        }

        /*Evento CellPainting de datagrid para colocar imagen en la columna Detalles*/
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

        /*Evento CellMouseMove para cambiar el cursor cuando pase por la columna Detalles del data grid*/
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

        /*Evento CheckedChanged para habilitar o deshabilitar el boton de enviar tramite*/
        private void chbEnviaraAprobacion_CheckedChanged(object sender, EventArgs e)
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
        
        /*Evento click boton Enviar Tramite que contiene la función para enviar la propuesta de respuesta al supervisor contable*/
        private void btnEnviarTramite_Click(object sender, EventArgs e)
        {
            bool bPendiente     = false;
            int iIdPropuesta    = 0;

            for (int i = 0; i < dgvPropuestas.RowCount; i++)
            {
                if (dgvPropuestas.Rows[i].Cells[2].Value.ToString() != "RECHAZADA")
                {
                    bPendiente = true;
                }
            }

            for (int i = 0; i < dgvPropuestas.RowCount; i++)
            {
                if (dgvPropuestas.Rows[i].Cells[2].Value.ToString() == "SIN SOLICITAR")
                {
                    iIdPropuesta = int.Parse(dgvPropuestas.Rows[i].Cells[0].Value.ToString());
                }
            }

            if (bPendiente == true)
            {
                DialogResult rs = MessageBox.Show("¿Estás seguro de enviar la solicitud al supervisor para su aprobación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    iBanderaProp = 1;
                    new Solicitud().envioPropuestaContador(iIdSol, iIdPropuesta);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Es necesario registrar una nueva propuesta de respuesta", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                chbEnviaraAprobacion.Checked = false;
            }
        }

        /*Evento click de boton Cancelar y cerrar el formulario */
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Evento CellContentClick para lanzar modal segun el click en la columna Detalles del datagrid*/
        private void dgvPropuestas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvPropuestas.Columns[e.ColumnIndex].Name.Equals("Detalles"))
                {
                    if (dgvPropuestas.SelectedCells[2].FormattedValue.ToString() == "SIN SOLICITAR")
                    {
                        FRCEditPropuesta aFormulario = new FRCEditPropuesta(iIdSol, int.Parse(dgvPropuestas.SelectedCells[0].FormattedValue.ToString()), 0);
                        aFormulario.FormClosed += new FormClosedEventHandler(ActualizarDetalles_FormClosed);
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
            catch (Exception)
            {
            }
        }

        /*Evento formClosing, solicita autorizacion para cerrar el formulario ya que no se ha descrito la resolución*/
        private void FRCGenerarRespuesta_FormClosing(object sender, FormClosingEventArgs e)
        {
            int iBProp = 0;
            for (int i = 0; i < dgvPropuestas.RowCount; i++)
            {
                if (dgvPropuestas.Rows[i].Cells[2].FormattedValue.ToString() == "SIN SOLICITAR")
                {
                    iBProp = 1;
                }
            }

            if (iBProp > 0 && iBanderaProp == 0)
            {
                DialogResult pro = MessageBox.Show("Existen propuestas sin solicitar aprobación" + Environment.NewLine + 
                                                   "¿Deseas salir sin enviar a aprobación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pro == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void tcDetalles_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage CurrentTab = tcDetalles.TabPages[e.Index];
            Rectangle ItemRect = tcDetalles.GetTabRect(e.Index);
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

            //Next we'll paint the TabItem with our Fill Brush
            e.Graphics.FillRectangle(FillBrush, ItemRect);

            //Now draw the text.
            e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, (RectangleF)ItemRect, sf);

            //Reset any Graphics rotation
            e.Graphics.ResetTransform();

            //Finally, we should Dispose of our brushes.
            FillBrush.Dispose();
            TextBrush.Dispose();
        }
    }
}
