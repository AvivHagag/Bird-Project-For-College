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

    public partial class ShowBirdsOrEditCage : Form
    {
        public string cageID;
        public string lengthCage;
        public string heightCage;
        public string widthCage;
        public string materialCage;



        public ShowBirdsOrEditCage()
        {
            InitializeComponent();
        }

        private void showBirdsBtn_Click(object sender, EventArgs e)
        {
            BirdsCage formShow = new BirdsCage();

            formShow.cageID = cageID;
            formShow.Show();
            this.Close();

        }

        private void editCageBtn_Click(object sender, EventArgs e)
        {
            EditCage formEdit = new EditCage();
            formEdit.cageID = cageID;
            formEdit.lengthCage = lengthCage;
            formEdit.heightCage = heightCage;
            formEdit.widthCage = widthCage;
            formEdit.materialCage = materialCage;
            formEdit.Show();
            this.Close();

        }
    }
}
