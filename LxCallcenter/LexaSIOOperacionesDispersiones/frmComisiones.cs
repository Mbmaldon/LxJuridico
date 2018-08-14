using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC;

using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
using DevExpress.Export;
using System.Globalization;
using LogicaCC.LexaSIOOperLogica;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    public partial class frmComisiones : Form
    {
        FPrincipal _frmPrincipal;
        public frmComisiones()
        {
            InitializeComponent();


            //OBTIENE EL AÑO EN CURSO Y AGREGA AÑOS ANTERIORES
            //for (int i = DateTime.Now.Year - 2; i < DateTime.Now.Year; i++)
            //{
            //    cmbxAño.Items.Add(i);
            //}
            cmbxAño.DataSource    = new OperacionComisionista().lAnios();
            cmbxAño.ValueMember   = "iAnio";
            cmbxAño.DisplayMember = "iAnio";

            cmbxAño.SelectedValue = DateTime.Now.Year;

            //CALCULA EN NÚMERO TOTAL DE SEMANAS DEL AÑO EN CURSO
            cmbxNoSemana.Items.Clear();
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            DateTime date1 = new DateTime(DateTime.Now.Year, 12, 31);
            Calendar cal = dfi.Calendar;
            //LENAMOS EL COMBOBOX CON LOS NÚMEROS DE LAS SEMANAS
            for (int i = 1; i < cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) + 1; i++)
            {
                cmbxNoSemana.Items.Add(i);
            }

            cmbxTipoFactura.DataSource      = new TipoFactura().lTipoFacturas();
            cmbxTipoFactura.DisplayMember   = "sTipoFactura";
            cmbxTipoFactura.ValueMember     = "iIdTipoFactura";
            

            //CALCULAR EL NÚMERO DE SEMANA EN CURSO
            CultureInfo _CultureInfo = new CultureInfo("en-US");
            Calendar _Calendar = _CultureInfo.Calendar;
            CalendarWeekRule _CalendarWeekRule = _CultureInfo.DateTimeFormat.CalendarWeekRule;
            DayOfWeek _DayOfWeek = _CultureInfo.DateTimeFormat.FirstDayOfWeek;
            //cargarComisionitas(_Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek) - 1, int.Parse(cmbxTipoFactura.SelectedValue.ToString()), 1, DateTime.Now.Year);
            cargarComisionitas(_Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek) - 1, 2, 1, DateTime.Now.Year);

            cmbxNoSemana.SelectedIndex    = cmbxNoSemana.FindString((_Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek) - 1).ToString());
            cmbxTipoFactura.SelectedIndex = 1;



            //ASIGNA FORMATO AL DOCUMENTO EXPORTADO DESDE EL GRIDVIEW DE DEVEXPRESS
            ExportSettings.DefaultExportType                    = ExportType.WYSIWYG;
            gridView1.AppearancePrint.HeaderPanel.BackColor     = Color.FromArgb(0, 20, 137);
            gridView1.AppearancePrint.HeaderPanel.ForeColor     = Color.White;
            gridView1.AppearancePrint.HeaderPanel.BorderColor   = Color.FromArgb(0, 20, 137);
            gridView1.AppearancePrint.FooterPanel.BackColor     = Color.White;
            gridView1.AppearancePrint.FooterPanel.BorderColor   = Color.White;
            //gridView1.AppearancePrint.GroupRow.BorderColor    = Color.FromArgb(216, 216, 216);
            gridView1.AppearancePrint.Row.BorderColor           = Color.FromArgb(216, 216, 216);
            gridView1.OptionsPrint.AutoWidth                    = false;
            gridView1.OptionsPrint.UsePrintStyles               = true;

            _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;
            _frmPrincipal.btnVerDetallesFactura.Enabled          = true;
            _frmPrincipal.btnExportarConcentradoFacturas.Enabled = true;
        }

        private void frmComisiones_Load(object sender, EventArgs e)
        {
        }

        public void cargarComisionitas(int iNoSemana, int iIdTipoFactura, int iEstado, int iAnio)
        {
            //CARGAMOS COMISIONES EN EL GRIDVIEW
            grdComisionistas.DataSource = null;
            grdComisionistas.DataSource = new LogicaCC.LexaSIOOperLogica.OperacionComisionista().ListaComisionistas(iNoSemana, iIdTipoFactura, iEstado, iAnio);
            gridView1.BestFitColumns();
            gridView1.Appearance.FooterPanel.Options.UseBackColor   = true;
            gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            gridView1.Appearance.FooterPanel.BackColor              = Color.White;
            gridView1.Appearance.FooterPanel.BackColor2             = Color.White;
            gridView1.Appearance.FooterPanel.BorderColor            = Color.White;

            gridView1.ExpandAllGroups();

            //CALCULAR EL NÚMERO DE SEMANA EN CURSO
            CultureInfo _CultureInfo = new CultureInfo("en-US");
            Calendar _Calendar = _CultureInfo.Calendar;
            CalendarWeekRule _CalendarWeekRule = _CultureInfo.DateTimeFormat.CalendarWeekRule;
            DayOfWeek _DayOfWeek = _CultureInfo.DateTimeFormat.FirstDayOfWeek;
            lblNoSemana.Text = _Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek).ToString();

            //TOMA LOS TOTALES DE LAS COLUMNAS Y LOS ASIGNA A LAS VARIABLES
            try
            {
                ////CALCULA EN NÚMERO TOTAL DE SEMANAS DEL AÑO EN CURSO
                //cmbxNoSemana.Items.Clear();
                //DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                //DateTime date1 = new DateTime(DateTime.Now.Year, 12, 31);
                //Calendar cal = dfi.Calendar;
                ////LENAMOS EL COMBOBOX CON LOS NÚMEROS DE LAS SEMANAS
                //for (int i = 1; i < cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) + 1; i++)
                //{
                //    cmbxNoSemana.Items.Add(i);
                //}
                if (gridView1.RowCount > 0)
                {
                    lblTotalIngresos.Text = string.Format("{0:C}", Decimal.Parse(gridView1.Columns["dTotal"].SummaryItem.SummaryValue.ToString()));
                    lblImporteRepartidoAlimentos.Text = string.Format("{0:C}", Decimal.Parse(gridView1.Columns["dImporte"].SummaryItem.SummaryValue.ToString()));
                }
                //lblNoSemana.Text = cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek).ToString();
                //lblComisionesVenta.Text             = string.Format("{0:C}", Decimal.Parse(gridView1.Columns["dComisionGlobalVenta"].SummaryItem.SummaryValue.ToString()));
                //lblDevPuntos.Text                   = string.Format("{0:C}", Decimal.Parse(gridView1.Columns["dBeneficio"].SummaryItem.SummaryValue.ToString()));
                //lblComisionNivel0.Text              = string.Format("{0:C}", Decimal.Parse(gridView1.Columns["dComisionNivel0"].SummaryItem.SummaryValue.ToString()));
                //lblComisionNivel1.Text              = string.Format("{0:C}", Decimal.Parse(gridView1.Columns["dComisionNivel1"].SummaryItem.SummaryValue.ToString()));
                //lblComisionNivel2.Text              = string.Format("{0:C}", Decimal.Parse(gridView1.Columns["dComisionNivel2"].SummaryItem.SummaryValue.ToString()));
                //lblComisionNivel3.Text              = string.Format("{0:C}", Decimal.Parse(gridView1.Columns["dComisionNivel3"].SummaryItem.SummaryValue.ToString()));
                //lblImporteNegocio.Text              = string.Format("{0:C}", Decimal.Parse(gridView1.Columns["dImporteNegocio"].SummaryItem.SummaryValue.ToString()));
                //cmbxNoSemana.SelectedIndex = cmbxNoSemana.FindString((_Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek) - 1).ToString());
            }
            catch
            {

            }
        }

        public void btnExportar_Click(object sender, EventArgs e)
        {
            //EXPORTA EL CONTENIDO DEL GRIDVIEW A UNA HOJA DE CALCULO
            if (gridView1.RowCount != 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    grdComisionistas.ExportToXlsx(saveFileDialog1.FileName);
                    Process.Start(saveFileDialog1.FileName);
                }
            }
        }

        public List<LogicaCC.LexaSIOOperLogica.Comision> comisiones;
        public void btnMostrarPagadas_Click(object sender, EventArgs e)
        {
            _frmPrincipal.btnVerDetallesFactura.Enabled          = false;
            _frmPrincipal.btnExportarConcentradoFacturas.Enabled = false;
            btnMostrarPagadas.Enabled   = false;
            btnExportar.Enabled         = false;
            grdComisionistas.Enabled    = false;
            pblImportes.Enabled         = false;
            txtBuscar.Enabled           = false;
            label1.Enabled              = false;
            pnlComisiones.Controls.Clear();
            pnlPagoComisiones.Visible   = true;

            var rowHandle   = gridView1.FocusedRowHandle;
            var c1          = gridView1.GetRowCellValue(rowHandle, "iIdOperacion");
            var c2          = gridView1.GetRowCellValue(rowHandle, "PorcentajeTotal");

            //LSOSPS_Seleccionar_Operacion

            LogicaCC.LexaSIOOperLogica.OperacionComisionista Operacion = new LogicaCC.LexaSIOOperLogica.OperacionComisionista().OperacionInf(new LogicaCC.LexaSIOOperLogica.OperacionComisionista()
            {
                iIdOperacion = int.Parse(c1.ToString())
            });
            lblCliente.Name         = Operacion.iIdCliente.ToString();
            lblNoOperacion.Name     = c1.ToString();
            lblNoFactura.Text       = Operacion.sNoFactura;
            lblImporteTotal.Text    = string.Format("{0:C}", Operacion.dImporte + (Operacion.dImporte * decimal.Parse("0.16")));
            lblCliente.Text         = Operacion.sNombre;
            //CARGA FECHA FACTURA
            if (!string.IsNullOrEmpty(Operacion.sFechaFactura))
            {
                dtFechaFactura.Value = DateTime.Parse(Operacion.sFechaFactura);
                dtFechaFactura.Enabled = false;
                dtFechaFactura.Visible = true;
            }
            else
            {
                dtFechaFactura.Value = DateTime.Now;
                //dtFechaFactura.Enabled = true;
                dtFechaFactura.Visible = false;
            }
            //CARGA FECHA DEPOSITO
            if (!string.IsNullOrEmpty(Operacion.sFechaDeposito))
            {
                dtFechaDeposito.Value = DateTime.Parse(Operacion.sFechaDeposito);
                dtFechaDeposito.Enabled = false;
                dtFechaDeposito.Visible = true;
            }
            else
            {
                dtFechaDeposito.Value = DateTime.Now;
                //dtFechaDeposito.Enabled = true;
                dtFechaDeposito.Visible = false;
            }
            ////ACTIVAR BOTON DE ACUERDO AL ESTADO DE LA FACTURA
            //if (!string.IsNullOrEmpty(Operacion.sFechaDeposito))
            //{
            //    btnFacturaPagada.Visible = false;
            //    //lnkCancelarFactura.Visible = false;
            //}
            //else
            //{
            //    btnFacturaPagada.Visible = true;
            //    //lnkCancelarFactura.Visible = true;
            //}
            btnFacturaPagada.Visible = false;




            Comision comision = new Comision();
            comisiones = comision.listaComisiones(int.Parse(c1.ToString()));
            for (int i = 0; i < comisiones.Count; i++)
            {
                //CREAMOS CONTROLES
                Panel  pnlComision                              = new Panel();
                PictureBox ptbMarca                             = new PictureBox();
                MetroFramework.Controls.MetroLink lnkComision   = new MetroFramework.Controls.MetroLink();
                Label  lblNombre                                = new Label();
                Label  lblNoOperacion                           = new Label();
                Label  lblImporte                               = new Label();
                Panel  pnlLinea                                 = new Panel();


                //PANEL
                pnlComision.Location    = new Point(10, 70 * i + 10);
                pnlComision.Name        = comisiones[i].iIdOperacionComisionista.ToString();
                pnlComision.Width       = 480;
                pnlComision.Height      = 65;
                //pnlComision.BackColor = Color.Gray;
                //IMAGEN: MARCA
                ptbMarca.Image          = Properties.Resources.Check_01;
                ptbMarca.Location       = new Point(0, 16);
                ptbMarca.SizeMode       = PictureBoxSizeMode.AutoSize;
                //LABEL: NOMBRE
                lblNombre.Location      = new Point(15, 10);
                //lblNombre.Text          = comisiones[i].sNombreComisionista.ToString();
                lblNombre.Text          = comisiones[i].sNombreComisionista;
                lblNombre.Font          = new Font("Segoe UI", 13);
                lblNombre.AutoSize      = true;
                //LABEL: NOOPERACION
                lblNoOperacion.Location = new Point(18, 33);
                lblNoOperacion.Text     = "Operación No. " + comisiones[i].sNoOperacion.ToString();
                lblNoOperacion.Font     = new Font("Segoe UI", 9);
                lblNoOperacion.AutoSize = true;
                //LABEL: IMPORTE
                lblImporte.Location     = new Point(300, 18);
                //lblImporte.Text         = String.Format("{0:C}", comisiones[i].dImporte);
                if(comisiones[i].iIdTipoUsuario == 20010)
                    lblImporte.Text         = String.Format("{0:C}", (Operacion.dImporte + (Operacion.dImporte * decimal.Parse("0.16")) ) * decimal.Parse(c2.ToString()));
                else
                    lblImporte.Text = String.Format("{0:C}", (Operacion.dImporte + (Operacion.dImporte * decimal.Parse("0.16"))) * decimal.Parse("0.01"));
                lblImporte.Font         = new Font("Segoe UI", 15);
                //lblImporte.AutoSize   = true;
                lblImporte.TextAlign    = ContentAlignment.MiddleRight;
                lblImporte.Width        = 170;
                lblImporte.Height       = 28;
                //lblImporte.BackColor  = Color.Gray;
                //LINK: PAGAR
                //lnkComision.Location  = new Point(118, 35);
                //lnkComision.Location  = new Point(305, 45);
                lnkComision.Name        = comisiones[i].iIdOperacionComisionista.ToString();
                lnkComision.Location    = new Point(18, 48);
                lnkComision.Text        = "Marcar como pagada";
                lnkComision.Width       = 125;
                lnkComision.Height      = 16;
                lnkComision.TextAlign   = ContentAlignment.TopLeft;
                lnkComision.ForeColor   = Color.FromArgb(0, 176, 240);
                lnkComision.Cursor      = Cursors.Hand;
                lnkComision.Click += LnkComision_Click;           
                //PANEL: LINEA
                pnlLinea.BackColor      = Color.FromArgb(225, 225, 225);
                pnlLinea.Location       = new Point(50, 64);
                pnlLinea.Width          = 380;
                pnlLinea.Height         = 1;

                if (comisiones[i].bPagada)
                    pnlComision.Controls.Add(ptbMarca);
                pnlComision.Controls.Add(lblNombre);
                pnlComision.Controls.Add(lblNoOperacion);
                pnlComision.Controls.Add(lblImporte);
                //if(!comisiones[i].bPagada)
                //    pnlComision.Controls.Add(lnkComision);
                pnlComision.Controls.Add(pnlLinea);
                pnlComisiones.Controls.Add(pnlComision);
            }



        }

        private void LnkComision_Click(object sender, EventArgs e)
        {
            //CAMBIA EL ESTADO DE PAGO DE UNA COMISIÓN Y ACTUALIZA LA LISTA DE COMISIONES PARA REFLEJAR LOS CAMBIOS
            MetroFramework.Controls.MetroLink Link = sender as MetroFramework.Controls.MetroLink;
            if(FlatMessageBox.Show("¿Está seguro de cambiar el estado de pago de esta comisión?", "SI", "NO", FlatMessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Comision comision = new Comision();
                new Comision().marcarPagada(int.Parse(Link.Name));
                btnMostrarPagadas_Click(sender, e);
            }
        }

        private void lnkCerrarPagoComisiones_Click(object sender, EventArgs e)
        {
            pnlPagoComisiones.Visible   = false;
            _frmPrincipal.btnVerDetallesFactura.Enabled          = true;
            _frmPrincipal.btnExportarConcentradoFacturas.Enabled = true;
            btnExportar.Enabled         = true;
            grdComisionistas.Enabled    = true;
            pblImportes.Enabled         = true;
            btnMostrarPagadas.Enabled   = true;
            txtBuscar.Enabled           = true;
            label1.Enabled              = true;
        }

        private void cmbxNoSemana_SelectedIndexChanged(object sender, EventArgs e)
        {            
            //MessageBox.Show(cmbxNoSemana.Text);
            cargarComisionitas(int.Parse(cmbxNoSemana.Text), 2, 1, int.Parse(cmbxAño.SelectedValue.ToString()));
        }

        private void btnFacturaPagada_Click(object sender, EventArgs e)
        {
            if(FlatMessageBox.Show("¿Está seguro de cambiar el estado de pago de esta factura?", "SI", "NO", FlatMessageBoxIcon.Warning) == DialogResult.Yes)
            { 
                if(new Operacion().bPagarFactura(new Operacion()
                {
                    iIdOperacion    = int.Parse(lblNoOperacion.Name),
                    iIdVendedor     = int.Parse(lblCliente.Name),
                    dFechaFactura   = dtFechaFactura.Value,
                    dFechaPago      = dtFechaDeposito.Value,
                    iNoSemana       = int.Parse(cmbxNoSemana.Text)
                }) == true)
                {
                    btnFacturaPagada.Visible = false;
                    dtFechaFactura.Enabled   = false;
                    dtFechaDeposito.Enabled  = false;

                    var rowHandle = gridView1.FocusedRowHandle;
                    gridView1.SetRowCellValue(rowHandle, "sFechaFactura", dtFechaFactura.Value);
                    gridView1.SetRowCellValue(rowHandle, "sFechaDeposito", dtFechaDeposito.Value);


                    FlatMessageBox.Show("Factura pagada correctamente", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
                    
                }
                else
                    FlatMessageBox.Show("No se pudo cambiar el estado de pago de esta factura, ya que existe una factura anterior, no pagada.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            gridView1.ActiveFilterCriteria = new DevExpress.Data.Filtering.BinaryOperator(new DevExpress.Data.Filtering.OperandProperty("sNoFactura"), new DevExpress.Data.Filtering.OperandValue("%" + txtBuscar.Text + "%"), DevExpress.Data.Filtering.BinaryOperatorType.Like);
            gridView1.ExpandAllGroups();
        }

        private void cmbxTipoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    cargarComisionitas(int.Parse(cmbxNoSemana.Text), int.Parse(cmbxTipoFactura.SelectedValue.ToString()), 1, int.Parse(cmbxAño.SelectedValue.ToString()));
            //}
            //catch
            //{
            //    //CALCULAR EL NÚMERO DE SEMANA EN CURSO
            //    CultureInfo _CultureInfo = new CultureInfo("en-US");
            //    Calendar _Calendar = _CultureInfo.Calendar;
            //    CalendarWeekRule _CalendarWeekRule = _CultureInfo.DateTimeFormat.CalendarWeekRule;
            //    DayOfWeek _DayOfWeek = _CultureInfo.DateTimeFormat.FirstDayOfWeek;

            //    cargarComisionitas(_Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek) - 1, int.Parse("1"), 1, int.Parse(cmbxAño.SelectedValue.ToString()));
            //}
        }

        private void lnkCancelarFactura_Click(object sender, EventArgs e)
        {
            //if(MessageBox.Show("¿Está seguro de cancelar esta factura?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            if (FlatMessageBox.Show("¿Está seguro de cancelar esta factura?", "SI", "NO", FlatMessageBoxIcon.Warning) == DialogResult.Yes)
            {
                pnlComentario.Visible           = true;
                panel2.Enabled                  = false;
                dtFechaDeposito.Enabled         = false;
                dtFechaFactura.Enabled          = false;
                lnkCerrarPagoComisiones.Enabled = false;
                label12.Enabled                 = false;
                lblNoFactura.Enabled            = false;
                label16.Enabled                 = false;
                lblImporteTotal.Enabled         = false;
                label18.Enabled                 = false;
                label17.Enabled                 = false;
                btnFacturaPagada.Enabled        = false;
                lblNoOperacion.Enabled          = false;
                txtComentario.Focus();           
            }
        }

        private void btnCancelarCanFac_Click(object sender, EventArgs e)
        {
            pnlComentario.Visible           = false;
            panel2.Enabled                  = true;
            dtFechaDeposito.Enabled         = true;
            dtFechaFactura.Enabled          = true;
            lnkCerrarPagoComisiones.Enabled = true;
            label12.Enabled                 = true;
            lblNoFactura.Enabled            = true;
            label16.Enabled                 = true;
            lblImporteTotal.Enabled         = true;
            label18.Enabled                 = true;
            label17.Enabled                 = true;
            btnFacturaPagada.Enabled        = true;
            lblNoOperacion.Enabled          = true;
            txtComentario.Text              = string.Empty;
        }

        private void btnCancelarFactura_Click(object sender, EventArgs e)
        {
            if(FlatMessageBox.Show("¿Está seguro de cancelar esta factura?", "SI", "NO", FlatMessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (new Operacion().bCancelarFactura(new Operacion()
                {
                    iIdOperacion  = int.Parse(lblNoOperacion.Name),
                    sComentario   = txtComentario.Text
                }) == true)
                {
                    cargarComisionitas(int.Parse(cmbxNoSemana.Text), 2, 1, int.Parse(cmbxAño.SelectedValue.ToString()));
                    FlatMessageBox.Show("Factura cancelada correctamente.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
                    lnkCerrarPagoComisiones_Click(sender, e);
                    btnCancelarCanFac_Click(sender, e);
                }             
            }
        }

        private void cmbxEstadoFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComisionitas(int.Parse(cmbxNoSemana.Text), 2, 1, int.Parse(cmbxAño.SelectedValue.ToString()));
            if (cmbxEstadoFac.Text == "Activas")
                btnMostrarPagadas.Visible = true;
            else
                btnMostrarPagadas.Visible = false;
        }

        private void cmbxAño_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //CALCULA EN NÚMERO TOTAL DE SEMANAS DEL AÑO EN CURSO
            cmbxNoSemana.Items.Clear();
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            DateTime date1         = new DateTime(int.Parse(cmbxAño.SelectedValue.ToString()), 12, 31);
            Calendar cal           = dfi.Calendar;
            //LENAMOS EL COMBOBOX CON LOS NÚMEROS DE LAS SEMANAS
            for (int i = 1; i < cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) + 1; i++)
            {
                cmbxNoSemana.Items.Add(i);
            }

            grdComisionistas.DataSource = null;
        }
    }
}
