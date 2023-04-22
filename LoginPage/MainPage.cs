using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
    }
}
