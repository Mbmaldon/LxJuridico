using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.LexaSIOOperLogica;
using LogicaCC.Logica;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
	public partial class frmConciliacion : Form
	{
		UsuarioData AUsuarioData = UsuarioData.Instancia;
		private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
		private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

		
		bool bBanco1 = false;
		bool bBanco2 = false;
		bool bBanco3 = false;

		public frmConciliacion()
		{
			InitializeComponent();
		}


		#region EVENTOS
		private void btnBanco1_Click(Object sender, EventArgs e)
		{
            // Selección del archivo para pagos en BANORTE
			if (ofdBanco1.ShowDialog() == DialogResult.OK)
			{
				btnBanco1.Text	= Path.GetFileName(ofdBanco1.FileName);
				bBanco1			= true;
				metroToolTip1.SetToolTip(btnBanco1, ofdBanco1.FileName);
			}
        }

		private void btnBanco2_Click(Object sender, EventArgs e)
		{
            // Selección del archivo para pagos en BANCOMER
            if (ofdBanco2.ShowDialog() == DialogResult.OK)
			{
				btnBanco2.Text	= Path.GetFileName(ofdBanco2.FileName);
				bBanco2			= true;
				metroToolTip1.SetToolTip(btnBanco2, ofdBanco2.FileName);
			}
		}

		private void btnBanco3_Click(Object sender, EventArgs e)
		{
            // Selección del archivo para pagos en SANTANDER
            if (ofdBanco3.ShowDialog() == DialogResult.OK)
			{
				btnBanco3.Text	= Path.GetFileName(ofdBanco3.FileName);
				bBanco3			= true;
				metroToolTip1.SetToolTip(btnBanco3, ofdBanco3.FileName);
			}
		}

		private void btnGuardar_Click(Object sender, EventArgs e)
		{
			int iNoBancos = 0;

			if (bBanco1)
				iNoBancos++;

			if (bBanco2)
				iNoBancos++;

			if (bBanco3)
				iNoBancos++;

			if (iNoBancos > 0)
			{
				pgbCargaBancos.Value	= 0;
				pgbCargaBancos.Visible	= true;
				lblArchivos.Text		= "";
				lblRegistros.Text		= "";
				btnBanco1.Enabled		= false;
				btnBanco2.Enabled		= false;
				btnBanco3.Enabled		= false;
				btnGuardar.Enabled		= false;
				bgwCargas.RunWorkerAsync();
			}
			else
				FlatMessageBox.Show("Debe seleccionar al menos un archivo", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
		}	

		private void bgwCargas_DoWork(Object sender, DoWorkEventArgs e)
		{
			CargarArchivos(e);
		}

		private void bgwCargas_ProgressChanged(Object sender, ProgressChangedEventArgs e)
		{
			pgbCargaBancos.Value	= e.ProgressPercentage;
            lblPorcentaje.Text		= String.Format("{0} %", e.ProgressPercentage);
			string[] sUserState		= e.UserState.ToString().Split('-');

			lblArchivos.Text		= sUserState[0];
			lblRegistros.Text = sUserState[1];
		}

        /// <summary>
        /// Reiniciamos el estado de los controles para carga de archivos bancarios
        /// </summary>
        private void ResetUpload()
        {
            btnBanco1.Text      = "Seleccionar Archivo";
            bBanco1             = false;
            ofdBanco1.FileName  = string.Empty;
            metroToolTip1.SetToolTip(btnBanco1, "");
            
            btnBanco2.Text      = "Seleccionar Archivo";
            bBanco2             = false;
            ofdBanco2.FileName  = string.Empty;
            metroToolTip1.SetToolTip(btnBanco2, "");
            
            btnBanco3.Text      = "Seleccionar Archivo";
            bBanco3             = false;
            ofdBanco3.FileName  = string.Empty;
            metroToolTip1.SetToolTip(btnBanco3, "");
        }

		private void bgwCargas_RunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled)
			{
				MessageBox.Show("Operación Cancelada");
				btnGuardar.Enabled  = true;
				btnBanco1.Enabled   = true;
				btnBanco2.Enabled   = true;
				btnBanco3.Enabled   = true;
			}
			else
			{
				lblArchivos.Text    = "Operación Completa";
				lblRegistros.Text   = "";
				lblPorcentaje.Text  = "";

                ResetUpload();
                btnGuardar.Enabled  = true;
                btnBanco1.Enabled   = true;
				btnBanco2.Enabled   = true;
				btnBanco3.Enabled   = true;
				SystemSounds.Hand.Play();
			}

			if (e.Error != null)
			{
				MessageBox.Show("Error! " + e.Error.ToString());
			}
		}
		#endregion

		#region FUNCIONES
		/// <summary>
		/// Realiza la carga de pagos
		/// </summary>
		/// <param name="e"></param>
		private void CargarArchivos(DoWorkEventArgs e)
		{
            // Si cargo un archivo para el banco BANORTE
            // se realiza el proceso de carga
			if (bBanco1)
			{
                string sFilePath	= ofdBanco1.FileName;			// Ruta del archivo
				string sExtension	= Path.GetExtension(sFilePath); // Extensión del archivo
				string sHeader		= "YES";                        // Leer los headers del documento
				string ConnectionString, sheetName;
				ConnectionString	= string.Empty;

				int i, iTotal;

                switch (sExtension) // Establece el formato del archivo y la cadena de conexión
                {
                    case ".xls":  // Excel 97-03
                        ConnectionString = string.Format(Excel03ConString, sFilePath, sHeader);
                        break;
                    case ".xlsx": // Excel 07-16
                        ConnectionString = string.Format(Excel07ConString, sFilePath, sHeader);
                        break;
                    case ".XLS":  // Excel 97-03
                        ConnectionString = string.Format(Excel03ConString, sFilePath, sHeader);
                        break;
                    case ".XLSX": // Excel 07-16
                        ConnectionString = string.Format(Excel07ConString, sFilePath, sHeader);
                        break;
                }

                // INICIA
                DataTable _DTPagos = new DataTable();
                sheetName   = sGetSheet(0, ConnectionString);
                _DTPagos    = GetTable(ConnectionString, sheetName, "");

                i = 0;
                iTotal = _DTPagos.Rows.Count;

                foreach (DataRow row in _DTPagos.Rows)
                {
                    i = i + 1;
                    Thread.Sleep(100);
                    int percents = (i * 100) / iTotal;
                    bgwCargas.ReportProgress(percents, string.Format("Banorte-{1}/{0}", iTotal, i));
                    if (row[0].ToString() != string.Empty || row[1].ToString() != string.Empty)
                    {
                        try
                        {
                            // Obtiene la referencia
                            string sReferencia = row[1].ToString();
                            sReferencia = sReferencia.Substring(23);
                            // Obtiene el importe del pago
                            string sImporte = row[5].ToString();
                            // Obtiene la fecha de paog
                            string sFechaPago = row[14].ToString();

                            Conciliacion item = new Conciliacion().AddPago(new Conciliacion()
							{
								iIdUsuario		= int.Parse(AUsuarioData.sIdusuario),
								sReferencia1	= sReferencia,
								dImporte		= decimal.Parse(sImporte),
								dtFechaPago		= DateTime.Parse(sFechaPago),
								sBanco			= "Banorte"
							});
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                // TERMINA
            }

            // Si cargo un archivo para el banco BANCOMER
            // se realiza el proceso de carga
            if (bBanco2)
			{
				string sFilePath	= ofdBanco2.FileName;			// Ruta del archivo
				string sExtension	= Path.GetExtension(sFilePath); // Extensión del archivo
				string sHeader		= "YES";                        // Leer los headers del documento
				string ConnectionString, sheetName;
				ConnectionString	= string.Empty;

				int i, iTotal;

				switch (sExtension) // Establece el formato del archivo y la cadena de conexión
				{
					case ".xls":  // Excel 97-03
						ConnectionString = string.Format(Excel03ConString, sFilePath, sHeader);
						break;
					case ".xlsx": // Excel 07-16
						ConnectionString = string.Format(Excel07ConString, sFilePath, sHeader);
						break;
					case ".XLS":  // Excel 97-03
						ConnectionString = string.Format(Excel03ConString, sFilePath, sHeader);
						break;
					case ".XLSX": // Excel 07-16
						ConnectionString = string.Format(Excel07ConString, sFilePath, sHeader);
						break;
				}

				// INICIA
				DataTable _DTPagos = new DataTable();
				sheetName	= sGetSheet(0, ConnectionString);
				_DTPagos	= GetTable(ConnectionString, sheetName, "Día");

				i		= 0;
				iTotal	= _DTPagos.Rows.Count;

				foreach (DataRow row in _DTPagos.Rows)
				{
					i = i + 1;
					Thread.Sleep(100);
					int percents = (i * 100) / iTotal;
					bgwCargas.ReportProgress(percents, string.Format( "Bancomer-{1}/{0}", iTotal, i));
					if (row[0].ToString() != string.Empty || row[1].ToString() != string.Empty)
					{
						try
						{
							string[] sSplit = row[1].ToString().Split('/');
							if (sSplit[0] == "DEPOSITO EN EFECTIVO")
							{
								Conciliacion item = new Conciliacion().AddPago(new Conciliacion()
								{
									iIdUsuario		= int.Parse(AUsuarioData.sIdusuario),
									sReferencia1	= sSplit[1],
									dImporte		= decimal.Parse(row[3].ToString()),
									dtFechaPago		= DateTime.Parse(row[0].ToString()),
									sBanco			= "Bancomer"
								});
							}
						}
						catch (Exception)
						{

						}
					}
				}
				// TERMINA
			}

            // Si cargo un archivo para el banco SANTANDER
            // se realiza el proceso de carga
            if (bBanco3)
			{
				string sFilePath	= ofdBanco3.FileName;			// Ruta del archivo
				string sExtension	= Path.GetExtension(sFilePath); // Extensión del archivo
				string sHeader		= "YES";						// Leer los headers del documento
				string ConnectionString, sheetName;
				ConnectionString	= string.Empty;

				int i, iTotal;

				switch (sExtension) // Establece el formato del archivo y la cadena de conexión
				{
					case ".xls":  // Excel 97-03
						ConnectionString = string.Format(Excel03ConString, sFilePath, sHeader);
						break;
					case ".xlsx": // Excel 07-16
						ConnectionString = string.Format(Excel07ConString, sFilePath, sHeader);
						break;
					case ".XLS":  // Excel 97-03
						ConnectionString = string.Format(Excel03ConString, sFilePath, sHeader);
						break;
					case ".XLSX": // Excel 07-16
						ConnectionString = string.Format(Excel07ConString, sFilePath, sHeader);
						break;
					case ".csv":  // CSV
						ConnectionString = string.Format(@"Provider=Microsoft.Jet.OleDb.4.0; Data Source={0};Extended Properties=""Text;HDR=YES;FMT=Delimited""", Path.GetDirectoryName(ofdBanco3.FileName));
						break;
					case ".CSV": // CSV
						ConnectionString = string.Format(@"Provider=Microsoft.Jet.OleDb.4.0; Data Source={0};Extended Properties=""Text;HDR=YES;FMT=Delimited""", Path.GetDirectoryName(ofdBanco3.FileName));
						break;
				}


				// INICIA
				DataTable _DTPagos = new DataTable();
				sheetName	= Path.GetFileName(ofdBanco3.FileName);
				_DTPagos	= GetTable(ConnectionString, sheetName, "");

				i		= 0;
				iTotal	= _DTPagos.Rows.Count;

				foreach (DataRow row in _DTPagos.Rows)
				{
					i = i + 1;
					Thread.Sleep(100);
					int percents = (i * 100) / iTotal;
					bgwCargas.ReportProgress(percents, string.Format( "Santander-{1}/{0}", iTotal, i));
					if (row[0].ToString() != string.Empty || row[1].ToString() != string.Empty)
					{
						try
						{
							string sConcepto = row[4].ToString();

							if (sConcepto == "\tDEP EN EFECTIV")
							{
								string sFecha = string.Format("{0}-{1}-{2}", row[1].ToString().Substring(1, 2), row[1].ToString().Substring(3, 2), row[1].ToString().Substring(5, 4));
								string sReferencia = row[9].ToString().Substring(1);

								Conciliacion item = new Conciliacion().AddPago(new Conciliacion()
								{
									iIdUsuario		= int.Parse(AUsuarioData.sIdusuario),
									sReferencia1	= sReferencia,
									dImporte		= decimal.Parse(row[6].ToString()),
									dtFechaPago		= DateTime.Parse(sFecha),
									sBanco			= "Santander"
								});
							}
						}
						catch (Exception)
						{

						}
					}
				}
				// TERMINA
			}
		}

		/// <summary>
		/// Obtiene el nombre de la hoja de trabajo
		/// </summary>
		/// <param name="iNoHoja">Número de hoja</param>
		/// <param name="ConnectionString">Cadena de conexión</param>
		/// <returns></returns>
		public string sGetSheet(int iNoHoja, string ConnectionString)
        {
            using (OleDbConnection _OleDbConnection = new OleDbConnection(ConnectionString))
            {
                using (OleDbCommand _OleDbCommand = new OleDbCommand())
                {
                    _OleDbCommand.Connection = _OleDbConnection;
                    _OleDbConnection.Open();
                    DataTable _DTExcelSchema = _OleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    string sheet = _DTExcelSchema.Rows[iNoHoja]["TABLE_NAME"].ToString();
                    _OleDbConnection.Close();
                    return sheet;
                }
            }
        }

        /// <summary>
        /// Regresa una tabla con el contenido de la hoja que se requiere
        /// </summary>
        /// <param name="ConnectionString">Cadena de conexión</param>
        /// <param name="SheetName">Nombre de la hoja de  trabajo</param>
        /// <returns></returns>
        public DataTable GetTable(string ConnectionString, string SheetName, string ColumnName)
        {
            DataTable _DataTable = new DataTable();
            using (OleDbConnection _OleDbConnection = new OleDbConnection(ConnectionString))
            {
                using (OleDbCommand _OleDbCommand = new OleDbCommand())
                {
					using (OleDbDataAdapter _OleDbDataAdapter = new OleDbDataAdapter())
					{
						//DataTable _DataTable = new DataTable();
						if (string.IsNullOrEmpty(ColumnName))
							_OleDbCommand.CommandText = string.Format("SELECT * FROM [{0}]", SheetName);
						else
							_OleDbCommand.CommandText = string.Format("SELECT * FROM [{0}] WHERE [{1}] IS NOT NULL", SheetName, ColumnName);

                        _OleDbCommand.Connection  = _OleDbConnection;
                        _OleDbConnection.Open();
                        _OleDbDataAdapter.SelectCommand = _OleDbCommand;
                        _OleDbDataAdapter.Fill(_DataTable);
                        _OleDbConnection.Close();
                    }
                }
            }
            return _DataTable;
        }
		#endregion
	}
}
