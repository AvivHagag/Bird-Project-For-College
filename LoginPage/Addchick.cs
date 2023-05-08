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
using static System.Runtime.InteropServices.JavaScript.JSType;
using Boolean = System.Boolean;

namespace LoginPage
{
    public partial class Addchick : Form
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


        public Addchick()
        {
            InitializeComponent();


        }

        private void chickGroup_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chickMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (MainPage FormMain = new MainPage())
                FormMain.ShowDialog();
            Show();
        }

        private void exitChickBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void addChickBtn_Click(object sender, EventArgs e)
        {
            Boolean motherSerial = false;
            Boolean fatherSerial = false;
            DateTime selectedDate = dateChickBox.Value.Date;
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
            string sheadcolor; 
            string schestcolor;
            string sbodycolor;

            // Get the last row number
            int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            if (reciveFromFather)
            {
                for (int i = 2; i <= lastRow; i++)
                {
                    // Start from 2 to skip the header row
                    Excel.Range userCell = worksheet.Cells[i, 1];
                    if (userCell.Value.ToString() == motherChickBox.Text)
                    {
                        Excel.Range GenderCell = worksheet.Cells[i, 4];
                        if (GenderCell.Value.ToString() == "Female")
                        {

                            sheadcolor = worksheet.Cells[i,9].Value.ToString();
                            schestcolor = worksheet.Cells[i,10].Value.ToString();
                            sbodycolor = worksheet.Cells[i,11]. Value.ToString();
                            motherSerial = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 2; i <= lastRow; i++)
                {
                    // Start from 2 to skip the header row
                    Excel.Range user2Cell = worksheet.Cells[i, 1];
                    if (user2Cell.Value.ToString() == fatherChickBox.Text)
                    {
                        Excel.Range Gender2Cell = worksheet.Cells[i, 4];
                        if (Gender2Cell.Value.ToString() == "Male")
                        {
                            sheadcolor = worksheet.Cells[i, 9].Value.ToString();
                            schestcolor = worksheet.Cells[i, 10].Value.ToString();
                            sbodycolor = worksheet.Cells[i, 11].Value.ToString();
                            fatherSerial = true;
                            break;
                        }
                    }
                }

            }

            if (selectedDate != null && chickGenderCombo.Text!="" && ((reciveFromFather && motherSerial) || (reciveFromMothrer && fatherSerial)))
            {

                int newRow = lastRow + 1;
                worksheet.Cells[newRow, 1] = newRow - 1;
                worksheet.Cells[newRow, 2] = species;
                worksheet.Cells[newRow, 3] = subSpecies;
                worksheet.Cells[newRow, 4] = chickGenderCombo.Text;
                if (reciveFromFather && motherSerial)
                {
                    worksheet.Cells[newRow, 5] = motherChickBox.Text;
                    worksheet.Cells[newRow, 6] = birdID;

                }

                else if (reciveFromFather && fatherSerial)
                {
                    worksheet.Cells[newRow, 5] = birdID;
                    worksheet.Cells[newRow, 6] = fatherChickBox.Text;


                }
                worksheet.Cells[newRow, 7] = selectedDate;
                worksheet.Cells[newRow, 8] = cageID.ToString();
                worksheet.Cells[newRow, 9] = ((LoginForm)Application.OpenForms["LoginForm"]).getid();
                workbook.Save();
                MessageBox.Show("Bird was added successfully");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invaild input, Bird was not added");
                this.Hide();

            }

                chickGenderCombo.Text = null;
                motherChickBox.Text = null;
                fatherChickBox.Text = null;
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

        }
    }

