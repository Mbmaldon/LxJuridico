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

namespace LxCallcenter.LexaSIOConta
{
	public partial class frmPendientes : Form
	{
		UsuarioData AUsuario = UsuarioData.Instancia;
		UsuarioData AUsuarioData = UsuarioData.Instancia;
		decimal dTotal = 0;
		int iIdCliente = 0;
		public frmPendientes(int iIdCliente)
		{
			InitializeComponent();
			InitializeControls();
			this.iIdCliente = iIdCliente;
		}

		public void InitializeControls()
		{
			// Llenamos de tipos de declaraciones
			cmbxTipoDeclaracion.DataSource    = new LogicaCC.LexaSIOContaLogica.Declaracion().listaDeclaracionesModo();
            cmbxTipoDeclaracion.DisplayMember = "sDeclaracionModo";
            cmbxTipoDeclaracion.ValueMember   = "iIdDeclaracionModo";
			cmbxTipoDeclaracion.SelectedIndex = -1;

			// Obtenemos los meses del año
			var monthList = System.Globalization.DateTimeFormatInfo.CurrentInfo.MonthNames.Select((item, index) => new
			{
				Month = item.Length > 0 ? string.Format("{0}{1}", char.ToUpper(item[0]), item.Substring(1)) : item,//item,
				Value = index + 1
			});

			// Llenamos de solo los tres ultimos meses al mes en curso
			cmbxPeriodo.DataSource		= monthList.Where(mes => mes.Value < DateTime.Now.Month).OrderByDescending(x => x.Value).Take(3).OrderBy(y => y.Value).ToList();
			cmbxPeriodo.DisplayMember	= "Month";
			cmbxPeriodo.ValueMember	= "Value";
			cmbxPeriodo.SelectedIndex	= -1;

			// Llenamos de las declaraciones
			cmbxDeclaracion.DataSource = new LogicaCC.LexaSIOContaLogica.Declaracion().listaDeclaraciones(new LogicaCC.LexaSIOContaLogica.Declaracion()
            {
                iIdCliente = 0
            });
			cmbxDeclaracion.DisplayMember = "sDetalleObligacion";
			cmbxDeclaracion.ValueMember   = "iIdDetalleObligacion";
			cmbxDeclaracion.SelectedIndex = -1;


			cmbxConcepto.DataSource     = new LogicaCC.LexaSIOContaLogica.Concepto().listaConceptos();
            cmbxConcepto.DisplayMember  = "sConcepto";
            cmbxConcepto.ValueMember    = "iIdConcepto";
            cmbxConcepto.SelectedIndex  = -1;

			//CARGA LOS ESTADOS DE PAGO DISPONIBLES PARA LA DECLARACIÓN
			cbEstadoPago.DataSource = new DeclaracionEstado().listaDeclaracionEstado().Where(x => x.iIdDeclaracionEstado != 4).ToList();
            cbEstadoPago.DisplayMember  = "sDeclaracionEstado";
            cbEstadoPago.ValueMember    = "iIdDeclaracionEstado";
            //cbEstadoPago.SelectedIndex  = -1;
		}

		/// <summary>
		/// Obtiene el tamaño maximo que tendra un combobox de acuerdo al tamaño de sus items
		/// </summary>
		/// <param name="myCombo">ComboBox del cual se obtendran los items para establecer el tamaño</param>
		/// <returns></returns>
		int DropDownWidth(MaterialSkin.Controls.MaterialComboBox myCombo)
		{
			int widestStringInPixels = 0;
			foreach (Object o in myCombo.Items)
			{
				string toCheck;
				System.Reflection.PropertyInfo pinfo;
				Type objectType = o.GetType();
				if (myCombo.DisplayMember.CompareTo("") == 0)
				{
					toCheck = o.ToString();
				}
				else
				{
					pinfo = objectType.GetProperty(myCombo.DisplayMember);
					toCheck = pinfo.GetValue(o, null).ToString();
				}
				if (TextRenderer.MeasureText(toCheck, myCombo.Font).Width > widestStringInPixels)
					widestStringInPixels = TextRenderer.MeasureText(toCheck, myCombo.Font).Width;
			}
			return widestStringInPixels + 45;
		}

