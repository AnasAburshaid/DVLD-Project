using DVLD_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD
{
    public partial class frmManageLocalLicenseApplications : Form
    {
        private DataView _dtLocalApplicationView;
        clsLocalLicenseApplications _LocalLicenseApp;
        int _localLicenseAppID;

        public frmManageLocalLicenseApplications()
        {
            InitializeComponent();
        }

        private void _LoadLocalLicenceApplications()
        {
            DataTable dt = clsLocalLicenseApplications.GetListLocalLicenseApplication();
            _dtLocalApplicationView = dt.DefaultView;
            dataGridView1.DataSource = _dtLocalApplicationView;
            lblRecrodsCount.Text = _dtLocalApplicationView.Count.ToString();
            txtSearchFilter.Clear();
        }

        private void frmManageLocalLicenseApplications_Load(object sender, EventArgs e)
        {
            _LoadLocalLicenceApplications();
            cmpFilter.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmpFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchFilter.Text = "";
            if (cmpFilter.SelectedIndex == 0)
            {
                txtSearchFilter.Visible = false;
                cmpStatus.Visible = false;
                lblPlaceHolder.Visible = false;
            }
            else if (cmpFilter.Text == "Status")
            {
                txtSearchFilter.Visible = false;
                cmpStatus.Visible = true;
                lblPlaceHolder.Visible = false;
            }
            else
            {
                cmpStatus.Visible = false;
                txtSearchFilter.Visible = true;
                lblPlaceHolder.Visible = true;
            }
            _LoadLocalLicenceApplications();
        }

        private void txtSearchFilter_TextChanged(object sender, EventArgs e)
        {


            string FilterColoumn = "";
            switch (cmpFilter.Text)
            {
                case "Local License Application ID":
                    FilterColoumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "Class Name":
                    FilterColoumn = "ClassName";
                    break;
                case "NationalNo":
                    FilterColoumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColoumn = "Fullname";
                    break;
                case "Application Date":
                    FilterColoumn = "ApplicationDate";
                    break;
                default:
                    FilterColoumn = "None";
                    break;
            }

            if (txtSearchFilter.Text.Trim() == "")
            {
                _dtLocalApplicationView.RowFilter = "";
                return;
            }

            if (FilterColoumn == "LocalDrivingLicenseApplicationID")
            {
                if (int.TryParse(txtSearchFilter.Text, out int id))
                {
                    _dtLocalApplicationView.RowFilter = $"{FilterColoumn} = {id}";
                }
            }
            else
                _dtLocalApplicationView.RowFilter = $"{FilterColoumn} LIKE '{txtSearchFilter.Text.Trim()}%'";
        }

        private void cmpStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmpStatus.SelectedIndex == 0)
            {
                _dtLocalApplicationView.RowFilter = "";
            }
            else
            {
                _dtLocalApplicationView.RowFilter = $"Status = '{cmpStatus.Text}'";
            }
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            frmAddEditLocalLicenseApplication frm = new frmAddEditLocalLicenseApplication(-1);
            frm.ShowDialog();
            _LoadLocalLicenceApplications();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditLocalLicenseApplication frm = new frmAddEditLocalLicenseApplication((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadLocalLicenceApplications();
        }

        private void CancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Cancel Application " +
               "with id = [" + dataGridView1.CurrentRow.Cells[0].Value + "] ?", "Cancel Application",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsLocalLicenseApplications.CancelLocalLicenseApplication((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Application Cancelled successfuly");
                    _LoadLocalLicenceApplications();
                }
                else
                {
                    MessageBox.Show("The application with id = [" + dataGridView1.CurrentRow.Cells[0].Value + "] cant be Cancelled .. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void pnlFilterBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        

        private void scheduleVisionTesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleLicenseTests frm = new frmScheduleLicenseTests((int)dataGridView1.CurrentRow.Cells[0].Value , 1);
            frm.ShowDialog();
            _LoadLocalLicenceApplications();
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleLicenseTests frm = new frmScheduleLicenseTests((int)dataGridView1.CurrentRow.Cells[0].Value, 2);
            frm.ShowDialog();
            _LoadLocalLicenceApplications();

        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleLicenseTests frm = new frmScheduleLicenseTests((int)dataGridView1.CurrentRow.Cells[0].Value, 3);
            frm.ShowDialog();
            _LoadLocalLicenceApplications();

        }

        private void _TestsMenuControl(int PassedTests , byte ApplicationStatus)
        {
            if (PassedTests == 0 && ApplicationStatus == 1)
            {
                ScheduleTestToolStripMenuItem.Enabled = true;
                scheduleVisionTesToolStripMenuItem.Enabled = true;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                schedulePracticalTestToolStripMenuItem.Enabled = false;
                IssureLicenseToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = true;
            }
            else if (PassedTests == 1 && ApplicationStatus == 1)
            {
                ScheduleTestToolStripMenuItem.Enabled = true;
                scheduleWrittenTestToolStripMenuItem.Enabled = true;
                schedulePracticalTestToolStripMenuItem.Enabled = false;
                scheduleVisionTesToolStripMenuItem.Enabled = false;
                IssureLicenseToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
            }
            else if (PassedTests == 2 && ApplicationStatus == 1)
            {
                ScheduleTestToolStripMenuItem.Enabled = true;
                schedulePracticalTestToolStripMenuItem.Enabled = true;
                scheduleVisionTesToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                IssureLicenseToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
            }
            else if (PassedTests > 2)
            {
                ScheduleTestToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
            }
            if (PassedTests == 3 && ApplicationStatus == 1)
            {
                editToolStripMenuItem.Enabled = false;
                IssureLicenseToolStripMenuItem.Enabled = true;
            }


        }

        private void _ContextMenuControl(int passedtest)
        {
            _localLicenseAppID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            _LocalLicenseApp = clsLocalLicenseApplications.Find(_localLicenseAppID);


            if ( _LocalLicenseApp != null )
            {
                if(_LocalLicenseApp.ApplicationInfo.ApplicationStatus == 1)
                {
                    showLicenseToolStripMenuItem.Enabled  =false;
                    CancelApplicationToolStripMenuItem.Enabled = true;
                    ScheduleTestToolStripMenuItem.Enabled = true ;
                    editToolStripMenuItem.Enabled = true ;
                    deleteToolStripMenuItem.Enabled = false;

                }
                else if(_LocalLicenseApp.ApplicationInfo.ApplicationStatus == 2)
                {
                    IssureLicenseToolStripMenuItem.Enabled = false;
                    showLicenseToolStripMenuItem.Enabled = false;
                    CancelApplicationToolStripMenuItem.Enabled = false;
                    ScheduleTestToolStripMenuItem.Enabled = false;
                    editToolStripMenuItem.Enabled = false;
                    deleteToolStripMenuItem.Enabled = true;
                }
                else
                {
                    editToolStripMenuItem.Enabled =false;
                    CancelApplicationToolStripMenuItem.Enabled =false;
                    ScheduleTestToolStripMenuItem.Enabled =false;
                    deleteToolStripMenuItem.Enabled =false;
                    IssureLicenseToolStripMenuItem.Enabled=false;
                    showLicenseToolStripMenuItem.Enabled = true;

                }
                _TestsMenuControl(passedtest, _LocalLicenseApp.ApplicationInfo.ApplicationStatus);


            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int passedtests = clsLocalLicenseApplications.GetNumberOfPassedTests((int)dataGridView1.CurrentRow.Cells[0].Value);

            _ContextMenuControl((int)passedtests);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Application " +
              "with id = [" + dataGridView1.CurrentRow.Cells[0].Value + "] ?", "Delete Local license Application",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsLocalLicenseApplications.DeleteLocalLicenseApplication((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Application deleted successfuly");
                    _LoadLocalLicenceApplications();
                }
                else
                {
                    MessageBox.Show("The Local License Application with id = [" + dataGridView1.CurrentRow.Cells[0].Value + "] cant be deleted .. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void IssureLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssureDrvingLicense frm = new frmIssureDrvingLicense((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadLocalLicenceApplications();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDriverLicenseInfo frm = frmShowDriverLicenseInfo.CreateByLocalAppID((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadLocalLicenceApplications();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_LocalLicenseApp != null)
            {
                frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory(_LocalLicenseApp.ApplicationID);
                frm.ShowDialog();
                _LoadLocalLicenceApplications();
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowApplicationDetails frm = new frmShowApplicationDetails((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}

