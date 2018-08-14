using LogicaCC.LexaSIOOperLogica;
using LogicaCC.Logica;
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

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    public partial class frmOperacionesCargaBatch : Form
    {
        UsuarioData AUsuarioData = UsuarioData.Instancia;
        //Constants
        const int AW_HIDE           = 0X10000;
        const int AW_SLIDE          = 0X40000;
        const int AW_HOR_POSITIVE   = 0X1;
        const int AW_HOR_NEGATIVE   = 0X2;
        const int AW_BLEND          = 0X80000;
        const int AW_VER_POSITIVE   = 0x00000004;
        const int AW_VER_NEGATIVE   = 0x00000008;

        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";


        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        private bool _UseSlideAnimation;

        public frmOperacionesCargaBatch() : this(false) { }

        public frmOperacionesCargaBatch(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;            
        }

        //public frmOperacionesCargaBatch()
        //{
        //    InitializeComponent();
        //}

        static frmOperacionesCargaBatch _OperacionesCargaBatch;
        static DialogResult _DialogResult = DialogResult.No;

        /// <summary>
        /// Modal para realizar el alta de operaciones de forma masiva
        /// </summary>
        /// <returns></returns>
        public static DialogResult Show()
        {
            _OperacionesCargaBatch = new frmOperacionesCargaBatch();
            Form frmSet = Application.OpenForms["FPrincipal"];

            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _OperacionesCargaBatch.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _OperacionesCargaBatch.Location = new Point(x, y);

            

            _OperacionesCargaBatch.Activate();
            _OperacionesCargaBatch.ShowDialog();
            frmSet.Activate();

            

            //_OperacionesCargaBatch.ShowDialog();

            return _DialogResult;
        }

        private void lollipopFileInput1_TextChanged(object sender, EventArgs e)
        {
            lnkSubir.Visible = true;
        }

        private void lnkSubir_Click(object sender, EventArgs e)
        {
            ofdCargaFacturas.Enabled   = false;
            lnkSubir.Visible           = false;
            pbBarraCarga.Visible       = true;
            btnCerrar.Enabled          = false;
            bgwCargarFacturas.RunWorkerAsync();
        }

        protected override void OnLoad(EventArgs e)
        {
            //Animate form
            base.OnLoad(e);
            AnimateWindow(this.Handle, 100, AW_SLIDE | AW_VER_POSITIVE);            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (e.Cancel == false)
            {
                AnimateWindow(this.Handle, 200, AW_HIDE | AW_SLIDE | AW_VER_NEGATIVE);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            _DialogResult = DialogResult.No;
            _OperacionesCargaBatch.Close();
        }


        #region Carga Batch
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
        public DataTable GetTable(string ConnectionString, string SheetName)
        {
            DataTable _DataTable = new DataTable();
            using (OleDbConnection _OleDbConnection = new OleDbConnection(ConnectionString))
            {
                using (OleDbCommand _OleDbCommand = new OleDbCommand())
                {
                    using (OleDbDataAdapter _OleDbDataAdapter = new OleDbDataAdapter())
                    {
                        //DataTable _DataTable = new DataTable();
                        _OleDbCommand.CommandText = string.Format("SELECT * FROM [{0}] WHERE [NoOperacion] IS NOT NULL", SheetName);
                        _OleDbCommand.Connection = _OleDbConnection;
                        _OleDbConnection.Open();
                        _OleDbDataAdapter.SelectCommand = _OleDbCommand;
                        _OleDbDataAdapter.Fill(_DataTable);
                        _OleDbConnection.Close();
                    }
                }
            }
            return _DataTable;
        }

        /// <summary>
        /// Realiza la lectura de archivo Excel
        /// seleccionado con el control FileOpenDialog
        /// </summary>
        /// <param name="e">DoWorkEventArgs</param>
        /// <param name="idUsuario">Id de usuario log</param>
        void LoadFileSociosComanditarios(DoWorkEventArgs e, int idUsuario)
        {
            string sFilePath  = ofdCargaFacturas.Text;        // Ruta del archivo
            string sExtension = Path.GetExtension(sFilePath); // Extensión del archivo
            string sHeader    = "YES";                        // Leer los headers del documento
            string ConnectionString, sheetName;
            ConnectionString  = string.Empty;

            int i, iTotal, iIdOperacion;

            // Establece el formato del archivo y la cadena de conexión
            switch (sExtension)
            {
                case ".xls":  // Excel 97-03
                    ConnectionString = string.Format(Excel03ConString, sFilePath, sHeader);
                    break;
                case ".xlsx": // Excel 07-16
                    ConnectionString = string.Format(Excel07ConString, sFilePath, sHeader);
                    break;
            }

            // INICIA: SocioComanditario | SocioComanditarioInformacion
            sheetName = sGetSheet(0, ConnectionString);
            DataTable _DTSocioComanditario = new DataTable();
            _DTSocioComanditario = GetTable(ConnectionString, sheetName);

            i            = 0;
            iTotal       = _DTSocioComanditario.Rows.Count;
            iIdOperacion = 0;

            foreach (DataRow row in _DTSocioComanditario.Rows)
            {
                i = i + 1;
                Thread.Sleep(100);
                int percents = (i * 100) / iTotal;
                bgwCargarFacturas.ReportProgress(percents, string.Format("{0}/{1}", i, iTotal));
                if (row[0].ToString() != string.Empty)
                {
                    // Alta de Operaciones
                    iIdOperacion = new PapelTrabajo().iCargaFacturasBatch(new PapelTrabajo()
                    {
                        sCliente        = row[6].ToString(),
                        iIdTipoFactura  = 2,
                        sNoOperacion    = row[0].ToString(),
                        dImporte        = decimal.Parse(row[4].ToString()),
                        sNoFactura      = row[1].ToString(),
                        dtFechaFactura  = DateTime.Parse(row[2].ToString()),
                        dtFechaDeposito = DateTime.Parse(row[3].ToString()),
                        sUUID           = row[5].ToString()
                    });
                }
            }
        }
        #endregion

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadFileSociosComanditarios(e, int.Parse(AUsuarioData.sIdusuario));
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Operación Cancelada");
                btnCerrar.Enabled          = true;
                ofdCargaFacturas.Enabled   = true;
                ofdCargaFacturas.Enabled   = false;
                lnkSubir.Visible           = false;
                pbBarraCarga.Visible       = true;
                btnCerrar.Enabled          = false;
            }
            else
            {
                lblPorcentaje.Text          = "Operación Completa";
                //lblNumArchivos.Text         = "";
                //lblPorcentaje.Text          = "";
                //lblPorcentaje.Visible       = false;
                btnCerrar.Enabled           = true;
                //ofdCargaFacturas.Enabled    = true;
                lnkNuevaCarga.Visible = true;
                SystemSounds.Hand.Play();
            }

            if (e.Error != null)
            {
                MessageBox.Show("Error! " + e.Error.ToString());
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbBarraCarga.Value = e.ProgressPercentage;

            lblPorcentaje.Text = String.Format("{0} %", e.ProgressPercentage);
            //lblNoArchivos.TextAlign = ContentAlignment.MiddleCenter;
            //lblNumArchivos.Text = String.Format("Estado{0}{1}", Environment.NewLine,  e.UserState);
            lblNumArchivos.Text = e.UserState.ToString();
        }

        private void lnkNuevaCarga_Click(object sender, EventArgs e)
        {
            ofdCargaFacturas.Text       = string.Empty;
            lnkSubir.Visible            = false;
            ofdCargaFacturas.Enabled    = true;
            pbBarraCarga.Value          = 0;
            pbBarraCarga.Visible        = false;
            lblPorcentaje.Text          = string.Empty;
            lblNumArchivos.Text         = string.Empty;
            lnkNuevaCarga.Visible       = false;
        }
    }
}