		private void btnAgregar1_Click(Object sender, EventArgs e)
		{
			//if (cmbxPeriodo1.SelectedIndex != -1 && cmbxDeclaracion1.SelectedIndex != -1)
			//{
			//	string[] Declaracion = new string[]
			//	{
			//		cmbxPeriodo1.SelectedValue.ToString(),
			//		cmbxPeriodo1.Text,
			//		cmbxDeclaracion1.SelectedValue.ToString(),
			//		cmbxDeclaracion1.Text
			//	};

			//	grdDeclaraciones1.Rows.Add(Declaracion);
			//	cmbxPeriodo1.SelectedIndex		= -1;
			//	cmbxDeclaracion1.SelectedIndex	= -1;
			//}
			//AGREGAMOS UN NUEVO CONCEPTO DE LA LISTA DE CONCEPTOS AL GRIDVIEW GRDCONCEPTOS
            if (cmbxConcepto.SelectedIndex != -1 && txtImporte.Text != string.Empty)
            {
				
				string sTotal = (decimal.Parse(txtImporte.Text) 
                               + decimal.Parse(string.IsNullOrEmpty(txtActualizacion.Text) ? "0" : txtActualizacion.Text)
                               + decimal.Parse(string.IsNullOrEmpty(txtRecargos.Text)      ? "0" : txtRecargos.Text)
                               + decimal.Parse(string.IsNullOrEmpty(txtMultas.Text)        ? "0" : txtMultas.Text)).ToString();
                string[] concepto = new string[] { cmbxConcepto.SelectedValue.ToString()
                                                 , cmbxConcepto.Text
                                                 , ""//cmbxEstado.Text
                                                 , txtImporte.Text
                                                 , string.IsNullOrEmpty(txtActualizacion.Text)? "0" : txtActualizacion.Text
                                                 , string.IsNullOrEmpty(txtRecargos.Text)     ? "0" : txtRecargos.Text
                                                 , string.IsNullOrEmpty(txtMultas.Text)       ? "0" : txtMultas.Text
                                                 , sTotal};
                grdConceptos.Rows.Add(concepto);

                dTotal = dTotal + decimal.Parse(sTotal);

                txtMonto.Text = dTotal.ToString();

                cmbxConcepto.SelectedIndex = -1;
                //cmbxEstado.Text        = string.Empty;
                txtImporte.Text       = "0";
                txtActualizacion.Text = "0";
                txtRecargos.Text      = "0";
                txtMultas.Text        = "0";
            }
            else
            {
				MessageBox.Show("No campos vacios");
                //FlatMessageBox.Show("No campos vacios", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
            }
		}


