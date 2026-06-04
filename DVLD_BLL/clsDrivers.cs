using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DAL;

namespace DVLD_BLL
{
    public class clsDriver
    {
        public enum enMode { enUpdateMode = 0, enAddMode = 1 };
        enMode _Mode;

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsPerson PersonInfo { get; set; }

        private clsDriver(int driverid, int personid, int createdbyuserid, DateTime createddate)
        {
            _Mode = enMode.enUpdateMode;

            this.DriverID = driverid;
            this.PersonID = personid;
            this.CreatedByUserID = createdbyuserid;
            this.CreatedDate = createddate;

            this.PersonInfo = clsPerson.Find(personid);
        }

        public clsDriver()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            this.CreatedDate = DateTime.Now;

            this.PersonInfo = new clsPerson();

            _Mode = enMode.enAddMode;
        }

        public static clsDriver Find(int DriverID)
        {
            int personID = -1, createdByUserID = -1;
            DateTime createdDate = DateTime.Now;

            if (clsDriver_DAL.GetDriverInfoByID(DriverID, ref personID, ref createdByUserID, ref createdDate))
            {
                return new clsDriver(DriverID, personID, createdByUserID, createdDate);
            }
            else
                return null;
        }

        public static clsDriver FindByPersonID(int PersonID)
        {
            int driverID = -1, createdByUserID = -1;
            DateTime createdDate = DateTime.Now;

            if (clsDriver_DAL.GetDriverInfoByPersonID(PersonID, ref driverID, ref createdByUserID, ref createdDate))
            {
                return new clsDriver(driverID, PersonID, createdByUserID, createdDate);
            }
            else
                return null;
        }

        private bool _AddNewDriver()
        {
            this.DriverID = clsDriver_DAL.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);

            return (this.DriverID != -1);
        }

        private bool _UpdateDriver()
        {
            int rowAffected = clsDriver_DAL.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);

            return (rowAffected > 0);
        }

        public static bool DeleteDriver(int DriverID)
        {
            int rowAffected = clsDriver_DAL.DeleteDriver(DriverID);

            return (rowAffected > 0);
        }

        public static DataTable GetListDrivers()
        {
            return clsDriver_DAL.GetListDrivers();
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddMode:
                    {
                        if (_AddNewDriver())
                        {
                            _Mode = enMode.enUpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.enUpdateMode:
                    {
                        if (_UpdateDriver())
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