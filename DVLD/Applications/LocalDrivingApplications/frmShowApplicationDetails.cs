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
    public partial class frmShowApplicationDetails : Form
    {
        int _LocalAppID;
        clsLocalLicenseApplications _LocalApp;

        enum enStatus { New =1,Canceled =2, Completed =3};
        enStatus StatusType;
        private string _GetAppStatus(clsLocalLicenseApplications LocalApp)
        {
            string Status = "";

            if (LocalApp != null)
                StatusType = (enStatus)LocalApp.ApplicationInfo.ApplicationStatus;

            switch(StatusType)
            {
                case enStatus.New:
                    Status = "New";
                    break;
                case enStatus.Canceled:
                    Status = "Canceled";
                    break;
                case enStatus.Completed:
                    Status = "Completed";
                    break;
            }

            return Status;
        }
        public frmShowApplicationDetails(int localAppid)
        {
            InitializeComponent();
            _LocalAppID = localAppid;
        }

      
        private void frmShowApplicationDetails_Load(object sender, EventArgs e)
        {
            _LocalApp = clsLocalLicenseApplications.Find(_LocalAppID);
            if( _LocalApp != null )
            {
                lblLocalAppid.Text = _LocalAppID.ToString();
                lblpassesTests.Text = clsLocalLicenseApplications.GetNumberOfPassedTests(_LocalAppID).ToString();

                clsPerson person = clsPerson.Find(_LocalApp.ApplicationInfo.ApplicationPersonID);
                lblApplicant.Text = person.GetFullName();

                lblApplicationID.Text = _LocalApp.ApplicationInfo.ApplicationID.ToString();
                lblDate.Text = _LocalApp.ApplicationInfo.ApplicationDate.ToShortDateString();
                lblStatusDate.Text = _LocalApp.ApplicationInfo.LastStatusDate.ToShortDateString();
                lblAppStatus.Text = _LocalApp.ApplicationInfo.ApplicationStatus.ToString();
                lblAppStatus.Text = _GetAppStatus(_LocalApp);
                lblFees.Text = _LocalApp.ApplicationInfo.PaidFees.ToString();
                clsApplicationTypes apptypes = clsApplicationTypes.Find(_LocalApp.ApplicationInfo.ApplicationTypeID);
                if( apptypes != null ) 
                     lblType.Text = apptypes.ApplicationTypeTitle.ToString();
                clsUser user = clsUser.Find(_LocalApp.ApplicationInfo.CreatedByUserID);
                if( user != null )
                     lblCreatedBy.Text = user.Username.ToString();

                clsLicenseClasses licenseClass = clsLicenseClasses.Find(_LocalApp.LicenseClassID);
                if( licenseClass != null )
                {
                    lblLicenseClass.Text = licenseClass.ClassName.ToString();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlCardAppInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LinkPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_LocalApp!=null)
            {
                frmPersonCardDetails frm = new frmPersonCardDetails(_LocalApp.ApplicationInfo.ApplicationPersonID);
                frm.ShowDialog();
            }
            
        }
    }
}
