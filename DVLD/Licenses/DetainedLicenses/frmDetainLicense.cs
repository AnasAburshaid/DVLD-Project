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
    public partial class frmDetainLicense : Form
    {
        int _LicesneID;
        int _DetainID;
        int _PersonID;
        clsLicense _License;
        clsDetainedLicenses _DetainedLicense;
        clsPerson _Person;

        public frmDetainLicense()
        {
            InitializeComponent();
        }

        public void resetLabels()
        {
            lblCreatedBy.Text = "[???]";
            lblDetainDate.Text = "[???]";
            lblDetainID.Text = "[???]";
            lblLicenseID.Text = "[???]";
        }
        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            resetLabels();
        }

        public bool IsValidToDetain(clsLicense license)
        {
            bool isvalid = true;
            if (clsDetainedLicenses.IsLicenseDetained(license.LicenseID))
            {
                MessageBox.Show("This License Already Detained", "Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isvalid = false;
            }
            else if (!license.IsActive)
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
                if (!IsValidToDetain(_License))
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
                }
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

                    if (MessageBox.Show("Are you sure you want to Detain License for [" + _Person.GetFullName() + "]",
                      "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        _DetainedLicense = new clsDetainedLicenses();

                        _DetainedLicense.LicenseID = _LicesneID;
                        _DetainedLicense.FineFees = (double)numFineFees.Value;
                        _DetainedLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                        _DetainedLicense.IsReleased = false;

                        if(_DetainedLicense.Save())
                        {

                            _DetainID = _DetainedLicense.DetainID;
                            MessageBox.Show("Drving License Detained Successfuly, Detain ID : [" + _DetainID + "] .", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblDetainID.Text = _DetainID.ToString();
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
            frmShowDriverLicenseInfo frm = frmShowDriverLicenseInfo.CreateByLicenseID(_LicesneID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

