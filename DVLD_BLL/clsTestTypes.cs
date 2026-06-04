using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsTestTypes
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public double TestTypeFees { get; set; }

        private clsTestTypes(int testtypeid, string testtypetitle, string testtypedescription,double testtypefees)
        {
            this.TestTypeID = testtypeid;
            this.TestTypeTitle = testtypetitle;
            this.TestTypeDescription = testtypedescription;
            this.TestTypeFees = testtypefees;

        }

        public static clsTestTypes Find(int testtypeid)
        {
            string testtypetitle = "", testtypedescription = "";
            double testtypefees = -1;

            if (clsTestTypes_DAL.GetTestType(ref testtypeid, ref testtypetitle,ref testtypedescription, ref testtypefees))
            {
                return new clsTestTypes(testtypeid, testtypetitle, testtypedescription, testtypefees);
            }
            else
                return null;
        }

        public bool updateTestType()
        {
            int rows = clsTestTypes_DAL.UpdateTestType(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription,this.TestTypeFees);
            return (rows > 0);
        }

        public static DataTable GetTestTypesList()
        {
            return clsTestTypes_DAL.GetListTestTypes();
        }
    }
}
