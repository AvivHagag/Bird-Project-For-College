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
using LoginPage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private string userName;
        private string password;
        private String id;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Excel.Application application;
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            application = new Excel.Application();
            application.Visible = false;
            // Open the workbook
            workbook = application.Workbooks.Open(@"C:\Users\aviv1\Desktop\Users2.xlsx");
            worksheet = (Excel.Worksheet)workbook.Sheets[1];
             userName = usernameBox.Text;
             password = passwordBox.Text;

            // Get the last row number
            int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            // Check if the username and pass viald
            bool LoginSuccess = false;
            for (int i = 2; i <= lastRow; i++)
            { // Start from 2 to skip the header row

                Excel.Range userCell = worksheet.Cells[i, 1];
                Excel.Range PassCell = worksheet.Cells[i, 2];
                Excel.Range idCell = worksheet.Cells[i, 3];
                if (userCell.Value != null && userCell.Value.ToString() == userName && PassCell.Value != null && PassCell.Value.ToString() == password)
                {
                    LoginSuccess = true;
                    id = idCell.Value.ToString();
                }
            }

            if (!LoginSuccess)
            {
                invalidAuth.Visible = true;
                //MessageBox.Show("שם המשתמש או הסיסמא אינם נכונים, נסה שנית"); }//שם משתמש או סיסמא אינם נכונים
            }
            else
            {
                // התחברת בהצלחה
                this.Hide();
                MessageBox.Show("משתמש התחבר בהצלחה");
                new MainPage().Show();
            }
            // Close the workbook and release the objects
            workbook.Close();
            application.Quit();

            //close system runtime-app
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(application);
            
        }
         // get user name amd password,id from the  login form 
        public String getusername() 
        {
            return userName;
        }
        public String getpassword()
        {
            return password;
        }
        public String getid()
        {
            return id;
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (RegForm formReg = new RegForm())
                formReg.ShowDialog();
            Show();
        }

        private void usernameBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}