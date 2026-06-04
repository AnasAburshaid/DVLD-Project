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
    public partial class frmManageApplicationTypes : Form
    {
        private DataView _dtApplicationTypesView;
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }
        
        private void _LoadData()
        {
            DataTable dt = clsApplicationTypes.GetApplicationTypesList();
            _dtApplicationTypesView = dt.DefaultView;
            dataGridView1.DataSource = _dtApplicationTypesView;
            lblRecrodsCount.Text = _dtApplicationTypesView.Count.ToString();
        }
        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationType frm = new frmUpdateApplicationType((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadData();
        }
    }
}
