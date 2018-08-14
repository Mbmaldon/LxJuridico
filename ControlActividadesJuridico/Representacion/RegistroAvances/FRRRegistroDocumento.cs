using ClaseData.Clases.Solicitud;
using ClaseData.Clases.Solicitud.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    public partial class FRRRegistroDocumento : Form
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

        public FRRRegistroDocumento()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            AnimateWindow(this.Handle, 200, AnimateWindowFlags.AW_BLEND);
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            AnimateWindow(this.Handle, 300, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }

        



        int iIdSol;
        int iIdConsultor;

        ISDetalleServicio detalle;

        /*Funciones que se inicializan cuando el formulario es llamado*/
        //public FRRRegistroDocumento(int iIdSolicitud, int Usuario)
        //{
        //    InitializeComponent();
        //    iIdSol          = iIdSolicitud;
        //    iIdConsultor    = Usuario;

        //    DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
        //    detalle = detalleSolicitud.InfoSolicitud(iIdSolicitud);
        //}

        static FRRRegistroDocumento _Registro;
        static DialogResult _DialogResult = DialogResult.No;
        public static DialogResult Show(int iIdSolicitud, int Usuario)
        {
            _Registro = new FRRRegistroDocumento();
            Form frmSet = Application.OpenForms["FPrincipal"];
            FRDetalleServicio _DetalleServicio = Application.OpenForms["FRDetalleServicio"] as FRDetalleServicio;

            _Registro.FormClosed += new FormClosedEventHandler(_DetalleServicio.ActualizarDetalles_FormClosed);

            _Registro.iIdSol = iIdSolicitud;
            _Registro.iIdConsultor = Usuario;

            DSDetalleServicio detalleSolicitud = new DSDetalleServicio();
            _Registro.detalle = detalleSolicitud.InfoSolicitud(iIdSolicitud);



            _DialogResult = DialogResult.No;

            _Registro.Activate();
            _Registro.ShowDialog();
            return _DialogResult;
        }

        /*Evento click boton registrar para dar de alta un nuevo documento*/
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Requisicion  = null;
            string TipoReq      =  null;

            if (rbDocumento.Checked == true)
            {
                TipoReq     = "Documento";
                Requisicion = txtRequisicion.Text;
            }

            if (rbTestigo.Checked == true)
            {
                TipoReq     = "Testigo";
                Requisicion = txtRequisicion.Text;
            }

            if (rbDocumento.Checked != false || rbTestigo.Checked != false)
            {
                if (txtRequisicion.Text != string.Empty)
                {
                    try
                    {
                        new DSDetalleServicio().RegistrarDocumento(iIdSol, iIdConsultor, Requisicion, TipoReq);
                        DialogResult rs = MessageBox.Show("Se ha realizado el registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (rs == DialogResult.OK)
                        {
                            Close();
                        }
                    }
                    catch
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Se requiere registrar la requisición", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Es necesario tipificar el tipo de requisición", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /*Evento CheckedChanged de radioButton para seleccionar el tipo de documento o solicitud al cliente*/
        private void rbDocumento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDocumento.Checked == true)
            {
                lblReq.Text             = "Documento:";
                lblReq.Visible          = true;
                txtRequisicion.Visible  = true;
            }
            if (rbTestigo.Checked == true)
            {
                lblReq.Text             = "Nombre:";
                lblReq.Visible          = true;
                txtRequisicion.Visible  = true;
            }
        }

        /*Evento click de boton cancelar para cerrar formulario*/
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
