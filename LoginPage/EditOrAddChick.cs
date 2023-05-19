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

    public partial class EditOrAddChick : Form
    {
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

        public EditOrAddChick()
        {
            InitializeComponent();
        }

        private void editBirdChoiceBtn_Click(object sender, EventArgs e)
        {
            EditBird formEdit = new EditBird();
            // Set the data for the new form.

            formEdit.birdID = birdID;
            formEdit.species = species;
            formEdit.subSpecies = subSpecies;
            formEdit.cageID = cageID;
            formEdit.gender = gender;
            formEdit.headcolor = headcolor;
            formEdit.chestcolor = chestcolor;
            formEdit.bodycolor = bodycolor;
            // Show the new form.
            this.Hide();
            formEdit.Show();

        }

        private void addChickChoiceBtn_Click(object sender, EventArgs e)
        {

            Addchick formAddChick = new Addchick();
            // Set the data for the new form.
            if (gender == "Male")
            {
                formAddChick.reciveFromFather = true;
                formAddChick.reciveFromMothrer = false;
                formAddChick.motherChickBox.Visible = true;
                formAddChick.fatherChickBox.Visible = false;
                formAddChick.motherIdLabel.Visible = true;
                formAddChick.FatherIdLabel.Visible = false;

            }
            else
            {
                formAddChick.reciveFromFather = false;
                formAddChick.reciveFromMothrer = true;
                formAddChick.motherChickBox.Visible = false;
                formAddChick.motherIdLabel.Visible = false;
                formAddChick.FatherIdLabel.Visible = true;
                formAddChick.fatherChickBox.Visible = true;
            }
            formAddChick.birdID = birdID;
            formAddChick.species = species;
            formAddChick.subSpecies = subSpecies;
            formAddChick.cageID = cageID;
            formAddChick.gender = gender;
            formAddChick.headcolor = headcolor;
            formAddChick.chestcolor = chestcolor;
            formAddChick.bodycolor = bodycolor;
            // Show the new form.
            this.Hide();
            formAddChick.Show();
        }
    }
}
