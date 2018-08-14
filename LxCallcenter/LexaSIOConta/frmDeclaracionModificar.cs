using LogicaCC;
using LogicaCC.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter.LexaSIOConta
{
    public partial class frmDeclaracionModificar : Form
    {
        static UsuarioData AUsuario = UsuarioData.Instancia;
        FTPDownload DownloadData = FTPDownload.Instancia;
        static DeclaracionEstado declaracionEstado;
        List<LogicaCC.LexaSIOContaLogica.RegistroConcepto> ConceptsStatement = null;
        List<LogicaCC.LexaSIOContaLogica.RegistroConcepto> NewConcepts       = new List<LogicaCC.LexaSIOContaLogica.RegistroConcepto>();
        List<LogicaCC.LexaSIOContaLogica.RegistroConcepto> DeleteConcepts    = new List<LogicaCC.LexaSIOContaLogica.RegistroConcepto>();
        public List<LogicaCC.LexaSIOContaLogica.RegistroConcepto> RegistrosConceptos;

        int       iIdPeriodo;
        int       iIdStatement;
        int       iIdClient;
        int       iAnio;
        int       iIdDeclaracionModo;
        string    sClient;
        string    sIdDeclaracionTipo;
        string    sIdDecEstado;
        string    sLinCap;
        string    sNumOper;
        string    sLlavePago;
        string    sEstadoPago;
        string    sDecTipoTx;
        decimal   dMonto;
        decimal   dTotal = 0;
        DateTime  dtFechaLimitePago;
        DateTime  dtFechaPresentacion;
        DateTime? dtFechaPag;

        public frmDeclaracionModificar()
        {
            InitializeComponent();
        }

        static frmDeclaracionModificar _Editar;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show(int iIdDeclaracion, int iIdCliente, string sNoCliente)
        {
            _Editar = new frmDeclaracionModificar();
            _Editar.StartPosition = FormStartPosition.CenterScreen;

            _Editar.InitializeControls(iIdCliente);
            _Editar.LoadStatement(iIdDeclaracion, sNoCliente);

            _DialogResult = DialogResult.No;

            _Editar.Activate();
            _Editar.ShowDialog();
            return _DialogResult;
        }

        #region EVENTOS
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _DialogResult = DialogResult.No;
            _Editar.Close();
        }

        private void btnLíneaCaptura_Click(object sender, EventArgs e)
        {
            if (ofdLineaCaptura.ShowDialog() == DialogResult.OK)
			{
				btnLíneaCaptura.Text	= Path.GetFileName(ofdLineaCaptura.FileName);
				btnLíneaCaptura.Image	= Properties.Resources.file_48px;
				metroToolTip1.SetToolTip(btnLíneaCaptura, ofdLineaCaptura.FileName);
                lnkGuardarLineaCaptura.Visible      = false;
                lnkRestaurarLineaCaptura.Visible    = true;
                lnkRestaurarLineaCaptura.Location   = new Point(283, 594);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateArchivoPago())
            {
                if (FlatMessageBox.Show("¿Está seguro de actualizar la declaración?.", "SI", "NO", FlatMessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Cambiamos el estado de los controles
                    EstadoControles(false);
                    btnGuardar.Visible  = false;
                    pgbCarga.Visible    = true;

                    // Recogemos la información de la declaración en variables
                    iIdPeriodo          = int.Parse(_Editar.cbPeriodo.SelectedValue.ToString());
                    sIdDeclaracionTipo  = _Editar.cbDecTipo.SelectedValue.ToString();
                    sIdDecEstado        = _Editar.cbEstadoPago.SelectedValue.ToString();    
                    iAnio               = int.Parse(_Editar.cmbxAnioDeclaracion.Text);
                    sLinCap             = txbLCaptura.Text.ToUpper();
                    sNumOper            = txbNumOperacion.Text.ToUpper();
                    dMonto              = Decimal.Parse(MoneyToDecimal(txbMonto.Text));
                    sLlavePago          = txbLlavePago.Text.ToUpper();
                    dtFechaLimitePago   = dpFechaLimitePago.Value;
                    dtFechaPresentacion = dpFPresentacion.Value;
                    dtFechaPag          = _Editar.dtFechaPago.Visible ? dtFechaPago.Value : (DateTime?)null;
                    iIdDeclaracionModo  = int.Parse(cmbxTipoDeclaracion.SelectedValue.ToString());
                    sEstadoPago         = cbEstadoPago.Text;

                    sDecTipoTx = cbDecTipo.Text;

                    // Recogemos el listado de conceptos de la declaración en una lista
                    RegistrosConceptos = new List<LogicaCC.LexaSIOContaLogica.RegistroConcepto>();
                    foreach (DataGridViewRow row in grdConceptos.Rows)
                    {
                        if (int.Parse(row.Cells[0].Value.ToString()) < 0)
                        {
                            LogicaCC.LexaSIOContaLogica.RegistroConcepto item = new LogicaCC.LexaSIOContaLogica.RegistroConcepto()
                            {
                                iIdConcepto    = int.Parse(row.Cells[1].Value.ToString()),
                                sEstado        = row.Cells[3].Value.ToString(),
                                dMonto         = decimal.Parse(row.Cells[4].Value.ToString()),
                                dActualizacion = decimal.Parse(row.Cells[5].Value.ToString()),
                                dRecargos      = decimal.Parse(row.Cells[6].Value.ToString()),
                                dMultas        = decimal.Parse(row.Cells[7].Value.ToString()),
                                dTotal         = decimal.Parse(row.Cells[8].Value.ToString()),
                                iIdDeclaracion = _Editar.iIdStatement
                            };
                            RegistrosConceptos.Add(item);
                        }
                    }
                    // Inciamos el guardado de la declaración
                    bgwDeclaracion.RunWorkerAsync(); 
                }  
            }
            else
                FlatMessageBox.Show("Archivo de pago vacío.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
        }

        private void btnDeleteConcept_Click(object sender, EventArgs e)
        {
            int iIdConcept   = (int)grdConceptos.SelectedRows[0].Cells[0].Value;
            var itemToRemove = ConceptsStatement.Single(x => x.iIdRegistroConcepto == iIdConcept);

            if (iIdConcept > 0)
                DeleteConcepts.Add(itemToRemove);

            ConceptsStatement.Remove(itemToRemove);

            grdConceptos.DataSource = null;
            grdConceptos.DataSource = ConceptsStatement;

            decimal dTo = ConceptsStatement.Sum(x => x.dTotal);

            txbMonto.Text = dTo.ToString("C2");
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

                int iIdNewConcept = 0 - (NewConcepts.Count() + 1);

                LogicaCC.LexaSIOContaLogica.RegistroConcepto NewConcept = new LogicaCC.LexaSIOContaLogica.RegistroConcepto()
                {
                    iIdRegistroConcepto = iIdNewConcept,
                    iIdConcepto         = int.Parse(cmbxConcepto.SelectedValue.ToString()),
                    sConcepto           = cmbxConcepto.Text,
                    sEstado             = string.Empty,
                    dMonto              = string.IsNullOrEmpty(txtImporte.Text)      ? 0 : Decimal.Parse(txtImporte.Text),
                    dActualizacion      = string.IsNullOrEmpty(txtActualizacion.Text)? 0 : Decimal.Parse(txtActualizacion.Text),
                    dRecargos           = string.IsNullOrEmpty(txtRecargos.Text)     ? 0 : Decimal.Parse(txtRecargos.Text),
                    dMultas             = string.IsNullOrEmpty(txtMultas.Text)       ? 0 : Decimal.Parse(txtMultas.Text),
                    dTotal              = Decimal.Parse(sTotal)
                };
                NewConcepts.Add(NewConcept);
                ConceptsStatement.Add(NewConcept);

                dTotal = dTotal + decimal.Parse(sTotal);

                decimal dTo = ConceptsStatement.Sum(x => x.dTotal);

                txbMonto.Text = dTo.ToString("C2");

                cmbxConcepto.SelectedIndex = -1;
                txtImporte.Text       = "";
                txtActualizacion.Text = "";
                txtRecargos.Text      = "";
                txtMultas.Text        = "";

                grdConceptos.DataSource = null;
                grdConceptos.DataSource = ConceptsStatement;
            }
            else
                FlatMessageBox.Show("No campos vacios", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
        }

        private void cbEstadoPago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //VALIDA SI ESTADO DE PAGO ESTA EN ESTADO "PAGADA"
            if (cbEstadoPago.SelectedIndex == 3)
            {
                dtFechaPago.Visible     = true;
                materialLabel5.Visible  = true;
                materialLabel4.Visible  = true;
                btnArchivoPago.Visible  = true;
                lnkGuardarArchivoPago.Visible = declaracionEstado.iIdDeclaracionEstado == 4 ? true : false;
            }
            else
            {
                dtFechaPago.Visible     = false;
                materialLabel5.Visible  = false;
                materialLabel4.Visible  = false;
                btnArchivoPago.Visible  = false;

                lnkGuardarArchivoPago.Visible       = false;
                lnkRestaurarArchivoPago.Visible     = false;
                openFileDialogDocumento.FileName    = "";
                btnArchivoPago.Text                 = "Archivo de Pago";
                metroToolTip1.SetToolTip(btnArchivoPago, "");
            }
        }

        private void btnArchivoPago_Click(object sender, EventArgs e)
        {
            if (openFileDialogDocumento.ShowDialog() == DialogResult.OK)
            {
                btnArchivoPago.Text = Path.GetFileName(openFileDialogDocumento.FileName);
                metroToolTip1.SetToolTip(btnArchivoPago, openFileDialogDocumento.FileName);

                lnkRestaurarArchivoPago.Location    = new Point(606, 594);
                lnkRestaurarArchivoPago.Visible     = true;
            }
        }

        private void lnkRestaurarLineaCaptura_Click(object sender, EventArgs e)
        {
            ofdLineaCaptura.FileName            = "";
            btnLíneaCaptura.Text                = "Línea de Captura.pdf";
            lnkRestaurarLineaCaptura.Visible    = false;
            lnkGuardarLineaCaptura.Visible      = true;
            metroToolTip1.SetToolTip(btnLíneaCaptura, "");
        }

        private void lnkGuardarLineaCaptura_Click(object sender, EventArgs e)
        {
            DownloadData.sRutaArchivo   = string.Format("ftp://{0}/{1}/{2}/-Declaraciones/{3}", FTPCredentials.Path, ConnectionString.FolderConnection, _Editar.sClient, _Editar.iIdStatement);
            DownloadData.sNombreArchivo = string.Format("{0}.pdf", _Editar.iIdStatement);

            frmDescargarArchivos DownloadFile = new frmDescargarArchivos();
            DownloadFile.StartPosition  = FormStartPosition.Manual;
            DownloadFile.Location       = new Point((Screen.PrimaryScreen.WorkingArea.Width - DownloadFile.Width) - 10
                                                  , (Screen.PrimaryScreen.WorkingArea.Height - DownloadFile.Height) - 10);
            DownloadFile.ShowDialog();
        }

        private void lnkRestaurarArchivoPago_Click(object sender, EventArgs e)
        {
            btnArchivoPago.Text                = "Archivo de pago";
            lnkRestaurarArchivoPago.Visible    = false;
            if (declaracionEstado.iIdDeclaracionEstado == 4)
                lnkGuardarArchivoPago.Visible      = true;
            metroToolTip1.SetToolTip(btnArchivoPago, "");
        }

        private void lnkGuardarArchivoPago_Click(object sender, EventArgs e)
        {
            string sPathFile = new Adjunto().GetPathAttachment(_Editar.iIdStatement);
            if (!string.IsNullOrEmpty(sPathFile))
            {
                DownloadData.sRutaArchivo   = string.Format("ftp://{0}", Path.GetDirectoryName(sPathFile)).Replace(@"\", "/");
                DownloadData.sNombreArchivo = Path.GetFileName(sPathFile);

                frmDescargarArchivos DownloadFile = new frmDescargarArchivos();
                DownloadFile.StartPosition = FormStartPosition.Manual;
                DownloadFile.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - DownloadFile.Width) - 10
                                                      , (Screen.PrimaryScreen.WorkingArea.Height - DownloadFile.Height) - 10);
                DownloadFile.ShowDialog();

            }
            else if (sPathFile == "Error de Conexión")
                FlatMessageBox.Show("Error de Conexón", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
            else if (string.IsNullOrEmpty(sPathFile))
                FlatMessageBox.Show("No se encontro el archivo adjunto", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
        }

        private void bgwDeclaracion_DoWork(object sender, DoWorkEventArgs e)
        {
            _Editar.SaveStatement();
        }

        private void bgwDeclaracion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EstadoControles(true);
            pgbCarga.Visible     = false;
            btnLíneaCaptura.Text = "Línea de Captura.pdf";
            btnArchivoPago.Text  = "Archivo de Pago";
            openFileDialogDocumento.FileName = "";
            ofdLineaCaptura.FileName = "";
            btnGuardar.Visible = true;
            dTotal = 0;
        }
        
        #endregion

        #region FUNCIONES
        /// <summary>
        /// Inicializa el contenido de los controles por primera vez
        /// </summary>
        /// <param name="iIdClient">Id del cliente</param>
        public void InitializeControls(int iIdClient)
        {
            _Editar.iIdClient = iIdClient;
            int v = 0;
            List<Anio> lista = new List<Anio>();
            lista.Add(new Anio((DateTime.Now.Year - 1).ToString(), DateTime.Now.Year - 1));
            for (int i = DateTime.Now.Year; i < DateTime.Now.Year + 3; i++)
            {
                v++;
                lista.Add(new Anio(i.ToString(), v));
            }

            _Editar.cmbxAnioDeclaracion.DataSource      = lista;
            _Editar.cmbxAnioDeclaracion.DisplayMember   = "sAnio";
            _Editar.cmbxAnioDeclaracion.ValueMember     = "iIdAnio";

            _Editar.cmbxTipoDeclaracion.DataSource      = new LogicaCC.LexaSIOContaLogica.Declaracion().listaDeclaracionesModo();
            _Editar.cmbxTipoDeclaracion.DisplayMember   = "sDeclaracionModo";
            _Editar.cmbxTipoDeclaracion.ValueMember     = "iIdDeclaracionModo";

            _Editar.cbDecTipo.DataSource = new LogicaCC.LexaSIOContaLogica.Declaracion().listaDeclaraciones(new LogicaCC.LexaSIOContaLogica.Declaracion()
            {
                iIdCliente = iIdClient
            });
            _Editar.cbDecTipo.DisplayMember     = "sDetalleObligacion";
            _Editar.cbDecTipo.ValueMember       = "iIdDetalleObligacion";
            _Editar.cbDecTipo.DropDownWidth     = DropDownWidth(_Editar.cbDecTipo);

            _Editar.cbEstadoPago.DataSource     = new DeclaracionEstado().listaDeclaracionEstado();
            _Editar.cbEstadoPago.DisplayMember  = "sDeclaracionEstado";
            _Editar.cbEstadoPago.ValueMember    = "iIdDeclaracionEstado";

            _Editar.cbEstadoPago.SelectedIndex  = 1;

            _Editar.cmbxConcepto.DataSource     = new LogicaCC.LexaSIOContaLogica.Concepto().listaConceptos();
            _Editar.cmbxConcepto.DisplayMember  = "sConcepto";
            _Editar.cmbxConcepto.ValueMember    = "iIdConcepto";
            _Editar.cmbxConcepto.SelectedIndex  = -1;

           _Editar.cbPeriodo.DataSource = new LogicaCC.LexaSIOContaLogica.Declaracion().listaPeriodo(new LogicaCC.LexaSIOContaLogica.Declaracion()
            {
                iIdCliente              = iIdClient,
                iAnio                   = int.Parse(DateTime.Now.Year.ToString()),
                iIdDetalleObligacion    = int.Parse(_Editar.cbDecTipo.SelectedValue.ToString())
            });
            _Editar.cbPeriodo.DisplayMember     = "sPeriodo";
            _Editar.cbPeriodo.ValueMember       = "iIdPeriodo";
        }

        /// <summary>
        /// Obtiene el tamaño maximo que tendra un combobox de acuerdo al tamaño de sus items
        /// </summary>
        /// <param name="myCombo">ComboBox del cual se obtendran los items para establecer el tamaño</param>
        /// <returns></returns>
        //int DropDownWidth(MetroFramework.Controls.MetroComboBox myCombo)
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
                    pinfo   = objectType.GetProperty(myCombo.DisplayMember);
                    toCheck = pinfo.GetValue(o, null).ToString();
                }
                if (TextRenderer.MeasureText(toCheck, myCombo.Font).Width > widestStringInPixels)
                    widestStringInPixels = TextRenderer.MeasureText(toCheck, myCombo.Font).Width;
            }
            return widestStringInPixels + 45;
        }

        /// <summary>
        /// Carga la información de la declaración por primera vez
        /// </summary>
        /// <param name="iIdStatement"></param>
        /// <param name="sClient"></param>
        public void LoadStatement(int iIdStatement, string sClient)
        {
            _Editar.iIdStatement    = iIdStatement;
            _Editar.sClient         = sClient;
            //SE OBTIENE LA INFORMACIÓN DE LAS OBLIGACIONES
            declaracionEstado = new DeclaracionEstado().informacionDeclaracion(iIdStatement);
            //ASIGNA LA INFORMACIÓN A LOS CONTROLES
            cmbxAnioDeclaracion.Text    = declaracionEstado.iAnioDeclaracion.ToString();
            dpFPresentacion.Value       = DateTime.Parse(declaracionEstado.sFechaPresentacion);
            txbMonto.Text               = FormatToMoney(declaracionEstado.sMonto);
            dpFechaLimitePago.Value     = DateTime.Parse(declaracionEstado.sFechaLimitePago);
            cbEstadoPago.SelectedIndex  = declaracionEstado.iIdDeclaracionEstado - 1;
            cbDecTipo.Text              = declaracionEstado.sDeclaracionTipo;
            cbPeriodo.Text              = declaracionEstado.sPeriodoDeclaracion;
            txbNumOperacion.Text        = declaracionEstado.sNumOperacion;
            txbLlavePago.Text           = declaracionEstado.sLlavePago;
            txbLCaptura.Text            = declaracionEstado.sLineaCaptura;
            cmbxTipoDeclaracion.Text    = declaracionEstado.sDeclaracionModo;

            if (declaracionEstado.dtFechaPago.HasValue)
            {
                dtFechaPago.Value       = declaracionEstado.dtFechaPago.Value;
                dtFechaPago.Visible     = true;
                materialLabel5.Visible  = true;
            }

            grdConceptos.AutoGenerateColumns = false;
            ConceptsStatement = new LogicaCC.LexaSIOContaLogica.RegistroConcepto().GetConceptsStatement(iIdStatement);
            grdConceptos.DataSource = ConceptsStatement;

            if (cbEstadoPago.Text == "Pagada")
            {
                materialLabel4.Visible          = true;
                btnArchivoPago.Visible          = true;
                lnkGuardarArchivoPago.Visible   = true;
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
            string[] Import     = sImport.Split('$');
            decimal dImporte    = Decimal.Parse(Import[1]);

            return dImporte.ToString();
        }

        /// <summary>
        /// Cambia la propiedad Enabled de los controles en el formulario
        /// </summary>
        /// <param name="bEstado"></param>
        private void EstadoControles(bool bEstado)
        {
            cmbxAnioDeclaracion.Enabled = bEstado;
            dpFPresentacion.Enabled     = bEstado;
            dtFechaPago.Enabled         = bEstado;
            txbMonto.Enabled            = bEstado;
            cbEstadoPago.Enabled        = bEstado;
            btnLíneaCaptura.Enabled     = bEstado;
            btnArchivoPago.Enabled      = bEstado;
            cmbxTipoDeclaracion.Enabled = bEstado;
            cbDecTipo.Enabled           = bEstado;
            cbPeriodo.Enabled           = bEstado;
            txbNumOperacion.Enabled     = bEstado;
            txbLCaptura.Enabled         = bEstado;
            txbLlavePago.Enabled        = bEstado;
            cmbxConcepto.Enabled        = bEstado;
            txtImporte.Enabled          = bEstado;
            txtActualizacion.Enabled    = bEstado;
            txtRecargos.Enabled         = bEstado;
            txtMultas.Enabled           = bEstado;
            btnAgregarConcepto.Enabled  = bEstado;
            grdConceptos.Enabled        = bEstado;
            btnLíneaCaptura.Enabled     = bEstado;
            btnGuardar.Enabled          = bEstado;
            btnCancelar.Enabled         = bEstado;
        }

        /// <summary>
        /// Realiza el alta de la declaración en la base de datos
        /// </summary>
        public void SaveStatement()
        {
            int iResultado = new LogicaCC.LexaSIOContaLogica.Declaracion().UpdateStatement(new LogicaCC.LexaSIOContaLogica.Declaracion()
            {
                iIdDeclaracion      = _Editar.iIdStatement,
                iIdPeriodo          = iIdPeriodo,
                sIdDeclaracionTipo  = sIdDeclaracionTipo,
                sIdDecEstado        = sIdDecEstado,
                sIdUsuario          = AUsuario.sIdusuario,
                iAnio               = iAnio,
                sLinCap             = sLinCap,
                sNumOper            = sNumOper,
                dMonto              = dMonto,
                sLlavePago          = sLlavePago,
                dtFechaLimitePago   = dtFechaLimitePago,
                dtFechaPresentacion = dtFechaPresentacion,
                dtFechaPago         = dtFechaPag,
                iIdDeclaracionModo  = iIdDeclaracionModo
            });

            if (iResultado == 1)
            {
                // Lista de Conceptos Eliminados
                foreach (LogicaCC.LexaSIOContaLogica.RegistroConcepto item in DeleteConcepts)
                    new LogicaCC.LexaSIOContaLogica.RegistroConcepto().DeleteConcept(item.iIdRegistroConcepto);
                
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
                        iIdDeclaracion = _Editar.iIdStatement
                    });
                }

                UploadArchivoPago();

                if (UploadLineaCaptura())
                    FlatMessageBox.Show("Declaración actualizada exitosamente.", "OK", string.Empty, FlatMessageBoxIcon.Information);
                else
                    FlatMessageBox.Show("Error al actualizar el archivo de Línea de Captura.", "OK", string.Empty, FlatMessageBoxIcon.Warning);
            }
            else if (iResultado == 0)
                FlatMessageBox.Show("Error al actualizar en la base de datos.", "OK", string.Empty, FlatMessageBoxIcon.Error);
            else if (iResultado == -1)
                FlatMessageBox.Show("Error de conexión.", "OK", string.Empty, FlatMessageBoxIcon.Warning);
        }

        /// <summary>
        /// Sube en el servidor el archivo Linea de captura de la declaración
        /// </summary>
        /// <returns></returns>
        public bool UploadLineaCaptura()
        {
            try
            {
                if (!string.IsNullOrEmpty(ofdLineaCaptura.FileName))
                {
                    // Guardamos el archivo en la nueva carpeta creada
                    string FullPath = string.Format("{0}/{1}/{2}/-Declaraciones/{3}/", FTPCredentials.Path, ConnectionString.FolderConnection, _Editar.sClient, _Editar.iIdStatement);

                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}.pdf", FullPath, _Editar.iIdStatement));
                    request.Method = WebRequestMethods.Ftp.DeleteFile;
                    request.Credentials = new NetworkCredential(FTPCredentials.User, FTPCredentials.Password);
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    response.Close();

                    // Creamos la carpeta donde se guardara el archivo de la declaración
                    FTPServer.CreateDirectory(FTPCredentials.Path, FTPCredentials.User, FTPCredentials.Password, string.Format(@"{0}/-Declaraciones/{1}/", _Editar.sClient, _Editar.iIdStatement));
                    FTPServer.Upload(FullPath, FTPCredentials.User, FTPCredentials.Password, Path.GetFileName(ofdLineaCaptura.FileName), ofdLineaCaptura.FileName);
                    // Renombramos el archivo guardado
                    FTPServer.RenameFile(FullPath, FTPCredentials.User, FTPCredentials.Password, Path.GetFileName(ofdLineaCaptura.FileName), _Editar.iIdStatement.ToString() + Path.GetExtension(ofdLineaCaptura.FileName));
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Realiza la carga del archivo de pago de la declaración en el servidor
        /// </summary>
        /// <returns></returns>
        public bool UploadArchivoPago()
        {
            try
            {
                if (sEstadoPago == "Pagada")
                {
                    if (!string.IsNullOrEmpty(openFileDialogDocumento.FileName))
                    {
                        //VALIDA SI LOS DIRECTORIO EXISTEN, SI NO, SE CREAN LAS CARPETAS
                        FTPServer.CreateDirectory(FTPCredentials.Path, FTPCredentials.User, FTPCredentials.Password, string.Format(@"{0}/04. Declaraciones, acuses y pagos de impuestos federales/Pagos/{1}/{2}/", _Editar.sClient, sDecTipoTx, DateTime.Now.ToString("dd-MM-yyyy")));

                        //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO
                        int i = FTPServer.CountFileList(FTPCredentials.Path, FTPCredentials.User, FTPCredentials.Password, string.Format(@"{0}/04. Declaraciones, acuses y pagos de impuestos federales/Pagos/{1}/{2}/", _Editar.sClient, sDecTipoTx, DateTime.Now.ToString("dd-MM-yyyy")));

                        //COPIA Y CAMBIA EL NOMBRE DE LOS ARCHIVO SELECCIONADOS EN EL CONTROL OPENFILEDIALOG
                        foreach (string fileName in openFileDialogDocumento.FileNames)
                        {
                            //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
                            i++;
                            string FullPath = string.Format("{0}/{1}/{2}/04. Declaraciones, acuses y pagos de impuestos federales/Pagos/{3}/{4}", FTPCredentials.Path, ConnectionString.FolderConnection, _Editar.sClient, sDecTipoTx, DateTime.Now.ToString("dd-MM-yyyy"));
                            FTPServer.Upload(FullPath, FTPCredentials.User, FTPCredentials.Password, Path.GetFileName(fileName), fileName);
                            FTPServer.RenameFile(FullPath, FTPCredentials.User, FTPCredentials.Password, Path.GetFileName(fileName), i.ToString() + DateTime.Now.ToString("ddMMyyyy") + Path.GetExtension(fileName));

                            //GUARDA UN REGISTRO DE LA RUTA DONDE SE GUARDO EL ARCHIVO
                            new Adjunto().insertarAdjunto(new Adjunto()
                            {
                                iIdDeclaracion          = _Editar.iIdStatement,
                                iIdRegistroObligacion   = int.Parse(cbDecTipo.SelectedValue.ToString()),
                                iIdCliente              = _Editar.iIdClient,
                                sAdjunto                = string.Format("{0}/{1}/{2}/04. Declaraciones, acuses y pagos de impuestos federales/Pagos/{3}/{4}/{5}", FTPCredentials.Path, ConnectionString.FolderConnection, _Editar.sClient, sDecTipoTx, DateTime.Now.ToString("dd-MM-yyyy"), i.ToString() + DateTime.Now.ToString("ddMMyyyy") + Path.GetExtension(fileName))
                            });
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Valida si se ha adjuntado el archivo de pago
        /// </summary>
        /// <returns></returns>
        public bool ValidateArchivoPago()
        {
            bool bResultado = false;

            if (cbEstadoPago.Text == "Pagada")
            {
                if (declaracionEstado.iIdDeclaracionEstado != 4)
                {
                    if (openFileDialogDocumento.FileName != string.Empty)
                        bResultado = true;
                }
                else
                    bResultado = true;
            }
            else
                bResultado = true;
            return bResultado;
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
