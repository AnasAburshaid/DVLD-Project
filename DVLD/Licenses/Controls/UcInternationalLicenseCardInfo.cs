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
    public partial class UcInternationalLicenseCardInfo : UserControl
    {
        int _InternationalLicenseID;
        int _PersonID;
        clsInternationalLicense _InternationalLicense;
        clsPerson _Person;
        
        public UcInternationalLicenseCardInfo()
        {
            InitializeComponent();
        }

        private void _SetDefaultImage()
        {
            if (!string.IsNullOrEmpty(ppProfilePic.ImageLocation))
                return;


            if (_Person == null)
            {
                ppProfilePic.Image = Properties.Resources.unkown;
                return;
            }

            if (_Person.Gendor == 0)
                ppProfilePic.Image = Properties.Resources.unkown_male;
            else
                ppProfilePic.Image = Properties.Resources.unkown_female;
        }
        public void LoadInternationalData(int internationalLicenseID)
        {
            _InternationalLicenseID = internationalLicenseID;
            _InternationalLicense = clsInternationalLicense.Find(_InternationalLicenseID);
            if( _InternationalLicense != null )
            {
                lblInterLicenseID.Text = _InternationalLicenseID.ToString();
                lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToShortDateString();
                lblIssueDate.Text = _InternationalLicense.IssueDate.ToShortDateString();
                lblLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
                lblIsActive.Text = _InternationalLicense.IsActive ? "yes" : "No";
                lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
                lblDriverID.Text = _InternationalLicense.DriverID.ToString();
                
                clsApplication app = clsApplication.Find(_InternationalLicense.ApplicationID);
                if( app != null )
                {
                    _PersonID = app.ApplicationPersonID;
                    _Person = clsPerson.Find(_PersonID);
                    if (_Person != null)
                    {
                        lblFullName.Text = _Person.GetFullName();
                        lblGendor.Text = _Person.Gendor == 1 ? "female" : "male";
                        lblNationalNO.Text = _Person.NationalNo.ToString();
                        lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
                        if (!string.IsNullOrEmpty(_Person.ImagePath))
                            ppProfilePic.ImageLocation = _Person.ImagePath;
                        else
                            _SetDefaultImage();
                    }
                }

            }
        }

       
    }
}
