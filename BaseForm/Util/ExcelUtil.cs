using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.IO;
using System.Reflection;

namespace Team2.Util
{
    public class ExcelUtil
    {
        //List<T>의 내용을 엑셀 파일 다운로드
        public static string ExcelExportListDTO<T>(List<T> list, string fileName, string exceptProperty)
        {
            Excel.Application xlApp = new Excel.Application();//엑셀프로그램
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();//엑셀파일 
            Excel.Worksheet xlWorksheet = xlWorkBook.Worksheets.get_Item(1);//엑셀쉬트

            try
            {
                //컬럼헤더를 찍어준다.(DTO의 속성명으로 컬럼헤더를 찍는다)
                int c = 0;
                foreach (PropertyInfo prop in typeof(T).GetProperties())
                {
                    if (!exceptProperty.Contains(prop.Name))
                    {
                        xlWorksheet.Cells[1, c + 1] = prop.Name;
                        c++;
                    }
                }

                //데이터를 찍어준다.
                for (int r = 0; r < list.Count; r++)
                {
                    c = 0;
                    foreach (PropertyInfo prop in typeof(T).GetProperties())
                    {
                        if (!exceptProperty.Contains(prop.Name))
                        {
                            if (prop.GetValue(list[r], null) != null)
                            {
                                xlWorksheet.Cells[r + 2, c + 1] = prop.GetValue(list[r], null).ToString();
                            }
                            c++;
                        }
                    }
                }

                xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close();
                xlApp.Quit();

                return null;
            }
            catch (Exception err)
            {
                return err.Message;
            }
            finally
            {
                releaseObject(xlWorksheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
        }

        //DataTable의 내용을 엑셀 파일 다운로드
        public static string ExcelExportDataTable(DataTable dt, string fileName)
        {
            Excel.Application xlApp = new Excel.Application();//엑셀프로그램
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();//엑셀파일 
            Excel.Worksheet xlWorksheet = xlWorkBook.Worksheets.get_Item(1);//엑셀쉬트

            try
            {
                //컬럼헤더를 찍어준다.
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    xlWorksheet.Cells[1, c + 1] = dt.Columns[c].ColumnName;
                }

                //데이터를 찍어준다.
                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    for (int c = 0; c < dt.Columns.Count; c++)
                    {
                        xlWorksheet.Cells[r + 2, c + 1] = dt.Rows[r][c].ToString();
                    }
                }

                xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close();
                xlApp.Quit();

                return null;
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message);
                return err.Message;
            }
            finally
            {
                releaseObject(xlWorksheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
        }

        public static string ExcelExportAccount(DataTable dt, string templateFile, string fileName)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(templateFile);
            Excel.Worksheet xlWorksheet = xlWorkBook.Worksheets.get_Item(1);

            try
            {
                //데이터를 찍어준다.
                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    //for (int c = 0; c < dt.Columns.Count; c++)
                    //{
                    xlWorksheet.Cells[r + 10, 2] = dt.Rows[r]["UserID"].ToString();
                    xlWorksheet.Cells[r + 10, 5] = dt.Rows[r]["Name"].ToString();
                    //}
                }

                xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close();
                xlApp.Quit();

                return null;
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message);
                return err.Message;
            }
            finally
            {
                releaseObject(xlWorksheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                //MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        //엑셀을 임포트해서 DataTable 리턴
        public static DataTable ExcelImportDataTable(string fileName)
        {
            try
            {
                string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"; //*.xls
                string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"; //*.xlsx

                string ext = Path.GetExtension(fileName);
                string connStr = string.Empty;
                if (ext == ".xls") // .xlsx
                    connStr = string.Format(Excel03ConString, fileName, "Yes");
                else
                    connStr = string.Format(Excel07ConString, fileName, "Yes");

                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();

                DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string sheetName = dtSchema.Rows[0]["TABLE_NAME"].ToString();

                string sql = $"select * from [{sheetName}]";
                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();

                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
