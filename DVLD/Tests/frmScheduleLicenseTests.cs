using DVLD_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmScheduleLicenseTests : Form
    {
        private DataView _dtAppointmentsView;

        clsLocalLicenseApplications _LocalLicenseApp;
        int _LocalLicenseAppID;
        int _TestTypeID;

        clsTest _Test;
        int _TestID;
        public frmScheduleLicenseTests(int localLicenseAppID , int testtype)
        {
            InitializeComponent();

            _LocalLicenseAppID = localLicenseAppID;
            _TestTypeID = testtype;
        }

        private void _PhotoChange()
        {

            switch (_TestTypeID)
            {
                case 1:
                    pbTestType.Image = Properties.Resources.VisionTest2;
                    lblTitle.Text = "Vision Test Appointment";
                    break;
                case 2:
                    pbTestType.Image = Properties.Resources.WrittnenTest;
                    lblTitle.Text = "Written Test Appointment";
                    break;
                case 3:
                    pbTestType.Image = Properties.Resources.PracticalTest__2_;
                    lblTitle.Text = "Street Test Appointment";
                    break;
            }
        }

        private bool _IsThereActiveAppointment()
        {
            foreach(DataRowView dv in _dtAppointmentsView)
            {
                if (Convert.ToBoolean(dv["islocked"]) == false)
                {
                    return true;
                }
            }
            return false;
        }
        private bool _IsValidToAdd()
        {
            int TestAppID = -1;
            foreach (DataRowView dv in _dtAppointmentsView)
            {
                if (Convert.ToBoolean(dv["islocked"]) == true)
                {
                    TestAppID = Convert.ToInt32(dv["TestAppointmentID"]);
                    _Test = clsTest.FindTestByTestAppointmentID(TestAppID);

                    if (_Test != null && _Test.TestResult != false)
                        return false;
                }
                
            }
            return true;
        }

        private void _AddAppointmentLoad()
        {
            DataTable dt = clsTestAppointments.GetApplicationTestAppointmentsPerTestType(_LocalLicenseAppID, _TestTypeID);
            _dtAppointmentsView = dt.DefaultView;
            dataGridView1.DataSource = _dtAppointmentsView;
            lblRecordCount.Text = _dtAppointmentsView.Count.ToString();
        }
        private void frmScheduleLicenseTests_Load(object sender, EventArgs e)
        {
            ucLocalLicenceApplicationInfo1.LoadLicenseApplicationInfo(_LocalLicenseAppID);
            _PhotoChange();
            _AddAppointmentLoad();
        }

      
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (!_IsThereActiveAppointment())
            {
                if (_IsValidToAdd())
                {
                    frmAddEditTestAppointment frm = new frmAddEditTestAppointment(_LocalLicenseAppID, _TestTypeID, -1);
                    frm.ShowDialog();
                    _AddAppointmentLoad();
                }
                else
                {
                    MessageBox.Show("this Applicant already passed this test ..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You cant add new appointment while there is an active appointment ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsTestAppointments TestApp = clsTestAppointments.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            if ((TestApp.IsLocked))
            {
                MessageBox.Show("You cant Edit This Appointment, it is LOCKED" , "Locked" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmAddEditTestAppointment frm = new frmAddEditTestAppointment(_LocalLicenseAppID, _TestTypeID, (int)dataGridView1.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                _AddAppointmentLoad();
            }

        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsTestAppointments TestApp = clsTestAppointments.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            if ((TestApp.IsLocked))
            {
                MessageBox.Show("You cant take Test, it is LOCKED", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmTakeTest frm = new frmTakeTest(_LocalLicenseAppID, _TestTypeID, (int)dataGridView1.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                _AddAppointmentLoad();
            }
        }
    }
}
