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
    public partial class UsPersonCardFilter : UserControl
    {
        public UsPersonCardFilter()
        {
            InitializeComponent();
        }

        public event Action<int> OnPersonSelected;
        int _PersonID;
        clsPerson _Person;


        private void txtSearchFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtSearchFilter.Text))
            {
                MessageBox.Show("Search box is empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                return;
            }

            if (cmpFilter.SelectedIndex == 0)
            {
                usPersonInformationCard1.LoadData(txtSearchFilter.Text);
            }
            else if (cmpFilter.SelectedIndex == 1)
            {
                if (int.TryParse(txtSearchFilter.Text, out int personid))
                {
                    usPersonInformationCard1.LoadData(personid);
                }
                else
                {
                    MessageBox.Show("Please enter valid personID (number)", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            OnPersonSelected?.Invoke(usPersonInformationCard1.PersonID);
        }

        private void UsPersonCardFilter_Load(object sender, EventArgs e)
        {
            cmpFilter.SelectedIndex = 0;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmEditAndUpdatePerson frm = new frmEditAndUpdatePerson(-1);
            frm.ShowDialog();
        }

        public void DisableSearchFilter()
        {
            GrFilterBox.Enabled = false;
        }

        public void LoadDataInUpdateMode(int Personid)
        {
            usPersonInformationCard1.LoadData(Personid);
            DisableSearchFilter();
        }
     
    }
}
