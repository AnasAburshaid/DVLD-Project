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
    public partial class frmAddEditLocalLicenseApplication : Form
    {
        enum enMode { Update = 0, Add = 1 };
        enMode _Mode;
        int _LocalApplicationInfo;
        public frmAddEditLocalLicenseApplication( int LocalApplicationID)
        {
            InitializeComponent();
            _LocalApplicationInfo = LocalApplicationID;
            if (_LocalApplicationInfo == -1)
                _Mode = enMode.Add;
            else
                _Mode = enMode.Update;
        }

        private void frmAddEditLocalLicenseApplication_Load(object sender, EventArgs e)
        {
            if(_Mode == enMode.Add)
            {
                ucLocalLicenseApplication1.LoadApplicationInAddMode();
                lblMode.Text = "New Local Driving License Application";
            }
            else
            {
                ucLocalLicenseApplication1.LoadApplicationInUpdateMode(_LocalApplicationInfo);
                lblMode.Text = "Editing Local Driving License Application";

            }
        }
    }
}
