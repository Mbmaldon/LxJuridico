using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ClaseData.Clases.Exportar
{
    public class ExportExcelCallCenter
    {
        /*Función para esportar toda la información de datagrid  que se le envia*/
        public void Expotar(DataGridView datos)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Evaluaciones";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;
                int iTotalColumnas = datos.Columns.Count;

                /*Contador y escritura de cabeceras de data grid*/
                //Loop through each row and read value from each column. 
                for (int i = 0; i < datos.Rows.Count -1 ; i++)
                {
                    if (cellRowIndex == 1)
                    {
                        for (int x = 0; x < datos.Columns.Count; x++)
                        {
                            //if (x != 0)
                            //{
                            //if (datos.Rows[i].Cells[x].Visible == true)
                            //{
                            if (x == iTotalColumnas - 1)
                            {
                                cellRowIndex++;
                            }
                            else
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = datos.Columns[x].HeaderText;
                                cellColumnIndex++;
                            }
                            //}
                            //}
                        }
                    }

                    /*Contador y escritura de cada registro cargado en el datagrid*/
                    cellColumnIndex = 1;
                    for (int j = 0; j < datos.Columns.Count; j++)
                    {

                        //if (j != 0)
                        //{
                        //if (datos.Rows[i].Cells[j].Visible == true)
                        //{

                        ////Excel index starts from 1,1.As first Row would have the Column headers, adding a condition check. 
                        if (j == iTotalColumnas - 1)
                        {
                            cellRowIndex++;
                        }
                        else
                        {
                            try
                            {
                                if (j == 8)
                                {
                                    worksheet.Cells[cellRowIndex, 9].Cells.Interior.Color = datos.Rows[i].Cells[8].Style.BackColor;
                                    cellColumnIndex++;
                                }
                                else
                                {
                                    worksheet.Cells[cellRowIndex, cellColumnIndex] = datos.Rows[i].Cells[j].Value.ToString();
                                    cellColumnIndex++;
                                }
                            }
                            catch
                            {
                            }
                            // worksheet.Cells[cellRowIndex, 9].Cells.Interior.Color = datos.Rows[i].Cells[9].Style.BackColor;
                            //cellColumnIndex++;
                        }
                            //}
                        //}
                    }
                    cellColumnIndex = 1;
                    //cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    System.Windows.MessageBox.Show("La información ha sido exportada correctamente", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
    }
}
