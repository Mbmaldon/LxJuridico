using LogicaCC.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter
{
    public partial class frmComentarioCerrarFolio : Form
    {
        UsuarioData AUsuarioData = UsuarioData.Instancia;
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

        public frmComentarioCerrarFolio() : this(false) { }

        public frmComentarioCerrarFolio(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
        }
        //public frmComentarioCerrarFolio()
        //{
        //    InitializeComponent();
        //}
        static frmComentarioCerrarFolio _ComentarioCerrarFolio;
        static DialogResult _DialogResult = DialogResult.No;
        public int iNoFolio;
        public MaterialSkin.Controls.MaterialRaisedButtonCustom btnCerrar;
        //public Label lblFechaCierre;

        public static DialogResult Show(Form frmSet, int iFolio, MaterialSkin.Controls.MaterialRaisedButtonCustom btnCerrar)
        {
            _ComentarioCerrarFolio = new frmComentarioCerrarFolio();

            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _ComentarioCerrarFolio.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _ComentarioCerrarFolio.Location  = new Point(x, y);
            _ComentarioCerrarFolio.iNoFolio  = iFolio;
            _ComentarioCerrarFolio.btnCerrar = btnCerrar;

            _DialogResult = DialogResult.No;
            _ComentarioCerrarFolio.ShowDialog();
            return _DialogResult;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _DialogResult = DialogResult.No;
            _ComentarioCerrarFolio.Close();
        }        

        private void btnCerrarFolio_Click(object sender, EventArgs e)
        {
            if (new Caso().bCerrarCaso(new Caso()
            {
                iIdCaso            = _ComentarioCerrarFolio.iNoFolio,
                iIdUsuarioModifica = int.Parse(AUsuarioData.sIdusuario)
            }) == true)
            {
                //bool bAlta = new CasoHistorial().Agregar(new CasoHistorial()
                //{
                //    iIdCaso     = _ComentarioCerrarFolio.iNoFolio,
                //    sComentario = txbDescripcion.Text
                //});

                int iResultado = new CasoHistorial().AddHistorial(new CasoHistorial()
                {
                    iIdCaso             = _ComentarioCerrarFolio.iNoFolio,
                    iIdUsuarioRegistra  = int.Parse(AUsuarioData.sIdusuario),
                    sComentario         = txbDescripcion.Text
                });


                _DialogResult = DialogResult.Yes;
                _ComentarioCerrarFolio.Close();

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FSeguimientoFolios")
                    {
                        FSeguimientoFolios _FSeguimientoFolios = frm as FSeguimientoFolios;
                        btnCerrar.Visible = false;
                        _FSeguimientoFolios.cargarFoliosBusqueda(0, 40, 230);
                        break;
                    }
                }
            }
            else
            {
                FlatMessageBox.Show("No se pudo cerrar el folio", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            //Animate form
            base.OnLoad(e);
            AnimateWindow(this.Handle, 200, AW_SLIDE | AW_VER_POSITIVE);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (e.Cancel == false)
            {
                AnimateWindow(this.Handle, 200, AW_HIDE | AW_SLIDE | AW_VER_NEGATIVE);
            }
        }
    }
}
