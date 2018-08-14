using DevExpress.Export;
using LogicaCC.LexaSIOOperLogica;
using LogicaCC.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    public partial class frmComisionesPago : Form
    {
        UsuarioData AUsuario;
        //decimal dPorcentajeBono = 0;
        FPrincipal _frmPrincipal;
        public frmComisionesPago()
        {
            InitializeComponent();
            AUsuario = UsuarioData.Instancia;


            //ASIGNA FORMATO AL DOCUMENTO EXPORTADO DESDE EL GRIDVIEW DE DEVEXPRESS
            ExportSettings.DefaultExportType                    = ExportType.WYSIWYG;
            gridView1.AppearancePrint.HeaderPanel.BackColor     = Color.FromArgb(7, 22, 127);
            gridView1.AppearancePrint.HeaderPanel.ForeColor     = Color.White;
            gridView1.AppearancePrint.HeaderPanel.BorderColor   = Color.FromArgb(7, 22, 127);
            gridView1.AppearancePrint.FooterPanel.BackColor     = Color.White;
            gridView1.AppearancePrint.FooterPanel.BorderColor   = Color.White;
            gridView1.AppearancePrint.Row.BorderColor           = Color.FromArgb(216, 216, 216);
            gridView1.OptionsPrint.AutoWidth                    = false;
            gridView1.OptionsPrint.UsePrintStyles               = true;

            _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;
            _frmPrincipal.btnExportarConcentradoComisiones.Enabled = true;
            //_frmPrincipal.btnPagarComisionSel.Enabled              = true;
            //_frmPrincipal.btnPagarComisionesTod.Enabled            = true;
        }

        private void frmComisionesPago_Load(object sender, EventArgs e)
        {
            cargarControles();
        }


        void cargarControles()
        {
            cmbxAño.DataSource    = new ComisionVendedor().lAnios();
            cmbxAño.ValueMember   = "iAnio";
            cmbxAño.DisplayMember = "iAnio";
            cmbxAño.SelectedValue = DateTime.Now.Year;

            cmbxMostrar.SelectedIndex = 0;
            //CALCULA EN NÚMERO TOTAL DE SEMANAS DEL AÑO EN CURSO
            cmbxNoSemana.Items.Clear();
            DateTimeFormatInfo dfi  = DateTimeFormatInfo.CurrentInfo;
            DateTime date1          = new DateTime(DateTime.Now.Year, 12, 31);
            Calendar cal            = dfi.Calendar;
            //LENAMOS EL COMBOBOX CON LOS NÚMEROS DE LAS SEMANAS
            for (int i = 1; i < cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) + 1; i++)
            {
                cmbxNoSemana.Items.Add(i);
            }

            //CALCULAR EL NÚMERO DE SEMANA EN CURSO
            CultureInfo _CultureInfo           = new CultureInfo("en-US");
            Calendar _Calendar                 = _CultureInfo.Calendar;
            CalendarWeekRule _CalendarWeekRule = _CultureInfo.DateTimeFormat.CalendarWeekRule;
            DayOfWeek _DayOfWeek               = _CultureInfo.DateTimeFormat.FirstDayOfWeek;
            cargarComisionistas(_Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek) - 1, DateTime.Now.Year);

            lblNoSemana.Text            = _Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek).ToString();
            cmbxNoSemana.SelectedIndex  = cmbxNoSemana.FindString((_Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek) - 1).ToString());
        }



        void cargarComisionistas(int iNoSemana, int iAnio)
        {
            //CARGAMOS COMISIONES EN EL GRIDVIEW
            grdComisionistas.DataSource = null;
            grdComisionistas.DataSource = new ComisionVendedor().lComisionesVendedores(iNoSemana, iAnio);
            gridView1.BestFitColumns();
            gridView1.Appearance.FooterPanel.Options.UseBackColor   = true;
            gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            gridView1.Appearance.FooterPanel.BackColor              = Color.White;
            gridView1.Appearance.FooterPanel.BackColor2             = Color.White;
            gridView1.Appearance.FooterPanel.BorderColor            = Color.White;

            gridView1.ExpandAllGroups();


            //TOMA LOS TOTALES DE LAS COLUMNAS Y LOS ASIGNA A LAS VARIABLES
            try
            {
                //CALCULAR EL NÚMERO DE SEMANA EN CURSO
                CultureInfo _CultureInfo = new CultureInfo("en-US");
                Calendar _Calendar = _CultureInfo.Calendar;
                CalendarWeekRule _CalendarWeekRule = _CultureInfo.DateTimeFormat.CalendarWeekRule;
                DayOfWeek _DayOfWeek = _CultureInfo.DateTimeFormat.FirstDayOfWeek;



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
                    //lblTotalImporte.Text  = string.Format("{0:C}", Decimal.Parse(gridView1.Columns["dImporte"].SummaryItem.SummaryValue.ToString()));
                    lblTotalComision.Text = string.Format("{0:C}", Decimal.Parse(gridView1.Columns["dComision"].SummaryItem.SummaryValue.ToString()));
                }
                /////////lblNoSemana.Text                    = _Calendar.GetWeekOfYear(DateTime.Now, _CalendarWeekRule, _DayOfWeek).ToString();

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
                //lblTotalImporte.Text  = "$ --";
                lblTotalComision.Text = "$ --";
            }
        }

        void estadoControles(bool bEstado)
        {
            label95.Enabled          = bEstado;
            lblTotalImporte.Enabled  = bEstado;
            label2.Enabled           = bEstado;
            lblTotalComision.Enabled = bEstado;
            label7.Enabled           = bEstado;
            lblNoSemana.Enabled      = bEstado;
            label5.Enabled           = bEstado;
            cmbxNoSemana.Enabled     = bEstado;
            label11.Enabled          = bEstado;
            cmbxMostrar.Enabled      = bEstado;
			cmbxAño.Enabled			 = bEstado;
        }

        public void btnMostrarPagadas_Click(object sender, EventArgs e)
        {
            try
            {
                btnMostrarPagadas.Enabled   = false;
                btnExportar.Enabled         = false;
                grdComisionistas.Enabled    = false;                
                txtBuscar.Enabled           = false;
                label1.Enabled              = false;
                estadoControles(false);

                _frmPrincipal.btnExportarConcentradoComisiones.Enabled = false;
                //_frmPrincipal.btnPagarComisionSel.Enabled              = false;
                //_frmPrincipal.btnPagarComisionesTod.Enabled            = false;

                var rowHandle = gridView1.FocusedRowHandle;

                lblVendedor.Text        = gridView1.GetRowCellValue(rowHandle, "sNombreVendedor").ToString();
                lblNoFactura.Text       = gridView1.GetRowCellValue(rowHandle, "sNoFactura").ToString();
                lblImporteTotal.Text    = string.Format("{0:C}", Decimal.Parse(gridView1.GetRowCellValue(rowHandle, "dComision").ToString()));

                if (gridView1.GetRowCellValue(rowHandle, "sFacturaPagada").ToString() == "0")
                {
                    btnComisionPagada.Visible = false;
                }
                else
                {
                    if (gridView1.GetRowCellValue(rowHandle, "sPagado").ToString() == "False")
                    {
                        //if (int.Parse(lblNoSemana.Text) > int.Parse(cmbxNoSemana.Text))
                            btnComisionPagada.Visible = true;
                        //else
                        //    btnComisionPagada.Visible = false;
                    }
                    else
                    {
                        btnComisionPagada.Visible       = false;
                        txtNoOperacionBancaria.Enabled  = false;
                        txtNoOperacionBancaria.Text     = gridView1.GetRowCellValue(rowHandle, "sNoOperacionBancaria").ToString();//sNoOperacionBancaria
                    }
                }

                pnlPagoComisiones.Visible = true;
            }
            catch
            {
                btnMostrarPagadas.Enabled   = true;
                btnExportar.Enabled         = true;
                grdComisionistas.Enabled    = true;
            }
        }

        private void lnkCerrarPagoComisiones_Click(object sender, EventArgs e)
        {
            pnlPagoComisiones.Visible      = false;
            estadoControles(true);
            btnExportar.Enabled            = true;
            grdComisionistas.Enabled       = true;
            btnMostrarPagadas.Enabled      = true;
            txtNoOperacionBancaria.Enabled = true;
            txtBuscar.Enabled              = true;
            label1.Enabled                 = true;
            _frmPrincipal.btnExportarConcentradoComisiones.Enabled = true;
            //_frmPrincipal.btnPagarComisionSel.Enabled              = true;
            //_frmPrincipal.btnPagarComisionesTod.Enabled            = true;
            txtNoOperacionBancaria.Clear();
        }

        private void btnComisionPagada_Click(object sender, EventArgs e)
        {
            if (FlatMessageBox.Show("¿Está seguro de cambiar el estado de pago de esta comisión?", "SI", "CANCELAR", FlatMessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var rowHandle = gridView1.FocusedRowHandle;
                if (new ComisionVendedor().bPagarComision(new ComisionVendedor()
                {
                    iIdOperacionComisionista = int.Parse(gridView1.GetRowCellValue(rowHandle, "iIdOperacionComisionista").ToString()),
                    sNoOperacionBancaria     = string.Empty,
                    dComisionF               = Decimal.Parse(gridView1.GetRowCellValue(rowHandle, "dComision").ToString()),
                    sFechaPago               = dtFechaFactura.Value.ToString()
                }) == true)
                {
                    btnComisionPagada.Visible       = false;
                    dtFechaFactura.Enabled          = false;
                    txtNoOperacionBancaria.Enabled  = false;
                    gridView1.SetRowCellValue(rowHandle, "sPagado", "True");
                    gridView1.SetRowCellValue(rowHandle, "sNoOperacionBancaria", txtNoOperacionBancaria.Text);
                    gridView1.SetRowCellValue(rowHandle, "sFechaPago", dtFechaFactura.Value);
                    FlatMessageBox.Show("Estado de Pago cambiado con exito.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
                }
                else
                    FlatMessageBox.Show("No se Pudo Cambiar el Estado de Pago.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            gridView1.ActiveFilterCriteria = new DevExpress.Data.Filtering.BinaryOperator(new DevExpress.Data.Filtering.OperandProperty("sNombreVendedor"), new DevExpress.Data.Filtering.OperandValue("%" + txtBuscar.Text + "%"), DevExpress.Data.Filtering.BinaryOperatorType.Like);
            gridView1.ExpandAllGroups();
        }      

        public void btnExportar_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount != 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    DevExpress.XtraPrinting.XlsxExportOptions options = new DevExpress.XtraPrinting.XlsxExportOptions();
                    options.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;

                    grdComisionistas.ExportToXlsx(saveFileDialog1.FileName, options);
                    Process.Start(saveFileDialog1.FileName);
                }
            }
        }


        private void btnCancelarPorcentaje_Click(object sender, EventArgs e)
        {
            pnlParcentaje.Visible = false;
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
                }
            }
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private Point MouseDownLocation;

        private void pnlPagoComisiones_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void pnlPagoComisiones_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pnlPagoComisiones.Left = e.X + pnlPagoComisiones.Left - MouseDownLocation.X;
                pnlPagoComisiones.Top = e.Y + pnlPagoComisiones.Top - MouseDownLocation.Y;
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView View = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (e.Column.FieldName == "sComPagada")
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["sComPagada"]);
                if (category == "Si")
                {
                    e.Appearance.BackColor = Color.White;
                    e.Appearance.BackColor2 = Color.Green;
                }
                else
                {
                    e.Appearance.BackColor = Color.White;
                    e.Appearance.BackColor2 = Color.Maroon;
                }
            }
        }

        private void cmbxMostrar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cmbxMostrar.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Todos");
                    break;
                case 1:
                    MessageBox.Show("Vendedores");
                    break;
                case 2:
                    MessageBox.Show("Supervisores");
                    break;
                case 3:
                    MessageBox.Show("Gerentes");
                    break;
            }
        }

        private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            gridView1.ExpandAllGroups();
        }

        public void btnPagarTodas_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("¿Está seguro de cambiar el estado de pago de las comisiones?, solo se cambiaran las que se muestran actualmente.", "Pagar Comisiones", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            if (FlatMessageBox.Show("¿Desea cambiar el estado de pago de las comisiones?" + Environment.NewLine + "Solo se cambiaran las que se muestran actualmente.", "SI", "NO", FlatMessageBoxIcon.Warning) == DialogResult.Yes)
            { 
                string sNoPagadas = string.Empty;
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    //DataRow row = gridView1.GetDataRow(i);
                    //string name = row["Importe"].ToString();
                    //string name = string.Format("Comisión: {0}{1}Importe: {2}{1}NoOperación: {3}", Convert.ToString(gridView1.GetRowCellValue(i, "iIdOperacionComisionista")), Environment.NewLine, Convert.ToString(gridView1.GetRowCellValue(i, "dImporte")), Convert.ToString(gridView1.GetRowCellValue(i, "sNoOperacionBancaria")));
                    //MessageBox.Show(name);

                    if (new ComisionVendedor().bPagarComision(new ComisionVendedor()
                    {
                        iIdOperacionComisionista = int.Parse(gridView1.GetRowCellValue(i, "iIdOperacionComisionista").ToString()),
                        sNoOperacionBancaria = string.Empty,
                        dComisionF = decimal.Parse(gridView1.GetRowCellValue(i, "dComision").ToString()),
                        sFechaPago = DateTime.Now.ToString()
                    }) == false)
                    {
                        sNoPagadas = sNoPagadas + Convert.ToString(gridView1.GetRowCellValue(i, "sNoFactura")) + Environment.NewLine;
                    }

                }

                cmbxNoSemana_SelectionChangeCommitted(sender, e);
                if (string.IsNullOrEmpty(sNoPagadas))
                    FlatMessageBox.Show("Todas las comisiones fueran cambiadas a pagadas exitosamente.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
                else
                    FlatMessageBox.Show(string.Format("Cambio terminado, no se pudo cambiar el estado{0}de pago de algunas comisiones.{0}{1}", Environment.NewLine, sNoPagadas), "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
            }
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

        private void cmbxNoSemana_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (int.Parse(lblNoSemana.Text) > int.Parse(cmbxNoSemana.Text))
            {
                btnPagarTodas.Visible = true;
                btnMostrarPagadas.Visible = true;
            }
            else
            {
                btnPagarTodas.Visible = false;
                btnMostrarPagadas.Visible = false;
            }
            cargarComisionistas(int.Parse(cmbxNoSemana.Text), int.Parse(cmbxAño.SelectedValue.ToString()));
        }
    }
}
