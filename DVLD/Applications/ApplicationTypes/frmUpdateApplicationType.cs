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
    public partial class frmUpdateApplicationType : Form
    {
        int _ApplicationTypeID;
        clsApplicationTypes _ApplicationTypes;
        public frmUpdateApplicationType( int applicationtypeid)
        {
            InitializeComponent();
            _ApplicationTypeID = applicationtypeid;
        }

        private void _LoadApplicationTypeInfo()
        {
            _ApplicationTypes = clsApplicationTypes.Find(_ApplicationTypeID);
            if( _ApplicationTypes == null )
            {
                MessageBox.Show("Application type is not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            lblid.Text = _ApplicationTypes.ApplicationTypeID.ToString();
            txtTitle.Text = _ApplicationTypes.ApplicationTypeTitle;
            txtFees.Text = _ApplicationTypes.ApplicationFees.ToString();
        }
        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            _LoadApplicationTypeInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ApplicationTypes.ApplicationTypeTitle = txtTitle.Text;
            _ApplicationTypes.ApplicationFees = Convert.ToDouble(txtFees.Text);

            if(_ApplicationTypes.UpdateApplicationType())
            {
                MessageBox.Show("Application type updated successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Application type cant be updated .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
