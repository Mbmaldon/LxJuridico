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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraLayout;
using System.Runtime.InteropServices;

namespace LxCallcenter
{
    public partial class frmDirectorio : Form
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

        public frmDirectorio() : this(false) { }

        public frmDirectorio(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
        }

        //public frmDirectorio()
        //{
        //    InitializeComponent();
        //}

        static frmDirectorio _Directorio;
        static DialogResult _DialogResult = DialogResult.No;

        /// <summary>
        /// Modal para mostral un directorio de clientes de acuerdo al usuario logeado
        /// </summary>
        /// <param name="frmSet">Formulario principal en el que anclara el form</param>
        /// <returns></returns>
        public static DialogResult Show(Form frmSet)
        {
            Form fc = Application.OpenForms["frmDirectorio"];

            if (fc == null)
            {
                _Directorio = new frmDirectorio();

                //int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _Directorio.Width) / 2);
                int x = frmSet.Location.X + (frmSet.Width - _Directorio.Width);
                int y = frmSet.Location.Y;
                _Directorio.Location = new Point(x, y);
                _Directorio.Height   = frmSet.Height - 7;
                _Directorio.Owner    = frmSet;


                _DialogResult = DialogResult.No;
                _Directorio.Show();
            }
            return _DialogResult;            
        }

        protected override void OnLoad(EventArgs e)
        {
            //Animate form
            base.OnLoad(e);
            AnimateWindow(this.Handle, 100, AW_SLIDE | AW_HOR_NEGATIVE);

			FindControl find = null;
			foreach (Control ctrl in grdClientes.Controls)
				if (ctrl.GetType() == typeof(FindControl))
					find = ctrl as FindControl;
			if (find != null)
			{
				LayoutControl layout = find.Controls[0] as LayoutControl;
				edit = (layout.Items[2] as LayoutControlItem).Control as MRUEdit;
			}

			panel2.Visible			= true;
			materialLabel2.Visible	= true;
		}

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (e.Cancel == false)
            {
                AnimateWindow(this.Handle, 200, AW_HIDE | AW_SLIDE | AW_HOR_POSITIVE);
            }
        }

        private void frmDirectorio_Load(object sender, EventArgs e)
        {
            if (AUsuarioData.sTipoUsuario.Equals("10009") || AUsuarioData.sTipoUsuario.Equals("5"))
                cargarDirectorio(0);
            else
                cargarDirectorio(int.Parse(AUsuarioData.sIdusuario));
		}
        
        public void cargarDirectorio(int iIdContador)
        {
            grdClientes.DataSource = new LogicaCC.LexaSIOContaLogica.Cliente().lDirectorio(iIdContador);
        }

		MRUEdit edit;
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			//FindControl find = null;
			//foreach (Control ctrl in grdClientes.Controls)
			//	if (ctrl.GetType() == typeof(FindControl))
			//		find = ctrl as FindControl;
			//if (find != null)
			//{
			//	LayoutControl layout = find.Controls[0] as LayoutControl;
			//	edit = (layout.Items[2] as LayoutControlItem).Control as MRUEdit;
			//}
		}

		private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
			//string sCriterio = null;
			//if (rdbNoCliente.Checked)
			//    sCriterio = "sCliente";
			//else if (rdbNombre.Checked)
			//    sCriterio = "sNombre";
			//else if (rdbRfc.Checked)
			//    sCriterio = "sRfc";

			//cardView1.ActiveFilterCriteria = new DevExpress.Data.Filtering.BinaryOperator(new DevExpress.Data.Filtering.OperandProperty(sCriterio), new DevExpress.Data.Filtering.OperandValue(string.Format("%{0}%", txtBuscar.Text)), DevExpress.Data.Filtering.BinaryOperatorType.Like);
			edit.Text = txtBuscar.Text.ToString();
		}

        private void lnkCerrar_Click(object sender, EventArgs e)
        {
            _Directorio.Close();
        }

        
    }
}
