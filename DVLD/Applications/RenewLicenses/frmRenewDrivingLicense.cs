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
    public partial class frmRenewDrivingLicense : Form
    {
        int _LicesneID;
        int _NewLicenseID;
        int _PersonID;
        int _NewApplicationID;
        clsApplication _NewApplication;
        clsLicense _License;
        clsLicense _NewLicese;
        clsPerson _Person;

        double totalfees;

        enum enIssueReasons { New = 1, Renew = 2, replacementForLost = 3, replacementForDamaged = 4 };
        enIssueReasons _IssueReason;
        public frmRenewDrivingLicense()
        {
            InitializeComponent();
        }
        public void resetLabels()
        {
            lblApplicationDate.Text = "[???]";
            lblIssueDate.Text = "[???]";
            lblFees.Text = "[???]";
            txtNotes.Text = ""; 

            lblLicenseFees.Text = "[???]";
            lblLocalLicenseID.Text = "[???]";

            lblExpDate.Text = "[???]";

            lblCreatedBy.Text = "[???]";
            lblTotalFees.Text = "[???]";
            lblRenewApplicationID.Text = "[???]";
            lblRenewApplicationID.Text = "[???]"; ;
        }

        private bool _IsValidToRenew(clsLicense License)
        {

            if (License.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show("This License didnt expired yet You cant Renew .", "Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grApplicationInfo.Enabled = false;
                btnSave.Enabled = false;
                resetLabels();
                return false;
            }
            else if (clsLicense.IsThereActiveRenewDrvingLicense(License.LicenseID))
            {
                MessageBox.Show("There License is renewed before you cant renew it again.", "Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grApplicationInfo.Enabled = false;
                btnSave.Enabled = false;
                resetLabels();
                return false;
            }

            return true;
        }
        private void ucDriverLicenseInfoFilter1_OnLicenseFind(int obj)
        {
            _LicesneID = obj;
            _License = clsLicense.Find(_LicesneID);
            if (_License != null)
            {
               if(!_IsValidToRenew(_License))
                {
                    return;
                }
                else
                {
                    grApplicationInfo.Enabled = true;
                    btnSave.Enabled = true;

                    lblApplicationDate.Text = DateTime.Now.ToShortDateString();
                    lblLocalLicenseID.Text = _LicesneID.ToString();
                    lblIssueDate.Text = DateTime.Now.ToShortDateString();
                    lblExpDate.Text = DateTime.Now.AddYears(10).ToShortDateString();

                    clsApplicationTypes apptypes = clsApplicationTypes.Find(2);
                    lblFees.Text = apptypes.ApplicationFees.ToString();
                    lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
                    clsApplicationTypes apptypes2 = clsApplicationTypes.Find(5);
                    lblLicenseFees.Text = apptypes2.ApplicationFees.ToString();
                    totalfees = apptypes.ApplicationFees + apptypes2.ApplicationFees;
                    lblTotalFees.Text = totalfees.ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _License = clsLicense.Find(_LicesneID);
            if (_License != null)
            {
                clsApplication App = clsApplication.Find(_License.ApplicationID);
                if (App != null)
                {
                    _Person = clsPerson.Find(App.ApplicationPersonID);
                    _PersonID = _Person.PersonID;

                    if (MessageBox.Show("Are you sure you want to Renew License for [" + _Person.GetFullName() + "]",
                      "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        _NewApplication = new clsApplication();

                        _NewApplication.ApplicationPersonID = _PersonID;
                        _NewApplication.ApplicationStatus = 3;
                        _NewApplication.ApplicationTypeID = (int)enIssueReasons.Renew;
                        _NewApplication.ApplicationDate = DateTime.Now;
                        _NewApplication.LastStatusDate = DateTime.Now;
                        clsApplicationTypes app = clsApplicationTypes.Find(_NewApplication.ApplicationTypeID);
                        _NewApplication.PaidFees = app.ApplicationFees;
                        _NewApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                        if(!_NewApplication.Save())
                        {
                            MessageBox.Show("something went wrong Cant make new license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        _NewApplicationID = _NewApplication.ApplicationID;


                        _License.IsActive = false;
                        if (!_License.Save())
                        {
                            MessageBox.Show("something went wrong Cant make new license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        _NewLicese = new clsLicense();

                        _NewLicese.ApplicationID = _NewApplicationID;
                        _NewLicese.DriverID = _License.DriverID;
                        _NewLicese.LicenseClass = _License.LicenseClass;
                        _NewLicese.IssueDate = DateTime.Now;
                        clsLicenseClasses LicenseClass = clsLicenseClasses.Find(_License.LicenseClass);
                        if (LicenseClass != null)
                        {
                            _License.ExpirationDate = _License.IssueDate.AddYears(LicenseClass.DefaultValidityLength);
                        }
                        _License.PaidFees = _NewApplication.PaidFees;

                        if (string.IsNullOrWhiteSpace(txtNotes.Text))
                            _NewLicese.Notes = null;
                        else
                            _NewLicese.Notes = txtNotes.Text;

                        _NewLicese.IsActive= true;
                        _NewLicese.IssueReason = (byte)enIssueReasons.Renew;
                        _NewLicese.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                        _NewLicese.DriverInfo = _License.DriverInfo;
                        if (_NewLicese.Save())
                        {
                            _NewLicenseID = _NewLicese.LicenseID;
                            MessageBox.Show("Drving License Renewd Successfuly, new driving license id : [" + _NewLicenseID + "] .", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblRenewApplicationID.Text = _NewApplicationID.ToString();
                            lblRenewLicenseId.Text = _NewLicenseID.ToString();
                            btnSave.Enabled = false;
                            LinkShowRenwLicenseInfo.Enabled = true;
                            return;
                           
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_License != null)
            {
                frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory(_License.ApplicationID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Find licnese first to show history", "not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LinkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmShowDriverLicenseInfo frm = frmShowDriverLicenseInfo.CreateByLicenseID(_NewLicenseID);
            frm.ShowDialog();
        }
    }
}
        


