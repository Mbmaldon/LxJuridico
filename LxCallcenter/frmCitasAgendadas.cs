using DevExpress.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraLayout;
using LogicaCC.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter
{
    public partial class frmCitasAgendadas : Form
    {
        UsuarioData AUsuario = UsuarioData.Instancia;
        MRUEdit edit;
        public frmCitasAgendadas()
        {
            InitializeComponent();
            InitializeControls();
        }

        #region EVENTOS
        private void lnkCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            edit.Text = txtBuscar.Text;
            CountCitas();
        }

        private void frmCitasAgendadas_Shown(object sender, EventArgs e)
        {
            FindControl find = null;
            foreach (Control ctrl in grdCitas.Controls)
                if (ctrl.GetType() == typeof(FindControl))
                    find = ctrl as FindControl;
            if (find != null)
            {
                LayoutControl layout = find.Controls[0] as LayoutControl;
                edit = (layout.Items[2] as LayoutControlItem).Control as MRUEdit;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount != 0)
            {
                if (sfdExportarCitas.ShowDialog() == DialogResult.OK)
                {
                    grdCitas.ExportToXlsx(sfdExportarCitas.FileName);
                    Process.Start(sfdExportarCitas.FileName);
                }
            }
        }
        #endregion

        #region FUNCIONES
        /// <summary>
        /// Inicializa la información de los controles que se mostrarán
        /// </summary>
        public void InitializeControls()
        {
            grdCitas.DataSource = new Cita().GetList(int.Parse(AUsuario.sIdusuario));
            CountCitas();
            //APLICAMOS FORMATO AL GRIDVIEW
            gridView1.BestFitColumns();
            gridView1.Appearance.FooterPanel.Options.UseBackColor   = true;
            gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            gridView1.Appearance.FooterPanel.BackColor   = Color.White;
            gridView1.Appearance.FooterPanel.BackColor2  = Color.White;
            gridView1.Appearance.FooterPanel.BorderColor = Color.White;
            //APLICAMOS PROPIEDADES DE EXPORTACIÓN PARA EL GRIDVIEW DE DEVEXPRESS
            ExportSettings.DefaultExportType                    = ExportType.WYSIWYG;
            gridView1.AppearancePrint.HeaderPanel.BackColor     = Color.FromArgb(0, 176, 240);
            gridView1.AppearancePrint.HeaderPanel.ForeColor     = Color.White;
            gridView1.AppearancePrint.HeaderPanel.BorderColor   = Color.FromArgb(0, 176, 240);
            gridView1.AppearancePrint.FooterPanel.BackColor     = Color.White;        
            gridView1.AppearancePrint.FooterPanel.BorderColor   = Color.White;        
            gridView1.AppearancePrint.Row.BorderColor           = Color.FromArgb(216, 216, 216);
            gridView1.OptionsPrint.AutoWidth                    = false;
            gridView1.OptionsPrint.UsePrintStyles               = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            FindControl find = null;
            foreach (Control ctrl in grdCitas.Controls)
                if (ctrl.GetType() == typeof(FindControl))
                    find = ctrl as FindControl;
            if (find != null)
            {
                LayoutControl layout = find.Controls[0] as LayoutControl;
                edit = (layout.Items[2] as LayoutControlItem).Control as MRUEdit;
            }
        }

        /// <summary>
        /// Cuenta el total de registros que se muestran el el GridView de llamadas
        /// </summary>
        private void CountCitas()
        {
            if (gridView1.RowCount > 0)
                lblNoRegitros.Text = string.Format("No. de Registros: {0}", gridView1.RowCount);
            else
                lblNoRegitros.Text = "No. de Registros: --";
        }
        #endregion

        #region Code for border shadow
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
     );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;

        }
        #endregion 
    }
}