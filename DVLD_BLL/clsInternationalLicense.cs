using System;
using System.Data;
using DVLD_DAL;

namespace DVLD_BLL
{
    public class clsInternationalLicense
    {
        public enum enMode { enUpdateMode = 0, enAddMode = 1 };
        public enMode _Mode;

        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsApplication ApplicationInfo { get; set; }

        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate,
            bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;

            this.ApplicationInfo = clsApplication.Find(ApplicationID);

            _Mode = enMode.enUpdateMode;
        }

        public clsInternationalLicense()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now.AddYears(1);
            this.IsActive = true;
            this.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            this.ApplicationInfo = new clsApplication();

            this.ApplicationInfo.ApplicationStatus = 3;
            this.ApplicationInfo.ApplicationTypeID = 6;
            this.ApplicationInfo.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            _Mode = enMode.enAddMode;
        }

        public static clsInternationalLicense Find(int InternationalLicenseID)
        {
            int ApplicationID = -1, DriverID = -1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = true;
            
            if(clsInternationalLicense_DAL.GetInternationalLicenseInfoByID(InternationalLicenseID,
                ref ApplicationID , ref DriverID , ref IssuedUsingLocalLicenseID , ref IssueDate,
                ref ExpirationDate , ref IsActive , ref CreatedByUserID))
            {
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID,
                                                   IssuedUsingLocalLicenseID, IssueDate, ExpirationDate,
                                                   IsActive, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static clsInternationalLicense FindInternationalLicenseByLocalLicenseID(int LocallicenseID)
        {
            int ApplicationID = -1, DriverID = -1, InternationalLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = true;

            if (clsInternationalLicense_DAL.GetInternationalLicenseInfoByLocalLicenseID(LocallicenseID,
                ref ApplicationID, ref DriverID, ref InternationalLicenseID, ref IssueDate,
                ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID,
                                                   LocallicenseID, IssueDate, ExpirationDate,
                                                   IsActive, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewInternationalLicense()
        {
          
            if (!this.ApplicationInfo.Save())
            {
                return false;
            }

            this.ApplicationID = this.ApplicationInfo.ApplicationID;

            this.InternationalLicenseID = clsInternationalLicense_DAL.AddNewInternationalLicense(
                this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID,
                this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return (this.InternationalLicenseID != -1);
        }

        private bool _UpdateInternationalLicense()
        {
            if (!this.ApplicationInfo.Save())
            {
                return false;
            }

            int RowsAffected = clsInternationalLicense_DAL.UpdateInternationalLicense(
                this.InternationalLicenseID, this.ApplicationID, this.DriverID,
                this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate,
                this.IsActive, this.CreatedByUserID);

            return (RowsAffected > 0);
        }

        public static DataTable GetHistoryInternatioanlLicense(int personid)
        {
            return clsInternationalLicense_DAL.GetInternationalLicenseInfoHistoryByPersonID(personid);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddMode:
                    if (_AddNewInternationalLicense())
                    {
                        _Mode = enMode.enUpdateMode;
                        return true;
                    }
                    else
                        return false;

                case enMode.enUpdateMode:
                    return _UpdateInternationalLicense();
            }

            return false;
        }

        public static bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            return (clsInternationalLicense_DAL.DeleteInternationalLicense(InternationalLicenseID) > 0);
        }

        public static DataTable GetListInternationalLicenses()
        {
            return clsInternationalLicense_DAL.GetListInternationalLicenses();
        }

    }
}