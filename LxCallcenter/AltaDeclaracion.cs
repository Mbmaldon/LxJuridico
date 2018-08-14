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
using System.IO;
using LxCallcenter.LexaSIOConta;
using System.Net;
using System.Runtime.InteropServices;
using LogicaCC;

namespace LxCallcenter
{
	public partial class AltaDeclaracion : Form
	{
		UsuarioData AUsuario;
        public static string sCliente;
		LogicaCC.LexaSIOContaLogica.Cliente Cliente = null;

        public List<LogicaCC.LexaSIOContaLogica.RegistroConcepto> RegistrosConceptos;
        
        int     iPeriodo;
        int     iEstadoPago;
        int     iTipoDeclaracion;
        string  sFechaLimPag;
        string  sFechaPresentacion;
        string  sDecTipo;
        string  sEstadoPago;
        string  sAnioDec;
        string  sLineaCap;
        string  sNoOpera;
        string  sMontoMoney;
        string  sLlavePag;
        string  sDecTipoTx;
        decimal dTotal = 0;

        public AltaDeclaracion()
        {
            InitializeComponent();
        }

        static AltaDeclaracion _AltaDeclaracion;
		static DialogResult _DialogResult = DialogResult.No;

		public static DialogResult Show(int iIdCliente)
		{
			_AltaDeclaracion = new AltaDeclaracion();

            _AltaDeclaracion.StartPosition = FormStartPosition.CenterScreen;

            _AltaDeclaracion.AUsuario = UsuarioData.Instancia;
			_AltaDeclaracion.Cliente = new LogicaCC.LexaSIOContaLogica.Cliente().InformacionCliente(iIdCliente);
			_AltaDeclaracion.Inicializar();

			_DialogResult = DialogResult.No;

			_AltaDeclaracion.Activate();
			_AltaDeclaracion.ShowDialog();
			return _DialogResult;
		}

		#region EVENTOS
		private void Inicializar()
		{
			lblNombre.Text      = Cliente.sNombre + " " + Cliente.sAPaterno + " " + Cliente.sAMaterno;
			sCliente            = Cliente.sCliente;
            InicializaControles();
        }

		// BOTON CANCELAR
		private void btnCancelar_Click(Object sender, EventArgs e)
		{
			_DialogResult = DialogResult.No;
			_AltaDeclaracion.Close();
		}

		// CONVIERTE EN MAYUSCULA LOS CONTROLES
		private void Mayusculas(Object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Char.ToUpper(e.KeyChar);
        }
		
		// BOTON GUARDAR
		private void btnGuardar_Click(Object sender, EventArgs e)
		{
            if (ValidarDeclaracion() == 0)
            {
                // Cambiamos el estado de los controles
                EstadoControles(false);
                btnGuardar.Visible  = false;
                pgbCarga.Visible    = true;

                // Recogemos la información de la declaración en variables
                sFechaLimPag        = string.Format("{0}/{1}/{2}", dpFechaPago.Value.Day, dpFechaPago.Value.Month, dpFechaPago.Value.Year);
                sFechaPresentacion  = string.Format("{0}/{1}/{2}", dpFPresentacion.Value.Day, dpFPresentacion.Value.Month, dpFPresentacion.Value.Year);
                iPeriodo            = int.Parse(cbPeriodo.SelectedValue.ToString());
                sDecTipo            = cbDecTipo.SelectedValue.ToString();
                sEstadoPago         = cbEstadoPago.SelectedValue.ToString();
                sAnioDec            = cmbxAnioDeclaracion.Text;
                sLineaCap           = txbLCaptura.Text.ToUpper();
                sNoOpera            = txbNumOperacion.Text.ToUpper();
                sMontoMoney         = MoneyToDecimal(txbMonto.Text);
                sLlavePag           = txbLlavePago.Text.ToUpper();
                iTipoDeclaracion    = int.Parse(cmbxTipoDeclaracion.SelectedValue.ToString());
                iEstadoPago         = cbEstadoPago.SelectedIndex;
                sDecTipoTx          = cbDecTipo.Text;
                

                // Recogemos el listado de conceptos de la declaración en una lista
                RegistrosConceptos = new List<LogicaCC.LexaSIOContaLogica.RegistroConcepto>();
                foreach (DataGridViewRow row in grdConceptos.Rows)
                {
                    LogicaCC.LexaSIOContaLogica.RegistroConcepto item = new LogicaCC.LexaSIOContaLogica.RegistroConcepto()
                    {
                        iIdConcepto     = int.Parse(row.Cells[0].Value.ToString()),
                        sEstado         = row.Cells[2].Value.ToString(),
                        dMonto          = decimal.Parse(MoneyToDecimal(row.Cells[3].Value.ToString())),
                        dActualizacion  = decimal.Parse(MoneyToDecimal(row.Cells[4].Value.ToString())),
                        dRecargos       = decimal.Parse(MoneyToDecimal(row.Cells[5].Value.ToString())),
                        dMultas         = decimal.Parse(MoneyToDecimal(row.Cells[6].Value.ToString())),
                        dTotal          = decimal.Parse(MoneyToDecimal(row.Cells[7].Value.ToString())),
                    };
                    RegistrosConceptos.Add(item);
                }

                // Inciamos el guardado de la declaración
                bgwDeclaracion.RunWorkerAsync();               
            }            
		}

