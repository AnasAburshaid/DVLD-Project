using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsApplicationTypes
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public double ApplicationFees { get; set; }

        private clsApplicationTypes(int applicationtypeid, string applicationtypetitle, double applicationfees)
        {
            this.ApplicationTypeID = applicationtypeid;
            this.ApplicationTypeTitle = applicationtypetitle;
            this.ApplicationFees = applicationfees;
          
        }

        public static clsApplicationTypes Find(int applicationtypeid)
        {
            string applicationtypetitle = "";
            double applicationfees = -1;

            if (clsApplicationTypes_DAL.GetApplicationType(ref applicationtypeid,ref applicationtypetitle,ref applicationfees))
            {
                return new clsApplicationTypes(applicationtypeid,applicationtypetitle,applicationfees);
            }
            else
                return null;
        }

        public bool UpdateApplicationType()
        {
            int rows = clsApplicationTypes_DAL.UpdateApplicationType(this.ApplicationTypeID,this.ApplicationTypeTitle,this.ApplicationFees);
            return (rows > 0);
        }

        public static DataTable GetApplicationTypesList()
        {
            return clsApplicationTypes_DAL.GetListApplicationTypes();
        }

    }
}
