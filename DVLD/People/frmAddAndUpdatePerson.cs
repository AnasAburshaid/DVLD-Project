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
    public partial class frmEditAndUpdatePerson : Form
    {
        int _PersonId;
        clsPerson _Person;
        enum enMode { Update = 0, Add = 1 };
        enMode _Mode;
        public frmEditAndUpdatePerson( int PersonId)
        {
            InitializeComponent();
            _PersonId = PersonId;

            if (PersonId == -1)
                _Mode = enMode.Add;
            else
                _Mode = enMode.Update;
        }

        private void frmEditAndUpdatePerson_Load(object sender, EventArgs e)
        {
            ucPersonCard1.OnPersonSaved += ucPersonCard1_OnPersonSaved;

            if(_Mode == enMode.Update)
            {
                this.Text = "Update Person";
                lblMode.Text = "Update Person";
                ucPersonCard1.LoadDataInUpdateMode(_PersonId);
            }
            else
            { 
                this.Text = "Add New Person";
                lblMode.Text = "Add New Person";
                ucPersonCard1.LoadDataInAddMode();
            }
        }

        private void ucPersonCard1_OnPersonSaved(int obj)
        {
            _PersonId = obj;
            _Mode = enMode.Update;

        }
    }
}
