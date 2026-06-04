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
    public partial class frmUpdateTestTypes : Form
    {

        int _TestTypeID;
        clsTestTypes _TestType;
        public frmUpdateTestTypes(int testtypeid)
        {
            InitializeComponent();
            _TestTypeID = testtypeid;

        }

        private void _LoadTestTypeInfo()
        {
            _TestType = clsTestTypes.Find(_TestTypeID);
            if (_TestType == null)
            {
                MessageBox.Show("Test type is not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblid.Text = _TestType.TestTypeID.ToString();
            txtTitle.Text = _TestType.TestTypeTitle;
            txtDesc.Text = _TestType.TestTypeDescription;
            txtFees.Text = _TestType.TestTypeFees.ToString();
        }
        private void frmUpdateTestTypes_Load(object sender, EventArgs e)
        {
            _LoadTestTypeInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _TestType.TestTypeTitle = txtTitle.Text;
            _TestType.TestTypeDescription = txtDesc.Text;
            _TestType.TestTypeFees = Convert.ToDouble(txtFees.Text);

            if (_TestType.updateTestType())
            {
                MessageBox.Show("Test type updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Test type cant be updated .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
