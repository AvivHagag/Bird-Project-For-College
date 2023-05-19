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
using WinFormsApp1;
using Excel = Microsoft.Office.Interop.Excel;

namespace LoginPage
{
    public partial class EditBird : Form
    {
        // all the data that come from the parent who choosen 
        public string birdID;
        public string species;
        public string subSpecies;
        public string cageID;
        public string gender;
        public string headcolor;
        public string chestcolor;
        public string bodycolor;
        public Boolean reciveFromMothrer;
        public Boolean reciveFromFather;
        public string sheadcolor;
        public string schestcolor;
        public string sbodycolor;
        public EditBird()
        {
            InitializeComponent();

        }

        private void newCageNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeCageBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditBird_Load(object sender, EventArgs e)
        {
            oldBirdCage.Text = cageID;

        }

        private void loginExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Searchbird().Show();


        }
        private Boolean CageExist(String cage)
        {
            string fileName = "birds.xlsx";
            string projectDirectory = System.IO.Path.GetDirectoryName(Application.StartupPath);
            string dataFolder = Path.Combine(projectDirectory, "Data");
            string filePath = System.IO.Path.Combine(dataFolder, fileName);
            bool fileExists = File.Exists(filePath);

            Excel.Application application2 = new Excel.Application();
            Excel.Workbook workbook2;
            Excel.Worksheet worksheet2;
            application2.DisplayAlerts = false;
            workbook2 = application2.Workbooks.Open(filePath);
            worksheet2 = workbook2.Sheets[3]; // Get the third worksheet in the workbook

            // Get the last row number
            int lastRow = worksheet2.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;

            bool cageExist = false;
            for (int i = 2; i <= lastRow; i++)
            {
                // Start from 2 to skip the header row
                Excel.Range cageCell = worksheet2.Cells[i, 1];
                Excel.Range userID = worksheet2.Cells[i, 6];
                if (cageCell.Value != null && cageCell.Value.ToString() == cage && userID.Value.ToString() == ((LoginForm)Application.OpenForms["LoginForm"]).getid())
                {
                    cageExist = true;
                    break;
                }

            }
            // Close the workbook and release the objects
            workbook2.Close();
            Marshal.ReleaseComObject(workbook2);

            application2.Quit();
            
            return cageExist;
        }
        
        private void addChickBtn_Click(object sender, EventArgs e)
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
            worksheet = workbook.Sheets[2]; // Get the second worksheet in the workbook

            string newCageID = newCageNumberBox.Text;

            int lastRow = worksheet.UsedRange.Rows.Count;
            int rowIndex = 0;
            int n = 0;
            for (int i = 2; i <= lastRow; i++)
            { // Start from 2 to skip the header row
                try
                {
                Excel.Range birdIDCell = worksheet.Cells[i, 1];

                if (birdIDCell.Value.ToString() == birdID)
                {
                    if (CageExist(newCageID))
                    {
                        worksheet.Cells[i, 8] = newCageID;
                        workbook.Save();
                        MessageBox.Show("Bird cage changed successfully");
                        this.Hide();
                        new Searchbird().Show();

                    }
                   
                    else
                    {
                        MessageBox.Show("Cage number is not exist, try again.");
                        new Searchbird().Show();
                        this.Close();
                        break;
                    }
                }
                }
                catch
                {
                    MessageBox.Show("Error, try again.");
                    break;
                    
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

        }
    }
}
