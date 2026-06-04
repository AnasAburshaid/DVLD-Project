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
    public partial class frmInternationalLicenseApplication : Form
    {
        int _LicesneID;
        int _InternationalLicenseID;
        int _PersonID;
        clsLicense _License;
        clsInternationalLicense _InternationalLicense;
        clsPerson _Person;
        public frmInternationalLicenseApplication()
        {
            InitializeComponent();
        }
        private void _LoadInternationalLicenseData()
        {
            _License = clsLicense.Find(_LicesneID);
            if( _License != null )
            {
                lblApplicationDate.Text = DateTime.Now.ToShortDateString();
                lblIssueDate.Text = DateTime.Now.ToShortDateString();
                lblLocalLicenseID.Text = _LicesneID.ToString();
                lblExpDate.Text = DateTime.Now.AddYears(1).ToShortDateString();

                clsApplicationTypes AppType = clsApplicationTypes.Find(6);
                lblFees.Text = AppType.ApplicationFees.ToString();

                lblCreatedBy.Text = clsGlobal.CurrentUser.Username.ToString();
            }
        }

        private bool _IsthereActiveInternationlLicense(int Driverid)
        {

            DataTable dt = clsInternationalLicense.GetListInternationalLicenses();

            foreach(DataRow dr in dt.Rows)
            {
                if ((int)dr["DriverID"] == Driverid)
                {
                    return true;
                }
            }
            return false;


        }

        private void ucDriverLicenseInfoFilter1_OnLicenseFind(int obj)
        {        
            _LicesneID = obj;
            _License = clsLicense.Find(_LicesneID);
            if (_License != null)
            {
                if (!_IsthereActiveInternationlLicense(_License.DriverID))
                {
                    _LoadInternationalLicenseData();
                }
                else
                {
                    MessageBox.Show("This person already have an international License ID","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    _InternationalLicense = clsInternationalLicense.FindInternationalLicenseByLocalLicenseID(_LicesneID);
                    if(_InternationalLicense != null)
                    {
                        _InternationalLicenseID = _InternationalLicense.InternationalLicenseID;
                        lblInterApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
                        lblInterLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
                        lblApplicationDate.Text = _InternationalLicense.ApplicationInfo.ApplicationDate.ToString();
                        lblApplicationDate.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
                        lblIssueDate.Text = _InternationalLicense.IssueDate.ToString();
                        lblExpDate.Text = _InternationalLicense.ExpirationDate.ToString();
                        clsApplicationTypes apptype = clsApplicationTypes.Find(_InternationalLicense.ApplicationInfo.ApplicationTypeID);
                        lblFees.Text = apptype.ApplicationFees.ToString();
                        clsUser user = clsUser.Find(_InternationalLicense.CreatedByUserID);
                        lblCreatedBy.Text = user.Username.ToString();
                        LinkShowLicenseInfo.Enabled = true;
                    }
                }
            }

        }

        public bool islegalLicenseToIssue(int personid)
        {
           return clsLicense.isPersonHasClass3License(personid);
        }
        private void frmInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
            if(_InternationalLicense  != null)
            {
                MessageBox.Show("You cant Issue another internatioanl license for License id = [" + _InternationalLicense.IssuedUsingLocalLicenseID + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _License = clsLicense.Find(_LicesneID);
            if (_License != null)
            {
                clsApplication App = clsApplication.Find(_License.ApplicationID);
                if (App != null)
                {
                    _Person = clsPerson.Find(App.ApplicationPersonID);
                    _PersonID = _Person.PersonID;
                    if (!islegalLicenseToIssue(_PersonID))
                    {
                        MessageBox.Show("You Cant Issue international license if you dont have at least class 3 License", "Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (MessageBox.Show("Are you sure you want to Issue an International Driving License for [" + _Person.GetFullName() + "]",
                        "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        _InternationalLicense = new clsInternationalLicense();

                        _InternationalLicense.DriverID = _License.DriverID;
                        _InternationalLicense.IssuedUsingLocalLicenseID = _LicesneID;
                        _InternationalLicense.ApplicationInfo.ApplicationPersonID = _Person.PersonID;
                        _InternationalLicense.ApplicationInfo.ApplicationDate = DateTime.Now;
                        _InternationalLicense.ApplicationInfo.LastStatusDate = DateTime.Now;
                        clsApplicationTypes apptypes = clsApplicationTypes.Find(6);
                        _InternationalLicense.ApplicationInfo.ApplicationTypeID = apptypes.ApplicationTypeID;
                        _InternationalLicense.ApplicationInfo.PaidFees = apptypes.ApplicationFees;

                        if (_InternationalLicense.Save())
                        {
                            MessageBox.Show("International License Issued Successfuly . ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblInterApplicationID.Text = _InternationalLicense.ApplicationID.ToString();

                            _InternationalLicenseID = _InternationalLicense.InternationalLicenseID;
                            lblInterLicenseID.Text = _InternationalLicenseID.ToString();
                            btnSave.Enabled = false;
                            LinkShowLicenseInfo.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("Data Cant be Saved");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("License id not found to issue . ", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
                MessageBox.Show("Find licnese first to show history","not valid",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LinkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(_InternationalLicenseID);
            frm.ShowDialog();
        }
    }
}
