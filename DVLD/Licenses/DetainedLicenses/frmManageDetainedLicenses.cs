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
    public partial class frmManageDetainedLicenses : Form
    {
        int _DetainedLicenseID;
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }
        private DataView _dtDetainedLicensesView;

        private void _LoadDetainedLicensesList()
        {
            DataTable dt = clsDetainedLicenses.GetListDetainedLicenses();
            _dtDetainedLicensesView = dt.DefaultView;
            dataGridView1.DataSource = _dtDetainedLicensesView;

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns["DetainID"].HeaderText = "Detain ID";
                dataGridView1.Columns["LicenseID"].HeaderText = "License ID";
                dataGridView1.Columns["NationalNo"].HeaderText = "National No.";
                dataGridView1.Columns["FullName"].HeaderText = "Full Name";
                dataGridView1.Columns["DetainDate"].HeaderText = "Detain Date";
                dataGridView1.Columns["IsReleased"].HeaderText = "Is Released";
                dataGridView1.Columns["FineFees"].HeaderText = "Fine Fees";
                dataGridView1.Columns["ReleaseDate"].HeaderText = "Release Date";
                dataGridView1.Columns["ReleaseApplicationID"].HeaderText = "Release App.ID";

                dataGridView1.Columns["FullName"].Width = 200;
                dataGridView1.Columns["NationalNo"].Width = 100;
                dataGridView1.Columns["FineFees"].Width = 90;
                dataGridView1.Columns["IsReleased"].Width = 90;
            }

            lblRecrodsCount.Text = _dtDetainedLicensesView.Count.ToString();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            cmpFilter.SelectedIndex = 0;
            _LoadDetainedLicensesList();
        }

        private void txtSearchFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cmpFilter.Text)
            {
                case "Detain ID":
                    FilterColumn = "DetainID";
                    break;
                case "License ID":
                    FilterColumn = "LicenseID";
                    break;
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtSearchFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtDetainedLicensesView.RowFilter = "";
                lblRecrodsCount.Text = _dtDetainedLicensesView.Count.ToString();
                return;
            }

            if (FilterColumn == "DetainID" || FilterColumn == "LicenseID")
            {
                if (int.TryParse(txtSearchFilter.Text.Trim(), out int id))
                {
                    _dtDetainedLicensesView.RowFilter = $"{FilterColumn} = {id}";
                }
                else
                {
                    _dtDetainedLicensesView.RowFilter = $"{FilterColumn} = -1";
                }
            }
            else
            {
                _dtDetainedLicensesView.RowFilter = $"{FilterColumn} LIKE '{txtSearchFilter.Text.Trim()}%'";
            }

            lblRecrodsCount.Text = _dtDetainedLicensesView.Count.ToString();
        }

        private void cmpFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchFilter.Text = "";

            if (cmpFilter.SelectedIndex == 0)
            {
                txtSearchFilter.Visible = false;
                cmpIsActive.Visible = false;
                lblPlaceHolder.Visible = false;
            }
            else if (cmpFilter.SelectedIndex == 5)
            {
                txtSearchFilter.Visible = false;
                cmpIsActive.Visible = true;
                lblPlaceHolder.Visible = false;

                cmpIsActive.SelectedIndex = 0;
            }
            else
            {
                cmpIsActive.Visible = false;
                txtSearchFilter.Visible = true;
                lblPlaceHolder.Visible = true;
            }

            _LoadDetainedLicensesList();
        }

        private void cmpIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmpIsActive.SelectedIndex == 1)
                _dtDetainedLicensesView.RowFilter = "IsReleased = 1";
            else if (cmpIsActive.SelectedIndex == 2)
                _dtDetainedLicensesView.RowFilter = "IsReleased = 0";
            else
                _dtDetainedLicensesView.RowFilter = "";

            lblRecrodsCount.Text = _dtDetainedLicensesView.Count.ToString();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("There is no detained licences in the system", "Empty");
                return;
            }

            bool IsReleased = (bool)dataGridView1.CurrentRow.Cells["IsReleased"].Value;
            if(IsReleased)
            {
                ReleaseLicenseToolStripMenuItem.Enabled = false;
            }
            else
            {
                ReleaseLicenseToolStripMenuItem.Enabled = true;
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            string NationalNo = dataGridView1.CurrentRow.Cells["NationalNo"].Value.ToString();

            clsPerson person = clsPerson.Find(NationalNo);
            if (person !=null)
            {
                frmPersonCardDetails frm = new frmPersonCardDetails(person.PersonID);
                frm.ShowDialog();
            }
            _LoadDetainedLicensesList();
        }

        private void ShowLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int LicenseID = (int)dataGridView1.CurrentRow.Cells["LicenseID"].Value;

            frmShowDriverLicenseInfo frm = frmShowDriverLicenseInfo.CreateByLicenseID(LicenseID);
            frm.ShowDialog();
            _LoadDetainedLicensesList();

        }

        private void ShowPersonLicenseHistoryStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int LicenseID = (int)dataGridView1.CurrentRow.Cells["LicenseID"].Value;

            clsLicense license = clsLicense.Find(LicenseID);
            if (license != null)
            {
                frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory(license.ApplicationID);
                frm.ShowDialog();
                _LoadDetainedLicensesList();

            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
            _LoadDetainedLicensesList();

        }

        private void ReleaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int LicenseID = (int)dataGridView1.CurrentRow.Cells["LicenseID"].Value;

            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense(LicenseID);
            frm.ShowDialog();
            _LoadDetainedLicensesList();

        }
    }
}
