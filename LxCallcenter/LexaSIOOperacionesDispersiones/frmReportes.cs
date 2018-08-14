using DevExpress.Export;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using LogicaCC.LexaSIOOperLogica;
using LogicaCC.LexaSIOOperLogica.Reportes;
using LogicaCC.Logica;
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
    public partial class frmReportes : Form
    {
        UsuarioData AUsuario;
        decimal dPorcentajeBono = 0;
        FPrincipal _frmPrincipal;
        public frmReportes()
        {
            InitializeComponent();
            AUsuario = UsuarioData.Instancia;

            //INICIALIZA
            //INGRESOS POR CLIENTE
            AplicarFormatoGridsExportacion(gridView1);
            CargarIngresosCliente(dtFechaDesde.Value, dtFechaHasta.Value);
            //COMISIONES
            AplicarFormatoGridsExportacion(gridView2);
            CargarComisiones(dtFechaDesde.Value, dtFechaHasta.Value);

            cmbxAnioRemanente.DataSource    = new RBonosVendedores().ObtenerAnios();
            cmbxAnioRemanente.DisplayMember = "iAnio";
            cmbxAnioRemanente.ValueMember   = "iAnio";
            AplicarFormatoGridsExportacion(gridView4);

            _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;
            _frmPrincipal.btnExportarIngrCliente.Enabled          = true;
            _frmPrincipal.btnExportarComisionesVendedores.Enabled = true;
        }
        private void frmReportes_Load(object sender, EventArgs e)
        {
            cargarBonos();
        }
        /// <summary>
        /// Método para aplicar formato a la exportación del gridview en el
        /// documento en excel
        /// </summary>
        /// <param name="_Gridview0">Nombre por default del grid (ejem. gridView1)</param>
        void AplicarFormatoGridsExportacion(GridView _Gridview0)
        {
            //APLICAMOS PROPIEDADES DE EXPORTACIÓN PARA EL GRIDVIEW DE DEVEXPRESS
            ExportSettings.DefaultExportType                    = ExportType.WYSIWYG;
            _Gridview0.AppearancePrint.HeaderPanel.BackColor     = Color.FromArgb(33, 69, 129);
            _Gridview0.AppearancePrint.HeaderPanel.ForeColor     = Color.White;
            _Gridview0.AppearancePrint.HeaderPanel.BorderColor   = Color.FromArgb(33, 69, 129);
            _Gridview0.AppearancePrint.FooterPanel.BackColor     = Color.White;
            _Gridview0.AppearancePrint.FooterPanel.BorderColor   = Color.White;
            _Gridview0.AppearancePrint.Row.BorderColor           = Color.FromArgb(216, 216, 216);
            _Gridview0.OptionsPrint.AutoWidth                    = false;
            _Gridview0.OptionsPrint.UsePrintStyles               = true;
        }

        /// <summary>
        /// Método para exportar el contenido de un GridView
        /// </summary>
        /// <param name="_Gridview0">Nombre por default del grid (ejem. gridView1)</param>
        /// <param name="_GridControl">Nombre del GridViewAsignado por el usuario</param>
        void ExportarReporte(GridView _Gridview0, GridControl _GridControl)
        {
            if (_Gridview0.RowCount != 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _GridControl.ExportToXlsx(saveFileDialog1.FileName);
                    Process.Start(saveFileDialog1.FileName);
                }
            }
        }


        #region INGRESOS POR CLIENTE
        /// <summary>
        /// Método para la busqueda de ingresos por cliente a traves de un
        /// filtro de fechas
        /// </summary>
        /// <param name="dtDesde">Fecha de Inicio de Busqueda</param>
        /// <param name="dtHasta">Fecha de Termino de Busqueda</param>
        void CargarIngresosCliente(DateTime dtDesde, DateTime dtHasta)
        {
            grdIngresosCliente.DataSource = new RIngresosCliente().LIngresosCliente(new RIngresosCliente()
            {
                dtFDesde = dtDesde,
                dtFHasta = dtHasta
            });
            //APLICAMOS FORMATO AL GRIDVIEW
            gridView1.BestFitColumns();
            gridView1.Appearance.FooterPanel.Options.UseBackColor   = true;
            gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            gridView1.Appearance.FooterPanel.BackColor              = Color.White;
            gridView1.Appearance.FooterPanel.BackColor2             = Color.White;
            gridView1.Appearance.FooterPanel.BorderColor            = Color.White;
        }

        private void btnBuscarIngrCliente_Click(object sender, EventArgs e)
        {
            CargarIngresosCliente(dtFechaDesde.Value, dtFechaHasta.Value);
        }
        
        public void btnExportarIngrCliente_Click(object sender, EventArgs e)
        {
            ExportarReporte(gridView1, grdIngresosCliente);
        }
        #endregion


        #region COMISIONES POR VENDEDORES
        /// <summary>
        /// Método para realizar busqueda de comisiones pagadas por
        /// vendedores filtrando con rangos de fechas.
        /// </summary>
        /// <param name="dtDesde">Fecha de Inicio de Busqueda</param>
        /// <param name="dtHasta">Fecha de Termino de Busqueda</param>
        void CargarComisiones(DateTime dtDesde, DateTime dtHasta)
        {
            grdComisionesVendedores.DataSource = new RComisionesVendedores().lComisionesVendedores(new RComisionesVendedores()
            {
                dtFechaDesde = dtDesde,
                dtFechaHasta = dtHasta
            });
            //APLICAMOS FORMATO AL GRIDVIEW
            gridView2.BestFitColumns();
            gridView2.Appearance.FooterPanel.Options.UseBackColor   = true;
            gridView2.Appearance.FooterPanel.Options.UseBorderColor = true;
            gridView2.Appearance.FooterPanel.BackColor              = Color.White;
            gridView2.Appearance.FooterPanel.BackColor2             = Color.White;
            gridView2.Appearance.FooterPanel.BorderColor            = Color.White;
        }

        private void btnBuscarComisionesVendedores_Click(object sender, EventArgs e)
        {
            CargarComisiones(dtFechaDesdeCom.Value, dtFechaHastaCom.Value);
        }

        public void btnExportarComisionesVendedores_Click(object sender, EventArgs e)
        {
            ExportarReporte(gridView2, grdComisionesVendedores);
        }
        #endregion

        
        #region BONOS
        void cargarBonos()
        {
            Bono bono = new Bono().LeerPorcentajeBono();
            dPorcentajeBono           = bono.dPorcentajeBono;
            txtPorcentaje.Text        = (dPorcentajeBono).ToString("0.##%");

            //grdBonosPendientes.ForceInitialize();
            gridView2.BestFitColumns();
            gridView2.Appearance.FooterPanel.Options.UseBackColor   = true;
            gridView2.Appearance.FooterPanel.Options.UseBorderColor = true;
            gridView2.Appearance.FooterPanel.BackColor              = Color.White;
            gridView2.Appearance.FooterPanel.BackColor2             = Color.White;
            gridView2.Appearance.FooterPanel.BorderColor            = Color.White;
                    
            gridView2.ExpandAllGroups();
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnGuardarPorcentaje_Click(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(txtPorcentaje.Text, out value))
            {
                //lblPorcentajeActual.Text = String.Format(CultureInfo.CurrentCulture, "{0:P2}", value/100);
                //txtPorcentaje.Text = String.Format(CultureInfo.CurrentCulture, "{0:P2}", value/100);
                if (new Bono().iPorcentajeBono(Convert.ToDecimal(value / 100)) == 1)
                {
                    txtPorcentaje.Text = (value / 100).ToString("0.##%");
                    cargarBonos();

                }
            }
        }

        private void btnCancelarPorcentaje_Click(object sender, EventArgs e)
        {
            pnlParcentaje.Visible = false;
        }           
        #endregion


        #region REMANENTE
        void cargarRemanente()
        {
            try
            { 
                RRemenanente remanente = new RRemenanente();
                remanente   = new RRemenanente().InfoRemanente(int.Parse(cmbxAnioRemanente.Text));
                lblBonosPagados.Text        = string.Format("{0:C}", Decimal.Parse(remanente.dBono.ToString()));
                lblComisionesPagadas.Text   = string.Format("{0:C}", Decimal.Parse(remanente.dComision.ToString()));
                lblRemanente.Text           = string.Format("{0:C}", Decimal.Parse(remanente.dRemanente.ToString()));
            }
            catch
            {

            }
        }

        private void btnBuscarRemanente_Click(object sender, EventArgs e)
        {
            cargarRemanente();
        }

        private void btnExportarRemanente_Click(object sender, EventArgs e)
        {
            if (gridView4.RowCount != 0)
            {
                grdRemanente.DataSource = new RRemenanente().lRemanente(int.Parse(cmbxAnioRemanente.Text));
                ExportarReporte(gridView4, grdRemanente);
            }
        }
        #endregion

    }
}
