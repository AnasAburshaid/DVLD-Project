using DVLD_;
using DVLD_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class UcPersonCard : UserControl
    {
        private ErrorProvider _Error = new ErrorProvider();
        public event Action<int> OnPersonSaved;

        enum enMode { Update = 0, Add = 1 };
        enMode _Mode;
        clsPerson _Person;
        int _PersonId = -1;

        public UcPersonCard()
        {
            InitializeComponent();

            DateOfBirthValidation();

        }
        private void _LoadAllCountriesInComboBox()
        {
            DataTable dt = clsCountry.GetListCountries();

            foreach (DataRow dr in dt.Rows)
            {
                cmbCountries.Items.Add(dr["CountryName"].ToString());
            }
        }

        public void LoadDataInAddMode()
        {
            _Mode = enMode.Add;

            _PersonId = -1;
            _Person = new clsPerson();
            ClearFields();
        }

        private void _SetDefaultImage()
        {
            if (!string.IsNullOrEmpty(ppProfilePic.ImageLocation))
                return;

            if (rdMale.Checked)
                ppProfilePic.Image = Properties.Resources.unkown_male;
            else
                ppProfilePic.Image = Properties.Resources.unkown_female;

        }
        
        private bool IsEmailValid()
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
                return true;
            
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }
        private bool IsPhoneValid()
        {
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(phone))
            {
                return false;
            }

           
            string pattern = @"^\+?[0-9]{8,15}$";

            return System.Text.RegularExpressions.Regex.IsMatch(phone, pattern);
        }
        private bool ErrorCheck()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtFirstname.Text))
            {
                _Error.SetError(txtFirstname, "First name is requeird.");
                isValid = false;
            }
            else
                _Error.SetError(txtFirstname, "");

            if (!IsEmailValid())
            {
                _Error.SetError(txtEmail, "Wrong format ex: someone@example.com");
                isValid = false;
            }
            else
                _Error.SetError(txtEmail, "");

            if (string.IsNullOrWhiteSpace(txtSecondName.Text))
            {
                _Error.SetError(txtSecondName, "Second name is requeird.");
                isValid = false;
            }
            else
                _Error.SetError(txtSecondName, "");

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                _Error.SetError(txtAddress, "Address is requeird.");
                isValid = false;
            }
            else
                _Error.SetError(txtAddress, "");

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                _Error.SetError(txtLastName, "Last name is requeird.");
                isValid = false;
            }
            else
                _Error.SetError(txtLastName, "");

            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
            {
                _Error.SetError(txtNationalNo, "National number is requeird.");
                isValid = false;
            }
            else if (_Mode==enMode.Add && clsPerson.IsPersonExist(txtNationalNo.Text))
            {
                _Error.SetError(txtNationalNo, "National number already exists .");
                isValid = false;
            }
            else
                _Error.SetError(txtNationalNo, "");



            if (string.IsNullOrWhiteSpace(DateTimePicker.Value.ToString()))
            {
                _Error.SetError(DateTimePicker, "DateOfBirth is requeird.");
                isValid = false;
            }
            else
                _Error.SetError(DateTimePicker, "");

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                _Error.SetError(txtPhone, "Phone number is requeird.");
                isValid = false;
            }
            else if(!IsPhoneValid())
            {
                _Error.SetError(txtPhone, "Wrong Phone format.");
                isValid = false;
            }
            else
                _Error.SetError(txtPhone, "");

            return isValid;

        }
        public void LoadDataInUpdateMode(int personid)
        {
            _LoadAllCountriesInComboBox();
            _Mode = enMode.Update;
            _PersonId = personid;
            _Person = clsPerson.Find(_PersonId);
            if(_Person ==  null)
            {
                MessageBox.Show("Person not found", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            lblPersonId.Text = _Person.PersonID.ToString();
            txtFirstname.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            txtNationalNo.ReadOnly = true;
            DateTimePicker.Value = _Person.DateOfBirth;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;

            if (_Person.Gendor == 0)
                rdMale.Checked = true;
            else
                rdFemale.Checked = true;

            clsCountry country = clsCountry.Find(_Person.NationalityCountryID);
            cmbCountries.SelectedIndex = cmbCountries.FindString(country.CountryName);

            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {
                ppProfilePic.ImageLocation = _Person.ImagePath;
                LinkRemoveImage.Visible = true;
            }
            else
            {
                ppProfilePic.ImageLocation = null; 
                LinkRemoveImage.Visible = false;
                _SetDefaultImage();
            }

        }
        public void DateOfBirthValidation()
        {
            DateTimePicker.Value = DateTimePicker.MaxDate;
            DateTimePicker.MaxDate = DateTime.Now.AddYears(-18);
            DateTimePicker.MinDate = DateTime.Now.AddYears(-90);
        }
        public void ClearFields()
        {
            _LoadAllCountriesInComboBox();

            txtFirstname.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            DateTimePicker.Value = DateTimePicker.MaxDate;
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            cmbCountries.SelectedIndex = 89;
            rdMale.Checked = true;
            _SetDefaultImage();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ErrorCheck())
                 return; 

            _Person.FirstName = txtFirstname.Text;
            _Person.SecondName = txtSecondName.Text;

            if (string.IsNullOrWhiteSpace(txtThirdName.Text))
                _Person.ThirdName = "";
            else
                _Person.ThirdName = txtThirdName.Text;

            _Person.LastName = txtLastName.Text;
            _Person.Address = txtAddress.Text;
            _Person.DateOfBirth = DateTimePicker.Value;
            _Person.NationalNo = txtNationalNo.Text;

            int NationalityCountryID = clsCountry.Find(cmbCountries.Text).CountryID;
            _Person.NationalityCountryID = NationalityCountryID;

            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
            _Person.Gendor = rdMale.Checked ? 0 : 1;

            if (ppProfilePic.ImageLocation != null)
                _Person.ImagePath = ppProfilePic.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                if (_Mode == enMode.Update)
                {
                    _Mode = enMode.Update;
                    MessageBox.Show("Person Updated Successfuly ", "Updating Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _Mode = enMode.Update;
                    MessageBox.Show("Person Added Successfuly ", "Adding Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblPersonId.Text = _Person.PersonID.ToString();
                }
                OnPersonSaved?.Invoke(_Person.PersonID);
            }
            else
            {
                MessageBox.Show("Data Cant Be Saved .. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LinkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = ("FileData |*.jpg;*.jpeg;*.png");
            openFileDialog1.FilterIndex = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ppProfilePic.ImageLocation = openFileDialog1.FileName;
                LinkRemoveImage.Visible = true;
            }
        }

        private void LinkRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ppProfilePic.ImageLocation = null;
            _Person.ImagePath = "";
            LinkRemoveImage.Visible = false;
            _SetDefaultImage();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            _SetDefaultImage();
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            _SetDefaultImage();
        }

        
    }
}
