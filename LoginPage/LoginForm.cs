using System.Data.OleDb;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Get the values entered in the username and password text boxes
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            // Validate the user's credentials by checking against the Excel database
            if (isValidCredentials(username, password))
            {
                LoginForm mainForm = new LoginForm();
                mainForm.Show();
                this.Hide();
            }
            // If the credentials are invalid, display an error message to the user
            else
            {
                invalidAuth.Visible = true;
            }
        }
        private bool isValidCredentials(string username, string password)
        {
            //// Set the connection string for the Excel database
            //string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Auth.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES;'";

            //// Create a new OleDbConnection object with the connection string
            //OleDbConnection connection = new OleDbConnection(connectionString);

            //// Open the connection
            //connection.Open();

            //// Execute a query to retrieve the username and password from the database
            //string query = $"SELECT * FROM [Users$] WHERE Username='{username}' AND Password='{password}'";
            //OleDbCommand command = new OleDbCommand(query, connection);
            //OleDbDataReader reader = command.ExecuteReader();

            //// If there is a row returned, the username and password are valid
            //bool isValid = reader.HasRows;

            //// Close the reader, command, and connection
            //reader.Close();
            //command.Dispose();
            //connection.Close();

            //return isValid;
            return true;
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
    }
}