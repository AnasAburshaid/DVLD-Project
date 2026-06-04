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
    public partial class UcLocalLicenceApplicationInfo : UserControl
    {
        clsLocalLicenseApplications _LocalApplication;
        clsPerson _Applicant;
        int _ApplicantID;
        int _LocalApplicationID;
        public UcLocalLicenceApplicationInfo()
        {
            InitializeComponent();
        }

        private void _ApplicationStatus()
        {
            if (_LocalApplication.ApplicationInfo.ApplicationStatus == 1)
                lblStatus.Text = "New";
            else if (_LocalApplication.ApplicationInfo.ApplicationStatus == 2)
                lblStatus.Text = "Cancelled";
            else
                lblStatus.Text = "Completed";
        }

        public void LoadLicenseApplicationInfo( int LocalApplicationID)
        {
            _LocalApplicationID = LocalApplicationID;
            _LocalApplication = clsLocalLicenseApplications.Find(_LocalApplicationID);
            if (_LocalApplication == null)
                return;

            lblLocalAppID.Text = _LocalApplicationID.ToString();
            clsLicenseClasses _ClassTypes = clsLicenseClasses.Find(_LocalApplication.LicenseClassID);
            if (_ClassTypes != null)
                lblLicenseClassType.Text = _ClassTypes.ClassName;
            else
                lblLicenseClassType.Text = "Not Found Error";

            lblPassedTests.Text = clsLocalLicenseApplications.GetNumberOfPassedTests(_LocalApplicationID).ToString();

            lblApplicationID.Text = _LocalApplication.ApplicationID.ToString();
            _ApplicationStatus();
            lblApplicationFees.Text = _LocalApplication.ApplicationInfo.PaidFees.ToString();
            lblDate.Text = _LocalApplication.ApplicationInfo.ApplicationDate.ToString();
            lblStatusDate.Text = _LocalApplication.ApplicationInfo.LastStatusDate.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;

            _ApplicantID = _LocalApplication.ApplicationInfo.ApplicationPersonID;
            _Applicant = clsPerson.Find(_ApplicantID);
            if (_Applicant != null)
                lblAppliciant.Text = _Applicant.GetFullName();
            else
                lblAppliciant.Text = "Not found error";

            clsApplicationTypes AppType = clsApplicationTypes.Find(_LocalApplication.ApplicationInfo.ApplicationTypeID);
            if (AppType != null)
                lblApplicationType.Text = AppType.ApplicationTypeTitle.ToString();
            else
                lblApplicationType.Text = "Not found error";
         
        }

      

        private void pnlSec2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LinkPersonInfo_LinkClicked(object sender, EventArgs e)
        {
            if (_Applicant != null)
            {
                frmPersonCardDetails frm = new frmPersonCardDetails(_ApplicantID);
                frm.ShowDialog();
            }
        }
    }
}
