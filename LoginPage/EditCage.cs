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
    public partial class EditCage : Form
    {
        public string cageID;
        public string lengthCage;
        public string heightCage;
        public string widthCage;
        public string materialCage;
        public EditCage()
        {
            InitializeComponent();
        }

        private void EditCage_Load(object sender, EventArgs e)
        {
            heightCage1.Text = heightCage;
            lengthCage1.Text = lengthCage;
            widthCage1.Text = widthCage;
            materialCage1.Text = materialCage;
        }

        private void heightCage1_Click(object sender, EventArgs e)
        {


        }

        private void CageEditBtn_Click(object sender, EventArgs e)
        {
            //open system runtime-app
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


            int lastRow = worksheet.UsedRange.Rows.Count;
            int rowIndex = 0;
            int n = 0;

            for (int i = 2; i <= lastRow; i++)
            { // Start from 2 to skip the header row
                
                    Excel.Range cageIDCell = worksheet.Cells[i, 1];


                    if (cageIDCell.Value.ToString() == cageID)
                    {
                        if (int.TryParse(newLengthBox.Text, out n) && int.TryParse(newWidthBox.Text, out n) && int.TryParse(newHeightBox.Text, out n) && newLengthBox.Text != "" && newWidthBox.Text != "" && newHeightBox.Text != "" && newMaterialBox.Text != "" && int.Parse(newLengthBox.Text) > 0 && int.Parse(newWidthBox.Text) > 0 && int.Parse(newHeightBox.Text) > 0)
                        {
                            worksheet.Cells[i, 2] = newLengthBox.Text;
                            worksheet.Cells[i, 3] = newWidthBox.Text;
                            worksheet.Cells[i, 4] = newHeightBox.Text;
                            worksheet.Cells[i, 5] = newMaterialBox.Text;
                            workbook.Save();
                            MessageBox.Show("Cage details changed successfully");
                            newLengthBox.Text = null;
                            newWidthBox.Text = null;
                            newHeightBox.Text = null;
                            newMaterialBox.Text = null;
                        }
                        else
                        {
                            MessageBox.Show("Invalid input");
                            newLengthBox.Text = null;
                            newWidthBox.Text = null;
                            newHeightBox.Text = null;
                            newMaterialBox.Text = null;

                        }



                    }
               


            }
            workbook.Close();
            Marshal.ReleaseComObject(workbook);

            application.Quit();
            Marshal.ReleaseComObject(application);
            Process[] pro = Process.GetProcessesByName("excel");

            pro[0].Kill();
            pro[0].WaitForExit();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            new MainPage().Show();
            this.Close();
        }

        private void exitCageBtn_Click(object sender, EventArgs e)
        {
            new MainPage().Show();
            this.Close();
        }
    }
}
