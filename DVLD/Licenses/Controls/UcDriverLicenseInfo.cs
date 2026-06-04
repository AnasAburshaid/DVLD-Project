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
    public partial class UcDriverLicenseInfo : UserControl
    {
        int _LocalAppID;
        int _LicenseID;
        int _PersonID;
        clsPerson _person;
        clsLocalLicenseApplications _LocalApp;
        clsLicense _License;

        enum enIssueReasons { New = 1, Renew = 2, replacementForLost = 3, replacementForDamaged = 4 };
        enIssueReasons _IssueReason;
        public UcDriverLicenseInfo()
        {
            InitializeComponent();
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

        private string _IssueReasonTranslate()
        {
            string IssueReason = "";
            switch(_IssueReason)
            {
                case enIssueReasons.New:
                    IssueReason = "First Time";
                    break;
                case enIssueReasons.replacementForDamaged:
                    IssueReason = "Replacement for damage";
                    break;
                case enIssueReasons.replacementForLost:
                    IssueReason = "Replacement for Lost";
                    break;
                case enIssueReasons.Renew:
                    IssueReason = "Renew";
                    break;
                default:
                    return IssueReason;
            }

            return IssueReason;
        }
        public void LoadDataByLocalAppID(int LocalAppID)
        {
            _LocalAppID = LocalAppID;
                
            _LocalApp = clsLocalLicenseApplications.Find(_LocalAppID);
            if (_LocalApp != null)
            {
                _LicenseID = clsLicense.GetLisenceIDByApplicationID(_LocalApp.ApplicationID);
                _PersonID = _LocalApp.ApplicationInfo.ApplicationPersonID;
                _person = clsPerson.Find(_PersonID);
                if (_person != null)
                {
                    lblFullName.Text = _person.GetFullName();
                    lblNationalNO.Text = _person.NationalNo;

                    if (_person.Gendor == 0)
                        lblGendor.Text = "Male";
                    else
                        lblGendor.Text = "Female";

                    lblDateOfBirth.Text = _person.DateOfBirth.ToShortDateString();

                    if (!string.IsNullOrEmpty(_person.ImagePath))
                        ppProfilePic.ImageLocation = _person.ImagePath;
                    else
                        _SetDefaultImage();

                }

                clsLicenseClasses Class = clsLicenseClasses.Find(_LocalApp.LicenseClassID);
                if (Class != null)
                    lblClassType.Text = Class.ClassName;
            }

            lblLicenseID.Text = _LicenseID.ToString();

            _License = clsLicense.Find(_LicenseID);
            if (_License != null)
            {
                _LicenseID = _License.LicenseID;
                lblIssueDate.Text = _License.IssueDate.ToShortDateString();
                _IssueReason = (enIssueReasons)_License.IssueReason;
                lblIssureReason.Text = _IssueReasonTranslate();
                lblNotes.Text = _License.Notes;

                if (_License.IsActive == true)
                    lblIsActive.Text = "Yes";
                else
                    lblIsActive.Text = "No";
                lblExpirationDate.Text = _License.ExpirationDate.ToShortDateString();
                lblDriverID.Text = _License.DriverID.ToString();

                lblIsDetaind.Text = clsDetainedLicenses.IsLicenseDetained(_LicenseID) ? "Yes" : "No";
            }
            else
                MessageBox.Show("Local Application id not found", "not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LoadDataByLicenseID(int LicenseID)
        {
            _LicenseID = LicenseID;

            _License = clsLicense.Find(_LicenseID);
            if (_License != null)
            {
                lblDriverID.Text = _License.DriverID.ToString();
                lblLicenseID.Text = LicenseID.ToString();
                lblIssueDate.Text= _License.IssueDate.ToShortDateString();
                _IssueReason = (enIssueReasons)_License.IssueReason;
                lblIssureReason.Text = _IssueReasonTranslate();
                if(_License.Notes != null)
                    lblNotes.Text = _License.Notes;

                lblIsActive.Text = (_License.IsActive == true) ? "Yes" : "No";
                lblExpirationDate.Text= _License.ExpirationDate.ToShortDateString();

                clsLicenseClasses ClassType = clsLicenseClasses.Find(_License.LicenseClass);
                if (ClassType != null)
                    lblClassType.Text = ClassType.ClassName;

                clsApplication Application = clsApplication.Find(_License.ApplicationID);
                if (Application != null)
                {
                    _PersonID = Application.ApplicationPersonID;
                    _person = clsPerson.Find(_PersonID);
                    if(_person != null)
                    {
                        lblFullName.Text = _person.GetFullName();
                        lblNationalNO.Text = _person.NationalNo;
                        lblGendor.Text = (_person.Gendor == 1) ? "Female" : "Male";
                        lblDateOfBirth.Text = _person.DateOfBirth.ToShortDateString();

                        if (!string.IsNullOrEmpty(_person.ImagePath))
                            ppProfilePic.ImageLocation = _person.ImagePath;
                        else
                            _SetDefaultImage();
                    }

                }
                lblIsDetaind.Text = clsDetainedLicenses.IsLicenseDetained(_LicenseID) ? "Yes" : "No";
            }
            else
                MessageBox.Show("License id not found","not found",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UcDriverLicenseInfo_Load(object sender, EventArgs e)
        {

        }

        private void LinkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _person = clsPerson.Find(_PersonID);
            if (_person != null)
            {
                frmEditAndUpdatePerson frm = new frmEditAndUpdatePerson(_person.PersonID);
                frm.ShowDialog();
                LoadDataByLicenseID(_LicenseID);
            }

           
        }
    }
}
