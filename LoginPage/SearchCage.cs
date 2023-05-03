using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace LoginPage
{
    public partial class SearchCage : Form
    {
        public SearchCage()
        {
            InitializeComponent();
        }
        private void cageSearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cageSearchBox.Text == "Cage ID")
            {
                idTextBox.Visible = true;
                materialListBox.Visible = false;
                /*    materialListBox.Items.Clear();
                    materialListBox.Text = null;*/


            }
            else if (cageSearchBox.Text == "Material")
            {
                materialListBox.Items.Clear();
                materialListBox.Text = null;

                idTextBox.Visible = false;
                materialListBox.Visible = true;
                materialListBox.Items.Add("wood");
                materialListBox.Items.Add("plastic");
                materialListBox.Items.Add("iron");

            }

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            string fileName = "birds.xlsx";
            string projectDirectory = System.IO.Path.GetDirectoryName(Application.StartupPath);
            string dataFolder = Path.Combine(projectDirectory, "Data");
            string filePath = System.IO.Path.Combine(dataFolder, fileName);
            bool fileExists = File.Exists(filePath);

            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            application.DisplayAlerts = false;
            workbook = application.Workbooks.Open(filePath);
            worksheet = workbook.Sheets[3];

            int lastRow = worksheet.UsedRange.Rows.Count + 1;
            int rowIndex = 0;
            int n = 0;
            dataGridCages.Rows.Clear();
            for (int i = 2; i <= lastRow; i++)
            { // Start from 2 to skip the header row

                Excel.Range cageIDCell = worksheet.Cells[i, 1];
                Excel.Range lengthCell = worksheet.Cells[i, 2];
                Excel.Range widthCell = worksheet.Cells[i, 3];
                Excel.Range heightCell = worksheet.Cells[i, 4];
                Excel.Range materialCell = worksheet.Cells[i, 5];


                if (cageSearchBox.Text == "Cage ID")
                {
                    if (cageIDCell.Value == idTextBox.Text)
                    {
                        rowIndex = dataGridCages.Rows.Add();
                        dataGridCages.Rows[rowIndex].Cells[0].Value = cageIDCell.Value;
                        dataGridCages.Rows[rowIndex].Cells[1].Value = lengthCell.Value;
                        dataGridCages.Rows[rowIndex].Cells[2].Value = widthCell.Value;
                        dataGridCages.Rows[rowIndex].Cells[3].Value = heightCell.Value;
                        dataGridCages.Rows[rowIndex].Cells[4].Value = materialCell.Value;


                    }

                }
                else if (cageSearchBox.Text == "Material")
                {
                    if (materialCell.Value == materialListBox.Text)
                    {

                        rowIndex = dataGridCages.Rows.Add();
                        dataGridCages.Rows[rowIndex].Cells[0].Value = cageIDCell.Value;
                        dataGridCages.Rows[rowIndex].Cells[1].Value = lengthCell.Value;
                        dataGridCages.Rows[rowIndex].Cells[2].Value = widthCell.Value;
                        dataGridCages.Rows[rowIndex].Cells[3].Value = heightCell.Value;
                        dataGridCages.Rows[rowIndex].Cells[4].Value = materialCell.Value;

                    }
                }




            }

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




        }

        private void cageSearchMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (MainPage FormMain = new MainPage())
                FormMain.ShowDialog();
            Show();
        }

        private void cageSearchExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
