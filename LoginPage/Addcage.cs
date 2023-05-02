using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace LoginPage
{
    public partial class Addcage : Form
    {
        public Addcage()
        {
            InitializeComponent();
        }

        private void length_TextChanged(object sender, EventArgs e)
        {

        }

        private void CageAddBtn_Click(object sender, EventArgs e)
        {
            string fileName = "birds.xlsx";
            string projectDirectory = System.IO.Path.GetDirectoryName(Application.StartupPath);
            string dataFolder = Path.Combine(projectDirectory, "Data");
            string filePath = System.IO.Path.Combine(dataFolder, fileName);
            bool fileExists = File.Exists(filePath);
            int n = 0;
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            application.DisplayAlerts = false;
            workbook = application.Workbooks.Open(filePath);
            worksheet = workbook.Sheets[3]; // Get the cages worksheet in the workbook

            // Get the last row number
            int lastRow = worksheet.UsedRange.Rows.Count+1;
            int check = 0;
            if (int.TryParse(lengthBox.Text, out n) && int.TryParse(widthBox.Text, out n) && int.TryParse(heightBox.Text, out n))
            {
            worksheet.Cells[lastRow, 1] = "a"+lastRow;
                worksheet.Cells[lastRow, 2] = lengthBox.Text;
                worksheet.Cells[lastRow, 3] = widthBox.Text;
                worksheet.Cells[lastRow, 4] = heightBox.Text;
                worksheet.Cells[lastRow, 5] = materialBox.Text;

            workbook.Save();
            }


            MessageBox.Show("Cage was added successfully");
            this.Hide();
            lengthBox.Text = null;
            widthBox.Text = null;
            heightBox.Text = null;
            materialBox.Text = null;

            // Close the workbook and release the objects
            workbook.Close();
            Marshal.ReleaseComObject(workbook);

            application.Quit();
            Marshal.ReleaseComObject(application);
            Process[] pro = Process.GetProcessesByName("excel");

            pro[0].Kill();
            pro[0].WaitForExit();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // Release COM objects
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(application);


        }

        private void material_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
