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
    public partial class frmDriversMenuScreen : Form
    {
        public frmDriversMenuScreen()
        {
            InitializeComponent();
        }

        private DataView _dtDriversView;

        private void _LoadDriversList()
        {
            DataTable dt = clsDriver.GetListDrivers();
            _dtDriversView = dt.DefaultView;
            dataGridView1.DataSource = _dtDriversView;

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns["DriverID"].HeaderText = "Driver ID";
                dataGridView1.Columns["PersonID"].HeaderText = "Person ID";
                dataGridView1.Columns["NationalNo"].HeaderText = "National No.";
                dataGridView1.Columns["FullName"].HeaderText = "Full Name";
                dataGridView1.Columns["CreatedDate"].HeaderText = "Created Date";
                dataGridView1.Columns["NumberOfActiveLicenses"].HeaderText = "Active Licenses";

                dataGridView1.Columns["FullName"].Width = 220;
                dataGridView1.Columns["CreatedDate"].Width = 130;
                dataGridView1.Columns["NationalNo"].Width = 100;
                dataGridView1.Columns["NumberOfActiveLicenses"].Width = 110;

                dataGridView1.Columns["NumberOfActiveLicenses"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["DriverID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            lblRecrodsCount.Text = _dtDriversView.Count.ToString();
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
            _LoadDriversList();

        }
       

        private void frmDriversMenuScreen_Load(object sender, EventArgs e)
        {
            cmpFilter.SelectedIndex = 0;
            _LoadDriversList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchFilter_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchFilter.Text))
                lblPlaceHolder.Visible = true;
            else
                lblPlaceHolder.Visible = false;

            string FilterColoumn = "";

            switch (cmpFilter.Text)
            {
                case "Person ID":
                    FilterColoumn = "PersonID";
                    break;
                case "Driver ID":
                    FilterColoumn = "DriverID";
                    break;
                case "National Number":
                    FilterColoumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColoumn = "Fullname";
                    break;
                case "Created Date":
                    FilterColoumn = "CreatedDate";
                    break;
                case "Number Of Active Licenses":
                    FilterColoumn = "NumberOfActiveLicenses";
                    break;
                default:
                    FilterColoumn = "None";
                    break;
            }

            if (txtSearchFilter.Text.Trim() == "")
            {
                _dtDriversView.RowFilter = "";
                return;
            }

            if (FilterColoumn == "PersonID" || FilterColoumn == "DriverID" || FilterColoumn == "NumberOfActiveLicenses")
            {
                if (int.TryParse(txtSearchFilter.Text, out int id))
                {
                    _dtDriversView.RowFilter = $"{FilterColoumn} = {id}";
                }
            }
            else
                _dtDriversView.RowFilter = $"{FilterColoumn} LIKE '{txtSearchFilter.Text.Trim()}%'";
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int personid = (int)dataGridView1.CurrentRow.Cells["PersonID"].Value;

            frmPersonCardDetails frm = new frmPersonCardDetails(personid);
            frm.ShowDialog();

            _LoadDriversList();
        }

        private void ShowPersonLicenseHistoryStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            string NationalNo = dataGridView1.CurrentRow.Cells["NationalNo"].Value.ToString();

            frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory(NationalNo);
            frm.ShowDialog();
            _LoadDriversList();
        }
    }
}
