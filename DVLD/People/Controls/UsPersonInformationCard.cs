using DVLD_;
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
    
    public partial class UsPersonInformationCard : UserControl
    {
        int _personid;
        string _NationalNo;
        clsPerson _person;

        public UsPersonInformationCard()
        {
            InitializeComponent();
          
        }

        public int PersonID
        {
            get { return _personid; }
        }
        private void _SetDefaultImage()
        {
            if (!string.IsNullOrEmpty(ppProfilePic.ImageLocation))
                return;

            
            if (_person == null)
            {
                ppProfilePic.Image = Properties.Resources.unkown;
                return;
            }

            if (_person.Gendor == 0)
                ppProfilePic.Image = Properties.Resources.unkown_male;
            else
                ppProfilePic.Image = Properties.Resources.unkown_female;
        }

        public void LoadData(int personid)
        {
            _personid = personid;
            _person = clsPerson.Find(_personid);
            if (_person == null)
            {
                MessageBox.Show("Person ID doesnt Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblPersonId.Text = _person.PersonID.ToString();

            lblAddress.Text = _person.Address;
            lblFullName.Text = _person.GetFullName();

            if(_person.Email != null)
                lblEmail.Text = _person.Email;

            clsCountry country = clsCountry.Find(_person.NationalityCountryID);
            lblCountry.Text = country.CountryName;

            if (_person.Gendor == 0)
                lblGendor.Text = "Male";
            else
                lblGendor.Text = "Female";

            lblNationalNo.Text = _person.NationalNo;
            lblPhone.Text = _person.Phone;
            lblDateOfBirth.Text = _person.DateOfBirth.ToShortDateString();


            if (!string.IsNullOrEmpty(_person.ImagePath))
                ppProfilePic.ImageLocation = _person.ImagePath;
            else
                _SetDefaultImage();

        }
        public void LoadData(string NationalNo)
        {
            _NationalNo = NationalNo;
            _person = clsPerson.Find(_NationalNo);

            if (_person == null)
            {
                MessageBox.Show("National Number doesnt Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _personid = _person.PersonID;
            lblPersonId.Text = _person.PersonID.ToString();

            lblAddress.Text = _person.Address;
                lblFullName.Text = _person.GetFullName();

            if (_person.Email != null)
                lblEmail.Text = _person.Email;

            clsCountry country = clsCountry.Find(_person.NationalityCountryID);
            lblCountry.Text = country.CountryName;

            if (_person.Gendor == 0)
                lblGendor.Text = "Male";
            else
                lblGendor.Text = "Female";

            lblNationalNo.Text = _person.NationalNo;
            lblPhone.Text = _person.Phone;
            lblDateOfBirth.Text = _person.DateOfBirth.ToShortDateString();


            if (!string.IsNullOrEmpty(_person.ImagePath))
                ppProfilePic.ImageLocation = _person.ImagePath;
            else
                _SetDefaultImage();

        }
        

        private void LinkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_person != null)
            {
                frmEditAndUpdatePerson frmEditUpdateCard = new frmEditAndUpdatePerson(_personid);
                frmEditUpdateCard.ShowDialog();
                LoadData(_personid);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void UsPersonInformationCard_Load(object sender, EventArgs e)
        {
            _SetDefaultImage();
        }
    }
    }

