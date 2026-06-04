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
    public partial class frmTakeTest : Form
    {
        int _LocalAppID;
        clsLocalLicenseApplications _LocalApp;

        int _TestAppointmentID;
        clsTestAppointments _TestAppointment;

        int _TestTypeID;
        clsTestTypes _TestTypes;

        int _TestID;
        clsTest _Test;

        public frmTakeTest(int localAppID, int TestTypeID, int testAppID)
        {
            InitializeComponent();

            _LocalAppID = localAppID;
            _TestTypeID = TestTypeID;
            _TestAppointmentID = testAppID;
        }

        private void _LoadData()
        {
          
            _TestAppointment = clsTestAppointments.Find(_TestAppointmentID);
            lblLocalDrivingLicenseID.Text = _LocalAppID.ToString();

            if (_TestAppointment != null)
                lblTestDate.Text = _TestAppointment.AppointmentDate.ToString();
            
            _LocalApp = clsLocalLicenseApplications.Find(_LocalAppID);
            if (_LocalApp != null)
            {
                clsLicenseClasses Class = clsLicenseClasses.Find(_LocalApp.LicenseClassID);

                if (Class != null)
                    lblLicenseClassType.Text = Class.ClassName;


                lblTrail.Text = clsTestAppointments.GetNumOfTrails(_LocalAppID, _TestTypeID).ToString();

                clsPerson person = clsPerson.Find(_LocalApp.ApplicationInfo.ApplicationPersonID);

                if (person != null)
                    lblName.Text = person.GetFullName();

                _TestTypes = clsTestTypes.Find(_TestTypeID);

                if (_TestTypes != null)
                    lblFees.Text = _TestTypes.TestTypeFees.ToString();
            }

        }
        private void _PhotoChange()
        {

            switch (_TestTypeID)
            {
                case 1:
                    ppTestType.Image = Properties.Resources.VisionTest2;
                    break;
                case 2:
                    ppTestType.Image = Properties.Resources.WrittnenTest;
                    break;
                case 3:
                    ppTestType.Image = Properties.Resources.PracticalTest__2_;
                    break;
            }
        }
        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _PhotoChange();
            _LoadData();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want Save?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _Test = new clsTest();
                _Test.TestAppointmentID = _TestAppointmentID;
                if (rdPass.Checked)
                    _Test.TestResult = true;
                else
                    _Test.TestResult = false;

                if (!string.IsNullOrWhiteSpace(txtNotes.Text))
                    _Test.Notes = txtNotes.Text;
                else
                    _Test.Notes = null;

                _Test.TestAppointmentsInfo = clsTestAppointments.Find(_TestAppointmentID);
                if (_Test.TestAppointmentsInfo != null)
                {
                    _Test.TestAppointmentsInfo.IsLocked = true;
                }

                if (_Test.Save())
                {
                    if (_Test.TestResult == true)
                    {
                        MessageBox.Show("Succeed in the test ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSave.Enabled = false;
                        this.Close();
                    }
                    else if (_Test.TestResult == false)
                    {
                        MessageBox.Show("Failed in the test ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSave.Enabled = false;
                    }

                    _TestID = _Test.TestID;
                    lblTestID.Text = _TestID.ToString();
                    return;
                }
                else
                {
                    MessageBox.Show("Test didnt save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                return;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
