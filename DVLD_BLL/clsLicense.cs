using System;
using System.Data;
using DVLD_DAL;

namespace DVLD_BLL
{
    public class clsLicense
    {
        public enum enMode { enUpdateMode = 0, enAddMode = 1 };
        public enMode _Mode;

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public double PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

      
        public clsDriver DriverInfo { get; set; }

        private clsLicense(int licenseID, int applicationID, int driverID, int licenseClass,
            DateTime issueDate, DateTime expirationDate, string notes,
            double paidFees, bool isActive, byte issueReason, int createdByUserID)
        {
            this.LicenseID = licenseID;
            this.ApplicationID = applicationID;
            this.DriverID = driverID;
            this.LicenseClass = licenseClass;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.Notes = notes;
            this.PaidFees = paidFees;
            this.IsActive = isActive;
            this.IssueReason = issueReason;
            this.CreatedByUserID = createdByUserID;

            this.DriverInfo = clsDriver.Find(driverID);

            _Mode = enMode.enUpdateMode;
        }

        public clsLicense()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = true;
            this.IssueReason = 1; // 1 = First Time
            this.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            this.DriverInfo = new clsDriver();

            _Mode = enMode.enAddMode;
        }

        public static clsLicense Find(int LicenseID)
        {
            int applicationID = -1, driverID = -1, licenseClass = -1, createdByUserID = -1;
            DateTime issueDate = DateTime.Now, expirationDate = DateTime.Now;
            string notes = "";
            double paidFees = 0;
            bool isActive = true;
            byte issueReason = 1;

            if (clsLicense_DAL.GetLicenseInfoByID(LicenseID, ref applicationID, ref driverID, ref licenseClass,
                ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref createdByUserID))
            {
                return new clsLicense(LicenseID, applicationID, driverID, licenseClass,
                                      issueDate, expirationDate, notes, paidFees, isActive, issueReason, createdByUserID);
            }
            else
            {
                return null;
            }
        }
        private bool _AddNewLicense()
        {
            clsDriver ExistingDriver = clsDriver.FindByPersonID(this.DriverInfo.PersonID);

            if (ExistingDriver != null)
            {
                this.DriverID = ExistingDriver.DriverID;
                this.DriverInfo = ExistingDriver; 
            }
            else
            {
                if (!this.DriverInfo.Save())
                {
                    return false;
                }
                this.DriverID = this.DriverInfo.DriverID;
            }

            this.LicenseID = clsLicense_DAL.AddNewLicense(
                this.ApplicationID, this.DriverID, this.LicenseClass,
                this.IssueDate, this.ExpirationDate, this.Notes,
                this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID
            );

            return (this.LicenseID != -1);
        }
        private bool _UpdateLicense()
        {
            if (!this.DriverInfo.Save())
            {
                return false;
            }

            this.DriverID = this.DriverInfo.DriverID;

            int rowsAffected = clsLicense_DAL.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClass,
                this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);

            return (rowsAffected > 0);
        }

        public static int GetLisenceIDByApplicationID(int ApplicationID)
        {
            int LicenseID = clsLicense_DAL.GetLicenseIDByApplicationID(ApplicationID);
            return LicenseID;
        }

        public static DataTable GetHistoryLocalLicenses(int personid)
        {
            return clsLicense_DAL.GetListHistoryLocalLicenses(personid);
        }

        public static bool isPersonHasClass3License(int personid)
        {
            return clsLicense_DAL.IsPersonHasClass3License(personid);
        }

        public static bool IsThereActiveRenewDrvingLicense(int licenseid)
        {
            return clsLicense_DAL.IsThereActiveRenewDrivingLicense(licenseid);
          
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddMode:
                    {
                        if (_AddNewLicense())
                        {
                            _Mode = enMode.enUpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.enUpdateMode:
                    {
                        if (_UpdateLicense())
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