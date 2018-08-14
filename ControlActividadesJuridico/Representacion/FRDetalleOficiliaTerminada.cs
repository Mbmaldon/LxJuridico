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
    public partial class FRDetalleOficiliaTerminada : Form
    {
        int iIdSol;
        int iContador;

        ISDetalleServicio detalle;

        /*Funciones que se inicializan cuando el formulario es llamado*/
        public FRDetalleOficiliaTerminada(int iIdSolicitud)
        {
            InitializeComponent();
            iIdSol  = iIdSolicitud;
            detalle = null;

            DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
            detalle = detalleSolicitud.InfoSolicitud(iIdSolicitud);
            SolicitudDetalle(detalle);

            cargraOficialias();
        }

        /*Función para vaciar la información en los controles visibles en diseño*/
        private void SolicitudDetalle(ISDetalleServicio detSolicitud)
        {
            lblNocliente1.Text  = detSolicitud.sNumCliente;
            lblNomCliente.Text  = detSolicitud.sNombreCliente;
            lblRFC.Text         = detSolicitud.sRFC;
            lblFolio.Text       = detSolicitud.sIdCaso;
        }

        /*Función para realizar la carga de información en el datagrid*/
        public void cargraOficialias()
        {
            List<EOficialia> OficialiasRegistradas = new List<EOficialia>();
            CInfoDetalles ARegistros    = new CInfoDetalles();
            OficialiasRegistradas       = ARegistros.obtenerOficialias(iIdSol);

            iContador = 0;

            if (OficialiasRegistradas.Any())
            {
                foreach (EOficialia vRow in OficialiasRegistradas)
                {
                    dgvOficialias.Rows.Add(vRow.sIdOficialia,
                                            vRow.sConsultor,
                                            vRow.sExpOrigen,
                                            vRow.sNumExpediente,
                                            vRow.sJuzgado,
                                            vRow.sContraparte,
                                            vRow.sTipoJuicio,
                                            vRow.sOficialia,
                                            "Detalles");
                    iContador++;
                }
            }
        }

        /*Evento click de boton Cerrar formulario */
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*Evento CellContentClick para lanzar modal segun el click en la columna detalles de los datagrid*/
        private void dgvOficialias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvOficialias.Columns[e.ColumnIndex].Name.Equals("Detalles"))
                {
                    FRDetallesOficialiaT aFormulario = new FRDetallesOficialiaT(int.Parse(dgvOficialias.SelectedCells[0].FormattedValue.ToString()));
                    aFormulario.ShowDialog();
                }
            }
            catch (Exception)
            {

            }
        }

        /*Evento CellPainting de datagrid para colocar imagen en la columna detalles*/
        private void dgvOficialias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvOficialias.Columns[e.ColumnIndex].Name == "Detalles" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvOficialias.Rows[e.RowIndex].Cells["Detalles"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.content_20px, e.CellBounds.Left + 20, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }

        /*Evento CellMouseMove para cambiar el cursor cuando pase por la columna detalles del data grid*/
        private void dgvOficialias_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvOficialias.Columns[e.ColumnIndex].Name.ToString() == "Detalles")
            {
                dgvOficialias.Cursor = Cursors.Hand;
            }
            else
            {
                dgvOficialias.Cursor = Cursors.Default;
            }
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
    }
}
