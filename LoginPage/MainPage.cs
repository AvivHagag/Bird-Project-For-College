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
            
            new Addbird().Show();
            this.Close();
        }

        private void Addcbtn_Click(object sender, EventArgs e)
        {
            
            new Addcage().Show();
            this.Close();


        }


        private void SearchBbtn_Click(object sender, EventArgs e)
        {
            
            new Searchbird().Show();
            this.Close();


        }
        private void SearchCbtn_Click(object sender, EventArgs e)
        {
            
            new SearchCage().Show();
            this.Close();


        }



        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       
    }
}
