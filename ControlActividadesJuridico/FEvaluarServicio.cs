using ClaseData.Clases.CallCenter;
using ClaseData.Clases.CallCenter.Entidades;
using ControlActividadesJuridico.CallCenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico
{
    public partial class FEvaluarServicio : Form
    {
        int idCallCenter;
        int iContador;
        int iBandera = 0;
        int Registros;
        EDetallesEvaluacion detalle;

        public FEvaluarServicio(int iIdCallCenter)
        {
            InitializeComponent();
            idCallCenter = iIdCallCenter;
        }

        /*Funcion para cargar la información del cliente en el formulario*/
        public void informacion(EDetallesEvaluacion det)
        {
            lblNocliente1.Text      = det.sNumCliente;
            lblNomCliente.Text      = det.sCliente;
            lblRFC.Text             = det.sRFC;
            lblTelCelular.Text      = det.sNumMovil;
            lblTelLocal.Text        = det.sNumLocal;
            lblFolio.Text           = det.sFolio;
            lblTipoEvento.Text      = det.sTipoSolicitud;
            lblFechaSolicitud.Text  = DateTime.Parse(det.sFechaSolicitud).ToShortDateString();
            lblFResolucion.Text     = DateTime.Parse(det.sFechaResolución).ToShortDateString();
            lblConsultor.Text       = det.sConsultor;
            lblFechaRegistro.Text   = det.sFechaSolicitudevaluacion;
        }

        /*Finción para mostrar modal y registrar evaluación*/
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvEvaluaciones.RowCount; i++)
            {
                if (dgvEvaluaciones.Rows[i].Cells[3].FormattedValue.ToString() == "SI")
                {
                    iBandera = 1;
                }
            }

            if (iBandera == 0)
            {
                if (Registros < 3)
                {
                    FCRegistrarEvaluacion RegistrarEvaluacion   = new FCRegistrarEvaluacion(idCallCenter, Registros);
                    RegistrarEvaluacion.FormClosed              += new FormClosedEventHandler(ActualizarInformacion_FormClosed);
                    RegistrarEvaluacion.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Ya existen tres registros y no se contacto al cliente" + Environment.NewLine + "Es necesario cerrar el proceso de evaluación", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ya existe una evaluación por el cliente, es necesario cerrar con el proceso", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*Función para recargar la informacion cuando sea necesario*/
        private void ActualizarInformacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            LimpiaDataGrid();
            cargaEvaluacionesRegistradas();
            seleccion();
        }

        /*Limpiar datagrid*/
        public void LimpiaDataGrid()
        {
            dgvEvaluaciones.Rows.Clear();
        }

        /*Quita seleccion automatica del registros en el datagrid*/
        public void seleccion()
        {
            dgvEvaluaciones.ClearSelection();
        }

        /*Función para cargra las evaluaciones registradas en la solicitud*/
        public void cargaEvaluacionesRegistradas()
        {
            List<EIEvaluaciones> EvaluacionesRegistradas    = new List<EIEvaluaciones>();
            DDetallesEvaluacion evaluaciones                = new DDetallesEvaluacion();

            EvaluacionesRegistradas                         = evaluaciones.obetenerEvaluacionesRegis(idCallCenter);

            iContador = 0;

            if (EvaluacionesRegistradas.Any())
            {
                foreach (EIEvaluaciones vRow in EvaluacionesRegistradas)
                {
                    dgvEvaluaciones.Rows.Add(vRow.sIdEvaluacion,
                                             vRow.sUsuario,
                                             vRow.sFechaRegistro,
                                             vRow.sClienteContactado,
                                             "Detalles");

                    iContador++;
                }
            }
            Registros = dgvEvaluaciones.Rows.Count;

            for (int i = 0; i < dgvEvaluaciones.RowCount; i++)
            {
                if (dgvEvaluaciones.Rows[i].Cells[3].FormattedValue.ToString() == "SI")
                {
                    btnEnviar.Visible = Visible;
                }
            }

            if (Registros == 3)
            {
                btnEnviar.Visible = Visible;
            }
        }

        /*Función para abrir el formulario dependiendo la evaluacion realizada*/
        private void dgvEvaluaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvEvaluaciones.Columns[e.ColumnIndex].Name.Equals("detalles"))
                {
                    if (this.dgvEvaluaciones.SelectedCells[3].FormattedValue.Equals("SI"))
                    {
                        FDetalleEvaluacionS aFormulario = new FDetalleEvaluacionS(int.Parse(dgvEvaluaciones.SelectedCells[0].FormattedValue.ToString()));
                        aFormulario.ShowDialog();
                    }
                    else if (this.dgvEvaluaciones.SelectedCells[3].FormattedValue.Equals("NO"))
                    {
                        FDetalleEvaluacionN aFormulario = new FDetalleEvaluacionN(int.Parse(dgvEvaluaciones.SelectedCells[0].FormattedValue.ToString()));
                        aFormulario.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        /*Funcion para recargar la información en el formulario*/
        private void FEvaluarServicio_Load(object sender, EventArgs e)
        {
            DDetallesEvaluacion detalleEvaluacion   = new DDetallesEvaluacion();
            detalle                                 = detalleEvaluacion.InfoEvaluacion(idCallCenter);
            informacion(detalle);
            cargaEvaluacionesRegistradas();
            seleccion();
        }

        /*Función para cerrar formulario*/
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*Función para cerrar la evaluación realizada del servicio brindado al cliente*/
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DialogResult ap = MessageBox.Show("¿Estas seguro de cerrar la evalución del servicio?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ap == DialogResult.Yes)
            {
                new DDetallesEvaluacion().evaluacionRealizada(idCallCenter);
                Close();
            }
        }

        /*Funcion para insertar imagen en cada registro de las evaluaciones*/
        private void dgvEvaluaciones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvEvaluaciones.Columns[e.ColumnIndex].Name == "detalles" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvEvaluaciones.Rows[e.RowIndex].Cells["detalles"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.content_20px, e.CellBounds.Left + 25, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }

        /*Función para cambiar puntero cuando su posicion sea en la celda detalles*/
        private void dgvEvaluaciones_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEvaluaciones.Columns[e.ColumnIndex].Name.ToString() == "detalles")
            {
                dgvEvaluaciones.Cursor = Cursors.Hand;
            }
            else
            {
                dgvEvaluaciones.Cursor = Cursors.Default;
            }
        }
    }
}
