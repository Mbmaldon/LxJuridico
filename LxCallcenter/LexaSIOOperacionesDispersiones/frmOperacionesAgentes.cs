using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.LexaSIOOperLogica;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    public partial class frmOperacionesAgentes : Form
    {
        public frmOperacionesAgentes()
        {
            InitializeComponent();
        }

        //VARIABLES DESDE CAJAS DE TEXTO
        decimal dImporteHonorarios           = 0;
        //decimal dPorcentajeComision        = 0;
        //decimal dPorcentajeDeducciones     = 0;
        //decimal dPuntosBeneficio           = 0;
        //decimal dPorcentajeUtilidadEstimada= 0;


        //PRESTACIÓN DE SERVICIOS PROFESIONALES
        //IMPORTE FACTURADO(IF)
        decimal dIngresosHonorariosIF       = 0;
        decimal dIvaIF                      = 0;
        decimal dTotalIF                    = 0;
        //RETENCIONES(RT)
        decimal dRetencionIsrRT             = 0;
        decimal dRetencionIvaRT             = 0;
        decimal dTotalRetencionesRT         = 0;
        //IMPORTE RECIBIDO(IR)
        decimal dTotalFacturadoIR           = 0;
        decimal dRetencionesIR              = 0;
        decimal dTotalRecibidoIR            = 0;
        //PAGO PROVISIONAL DE I.S.R.(PPI)
        decimal dIngresosPeriodoPPI         = 0;
        decimal dDeduccionesPPI             = 0;
        decimal dBaseGravablePPI            = 0;
        decimal dLimInferiorPPI             = 0;
        decimal dExcLimInferiorPPI          = 0;
        decimal dPorcentajeAplicablePPI     = 0;
        decimal dImpuestoMarginalPPI        = 0;
        decimal dCuotaFijaPPI               = 0;
        decimal dIsrSegunTarifaPPI          = 0;
        decimal dRetencionesEfectuadasPPI   = 0;
        decimal dIsrPagarPPI                = 0;
        //PAGO DEFINITIVO DE I.V.A.(PDI)
        decimal dIvaCausadoPDI              = 0;
        decimal dIvaAcreditablePDI          = 0;
        decimal dRetencionesIvaPDI          = 0;
        decimal dPagoDefinitivoIvaPDI       = 0;
        //IMPORTE NETO (IN)
        decimal dTotalRefacturadoIN         = 0;
        decimal dRetencionIsrIN             = 0;
        decimal dRetencionIvaIN             = 0;
        decimal dPagoProvisionalIsrIN       = 0;
        decimal dPagoDefinitivoIvaIN        = 0;
        decimal dImporteNetoIN              = 0;


        //SOCIO COMANDITARIO INDUSTRIAL
        //IMPORTE FACTURADO (IF)
        decimal dIngresoFacturadoScIF       = 0;
        //decimal dIvaIF                    = 0;
        //decimal dTotalIF                  = 0;
        //COMISIÓN (CO)
        decimal dIngresoFacturadoScCO       = 0;
        decimal dPorcentajeComisionCO       = 0;
        decimal dComisionCO                 = 0;
        //PUNTOS DE BENEFICIO (PB)
        decimal dIvaPB                      = 0;
        decimal dPuntosPB                   = 0;
        decimal dBeneficioPB                = 0;
        //COSTO FISCAL (CF)
        decimal dIngresoAcumulableCF        = 0;
        decimal dUtilidadEstimadaCF         = 0;
        decimal dCostoFiscalIsrCF           = 0;
        //IMPORTE NETO QUE SE PERCIBIRA (INP)
        decimal dHonorariosINP              = 0;
        decimal dBeneficioINP               = 0;
        decimal dComisionINP                = 0;
        decimal dCostoFiscalINP             = 0;
        decimal dImporteNetoINP             = 0;


        //BENEFICIO (BO)
        decimal dImporteNetoEsquemaPropuesto = 0;
        decimal dImporteNetoEsquemaNormal   = 0;
        decimal dBeneficioNeto              = 0;
        decimal dPorcentajeBeneficio        = 0;
        
        /// <summary>
        /// Método Público para realizar las operaciones
        /// </summary>
        public void realizarCalculos()
        {
            LimiteInferior _limiteInferior;
            string[] sImporteHonorarios = txtImporteHonorarios.Text.Split('$');
            dImporteHonorarios = Decimal.Parse(sImporteHonorarios[1]);

            //PRESTACIÓN DE SERVICIOS PROFESIONALES
            //IMPORTE FACTURADO
            dIngresosHonorariosIF     = dImporteHonorarios;
            dIvaIF                    = dIngresosHonorariosIF * decimal.Parse("0.16");
            dTotalIF                  = dIngresosHonorariosIF + dIvaIF;
            lblIngresosHonorariosIF.Text    = String.Format("{0:C2}", decimal.Round(dIngresosHonorariosIF, MidpointRounding.AwayFromZero));
            lblIvaIF.Text                   = String.Format("{0:C2}", decimal.Round(dIvaIF, MidpointRounding.AwayFromZero));
            lblTotalIF.Text                 = String.Format("{0:C2}", decimal.Round(dTotalIF, MidpointRounding.AwayFromZero));
            //RENTECIONES
            dRetencionIsrRT           = dIngresosHonorariosIF * decimal.Parse("0.1");
            dRetencionIvaRT           = (dIvaIF / 3) * 2;
            dTotalRetencionesRT       = dRetencionIsrRT + dRetencionIvaRT;
            lblRetencionIsrRT.Text          = String.Format("{0:C2}", decimal.Round(dRetencionIsrRT, MidpointRounding.AwayFromZero));
            lblRetencionIvaRT.Text          = String.Format("{0:C2}", decimal.Round(dRetencionIvaRT, MidpointRounding.AwayFromZero));
            lblTotalRetencionesRT.Text      = String.Format("{0:C2}", decimal.Round(dTotalRetencionesRT, MidpointRounding.AwayFromZero));
            //IMPORTE RECIBIDO
            dTotalFacturadoIR         = dTotalIF;
            dRetencionesIR            = dTotalRetencionesRT;
            dTotalRecibidoIR          = dTotalFacturadoIR - dRetencionesIR;
            lblTotalFacturadoIR.Text        = String.Format("{0:C2}", decimal.Round(dTotalFacturadoIR, MidpointRounding.AwayFromZero));
            lblRetencionesIR.Text           = String.Format("{0:C2}", decimal.Round(dRetencionesIR, MidpointRounding.AwayFromZero));
            lblTotalRecibidoIR.Text         = String.Format("{0:C2}", decimal.Round(dTotalRecibidoIR, MidpointRounding.AwayFromZero));
            //PAGO PROVISIONAL DE I.S.R.
            dIngresosPeriodoPPI       = dIngresosHonorariosIF;
            string[] sDeduccionesPPI  = lblNum4.Text.Split('%');
            dDeduccionesPPI           = dIngresosPeriodoPPI * (Decimal.Parse(sDeduccionesPPI[0]) / 100);
            dBaseGravablePPI          = dIngresosPeriodoPPI - dDeduccionesPPI;
            _limiteInferior           = new LimiteInferior().obtenerLimite(dBaseGravablePPI);
            dLimInferiorPPI           = _limiteInferior.dLimiteInferior;
            dExcLimInferiorPPI        = dBaseGravablePPI - dLimInferiorPPI;
            dPorcentajeAplicablePPI   = _limiteInferior.dExcedente / 100;
            dImpuestoMarginalPPI      = dExcLimInferiorPPI * dPorcentajeAplicablePPI;
            dCuotaFijaPPI             = _limiteInferior.dCuotaFija;
            dIsrSegunTarifaPPI        = dImpuestoMarginalPPI + dCuotaFijaPPI;
            dRetencionesEfectuadasPPI = dRetencionIsrRT;
            dIsrPagarPPI              = dIsrSegunTarifaPPI - dRetencionesEfectuadasPPI;
            if (dIsrPagarPPI < 0)
                dIsrPagarPPI          = 0;
            dIvaCausadoPDI            = dIvaIF;
            dIvaAcreditablePDI        = dDeduccionesPPI * decimal.Parse("0.16");
            dRetencionesIvaPDI        = dRetencionIvaRT;
            dPagoDefinitivoIvaPDI     = dIvaCausadoPDI - dIvaAcreditablePDI - dRetencionesIvaPDI;
            lblIngresosPeriodoPPI.Text      = String.Format("{0:C2}", decimal.Round(dIngresosPeriodoPPI, MidpointRounding.AwayFromZero));
            lblDeduccionesPPI.Text          = String.Format("{0:C2}", decimal.Round(dDeduccionesPPI, MidpointRounding.AwayFromZero));
            lblBaseGravablePPI.Text         = String.Format("{0:C2}", decimal.Round(dBaseGravablePPI, MidpointRounding.AwayFromZero));
            lblLimInferiorPPI.Text          = String.Format("{0:C2}", decimal.Round(dLimInferiorPPI, MidpointRounding.AwayFromZero));
            lblExcLimInferiorPPI.Text       = String.Format("{0:C2}", decimal.Round(dExcLimInferiorPPI, MidpointRounding.AwayFromZero));
            lblPorcentajeAplicablePPI.Text  = String.Format("{0:P2}", Math.Round(dPorcentajeAplicablePPI, 2));
            lblImpuestoMarginalPPI.Text     = String.Format("{0:C2}", decimal.Round(dImpuestoMarginalPPI, MidpointRounding.AwayFromZero));
            lblCuotaFijaPPI.Text            = String.Format("{0:C2}", decimal.Round(dCuotaFijaPPI, MidpointRounding.AwayFromZero));
            lblIsrSegunTarifaPPI.Text       = String.Format("{0:C2}", decimal.Round(dIsrSegunTarifaPPI, MidpointRounding.AwayFromZero));
            lblRetencionesEfectuadasPPI.Text= String.Format("{0:C2}", decimal.Round(dRetencionesEfectuadasPPI, MidpointRounding.AwayFromZero));
            lblIsrPagarPPI.Text             = String.Format("{0:C2}", decimal.Round(dIsrPagarPPI, MidpointRounding.AwayFromZero));
            lblIvaCausadoPDI.Text           = String.Format("{0:C2}", decimal.Round(dIvaCausadoPDI, MidpointRounding.AwayFromZero));
            lblIvaAcreditablePDI.Text       = String.Format("{0:C2}", decimal.Round(dIvaAcreditablePDI, MidpointRounding.AwayFromZero));
            lblRetencionesIvaPDI.Text       = String.Format("{0:C2}", decimal.Round(dRetencionesIvaPDI, MidpointRounding.AwayFromZero));
            lblPagoDefinitivoIvaPDI.Text    = String.Format("{0:C2}", decimal.Round(dPagoDefinitivoIvaPDI, MidpointRounding.AwayFromZero));
            //IMPORTE NETO (IN)
            dTotalRefacturadoIN     = dTotalIF;
            dRetencionIsrIN         = dRetencionIsrRT;
            dRetencionIvaIN         = dRetencionIvaRT;
            dPagoProvisionalIsrIN   = dIsrPagarPPI;
            dPagoDefinitivoIvaIN    = dPagoDefinitivoIvaPDI;
            dImporteNetoIN          = dTotalIF - dRetencionIsrRT - dRetencionIvaRT - dIsrPagarPPI - dPagoDefinitivoIvaPDI;
            lblTotalRefacturadoIN.Text      = String.Format("{0:C2}", decimal.Round(dTotalRefacturadoIN, MidpointRounding.AwayFromZero));
            lblRetencionIsrIN.Text          = String.Format("{0:C2}", decimal.Round(dRetencionIsrIN, MidpointRounding.AwayFromZero));
            lblRetencionIvaIN.Text          = String.Format("{0:C2}", decimal.Round(dRetencionIvaIN, MidpointRounding.AwayFromZero));
            lblPagoProvisionalIsrIN.Text    = String.Format("{0:C2}", decimal.Round(dPagoProvisionalIsrIN, MidpointRounding.AwayFromZero));
            lblPagoDefinitivoIvaIN.Text     = String.Format("{0:C2}", decimal.Round(dPagoDefinitivoIvaIN, MidpointRounding.AwayFromZero));
            lblImporteNetoIN.Text           = String.Format("{0:C2}", decimal.Round(dImporteNetoIN, MidpointRounding.AwayFromZero));


            //SOCIO COMANDITARIO INDUSTRIAL
            //IMPORTE FACTURADO
            dIngresoFacturadoScIF   = dIngresosHonorariosIF;
            //dIvaIF                = dIvaIF;
            //dTotalIF              = dTotalIF;
            lblIngresoFacturadoScIF.Text    = String.Format("{0:C2}", decimal.Round(dIngresoFacturadoScIF, MidpointRounding.AwayFromZero));
            lblIvaIFSCI.Text                = String.Format("{0:C2}", decimal.Round(dIvaIF, MidpointRounding.AwayFromZero));
            lblTotalIFSCI.Text              = String.Format("{0:C2}", decimal.Round(dTotalIF, MidpointRounding.AwayFromZero));
            //COMISIÓN
            dIngresoFacturadoScCO = dIngresoFacturadoScIF;
            string[] sPorcentajeComisionCO = txtPorcentajeComision.Text.Split('%');
            dPorcentajeComisionCO = Decimal.Parse(sPorcentajeComisionCO[0]) / 100;
            dComisionCO           = dIngresoFacturadoScCO * dPorcentajeComisionCO;
            dIvaPB                = dIvaIF;
            dPuntosPB             = dIngresoFacturadoScCO * decimal.Parse(lblNum.Text) / 100;
            dBeneficioPB          = dPuntosPB;
            lblIngresoFacturadoScCO.Text    = String.Format("{0:C2}", decimal.Round(dIngresoFacturadoScCO, MidpointRounding.AwayFromZero));
            lblPorcentajeComisionCO.Text    = String.Format("{0:P2}", Math.Round(dPorcentajeComisionCO, 2));//(dPorcentajeComisionCO * 100).ToString();
            lblComisionCO.Text              = String.Format("{0:C2}", decimal.Round(dComisionCO, MidpointRounding.AwayFromZero));
            lblIvaPB.Text                   = String.Format("{0:C2}", decimal.Round(dIvaPB, MidpointRounding.AwayFromZero));
            lblPuntosPB.Text                = String.Format("{0:C2}", decimal.Round(dPuntosPB, MidpointRounding.AwayFromZero));
            lblBeneficioPB.Text             = String.Format("{0:C2}", decimal.Round(dBeneficioPB, MidpointRounding.AwayFromZero));
            //COSTO FISCAL
            dIngresoAcumulableCF         = dTotalIF;
            string[] sUtilidadEstimadaCF = lblNum2.Text.Split('%');
            dUtilidadEstimadaCF          = dIngresoAcumulableCF * (Decimal.Parse(sUtilidadEstimadaCF[0]) / 100);
            string[] sCostoFiscalIsrCF   = lblNum3.Text.Split('%');
            dCostoFiscalIsrCF            = dUtilidadEstimadaCF * (Decimal.Parse(sCostoFiscalIsrCF[0]) / 100);
            lblIngresoAcumulableCF.Text     = String.Format("{0:C2}", decimal.Round(dIngresoAcumulableCF, MidpointRounding.AwayFromZero));
            lblUtilidadEstimadaCF.Text      = String.Format("{0:C2}", decimal.Round(dUtilidadEstimadaCF, MidpointRounding.AwayFromZero));
            lblCostoFiscalIsrCF.Text        = String.Format("{0:C2}", decimal.Round(dCostoFiscalIsrCF, MidpointRounding.AwayFromZero));
            //IMPORTE NETO QUE SE PERCIBIRA
            dHonorariosINP       = dIngresoFacturadoScIF;
            dBeneficioINP        = dBeneficioPB;
            dComisionINP         = dComisionCO;
            dCostoFiscalINP      = dCostoFiscalIsrCF;
            dImporteNetoINP      = dHonorariosINP + dBeneficioINP - dComisionINP - dCostoFiscalINP;
            lblHonorariosINP.Text           = String.Format("{0:C2}", decimal.Round(dHonorariosINP, MidpointRounding.AwayFromZero));
            lblBeneficioINP.Text            = String.Format("{0:C2}", decimal.Round(dBeneficioINP, MidpointRounding.AwayFromZero));
            lblComisionINP.Text             = String.Format("{0:C2}", decimal.Round(dComisionINP, MidpointRounding.AwayFromZero));
            lblCostoFiscalINP.Text          = String.Format("{0:C2}", decimal.Round(dCostoFiscalINP, MidpointRounding.AwayFromZero));
            lblImporteNetoINP.Text          = String.Format("{0:C2}", decimal.Round(dImporteNetoINP, MidpointRounding.AwayFromZero));

            //BENEFICIO
            dImporteNetoEsquemaPropuesto = dImporteNetoINP;
            dImporteNetoEsquemaNormal    = dImporteNetoIN;
            dBeneficioNeto               = dImporteNetoINP - dImporteNetoIN;
            dPorcentajeBeneficio         = dBeneficioNeto / dImporteNetoIN;
            lblImporteNetoEsquemaPropuesto.Text  = String.Format("{0:C2}", decimal.Round(dImporteNetoEsquemaPropuesto, MidpointRounding.AwayFromZero));
            lblImporteNetoEsquemaNormal.Text     = String.Format("{0:C2}", decimal.Round(dImporteNetoEsquemaNormal, MidpointRounding.AwayFromZero));
            lblBeneficioNeto.Text                = String.Format("{0:C2}", decimal.Round(dBeneficioNeto, MidpointRounding.AwayFromZero));
            lblPorcentajeBeneficio.Text          = String.Format("{0:P2}", Math.Round(dPorcentajeBeneficio, 2));
        }

        private void txtImporteHonorarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDA PARA INGRESAR SOLO NÚMEROS
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtImporteHonorarios_Leave(object sender, EventArgs e)
        {
            //VALIDA PARA CONVERTIR EL CONTENIDO EN MONEDA
            Double value;
            if (Double.TryParse(txtImporteHonorarios.Text, out value))
                txtImporteHonorarios.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //VALIDA QUE EXISTA UN IMPORTE PARA REALIZAR LOS CALCULOS
            if(!(txtImporteHonorarios.Text == string.Empty))
                realizarCalculos();
        }

        private void txtPuntosBeneficio_Leave(object sender, EventArgs e)
        {
            //VALIDA QUE EL CONTENIDO DEL TEXTBOX SE COPIA A UN LABEL
            if (!(txtPuntosBeneficio.Text == string.Empty))
                lblNum.Text = txtPuntosBeneficio.Text;
            else
                lblNum.Text = "0";
        }

        private void txtPorcentajeUtilidadEstimada_Leave(object sender, EventArgs e)
        {
            //VALIDA EL FORMATO DEL CONTENIDO DEL TEXTBOX PARA USAR %
            if (!(txtPorcentajeUtilidadEstimada.Text == string.Empty))
            {
                txtPorcentajeUtilidadEstimada.Text = txtPorcentajeUtilidadEstimada.Text + "%";
                lblNum2.Text                       = txtPorcentajeUtilidadEstimada.Text;
            }
            else
                lblNum2.Text = "0";
        }

        private void txtPorcentajeComision_Leave(object sender, EventArgs e)
        {
            //VALIDA EL FORMATO DEL CONTENIDO DEL TEXTBOX PARA USAR %
            if (!(txtPorcentajeComision.Text == string.Empty))
            {
                txtPorcentajeComision.Text = txtPorcentajeComision.Text + "%";
            }
            else
                txtPorcentajeComision.Text = "0%";
        }

        private void txtPorcentajeDeducciones_Leave(object sender, EventArgs e)
        {
            //VALIDA EL FORMATO DEL CONTENIDO DEL TEXTBOX PARA USAR %
            if (!(txtPorcentajeDeducciones.Text == string.Empty))
            {
                txtPorcentajeDeducciones.Text = txtPorcentajeDeducciones.Text + "%";
                lblNum4.Text = txtPorcentajeDeducciones.Text;
            }
            else
                txtPorcentajeDeducciones.Text = "0%";
        }
    }
}