		private void OnlyNumbers(object sender, KeyPressEventArgs e)
		{
			//VALIDAR QUE SOLO SE INGRESEN NÚMEROS
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 46))
			{
				e.Handled = true;
				return;
			}
		}

		private void LimpiarControles()
		{
			//Limpia y reinicia los controles a estado inicial		
			txtMonto.Text				= "";
			txtNumOperacion.Text		= "";			
			txtLlavePago.Text			= "";
			txtLCaptura.Text			= "";
            cbEstadoPago.SelectedIndex	= 0;
            dtpFPresentacion.Text       = DateTime.Now.ToString();
            dtpFechaPago.Text           = DateTime.Now.ToString();
            grdConceptos.Rows.Clear();
        }

		private int ValidarDeclaracion()
		{
			MensajeError.Clear();
			int iResultado = 0;

			//if (txbAño.Text.Equals(""))
			//{
			//	MensajeError.SetError(txbAño, "Debe insertar año de la declaracion.");
			//	iResultado = 1;
			//}

			if (cmbxTipoDeclaracion.SelectedIndex == -1)
			{
				MensajeError.SetError(cmbxTipoDeclaracion, "Debe seleccionar un tipo de declaración.");
				iResultado = 1;
			}

			if (cmbxDeclaracion.SelectedIndex == -1)
			{
				MensajeError.SetError(cmbxDeclaracion, "Debe seleccionar una declaración.");
				iResultado = 1;
			}

			if (cmbxPeriodo.SelectedIndex == -1)
			{
				MensajeError.SetError(cmbxPeriodo, "Debe seleccionar un periodo.");
				iResultado = 1;
			}

			if (txtMonto.Text.Equals(""))
			{
				MensajeError.SetError(txtMonto, "Debe insertar año de la declaracion.");
				iResultado = 1;
			}

			if (cbEstadoPago.SelectedIndex == 0)
			{
				MensajeError.SetError(cbEstadoPago, "Debe seleccionar estado del pago.");
				iResultado = 1;
			}

			if (txtLCaptura.Text.Equals(""))
			{
				MensajeError.SetError(txtLCaptura, "Debe proporcionar la linea de captura.");
				iResultado = 1;
			}
			return iResultado;
		}


		private void btnGuardar_Click(Object sender, EventArgs e)
		{

			if (ValidarDeclaracion() == 0)
			{
				string sFechaLimPag       = string.Format("{0}/{1}/{2}", dtpFechaPago.Value.Day, dtpFechaPago.Value.Month, dtpFechaPago.Value.Year);
                string sFechaPresentacion = string.Format("{0}/{1}/{2}", dtpFPresentacion.Value.Day, dtpFPresentacion.Value.Month, dtpFPresentacion.Value.Year);

				int iIdDeclaracion = new LogicaCC.LexaSIOContaLogica.Declaracion().AddStatement(new LogicaCC.LexaSIOContaLogica.Declaracion()
                                     {
                                         iIdCliente         = iIdCliente,//4,//int.Parse(ACliente.sIdCliente),
                                         iIdPeriodo         = int.Parse(cmbxPeriodo.SelectedValue.ToString()),
                                         sIdDeclaracionTipo = cmbxDeclaracion.SelectedValue.ToString(),
                                         sIdDecEstado       = cbEstadoPago.SelectedValue.ToString(),
                                         sIdUsuario         = AUsuario.sIdusuario,
                                         sAñoDec            = DateTime.Now.Year.ToString(),//txbAño.Text,
                                         sLinCap            = txtLCaptura.Text.ToUpper(),
                                         sNumOper           = txtNumOperacion.Text.ToUpper(),
                                         sMonto             = txtMonto.Text,
                                         sLlavePago         = txtLlavePago.Text.ToUpper(),
                                         sFechaLimPag       = sFechaLimPag,
                                         sFechaPresentacion = sFechaPresentacion,
                                         iIdDeclaracionModo = int.Parse(cmbxTipoDeclaracion.SelectedValue.ToString())
                                     });
				if (iIdDeclaracion > 0)
                {               
                    foreach (DataGridViewRow row in grdConceptos.Rows)
                    {
                        new LogicaCC.LexaSIOContaLogica.RegistroConcepto().InsertarRegistroObligacion(new LogicaCC.LexaSIOContaLogica.RegistroConcepto()
                        {
                            iIdConcepto    = int.Parse(row.Cells[0].Value.ToString()),
                            sEstado        = row.Cells[2].Value.ToString(),
                            dMonto         = decimal.Parse(row.Cells[3].Value.ToString()),
                            dActualizacion = decimal.Parse(row.Cells[4].Value.ToString()),
                            dRecargos      = decimal.Parse(row.Cells[5].Value.ToString()),
                            dMultas        = decimal.Parse(row.Cells[6].Value.ToString()),
                            dTotal         = decimal.Parse(row.Cells[7].Value.ToString()),
                            iIdDeclaracion = iIdDeclaracion
                        });
                    }

                    FlatMessageBox.Show("Declaración guardada exitosamente.", "OK", string.Empty, FlatMessageBoxIcon.Information);
                    LimpiarControles();
                    dTotal = 0;
                }
                else
                {
                    FlatMessageBox.Show("Error al guardar la informacion.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
                }


				//foreach (DataGridViewRow row in grdConceptos.Rows)
				//{
				//	string sMensaje = string.Format("{1}{0}{2}{0}{3}{0}{4}", Environment.NewLine, row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
				//	MessageBox.Show(sMensaje);
				//}
			}
		}

		private void btnFinalizar_Click(Object sender, EventArgs e)
		{
			FPrincipal _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;
			if (_frmPrincipal != null)
			{
				_frmPrincipal.ribbonControlPrincipal.SelectedPage = _frmPrincipal.ribbonPage1;
				frmInicioObligaciones _frmInicioObligaciones = new frmInicioObligaciones(int.Parse(AUsuarioData.sIdusuario));
				frmInicioObligaciones InicioObligaciones = _frmInicioObligaciones ?? new frmInicioObligaciones(int.Parse(AUsuarioData.sIdusuario));
				MostrarForm(InicioObligaciones);
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
