    using DVLD_;
    using DVLD_BLL;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.Remoting.Messaging;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace DVLD
    {
        public partial class UcLocalLicenseApplication : UserControl
        {
            int _PersonID;
            clsPerson _Person;
            clsLocalLicenseApplications _LocalApplication;
            int _LocalAppID;
            enum enMode { Update = 0, Add = 1 };
            enMode _Mode;

            public UcLocalLicenseApplication()
            {
                InitializeComponent();

            }

        private void _LoadCmbLicenceClasses()
            {
                DataTable dt = clsLicenseClasses.GetListLicenseClasses();
                foreach(DataRow dr in dt.Rows)
                {
                    cmbLicenseClass.Items.Add(dr["ClassName"].ToString());
                }
            }
        public void LoadApplicationInAddMode()
        {
            _LoadCmbLicenceClasses();
            _Mode = enMode.Add;
            _LocalAppID = -1;
            _LocalApplication = new clsLocalLicenseApplications();

            tpApplicationInfo.Enabled = false;
            btnNext.Enabled = false;

            if (_LocalApplication == null)
                return;
            lblAppDate.Text = _LocalApplication.ApplicationInfo.ApplicationDate.ToString();
            lblAppFees.Text = _LocalApplication.ApplicationInfo.PaidFees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
            cmbLicenseClass.SelectedIndex = 1;

        }

        public void LoadApplicationInUpdateMode(int LocalAppID)
        {
            
            _LoadCmbLicenceClasses();
            _Mode = enMode.Update;
            _LocalApplication = clsLocalLicenseApplications.Find(LocalAppID);
            if (_LocalApplication == null)
            {
                return;
            }
            btnNext.Enabled = true;
            _PersonID = _LocalApplication.ApplicationInfo.ApplicationPersonID;

            tpApplicationInfo.Enabled = true;
            btnNext.Enabled = true;

            lblAppDate.Text = _LocalApplication.ApplicationInfo.ApplicationDate.ToString();
            lblAppFees.Text = _LocalApplication.ApplicationInfo.PaidFees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
            usPersonCardFilter1.DisableSearchFilter();

            usPersonCardFilter1.LoadDataInUpdateMode(_PersonID); ;
            _LocalApplication.ApplicationInfo.ApplicationPersonID = _PersonID;

            _LocalAppID = LocalAppID;

            lblLocalAppID.Text = _LocalAppID.ToString();
            clsLicenseClasses Class = clsLicenseClasses.Find(_LocalApplication.LicenseClassID);

            cmbLicenseClass.SelectedIndex = cmbLicenseClass.FindString(Class.ClassName);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Person = clsPerson.Find(_PersonID);
            int LicenseClassID = clsLicenseClasses.Find(cmbLicenseClass.Text).LicenseClassID;


            _LocalApplication.LicenseClassID = LicenseClassID;

            if (clsLocalLicenseApplications.IsThereActiveApplication(_PersonID, LicenseClassID, 1))
            {
                MessageBox.Show("You cant do application for the same person and same class id if the previous one is new", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (clsLocalLicenseApplications.IsThereActiveApplication(_PersonID, LicenseClassID, 3))
            {
                MessageBox.Show("You cant do application for the same person and same class id if he already have a license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalApplication.ApplicationInfo.ApplicationPersonID = _PersonID;


            if (_LocalApplication.Save())
            {
                if (_Mode == enMode.Update)
                {
                    MessageBox.Show("Application Updated successfully .. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    _Mode = enMode.Update;
                    MessageBox.Show("Application Added successfully .. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblLocalAppID.Text = _LocalApplication.LocalDrivingLicenseApplicationID.ToString();
                    return;

                }
            }
            MessageBox.Show("Cannot Save the Data .. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

            private void btnNext_Click(object sender, EventArgs e)
            {
                tpApplicationInfo.Enabled = true;
                tabControl1.SelectedTab = tpApplicationInfo;
            }

            private void usPersonCardFilter1_OnPersonSelected(int obj)
            {
                _PersonID = obj;
                if(_PersonID != -1)
                {
                    btnNext.Enabled = true;
                }
            }

            private void UcLocalLicenseApplication_Load(object sender, EventArgs e)
            {
                if (_Mode == enMode.Add)
                    tpApplicationInfo.Enabled = false;
                else
                    tpApplicationInfo.Enabled = true;
            }

            private void btnClose_Click(object sender, EventArgs e)
            {
                Form parentForm = this.FindForm();

                if (parentForm != null)
                {
                    parentForm.Close();
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                parentForm.Close();
            }
        }
    }
    }
