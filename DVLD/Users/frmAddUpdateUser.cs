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
    public partial class frmAddUpdateUser : Form
    {
        int _UserID;
        clsUser _User;
        enum enMode { Update = 0, Add = 1 };
        enMode _Mode;
        public frmAddUpdateUser(int Userid)
        {
            InitializeComponent();
            _UserID = Userid;
            if (Userid == -1)
                _Mode = enMode.Add;
            else
                _Mode = enMode.Update;
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                this.Text = "Update User";
                lblMode.Text = "Update User";
                ucUserCard1.LoadDataInUpdateMode(_UserID);
            }
            else
            {
                this.Text = "Add New User";
                lblMode.Text = "Add New User";
                ucUserCard1.LoadDataInAddMode();
            }

        }
    }
}
