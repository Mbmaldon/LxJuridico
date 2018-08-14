using DevExpress.Export;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    public partial class frmClientesInactivos : Form
    {
        FPrincipal _frmPrincipal;

        public frmClientesInactivos()
        {
            InitializeComponent();
           
            InicializarControles();
        }

        /// <summary>
        /// Iniciliza la carga de controles y datos
        /// </summary>
        public void InicializarControles()
        {
            _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;

            //ASIGNA FORMATO AL DOCUMENTO EXPORTADO DESDE EL GRIDVIEW DE DEVEXPRESS
            ExportSettings.DefaultExportType                    = ExportType.WYSIWYG;
            gridView1.AppearancePrint.HeaderPanel.BackColor     = Color.FromArgb(0, 20, 137);
            gridView1.AppearancePrint.HeaderPanel.ForeColor     = Color.White;
            gridView1.AppearancePrint.HeaderPanel.BorderColor   = Color.FromArgb(0, 20, 137);
            gridView1.AppearancePrint.FooterPanel.BackColor     = Color.White;
            gridView1.AppearancePrint.FooterPanel.BorderColor   = Color.White;
            gridView1.AppearancePrint.Row.BorderColor           = Color.FromArgb(216, 216, 216);
            gridView1.OptionsPrint.AutoWidth                    = false;
            gridView1.OptionsPrint.UsePrintStyles               = true;
            
            //CARGAMOS EL CONTENIDO DEL GRIDVIEW Y ASIGNA FORMATO A ESTE
            grdClientes.DataSource = new LogicaCC.LexaSIOOperLogica.VendedorLXCC().clientesInactivos();
            gridView1.BestFitColumns();
            gridView1.Appearance.FooterPanel.Options.UseBackColor   = true;
            gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            gridView1.Appearance.FooterPanel.BackColor              = Color.White;
            gridView1.Appearance.FooterPanel.BackColor2             = Color.White;
            gridView1.Appearance.FooterPanel.BorderColor            = Color.White;

            //if (gridView1.RowCount != 0)
            //    _frmPrincipal.btnExportarClientesInactivos.Enabled = true;
            //else
            //    _frmPrincipal.btnExportarClientesInactivos.Enabled = false;
        }

        /// <summary>
        /// Exporta un listado de clientes inactivos concentrados en un gridview
        /// </summary>
        public void ExportarClientesInactivos()
        {
            if (gridView1.RowCount != 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    grdClientes.ExportToXlsx(saveFileDialog1.FileName);
                    Process.Start(saveFileDialog1.FileName);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            gridView1.ActiveFilterCriteria = new DevExpress.Data.Filtering.BinaryOperator(new DevExpress.Data.Filtering.OperandProperty("sNombre"), new DevExpress.Data.Filtering.OperandValue("%" + txtBuscar.Text + "%"), DevExpress.Data.Filtering.BinaryOperatorType.Like);
            gridView1.ExpandAllGroups();
        }
    }
}
