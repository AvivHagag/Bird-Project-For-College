using Microsoft.VisualBasic.ApplicationServices;
using System.DirectoryServices;
using WinFormsApp1;

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
            String name = RegNameVal.Text;
            String password = RegPassVal.Text;
            String Id = RegIdVal.Text;
            MessageBox.Show(name + password + Id);
            if (name.Length < 6 || name.Length > 8) { alert1.Visible = true; alert2.Visible = false; return; }
            int sum = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= '0' && name[i] <= '9')
                    sum++;
            }
            if (sum > 2) { alert1.Visible = true; alert2.Visible = false; return; };
            if (password.Length < 8 || password.Length > 10) { alert1.Visible = false; alert2.Visible = true; ; return; }
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
            if (charSum == 0 || digitSum == 0 || spacielSum == 0) { alert1.Visible = false; alert2.Visible = true; ; return; }
            Hide();
            using (LoginForm form2 = new LoginForm())
                form2.ShowDialog();
            Show();

        }

    }
}