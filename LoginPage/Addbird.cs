using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace LoginPage
{
    public partial class Addbird : Form
    {
       

        public Addbird()
        {
            InitializeComponent();
        }

        private void SpeciescomboBox_SelectedIndex(object sender, EventArgs e)
        {
            if (SpeciescomboBox.Text == "American Gouldian")
            {
                SubspeciescomboBox.Items.Clear();
                SubspeciescomboBox.Items.Add("Notrh America");
                SubspeciescomboBox.Items.Add("Central America");
                SubspeciescomboBox.Items.Add("South America");
            }
            if (SpeciescomboBox.Text == "European Gouldian")
            {
                SubspeciescomboBox.Items.Clear();
                SubspeciescomboBox.Items.Add("East Europe");
                SubspeciescomboBox.Items.Add("West Europe");
            }
            if (SpeciescomboBox.Text == "Australian Gouldian")
            {
                SubspeciescomboBox.Items.Clear();
                SubspeciescomboBox.Items.Add("Central Australia");
                SubspeciescomboBox.Items.Add("Coastal cities");
            }
        }

        private void FinalAddbtn_Click(object sender, EventArgs e)
        {
            Boolean motherSerial = false;
            Boolean fatherSerial = false;
            if (SpeciescomboBox.Text != "" && SubspeciescomboBox.Text != "" && GendercomboBox.Text != "")
            {
                DateTime selectedDate = dateTimePicker1.Value.Date;
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

                // Get the last row number
                int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
                for (int i = 2; i <= lastRow; i++)
                {
                    // Start from 2 to skip the header row
                    Excel.Range userCell = worksheet.Cells[i, 1];
                    if (userCell.Value.ToString() == motherserialnumber.Text)
                    {
                        Excel.Range GenderCell = worksheet.Cells[i, 4];
                        if (GenderCell.Value.ToString() == "Female")
                        {
                            motherSerial = true;
                            break;
                        }
                    }
                }
                for (int i = 2; i <= lastRow; i++)
                {
                    // Start from 2 to skip the header row
                    Excel.Range user2Cell = worksheet.Cells[i, 1];
                    if (user2Cell.Value.ToString() == fatherserialnumber.Text)
                    {
                        Excel.Range Gender2Cell = worksheet.Cells[i, 4];
                        if (Gender2Cell.Value.ToString() == "Male")
                        {
                            fatherSerial = true;
                            break;
                        }
                    }
                }
                if (selectedDate != null && cagenumber.Text != null && CageExist(cagenumber.Text))
                {

                    int newRow = lastRow + 1;
                    worksheet.Cells[newRow, 1] = newRow - 1;
                    worksheet.Cells[newRow, 2] = SpeciescomboBox.Text;
                    worksheet.Cells[newRow, 3] = SubspeciescomboBox.Text;
                    worksheet.Cells[newRow, 4] = GendercomboBox.Text;
                    if (motherSerial == true)
                        worksheet.Cells[newRow, 5] = motherserialnumber.Text;
                    else
                        worksheet.Cells[newRow, 5] = null;
                    if (fatherSerial == true)
                        worksheet.Cells[newRow, 6] = fatherserialnumber.Text;
                    else
                        worksheet.Cells[newRow, 5] = null;
                    worksheet.Cells[newRow, 7] = selectedDate;
                    worksheet.Cells[newRow, 8] = cagenumber.Text;
                    worksheet.Cells[newRow, 9] = ((LoginForm)Application.OpenForms["LoginForm"]).getid();
                    workbook.Save();
                    MessageBox.Show("Bird was added successfully");
                    this.Hide();

                    SpeciescomboBox.Text = null;
                    SubspeciescomboBox.Text = null;
                    GendercomboBox.Text = null;
                    motherserialnumber.Text = null;
                    fatherserialnumber.Text = null;
                    cagenumber.Text = null;
                    selectedDate = DateTime.Today;

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
                else if (!(CageExist(cagenumber.Text)))
                {
                    MessageBox.Show("Cage number is not exist, try again.");

                }
                else
                    MessageBox.Show("Bird was added successfully");
            }
            else
                MessageBox.Show("Bird was added successfully");
        
        }
        private Boolean CageExist(String cage)
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
            worksheet = workbook.Sheets[3]; // Get the third worksheet in the workbook

            // Get the last row number
            int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;

            bool cageExist = false;
            for (int i = 2; i <= lastRow; i++)
            {
                // Start from 2 to skip the header row
                Excel.Range cageCell = worksheet.Cells[i, 1];
                if (cageCell.Value != null && cageCell.Value.ToString() == cage)
                {
                    cageExist = true;
                    break;
                }
               
            }

            return cageExist;
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (MainPage FormMain = new MainPage())
                FormMain.ShowDialog();
            Show();
        }

        private void SubspeciescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void birdExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
