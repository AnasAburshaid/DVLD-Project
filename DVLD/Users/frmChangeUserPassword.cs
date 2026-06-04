using DVLD_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmChangeUserPassword : Form
    {
        private ErrorProvider _Error = new ErrorProvider();
        int _UserID;
        clsUser _User;
        public frmChangeUserPassword(int Userid)
        {
            InitializeComponent();
            _UserID = Userid;
            _User = clsUser.Find(_UserID);
        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            ucUserInformationCard1.LoadUserData(_UserID);
        }
        
        private bool _ErrorCheck()
        {
            bool IsValid = true;

            if (txtCurrentPassword.Text != _User.Password)
            {
                _Error.SetError(txtCurrentPassword, "Wrong Password ");
                IsValid = false;
            }
            else
            {
                _Error.SetError(txtCurrentPassword, "");
            }
           

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                _Error.SetError(txtNewPassword, "New Password is Empty");
                IsValid = false;
            }
            else
            {
                _Error.SetError(txtNewPassword, "");

            }

            if (txtConfirmPassword.Text != txtNewPassword.Text)
                {
                    _Error.SetError(txtConfirmPassword, "Wrong Confirm Password ");
                    IsValid = false;
                }
                else
                {
                    _Error.SetError(txtConfirmPassword, "");
                }

            return IsValid;
        }
        

        private void Save_Click(object sender, EventArgs e)
        {
            if(_User == null)
            {
                MessageBox.Show("empty user");
                return;
            }
            if(!_ErrorCheck())
            {
                return;
            }

            if(_User == null)
            {
                MessageBox.Show("User not found ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _User.Password = txtNewPassword.Text;
            if(_User.Save())
            {
                MessageBox.Show("New password changed successfuly . ","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("New password cant be saved . ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
