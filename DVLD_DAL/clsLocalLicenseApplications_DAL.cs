using DVLD_DAL.DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsLocalLicenseApplications_DAL
    {
        public static bool GetLocalLicenseApplicationByID(ref int LocalDrivingLicenseApplicationID, ref int ApplicationID,
         ref int LicenseClassID)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @id ";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@id", LocalDrivingLicenseApplicationID);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    isfound = true;
                }
                else
                    isfound = false;

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isfound;
        }

        public static int AddLocalLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query =
                @"insert into LocalDrivingLicenseApplications 
                 Values 
                 (@ApplicationID,@LicenseClassID) ;
                  select SCOPE_IDENTITY();";

            int LocalDrivingLicenseApplicationID = -1;

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    LocalDrivingLicenseApplicationID = id;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }

            return LocalDrivingLicenseApplicationID;

        }

        public static int UpdateLocalLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID,
          int LicenseClassID)
        {
            int RowsAffected = 0;
            using (SqlConnection con = new SqlConnection(ConnectionSettings.connectionString))
            {
                string query = @"Update LocalDrivingLicenseApplications 
                         SET  ApplicationID = @ApplicationID,
                              LicenseClassID = @LicenseClassID
                         WHERE
                              LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                try
                {
                    con.Open();
                    RowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return RowsAffected;
        }

        public static int DeleteLocalLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int rowsAffected = 0;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);

            string query = @"DELETE FROM Tests 
                             WHERE TestAppointmentID IN 
                             (SELECT TestAppointmentID FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID);
                            
                             DELETE FROM TestAppointments 
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;
                            
                             DELETE FROM LocalDrivingLicenseApplications 
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";


            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                con.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return rowsAffected;
        }

        public static DataTable GetListLocalLicenseApplication()
        {
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "select * from LocalDrivingLicenseApplications_View";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }
            return dt;
        }

        public static bool IsThereActiveApplication(int ApplicantPersonID, int LicenseClassID, byte ApplicationStatus)
        {
            bool Found = false;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);

            string query = @"SELECT top 1 found = 1 
                     FROM LocalDrivingLicenseApplications
                     JOIN Applications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                     WHERE ApplicantPersonID = @ApplicantPersonID 
                     AND LicenseClassID = @LicenseClassID   
                     AND ApplicationStatus = @ApplicationStatus;";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    Found = true;

                reader.Close(); 
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally { con.Close(); }

            return Found;
        }

        public static byte GetPassedTestsCount( int LocalDrivingLicenseAppID)
        {
            byte passedTests = 0;

            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string querey = @"Select count(testid) 
                            from Tests
                            join TestAppointments on TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            where TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseAppID
                            and Tests.TestResult = 1;";

            SqlCommand cmd = new SqlCommand(querey, con);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseAppID", LocalDrivingLicenseAppID);
            try
            {
                con.Open();

                object result = cmd.ExecuteScalar();
                if (result != null && byte.TryParse(result.ToString(), out byte tests))
                    passedTests = tests;
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally { con.Close(); }

                            
            return passedTests;
        }


    }
}
