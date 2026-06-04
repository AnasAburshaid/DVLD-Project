using System;
using System.Data;
using DVLD_DAL;

namespace DVLD_BLL
{
    public class clsDetainedLicenses
    {
        public enum enMode { enUpdateMode = 0, enAddMode = 1 };
        private enMode _Mode;

        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public double FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }

        private clsDetainedLicenses(int detainID, int licenseID, DateTime detainDate, double fineFees,
            int createdByUserID, bool isReleased, DateTime? releaseDate, int? releasedByUserID, int? releaseApplicationID)
        {
            _Mode = enMode.enUpdateMode;

            this.DetainID = detainID;
            this.LicenseID = licenseID;
            this.DetainDate = detainDate;
            this.FineFees = fineFees;
            this.CreatedByUserID = createdByUserID;
            this.IsReleased = isReleased;
            this.ReleaseDate = releaseDate;
            this.ReleasedByUserID = releasedByUserID;
            this.ReleaseApplicationID = releaseApplicationID;
        }

        public clsDetainedLicenses()
        {
            _Mode = enMode.enAddMode;

            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0.0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = null;
            this.ReleasedByUserID = null;
            this.ReleaseApplicationID = null;
        }

        public static clsDetainedLicenses Find(int DetainID)
        {
            int LicenseID = -1, CreatedByUserID = -1;
            double FineFees = 0.0;
            bool IsReleased = false;
            DateTime DetainDate = DateTime.Now;

            DateTime? ReleaseDate = null;
            int? ReleasedByUserID = null, ReleaseApplicationID = null;

            if (clsDetainedLicenses_DAL.GetDetainedLicenseInfoByID(ref DetainID, ref LicenseID, ref DetainDate,
                ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicenses(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID,
                    IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewDetainedLicense()
        {
            this.DetainID = clsDetainedLicenses_DAL.AddNewDetainedLicense(this.LicenseID, this.DetainDate, this.FineFees,
                this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);

            return (this.DetainID != -1);
        }

        private bool _UpdateDetainedLicense()
        {
            int rowsAffected = clsDetainedLicenses_DAL.UpdateDetainedLicense(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees,
                this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);

            return (rowsAffected > 0);
        }

        public static bool DeleteDetainedLicense(int DetainID)
        {
            int rowsAffected = clsDetainedLicenses_DAL.DeleteDetainedLicense(DetainID);

            return (rowsAffected > 0);
        }

        public static DataTable GetListDetainedLicenses()
        {
            return clsDetainedLicenses_DAL.GetListDetainedLicenses();
        }

        public static bool IsDetainedLicenseExist(int DetainID)
        {
            return clsDetainedLicenses_DAL.IsDetainedLicenseExist(ref DetainID);
        }

        public static bool IsLicenseDetained(int licenseid)
        {
            return clsDetainedLicenses_DAL.IsLicenseIDDetained(licenseid);
        }

        public static clsDetainedLicenses FindDetainedInfoByLicenseID(int LicenseID)
        {
            int DetainID = -1, CreatedByUserID = -1;
            double FineFees = 0.0;
            bool IsReleased = false;
            DateTime DetainDate = DateTime.Now;

            DateTime? ReleaseDate = null;
            int? ReleasedByUserID = null, ReleaseApplicationID = null;

            if (clsDetainedLicenses_DAL.GetDetainedLicenseInfoByLicenseID(ref LicenseID, ref DetainID, ref DetainDate,
                ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicenses(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID,
                    IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
            {
                return null;
            }
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddMode:
                    {
                        if (_AddNewDetainedLicense())
                        {
                            _Mode = enMode.enUpdateMode;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.enUpdateMode:
                    {
                        if (_UpdateDetainedLicense())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
            }

            return false;
        }
    }
}