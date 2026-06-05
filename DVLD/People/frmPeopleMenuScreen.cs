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
    public partial class frmPeopleMenuScreen : Form
    {

        private DataView _dtPeopleView;

        public frmPeopleMenuScreen()
        {
            InitializeComponent();
        }

        private void _FillPeopleData()
        {
            DataTable dt = clsPerson.GetListpeople();
            _dtPeopleView = dt.DefaultView;
            dataGridView1.DataSource = _dtPeopleView;
            lblRecrodsCount.Text = _dtPeopleView.Count.ToString();
        }

        private void frmPeopleMenuScreen_Load(object sender, EventArgs e)
        {
            cmpFilter.SelectedIndex = 0;
            _FillPeopleData();
        }

        private void cmpFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchFilter.Text = "";
            if (cmpFilter.SelectedIndex == 0)
            {
                txtSearchFilter.Visible = false;
            }

            else
            {
                txtSearchFilter.Visible = true;
            }
        }
        private void txtSearchFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColoumn = "";
            switch (cmpFilter.Text)
            {
                case "Person ID":
                    FilterColoumn = "PersonID";
                    break;
                case "National Number":
                    FilterColoumn = "NationalNo";
                    break;
                case "First Name":
                    FilterColoumn = "FirstName";
                    break;
                case "Second Name":
                    FilterColoumn = "SecondName";
                    break;
                case "Third Name":
                    FilterColoumn = "ThirdName";
                    break;
                case "Last Name":
                    FilterColoumn = "LastName";
                    break;
                case "Phone":
                    FilterColoumn = "Phone";
                    break;
                case "Email":
                    FilterColoumn = "Email";
                    break;
                case "Nationality":
                    FilterColoumn = "Nationality";
                    break;
                default:
                    FilterColoumn = "None";
                    break;  
            }

            if(txtSearchFilter.Text.Trim() == "")
            {
                _dtPeopleView.RowFilter = "";
                return;
            }

            if (FilterColoumn == "PersonID")
            {
                if (int.TryParse(txtSearchFilter.Text, out int id))
                {
                    _dtPeopleView.RowFilter = $"{FilterColoumn} = {id}";
                }
            }
            else
                _dtPeopleView.RowFilter = $"{FilterColoumn} LIKE '{txtSearchFilter.Text.Trim()}%'";

        }

        private void txtAddPerson_Click(object sender, EventArgs e)
        {
            frmEditAndUpdatePerson frmAddEdit = new frmEditAndUpdatePerson(-1);
            frmAddEdit.ShowDialog();
            _FillPeopleData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditAndUpdatePerson frmAddEdit = new frmEditAndUpdatePerson((int)dataGridView1.CurrentRow.Cells[0].Value);
            frmAddEdit.ShowDialog();
            _FillPeopleData();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditAndUpdatePerson frmAddEdit = new frmEditAndUpdatePerson(-1);
            frmAddEdit.ShowDialog();
            _FillPeopleData();
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented Yet !" , "Message" , MessageBoxButtons.OK,MessageBoxIcon.Information);
            return;
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented Yet !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person " +
                "with id = [" + dataGridView1.CurrentRow.Cells[0].Value + "] ?", "Delete Person",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsPerson.DeletePerson((int)dataGridView1.CurrentRow.Cells[0].Value))
                    MessageBox.Show("Person deleted successfuly");

                _FillPeopleData();

            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonCardDetails frmPersonDetails = new frmPersonCardDetails((int)dataGridView1.CurrentRow.Cells[0].Value);
            frmPersonDetails.ShowDialog();
            _FillPeopleData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
