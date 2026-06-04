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
    public partial class frmUserDetails : Form
    {
        int _UserID;
        public frmUserDetails( int userid)
        {
            InitializeComponent();
            _UserID = userid;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            ucUserInformationCard1.LoadUserData(_UserID);
        }

        private void ucUserInformationCard1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
