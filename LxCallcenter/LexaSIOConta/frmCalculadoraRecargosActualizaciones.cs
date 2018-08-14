using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.Logica;
using LogicaCC.LexaSIOContaLogica;

namespace LxCallcenter.LexaSIOConta
{
    public partial class frmCalculadoraRecargosActualizaciones : Form
    {
        //NUEVA INSTANCIA PARA OBTENER INFORMACIÓN DEL USUARIO LOGEADO
        UsuarioData AUsuario = UsuarioData.Instancia;

        public frmCalculadoraRecargosActualizaciones(string sCliente)
        {
            InitializeComponent();
			buscarCliente(int.Parse(AUsuario.sIdusuario), sCliente);
		}


        private void cmbxDeclaracion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //CARGA DE CONCEPTOS
                grdImportes.DataSource = new Concepto().listaConceptosCalculadora(int.Parse(cmbxDeclaracion.SelectedValue.ToString()));

				foreach (DataGridViewRow row in grdImportes.Rows)
				{
					row.Cells[5].Value = decimal.Parse(row.Cells[2].Value.ToString()) + decimal.Parse(row.Cells[3].Value.ToString()) + decimal.Parse(row.Cells[4].Value.ToString());
				}

				foreach (DataGridViewRow row in grdImportes.Rows)
				{
					//dFactorActualizacion
					row.Cells[6].Value = decimal.Parse(lblFactor.Text);
				}

				foreach (DataGridViewRow row in grdImportes.Rows)
				{
					//dImporteActualizacion-dMonto-dFactorActualizacion
					row.Cells[7].Value = decimal.Parse(row.Cells[5].Value.ToString()) * decimal.Parse(row.Cells[6].Value.ToString());
				}

				string[] sPorcentajeRecargosAcumulados  = lblPorcentajeRecargosAcumulados.Text.Split('%');
				decimal dPorcentajeRecargosAcumulados   = 2 * decimal.Parse(sPorcentajeRecargosAcumulados[0]);
				lblTasaRecargos.Text                    = dPorcentajeRecargosAcumulados.ToString() + "%";
				foreach (DataGridViewRow row in grdImportes.Rows)
				{
					//dPorcentajeRecargos
					row.Cells[8].Value = dPorcentajeRecargosAcumulados/100;
				}

				foreach (DataGridViewRow row in grdImportes.Rows)
				{
					//dImporteRecargos-dImporteActualizacion-dPorcentajeRecargos
					row.Cells[9].Value = String.Format("{0:0.00}", decimal.Parse(row.Cells[7].Value.ToString()) * decimal.Parse(row.Cells[8].Value.ToString()));
				}

				foreach (DataGridViewRow row in grdImportes.Rows)
				{
					//dTotalPagar-dImporteActualizacion-dImporteRecargos
					row.Cells[10].Value = String.Format("{0:0.00}", decimal.Parse(row.Cells[7].Value.ToString()) + decimal.Parse(row.Cells[9].Value.ToString()));
				}

				//CARGA DE FECHA
				Declaracion declaracion = new Declaracion();
				declaracion = new Declaracion().fechaDeclaracion(int.Parse(cmbxDeclaracion.SelectedValue.ToString()));

				metroDateTime1.Value = DateTime.Parse(declaracion.sFechaLimPag);

				//SUMA Y ASIGNACIÓN DE CONCEPTOS
				decimal dImporteAdeudo          = 0;//2
				decimal dImporteActualizacion   = 0;//4
				decimal dImportesRecargos       = 0;//6
				decimal dTotalPagar             = 0;//7
				foreach (DataGridViewRow row in grdImportes.Rows)
				{
				    dImporteAdeudo          = dImporteAdeudo + decimal.Parse(row.Cells[5].Value.ToString());//dMonto
					dImporteActualizacion   = dImporteActualizacion + decimal.Parse(row.Cells[7].Value.ToString());//dImporteActualizacion
					dImportesRecargos       = dImportesRecargos + decimal.Parse(row.Cells[9].Value.ToString());//dImporteRecargos
					dTotalPagar             = dTotalPagar + decimal.Parse(row.Cells[10].Value.ToString());//dTotalPagar
				}
				lblImporteAdeudoActual.Text           = dImporteAdeudo.ToString("C2") + "\n\n";
				lblImporteActualizacion.Text    = dImporteActualizacion.ToString("C2") + "\n\n";
				lblImportesRecargos.Text        = dImportesRecargos.ToString("C2") + "\n\n";
				lblTotalPagar.Text              = dTotalPagar.ToString("C2") + "\n\n";

