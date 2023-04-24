using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace LoginPage
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            //MessageBox.Show(((LoginForm)Application.OpenForms["LoginForm"]).getid() + " was logged in! "); // get the id from the login form 
            InitializeComponent();
        }

        private void AddBbtn_Click(object sender, EventArgs e)
        {
            AddBbtn.Visible = false;
            SearchCbtn.Visible = false;
            Addcbtn.Visible = false;
            SearchBbtn.Visible = false;
            Addbirdgroupbox.Visible = true;

        }

        private void SpeciescomboBox_SelectedIndexChanged(object sender, EventArgs e)
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
                SubspeciescomboBox.Items.Clear();
                SubspeciescomboBox.Items.Add("Central Australia");
                SubspeciescomboBox.Items.Add("Coastal cities");
            }

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void Addbirdgroupbox_Enter(object sender, EventArgs e)
        {

        }

        private void FinalAddbtn_Click(object sender, EventArgs e)
        {
            Boolean motherSerial = false;
            Boolean fatherSerial = false;
            if (SpeciescomboBox.Text != "" && SubspeciescomboBox.Text != "" && GendercomboBox.Text != "")
            {
                DateTime selectedDate = dateTimePicker1.Value;
                MessageBox.Show("" + selectedDate);
                //open system runtime-app
                Excel.Application application;
                Excel.Workbook workbook;
                Excel.Worksheet worksheet;

                // Start Excel and get Application object.
                application = new Excel.Application();
                application.Visible = false;

                // Open the workbook
                workbook = application.Workbooks.Open(@"C:\Users\Aviv\Desktop\Users1.xlsx");
                worksheet = (Excel.Worksheet)workbook.Sheets[2];

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
                            MessageBox.Show("female");
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
                        MessageBox.Show(Gender2Cell.Value.ToString());
                        if (Gender2Cell.Value.ToString() == "Male")
                        {
                            fatherSerial = true;
                            MessageBox.Show("male");
                            break;
                        }
                    }
                }
                if (selectedDate != null && cagenumber.Text != null)
                {

                    int newRow = lastRow + 1;
                    worksheet.Cells[newRow, 1] = newRow - 1;
                    worksheet.Cells[newRow, 2] = SpeciescomboBox.Text;
                    worksheet.Cells[newRow, 3] = SubspeciescomboBox.Text;
                    worksheet.Cells[newRow, 4] = GendercomboBox.Text;
                    if (motherSerial == true)
                    {
                        worksheet.Cells[newRow, 5] = motherserialnumber.Text;
                    }
                    else
                    {
                        worksheet.Cells[newRow, 5] = null;
                    }
                    if (fatherSerial == true)
                    {
                        worksheet.Cells[newRow, 6] = fatherserialnumber.Text;
                    }
                    else
                    {
                        worksheet.Cells[newRow, 5] = null;
                    }
                    worksheet.Cells[newRow, 7] = selectedDate;
                    worksheet.Cells[newRow, 8] = cagenumber.Text;
                    worksheet.Cells[newRow, 9] = ((LoginForm)Application.OpenForms["LoginForm"]).getid();
                    workbook.Save();
                    MessageBox.Show("Bird was added successfully");

                    SpeciescomboBox.Text = null;
                    SubspeciescomboBox.Text = null;
                    GendercomboBox.Text = null;
                    motherserialnumber.Text = null;
                    fatherserialnumber.Text = null;
                    cagenumber.Text = null;
                    selectedDate = DateTime.Today;
                    // Close the workbook and release the objects
                    workbook.Close();
                    application.Quit();

                    //close system runtime-app
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(application);


                }
                else
                    MessageBox.Show("Bird was added successfully");
            }
            else
                MessageBox.Show("Error, enter all details about the bird");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void motherserialnumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
