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
    public partial class frmUsersMenueScreen : Form
    {
        private DataView _dtUsersView;

        public frmUsersMenueScreen()
        {
            InitializeComponent();
        }

        private void _LoadUsersList()
        {
            DataTable dt = clsUser.GetListUsers();
            _dtUsersView = dt.DefaultView;
            dataGridView1.DataSource = _dtUsersView;
            lblRecrodsCount.Text = _dtUsersView.Count.ToString();
        }

       
        private void frmUsersMenueScreen_Load(object sender, EventArgs e)
        {
            cmpFilter.SelectedIndex = 0;
            _LoadUsersList();
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
            else if(cmpFilter.SelectedIndex == 5)
            {
                txtSearchFilter.Visible = false;
                cmpIsActive.Visible = true;
                lblPlaceHolder.Visible = false ;
            }
            else
            {
                cmpIsActive.Visible = false;
                txtSearchFilter.Visible = true;
                lblPlaceHolder.Visible = true;
            }
            _LoadUsersList();

        }

        private void txtSearchFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColoumn = "";
            switch (cmpFilter.Text)
            {
                case "Person ID":
                    FilterColoumn = "PersonID";
                    break;
                case "User ID":
                    FilterColoumn = "UserID";
                    break;
                case "Username":
                    FilterColoumn = "Username";
                    break;
                case "Full Name":
                    FilterColoumn = "Fullname";
                    break;
                default:
                    FilterColoumn = "None";
                    break;
            }

            if (txtSearchFilter.Text.Trim() == "")
            {
                _dtUsersView.RowFilter = "";
                return;
            }

            if (FilterColoumn == "PersonID" || FilterColoumn == "UserID")
            {
                if (int.TryParse(txtSearchFilter.Text, out int id))
                {
                    _dtUsersView.RowFilter = $"{FilterColoumn} = {id}";
                }
            }
            else
                _dtUsersView.RowFilter = $"{FilterColoumn} LIKE '{txtSearchFilter.Text.Trim()}%'";
        }

        private void cmpIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmpIsActive.SelectedIndex == 1)
                _dtUsersView.RowFilter = "isActive = 1";
            else if (cmpIsActive.SelectedIndex == 2)
                _dtUsersView.RowFilter = "isActive = 0";
            else
                _dtUsersView.RowFilter = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(-1);
            frm.ShowDialog();
            _LoadUsersList();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(-1);
            frm.ShowDialog();
            _LoadUsersList();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User " +
               "with id = [" + dataGridView1.CurrentRow.Cells[0].Value + "] ?", "Delete User",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User deleted successfuly");
                    _LoadUsersList();
                }
                else
                {
                    MessageBox.Show("The user with id = [" + dataGridView1.CurrentRow.Cells[0].Value + "] cant be deleted .. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadUsersList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadUsersList();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword frm = new frmChangeUserPassword((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadUsersList();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet","",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
