using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExcelSQLData.VetSystemReference;
using Microsoft.Office.Tools.Ribbon;
using System.ServiceModel;

using SOAPConnectToDatabase;

namespace ExcelSQLData
{
    public partial class MyRibbon
    {
        private void MyRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, RibbonControlEventArgs e)
        {
            OperateDatabaseClient client = new OperateDatabaseClient();
            Microsoft.Office.Interop.Excel.Window window = e.Control.Context;
            Microsoft.Office.Interop.Excel.Worksheet activeWorksheet = ((Microsoft.Office.Interop.Excel.Worksheet)window.Application.ActiveSheet);
            Microsoft.Office.Interop.Excel.Range firstRow = activeWorksheet.get_Range("A1");
            firstRow.EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown);
            Microsoft.Office.Interop.Excel.Range newFirstRow = activeWorksheet.get_Range("A1");
            try
            {
                var doctors = client.GetAllDoctors();

                string cellNameA;
                string cellNameB;
                int counter = 1;
                foreach (var item in doctors)
                {
                    cellNameA = "A" + counter.ToString();
                    cellNameB = "B" + counter.ToString();
                    var rangeA = activeWorksheet.get_Range(cellNameA, cellNameA);
                    rangeA.Value2 = item.Name;
                    var rangeB = activeWorksheet.get_Range(cellNameB, cellNameB);
                    rangeB.Value2 = item.Email;
                    ++counter;
                }
            }
            catch (EndpointNotFoundException ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Exception in connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSaveData_Click(object sender, RibbonControlEventArgs e)
        {
            OperateDatabaseClient client = new OperateDatabaseClient();
            Microsoft.Office.Interop.Excel.Window window = e.Control.Context;
            Microsoft.Office.Interop.Excel.Worksheet activeWorksheet = ((Microsoft.Office.Interop.Excel.Worksheet)window.Application.Sheets[2]);
            activeWorksheet.Activate();
            Microsoft.Office.Interop.Excel.Range rng = activeWorksheet.get_Range("A1:D4");
            for (int i = 1; i <= rng.Rows.Count; i++)
            {
                Doctor s = new Doctor();
                s.Name = rng.Cells[i, 1].Value2.ToString();
                s.Email = rng.Cells[i, 3].Value2.ToString();
                s.Phone = rng.Cells[i, 2].Value2.ToString();
                s.Password = rng.Cells[i, 4].Value2.ToString();
                try
                {
                    client.InsertDoctor(s);
                }
                catch (EndpointNotFoundException ex)
                {
                    MessageBox.Show(ex.InnerException.Message, "Exception in connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
