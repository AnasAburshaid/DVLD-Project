using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsLocalLicenseApplications
    {
        public enum enMode { enUpdateMode = 0, enAddMode = 1 };
        enMode _Mode;
        public int LocalDrivingLicenseApplicationID {  get; set; }
        public int ApplicationID {  get; set; }
        public int LicenseClassID { get; set; }

        public clsApplication ApplicationInfo { get; set; }

        private clsLocalLicenseApplications(int LocalDrivingLicenseApplicationID , int ApplicationId,int LicenseClassId)
        {

            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationId;
            this.LicenseClassID = LicenseClassId;
            this.ApplicationInfo = clsApplication.Find(ApplicationId);

            _Mode = enMode.enUpdateMode;

        }
        public clsLocalLicenseApplications()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID= -1;
            this.ApplicationInfo = new clsApplication();

            this.ApplicationInfo.ApplicationTypeID = 1;
            clsApplicationTypes ApplicationType = clsApplicationTypes.Find(this.ApplicationInfo.ApplicationTypeID);
            if (ApplicationType != null)
            {
                this.ApplicationInfo.PaidFees = ApplicationType.ApplicationFees;
            }
            this.ApplicationInfo.ApplicationDate = DateTime.Now;
            this.ApplicationInfo.ApplicationStatus = 1;
            this.ApplicationInfo.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            _Mode = enMode.enAddMode;
        }

        public static clsLocalLicenseApplications Find(int LocalDrivingLicenseApplicationID)
        {

            int ApplicationID = -1, LicenseClassID = -1;

            if (clsLocalLicenseApplications_DAL.GetLocalLicenseApplicationByID(ref LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID)) 
            {
                return new clsLocalLicenseApplications(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            }
            else
                return null;
        }

        private bool _AddNewLocalLicenseApplication()
        {
            if (!this.ApplicationInfo.Save())
            {
                return false;
            }

            this.ApplicationID = this.ApplicationInfo.ApplicationID;

            this.LocalDrivingLicenseApplicationID = clsLocalLicenseApplications_DAL.AddLocalLicenseApplication(this.ApplicationID, this.LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID != -1); 


        }

        private bool _UpdateLocalLicenseApplication()
        {
            if (!this.ApplicationInfo.Save())
            {
                return false;
            }
            this.ApplicationID = this.ApplicationInfo.ApplicationID;

            int rowAffected = clsLocalLicenseApplications_DAL.UpdateLocalLicenseApplication(this.LocalDrivingLicenseApplicationID,this.ApplicationID, this.LicenseClassID);

            return (rowAffected > 0);
        }

        public static bool DeleteLocalLicenseApplication(int LocalLicenseApplicationID)
        {
            int rowAffected = clsLocalLicenseApplications_DAL.DeleteLocalLicenseApplication(LocalLicenseApplicationID);

            return (rowAffected > 0);
        }

        public static DataTable GetListLocalLicenseApplication()
        {
            return clsLocalLicenseApplications_DAL.GetListLocalLicenseApplication();
        }

        public static bool IsThereActiveApplication(int AppliciantPersonID , int LicenseClassID , byte ApplicationStatus)
        {
            return clsLocalLicenseApplications_DAL.IsThereActiveApplication( AppliciantPersonID,  LicenseClassID,  ApplicationStatus);
        }

        public static bool CancelLocalLicenseApplication(int LocalLicenseApplicationID)
        {
            clsLocalLicenseApplications LocalApp = clsLocalLicenseApplications.Find(LocalLicenseApplicationID);
            int AffectedRows = 0;

            if (LocalApp != null)
            {
                if (LocalApp.ApplicationInfo.ApplicationStatus != 3)
                    AffectedRows = clsApplication_DAL.CancelApplication(LocalApp.ApplicationID);
                else
                    return false;
            }

            return (AffectedRows != -1);
        }

        public static int GetNumberOfPassedTests(int LocalLicenseAppID)
        {
            return clsLocalLicenseApplications_DAL.GetPassedTestsCount(LocalLicenseAppID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddMode:
                    {
                        if (_AddNewLocalLicenseApplication())
                        {
                            _Mode = enMode.enUpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.enUpdateMode:
                    {
                        if (_UpdateLocalLicenseApplication())
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