				grdResultadoCalculo.Rows.Clear();
				string[] resultado = new string[] { lblImporteAdeudoActual.Text, lblImporteActualizacion.Text, lblImportesRecargos.Text, lblTotalPagar.Text };
				grdResultadoCalculo.Rows.Add(resultado);
			}
            catch (Exception)
            {
            }

            lblFecha.Text = metroDateTime1.Value.ToShortDateString() + " a " + metroDateTime2.Value.ToShortDateString();
        }

		private void btnCalcular_Click(Object sender, EventArgs e)
		{
			txtINPCActual_Leave(sender, e);
			txtINPCAdeudo_Leave(sender, e);
			RealizarCalculo();
		}

		public void RealizarCalculo()
		{
			foreach (DataGridViewRow row in grdImportes.Rows)
			{
				row.Cells[5].Value = decimal.Parse(row.Cells[2].Value.ToString()) + decimal.Parse(row.Cells[3].Value.ToString()) + decimal.Parse(row.Cells[4].Value.ToString());
			}

			foreach (DataGridViewRow row in grdImportes.Rows)
            {
                row.Cells[6].Value = decimal.Parse(lblFactor.Text);
            }

            foreach (DataGridViewRow row in grdImportes.Rows)
            {
                row.Cells[7].Value = decimal.Parse(row.Cells[5].Value.ToString()) * decimal.Parse(row.Cells[6].Value.ToString());
            }

            string[] sPorcentajeRecargosAcumulados  = lblPorcentajeRecargosAcumulados.Text.Split('%');
            decimal dPorcentajeRecargosAcumulados   = 2 * decimal.Parse(sPorcentajeRecargosAcumulados[0]);
            lblTasaRecargos.Text                    = dPorcentajeRecargosAcumulados.ToString() + "%";

			foreach (DataGridViewRow row in grdImportes.Rows)
            {
                row.Cells[9].Value = String.Format("{0:0.00}", decimal.Parse(row.Cells[7].Value.ToString()) * decimal.Parse(row.Cells[8].Value.ToString()));
            }

            foreach (DataGridViewRow row in grdImportes.Rows)
            {
                row.Cells[10].Value = String.Format("{0:0.00}", decimal.Parse(row.Cells[7].Value.ToString()) + decimal.Parse(row.Cells[9].Value.ToString()));
            }

            //CARGA DE FECHA
            Declaracion declaracion = new Declaracion();
            declaracion = new Declaracion().fechaDeclaracion(int.Parse(cmbxDeclaracion.SelectedValue.ToString()));

            metroDateTime1.Value = DateTime.Parse(declaracion.sFechaLimPag);

			switch (declaracion.sDeclaracionEstado)
			{
				case "PAGADA":
					btnStatus.Text		= "PAGADA";
					btnStatus.BGColor	= "#689f38";
					break;
				case "PENDIENTE":
					btnStatus.Text		= "PENDIENTE";
					btnStatus.BGColor	= "#ef6c00";
					break;
				case "NO PAGADA":
					btnStatus.Text		= "NO PAGADA";
					btnStatus.BGColor	= "#d50000";
					break;
				default:
					break;
			}

			//SUMA Y ASIGNACIÓN DE CONCEPTOS
			decimal dImporteAdeudo          = 0;//2
            decimal dImporteActualizacion   = 0;//4
            decimal dImportesRecargos       = 0;//6
            decimal dTotalPagar             = 0;//7
            foreach (DataGridViewRow row in grdImportes.Rows)
            {
                dImporteAdeudo          = dImporteAdeudo + decimal.Parse(row.Cells[5].Value.ToString());
                dImporteActualizacion   = dImporteActualizacion + decimal.Parse(row.Cells[7].Value.ToString());
                dImportesRecargos       = dImportesRecargos + decimal.Parse(row.Cells[9].Value.ToString());
                dTotalPagar             = dTotalPagar + decimal.Parse(row.Cells[10].Value.ToString());
            }
            lblImporteAdeudoActual.Text     = dImporteAdeudo.ToString("C2") + "\n\n";
            lblImporteActualizacion.Text    = dImporteActualizacion.ToString("C2") + "\n\n";
            lblImportesRecargos.Text        = dImportesRecargos.ToString("C2") + "\n\n";
            lblTotalPagar.Text              = dTotalPagar.ToString("C2") + "\n\n";

            grdResultadoCalculo.Rows.Clear();
            string[] resultado = new string[] { lblImporteAdeudoActual.Text, lblImporteActualizacion.Text, lblImportesRecargos.Text, lblTotalPagar.Text };
            grdResultadoCalculo.Rows.Add(resultado);
		}

        private void txtINPCActual_Leave(object sender, EventArgs e)
        {
            try
            {
                //VALIDACIÓN PARA CONVERTIR EL CONTENIDO DEL TEXTBOX A MONEDA
                lblINPCActual.Text  = txtINPCActual.Text;
                decimal total       = decimal.Parse(lblINPCActual.Text) / decimal.Parse(lblINPCAdeudo.Text);
                lblFactor.Text      = String.Format("{0:0.00000}", total);
            }
            catch
            {
            }
        }

        private void txtINPCAdeudo_Leave(object sender, EventArgs e)
        {
            try
            {
                //VALIDACIÓN PARA CONVERTIR EL CONTENIDO DEL TEXTBOX A MONEDA
                lblINPCAdeudo.Text  = txtINPCAdeudo.Text;
                decimal total       = decimal.Parse(lblINPCActual.Text) / decimal.Parse(lblINPCAdeudo.Text);
                lblFactor.Text      = String.Format("{0:0.00000}", total);
            }
            catch
            {
            }
        }

        private void txtINPCActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDACIÓN PARA INGRESAR SOLO NÚMEROS
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

		LogicaCC.LexaSIOContaLogica.Cliente cliente = null;
		public void buscarCliente(int iIdUsuario, string sCliente)
        {
			cliente = new LogicaCC.LexaSIOContaLogica.Cliente().informacionClienteExLN(iIdUsuario, sCliente);
            if (cliente != null)
            {
                 lblNombre.Text      = string.Format("{0} {1} {2}", cliente.sNombre, cliente.sAPaterno, cliente.sAMaterno);
                 lblNoCliente.Text   = cliente.sCliente;
                 lblRfc.Text         = cliente.sRfc;
                 lblTelefonoM.Text   = cliente.sNumeroMovil;
                 lblCorreoE.Text     = cliente.sCorreoElectronico;

				//CARGA DE LISTA DE DECLARACIONES SEGÚN EL CLIENTE SELECCIONADO
                cmbxDeclaracion.DataSource      = new Declaracion().listaDeclaracionesCalculadora(cliente.iIdCliente);
                cmbxDeclaracion.DisplayMember   = "sDetalleObligacion";
                cmbxDeclaracion.ValueMember     = "sIdDeclaracionTipo";
                cmbxDeclaracion.SelectedIndex   = -1;
				btnStatus.Text					= "";
				btnStatus.BGColor				= "#ECEFF1";	
			}
        }

		private void grdImportes_CellEndEdit(Object sender, DataGridViewCellEventArgs e)
		{
			RealizarCalculo();
		}

		private void lnkVolverDeclaraciones_Click(Object sender, EventArgs e)
		{
			FPrincipal _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;
			if (_frmPrincipal != null)
			{
				frmClients _frmClients = new frmClients();
				frmClients Declaraciones = _frmClients ?? new frmClients();
				MostrarForm(Declaraciones);
			}
		}

		#region FUNCIONES USADAS POR CONTROLES
		// RECIBE EL FORMULARIO A MOSTRAR, LO EDITA Y LO MUESTRA
		private void MostrarForm(Form Formulario)
		{
			FPrincipal _FPrincipal = Application.OpenForms.OfType<FPrincipal>().Where(pre => pre.Name == "FPrincipal").SingleOrDefault<FPrincipal>();
			CerrarFormularios();
			Formulario.TopLevel = false;
			Formulario.FormBorderStyle = FormBorderStyle.None;
			Formulario.Dock = DockStyle.Fill;
			_FPrincipal.panelContenedor.Controls.Add(Formulario);
			_FPrincipal.panelContenedor.Tag = Formulario;
			Formulario.Show();
		}

		// CIERRA LOS FORMULARIOS ABIERTOS Y PUESTOS EN EL FORM.
		private void CerrarFormularios()
		{
			FPrincipal _FPrincipal = Application.OpenForms.OfType<FPrincipal>().Where(pre => pre.Name == "FPrincipal").SingleOrDefault<FPrincipal>();
			Form[] sAforms = new Form[10];
			int iContador = 0;
			// Se genera el listado de los formularios abiertos
			foreach (Form x in Application.OpenForms)
			{
				string sForm = x.Name.ToString();

				if (!sForm.Equals("Login") && !sForm.Equals("FPrincipal") && !sForm.Equals("EnviarMensajes") && !sForm.Equals("frmDirectorio") && !sForm.Equals("frmTelefono") && !sForm.Equals("frmTelefonoConfigurar"))
				{
					_FPrincipal.panelContenedor.Controls.Remove(x);
					sAforms[iContador] = x;
					iContador++;
				}
			}
			// Cierra los formularios
			for (int i = 0; i < 10; i++)
			{
				if (sAforms[i] != null)
					sAforms[i].Close();
			}
		}
		#endregion FUNCIONES USADAS POR CONTROLES
	}
}
