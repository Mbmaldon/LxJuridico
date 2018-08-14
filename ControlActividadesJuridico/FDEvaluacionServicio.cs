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
    public partial class FDEvaluacionServicio : Form
    {
        //Constants
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
        public FDEvaluacionServicio() : this(false) { }

        public FDEvaluacionServicio(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
        }

        static FDEvaluacionServicio _Evaluacion;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show(int iIdCallCenter)
        {
            _Evaluacion = new FDEvaluacionServicio();
            Form frmSet = Application.OpenForms["FPrincipal"];
            FBandeja _FBandeja = Application.OpenForms["FBandeja"] as FBandeja;

            _Evaluacion.FormClosed += new FormClosedEventHandler(_FBandeja.ActualizarSolPendientes_FormClosed);

            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _Evaluacion.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _Evaluacion.Location = new Point(x, y);

            _Evaluacion.idCallCenter = iIdCallCenter;

            DDetallesEvaluacion detalleEvaluacion = new DDetallesEvaluacion();
            _Evaluacion.detalle = detalleEvaluacion.InfoEvaluacion(_Evaluacion.idCallCenter);
            _Evaluacion.informacion(_Evaluacion.detalle);

            _Evaluacion.cargaEvaluacionesRegistradas();
            _Evaluacion.seleccion();

            _DialogResult = DialogResult.No;

            _Evaluacion.Activate();
            _Evaluacion.ShowDialog();

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


        int idCallCenter;
        int iContador;
        EDetallesEvaluacion detalle;
        //public FDEvaluacionServicio(int iIdCallCenter)
        //{
        //    InitializeComponent();
        //    idCallCenter = iIdCallCenter;
        //}

        /*Funcion para cargar los detalles de la evaluación*/
        private void FDEvaluacionServicio_Load(object sender, EventArgs e)
        {
            //DDetallesEvaluacion detalleEvaluacion   = new DDetallesEvaluacion();
            //detalle                                 = detalleEvaluacion.InfoEvaluacion(idCallCenter);
            //informacion(detalle);

            //cargaEvaluacionesRegistradas();
            //seleccion();
        }

        /*Función para mostrara los detalles de la evaluacion en los labels*/
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

        /*Función para cargar las evaluaciones realizadas al cliente*/
        public void cargaEvaluacionesRegistradas()
        {
            List<EIEvaluaciones> EvaluacionesRegistradas = new List<EIEvaluaciones>();
            DDetallesEvaluacion evaluaciones = new DDetallesEvaluacion();

            EvaluacionesRegistradas = evaluaciones.obetenerEvaluacionesRegis(idCallCenter);
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
        }

        /*Quitar selección automatica en datagrid*/
        public void seleccion()
        {
            dgvEvaluaciones.ClearSelection();
        }

        /*Funcion para mostrar modeal dependiendo la evaluacion realizada en el registro del datagrid*/
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
            catch (Exception)
            {
            }
        }

        /*Función para cerrar formulario*/
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*Funcion para cargra imagen en cada registro del datagrid*/
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

        /*Función para cambiar puntero cuando este posicionado en la columna detalles de cada registro*/
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
