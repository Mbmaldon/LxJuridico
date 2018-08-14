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
    public partial class frmPremios : Form
    {
        FPrincipal _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;
        public frmPremios()
        {
            InitializeComponent();
            InicializaDatos();
            InicializaControles();
        }

        /// <summary>
        /// Carga la información correspondiente a los bonos
        /// </summary>
        public void InicializaDatos()
        {
            grdPremios.DataSource = new LogicaCC.LexaSIOOperLogica.Premio().lPremio();
            gridView1.BestFitColumns();
            gridView1.Appearance.FooterPanel.Options.UseBackColor   = true;
            gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            gridView1.Appearance.FooterPanel.BackColor              = Color.White;
            gridView1.Appearance.FooterPanel.BackColor2             = Color.White;
            gridView1.Appearance.FooterPanel.BorderColor            = Color.White;
        }

        /// <summary>
        /// Inializa los controles necesarios
        /// </summary>
        public void InicializaControles()
        {
            // Cambia el estado del botón de exportación según el
            // contenido del gridview que contiene la información.
            if (gridView1.RowCount > 0)
                _frmPrincipal.btnExportarPremios.Enabled = true;
            else
                _frmPrincipal.btnExportarPremios.Enabled = false;

            //Asigna formato al documento exportado desde el gridview de DevExpress
            ExportSettings.DefaultExportType                    = ExportType.WYSIWYG;
            gridView1.AppearancePrint.HeaderPanel.BackColor     = Color.FromArgb(0, 20, 137);
            gridView1.AppearancePrint.HeaderPanel.ForeColor     = Color.White;
            gridView1.AppearancePrint.HeaderPanel.BorderColor   = Color.FromArgb(0, 20, 137);
            gridView1.AppearancePrint.FooterPanel.BackColor     = Color.White;
            gridView1.AppearancePrint.FooterPanel.BorderColor   = Color.White;
            gridView1.AppearancePrint.Row.BorderColor           = Color.FromArgb(216, 216, 216);
            gridView1.OptionsPrint.AutoWidth                    = false;
            gridView1.OptionsPrint.UsePrintStyles               = true;
        }

        /// <summary>
        /// Exporta el contenido del gridview de bonos a una hoja de calculo
        /// </summary>
        public void Exportar()
        {
            if (gridView1.RowCount != 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    grdPremios.ExportToXlsx(saveFileDialog1.FileName);
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
