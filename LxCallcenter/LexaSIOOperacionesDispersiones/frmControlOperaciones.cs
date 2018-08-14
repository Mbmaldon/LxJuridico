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
using MetroFramework.Controls;
using LogicaCC.LexaSIOOperLogica;
using System.IO;
using System.Net;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    public partial class frmControlOperaciones : Form
    {
        //NetworkCredential _NetworkCredential = new NetworkCredential(ServerFile.sUser, ServerFile.sPassword);
        //string PathFolderShared = @"\\192.168.1.34\Documentos\" + LogicaCC.ConnectionString.FolderConnection + @"\Fotos";
        public frmControlOperaciones()
        {
            InitializeComponent();

            //cmbxTipoFactura
            //CARGAMOS LOS NIVELES
            cmbxTipoFactura.DataSource      = new TipoFactura().lTipoFacturas();
            cmbxTipoFactura.DisplayMember   = "sTipoFactura";
            cmbxTipoFactura.ValueMember     = "iIdTipoFactura";
            cmbxTipoFactura.SelectedIndex   = 1;


        }

        VendedorBusqueda vendedor = new VendedorBusqueda();

        decimal dImporteRepartirAlimentos   = 0;
        decimal dIVA                        = 0;
        decimal dTotal                      = 0;

        //IMPORTE DE LA FACTURA (IF)
        decimal dIngresoAlimentosIF     = 0;
        decimal dIvaIF                  = 0;
        decimal dTotalIF                = 0;


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!(txtIdVendedor.Text == string.Empty))
            {                
                vendedor = new VendedorBusqueda().busquedaVendedor(txtIdVendedor.Text);

                if(!(vendedor == null))
                {
                    lblMensajeError.Visible                 = false;
                    txtNombreVendedor.Text                  = vendedor.sNombreCliente;
                    txtVendedor.Text                        = vendedor.sNombreVendedor;
                    //asignarFotografia(vendedor.iIdCliente);
                    


                    //CREA DIAGNOSTICO
                    //if (!System.IO.File.Exists(string.Format(@"\\192.169.143.34\MiPyme_Files\Documentos\Diagnosticos\{0}.pdf", txtIdVendedor.Text)))
                    //    new Diagnostico().CrearDiagnostico(txtIdVendedor.Text);
                }
                else
                {
                    lblMensajeError.Visible = true;
                    txtNombreVendedor.Clear();
                    txtVendedor.Clear();
                    txtNoOperacion.Clear();
                    txtNoFactura.Clear();
                    txtImporteRepartirAlimentos.Text    = "$0.00";
                    txtIva.Text                         = "$0.00";
                    txtTotal.Text                       = "$0.00";
                    asignarFotografia(-1);
                }
            }
        }

        void asignarFotografia(int iIdCliente)
        {
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
            //    if (File.Exists(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.jpg", iIdCliente)))
            //    {
            //        ovalPictureBox1.Load(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.jpg", iIdCliente));
            //    }
            //    else if (File.Exists(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.JPG", iIdCliente)))
            //    {
            //        ovalPictureBox1.Load(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.JPG", iIdCliente));
            //    }
            //    else if (File.Exists(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.jpeg", iIdCliente)))
            //    {
            //        ovalPictureBox1.Load(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.jpeg", iIdCliente));
            //    }
            //    else if (File.Exists(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.JPEG", iIdCliente)))
            //    {
            //        ovalPictureBox1.Load(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.JPEG", iIdCliente));
            //    }
            //    else if (File.Exists(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.png", iIdCliente)))
            //    {
            //        ovalPictureBox1.Load(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.png", iIdCliente));
            //    }
            //    else if (File.Exists(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.PNG", iIdCliente)))
            //    {
            //        ovalPictureBox1.Load(string.Format(@"\\192.169.143.34\\MiPymeImg\\Clientes\{0}.PNG", iIdCliente));
            //    }
            //    else
            //    {
            //        ovalPictureBox1.Image = Properties.Resources.circled_user_male_skin_type_1_2_96px;
            //    }
            //}
			ovalPictureBox1.Image = Properties.Resources.circled_user_male_skin_type_1_2_96px;
		}

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarInformacion() == 0)
            {            
                if (!string.IsNullOrWhiteSpace(txtImporteRepartirAlimentos.Text))
                {
                    btnCalcular.Focus();
                    lblOperacionNo.Text                         = txtNoOperacion.Text;

                    //CALCULAR IMPORTE DE LA FACTURA
                    dIngresoAlimentosIF = dImporteRepartirAlimentos;
                    dIvaIF              = dIngresoAlimentosIF * decimal.Parse("0.16");
                    dTotalIF            = dIngresoAlimentosIF + dIvaIF;
                    //lblIngresoAlimentos.Text    = String.Format("{0:C2}", decimal.Round(dIngresoAlimentosIF, MidpointRounding.AwayFromZero));
                    //lblIvaIF.Text               = String.Format("{0:C2}", decimal.Round(dIvaIF, MidpointRounding.AwayFromZero));
                    //lblTotalIF.Text             = String.Format("{0:C2}", decimal.Round(dTotalIF, MidpointRounding.AwayFromZero));

                    lblIngresoAlimentos.Text    = String.Format("{0:C2}", dIngresoAlimentosIF);
                    lblIvaIF.Text               = String.Format("{0:C2}", dIvaIF);
                    lblTotalIF.Text             = String.Format("{0:C2}", dTotalIF);
                    
                    btnGuardar.Visible = true;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //CREA NUEVO REGISTRO DE PAPEL DE TRABAJO Y OPERACIÓN
            if(new PapelTrabajo().CrearPapelTrabajo(new PapelTrabajo()
            {
                iIdVendedor             = vendedor.iIdCliente,
                iIdTipoFactura          = int.Parse(cmbxTipoFactura.SelectedValue.ToString()),
                sNoOperacion            = txtNoOperacion.Text,
                dImporte                = dImporteRepartirAlimentos,
                sNoFactura              = txtNoFactura.Text,
                dtFechaFactura          = dtFechaFactura.Value,
                dtFechaDeposito         = dtFechaDeposito.Value,
                iIdUsuario              = vendedor.iIdVendedor,
                sUUID                   = txtUuid.Text
            }) == 1)
            {
                FlatMessageBox.Show("Factura guardada correctamente", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
                LimpiarControles();
                btnGuardar.Visible = false;
            }
            else
            {
                FlatMessageBox.Show("Error al guardar la factura", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
            }                                  
        }



        #region FUNCIONES CONTROLES


        public int ValidarInformacion()
        {
            int iResultado = 0;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtIdVendedor.Text))
            {
                this.errorProvider1.SetError(txtIdVendedor, "Clave del vendedor.");
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txtNombreVendedor.Text))
            {
                this.errorProvider1.SetError(txtNombreVendedor, "Nombre del vendedor.");
                iResultado = 1;
            }

            //if (string.IsNullOrEmpty(txtNivelVendedor.Text))
            //{
            //    this.errorProvider1.SetError(txtNivelVendedor, "Nivel del vendedor.");
            //    iResultado = 1;
            //}

            if (string.IsNullOrEmpty(txtNoOperacion.Text))
            {
                this.errorProvider1.SetError(txtNoOperacion, "Número de Operación.");
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txtImporteRepartirAlimentos.Text))
            {
                this.errorProvider1.SetError(txtImporteRepartirAlimentos, "Importe a repartir por alimentos");
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txtIva.Text))
            {
                this.errorProvider1.SetError(txtIva, "IVA.");
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txtTotal.Text))
            {
                this.errorProvider1.SetError(txtTotal, "Total.");
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txtNoFactura.Text))
            {
                this.errorProvider1.SetError(txtNoFactura, "Número de Factura.");
                iResultado = 1;
            }

            DateTime fechaFactura = Convert.ToDateTime(dtFechaFactura.Value);

            if (fechaFactura > DateTime.Now)
            {
                this.errorProvider1.SetError(dtFechaFactura, "La fecha de factura no debe ser mayor al día de hoy.");
                iResultado = 1;
            }

            DateTime fechaDeposito = Convert.ToDateTime(dtFechaDeposito.Value);

            if (fechaDeposito < fechaFactura || fechaDeposito > DateTime.Now)
            {
                this.errorProvider1.SetError(dtFechaDeposito, "La fecha de depósito no debe ser menor a la fecha de factura ni mayor al día de hoy.");
                iResultado = 1;
            }

            //if (string.IsNullOrEmpty(txtPorcentajeComisionUsoEsquema.Text))
            //{
            //    this.errorProvider1.SetError(txtPorcentajeComisionUsoEsquema, "Porcentaje de comisión por uso de esquema.");
            //    iResultado = 1;
            //}

            //if (string.IsNullOrEmpty(txtPuntosBeneficio.Text))
            //{
            //    this.errorProvider1.SetError(txtPuntosBeneficio, "Puntos de beneficio.");
            //    iResultado = 1;
            //}

            //if (string.IsNullOrEmpty(txtPorcentajeGlobalComisionVenta.Text))
            //{
            //    this.errorProvider1.SetError(txtPorcentajeGlobalComisionVenta, "Porcentaje de global de comisión por venta.");
            //    iResultado = 1;
            //}

            //if (string.IsNullOrEmpty(txtPorcentajeComisionMultinivel.Text))
            //{
            //    this.errorProvider1.SetError(txtPorcentajeComisionMultinivel, "Porcentaje de comisión multinivel.");
            //    iResultado = 1;
            //}

            //if (string.IsNullOrEmpty(txtPorcentajeUtilidadEstimadaIG.Text))
            //{
            //    this.errorProvider1.SetError(txtPorcentajeUtilidadEstimadaIG, "Porcentaje de utilidad estimada Islas Gower.");
            //    iResultado = 1;
            //}

            return iResultado;
        }



        private void LimpiarControles()
        {
            // Limpia por groupbox.
            // Informacion Cliente
            foreach (Control x in pnlDatos.Controls)
            {
                if (x is MetroTextBox)
                {
                    x.Text = "";
                }
            }

            //dtmFechaFactura.Value   = DateTime.Now;
            //dtmFechaDeposito.Value  = DateTime.Now;

            lblOperacionNo.Text                         = "0000";
            //lblDeterminacionComisionesOperacionNo.Text  = "0000";

            lblIngresoAlimentos.Text                = "$ --";
            lblIvaIF.Text                           = "$ --";
            lblTotalIF.Text                         = "$ --";
            //lblIngresoAlimentosCO.Text              = "$ --";
            //lblComisionCO.Text                      = "$ --";
            //lblIvaPB.Text                           = "$ --";
            //lblPuntosPB.Text                        = "$ --";
            //lblBeneficioPB.Text                     = "$ --";
            //lblIngresoAcumulableCF.Text             = "$ --";
            //lblUtilidadEstimadaCF.Text              = "$ --";
            //lblCostoFiscalIsrCF.Text                = "$ --";
            //lblAlimentosIRA.Text                    = "$ --";
            //lblBeneficioIRA.Text                    = "$ --";
            //lblComisionIRA.Text                     = "$ --";
            //lblCostoFiscalIRA.Text                  = "$ --";
            //lblImporteTotalIRA.Text                 = "$ --";
            //lblComisionManejoEsquemaIN.Text         = "$ --";
            //lblIvaIN.Text                           = "$ --";
            //lblMenosDevPuntosIN.Text                = "$ --";
            //lblImporteNegocioIN.Text                = "$ --";
            //lblComisionGlobalVentaCMPorcentaje.Text = "$ --";
            //lblComisionGlobalVentaCM.Text           = "$ --";

            //grdComisionistas.Rows.Clear();
        }

        private void txtImporteRepartirAlimentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtImporteRepartirAlimentos_Leave(object sender, EventArgs e)
        {
            try
            { 
                dImporteRepartirAlimentos   = decimal.Parse(txtImporteRepartirAlimentos.Text);
                dIVA                        = dImporteRepartirAlimentos * decimal.Parse("0.16");
                dTotal                      = dImporteRepartirAlimentos + dIVA;

                Double value;
                if (Double.TryParse(txtImporteRepartirAlimentos.Text, out value))
                    txtImporteRepartirAlimentos.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);

                //txtIva.Text     = String.Format("{0:C2}", decimal.Round(dIVA, MidpointRounding.AwayFromZero));
                //txtTotal.Text   = String.Format("{0:C2}", decimal.Round(dTotal, MidpointRounding.AwayFromZero));
                txtIva.Text = String.Format("{0:C2}", dIVA);
                txtTotal.Text = String.Format("{0:C2}", dTotal);
            }
            catch
            {

            }
        }

        //private void txtPorcentajeGlobalComisionVenta_Leave(object sender, EventArgs e)
        //{
        //    if (!(txtPorcentajeGlobalComisionVenta.Text == string.Empty))
        //    {
        //        txtPorcentajeGlobalComisionVenta.Text = txtPorcentajeGlobalComisionVenta.Text + "%";
        //    }
        //}

        //private void txtPorcentajeUtilidadEstimadaIG_Leave(object sender, EventArgs e)
        //{
        //    if (!(txtPorcentajeUtilidadEstimadaIG.Text == string.Empty))
        //    {
        //        Double value;
        //        if (Double.TryParse(txtPorcentajeUtilidadEstimadaIG.Text, out value))
        //            txtPorcentajeUtilidadEstimadaIG.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:P2}", value / 100);


        //        //txtPorcentajeUtilidadEstimadaIG.Text = txtPorcentajeUtilidadEstimadaIG.Text + "%";
        //        //lblNum2.Text = txtPorcentajeUtilidadEstimadaIG.Text;
        //    }
        //    //else
        //        //lblNum2.Text = "0%";
        //}

        //private void txtPorcentajeComisionUsoEsquema_Leave(object sender, EventArgs e)
        //{
        //    if (!(txtPorcentajeComisionUsoEsquema.Text == string.Empty))
        //    {
        //        Double value;
        //        if (Double.TryParse(txtPorcentajeComisionUsoEsquema.Text, out value))
        //            txtPorcentajeComisionUsoEsquema.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:P2}", value / 100);

        //        //txtPorcentajeComisionUsoEsquema.Text = txtPorcentajeComisionUsoEsquema.Text + "%";
        //        //lblPorcentajeComisionCO.Text = txtPorcentajeComisionUsoEsquema.Text;
        //    }
        //    //else
        //        //lblPorcentajeComisionCO.Text = "0%";
        //}

        //private void txtPuntosBeneficio_Leave(object sender, EventArgs e)
        //{
        //    if (!(txtPuntosBeneficio.Text == string.Empty))
        //    {
        //        //lblNum1.Text = txtPuntosBeneficio.Text;
        //        //lblNum4.Text = txtPuntosBeneficio.Text;
        //    }
        //    else
        //    {
        //        //lblNum1.Text                = "0";
        //        //lblNum4.Text                = "0";
        //        txtPuntosBeneficio.Text     = "0";
        //    }
        //}

        #endregion

        private void txtIdVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)13)
            {
                btnBuscar_Click(sender, e);
            }
        }
    }
}
