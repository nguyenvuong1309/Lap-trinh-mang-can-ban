using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;

namespace Lab2
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        private void loadData(string name,string id,string phonenumber,float math,float literature)
        {
            string s = name + Environment.NewLine + id + Environment.NewLine + phonenumber + Environment.NewLine + math.ToString() + Environment.NewLine + literature.ToString();
        }
        private void importData_Click(object sender, EventArgs e)
        {
            Import_data data = new Import_data(this);
            data.ShowDialog();
        }
        public class UserInfo
        {
            public string name { get; set; }
            public string id { get; set; }
            public string phonenumber { get; set; }
            public float mathscore { get; set; }
            public float literature { get; set; }
        }
        private void renderData_Click(object sender, EventArgs e)
        {
            if (dataGrid.Rows.Count > 1) { 
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strFileName;

            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Excel office |*.xls; *xlsx";
            openFD.ShowDialog();
            strFileName = openFD.FileName;

                if (strFileName != "")
                {
                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWorkbook = xlApp.Workbooks.Open(strFileName);
                    xlWorksheet = xlWorkbook.Worksheets["Sheet1"];
                    xlRange = xlWorksheet.UsedRange;
                    int i = 0;
                    for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                    {
                        i++;
                        dataGrid.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text);
                    }
                    xlWorkbook.Close();
                    xlApp.Quit();
                }
            }
            else
            {
                MessageBox.Show("Please enter data");
            }
        }
        private void export_Click(object sender, EventArgs e)
        {
            if (dataGrid.Rows.Count > 1) {
                dataGrid.SelectAll();
                DataObject copydata = dataGrid.GetClipboardContent();
                if (copydata != null) Clipboard.SetDataObject(copydata);
                Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
                xlapp.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook xlWbook;
                Microsoft.Office.Interop.Excel.Worksheet xlsheet;
                object miseddata = System.Reflection.Missing.Value;
                xlWbook = xlapp.Workbooks.Add(miseddata);

                xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
                xlr.Select();

                xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
            else
            {
                MessageBox.Show("Please enter data");
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (dataGrid.Rows.Count > 1) {
                try
                {
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    app.Visible = true;
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = "Records";

                    try
                    {
                        for (int i = 1; i < dataGrid.Columns.Count + 1; i++)
                        {
                            worksheet.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;
                        }
                        for (int i = 0; i < dataGrid.Rows.Count - 0; i++)
                        {
                            for (int j = 0; j < dataGrid.Columns.Count; j++)
                            {
                                if (dataGrid.Rows[i].Cells[j].Value != null)
                                {
                                    worksheet.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value.ToString();
                                }
                                else
                                {
                                    worksheet.Cells[i + 2, j + 1] = "";
                                }
                            }
                        }
                        SaveFileDialog saveDialog = new SaveFileDialog();
                        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                        saveDialog.FilterIndex = 2;

                        if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            workbook.SaveAs(saveDialog.FileName);
                            MessageBox.Show("Save Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    finally
                    {
                        app.Quit();
                        workbook = null;
                        worksheet = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please enter data");
            }
        }
    }
}
