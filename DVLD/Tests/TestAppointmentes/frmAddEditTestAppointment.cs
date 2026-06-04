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
    public partial class frmAddEditTestAppointment : Form
    {
        int _LocalAppID;
        clsLocalLicenseApplications _LocalApp;

        int _TestAppointmentID;
        clsTestAppointments _TestAppointment;

        int _TestTypeID;
        clsTestTypes _TestTypes;

        int _RetakeTestApplicationID;
        clsApplication _RetakeTestApplicaion;

        clsApplicationTypes _AppTypes;
        enum enMode { Add = 0, Update = 1 };
        enMode _Mode;

        public frmAddEditTestAppointment(int localAppID, int TestTypeID, int testAppID)
        {
            InitializeComponent();

            _LocalAppID = localAppID;
            _TestTypeID = TestTypeID;
            _TestAppointmentID = testAppID;

            if (_TestAppointmentID != -1)
                _Mode = enMode.Update;
            else
                _Mode = enMode.Add;
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

        public void RetakeTest()
        {
            gbRetakeTes.Enabled = true;
            _AppTypes = clsApplicationTypes.Find(8);

            if (_AppTypes != null)
            {
                lblRetakeFees.Text = _AppTypes.ApplicationFees.ToString();
            }

            double TotalFees = 0;
            _TestTypes = clsTestTypes.Find(_TestTypeID);

            if (_TestTypes != null && _AppTypes != null)
            {
                TotalFees = _TestTypes.TestTypeFees + _AppTypes.ApplicationFees;
            }

            lblTotalFees.Text = TotalFees.ToString();

            if (_Mode == enMode.Update)
            {
                _TestAppointment = clsTestAppointments.Find(_TestAppointmentID);
                if (_TestAppointment != null && _TestAppointment.RetakeTestApplicationID != -1)
                {
                    lblRetakeTestApplication.Text = _TestAppointment.RetakeTestApplicationID.ToString();
                }
                else
                {
                    lblRetakeTestApplication.Text = "Not Generated Yet";
                }
            }
        }

        private void _LoadData()
        {
            if (_Mode == enMode.Add)
            {
                dtTestDate.MinDate = DateTime.Now;
                dtTestDate.MaxDate = DateTime.Now.AddMonths(1);
            }
            else if (_Mode == enMode.Update)
            {
                lblLocalDrivingLicenseID.Text = _LocalAppID.ToString();
                _TestAppointment = clsTestAppointments.Find(_TestAppointmentID);

                if (_TestAppointment != null)
                {
                    dtTestDate.MinDate = new DateTime(1900, 1, 1);
                    dtTestDate.MaxDate = new DateTime(2100, 1, 1);

                    dtTestDate.Value = _TestAppointment.AppointmentDate;

                    if (_TestAppointment.AppointmentDate < DateTime.Now)
                    {
                        dtTestDate.MinDate = _TestAppointment.AppointmentDate;
                    }
                    else
                    {
                        dtTestDate.MinDate = DateTime.Now;
                    }

                    dtTestDate.MaxDate = DateTime.Now.AddMonths(1);
                }
            }

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

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            _PhotoChange();
            _LoadData();

            if (clsTestAppointments.GetNumOfTrails(_LocalAppID, _TestTypeID) > 0)
                RetakeTest();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _LocalApp = clsLocalLicenseApplications.Find(_LocalAppID);
            if (_LocalApp == null) return;

            if (_Mode == enMode.Add && clsTestAppointments.GetNumOfTrails(_LocalAppID, _TestTypeID) > 0)
            {
                _RetakeTestApplicaion = new clsApplication();

                _RetakeTestApplicaion.ApplicationPersonID = _LocalApp.ApplicationInfo.ApplicationPersonID;
                _RetakeTestApplicaion.ApplicationDate = DateTime.Now;

                if (_AppTypes == null) _AppTypes = clsApplicationTypes.Find(8);
                _RetakeTestApplicaion.ApplicationTypeID = _AppTypes.ApplicationTypeID;

                _RetakeTestApplicaion.ApplicationStatus = 3;
                _RetakeTestApplicaion.LastStatusDate = DateTime.Now;
                _RetakeTestApplicaion.PaidFees = _AppTypes.ApplicationFees;
                _RetakeTestApplicaion.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                if (!_RetakeTestApplicaion.Save())
                {
                    MessageBox.Show("There is an error saving the Retake Application.");
                    return;
                }
                lblRetakeTestApplication.Text = _RetakeTestApplicaion.ApplicationID.ToString();
            }

            if (_Mode == enMode.Add)
            {
                _TestAppointment = new clsTestAppointments();
                _TestAppointment.RetakeTestApplicationID = (_RetakeTestApplicaion != null) ? _RetakeTestApplicaion.ApplicationID : -1;
            }
            else
            {
                _TestAppointment = clsTestAppointments.Find(_TestAppointmentID);
            }

            if (_TestAppointment == null) return;

            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalAppID;
            _TestAppointment.AppointmentDate = dtTestDate.Value;
            _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            _TestTypes = clsTestTypes.Find(_TestTypeID);
            if (_TestTypes != null)
            {
                _TestAppointment.PaidFees = _TestTypes.TestTypeFees;
            }

            if (_TestAppointment.Save())
            {
                MessageBox.Show("Appointment Scheduled Successfully", "Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                _TestAppointmentID = _TestAppointment.TestAppointmentID;
                lblLocalDrivingLicenseID.Text = _LocalAppID.ToString();
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Appointment Could Not Be Saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}