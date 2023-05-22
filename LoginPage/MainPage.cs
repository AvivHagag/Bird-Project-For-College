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
            this.Hide();
            using (Addbird addbird = new Addbird())
                addbird.ShowDialog();
            Show();
        }

        private void Addcbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Addcage addcage = new Addcage())
                addcage.ShowDialog();
            Show();
        }


        private void SearchBbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Searchbird searchbird = new Searchbird())
                searchbird.ShowDialog();
            Show();
        }
        private void SearchCbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (SearchCage searchcage = new SearchCage())
                searchcage.ShowDialog();
            Show();
        }


       
        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       
    }
}
