using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsTest
    {
        public enum enMode { enUpdateMode = 0, enAddMode = 1 };
        enMode _Mode;
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID {  get; set; }
        public clsTestAppointments TestAppointmentsInfo {  get; set; }

        private clsTest(int TestID, int TestAppointmentID, bool TestResult , string notes, int CreatedByUserID  )
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = notes;
            this.CreatedByUserID = CreatedByUserID;

            this.TestAppointmentsInfo = clsTestAppointments.Find(TestAppointmentID);
            
            _Mode = enMode.enUpdateMode;

        }
        public clsTest()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            this.TestAppointmentsInfo = new clsTestAppointments();
            
            _Mode = enMode.enAddMode;
        }

        public static clsTest Find(int TestID)
        {

            int TestAppointmentID = -1, createdByUserID = -1;
            bool TestResult = false;
            string notes = "";


            if (clsTest_DAL.GetTestInfoByID(TestID, ref TestAppointmentID, ref TestResult, ref notes , ref createdByUserID))
            {
                return new clsTest(TestID, TestAppointmentID, TestResult , notes , createdByUserID);
            }
            else
                return null;
        }

        public static clsTest FindTestByTestAppointmentID(int TestAppointmentID)
        {

            int TestID = -1, createdByUserID = -1;
            bool TestResult = false;
            string notes = "";


            if (clsTest_DAL.GetTestInfoByTestAppointmentID(TestAppointmentID, ref TestID, ref TestResult, ref notes, ref createdByUserID))
            {
                return new clsTest(TestID, TestAppointmentID, TestResult, notes, createdByUserID);
            }
            else
                return null;
        }

        private bool _AddNewTest()
        {
            if (!this.TestAppointmentsInfo.Save())
            {
                return false;
            }

            this.TestAppointmentID = this.TestAppointmentsInfo.TestAppointmentID;

            this.TestID = clsTest_DAL.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

            return (this.TestID != -1);


        }
        private bool _UpdateTest()
        {
            if (!this.TestAppointmentsInfo.Save())
            {
                return false;
            }

            this.TestAppointmentID = this.TestAppointmentsInfo.TestAppointmentID;

            int rowAffected = clsTest_DAL.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

            return (rowAffected > 0);
        }

        public static bool DeleteTest(int TestID)
        {
            int rowAffected = clsTest_DAL.DeleteTest(TestID);

            return (rowAffected > 0);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddMode:
                    {
                        if (_AddNewTest())
                        {
                            _Mode = enMode.enUpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.enUpdateMode:
                    {
                        if (_UpdateTest())
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
