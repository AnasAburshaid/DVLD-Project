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
    public partial class frmShowPersonLicensesHistory : Form
    {
        int _ApplicationID;
        clsApplication _Application;

        string _NationalNumber;
        clsPerson _Person;

        enum enFindBy { enNationalNum =0,enApplicationID =1}
        enFindBy _FindBy;
        public frmShowPersonLicensesHistory(int Applicationid)
        {
            InitializeComponent();
            _ApplicationID = Applicationid;
            _FindBy = enFindBy.enApplicationID;
        }

        public frmShowPersonLicensesHistory(string NatioanlNumber)
        {
            InitializeComponent();
            _NationalNumber = NatioanlNumber;
            _FindBy = enFindBy.enNationalNum;
        }

        private void frmShowPersonLicensesHistory_Load(object sender, EventArgs e)
        {
            if (_FindBy == enFindBy.enApplicationID)
            {
                _Application = clsApplication.Find(_ApplicationID);
                if (_Application != null)
                {
                    ucShowLicenseHistory1.LoadLocalLicenceApplications(_Application.ApplicationPersonID);
                    ucShowLicenseHistory1.LoadInternationalLicenceApplications(_Application.ApplicationPersonID);
                    usPersonInformationCard1.LoadData(_Application.ApplicationPersonID);
                }
                else
                    MessageBox.Show("Error");
            }
            else
            {
                _Person = clsPerson.Find(_NationalNumber);
                if (_Person != null)
                {
                    ucShowLicenseHistory1.LoadLocalLicenceApplications(_Person.PersonID);
                    ucShowLicenseHistory1.LoadInternationalLicenceApplications(_Person.PersonID);
                    usPersonInformationCard1.LoadData(_Person.PersonID);
                }
                else
                    MessageBox.Show("Error");
            }
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
