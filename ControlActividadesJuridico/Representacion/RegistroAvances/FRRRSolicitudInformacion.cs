using ClaseData.Clases.AccesoArchivos;
using ClaseData.Clases.Solicitud;
using ClaseData.Clases.Solicitud.DetalleServicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    public partial class FRRRSolicitudInformacion : Form
    {
        string nomArchivo;
        ESolicitudInformacion SolicitudInformacion;
        public MaterialSkin.MaterialSkinManager SkinManager { get { return MaterialSkin.MaterialSkinManager.Instance; } }


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

        //NetworkCredential _NetworkCredential = new NetworkCredential(AccessFiles.sUsuario, AccessFiles.sContraseña);
        //string PathFolderShared = @"\\192.169.143.34\Data_Files";

        /*Funciones que se inicializan cuando el formulario es llamado*/
        //public FRRRSolicitudInformacion(int iIdSolInformacion)
        //{
        //    InitializeComponent();

        //    DSDetalleServicio detalleSol = new DSDetalleServicio();
        //    SolicitudInformacion = detalleSol.detSolicitudInformResp(iIdSolInformacion);
        //    detalleSolicitudInformacio(SolicitudInformacion);
        //}


        public FRRRSolicitudInformacion()
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

        static FRRRSolicitudInformacion _Seguimiento;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show(int iIdSolInformacion)
        {
            _Seguimiento = new FRRRSolicitudInformacion();

            DSDetalleServicio detalleSol = new DSDetalleServicio();
            _Seguimiento.SolicitudInformacion = detalleSol.detSolicitudInformResp(iIdSolInformacion);
            _Seguimiento.detalleSolicitudInformacio(_Seguimiento.SolicitudInformacion);

            _DialogResult = DialogResult.No;

            _Seguimiento.Activate();
            _Seguimiento.ShowDialog();
            return _DialogResult;
        }




        /*Función para vaciar la información en los controles visibles del diseño*/
        public void detalleSolicitudInformacio(ESolicitudInformacion det)
        {
            txtSolicitud.Text       = det.sSolicitud;
            txtResponsable.Text     = det.sResponsable;
            lblVigencia.Text        = det.sFechaVigencia;
            txtRespuesta.Text       = det.sRespuesta;

            Font _FontRoboto = SkinManager.ROBOTO_REGULAR_7;
            nomArchivo              = Path.GetFileName(det.sRutaArchivo);
            LinkLabel lnkArchivo    = new LinkLabel();
            lnkArchivo.Text         = nomArchivo;
            lnkArchivo.AutoSize     = true;
            //lnkArchivo.Location     = new Point(210, 311);
            lnkArchivo.Location = new Point(237, 311);
            lnkArchivo.Name         = det.sRutaArchivo;
            lnkArchivo.Font         = _FontRoboto;
            lnkArchivo.Click        += LnkArchivo_Click;
            frm2.Controls.Add(lnkArchivo);

            if (det.sFechaRespuesta == "01/01/1900 12:00:00 a. m.")
            {
                lblFechaEntrega.Text = " ";
            }
            else
            {
                lblFechaEntrega.Text = det.sFechaRespuesta;
            }
        }

        /*Funcion click para lanzar la apertura del archivo seleccionado*/
        private void LnkArchivo_Click(object sender, EventArgs e)
        {
            LinkLabel ruta = sender as LinkLabel;
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                System.Diagnostics.Process.Start(ruta.Name);
            //}
        }

        /*Evento KeyPress evita la escritura de texto en el control*/
        private void bloqueoInsercion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /*Evento click de boton cancelar para cerrar formulario*/
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
