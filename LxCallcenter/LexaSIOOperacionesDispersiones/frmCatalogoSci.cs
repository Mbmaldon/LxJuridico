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
using DevExpress.Export;
using System.Diagnostics;
using System.IO;
using System.Data.OleDb;
using LogicaCC.LexaSIOOperLogica;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    public partial class frmCatalogoSci : Form
    {
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";


        public frmCatalogoSci()
        {
            InitializeComponent();

            grdCatalogoSCI.DataSource = new SocioComanditario().listaSocioComanditario();
            gridView1.BestFitColumns();

            SocioComanditario _informacionVendedor = new SocioComanditario();
            _informacionVendedor  = new SocioComanditario().SociosAltaMes();
            lblAltasMes.Text      = _informacionVendedor.iTotal.ToString();

            SocioComanditario _informacionVendedor1 = new SocioComanditario();
            _informacionVendedor1 = new SocioComanditario().SociosActivos();
            lblActivos.Text       = _informacionVendedor1.iTotal.ToString();

            SocioComanditario _informacionVendedor2 = new SocioComanditario();
            _informacionVendedor2 = new SocioComanditario().SociosBaja();
            lblSociosBaja.Text    = _informacionVendedor2.iTotal.ToString();

            //APLICA ESTILO A LOS DOCUMENTOS EXPORTADOS EN EXCEL CON EL GRIDVIEW DE DEVEXPRESS
            ExportSettings.DefaultExportType = ExportType.WYSIWYG;
            gridView1.AppearancePrint.HeaderPanel.BackColor   = Color.FromArgb(0, 176, 240);
            gridView1.AppearancePrint.HeaderPanel.ForeColor   = Color.White;
            gridView1.AppearancePrint.HeaderPanel.BorderColor = Color.FromArgb(0, 176, 240);
            gridView1.AppearancePrint.FooterPanel.BackColor   = Color.White;
            gridView1.AppearancePrint.FooterPanel.BorderColor = Color.White;
            //gridView1.AppearancePrint.GroupRow.BorderColor  = Color.FromArgb(216, 216, 216);
            gridView1.AppearancePrint.Row.BorderColor         = Color.FromArgb(216, 216, 216);
            gridView1.OptionsPrint.AutoWidth                  = false;
            gridView1.OptionsPrint.UsePrintStyles             = true;
        }

        private void btnExportarListaSocios_Click(object sender, EventArgs e)
        {
            //EXPORTA EL CONTENIDO DEL GRIDVIEW EN UNA HOJA DE CALCULO
            if (gridView1.RowCount != 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    grdCatalogoSCI.ExportToXlsx(saveFileDialog1.FileName);
                    Process.Start(saveFileDialog1.FileName);
                }
            }
        }

        private void btnImportarNuevosSocios_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //OBTIENE LA RUTA DEL ARCHIVO
                string filePath  = openFileDialog1.FileName;
                //OBTIENE LA EXTENSIÓN DEL ARCHIVO
                string extension = Path.GetExtension(filePath);
                //string header  = rbHeaderYes.Checked ? "YES" : "NO";
                //GUARDA EN UNA VARIABLE SI SE TOMARAN EN CUENTA O NO LAS CABEZAS DE LAS COLUMNAS
                string header    = "YES";
                string conStr, sheetName;
                conStr = string.Empty;

                switch (extension)
                {
                    case ".xls": //Excel 97-03
                        conStr = string.Format(Excel03ConString, filePath, header);
                        break;

                    case ".xlsx": //Excel 07
                        conStr = string.Format(Excel07ConString, filePath, header);
                        break;
                }

                //OBTENEMOS EL NOMBRE DE LA PRIMERA HOJA DE TRABAJO
                using (OleDbConnection _OleDbConnection = new OleDbConnection(conStr))
                {
                    using (OleDbCommand _OleDbCommand = new OleDbCommand())
                    {
                        _OleDbCommand.Connection = _OleDbConnection;
                        _OleDbConnection.Open();
                        System.Data.DataTable dtExcelSchema = _OleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        _OleDbConnection.Close();
                    }
                }

                //LEEMOS LOS DATOS DE LA PRIMERA HOJA DE TRABAJO
                using (OleDbConnection _OleDbConnection = new OleDbConnection(conStr))
                {
                    using (OleDbCommand _OleDbCommand = new OleDbCommand())
                    {
                        using (OleDbDataAdapter _OleDbDataAdapter = new OleDbDataAdapter())
                        {
                            DataTable _DataTable      = new DataTable();
                            _OleDbCommand.CommandText = "SELECT * From [" + sheetName + "]";
                            _OleDbCommand.Connection  = _OleDbConnection;
                            _OleDbConnection.Open();
                            _OleDbDataAdapter.SelectCommand = _OleDbCommand;
                            _OleDbDataAdapter.Fill(_DataTable);
                            _OleDbConnection.Close();

                            //ASIGNAMOS UNA FUENTE DE DATOS AL GRIDVIEW
                            dataGridView1.DataSource = _DataTable;
                        }
                    }
                }

                LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
                //RECORREMOS EL GRIDVIEW PARA GUARDAR LOS NUEVOS REGISTROS
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString() != string.Empty)
                    {
                        new VendedorLXCC().registroVendedor(new VendedorLXCC()
                        {
                            sCliente                = row.Cells[0].Value.ToString(),
                            iIdEstado               = int.Parse(row.Cells[9].Value.ToString()),
                            iIdUsuario              = int.Parse(AUsuarioData.sIdusuario),
                            sNombre                 = row.Cells[3].Value.ToString(),
                            sAPaterno               = row.Cells[4].Value.ToString(),
                            sAMaterno               = row.Cells[5].Value.ToString(),
                            sRFC                    = row.Cells[1].Value.ToString(),
                            sDireccion              = row.Cells[7].Value.ToString(),
                            sMunicipio              = row.Cells[8].Value.ToString(),
                            sCP                     = row.Cells[10].Value.ToString(),
                            sTelefonoL              = row.Cells[11].Value.ToString(),
                            sExtension              = row.Cells[12].Value.ToString(),
                            sTelefonoM              = row.Cells[13].Value.ToString(),
                            sCorreoE                = row.Cells[17].Value.ToString(),
                            iIdServEstatus          = 1,
                            iIdServicioTipo         = 1,
                            sFechaContr             = DateTime.Now.ToString(),
                            sFechaVenci             = DateTime.Now.ToString(),
                            iIdContadorAsignado     = 1,
                            sNombreC1               = " ",
                            sAPaternoC1             = " ",
                            sAMaternoC1             = " ",
                            sTelefonoLC1            = " ",
                            sExtensionC1            = " ",
                            sTelefonoMC1            = " ",
                            sCorreoEC1              = " ",
                            sNombreC2               = " ",
                            sAPaternoC2             = " ",
                            sAMaternoC2             = " ",
                            sTelefonoLC2            = " ",
                            sExtensionC2            = " ",
                            sTelefonoMC2            = " ",
                            sCorreoEC2              = " ",
                            sServicioConta          = "false",
                            sServicioOD             = "true",
                            iIdComisionista         = int.Parse(row.Cells[15].Value.ToString()),
                            iIdNivel                = int.Parse(row.Cells[14].Value.ToString()),
                            sCURP                   = row.Cells[2].Value.ToString(),
                            sNoExpediente           = row.Cells[6].Value.ToString()
                        });
                    }
                    else
                    {
                        break;
                    }
                }
                //CARGA NUEVAMENTE EL CONTENIDO DEL GRIDVIEW PARA REFLEJAR LOS NUEVOS REGISTROS DE LOS SCI
                grdCatalogoSCI.DataSource = new SocioComanditario().listaSocioComanditario();
                MessageBox.Show("Socios Guardados");
            }
        }
    }
}