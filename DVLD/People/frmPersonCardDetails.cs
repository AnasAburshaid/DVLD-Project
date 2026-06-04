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
    public partial class frmPersonCardDetails : Form
    {
        int _Personid;
        public frmPersonCardDetails( int Personid)
        {
            InitializeComponent();
            _Personid = Personid;
        }

        private void frmPersonCardDetails_Load(object sender, EventArgs e)
        {
            usPersonInformationCard1.LoadData(_Personid);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
