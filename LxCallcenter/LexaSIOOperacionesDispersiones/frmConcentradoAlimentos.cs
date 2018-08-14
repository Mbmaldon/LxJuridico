using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using LogicaCC;
using DevExpress.Export;
using System.Diagnostics;
using DevExpress.XtraPrinting;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;



namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    public partial class frmConcentradoAlimentos : Form
    {
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

        private string  sSocio          = string.Empty;
        private string  sCantidad       = string.Empty;
        private string  sCantidadConv   = string.Empty;
        private string  sMes1           = string.Empty;
        private string  sMes2           = string.Empty;

        public frmConcentradoAlimentos()
        {
            InitializeComponent();
            cargarControles();

            //APLICAMOS PROPIEDADES DE EXPORTACIÓN PARA EL GRIDVIEW DE DEVEXPRESS
            ExportSettings.DefaultExportType                    = ExportType.WYSIWYG;
            gridView1.AppearancePrint.HeaderPanel.BackColor     = Color.FromArgb(0, 176, 240);
            gridView1.AppearancePrint.HeaderPanel.ForeColor     = Color.White;
            gridView1.AppearancePrint.HeaderPanel.BorderColor   = Color.FromArgb(0, 176, 240);
            gridView1.AppearancePrint.FooterPanel.BackColor     = Color.White;        
            gridView1.AppearancePrint.FooterPanel.BorderColor   = Color.White;        
            gridView1.AppearancePrint.Row.BorderColor           = Color.FromArgb(216, 216, 216);
            gridView1.OptionsPrint.AutoWidth                    = false;
            gridView1.OptionsPrint.UsePrintStyles               = true;
        }

        /// <summary>
        /// Método público para cargar de registros en los controles del Form
        /// </summary>
        public void cargarControles()
        {
            //CARGAMOS LISTA DE CONCENTRADO DE ALIMENTOS
            grdConcentradoAlimentos.DataSource = new LogicaCC.LexaSIOOperLogica.ConcentradoAlimentos().ListaConcentradoAlimentos();
            //APLICAMOS FORMATO AL GRIDVIEW
            gridView1.BestFitColumns();
            gridView1.Appearance.FooterPanel.Options.UseBackColor   = true;
            gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            gridView1.Appearance.FooterPanel.BackColor              = Color.White;
            gridView1.Appearance.FooterPanel.BackColor2             = Color.White;
            gridView1.Appearance.FooterPanel.BorderColor            = Color.White;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                //OBTENEMOS NOMBRE DEL SOCIO
                var rowHandle           = gridView1.FocusedRowHandle;
                var obj                 = gridView1.GetRowCellValue(rowHandle, "sNombreSocio");
                sSocio                  = obj.ToString();
                //OBTENEMOS CANTIDAD EN MONEDA
                string cantidad         = gridView1.Columns["dMonto"].SummaryItem.SummaryValue.ToString();
                sCantidad               = string.Format("{0:C}", Decimal.Parse(gridView1.Columns["dMonto"].SummaryItem.SummaryValue.ToString()));
                //OBTENEMOS CANTIDAD EN ESCRITO
                string cantidadLetra    = new Conv().enletras(cantidad.ToString());
                sCantidadConv           = cantidadLetra.ToString();
                //OBTENEMOS EL PERIODO
                string filtro           = gridView1.FilterPanelText.ToString();
                string testDate         = filtro;
                string fecha            = string.Empty;
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\d{2}/\d{2}/\d{4}");
                foreach (System.Text.RegularExpressions.Match m in regex.Matches(testDate))
                {
                    fecha = fecha + ' ' + m.ToString();
                }
                string[] periodos   = fecha.Split(' ');
                DateTime Mes1       = DateTime.Parse(periodos[1]);
                sMes1               = Mes1.ToString("MMMM").ToUpper();
                DateTime Mes2       = DateTime.Parse(periodos[2]);
                sMes2               = Mes2.ToString("MMMM").ToUpper();
            }
            catch
            {

            }
        }

        // CÓDIGO PARA LA IMPORTACIÓN DE UN DOCUMENTO EN EXCEL (LAYOUT)
        #region IMPORTAR LAYOUT
        private void btnImportarLayout_Click(object sender, EventArgs e)
        {
            //MOSTRAMOS EL DIALOG PARA ABRIR UN ARCHIVO
            ofdImportarLayout.ShowDialog();
        }

        private void ofdImportarLayout_FileOk(object sender, CancelEventArgs e)
        {
            //OBTENEMOS EL NOMBRE DEL DOCUMENTO
            string filePath     = ofdImportarLayout.FileName;
            //OBTENEMOS LA EXTENSIÓN DEL DOCUMENTO
            string extension    = Path.GetExtension(filePath);
            //DEFINIMOS SI IMPORTAREMOS LOS NOMBRES DE LAS COLUMNAS
            string header       = "YES";
            string conStr, sheetName;
            conStr = string.Empty;

            //SELECCIÓN DE FORMATO DEL DOCUMENTO QUE ESTAMOSC CARGANDO.
            switch (extension)
            {
                case ".xls": //Excel 97-03
                    conStr = string.Format(Excel03ConString, filePath, header);
                    break;

                case ".xlsx": //Excel 07
                    conStr = string.Format(Excel07ConString, filePath, header);
                    break;
            }

            //OBTENEMOS EL NOMBRE DE LA PRIMERA HOJA DE TRABAJO.
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

            //LEEMOS LOS DATOS DE LA PRIMERA HOJA DE TRABAJO.
            using (OleDbConnection _OleDbConnection = new OleDbConnection(conStr))
            {
                using (OleDbCommand _OleDbCommand = new OleDbCommand())
                {
                    using (OleDbDataAdapter _OleDbDataAdapter = new OleDbDataAdapter())
                    {
                        //CREAMOS UNA TABLA PARA INSERTAR LOS REGISTROS DE LA HOJA DE TRBAJO
                        DataTable _DataTable        = new DataTable();
                        _OleDbCommand.CommandText   = "SELECT * From [" + sheetName + "]";
                        _OleDbCommand.Connection    = _OleDbConnection;
                        _OleDbConnection.Open();
                        _OleDbDataAdapter.SelectCommand = _OleDbCommand;
                        _OleDbDataAdapter.Fill(_DataTable);
                        _OleDbConnection.Close();

                        //ASIGNAMOS LA FUENTE DE DATOS AL GRIDVIEW
                        dataGridView1.DataSource = _DataTable;
                    }
                }
            }

            //RECORREMOS EL GRIDVIEW Y VAMOS GUARDANDO LOS REGISTRO EN LA BD
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                //GAURDAMOS REGISTRO EN LA BD MIENTRAS PASAMOS PARAMETROS
                new LogicaCC.LexaSIOOperLogica.ConcentradoAlimentos().ImportarLayout(new LogicaCC.LexaSIOOperLogica.ConcentradoAlimentos()
                {
                    sNoOperacion                = row.Cells[0].Value.ToString(),
                    sEjecutivoCuentaAsignado    = row.Cells[1].Value.ToString(),
                    sVendedor                   = row.Cells[2].Value.ToString(),
                    sNoCuentaDisperso           = row.Cells[3].Value.ToString(),
                    dComision                   = decimal.Parse(row.Cells[4].Value.ToString()),
                    sNoSocio                    = row.Cells[5].Value.ToString(),
                    sNombreSocio                = row.Cells[6].Value.ToString(),
                    dMonto                      = decimal.Parse(row.Cells[7].Value.ToString()),
                    sFechaDeposito              = row.Cells[8].Value.ToString(),
                    sNumeroRecibo               = row.Cells[9].Value.ToString(),
                    sPolizaContable             = string.Format("R. {0} {1}", row.Cells[9].Value.ToString(), row.Cells[6].Value.ToString())
                });
            }
            cargarControles();
        }

        private void btnExportarAcumulado_Click(object sender, EventArgs e)
        {
            //SI NUESTRO GRID TIENE REGISTROS PROCEDEMOS
            if (gridView1.RowCount != 0)
            {
                //ABRIMOS DIALOG PARA EXPORTAR DOCUMENTO EN EXCEL
                if (sfdExportarAcumulado.ShowDialog() == DialogResult.OK)
                {
                    //EXPORTAMOS EL CONTENIDO DEL GRIDVIEW A UN NUEVO DOCUMENTO EN EXCEL
                    grdConcentradoAlimentos.ExportToXlsx(sfdExportarAcumulado.FileName);
                    //ABRIMOS EL DOCUMENTO RECIEN CREADO
                    Process.Start(sfdExportarAcumulado.FileName);
                }
            }
        }
        #endregion

        // CÓDIGO PARA GENERAR LA CONSTANCIA DE INGRESOS EN FORMATO PDF
        #region GENERAR CONSTANCIA DE INGRESOS
        private void btnGenerarConstaciaIngresos_Click(object sender, EventArgs e)
        {
            //VALIDAMOS PARA ASIGNAR FECHAS DE PERIODOS
            if(!(sMes1 == string.Empty || sMes2 == string.Empty))
            { 
                //ABRIMOS DIALOG PARA ASGINAR NOMBRE Y RUTA DONDE SE GUARDARA EL PDF
                if(saveFileDialog2.ShowDialog()== DialogResult.OK)
                {        
                    try
                    {
                        //CREAMOS FUENTES PERSONALIZADAS
                        iTextSharp.text.Font fontEncabezado     = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD);
                        fontEncabezado.Color                    = BaseColor.BLACK;

                        iTextSharp.text.Font fontCuerpo         = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL);
                        fontCuerpo.Color                        = BaseColor.BLACK;

                        iTextSharp.text.Font fontFirma          = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.UNDERLINE | iTextSharp.text.Font.BOLD);
                        fontFirma.Color                         = BaseColor.BLACK;

                        iTextSharp.text.Font fontPiePagina      = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 9, iTextSharp.text.Font.ITALIC);
                        fontPiePagina.Color                     = BaseColor.GRAY;

                        //ASIGNAMOS LA RUTA DONDE SE CREARA EL ARCHIVO PDF
                        string outputFile = saveFileDialog2.FileName;

                        //CREAMOS CONFIGURACIONES PARA EL ARCHIVO CREADO.
                        using (FileStream _fileStream = new FileStream(outputFile, FileMode.Append, FileAccess.Write, FileShare.None))
                        {
                            //CREAMOS UN NUEVO DOCUMENTO PDF, ASIGNANDO EL TAMAÑO DE LA HOJA EN LEGAL Y EN HORIZONTAL
                            using (iTextSharp.text.Document _document = new iTextSharp.text.Document(PageSize.LETTER, 90F, 90f, 40f, 0f))
                            {
                                //ASIGNAMOS EL FILESTREAM AL DOCUMENTO USANDO EL PDFWRITER DE ITEXTSHARP
                                using (PdfWriter _pdfWriter = PdfWriter.GetInstance(_document, _fileStream))
                                {
                                    //ABRIMOS EL DUCUMENTO PARA ESCRIBIRLO
                                    _document.Open();

                                    //IMAGEN
                                    //var img         = Properties.Resources.LOGO;
                                    //var _logo       = iTextSharp.text.Image.GetInstance(img, BaseColor.WHITE);
                                    //_logo.Alignment = Element.ALIGN_LEFT;
                                    //_logo.ScalePercent(30f);                                    
                                    //ENCABEZADO
                                    Paragraph _paragraphTitulos = new Paragraph();
                                    _paragraphTitulos.Font      = fontEncabezado;
                                    _paragraphTitulos.Alignment = Element.ALIGN_LEFT;
                                    _paragraphTitulos.SetLeading(30f, 1.2f);
                                    _paragraphTitulos.Add("A QUIEN CORRESPONDA.");
                                    //CUERPO
                                    string cuerpo = Environment.NewLine
                                                + "            El que suscribe C. GUADALUPE CACALO TOXCOYOA, en mi carácter de Administrador"
                                                + " Único de la moral denominada ISLAS GOWER Y COMPAÑÍA SUCESORES S. EN C. DE C.V., me"
                                                + " permito hacer constar que el C. " + sSocio + ", es Socio Comanditario Industrial"
                                                + " de la sociedad señalada, que percibió por el periodo de " + sMes1 + " a " + sMes2 + ", la cantidad de"
                                                + " " + sCantidad + " (" + sCantidadConv + "), por Concepto de Alimentos, dando estricto cumplimiento"
                                                + " con ello al artículo 49 de la Ley General de Sociedades Mercantiles, a las sentencias en"
                                                + " el Juicio de Amparo Indirecto Número 648/2007, dictada por el Juez Noveno de Distrito en"
                                                + " el Estado de Puebla y en el Amparo en Revisión Número 404/2014 dictado por el Tribunal"
                                                + " Colegiado en Campeche, así como a los Estatutos Sociales que rigen a esta Empresa. Lo"
                                                + " anterior se informa para los efectos a que haya lugar.";                                
                                    Paragraph _paragraphCuerpo  = new Paragraph();
                                    _paragraphCuerpo.Font       = fontCuerpo;
                                    _paragraphCuerpo.Alignment  = Element.ALIGN_JUSTIFIED;
                                    _paragraphCuerpo.SetLeading(20f, 0.1f);
                                    _paragraphCuerpo.Add(cuerpo);
                                    //CUERPO 2
                                    string cuerpo2 = Environment.NewLine + Environment.NewLine + "            Se extiende la presente a petición del interesado, el día " + string.Format("{0:D}", dtFechaEntiende.Value) + "." + Environment.NewLine + Environment.NewLine;
                                    Paragraph _paragraphCuerpo2 = new Paragraph();
                                    _paragraphCuerpo2.Font      = fontCuerpo;
                                    _paragraphCuerpo2.Alignment = Element.ALIGN_JUSTIFIED;
                                    _paragraphCuerpo2.SetLeading(20f, 0.1f);
                                    _paragraphCuerpo2.Add(cuerpo2);
                                    //FIRMA
                                    string firma = "C. GUADALUPE CACALO TOXCOYOA.";
                                    Paragraph _paragraphFirma   = new Paragraph();
                                    _paragraphFirma.Font        = fontFirma;
                                    _paragraphFirma.Alignment   = Element.ALIGN_CENTER;
                                    _paragraphFirma.SetLeading(20f, 0.1f);
                                    _paragraphFirma.Add(firma);
                                    //FIRMA 2
                                    string firma2 = "Administrador Único de" + Environment.NewLine +
                                                    "ISLAS GOWER Y COMPAÑÍA SUCESORES S.EN C. DE C.V.";
                                    Paragraph _paragraphFirma2  = new Paragraph();
                                    _paragraphFirma2.Font       = fontCuerpo;
                                    _paragraphFirma2.Alignment  = Element.ALIGN_CENTER;
                                    _paragraphFirma2.SetLeading(20f, 0.1f);
                                    _paragraphFirma2.Add(firma2);
                                    //PIE DE PAGINA
                                    string piePagina = Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine +
                                                       "________________________________________________________________________________________________" + Environment.NewLine +
                                                       "Avenida Maria Lavalle Urbina Lote 17 Manzana G-1, Local 2, Planta Baja, Área Ah Kim Pech Sector Fundadores, Campeche, Campeche.";
                                    Paragraph _paragraphPiePagina   = new Paragraph();
                                    _paragraphPiePagina.Font        = fontPiePagina;
                                    _paragraphPiePagina.Alignment   = Element.ALIGN_CENTER;
                                    //_paragraphPiePagina.SetLeading(20f, 0.1f);
                                    _paragraphPiePagina.Add(piePagina);
                                    //AGREGAMOS TEXTOS AL DOCUMENTO
                                    //_document.Add(_logo);
                                    _document.Add(_paragraphTitulos);
                                    _document.Add(_paragraphCuerpo);
                                    _document.Add(_paragraphCuerpo2);
                                    _document.Add(_paragraphFirma);
                                    _document.Add(_paragraphFirma2);
                                    _document.Add(_paragraphPiePagina);

                                    //CERRAMOS EL DOCUMENTO
                                    _document.Close();
                                }
                            }
                        }
                        //ABRIMOS EL DOCUMENTO RECIEN CREADO
                        Process.Start(saveFileDialog2.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("No se ha podido generar la póliza. Revise que tenga la información adecuada" + Environment.NewLine
                            + "   - Nombre del socio" + Environment.NewLine
                            + "   - Periodo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha podido generar la póliza. Revise que tenga la información adecuada" + Environment.NewLine
                            + "   - Nombre del socio" + Environment.NewLine
                            + "   - Periodo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }      

        #endregion
        
        //CÓDIGO FUENTE PARA EXPORTAR LA PÓLIZA CONTABLE EN EXCEL (NUEVO O EXISTENTE)
        #region GENERAR POLIZA CONTABLE
        public System.Data.DataTable ExportToExcel()
        {
            //CREAMOS UNA NUEVA TABLA PARA INSERTAR LOS REGISTROS DEL GRIDVIEW EN ELLA
            DataTable table     = new DataTable();
            DateTime FirstDate  = DateTime.Parse(gridView1.GetRowCellValue(0, "sFechaDeposito").ToString());

            //CREAMOS LAS COLUMNAS QUE SE OCUPARAN PARA EXPORTAR LA POLIZA DE ALIMENTOS
            table.Columns.Add(cmbxTipoPoliza.Text, typeof(string));
            table.Columns.Add(txtNoPoliza.Text, typeof(string));
            table.Columns.Add("CANTIDADES ENTREGADAS POR ALIMENTOS", typeof(string));
            table.Columns.Add(FirstDate.Day.ToString(), typeof(string));
            table.Columns.Add("", typeof(string));
            table.Columns.Add("", typeof(string));
            table.Columns.Add("", typeof(string));

            //OBTENEMOS EL NÚMERO DE PÓLIZA PARA INCREMENTARLO Y DECLARAMOS VARIABLE PARA SUMAR
            //CANTIDADES DE CADA REGISTRO POR PÓLIZA.
            int NoPoliza            = int.Parse(txtNoPoliza.Text);
            decimal dTotalPoliza    = 0;

            //AGREGAMOS LOS REGISTROS A LA TABLA
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                //OBTENEMOS EL DÍA DE CADA REGISTRO
                DateTime fecha = DateTime.Parse(gridView1.GetRowCellValue(i, "sFechaDeposito").ToString());
                try
                {
                    //SI NUESTRA FECHA ES IGUAL AL REGISTRO ANTERIOR AGREGAMOS REGISTRO A LA TABLA
                    if (fecha == DateTime.Parse(gridView1.GetRowCellValue(i - 1, "sFechaDeposito").ToString()))
                    {
                        //SUMAMOS LOS VALORES DE CADA REGISTRO PARA ACUMULAR UN TOTAL
                        dTotalPoliza = dTotalPoliza + Convert.ToDecimal(gridView1.GetRowCellValue(i, "dMonto"));
                        //ASIGNAMOS VALORES
                        string c1 = "";
                        string c2 = txtCuentaCarga.Text;
                        string c3 = "0";
                        string c4 = Convert.ToString(gridView1.GetRowCellValue(i, "sPolizaContable"));
                        string c5 = txtDepartamento.Text;
                        string c6 = Convert.ToString(gridView1.GetRowCellValue(i, "dMonto"));
                        string c7 = "0";

                        table.Rows.Add(c1, c2, c3, c4, c5, c6, c7);
                    }                    
                    else
                    {
                        //SI NUESTRA FECHA ES DIFERENTE AGREGAMOS UN FIN DE PÓLIZA Y COMENZAMOS NUEVOS REGISTROS DE LA SIGUIENTE FECHA.
                        string total0 = gridView1.Columns["dMonto"].SummaryItem.SummaryValue.ToString();

                        table.Rows.Add("", txtCuentaAbona.Text, "0", "CANTIDADES ENTREGADAS POR ALIMENTOS", txtDepartamento.Text, "0", dTotalPoliza);
                        table.Rows.Add("", "FIN_PARTIDAS", "", "", "", "", "");

                        //REINICIAMOS EL ACUMULADOR IMPORTES
                        dTotalPoliza    = 0;
                        //INCREMENTAMOS EL NÚMERO DE PÓLIZA
                        NoPoliza        = NoPoliza + 1;
                        table.Rows.Add(cmbxTipoPoliza.Text, NoPoliza, "CANTIDADES ENTREGADAS POR ALIMENTOS", fecha.Day.ToString(), "", "", "");
                        //AGREGEMOS EL NUEVO REGISTRO
                        string c1 = "";
                        string c2 = txtCuentaCarga.Text;
                        string c3 = "0";
                        string c4 = Convert.ToString(gridView1.GetRowCellValue(i, "sPolizaContable"));
                        string c5 = txtDepartamento.Text;
                        string c6 = Convert.ToString(gridView1.GetRowCellValue(i, "dMonto"));
                        string c7 = "0";

                        table.Rows.Add(c1, c2, c3, c4, c5, c6, c7);
                        dTotalPoliza = dTotalPoliza + Convert.ToDecimal(gridView1.GetRowCellValue(i, "dMonto"));
                    }
                }
                catch
                {
                    //PRIMER REGISTRO QUE TENDRA LA TABLA
                    if (fecha == DateTime.Parse(gridView1.GetRowCellValue(i, "sFechaDeposito").ToString()))
                    {
                        //AGREGAMOS EL REGISTRO A LA TABLA
                        string c1 = "";
                        string c2 = txtCuentaCarga.Text;
                        string c3 = "0";
                        string c4 = Convert.ToString(gridView1.GetRowCellValue(i, "sPolizaContable"));
                        string c5 = txtDepartamento.Text;
                        string c6 = Convert.ToString(gridView1.GetRowCellValue(i, "dMonto"));
                        string c7 = "0";

                        table.Rows.Add(c1, c2, c3, c4, c5, c6, c7);
                        dTotalPoliza = dTotalPoliza + Convert.ToDecimal(gridView1.GetRowCellValue(i, "dMonto"));
                    }
                }
            }
            //AGREGAMOS UN CIERRE DE PÓLIZA A LA TABLA
            table.Rows.Add("", txtCuentaAbona.Text, "0", "CANTIDADES ENTREGADAS POR ALIMENTOS", txtDepartamento.Text, "0", dTotalPoliza);
            table.Rows.Add("", "FIN_PARTIDAS", "", "", "", "", "");

            return table;
        }
    
        private void btnGenerarPolizaContable_Click(object sender, EventArgs e)
        {
            //VALIDAMOS SI SE ENCUENTRAN LOS DATOS REQUERIDOS
            if (ValidarInformacion() == 0)
            {
                //ABRIMOS CUADRO DE DIALOGO PARA MOSTRAR LA RUTA Y NOMBRE CON LA QUE
                //GUARDARA EL DOCUMENTO EN EXCEL.
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //DECLARAMOS VARIABLES
                    //NUEVA INSTACIA DE EXCEL
                    Microsoft.Office.Interop.Excel.Application  excel;
                    //NUEVO DOCUMENTO DE EXCEL
                    Microsoft.Office.Interop.Excel.Workbook     worKbooK;
                    //NUEVA HOJA DE TRABAJO DE EXCEL
                    Microsoft.Office.Interop.Excel.Worksheet    worKsheeT;
                    //RANGO DE EXCEL
                    Microsoft.Office.Interop.Excel.Range        celLrangE;

                    try
                    {
                        //ASIGNAMOS INSTACIA DE EXCEL PARA INICIALIZAR Y ASIGNAMOS QUE NO SEA VISIBLE
                        excel                   = new Microsoft.Office.Interop.Excel.Application();
                        excel.Visible           = false;
                        excel.DisplayAlerts     = false;
                        worKbooK                = excel.Workbooks.Add(Type.Missing);

                        //ACTIVAMOS LA HOJA DE TRABAJO Y ASIGNAMOS UN NOMBRE
                        worKsheeT       = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
                        worKsheeT.Name  = "Póliza de alimentos";

                        int rowcount = 2;

                        //AGREGAMOS EL CONTENIDO DE LA TABLA QUE NOS REGRESA EL METODO EXPORTTOEXCEL()
                        foreach (DataRow datarow in ExportToExcel().Rows)
                        {
                            rowcount += 1;
                            for (int i = 1; i <= ExportToExcel().Columns.Count; i++)
                            {
                                //AGREGAMOS LOS NOMBRES DE LA COLUMNAS
                                if (rowcount == 3)
                                {
                                    worKsheeT.Cells[2, i]       = ExportToExcel().Columns[i - 1].ColumnName;
                                    worKsheeT.Cells.Font.Color  = System.Drawing.Color.Black;
                                }

                                worKsheeT.Cells[rowcount, i] = datarow[i - 1].ToString();
                                //AGREGAMOS EL CONTENIDO
                                if (rowcount > 3)
                                {
                                    if (i == ExportToExcel().Columns.Count)
                                    {
                                        if (rowcount % 2 == 0)
                                        {
                                            celLrangE = worKsheeT.Range[worKsheeT.Cells[rowcount, 1], worKsheeT.Cells[rowcount, ExportToExcel().Columns.Count]];
                                        }
                                    }
                                }
                            }
                        }

                        celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[rowcount, ExportToExcel().Columns.Count]];
                        celLrangE.EntireColumn.AutoFit();

                        celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[2, ExportToExcel().Columns.Count]];

                        //GUARDAMOS EL DOCUMENTO, CERRAMOS EL LIBRO Y FINALIZAMOS LA APLICACIÓN
                        worKbooK.SaveAs(saveFileDialog1.FileName);
                        worKbooK.Close();
                        excel.Quit();
                        
                        //RESTAURAMOS LOS VALORES DEL ASISTENTE PARA GENERAR PÓLIZA
                        lnkCancelarGenerarCostanciaAlimentos_Click(sender, e);
                        //INICIAMOS EL DOCUMENTO RECIEN CREADO.
                        Process.Start(saveFileDialog1.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        worKsheeT   = null;
                        celLrangE   = null;
                        worKbooK    = null;
                    }
                }
            }
        }
       
        private void btnAbrirPólizaContable_Click(object sender, EventArgs e)
        {
            //VALIDAMOS SI SE ENCUENTRAN LOS DATOS REQUERIDOS
            if (ValidarInformacion() == 0)
            {
                //ABRIMOS CUADRO DE DIALOGO PARA MOSTRAR LA RUTA Y NOMBRE CON LA QUE
                //GUARDARA EL DOCUMENTO EN EXCEL.
                if (ofdPolizaContable.ShowDialog() == DialogResult.OK)
                {
                    object oMissing0 = System.Reflection.Missing.Value;
                    //DECLARAMOS VARIABLES
                    Microsoft.Office.Interop.Excel.Application ExcelObj0 = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook    WBook0;
                    Microsoft.Office.Interop.Excel.Worksheet   WSheet0;
                    //Microsoft.Office.Interop.Excel.Range       celLrangE0;
                    WBook0 = ExcelObj0.Workbooks.Open(ofdPolizaContable.FileName,
                        oMissing0, oMissing0, oMissing0, oMissing0, oMissing0,
                        oMissing0, oMissing0, oMissing0, oMissing0, oMissing0,
                        oMissing0, oMissing0, oMissing0, oMissing0);

                    int rowCont = 0;
                    //ABRIMOS LA HOJA EXISTENTE
                    WSheet0 = (Microsoft.Office.Interop.Excel.Worksheet)WBook0.Sheets.get_Item(1);
                    //ANALIZAMOS LOS DATOS DEL RANGO QUE DESEAMOS
                    Microsoft.Office.Interop.Excel.Range range = WSheet0.get_Range("B3:B1048576", System.Reflection.Missing.Value);

                    //OBTENEMOS EL NÚMERO DE LA ULTIMA CELDA QUE TIENE CONTENIDO
                    //Y LO GUARDAMOS EN UNA VARIABLE
                    if (range != null)
                        foreach (Microsoft.Office.Interop.Excel.Range r in range)
                        {
                            string value = r.Text;
                            if (value != string.Empty)
                            {
                                string user = r.Address;
                            }
                            else
                            {
                                string user     = r.Address;
                                string[] rango  = user.Split('$');
                                rowCont         = int.Parse(rango[2]);
                                break;
                            }
                        }
                    //CERRAMOS EL LIBRO Y FINALIZAMOS LA APLICACIÓN
                    WBook0.Close();
                    ExcelObj0.Quit();

                    object oMissing = System.Reflection.Missing.Value;
                    //DECLARAMOS VARIABLES
                    Microsoft.Office.Interop.Excel.Application ExcelObj = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook    WBook;
                    Microsoft.Office.Interop.Excel.Worksheet   WSheet;
                    Microsoft.Office.Interop.Excel.Range       celLrangE;
                    WBook = ExcelObj.Workbooks.Open(ofdPolizaContable.FileName,
                        oMissing, oMissing, oMissing, oMissing, oMissing,
                        oMissing, oMissing, oMissing, oMissing, oMissing,
                        oMissing, oMissing, oMissing, oMissing);


                    //ABRIMOS LA HOJA EXISTENTE
                    WSheet = (Microsoft.Office.Interop.Excel.Worksheet)WBook.Sheets.get_Item(1);

                    int rowcount = rowCont;

                    //AGREGAMOS EL CONTENIDO DE LA TABLA QUE NOS REGRESA EL METODO EXPORTTOEXCEL()
                    foreach (DataRow datarow in ExportToExcel().Rows)
                    {
                        rowcount += 1;
                        for (int i = 1; i <= ExportToExcel().Columns.Count; i++)
                        {
                            //AGREGAMOS LOS NOMBRES DE LA COLUMNAS
                            if (rowcount > 3)
                            {
                                WSheet.Cells[rowCont, i]    = ExportToExcel().Columns[i - 1].ColumnName;
                                WSheet.Cells.Font.Color     = System.Drawing.Color.Black;
                            }

                            WSheet.Cells[rowcount, i] = datarow[i - 1].ToString();
                            //AGREGAMOS EL CONTENIDO
                            if (rowcount > 3)
                            {
                                if (i == ExportToExcel().Columns.Count)
                                {
                                    if (rowcount % 2 == 0)
                                    {
                                        celLrangE = WSheet.Range[WSheet.Cells[rowcount, 1], WSheet.Cells[rowcount, ExportToExcel().Columns.Count]];
                                    }
                                }
                            }
                        }
                    }

                    celLrangE = WSheet.Range[WSheet.Cells[1, 1], WSheet.Cells[rowcount, ExportToExcel().Columns.Count]];
                    celLrangE.EntireColumn.AutoFit();

                    celLrangE = WSheet.Range[WSheet.Cells[1, 1], WSheet.Cells[2, ExportToExcel().Columns.Count]];
                    
                    //GUARDAMOS EL DOCUMENTO Y LO HACEMOS VISIBLE
                    WBook.Save();

                    ExcelObj.Visible = true;

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(WSheet);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(WBook);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(ExcelObj);
                    WSheet      = null;
                    WBook       = null;
                    ExcelObj    = null;
                    GC.Collect();

                    //RESTAURAMOS LOS VALORES DEL ASISTENTE PARA GENERAR PÓLIZA
                    lnkCancelarGenerarCostanciaAlimentos_Click(sender, e);
                }
            }
        }

        #region AsistenteGenerarPoliza
        private void lnkPolizaNext_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabPage2;
        }

        private void lnkCuentaBack_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabPage1;
        }

        private void lnkCuentaNext_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabPage4;
        }

        private void lnkFechaBack_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabPage2;
        }

        private void lnkFechaNext_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabPage4;
        }

        private void lnkDepartamentoBack_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabPage2;
        }

        private void lnkDepartamentoNext_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabPage5;
        }

        private void lnkTipoCambioBack_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabPage4;
        }

        private void lnkCancelarGenerarCostanciaAlimentos_Click(object sender, EventArgs e)
        {
            pnlPolizaContable.Visible       = false;
            cmbxTipoPoliza.SelectedIndex    = -1;
            txtNoPoliza.Text                = string.Empty;
            txtCuentaCarga.Text             = string.Empty;
            txtCuentaAbona.Text             = string.Empty;
            txtDepartamento.Text            = string.Empty;
            txtTipoCambio.Text              = string.Empty;
            metroTabControl1.SelectedTab    = metroTabPage1;
            errorProvider1.Clear();
        }

        private void btnPolizaContable_Click(object sender, EventArgs e)
        {
            pnlPolizaContable.Location  = new Point(33, 485);
            pnlPolizaContable.Visible   = true;
        }
        #endregion
        #endregion

        //CÓDIGO FUENTE PARA LA IMPRESIÓN DE RECIBOS TOMANDO UN FORMATO EN EXCEL Y UNA MACRO
        #region IMPRIMIR RECIBOS
        public DataTable ExportarRecibo()
        {
            //CREAMOS UNA NUEVA TABLA
            DataTable _DataTable = new DataTable();

            //AGREGAMOS COLUMNAS A LA TABLA CREADA
            _DataTable.Columns.Add("", typeof(string));
            _DataTable.Columns.Add("SOCIO", typeof(string));
            _DataTable.Columns.Add("MONTO PAGADO", typeof(string));
            _DataTable.Columns.Add("FECHA DE PAGO", typeof(string));
            _DataTable.Columns.Add("RECIBO", typeof(string));

            //OBTENEMOS EL REGISTRO SELECCIONADO
            var rowHandle = gridView1.FocusedRowHandle;

            //OBTENEMOS POR COLUMNA EL REGISTRO SELECCIONADO Y LO ASIGNAMOS
            //A UNA VARIABLE.
            var c1 = gridView1.GetRowCellValue(rowHandle, "sNombreSocio");
            var c2 = gridView1.GetRowCellValue(rowHandle, "dMonto");
            var c3 = gridView1.GetRowCellValue(rowHandle, "sFechaDeposito");
            var c4 = gridView1.GetRowCellValue(rowHandle, "sNumeroRecibo");
            string sC1 = c1.ToString();
            string sC2 = c2.ToString();
            string sC3 = c3.ToString();
            string sC4 = c4.ToString();

            //AGREGAMOS EL REGISTRO A LA TABLA
            _DataTable.Rows.Add("", sC1, sC2, sC3, sC4);

            return _DataTable;
        }

        private void btnImprimirRecibo_Click(object sender, EventArgs e)
        {
            //OBTENEMOS EL DOCUMENTO Y LO COPIAMOS A UNA RUTA EXISTENTE EN LAS CARPETAS DEL USUARIO
            //var filePath    = "C:\\Program Files (x86)\\Default Company Name\\LexaSio Installer\\FormatoRecibo.xlsm";
            var filePath = Application.StartupPath + "\\Resources\\FormatoRecibo.xlsm";


            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\').Last();
            string path     = "C:\\Users\\" + userName + "\\FormatoRecibo.xlsm";
            if (!File.Exists(path))
            {
                File.Copy(filePath, path);
            }

            try
            {
                object oMissing0 = System.Reflection.Missing.Value;

                Microsoft.Office.Interop.Excel.Application ExcelObj0 = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook    WBook0;
                Microsoft.Office.Interop.Excel.Worksheet   WSheet0;
                //Microsoft.Office.Interop.Excel.Range       celLrangE0;
                WBook0 = ExcelObj0.Workbooks.Open(path,
                    oMissing0, oMissing0, oMissing0, oMissing0, oMissing0,
                    oMissing0, oMissing0, oMissing0, oMissing0, oMissing0,
                    oMissing0, oMissing0, oMissing0, oMissing0);

                int rowCont = 0;
                //ABRIMOS LA HOJA EXISTENTE
                WSheet0 = (Microsoft.Office.Interop.Excel.Worksheet)WBook0.Sheets.get_Item(1);
                //ANALIZAMOS LOS DATOS DEL RANGO QUE DESEAMOS
                Microsoft.Office.Interop.Excel.Range range = WSheet0.get_Range("B2:B540", System.Reflection.Missing.Value);

                //OBTENEMOS EL NÚMERO DE LA ULTIMA CELDA QUE TIENE CONTENIDO
                //Y LO GUARDAMOS EN UNA VARIABLE
                if (range != null)
                    foreach (Microsoft.Office.Interop.Excel.Range r in range)
                    {
                        string value = r.Text;
                        if (value != string.Empty)
                        {
                            string user = r.Address;
                        }
                        else
                        {
                            string user     = r.Address;
                            string[] rango  = user.Split('$');
                            rowCont         = int.Parse(rango[2]);
                            break;
                        }
                    }

                //CERRAMOS EL LIBRO Y FINALIZAMOS LA APLICACIÓN
                WBook0.Close();
                ExcelObj0.Quit();

                rowCont = 2;
                object oMissing = System.Reflection.Missing.Value;
                //DECLARAMOS VARIABLES
                Microsoft.Office.Interop.Excel.Application ExcelObj = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook    WBook;
                Microsoft.Office.Interop.Excel.Worksheet   WSheet;
                Microsoft.Office.Interop.Excel.Range       celLrangE;
                WBook = ExcelObj.Workbooks.Open(path,
                    oMissing, oMissing, oMissing, oMissing, oMissing,
                    oMissing, oMissing, oMissing, oMissing, oMissing,
                    oMissing, oMissing, oMissing, oMissing);

                //ABRIMOS LA HOJA EXISTENTE
                WSheet = (Microsoft.Office.Interop.Excel.Worksheet)WBook.Sheets.get_Item(1);

                int rowcount = rowCont;

                //AGREGAMOS EL CONTENIDO DE LA TABLA QUE NOS REGRESA EL METODO EXPORTTOEXCEL()
                foreach (DataRow datarow in ExportarRecibo().Rows)
                {
                    rowcount += 1;
                    for (int i = 1; i <= ExportarRecibo().Columns.Count; i++)
                    {
                        WSheet.Cells[rowcount, i] = datarow[i - 1].ToString();
                        //AGREGAMOS EL CONTENIDO
                        if (rowcount > 3)
                        {
                            if (i == ExportarRecibo().Columns.Count)
                            {
                                if (rowcount % 2 == 0)
                                {
                                    celLrangE = WSheet.Range[WSheet.Cells[rowcount, 1], WSheet.Cells[rowcount, ExportarRecibo().Columns.Count]];
                                }
                            }
                        }
                    }
                }

                celLrangE = WSheet.Range[WSheet.Cells[1, 1], WSheet.Cells[rowcount, ExportarRecibo().Columns.Count]];
                celLrangE.EntireColumn.AutoFit();

                celLrangE = WSheet.Range[WSheet.Cells[1, 1], WSheet.Cells[2, ExportarRecibo().Columns.Count]];
                //GUARDAMOS EL LIBRO
                WBook.Save();
                //CERRAMOS EL LIBRO Y CERRAMOS LA INSTANCIA DE EXCEL
                WBook.Close();
                ExcelObj.Quit();

                //DEFINIMOS EL OBJETO EXCEL
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                //INICIAMOS EXCEL Y ABRIMOS LA HOJA DE TRABAJO
                xlWorkBook = xlApp.Workbooks.Open(path);
                //CORREMOS LA MACRO INGRESANDO LOS ARGUMENTOS NECESARIOS
                xlApp.Run("Imprimir", 3, 3);
                //CERRAMOS LA HOJA DE TRABAJO
                xlWorkBook.Close(false);
                //CERRAMOS LA APLICACIÓN EXCEL
                xlApp.Quit();
                //LIMPIAMOS
                releaseObject(xlApp);
                releaseObject(xlWorkBook);
                //ELIMINAMOS EL DOCUMENTO
                File.Delete(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //~~> Release the objects
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnImprimirMultiplesRecibos_Click(object sender, EventArgs e)
        {
            //OBTENEMOS EL DOCUMENTO Y LO COPIAMOS A UNA RUTA EXISTENTE EN LAS CARPETAS DEL USUARIO
            var filePath     = Application.StartupPath + "\\Resources\\FormatoRecibo.xlsm"; //"C:\\Program Files (x86)\\Default Company Name\\LexaSio Installer\\FormatoRecibo.xlsm";
            
            string userName  = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\').Last();
            string path      = "C:\\Users\\" + userName + "\\FormatoRecibo.xlsm";
            //string path    = "C:\\Users\\Desarrollo04\\Desktop\\FormatoRecibo.xlsm";
            if (!File.Exists(path))
            {
                File.Copy(filePath, path);
            }

            try
            {
                object oMissing0 = System.Reflection.Missing.Value;
                //DECLARAMOS VARIABLES
                Microsoft.Office.Interop.Excel.Application ExcelObj0 = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook    WBook0;
                Microsoft.Office.Interop.Excel.Worksheet   WSheet0;
                //Microsoft.Office.Interop.Excel.Range       celLrangE0;
                WBook0 = ExcelObj0.Workbooks.Open(path,
                    oMissing0, oMissing0, oMissing0, oMissing0, oMissing0,
                    oMissing0, oMissing0, oMissing0, oMissing0, oMissing0,
                    oMissing0, oMissing0, oMissing0, oMissing0);

                int rowCont = 0;
                //ABRIMOS LA HOJA EXISTENTE
                WSheet0 = (Microsoft.Office.Interop.Excel.Worksheet)WBook0.Sheets.get_Item(1);
                //ANALIZAMOS LOS DATOS DEL RANGO QUE DESEAMOS
                Microsoft.Office.Interop.Excel.Range range = WSheet0.get_Range("B2:B540", System.Reflection.Missing.Value);

                //OBTENEMOS EL NÚMERO DE LA ULTIMA CELDA QUE TIENE CONTENIDO
                //Y LO GUARDAMOS EN UNA VARIABLE
                if (range != null)
                    foreach (Microsoft.Office.Interop.Excel.Range r in range)
                    {
                        string value = r.Text;
                        if (value != string.Empty)
                        {
                            string user = r.Address;
                        }
                        else
                        {
                            string user     = r.Address;
                            string[] rango  = user.Split('$');
                            rowCont         = int.Parse(rango[2]);
                            break;
                        }
                    }

                //CERRAMOS EL LIBRO Y FINALIZAMOS LA APLICACIÓN
                WBook0.Close();
                ExcelObj0.Quit();

                object oMissing = System.Reflection.Missing.Value;
                //DECLARAMOS VARIABLES
                Microsoft.Office.Interop.Excel.Application ExcelObj = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook WBook;
                Microsoft.Office.Interop.Excel.Worksheet WSheet;
                Microsoft.Office.Interop.Excel.Range celLrangE;
                WBook = ExcelObj.Workbooks.Open(path,
                    oMissing, oMissing, oMissing, oMissing, oMissing,
                    oMissing, oMissing, oMissing, oMissing, oMissing,
                    oMissing, oMissing, oMissing, oMissing);

                //ABRIMOS LA HOJA EXISTENTE
                WSheet = (Microsoft.Office.Interop.Excel.Worksheet)WBook.Sheets.get_Item(1);

                int rowcount = rowCont - 1;
                //AGREGAMOS EL CONTENIDO DE LA TABLA QUE NOS REGRESA EL METODO EXPORTTOEXCEL()
                foreach (DataRow datarow in ExportarRecibosMultiples().Rows)
                {
                    rowcount += 1;
                    for (int i = 1; i <= ExportarRecibosMultiples().Columns.Count; i++)
                    {
                        WSheet.Cells[rowcount, i] = datarow[i - 1].ToString();
                        //AGREGAMOS EL CONTENIDO
                        if (rowcount > 3)
                        {
                            if (i == ExportarRecibosMultiples().Columns.Count)
                            {
                                if (rowcount % 2 == 0)
                                {
                                    celLrangE = WSheet.Range[WSheet.Cells[rowcount, 1], WSheet.Cells[rowcount, ExportarRecibosMultiples().Columns.Count]];
                                }
                            }
                        }
                    }
                }

                celLrangE = WSheet.Range[WSheet.Cells[1, 1], WSheet.Cells[rowcount, ExportarRecibosMultiples().Columns.Count]];
                celLrangE.EntireColumn.AutoFit();

                celLrangE = WSheet.Range[WSheet.Cells[1, 1], WSheet.Cells[2, ExportarRecibosMultiples().Columns.Count]];
                //GUARDAMOS EL LIBRO
                WBook.Save();
                //CERRAMOS EL LIBRO Y CERRAMOS LA INSTANCIA DE EXCEL
                WBook.Close();
                ExcelObj.Quit();


                object oMissing1 = System.Reflection.Missing.Value;
                //DECLARAMOS VARIABLES
                Microsoft.Office.Interop.Excel.Application ExcelObj1 = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook WBook1;
                Microsoft.Office.Interop.Excel.Worksheet WSheet1;
                //Microsoft.Office.Interop.Excel.Range celLrangE1;
                WBook1 = ExcelObj1.Workbooks.Open(path,
                    oMissing1, oMissing1, oMissing1, oMissing1, oMissing1,
                    oMissing1, oMissing1, oMissing1, oMissing1, oMissing1,
                    oMissing1, oMissing1, oMissing1, oMissing1);


                int rowContU = 0;
                //ABRIMOS LA HOJA EXISTENTE
                WSheet1 = (Microsoft.Office.Interop.Excel.Worksheet)WBook1.Sheets.get_Item(1);
                //ANALIZAMOS LOS DATOS DEL RANGO QUE DESEAMOS
                Microsoft.Office.Interop.Excel.Range rangeU = WSheet1.get_Range("B2:B1048576", System.Reflection.Missing.Value);

                //OBTENEMOS EL NÚMERO DE LA ULTIMA CELDA QUE TIENE CONTENIDO
                //Y LO GUARDAMOS EN UNA VARIABLE
                if (rangeU != null)
                    foreach (Microsoft.Office.Interop.Excel.Range r in rangeU)
                    {
                        string value = r.Text;
                        if (value != string.Empty)
                        {
                            string user = r.Address;
                        }
                        else
                        {
                            string user     = r.Address;
                            string[] rango  = user.Split('$');
                            rowContU        = int.Parse(rango[2]) - 1;
                            break;
                        }
                    }

                //CERRAMOS EL LIBRO Y CERRAMOS LA INSTANCIA DE EXCEL
                WBook1.Close();
                ExcelObj1.Quit();

                //DEFINIMOS EL OBJETO EXCEL--------------------------------------------------------------------------------------------
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                //INICIAMOS EXCEL Y ABRIMOS LA HOJA DE TRABAJO
                xlWorkBook = xlApp.Workbooks.Open(path);
                //CORREMOS LA MACRO INGRESANDO LOS ARGUMENTOS NECESARIOS
                xlApp.Run("Imprimir", 3, rowContU);
                //CERRAMOS LA HOJA DE TRABAJO
                xlWorkBook.Close(false);
                //CERRAMOS LA APLICACIÓN EXCEL
                xlApp.Quit();
                //LIMPIAMOS
                releaseObject(xlApp);
                releaseObject(xlWorkBook);

                File.Delete(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable ExportarRecibosMultiples()
        {
            //CREAMOS UNA NUEVA TABLA
            DataTable table = new DataTable();
            
            //AGREGAMOS COLUMNAS A LA NUEVA TABLA
            table.Columns.Add("", typeof(string));
            table.Columns.Add("SOCIO", typeof(string));
            table.Columns.Add("MONTO PAGADO", typeof(string));
            table.Columns.Add("FECHA DE PAGO", typeof(string));
            table.Columns.Add("RECIBO", typeof(string));

            //AGREGMOS CONTENIDO A LA TABLA RECORRIENDO EL CONTENIDO DEL GRIDVIEW
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                string c1 = Convert.ToString(gridView1.GetRowCellValue(i, "sNombreSocio"));
                string c2 = Convert.ToString(gridView1.GetRowCellValue(i, "dMonto"));
                string c3 = Convert.ToString(gridView1.GetRowCellValue(i, "sFechaDeposito"));
                string c4 = Convert.ToString(gridView1.GetRowCellValue(i, "sNumeroRecibo"));

                table.Rows.Add("", c1, c2, c3, c4);
            }
            return table;
        }
        #endregion

        //OTRAS FUNCIONES DE LOS CONTROLES COMO MOSTRAR PANELES O MENSAJES
        #region FUNCIONES CONTROLES
        public int ValidarInformacion()
        {
            int iResultado = 0;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtNoPoliza.Text))
            {
                this.errorProvider1.SetError(txtNoPoliza, "Número de Póliza");
                metroTabControl1.SelectedTab = metroTabPage1;
                iResultado = 1;
            }

            if (cmbxTipoPoliza.SelectedIndex == -1)
            {
                this.errorProvider1.SetError(cmbxTipoPoliza, "Debe seleccionar un tipo de póliza.");
                metroTabControl1.SelectedTab = metroTabPage1;
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txtCuentaCarga.Text))
            {
                this.errorProvider1.SetError(txtCuentaCarga, "Número de cuenta que carga.");
                metroTabControl1.SelectedTab = metroTabPage2;
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txtCuentaAbona.Text))
            {
                this.errorProvider1.SetError(txtCuentaAbona, "Número de cuenta que abona.");
                metroTabControl1.SelectedTab = metroTabPage2;
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txtDepartamento.Text))
            {
                this.errorProvider1.SetError(txtDepartamento, "Departamento");
                metroTabControl1.SelectedTab = metroTabPage4;
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txtTipoCambio.Text))
            {
                this.errorProvider1.SetError(txtTipoCambio, "Tipo de Cambio");
                metroTabControl1.SelectedTab = metroTabPage5;
                iResultado = 1;
            }

            return iResultado;
        }

        private void btnConstanciaAlimentos_Click(object sender, EventArgs e)
        {
            pnlConstanciaAlimentos.Location = new Point(33, 485);
            if (pnlConstanciaAlimentos.Visible)
                pnlConstanciaAlimentos.Visible = false;
            else
                pnlConstanciaAlimentos.Visible = true;
        }

        private void btnCancelarGenerarConstancia_Click(object sender, EventArgs e)
        {
            if (pnlConstanciaAlimentos.Visible)
                pnlConstanciaAlimentos.Visible = false;

            dtFechaEntiende.Value = DateTime.Now;
        }

        private void btnMostrarImprimirRecibos_Click(object sender, EventArgs e)
        {
            //panel2.Location = new Point(33, 297);
            panel2.Location = new Point(33, 485);
            if (panel2.Visible)
                panel2.Visible = false;
            else
                panel2.Visible = true;
        }

        private void lnkCerrarImprimirRecibos_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtNoPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }
        #endregion

        
    }
}