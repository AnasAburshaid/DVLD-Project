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
    public partial class frmIssureDrvingLicense : Form
    {
        int _LocalAppID;
        int _LicenseID;
        clsLocalLicenseApplications _LocalApp;
        clsLicense _License;


        
        public frmIssureDrvingLicense( int LocalAppid)
        {
            InitializeComponent();
            _LocalAppID = LocalAppid;
        }

        private void frmIssureDrvingLicense_Load(object sender, EventArgs e)
        {
            ucLocalLicenceApplicationInfo1.LoadLicenseApplicationInfo(_LocalAppID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {   
            _License = new clsLicense();

            _LocalApp = clsLocalLicenseApplications.Find(_LocalAppID);
            if (_LocalApp != null)
                _License.ApplicationID = _LocalApp.ApplicationID;

            _License.LicenseClass = _LocalApp.LicenseClassID;
            _License.IssueDate = DateTime.Now;
            clsLicenseClasses LicenseClass = clsLicenseClasses.Find(_LocalApp.LicenseClassID);
            if (LicenseClass != null)
            {
                _License.ExpirationDate = _License.IssueDate.AddYears(LicenseClass.DefaultValidityLength);
                _License.PaidFees = LicenseClass.ClassFees;
            }
            if (string.IsNullOrWhiteSpace(txtNotes.Text))
                _License.Notes = null;
            else
                _License.Notes = txtNotes.Text;

            _License.IsActive = true;
            _License.IssueReason = 1;

            _License.DriverInfo.PersonID = _LocalApp.ApplicationInfo.ApplicationPersonID;
            _License.DriverInfo.CreatedDate = DateTime.Now;

          

            _LocalApp.ApplicationInfo.ApplicationStatus = 3;


            if (MessageBox.Show("Are you sure you want to Issure Drving License for PersonID = [" + _License.DriverInfo.PersonID + "] ?", "Issure Driving License", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (!_License.Save())
                {
                    MessageBox.Show("Something went wrong", "Error");
                    return;
                }
                _LicenseID = _License.LicenseID;

                if (_LocalApp.Save())
                {
                    MessageBox.Show("Drving License Issued Successfuly New License ID = [" + _LicenseID + "] .", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                    return;
                }
                else
                {
                    MessageBox.Show("Something went Wrong You cant do that .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
              
        }
    }
}
