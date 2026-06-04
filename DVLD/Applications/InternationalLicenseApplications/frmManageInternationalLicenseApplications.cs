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

namespace DVLD
{
    public partial class frmManageInternationalLicenseApplications : Form
    {
        private DataView _dtInternationaLicenseView;
        public frmManageInternationalLicenseApplications()
        {
            InitializeComponent();
        }

        private void _LoadInternationalLicensesList()
        {
            DataTable dt = clsInternationalLicense.GetListInternationalLicenses();
            _dtInternationaLicenseView = dt.DefaultView;
            dataGridView1.DataSource = _dtInternationaLicenseView;

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns["InternationalLicenseID"].HeaderText = "Int.License ID";
                dataGridView1.Columns["ApplicationID"].HeaderText = "App.ID";
                dataGridView1.Columns["DriverID"].HeaderText = "Driver ID";
                dataGridView1.Columns["IssuedUsingLocalLicenseID"].HeaderText = "L.License ID";
                dataGridView1.Columns["IssueDate"].HeaderText = "Issue Date";
                dataGridView1.Columns["ExpirationDate"].HeaderText = "Exp. Date";
                dataGridView1.Columns["IsActive"].HeaderText = "Is Active";

                dataGridView1.Columns["IsActive"].Width = 100;
            }

            lblRecrodsCount.Text = _dtInternationaLicenseView.Count.ToString();
        }

        private void frmManageInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            cmpFilter.SelectedIndex = 0;
            _LoadInternationalLicensesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchFilter_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtSearchFilter.Text))
                lblPlaceHolder.Visible = true;
            else
                lblPlaceHolder.Visible = false;

            string FilterColoumn = "";

            switch (cmpFilter.Text)
            {
                case "International License ID":
                    FilterColoumn = "InternationalLicenseID";
                    break;
                case "Application ID":
                    FilterColoumn = "ApplicationID";
                    break;
                case "Driver ID":
                    FilterColoumn = "DriverID";
                    break;
                case "Local LIcense ID":
                    FilterColoumn = "IssuedUsingLocalLicenseID";
                    break;
                default:
                    FilterColoumn = "None";
                    break;
            }

            if (txtSearchFilter.Text.Trim() == "")
            {
                _dtInternationaLicenseView.RowFilter = "";
                return;
            }

            if (FilterColoumn == "InternationalLicenseID" || FilterColoumn == "ApplicationID" || FilterColoumn == "DriverID" || FilterColoumn == "IssuedUsingLocalLicenseID")
            {
                if (int.TryParse(txtSearchFilter.Text, out int id))
                {
                    _dtInternationaLicenseView.RowFilter = $"{FilterColoumn} = {id}";
                }
            }
            else
                _dtInternationaLicenseView.RowFilter = $"{FilterColoumn} LIKE '{txtSearchFilter.Text.Trim()}%'";
        }

        private void cmpFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchFilter.Text = "";
            if (cmpFilter.SelectedIndex == 0)
            {
                txtSearchFilter.Visible = false;
                lblPlaceHolder.Visible = false;
            }
            else
            {
                txtSearchFilter.Visible = true;
                lblPlaceHolder.Visible = true;
            }
            _LoadInternationalLicensesList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int _InternationalLicenseID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            clsInternationalLicense _internationalLicense = clsInternationalLicense.Find(_InternationalLicenseID);
            if (_internationalLicense != null)
            {
                clsApplication app = clsApplication.Find(_internationalLicense.ApplicationID);
                if (app != null)
                {

                    frmPersonCardDetails frm = new frmPersonCardDetails(app.ApplicationPersonID);
                    frm.ShowDialog();
                    _LoadInternationalLicensesList();
                }
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadInternationalLicensesList();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int _InternationalLicenseID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            clsInternationalLicense _internationalLicense = clsInternationalLicense.Find(_InternationalLicenseID);
            if (_internationalLicense != null)
            {
                frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory(_internationalLicense.ApplicationID);
                frm.ShowDialog();
                _LoadInternationalLicensesList();
            }
        }
    }
}

