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
    public partial class frmReplacementDrivingLicense : Form
    {
        int _LicesneID;
        int _NewRepLicenseID;
        int _PersonID;
        int _NewApplicationID;
        int _ApplicationTypeid;
        clsApplication _NewApplication;
        clsLicense _License;
        clsLicense _NewRepLicense;
        clsPerson _Person;
        clsApplicationTypes _apptypes;

      

        enum enIssueReasons { New = 1, Renew = 2, replacementForLost = 3, replacementForDamaged = 4 };
        enIssueReasons _IssueReason;
        public frmReplacementDrivingLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReplacementDrivingLicense_Load(object sender, EventArgs e)
        {
            rdDamagedLicense.Checked = true;
            grReplacementReason.Enabled = false;
            resetLabels();


        }
        public void resetLabels()
        {
            lblApplicationDate.Text = "[???]";
            lblApplicationFees.Text = "[???]";
            lblCreatedBy.Text = "[???]";
            lblRepApplicationID.Text = "[???]";
            lblReplacementLicenseID.Text = "[???]";
            lblCreatedBy.Text = "[???]";
        }
        private void ucDriverLicenseInfoFilter1_OnLicenseFind(int obj)
        {
            _LicesneID = obj;
            _License = clsLicense.Find(_LicesneID);
            if (_License != null)
            {
                
                if(_License.IsActive == false)
                {
                    MessageBox.Show("You cant replace not active license","Not Active",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    grApplicationRepInfo.Enabled = false;
                    grReplacementReason.Enabled = false;
                    btnSave.Enabled = false;
                    resetLabels();
                    return;
                }
                else
                {
                    grApplicationRepInfo.Enabled = true;
                    grReplacementReason.Enabled = true;
                    btnSave.Enabled = true;

                    lblApplicationDate.Text = DateTime.Now.ToShortDateString();
                    lblCreatedBy.Text = clsGlobal.CurrentUser.Username;

                    if (_apptypes != null)
                    {
                        _ApplicationTypeid = _apptypes.ApplicationTypeID;
                        lblApplicationFees.Text = _apptypes.ApplicationFees.ToString();
                    }

                    lblOldLIcenseID.Text = _License.LicenseID.ToString();
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

                    if (MessageBox.Show("Are you sure you want to Replace the License for [" + _Person.GetFullName() + "]",
                      "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        _NewApplication = new clsApplication();

                        _NewApplication.ApplicationPersonID = _PersonID;
                        _NewApplication.ApplicationStatus = 3;
                        _NewApplication.ApplicationTypeID = _apptypes.ApplicationTypeID;
                        _NewApplication.ApplicationDate = DateTime.Now;
                        _NewApplication.LastStatusDate = DateTime.Now;
                        _NewApplication.PaidFees = _apptypes.ApplicationFees;
                        _NewApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                        if (!_NewApplication.Save())
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

                        _NewRepLicense = new clsLicense();

                       _NewRepLicense.ApplicationID = _NewApplicationID;
                       _NewRepLicense.DriverID = _License.DriverID;
                       _NewRepLicense.LicenseClass = _License.LicenseClass;
                       _NewRepLicense.IssueDate = DateTime.Now;
                        clsLicenseClasses LicenseClass = clsLicenseClasses.Find(_License.LicenseClass);
                        if (LicenseClass != null)
                        {
                            _NewRepLicense.ExpirationDate = _NewRepLicense.IssueDate.AddYears(LicenseClass.DefaultValidityLength);
                        }
                        _NewRepLicense.PaidFees = _NewApplication.PaidFees;
                        _NewRepLicense.Notes = _License.Notes;


                        _NewRepLicense.IsActive = true;
                        _NewRepLicense.IssueReason = (byte)_apptypes.ApplicationTypeID;
                        _NewRepLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                        _NewRepLicense.DriverInfo = _License.DriverInfo;
                        if (_NewRepLicense.Save())
                        {
                            _NewRepLicenseID = _NewRepLicense.LicenseID;
                            MessageBox.Show("Drving License Replaced Successfuly, new driving license id : [" + _NewRepLicenseID + "] .", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblRepApplicationID.Text = _NewApplicationID.ToString();
                            lblReplacementLicenseID.Text = _NewRepLicenseID.ToString();
                            btnSave.Enabled = false;
                            LinkShowRenwLicenseInfo.Enabled = true;
                            return;

                        }
                    }
                }
            }
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

        private void LinkShowRenwLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowDriverLicenseInfo frm = frmShowDriverLicenseInfo.CreateByLicenseID(_NewRepLicenseID);
            frm.ShowDialog();
        }

        private void rdDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            _apptypes = clsApplicationTypes.Find(4);
            if (_apptypes != null)
            {
                lblApplicationFees.Text = _apptypes.ApplicationFees.ToString();
            }
        }

        private void rdLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            _apptypes = clsApplicationTypes.Find(3);
            if (_apptypes != null)
            {
                lblApplicationFees.Text = _apptypes.ApplicationFees.ToString();
            }

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
