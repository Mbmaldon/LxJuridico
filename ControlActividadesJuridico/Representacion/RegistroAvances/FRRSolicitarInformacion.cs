using ClaseData.Clases.ListCoordinadores;
using ClaseData.Clases.Solicitud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    public partial class FRRSolicitarInformacion : Form
    {

        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        [Flags]
        enum AnimateWindowFlags
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER       = 0x00000010,
            AW_HIDE         = 0x00010000,
            AW_ACTIVATE     = 0x00020000,
            AW_SLIDE        = 0x00040000,
            AW_BLEND        = 0x00080000
        }

        int iIdSol;
        int iIdConsultor;
     
        CoorNoAsignadoData contador;

        /*Funciones que se inicializan cuando el formulario es llamado*/
        public FRRSolicitarInformacion()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            AnimateWindow(this.Handle, 200, AnimateWindowFlags.AW_BLEND);
            _Solicitud.cmbResponsable.Visible = true;
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            AnimateWindow(this.Handle, 300, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }

        static FRRSolicitarInformacion _Solicitud;
        static DialogResult _DialogResult = DialogResult.No;
        public static DialogResult Show(int idSolicitud, int Usuario, int idContador, int IdCaso)
        {
            _Solicitud = new FRRSolicitarInformacion();
            Form frmSet = Application.OpenForms["FPrincipal"];
            FRDetalleServicio _DetalleServicio = Application.OpenForms["FRDetalleServicio"] as FRDetalleServicio;

            _Solicitud.FormClosed += new FormClosedEventHandler(_DetalleServicio.ActualizarDetalles_FormClosed);


            _Solicitud.iIdSol = idSolicitud;
            _Solicitud.iIdConsultor = Usuario;
            //dtpHoraEntrega.Value    = DateTime.Now;
            _Solicitud.dtpHoraEntrega.Time = DateTime.Now;

            DatosCoorNoAsignados AContador = new DatosCoorNoAsignados();
            //List<CoorNoAsignadoData> LContador = AContador.contadorAsignado(idContador);
            List<CoorNoAsignadoData> LContador = AContador.contadorAsignado(IdCaso);

            _Solicitud.cmbResponsable.DataSource = LContador;
            _Solicitud.cmbResponsable.ValueMember = "sIdUsuario";
            _Solicitud.cmbResponsable.DisplayMember = "sNombre";
            // this.cmbResponsable.SelectedIndex = -1;
            //_Solicitud.cmbResponsable.SelectedItem = 1;
            _Solicitud.cmbResponsable.SelectedIndex = -1;
            //_Solicitud.cmbResponsable.Enabled = false;



            _DialogResult = DialogResult.No;

            _Solicitud.Activate();
            _Solicitud.ShowDialog();
            return _DialogResult;
        }







        //public FRRSolicitarInformacion(int idSolicitud, int Usuario, int idContador)
        //{
        //    InitializeComponent();
        //    iIdSol                  = idSolicitud;
        //    iIdConsultor            = Usuario;
        //    //dtpHoraEntrega.Value    = DateTime.Now;
        //    dtpHoraEntrega.Time     = DateTime.Now;

        //    DatosCoorNoAsignados AContador = new DatosCoorNoAsignados();
        //    List<CoorNoAsignadoData> LContador= AContador.contadorAsignado(idContador);

        //    this.cmbResponsable.DataSource      = LContador;
        //    this.cmbResponsable.ValueMember     = "sIdUsuario";
        //    this.cmbResponsable.DisplayMember   = "sNombre";
        //    // this.cmbResponsable.SelectedIndex = -1;
        //    cmbResponsable.SelectedItem         = 1;
        //    cmbResponsable.Enabled              = false;

        //    //dtpHoraEntrega.ShowUpDown = true;
        //}























        /*Evento click boton Registrar que contempla función para realizar el registro de una nueva solicitud de informacion*/
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int idContador;
            DateTime FVigencia;

            if (txtSolicitud.Text != string.Empty)
            {
                if (cmbResponsable.Text != string.Empty)
                {
                    contador        = (CoorNoAsignadoData)cmbResponsable.SelectedItem;
                    idContador      = int.Parse(contador.sIdUsuario.ToString());
                  
                    string fecha    = dtpFechaEntrega.Value.ToShortDateString();
                    //string hora     = dtpHoraEntrega.Value.ToString("H:mm");
                    string hora = dtpHoraEntrega.Time.ToString("H:mm");
                    FVigencia       = DateTime.Parse(fecha + " " +  hora);

                    if (FVigencia < DateTime.Now)
                    {
                        MessageBox.Show("La fecha de entrega no puede ser menor a la fecha actual", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            new DSDetalleServicio().RegistrarSolicitudInformacion(iIdSol, iIdConsultor, idContador, txtSolicitud.Text, FVigencia);
                            DialogResult rs = MessageBox.Show("Se ha realizado la solicitud correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (rs == DialogResult.OK)
                            {
                                Close();
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Es necesario asignar al responsable de la solicitud", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Es necesario registrar la descripción de la solicitud a realizar", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /*Evento KeyPress que evita que el usuario inserte texto manual en el control*/
        private void cmbResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /*Evento click de boton cancelar para cerrar formulario*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
