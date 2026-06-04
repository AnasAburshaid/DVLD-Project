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
    public partial class frmManageTestTypes : Form
    {
        private DataView _dtTestTypesView;

        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            DataTable dt = clsTestTypes.GetTestTypesList();
            _dtTestTypesView = dt.DefaultView;
            dataGridView1.DataSource = _dtTestTypesView;
            lblRecrodsCount.Text = _dtTestTypesView.Count.ToString();
        }  
     
        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationType frm = new frmUpdateApplicationType((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadData();
        }
    
        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void editApplicationTypeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmUpdateTestTypes frm = new frmUpdateTestTypes((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadData();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
