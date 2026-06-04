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
    public partial class frmShowInternationalLicenseInfo : Form
    {
        int _internationalLicenseId;
        
        public frmShowInternationalLicenseInfo( int internationalLicenseid)
        {
            InitializeComponent();
            _internationalLicenseId = internationalLicenseid;
        }

        private void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ucInternationalLicenseCardInfo1.LoadInternationalData(_internationalLicenseId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