		// EVENTO QUE PERMITE NUMEROS EN EL MONTO
		private void txbMonto_KeyPress(Object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
				e.Handled = true;
		}

        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            //ASIGNA NOMBRE Y FILTROS DEL CONTROL OPENFILEDIALOG
            openFileDialogDocumento.Title       = "Subir Archivos";
            openFileDialogDocumento.FileName    = "";
            openFileDialogDocumento.ShowDialog();
            txtRutaArchivo.Text = Path.GetFileName(openFileDialogDocumento.FileName);
            metroToolTip1.SetToolTip(txtRutaArchivo, openFileDialogDocumento.FileName);
        }

        private void cbDecTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //CARGAR UNA LISTA DE PERIODOS DISPONIBLES DEPENDIENDO DE LA DECLARACIÓN SELECCIONADA
                cbPeriodo.DataSource = new LogicaCC.LexaSIOContaLogica.Declaracion().listaPeriodo(new LogicaCC.LexaSIOContaLogica.Declaracion()
                {
                    iIdCliente           = Cliente.iIdCliente,
                    iAnio                = int.Parse(cmbxAnioDeclaracion.Text),
                    iIdDetalleObligacion = int.Parse(cbDecTipo.SelectedValue.ToString())
                });
                cbPeriodo.DisplayMember = "sPeriodo";
                cbPeriodo.ValueMember   = "iIdPeriodo";

                cbPeriodo.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void cmbxAnioDeclaracion_SelectedIndexChanged(object sender, EventArgs e)
        {
			//OBTENEMOS EL AÑO SELECCIONADO DEL COMBOBOX	
            cbPeriodo.SelectedIndex = -1;
            cbDecTipo.SelectedIndex = -1;
        }

