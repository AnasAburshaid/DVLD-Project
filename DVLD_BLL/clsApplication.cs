using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsApplication
    {
        public enum enMode { enUpdateMode = 0, enAddMode = 1 };
        enMode _Mode;

        public int ApplicationID { get; set; }
        public int ApplicationPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }

        public int ApplicationTypeID { get; set; }

        public byte ApplicationStatus { get; set; }

        public DateTime LastStatusDate { get; set; }

        public double PaidFees { get; set; }

        public int CreatedByUserID { get; set; }

        private clsApplication(int ApplicationID, int ApplicationPersonID, DateTime ApplicationDate, int ApplicationTypeID,
        byte ApplicationStatus, DateTime LastStatusDate, double PaidFees, int CreatedByUserID)
        {
            _Mode = enMode.enUpdateMode;

            this.ApplicationID = ApplicationID;
            this.ApplicationPersonID = ApplicationPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
        }

        public clsApplication()
        {
            this.ApplicationID = -1;
            this.ApplicationPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = 1;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            _Mode = enMode.enAddMode;
        }

        public static clsApplication Find(int ApplicationID)
        {
          
            int ApplicantPersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;
            byte ApplicationStatus = 1;
            double PaidFees = 0;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;


            if (clsApplication_DAL.GetApplictionInfoByID(ref ApplicationID, ref ApplicantPersonID, ref ApplicationTypeID,
                ref ApplicationStatus, ref LastStatusDate, ref PaidFees,ref ApplicationDate,ref CreatedByUserID))
            {
                return new clsApplication(ApplicationID,ApplicantPersonID,ApplicationDate,
                    ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID);
            }
            else
                return null;
        }

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplication_DAL.AddNewApplication(this.ApplicationPersonID,this.ApplicationTypeID,
                this.ApplicationStatus,this.LastStatusDate,this.PaidFees,this.ApplicationDate,this.CreatedByUserID);

            return (this.ApplicationID != -1);
        }
        private bool _UpdateApplication()
        {
            int rowAffected = clsApplication_DAL.UpdateApplication(this.ApplicationID,this.ApplicationPersonID, this.ApplicationTypeID,
                this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.ApplicationDate, this.CreatedByUserID);

            return (rowAffected > 0);
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            int rowAffected = clsApplication_DAL.DeleteApplication(ApplicationID);

            return (rowAffected > 0);
        }

        public static bool CancelApplication(int ApplicationID)
        {
            int AffectedRows = clsApplication_DAL.CancelApplication(ApplicationID);
            return (AffectedRows> 0);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddMode:
                    {
                        if (_AddNewApplication())
                        {
                            _Mode = enMode.enUpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.enUpdateMode:
                    {
                        if (_UpdateApplication())
                        {
                            _Mode = enMode.enUpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
            }
            return false;
        }
    }
}
