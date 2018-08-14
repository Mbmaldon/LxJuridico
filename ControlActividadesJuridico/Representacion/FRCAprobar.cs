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
    public partial class FRCAprobar : Form
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
        public FRCAprobar() : this(false) { }

        public FRCAprobar(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
        }

        static FRCAprobar _Aprobar;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show(int iIdSolicitud, int iIdCaso)
        {
            _Aprobar = new FRCAprobar();
            Form frmSet = Application.OpenForms["FPrincipal"];
            FBandeja _FBandeja = Application.OpenForms["FBandeja"] as FBandeja;

            _Aprobar.FormClosed += new FormClosedEventHandler(_FBandeja.ActualizarSolPendientes_FormClosed);

            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _Aprobar.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _Aprobar.Location = new Point(x, y);

            _Aprobar.iIdSol = iIdSolicitud;
            _Aprobar.iCaso = iIdCaso;
            _Aprobar.detalle = null;

            DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
            _Aprobar.detalle = detalleSolicitud.InfoSolicitud(iIdSolicitud);
            _Aprobar.SolicitudDetalle(_Aprobar.detalle);
            _Aprobar.cargarDataGrid();

            _DialogResult = DialogResult.No;

            _Aprobar.Activate();
            _Aprobar.ShowDialog();

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
        int     iContador;
        //int iRegistro;
        int     iBanderaProp = 0;
        string  sUrlCitas;
        ISDetalleServicio detalle;

        /*Funciones que se inicializan cuando el formulario es llamado*/
        //public FRCAprobar(int iIdSolicitud, int iIdCaso)
        //{
        //    InitializeComponent();
        //    iIdSol  = iIdSolicitud;
        //    iCaso   = iIdCaso;
        //    detalle = null;

        //    DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
        //    detalle = detalleSolicitud.InfoSolicitud(iIdSolicitud);
        //    SolicitudDetalle(detalle);
        //    cargarDataGrid();
        //}

        /*Función para limpiar la seleccion de los registros cargados en el datagrid*/
        public void seleccion()
        {
            dgvPropuestas.ClearSelection();
        }

        /*Función para vaciar la información en los controles visibles del diseño*/
        private void SolicitudDetalle(ISDetalleServicio detSolicitud)
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
            lblContador.Text        = detSolicitud.sConsultor;
            lblTipoEvento.Text      = detSolicitud.sTipoEvento;
            txtSolicitud.Text       = detSolicitud.sSolicitud;
            sUrlCitas               = detSolicitud.sUrlCitas;
        }

        /*Función para realizar la carga de información en el datagrid*/
        public void cargarDataGrid()
        {
            List<EPropuestaRespuesta> RegistroPropuestas = new List<EPropuestaRespuesta>();
            CInfoDetalles APropuestas = new CInfoDetalles();

            RegistroPropuestas = APropuestas.obtenerPropuestasRegistradas(iIdSol);

            iContador = 0;
            if (RegistroPropuestas.Any())
            {
                foreach (EPropuestaRespuesta vRow in RegistroPropuestas)
                {
                    dgvPropuestas.Rows.Add(vRow.sIdPropuestaRespuesta,
                                           vRow.sAprobada,
                                           vRow.sPropuesta,
                                           vRow.sAprobacion,
                                           vRow.sDescripcionRechazo,
                                           vRow.sCoordinador,
                                           "Aprobar");
                    iContador++;
                }
            }
            propuestasAprobadas();
            seleccion();
        }

        /*Función para validar las propuestas aprobadas y mostrar el boton Enviar Trámite*/
        public void propuestasAprobadas()
        {
            for (int i = 0; i < dgvPropuestas.RowCount; i++)
            {
                if (dgvPropuestas.Rows[i].Cells[1].FormattedValue.ToString() == "0" && dgvPropuestas.Rows[i].Cells[3].FormattedValue.ToString() != "SIN APROBAR")
                {
                    btnEnviarTramite.Visible = true;
                }
            }
        }

        /*Evento CellPainting de datagrid para colocar imagen en la columna Aprobar*/
        private void dgvPropuestas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvPropuestas.Columns[e.ColumnIndex].Name == "Aprobar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvPropuestas.Rows[e.RowIndex].Cells["Aprobar"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.check_file_18px, e.CellBounds.Left + 28, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }

        /*Evento CellMouseMove para cambiar el cursor cuando pase por la columna Aprobar del data grid*/
        private void dgvPropuestas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPropuestas.Columns[e.ColumnIndex].Name.ToString() == "Aprobar")
            {
                dgvPropuestas.Cursor = Cursors.Hand;
            }
            else
            {
                dgvPropuestas.Cursor = Cursors.Default;
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
                MessageBox.Show("No existen llamadas de este folio", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* Evento SelectedIndexChanged del tcDetalles para visualizar u ocultar datagrid dependiendo el seleccionado*/
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

        /*Evento click de boton Cancelar y cerrar el formulario */
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Close();
            int iBPropuestas = 0;
            for (int i = 0; i < dgvPropuestas.RowCount; i++)
            {
                if (dgvPropuestas.Rows[i].Cells[3].FormattedValue.ToString() == "SIN APROBAR")
                {
                    iBPropuestas = 1;
                }
            }

            if (iBPropuestas > 0)
            {
                DialogResult rs = MessageBox.Show("Existe propuesta sin aprobación" + Environment.NewLine +
                                                  "¿Deseas cerrar sin aprobar la propuesta?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //e.Cancel = true;
                    _DialogResult = DialogResult.No;
                    _Aprobar.Close();
                }
            }
            else
            {
                if (iBanderaProp == 0)
                {
                    DialogResult ap = MessageBox.Show("Es necesario enviar la aprobación de la propuesta al contador" + Environment.NewLine +
                                                      "¿Deseas cerrar sin enviar la aprobación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ap == DialogResult.Yes)
                    {
                        //e.Cancel = true;
                        _DialogResult = DialogResult.No;
                        _Aprobar.Close();
                    }
                }
            }
        }

        /*Evento formClosing, solicita autorizacion para cerrar el formulario ya que no se ha realizado la probacion de la propuesta registrada por el contador*/
        private void FRCAprobar_FormClosing(object sender, FormClosingEventArgs e)
        {
            //int iBPropuestas = 0;
            //for (int i = 0; i < dgvPropuestas.RowCount; i++)
            //{
            //    if (dgvPropuestas.Rows[i].Cells[3].FormattedValue.ToString() == "SIN APROBAR")
            //    {
            //        iBPropuestas = 1;
            //    }
            //}

            //if (iBPropuestas > 0)
            //{
            //    DialogResult rs = MessageBox.Show("Existe propuesta sin aprobación" + Environment.NewLine + 
            //                                      "¿Deseas cerrar sin aprobar la propuesta?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (rs == DialogResult.No)
            //    {
            //        e.Cancel = true;
            //    }
            //}
            //else
            //{
            //    if (iBanderaProp == 0)
            //    {
            //        DialogResult ap = MessageBox.Show("Es necesario enviar la aprobación de la propuesta al contador" + Environment.NewLine + 
            //                                          "¿Deseas cerrar sin enviar la aprobación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (ap == DialogResult.No)
            //        {
            //            e.Cancel = true;
            //        }
            //    }
            //}
        }

        /*Evento click boton Enviar Tramite que contiene la función para enviar la aprobación de la propuesta de respuesta*/
        private void btnEnviarTramite_Click(object sender, EventArgs e)
        {
            //iRegistro = dgvPropuestas.Rows.Count;
            int iBandera    = 0;
            int idPropuesta = 0;
            bool bPendiente = false;

            for (int i = 0; i < dgvPropuestas.RowCount; i++)
            {
                if (dgvPropuestas.Rows[i].Cells[3].Value.ToString() == "SIN APROBAR")
                {
                    bPendiente = true;
                }
            }

            for (int i = 0; i < dgvPropuestas.RowCount; i++)
            {
                if (dgvPropuestas.Rows[i].Cells[1].Value.ToString() == "0")
                {
                    idPropuesta = int.Parse(dgvPropuestas.Rows[i].Cells[0].Value.ToString());
                }
            }

            if (bPendiente == true)
            {
                MessageBox.Show("Existe una propuesta de respuesta sin aprobar. Favor de realizar la aprobación", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < dgvPropuestas.RowCount; i++)
                {
                    if (dgvPropuestas.Rows[i].Cells[3].Value.ToString() == "APROBADA")
                    {
                        iBandera = 1;
                    }
                }

                //if (iRegistro == 3 && iBandera == 0)
                //{
                //    iRegistro = iRegistro + 1;
                //}

                try
                {
                    DialogResult av = MessageBox.Show("¿Estás seguro de enviar la aprobación de la propuesta?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (av == DialogResult.Yes)
                    {
                        iBanderaProp = 1;
                        new Solicitud().AprobacionFolioSupConta(iIdSol, iBandera, idPropuesta);
                        //if (iRegistro >= 4)
                        //{
                        //    DialogResult rs = MessageBox.Show("Se ha enviado la solicitud gerente.", "Mensaje", MessageBoxButtons.OK);
                        //    if (rs == DialogResult.OK)
                        //    {
                        //        Close();
                        //    }
                        //}
                        //else
                        //{
                            DialogResult rs = MessageBox.Show("Se ha enviado la solicitud al contador", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (rs == DialogResult.OK)
                            {
                                _DialogResult = DialogResult.OK;
                                _Aprobar.Close();
                                //Close();
                            }
                        //}
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        /*Evento CellContentClick para lanzar modal segun el click en la columna Detalles del datagrid*/
        private void dgvPropuestas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvPropuestas.Columns[e.ColumnIndex].Name.Equals("Aprobar"))
                {
                    if (this.dgvPropuestas.SelectedCells[1].FormattedValue.ToString() == "1")
                    {

                        if (dgvPropuestas.SelectedCells[3].FormattedValue.ToString() == "APROBADA")
                        {
                            FRRAprobarPropuesta aFormulario = new FRRAprobarPropuesta(int.Parse(dgvPropuestas.SelectedCells[0].FormattedValue.ToString()), 1, 1);
                            aFormulario.FormClosed += new FormClosedEventHandler(ActualizarDetalles_FormClosed);
                            aFormulario.ShowDialog();
                        }
                        else if (dgvPropuestas.SelectedCells[3].FormattedValue.ToString() == "RECHAZADA")
                        {
                            FRRAprobarPropuesta aFormulario = new FRRAprobarPropuesta(int.Parse(dgvPropuestas.SelectedCells[0].FormattedValue.ToString()), 2, 1);
                            aFormulario.FormClosed += new FormClosedEventHandler(ActualizarDetalles_FormClosed);
                            aFormulario.ShowDialog();
                        }
                    }
                    else if (this.dgvPropuestas.SelectedCells[1].FormattedValue.ToString() == "0")
                    {
                        if (dgvPropuestas.SelectedCells[3].FormattedValue.ToString() == "APROBADA")
                        {
                            FRRAprobarPropuesta aFormulario = new FRRAprobarPropuesta(int.Parse(dgvPropuestas.SelectedCells[0].FormattedValue.ToString()), 1, 0);
                            aFormulario.FormClosed += new FormClosedEventHandler(ActualizarDetalles_FormClosed);
                            aFormulario.ShowDialog();
                        }
                        else if (dgvPropuestas.SelectedCells[3].FormattedValue.ToString() == "RECHAZADA")
                        {
                            FRRAprobarPropuesta aFormulario = new FRRAprobarPropuesta(int.Parse(dgvPropuestas.SelectedCells[0].FormattedValue.ToString()), 2, 0);
                            aFormulario.FormClosed += new FormClosedEventHandler(ActualizarDetalles_FormClosed);
                            aFormulario.ShowDialog();
                        }
                        else
                        {
                            FRRAprobarPropuesta aFormulario = new FRRAprobarPropuesta(int.Parse(dgvPropuestas.SelectedCells[0].FormattedValue.ToString()), 0, 0);
                            aFormulario.FormClosed += new FormClosedEventHandler(ActualizarDetalles_FormClosed);
                            aFormulario.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
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


        public MaterialSkin.MaterialSkinManager SkinManager { get { return MaterialSkin.MaterialSkinManager.Instance; } }
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
