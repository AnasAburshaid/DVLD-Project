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
    public partial class frmReleaseDetainedLicense : Form
    {
        int _LicesneID;
        int _DetainID;
        int _PersonID;
        int _NewApplicationID;
        int _ApplicationTypeID;
        clsApplicationTypes _ApplicationTypes;
        clsApplication _NewApplicaion;
        clsLicense _License;
        clsDetainedLicenses _DetainedLicense;
        clsPerson _Person;

        enum enMode { enSearchMode = 0,enUpdateMode =1}
        enMode _Mode;

        double TotalFees = 0;
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
            _Mode = enMode.enSearchMode;
        }
        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            _LicesneID = LicenseID;
            _License = clsLicense.Find(_LicesneID);
            if( _License != null )
            {
                _Mode = enMode.enUpdateMode;
                ucDriverLicenseInfoFilter1.DisableFilterBox();
            }
        }

        private void grDetainApplicationInfo_Enter(object sender, EventArgs e)
        {

        }
        public void resetLabels()
        {
            lblCreatedBy.Text = "[???]";
            lblDetainDate.Text = "[???]";
            lblDetainID.Text = "[???]";
            lblLicenseID.Text = "[???]";
            lblAppFees.Text = "[???]";
            lblAppID.Text = "[???]";
            lblFineFees.Text = "[???]";
            lblTotalFees.Text = "[???]";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValidToRelease(clsLicense License)
        {
            bool isvalid = true;
            if (!clsDetainedLicenses.IsLicenseDetained(License.LicenseID))
            {
                MessageBox.Show("This license is not detained", "Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isvalid = false;
            }
            else if (!License.IsActive)
            {
                MessageBox.Show("This Licence is not active", "Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isvalid = false;
            }

            return isvalid;
        }

        private void ucDriverLicenseInfoFilter1_OnLicenseFind(int obj)
        {
            _LicesneID = obj;
            _License = clsLicense.Find(_LicesneID);

            if (_License != null)
            {
                if (!IsValidToRelease(_License))
                {
                    resetLabels();
                    grDetainApplicationInfo.Enabled = false;
                    btnSave.Enabled = false;
                }
                else
                {
                    grDetainApplicationInfo.Enabled = true;
                    btnSave.Enabled = true;
                    lblDetainDate.Text = DateTime.Now.ToShortDateString();
                    lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
                    lblLicenseID.Text = _LicesneID.ToString();
                    _ApplicationTypes = clsApplicationTypes.Find(5);
                    if (_ApplicationTypes != null)
                    {
                        _ApplicationTypeID = _ApplicationTypes.ApplicationTypeID;
                        lblAppFees.Text = _ApplicationTypes.ApplicationFees.ToString();
                    }
                    _DetainedLicense = clsDetainedLicenses.FindDetainedInfoByLicenseID(_LicesneID);
                    if (_DetainedLicense != null)
                    {
                        _DetainID = _DetainedLicense.DetainID;
                        lblFineFees.Text = _DetainedLicense.FineFees.ToString();
                        lblDetainID.Text = _DetainID.ToString();
                    }
                    TotalFees = _ApplicationTypes.ApplicationFees + _DetainedLicense.FineFees;
                    lblTotalFees.Text = TotalFees.ToString();

                }
            }
        }

        private void _loadInUpdateMode()
        {
            if (_License != null)
            {
                ucDriverLicenseInfoFilter1.LoadDataByLicenseID(_LicesneID);

                if (!IsValidToRelease(_License))
                {
                    resetLabels();
                    grDetainApplicationInfo.Enabled = false;
                    btnSave.Enabled = false;
                }
                else
                {
                    grDetainApplicationInfo.Enabled = true;
                    btnSave.Enabled = true;
                    lblDetainDate.Text = DateTime.Now.ToShortDateString();
                    lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
                    lblLicenseID.Text = _LicesneID.ToString();
                    _ApplicationTypes = clsApplicationTypes.Find(5);
                    if (_ApplicationTypes != null)
                    {
                        _ApplicationTypeID = _ApplicationTypes.ApplicationTypeID;
                        lblAppFees.Text = _ApplicationTypes.ApplicationFees.ToString();
                    }
                    _DetainedLicense = clsDetainedLicenses.FindDetainedInfoByLicenseID(_LicesneID);
                    if (_DetainedLicense != null)
                    {
                        _DetainID = _DetainedLicense.DetainID;
                        lblFineFees.Text = _DetainedLicense.FineFees.ToString();
                        lblDetainID.Text = _DetainID.ToString();
                    }
                    TotalFees = _ApplicationTypes.ApplicationFees + _DetainedLicense.FineFees;
                    lblTotalFees.Text = TotalFees.ToString();

                }
            }
        }
       
        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.enUpdateMode)
            {
                ucDriverLicenseInfoFilter1.DisableFilterBox();
                ucDriverLicenseInfoFilter1.LoadDataByLicenseID(_LicesneID);

                if (!IsValidToRelease(_License))
                {
                    resetLabels();
                    grDetainApplicationInfo.Enabled = false;
                    btnSave.Enabled = false;
                }
             
            }
            else
            {
                resetLabels();
                grDetainApplicationInfo.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _License = clsLicense.Find(_LicesneID);
            if (_License != null)
            {
                _LicesneID = _License.LicenseID;
                clsApplication App = clsApplication.Find(_License.ApplicationID);
                if (App != null)
                {
                    _Person = clsPerson.Find(App.ApplicationPersonID);
                    _PersonID = _Person.PersonID;

                    if (MessageBox.Show("Are you sure you want to Release License for [" + _Person.GetFullName() + "] ?",
                      "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _NewApplicaion = new clsApplication();

                        _NewApplicaion.ApplicationPersonID = _PersonID;
                        _NewApplicaion.ApplicationDate = DateTime.Now;
                        _NewApplicaion.ApplicationTypeID = _ApplicationTypeID;
                        _NewApplicaion.ApplicationStatus = 3;
                        _NewApplicaion.LastStatusDate = DateTime.Now;
                        _NewApplicaion.PaidFees = TotalFees;
                        _NewApplicaion.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                        if(!_NewApplicaion.Save())
                        {
                            MessageBox.Show("Error making new application");
                            return;
                        }
                        _NewApplicationID = _NewApplicaion.ApplicationID;

                        _DetainedLicense = clsDetainedLicenses.FindDetainedInfoByLicenseID(_License.LicenseID);
                        if (_DetainedLicense != null)
                        {
                            _DetainedLicense.IsReleased = true;
                            _DetainedLicense.ReleaseDate = DateTime.Now;
                            _DetainedLicense.ReleasedByUserID = clsGlobal.CurrentUser.UserID;
                            _DetainedLicense.ReleaseApplicationID = _NewApplicationID;

                            if(_DetainedLicense.Save())
                            {
                                _DetainID = _DetainedLicense.DetainID;
                                MessageBox.Show("Drving License Released Successfuly", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lblAppID.Text = _NewApplicationID.ToString();
                                btnSave.Enabled = false;
                                LinkShowReleasedLicenseInfo.Enabled = true;
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Cannot Release the license","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
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

        private void LinkShowReleasedLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowDriverLicenseInfo frm = frmShowDriverLicenseInfo.CreateByLicenseID(_LicesneID);
            frm.ShowDialog();
        }
    }
}
