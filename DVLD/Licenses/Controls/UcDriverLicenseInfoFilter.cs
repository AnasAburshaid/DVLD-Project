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
    public partial class UcDriverLicenseInfoFilter : UserControl
    {
        public event Action<int> OnLicenseFind;

        int _LiceseID;
        clsLicense _Licese;
        public UcDriverLicenseInfoFilter()
        {
            InitializeComponent();
        }

        private void UcDriverLicenseInfoFilter_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtSearchFilter.Text))
            {
                MessageBox.Show("Search box is empty ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if(int.TryParse(txtSearchFilter.Text, out int id))
            {
                ucDriverLicenseInfo1.LoadDataByLicenseID(id);
                OnLicenseFind?.Invoke(id);
            }
        }

        public void LoadDataByLicenseID(int LicenseID)
        {
            _LiceseID = LicenseID;
            _Licese = clsLicense.Find(_LiceseID);
            if (_Licese != null)
            {
                ucDriverLicenseInfo1.LoadDataByLicenseID(_Licese.LicenseID);
            }

        }
        public void DisableFilterBox()
        {
            pnlSearchBanner.Enabled = false;
        }
    }
}
