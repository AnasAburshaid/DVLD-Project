using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DAL; 

namespace DVLD_BLL
{
    public class clsTestAppointments
    {
        public enum enMode { enAddMode = 0, enUpdateMode = 1 };
        public enMode _Mode;

        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public double PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; } 

        private clsTestAppointments(int testAppointmentID, int testTypeID, int localDrivingLicenseApplicationID,
            DateTime appointmentDate, double paidFees, int createdByUserID, bool isLocked, int retakeTestApplicationID)
        {
            this.TestAppointmentID = testAppointmentID;
            this.TestTypeID = testTypeID;
            this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.AppointmentDate = appointmentDate;
            this.PaidFees = paidFees;
            this.CreatedByUserID = createdByUserID;
            this.IsLocked = isLocked;
            this.RetakeTestApplicationID = retakeTestApplicationID;

            _Mode = enMode.enUpdateMode;
        }

        public clsTestAppointments()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = 1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1; 

            _Mode = enMode.enAddMode;
        }

        public static clsTestAppointments Find(int testAppointmentID)
        {
            int testTypeID = -1;
            int localDrivingLicenseApplicationID = -1;
            DateTime appointmentDate = DateTime.Now;
            double paidFees = 0;
            int createdByUserID = -1;
            bool isLocked = false;
            int retakeTestApplicationID = -1; 

            if (clsTestAppointments_DAL.GetTestAppointmentInfoByID(testAppointmentID, ref testTypeID,
                ref localDrivingLicenseApplicationID, ref appointmentDate, ref paidFees, ref createdByUserID, ref isLocked, ref retakeTestApplicationID))
            {
                return new clsTestAppointments(testAppointmentID, testTypeID, localDrivingLicenseApplicationID,
                    appointmentDate, paidFees, createdByUserID, isLocked, retakeTestApplicationID);
            }
            else
                return null;
        }

        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointments_DAL.AddNewTestAppointment(
                this.TestTypeID,
                this.LocalDrivingLicenseApplicationID, 
                this.AppointmentDate, 
                this.PaidFees, 
                this.CreatedByUserID, 
                this.IsLocked,
                this.RetakeTestApplicationID 
            );

            return (this.TestAppointmentID != -1);
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointments_DAL.UpdateTestAppointment(
                this.TestAppointmentID, 
                this.TestTypeID,
                this.LocalDrivingLicenseApplicationID, 
                this.AppointmentDate, 
                this.PaidFees, 
                this.CreatedByUserID, 
                this.IsLocked,
                this.RetakeTestApplicationID 
            );
        }

        public static bool DeleteTestAppointment(int testAppointmentID)
        {
            return clsTestAppointments_DAL.DeleteTestAppointment(testAppointmentID);
        }

        public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointments_DAL.GetApplicationTestAppointmentsPerTestType(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public static int GetNumOfTrails(int LocalAppID, int TestTypeID)
        {
            return clsTestAppointments_DAL.GetNumberOfTrailsOfTest(LocalAppID, TestTypeID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddMode:
                    {
                        if (_AddNewTestAppointment())
                        {
                            _Mode = enMode.enUpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.enUpdateMode:
                    {
                        if (_UpdateTestAppointment())
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