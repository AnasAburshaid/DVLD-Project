using DVLD_BLL;
using System;
using System.IO; // <--- YOU MUST ADD THIS to use files!
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLogInScreen : Form
    {
        clsUser _User;

        // Let's define the file name we want to use. 
        // This will save directly into your bin/Debug folder!
        private string _CredentialsFilePath = "LoginData.txt";

        public frmLogInScreen()
        {
            InitializeComponent();

         
            if (File.Exists(_CredentialsFilePath))
            {
                string[] lines = File.ReadAllLines(_CredentialsFilePath);
                if (lines.Length == 2)
                {
                    txtUsername.Text = lines[0];
                    txtPassword.Text = lines[1];
                    chkRememberMe.Checked = true;
                }
            }
        }
        private void frmLogInScreen_Load(object sender, EventArgs e)
        {
            // 1. When the form opens, try to load the saved data
            if (File.Exists(_CredentialsFilePath))
            {
                // Read all lines from the text file into an array
                string[] lines = File.ReadAllLines(_CredentialsFilePath);

                // Make sure we actually have 2 lines (username and password)
                if (lines.Length == 2)
                {
                    txtUsername.Text = lines[0];
                    txtPassword.Text = lines[1];
                    chkRememberMe.Checked = true; // Check the box automatically
                }
            }
        }

        private bool Login()
        {
            // (I added your clean logic update from the previous step here!)
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            _User = clsUser.findUsernameAndPassword(username, password);

            if (_User == null)
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_User.IsActive == false)
            {
                MessageBox.Show("You can't login, you have no access", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // 2. A new helper method to handle the text file
        private void _HandleRememberMe()
        {
            if (chkRememberMe.Checked)
            {
                string[] lines = { txtUsername.Text, txtPassword.Text };
                File.WriteAllLines(_CredentialsFilePath, lines);
            }
            else
            {
                if (File.Exists(_CredentialsFilePath))
                {
                    File.Delete(_CredentialsFilePath);
                }
            }
        }

        public int GetUserID
        {
            get { return _User.UserID; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                _HandleRememberMe();

                this.Hide();
                clsGlobal.CurrentUser = this._User;
                frmMainScreen main = new frmMainScreen(_User.UserID);
                main.ShowDialog();
                this.Close();
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnPassword.BackgroundImage = Properties.Resources.eye;
                return;
            }

            if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                btnPassword.BackgroundImage = Properties.Resources.Line_eye;
                return;
            }
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            // Leave empty, we only care about its status when they click Login!
        }
    }
}