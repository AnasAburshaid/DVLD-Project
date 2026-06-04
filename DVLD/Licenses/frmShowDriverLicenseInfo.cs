using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmShowDriverLicenseInfo : Form
    {
        private int _LocalAppID = -1;
        private int _LicenseID = -1;

        private frmShowDriverLicenseInfo()
        {
            InitializeComponent();
        }

        public static frmShowDriverLicenseInfo CreateByLocalAppID(int localAppID)
        {
            frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo();
            frm._LocalAppID = localAppID;
            return frm;
        }

        public static frmShowDriverLicenseInfo CreateByLicenseID(int licenseID)
        {
            frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo();
            frm._LicenseID = licenseID;
            return frm;
        }

        private void frmShowDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            if (_LocalAppID != -1)
            {
                ucDriverLicenseInfo1.LoadDataByLocalAppID(_LocalAppID);
            }
            else if (_LicenseID != -1)
            {
                ucDriverLicenseInfo1.LoadDataByLicenseID(_LicenseID);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}