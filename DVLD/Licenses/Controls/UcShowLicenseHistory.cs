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
    public partial class UcShowLicenseHistory : UserControl
    {
        int _Personid;
        private DataView _dtLocalHistroyLicense;
        private DataView _dtInternationalHistroyLicense;

        public UcShowLicenseHistory()
        {
            InitializeComponent();
        }

        public void LoadLocalLicenceApplications(int personid)
        {
            _Personid = personid;
            DataTable dt = clsLicense.GetHistoryLocalLicenses(_Personid);
            _dtLocalHistroyLicense = dt.DefaultView;
            dataGridView1.DataSource = _dtLocalHistroyLicense;
            lblRecord.Text = _dtLocalHistroyLicense.Count.ToString();
        }

        public void LoadInternationalLicenceApplications(int personid)
        {
            _Personid = personid;
            DataTable dt = clsInternationalLicense.GetHistoryInternatioanlLicense(_Personid);
            _dtLocalHistroyLicense = dt.DefaultView;
            dataGridView2.DataSource = _dtLocalHistroyLicense;
            lblInternationlCount.Text = _dtLocalHistroyLicense.Count.ToString();
        }
        private void UcShowLicenseHistory_Load(object sender, EventArgs e)
        {
        }

        private void tabLocal_Click(object sender, EventArgs e)
        {

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabLocal)
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("There are no Local licenses available .", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmShowDriverLicenseInfo frm = frmShowDriverLicenseInfo.CreateByLicenseID((int)dataGridView1.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
            }
            else
            {
                if (dataGridView2.CurrentRow == null)
                {
                    MessageBox.Show("There are no International licenses available.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo((int)dataGridView2.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
            }
        }
    }
}
