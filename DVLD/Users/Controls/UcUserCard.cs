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
    public partial class UcUserCard : UserControl
    {
        int _Personid;
        int _Userid;
        clsUser _User;
        enum enMode { Update = 0, Add = 1 };
        enMode _Mode;
        private ErrorProvider _Error = new ErrorProvider();
        public UcUserCard()
        {
            InitializeComponent();

            usPersonCardFilter1.OnPersonSelected += PersonFind;
        }

        public void LoadDataInAddMode()
        {
            _Mode = enMode.Add;
            _Userid = -1;
            _User = new clsUser();

            ClearFields();
        }

        public void LoadDataInUpdateMode(int userid)
        {
            _Mode = enMode.Update;
            _Userid = userid;
            _User = clsUser.Find(userid);

            if (_User == null)
            {
                MessageBox.Show("User not found ..", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnNext.Enabled = true;
            _Personid = _User.PersonID;

            usPersonCardFilter1.LoadDataInUpdateMode(_Personid);

            txtUsername.Text = _User.Username;
            txtpassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;

            chkIsActive.Checked = _User.IsActive;
            lblUserID.Text = _User.UserID.ToString();
        }

        public void ClearFields()
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = false;
        }
        private void UsAddNewUserCard_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.Add)
                TabLogInInfo.Enabled = false;
            else
                TabLogInInfo.Enabled = true;
        }

        private bool _IsPersonAlreadyAUser(int personid)
        {
            DataTable dt = clsUser.GetListUsers();
            foreach (DataRow dr in dt.Rows)
            {
                if ((int)dr["personid"] == personid)
                {
                    return true;
                }
            }
            return false;

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Add)
            {
                if (_IsPersonAlreadyAUser(_Personid))
                {
                    MessageBox.Show("Person with id = [" + _Personid + "] is alredy a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            TabLogInInfo.Enabled = true;
            tabControl1.SelectedTab = TabLogInInfo;
        }
        private void PersonFind(int personid)
        {
            _Personid = personid;
            btnNext.Enabled = true;
        }
        private bool _ErrorCheck()
        {
            bool isValid = true; ;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                _Error.SetError(txtUsername, "Invalid Username");
                isValid = false;
            }
            else
            {
                _Error.SetError(txtUsername, "");
            }

            if (string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                _Error.SetError(txtpassword, "Invalid Password");
                isValid = false;
            }
            else
            {
                _Error.SetError(txtpassword, "");
            }

            if (txtConfirmPassword.Text != txtpassword.Text)
            {
                _Error.SetError(txtConfirmPassword, "Confirm Password is wrong .. ");
                isValid = false;
            }
            else
                _Error.SetError(txtConfirmPassword, "");

            return isValid;
        }

        public void ShowNewUerID(int NewUserId)
        {
            lblUserID.Text = NewUserId.ToString();
        }
        public clsUser LoginInput()
        {
            if (!_ErrorCheck())
                return null;

            _User = new clsUser();
            _User.Username = txtUsername.Text;
            _User.Password = txtpassword.Text;
            if (chkIsActive.Checked == true)
                _User.IsActive = true;
            else
                _User.IsActive = false;
            _User.PersonID = _Personid;



            return _User;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        public void DisableSearchFilter()
        {
            usPersonCardFilter1.DisableSearchFilter();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ErrorCheck())
                return;

            _User.Username = txtUsername.Text;
            _User.Password = txtpassword.Text;
            if (chkIsActive.Checked == true)
                _User.IsActive = true;
            else
                _User.IsActive = false;
            _User.PersonID = _Personid;

            if (_User.Save())
            {
                if (_Mode == enMode.Update)
                {
                    _Mode = enMode.Update;
                    MessageBox.Show("User Updated Successfuly ", "Updating User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _Mode = enMode.Update;
                    MessageBox.Show("User Added Successfuly ", "Adding User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblUserID.Text = _User.UserID.ToString();
                }
            }
            else
            {
                MessageBox.Show("Data Cant Be Saved .. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void usPersonCardFilter1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                parentForm.Close();
            }
        }
    }
}
