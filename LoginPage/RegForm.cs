using Microsoft.VisualBasic.ApplicationServices;
using System.DirectoryServices;
using WinFormsApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
namespace LoginPage
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userName = RegNameVal.Text;
            String Password = RegPassVal.Text;
            String Id = RegIdVal.Text;
            MessageBox.Show(userName + Password + Id);
            if (CheckReg(userName, Password))
            {
                //open system runtime-app
                Excel.Application application;
                Excel.Workbook workbook;
                Excel.Worksheet worksheet;

                // Start Excel and get Application object.
                application = new Excel.Application();
                application.Visible = false;

                // Open the workbook
                workbook = application.Workbooks.Open(@"C:\Users\aviv1\Desktop\Users.xlsx");
                worksheet = (Excel.Worksheet)workbook.Sheets[1];
                // Get the last row number
                int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
                // Check if the user already exists
                bool userExists = false;

                for (int i = 2; i <= lastRow; i++) {
                    // Start from 2 to skip the header row
                    Excel.Range userCell = worksheet.Cells[i, 1];
                    if (userCell.Value != null && userCell.Value.ToString() == userName) {
                        userExists = true;
                        break;
                    }
                    Excel.Range idCell = worksheet.Cells[i, 3];
                    if (idCell.Value != null && idCell.Value.ToString() == Id) {
                        userExists = true;
                        break;
                    }
                }

                if (!userExists) {
                    int newRow = lastRow + 1;
                    worksheet.Cells[newRow, 1] = userName;
                    worksheet.Cells[newRow, 2] = Password;
                    worksheet.Cells[newRow, 3] = Id;
                    workbook.Save();
                    MessageBox.Show("����� ���� ������");
                    Hide();
                    using (LoginForm form2 = new LoginForm())
                        form2.ShowDialog();
                    Show();
                }
                else {
                    MessageBox.Show("����� ��� ���� ������");
                }

                // Close the workbook and release the objects
                workbook.Close();
                application.Quit();
                //close system runtime-app
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(application);

            }
            
        }

        private void RegNameVal_TextChanged(object sender, EventArgs e)
        {

        }
        private Boolean CheckReg(String name,String password) {
            if (name.Length < 6 || name.Length > 8) { alert1.Visible = true; alert2.Visible = false; return false; }
            int sum = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= '0' && name[i] <= '9')
                    sum++;
            }
            if (sum > 2) { alert1.Visible = true; alert2.Visible = false; return false; };
            if (password.Length < 8 || password.Length > 10) { alert1.Visible = false; alert2.Visible = true; ; return false; }
            int charSum = 0, digitSum = 0, spacielSum = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    digitSum++;
                }
                else if (password[i] >= 'a' && password[i] <= 'z' || password[i] >= 'A' && password[i] <= 'Z')
                {
                    charSum++;
                }
                else
                    spacielSum++;
            }
            if (charSum == 0 || digitSum == 0 || spacielSum == 0) { alert1.Visible = false; alert2.Visible = true; ; return false; }
            return true;
        }
    }
}