        private void cbEstadoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            //VALIDA SI ESTADO DE PAGO ESTA EN "PAGADA"
            if(cbEstadoPago.SelectedIndex == 3)
            {
                btnSubirArchivo.Visible = true;
                txtRutaArchivo.Visible  = true;
            }
            else
            {
                btnSubirArchivo.Visible = false;
                txtRutaArchivo.Visible  = false;
            }
        }
        
        private void btnAgregarConcepto_Click(object sender, EventArgs e)
        {
            //AGREGAMOS UN NUEVO CONCEPTO DE LA LISTA DE CONCEPTOS AL GRIDVIEW GRDCONCEPTOS
            if (cmbxConcepto.SelectedIndex != -1 && txtImporte.Text != string.Empty)
            {
                string sTotal = (decimal.Parse(string.IsNullOrEmpty(txtImporte.Text) ? "0" : txtImporte.Text)
                               + decimal.Parse(string.IsNullOrEmpty(txtActualizacion.Text) ? "0" : txtActualizacion.Text)
                               + decimal.Parse(string.IsNullOrEmpty(txtRecargos.Text)      ? "0" : txtRecargos.Text)
                               + decimal.Parse(string.IsNullOrEmpty(txtMultas.Text)        ? "0" : txtMultas.Text)).ToString();

                string[] concepto = new string[] { cmbxConcepto.SelectedValue.ToString()
                                                 , cmbxConcepto.Text
                                                 , cmbxEstado.Text
                                                 , string.IsNullOrEmpty(txtImporte.Text)? "$0.00" :FormatToMoney(txtImporte.Text)
                                                 , string.IsNullOrEmpty(txtActualizacion.Text)? "$0.00" : FormatToMoney(txtActualizacion.Text)
                                                 , string.IsNullOrEmpty(txtRecargos.Text)     ? "$0.00" : FormatToMoney(txtRecargos.Text)
                                                 , string.IsNullOrEmpty(txtMultas.Text)       ? "$0.00" : FormatToMoney(txtMultas.Text)
                                                 , FormatToMoney(sTotal)};
                grdConceptos.Rows.Add(concepto);

                dTotal = dTotal + decimal.Parse(sTotal);

                txbMonto.Text = dTotal.ToString("C2");

                cmbxConcepto.SelectedIndex = -1;
                cmbxEstado.Text        = string.Empty;
                txtImporte.Text       = "";
                txtActualizacion.Text = "";
                txtRecargos.Text      = "";
                txtMultas.Text        = "";
            }
            else
            {
                FlatMessageBox.Show("No campos vacios", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDAR QUE SOLO SE INGRESEN NÚMEROS
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void cmbxTipoDeclaracion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbxTipoDeclaracion.SelectedValue.ToString() != "1")
            {
                txtActualizacion.Enabled = true;
                txtRecargos.Enabled      = true;
                txtMultas.Enabled        = true;
                txtActualizacion.Text    = "0";
                txtRecargos.Text         = "0";
                txtMultas.Text           = "0";
                grdConceptos.Rows.Clear();
                grdConceptos.Refresh();
            }
            else
            {
                txtActualizacion.Text    = "0";
                txtRecargos.Text         = "0";
                txtMultas.Text           = "0";
                grdConceptos.Rows.Clear();
                grdConceptos.Refresh();
            }
        }

		private void btnLíneaCaptura_Click(Object sender, EventArgs e)
		{
			if (ofdLineaCaptura.ShowDialog() == DialogResult.OK)
			{
				btnLíneaCaptura.Text	= Path.GetFileName(ofdLineaCaptura.FileName);
				btnLíneaCaptura.Image	= Properties.Resources.file_48px;
				metroToolTip1.SetToolTip(btnLíneaCaptura, ofdLineaCaptura.FileName);
			}
		}

        private void bgwDeclaracion_DoWork(object sender, DoWorkEventArgs e)
        {
            GuardarDeclaracion();
        }

        private void bgwDeclaracion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pgbCarga.Visible    = false;
            txtRutaArchivo.Text = string.Empty;
            openFileDialogDocumento.FileName = "";
            FlatMessageBox.Show("Declaración guardada exitosamente.", "OK", string.Empty, FlatMessageBoxIcon.Information);
            LimpiarControles();
            btnGuardar.Visible = true;
            dTotal = 0;
        }
        #endregion

        #region FUNCIONES
        /// <summary>
        /// Inicializa el contenido de los controles que se cargaran por primera vez
        /// </summary>
        public void InicializaControles()
		{
            int v = 0;
            List<Anio> lista = new List<Anio>();
            lista.Add(new Anio((DateTime.Now.Year - 1).ToString(), DateTime.Now.Year - 1));
            for (int i = DateTime.Now.Year; i < DateTime.Now.Year + 3; i++)
            {
                v++;
                lista.Add(new Anio(i.ToString(), v));
            }

            cmbxAnioDeclaracion.DisplayMember   = "sAnio";
            cmbxAnioDeclaracion.ValueMember     = "iIdAnio";
            cmbxAnioDeclaracion.DataSource      = lista;

            cmbxTipoDeclaracion.DataSource    = new LogicaCC.LexaSIOContaLogica.Declaracion().listaDeclaracionesModo();
            cmbxTipoDeclaracion.DisplayMember = "sDeclaracionModo";
            cmbxTipoDeclaracion.ValueMember   = "iIdDeclaracionModo";
            
            cbDecTipo.DataSource = new LogicaCC.LexaSIOContaLogica.Declaracion().listaDeclaraciones(new LogicaCC.LexaSIOContaLogica.Declaracion()
            {
                iIdCliente = Cliente.iIdCliente
            });
            cbDecTipo.DisplayMember = "sDetalleObligacion";
            cbDecTipo.ValueMember   = "iIdDetalleObligacion";
            cbDecTipo.DropDownWidth = DropDownWidth(cbDecTipo);

			cbEstadoPago.DataSource = new DeclaracionEstado().listaDeclaracionEstado();
			cbEstadoPago.DisplayMember = "sDeclaracionEstado";
			cbEstadoPago.ValueMember = "iIdDeclaracionEstado";

			cbDecTipo.SelectedIndex     = -1;
            cbEstadoPago.SelectedIndex  = 1;

            cmbxConcepto.DataSource     = new LogicaCC.LexaSIOContaLogica.Concepto().listaConceptos();
            cmbxConcepto.DisplayMember  = "sConcepto";
            cmbxConcepto.ValueMember    = "iIdConcepto";
            cmbxConcepto.SelectedIndex  = -1;

            DataSet ds;
            Estados AEstados = new Estados();

            //CARGAMOS LOS ESTADOS
            ds = AEstados.ListaEstados();
            cmbxEstado.DataSource    = ds.Tables["Estados"];
            cmbxEstado.DisplayMember = "estado";
            cmbxEstado.ValueMember   = "id";
            cmbxEstado.SelectedValue = 33;
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

        /// <summary>
        /// Limpia y pone los controles en estado inicial
        /// </summary>
		private void LimpiarControles()
		{
            RegistrosConceptos = null;
            grdConceptos.Rows.Clear();
            cbEstadoPago.SelectedIndex = 0;
            dpFPresentacion.Text       = DateTime.Now.ToString();
            dpFechaPago.Text           = DateTime.Now.ToString();
            txbMonto.Text              = "";
			txbNumOperacion.Text       = "";			
			txbLlavePago.Text          = "";
			txbLCaptura.Text           = "";
			ofdLineaCaptura.FileName   = "";
			btnLíneaCaptura.Text	   = "";

            iPeriodo            = 0;
            iEstadoPago         = 0;
            sFechaLimPag        = "";
            sFechaPresentacion  = "";
            sDecTipo            = "";
            sEstadoPago         = "";
            sAnioDec            = "";
            sLineaCap           = "";
            sNoOpera            = "";
            sMontoMoney         = "";
            sLlavePag           = "";
            sDecTipoTx          = "";

            btnSubirArchivo.Visible = false;
            txtRutaArchivo.Visible  = false;
            EstadoControles(true);
        }

        /// <summary>
        /// Cambia la propiedad Enabled de los controles en el formulario
        /// </summary>
        /// <param name="bEstado"></param>
        private void EstadoControles(bool bEstado)
        {
            cmbxAnioDeclaracion.Enabled = bEstado;
            dpFPresentacion.Enabled     = bEstado;
            dpFechaPago.Enabled         = bEstado;
            txbMonto.Enabled            = bEstado;
            cbEstadoPago.Enabled        = bEstado;
            btnSubirArchivo.Enabled     = bEstado;
            txtRutaArchivo.Enabled      = bEstado;
            cmbxTipoDeclaracion.Enabled = bEstado;
            cbDecTipo.Enabled           = bEstado;
            cbPeriodo.Enabled           = bEstado;
            txbNumOperacion.Enabled     = bEstado;
            txbLCaptura.Enabled         = bEstado;
            txbLlavePago.Enabled        = bEstado;
            cmbxConcepto.Enabled        = bEstado;
            cmbxEstado.Enabled          = bEstado;
            txtImporte.Enabled          = bEstado;
            txtActualizacion.Enabled    = bEstado;
            txtRecargos.Enabled         = bEstado;
            txtMultas.Enabled           = bEstado;
            btnAgregarConcepto.Enabled  = bEstado;
            grdConceptos.Enabled        = bEstado;
            btnLíneaCaptura.Enabled     = bEstado;
            btnGuardar.Enabled          = bEstado;
            btnCancelar.Enabled         = bEstado;
            lnkCerrar.Enabled           = bEstado;
        }

        /// <summary>
        /// Valida que los controles de la declaración tengan información
        /// </summary>
        /// <returns></returns>
		private int ValidarDeclaracion()
		{
            MensajeError.Clear();
            int iResultado = 0;

			if(cmbxAnioDeclaracion.Text.Equals(""))
			{
				MensajeError.SetError(cmbxAnioDeclaracion, "Debe insertar año de la declaracion.");
				iResultado = 1;
			}

			if(cbPeriodo.SelectedIndex == -1)
			{
				MensajeError.SetError(cbPeriodo, "Debe seleccionar un periodo.");
				iResultado = 1;
			}

			if(txbMonto.Text.Equals(""))
			{
				MensajeError.SetError(txbMonto, "Debe insertar año de la declaracion.");
				iResultado = 1;
			}

			if(cbEstadoPago.SelectedIndex == 0)
			{
				MensajeError.SetError(cbEstadoPago, "Debe seleccionar estado del pago.");
				iResultado = 1;
			}

			if(txbLCaptura.Text.Equals(""))
			{
				MensajeError.SetError(txbLCaptura, "Debe proporcionar la linea de captura.");
				iResultado = 1;
			}

			if (string.IsNullOrEmpty(ofdLineaCaptura.FileName))
			{
				MensajeError.SetError(btnLíneaCaptura, "Debe adjuntar un archivo");
				iResultado = 1;
			}

			return iResultado;
		}

        /// <summary>
        /// Sube en el servidor el archivo Linea de captura de la declaración
        /// </summary>
        /// <param name="sIdDeclaracion">Id de la de declaración</param>
        public void SubirLineaCaptura(string sIdDeclaracion)
        {
            try
            {
                // Creamos la carpeta donde se guardara el archivo de la declaración
                FTPServer.CreateDirectory(FTPCredentials.Path, FTPCredentials.User, FTPCredentials.Password, string.Format(@"{0}/-Declaraciones/{1}/", _AltaDeclaracion.Cliente.sCliente, sIdDeclaracion));
                // Guardamos el archivo en la nueva carpeta creada
                string FullPath = string.Format("{0}/{1}/{2}/-Declaraciones/{3}/", FTPCredentials.Path, ConnectionString.FolderConnection, _AltaDeclaracion.Cliente.sCliente, sIdDeclaracion);
                FTPServer.Upload(FullPath, FTPCredentials.User, FTPCredentials.Password, Path.GetFileName(ofdLineaCaptura.FileName), ofdLineaCaptura.FileName);
                // Renombramos el archivo guardado
                FTPServer.RenameFile(FullPath, FTPCredentials.User, FTPCredentials.Password, Path.GetFileName(ofdLineaCaptura.FileName), sIdDeclaracion + Path.GetExtension(ofdLineaCaptura.FileName));
            }
            catch (Exception)
            {
                //throw;
            }
        }

        /// <summary>
        /// Realiza la carga del archivo de pago de la declaración en el servidor
        /// </summary>
        public void cargarArchivos(int iIdDeclaracion)
        {
            //VALIDA SI ESTADO DE PAGO ESTA EN "PAGADA"
            if (iEstadoPago == 3)
            {
                try
                {
                    // VALIDA SI LOS DIRECTORIO EXISTEN, SI NO, SE CREAN LAS CARPETAS
                    FTPServer.CreateDirectory(FTPCredentials.Path, FTPCredentials.User, FTPCredentials.Password, string.Format(@"{0}/04. Declaraciones, acuses y pagos de impuestos federales/Pagos/{1}/{2}/", _AltaDeclaracion.Cliente.sCliente, sDecTipoTx, DateTime.Now.ToString("dd-MM-yyyy")));

                    //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO
                    int i = FTPServer.CountFileList(FTPCredentials.Path, FTPCredentials.User, FTPCredentials.Password, string.Format(@"{0}/04. Declaraciones, acuses y pagos de impuestos federales/Pagos/{1}/{2}/", _AltaDeclaracion.Cliente.sCliente, sDecTipoTx, DateTime.Now.ToString("dd-MM-yyyy")));

                    //COPIA Y CAMBIA EL NOMBRE DE LOS ARCHIVO SELECCIONADOS EN EL CONTROL OPENFILEDIALOG
                    foreach (string fileName in openFileDialogDocumento.FileNames)
                    {
                        //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
                        i++;
                        string FullPath = string.Format("{0}/{1}/{2}/04. Declaraciones, acuses y pagos de impuestos federales/Pagos/{3}/{4}", FTPCredentials.Path, ConnectionString.FolderConnection, _AltaDeclaracion.Cliente.sCliente, sDecTipoTx, DateTime.Now.ToString("dd-MM-yyyy"));
                        FTPServer.Upload(FullPath, FTPCredentials.User, FTPCredentials.Password, Path.GetFileName(fileName), fileName);
                        FTPServer.RenameFile(FullPath, FTPCredentials.User, FTPCredentials.Password, Path.GetFileName(fileName), i.ToString() + DateTime.Now.ToString("ddMMyyyy") + Path.GetExtension(fileName));

                        //GUARDA UN REGISTRO DE LA RUTA DONDE SE GUARDO EL ARCHIVO
                        new Adjunto().insertarAdjunto(new Adjunto()
                        {
                            iIdDeclaracion          = iIdDeclaracion,
                            iIdRegistroObligacion   = int.Parse(sDecTipo),
                            iIdCliente              = Cliente.iIdCliente,
                            sAdjunto                = string.Format("{0}/{1}/{2}/04. Declaraciones, acuses y pagos de impuestos federales/Pagos/{3}/{4}/{5}", FTPCredentials.Path, ConnectionString.FolderConnection, _AltaDeclaracion.Cliente.sCliente, sDecTipoTx, DateTime.Now.ToString("dd-MM-yyyy"), i.ToString() + DateTime.Now.ToString("ddMMyyyy") + Path.GetExtension(fileName))
                        });
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        /// <summary>
        /// Retorna un monto en tipo cadena a moneda con formato
        /// </summary>
        /// <param name="sImport"></param>
        /// <returns></returns>
        public string FormatToMoney(string sImport)
        {
            return decimal.Parse(sImport).ToString("C2");
        }

        /// <summary>
        /// Retorna una cantidad en moneda a decimal
        /// </summary>
        /// <param name="sImport"></param>
        /// <returns></returns>
        public string MoneyToDecimal(string sImport)
        {
            string[] Import  = sImport.Split('$');
            decimal dImporte = Decimal.Parse(Import[1]);
            return dImporte.ToString();
        }

        /// <summary>
        /// Método Público para escribir un log de los cambios de los archivos del expediente en linea
        /// </summary>
        /// <param name="strMessage">Mensaje que se guardara en el log.</param>
        public void EscribirLog(string strMessage)
        {
            //VALIDACIÓN SI EL ARCHIVO EXISTE
		    if (!File.Exists(@"\\192.168.1.34\\Documentos\\" + LogicaCC.ConnectionString.FolderConnection + "\\Documentos\\Clientes\\" + sCliente + "\\" + @"Expediente en Linea\Log.txt"))
            {
                var myFile = File.Create(@"\\192.168.1.34\\Documentos\\" + LogicaCC.ConnectionString.FolderConnection + "\\Documentos\\Clientes\\" + sCliente + "\\" + @"Expediente en Linea\Log.txt");
                myFile.Close();
            }

            //RUTA DE ACCESO DEL ARCHIVO LOG
            //string logFile = @"\\192.169.143.34\MiPyme_Files\Documentos\Clientes\" + sCliente + @"\Expediente en Linea\Log.txt";
		    string logFile = @"\\192.168.1.34\Documentos\" + LogicaCC.ConnectionString.FolderConnection + @"\Documentos\Clientes\" + sCliente + @"\Expediente en Linea\Log.txt";

            //APLICA FORMATO AL LOG Y ESCRIBE EL MENSAJE QUE SE PASA EN EL PARAMETRO STRMENSAJE.
            string line = string.Format("{0} | {1} | ", DateTime.Now, AUsuario.sIdusuario);
            line += strMessage;
            FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter swFromFileStream = new StreamWriter(fs);
            swFromFileStream.WriteLine(line);
            swFromFileStream.Flush();
            swFromFileStream.Close();
        }

        /// <summary>
        /// Realiza el alta de la declaración en la base de datos
        /// </summary>
        public void GuardarDeclaracion()
        {
            //string sFechaLimPag = string.Format("{0}/{1}/{2}", dpFechaPago.Value.Day, dpFechaPago.Value.Month, dpFechaPago.Value.Year);
            //string sFechaPresentacion = string.Format("{0}/{1}/{2}", dpFPresentacion.Value.Day, dpFPresentacion.Value.Month, dpFPresentacion.Value.Year);
            int iIdDeclaracion = new LogicaCC.LexaSIOContaLogica.Declaracion().AddStatement(new LogicaCC.LexaSIOContaLogica.Declaracion()
            {
                iIdCliente = Cliente.iIdCliente,
                //iIdPeriodo = int.Parse(cbPeriodo.SelectedValue.ToString()),
                iIdPeriodo = iPeriodo,
                //sIdDeclaracionTipo = cbDecTipo.SelectedValue.ToString(),
                sIdDeclaracionTipo = sDecTipo,
                //sIdDecEstado = cbEstadoPago.SelectedValue.ToString(),
                sIdDecEstado = sEstadoPago,
                sIdUsuario = AUsuario.sIdusuario,
                //sAñoDec = cmbxAnioDeclaracion.Text,
                sAñoDec = sAnioDec,
                //sLinCap = txbLCaptura.Text.ToUpper(),
                sLinCap = sLineaCap,
                //sNumOper = txbNumOperacion.Text.ToUpper(),
                sNumOper = sNoOpera,
                //sMonto = MoneyToDecimal(txbMonto.Text),
                sMonto = sMontoMoney,
                //sLlavePago = txbLlavePago.Text.ToUpper(),
                sLlavePago = sLlavePag,
                sFechaLimPag = sFechaLimPag,
                sFechaPresentacion = sFechaPresentacion,
                //iIdDeclaracionModo = int.Parse(cmbxTipoDeclaracion.SelectedValue.ToString())
                iIdDeclaracionModo = iTipoDeclaracion
            });
            if (iIdDeclaracion > 0)
            {
                for (int i = 0; i < RegistrosConceptos.Count; i++)
                {
                    new LogicaCC.LexaSIOContaLogica.RegistroConcepto().InsertarRegistroObligacion(new LogicaCC.LexaSIOContaLogica.RegistroConcepto()
                    {
                        iIdConcepto    = RegistrosConceptos[i].iIdConcepto,
                        sEstado        = RegistrosConceptos[i].sEstado,
                        dMonto         = RegistrosConceptos[i].dMonto,
                        dActualizacion = RegistrosConceptos[i].dActualizacion,
                        dRecargos      = RegistrosConceptos[i].dRecargos,
                        dMultas        = RegistrosConceptos[i].dMultas,
                        dTotal         = RegistrosConceptos[i].dTotal,
                        iIdDeclaracion = iIdDeclaracion
                    });
                }
                SubirLineaCaptura(iIdDeclaracion.ToString());
                cargarArchivos(iIdDeclaracion);
            }
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

            //if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
            //    m.Result = (IntPtr)HTCAPTION;

        }
        #endregion

    }
}

public class Anio
{
    public string sAnio     { get; set; }
    public int    iIdAnio   { get; set; }

    public Anio(string name, int value)
    {
        sAnio   = name;
        iIdAnio = value;
    }
    public override string ToString()
    {
        return sAnio;
    }
}
