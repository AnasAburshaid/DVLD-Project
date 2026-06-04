using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BLL;
namespace DVLD
{
    public partial class frmMainScreen : Form
    {
        int _Userid;
        clsUser _User;
        public frmMainScreen( int userid)
        {
            InitializeComponent();
            _Userid = userid;
            _User = clsUser.Find(_Userid);
            
        }

        private void PeopleMenu_Click(object sender, EventArgs e)
        {
            frmPeopleMenuScreen PeopleScreen = new frmPeopleMenuScreen();
            PeopleScreen.ShowDialog();
        }

        private void UsersMenu_Click(object sender, EventArgs e)
        {
            frmUsersMenueScreen UserScreen = new frmUsersMenueScreen();
            UserScreen.ShowDialog();
        }

        private bool _CheckUserExists()
        {
            if (_User != null)
                return true;
            else
                return false;
        }
        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(!_CheckUserExists())
            {
                MessageBox.Show("User Not Found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
           frmUserDetails frm = new frmUserDetails(_Userid);
           frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckUserExists())
            {
                MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmChangeUserPassword frm = new frmChangeUserPassword(_Userid);
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogInScreen LogInScreen = new frmLogInScreen();
            LogInScreen.ShowDialog();
            this.Close();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditLocalLicenseApplication frm = new frmAddEditLocalLicenseApplication(-1);
            frm.ShowDialog();
            
        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalLicenseApplications frm = new frmManageLocalLicenseApplications();
            frm.ShowDialog();
        }

        private void DriversMenu_Click(object sender, EventArgs e)
        {
            frmDriversMenuScreen frm = new frmDriversMenuScreen();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseApplication frm = new frmInternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void internationalDrivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInternationalLicenseApplications frm = new frmManageInternationalLicenseApplications();
            frm.ShowDialog();

        }

        private void renewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewDrivingLicense frm = new frmRenewDrivingLicense(); 
            frm.ShowDialog();
        }

        private void replacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplacementDrivingLicense frm = new frmReplacementDrivingLicense();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalLicenseApplications frm = new frmManageLocalLicenseApplications();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void releaseDetainedLicneseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void manageDetainedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetainedLicenses frm = new frmManageDetainedLicenses();
            frm.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }
    }
}
