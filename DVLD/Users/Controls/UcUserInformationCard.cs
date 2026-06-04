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
    public partial class UcUserInformationCard : UserControl
    {
        clsUser _User;
        int _UserId;
        public UcUserInformationCard()
        {
            InitializeComponent();
        }

        public void LoadUserData(int UserId)
        {
            _UserId = UserId;
            _User = clsUser.Find(_UserId);

            if( _User == null )
            {
                MessageBox.Show("User not found ..","Not found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            usPersonInformationCard1.LoadData(_User.PersonID);
            lblUsername.Text = _User.Username;
            lblUserID.Text = _User.UserID.ToString();
            if (_User.IsActive == true)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";
        }
        private void UcUserInformationCard_Load(object sender, EventArgs e)
        {

        }
    }
}
