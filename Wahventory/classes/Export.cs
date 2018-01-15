using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;

namespace Wahventory.classes
{
    class MyExcel
    {
        public static string Template = @System.IO.Directory.GetCurrentDirectory() + "\\" + "TemplateNew.xlsx";
        private static Excel.Workbook MyBook = null;
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet MySheet = null;
        private static int lastRow = 0;

        public static void InitializeExcel()
        {
            MyApp = new Excel.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(Template);
            MySheet = (Excel.Worksheet)MyBook.Sheets[1]; // Explict cast is not required here
            lastRow = MySheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
        }

        public static void CloseExcel()
        {
            MyBook.Saved = true;
            MyApp.Quit();

        }

    }

    class Export
    {
        public void ExportToExcel(System.Windows.Forms.DataGridView dgvReports,String title,int tabIndex)
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Open(MyExcel.Template);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Reports";

            int rowIndex = 6;
            int colIndex = 1;

            if (tabIndex == 0)
            {
                for (int x = -1; x < dgvReports.RowCount; x++)
                {
                    for (int y = 3; y < dgvReports.ColumnCount; y++)
                    {
                        if (rowIndex == 6)
                            worksheet.Cells[rowIndex, colIndex] = dgvReports.Columns[y].HeaderText;
                        else
                        {

                            worksheet.Cells[rowIndex, colIndex] = dgvReports.Rows[x].Cells[y].Value.ToString();

                            if (colIndex == 1)
                            {
                                if (dgvReports.Rows[x].Cells[y].Value.ToString() == "1")
                                    worksheet.Cells[rowIndex, colIndex] = "Returned";
                                else
                                    worksheet.Cells[rowIndex, colIndex] = "Assigned";
                            }
                        }
                        colIndex++;
                    }
                    colIndex = 1;
                    rowIndex++;
                }
            }
            else if (tabIndex == 1)
            {
                for (int x = -1; x < dgvReports.RowCount; x++)
                {
                    for (int y = 2; y < dgvReports.ColumnCount; y++)
                    {
                        if (rowIndex == 6)
                            worksheet.Cells[rowIndex, colIndex] = dgvReports.Columns[y].HeaderText;
                        else
                        {

                            worksheet.Cells[rowIndex, colIndex] = dgvReports.Rows[x].Cells[y].Value.ToString();

                            if (colIndex == 1)
                            {
                                if (dgvReports.Rows[x].Cells[y].Value.ToString() == "0")
                                    worksheet.Cells[rowIndex, colIndex] = "Throw";
                                else if(dgvReports.Rows[x].Cells[y].Value.ToString() == "1")
                                    worksheet.Cells[rowIndex, colIndex] = "Sell";
                                else if (dgvReports.Rows[x].Cells[y].Value.ToString() == "2")
                                    worksheet.Cells[rowIndex, colIndex] = "Donate";
                                else if (dgvReports.Rows[x].Cells[y].Value.ToString() == "3")
                                    worksheet.Cells[rowIndex, colIndex] = "LOST";
                            }
                        }
                        colIndex++;
                    }
                    colIndex = 1;
                    rowIndex++;
                }
            }
            else if (tabIndex == 2)
            {
                for (int x = -1; x < dgvReports.RowCount; x++)
                {
                    for (int y = 1; y < dgvReports.ColumnCount-1; y++)
                    {
                        if (rowIndex == 6)
                            worksheet.Cells[rowIndex, colIndex] = dgvReports.Columns[y].HeaderText;
                        else
                        {

                            worksheet.Cells[rowIndex, colIndex] = dgvReports.Rows[x].Cells[y].Value.ToString();

                        }
                        colIndex++;
                    }
                    colIndex = 1;
                    rowIndex++;
                }
            }



            worksheet.Rows.AutoFit();
            worksheet.Columns.AutoFit();
            worksheet.Cells[2, "D"] = title;
            worksheet.Cells[4, "D"] = DateTime.Now;
            worksheet.Cells[3, "D"] = "Exported by " + frmLogin.UserFullName;
            worksheet.Cells[4, "F"] = dgvReports.RowCount.ToString() + " records";

            //Getting the location and file name of the excel to save from user. 
            System.Windows.Forms.SaveFileDialog saveDialog = new System.Windows.Forms.SaveFileDialog();
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveDialog.FilterIndex = 2;

            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String savePath = saveDialog.FileName + ".xlsx";
                workbook.SaveAs(saveDialog.FileName);
                System.Windows.Forms.MessageBox.Show(null, "Reports was successfully exported to " + savePath, "Export reports", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(savePath);
            }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
