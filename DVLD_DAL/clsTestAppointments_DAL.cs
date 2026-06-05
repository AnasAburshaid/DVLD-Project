using DVLD_DAL.DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsTestAppointments_DAL
    {
        public static bool GetTestAppointmentInfoByID(int TestAppointmentID, ref int TestTypeID,
            ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate,
            ref double PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool isFound = false;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = Convert.ToBoolean(reader["IsLocked"]);

                    if (reader["RetakeTestApplicationID"] != DBNull.Value)
                    {
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                    }
                    else
                    {
                        RetakeTestApplicationID = -1;
                    }

                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isFound;
        }

        public static int AddNewTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID,
            DateTime AppointmentDate, double PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int TestAppointmentID = -1;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);

            string query = @"INSERT INTO TestAppointments 
                             (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID) 
                             VALUES 
                             (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);

            if (RetakeTestApplicationID != -1)
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            else
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    TestAppointmentID = id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return TestAppointmentID;
        }

        public static bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID,
            DateTime AppointmentDate, double PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int RowsAffected = 0;
            using (SqlConnection con = new SqlConnection(ConnectionSettings.connectionString))
            {
                string query = @"UPDATE TestAppointments 
                                 SET TestTypeID = @TestTypeID,
                                     LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                                     AppointmentDate = @AppointmentDate,
                                     PaidFees = @PaidFees,
                                     CreatedByUserID = @CreatedByUserID,
                                     IsLocked = @IsLocked,
                                     RetakeTestApplicationID = @RetakeTestApplicationID
                                 WHERE TestAppointmentID = @TestAppointmentID;";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                cmd.Parameters.AddWithValue("@IsLocked", IsLocked);

                if (RetakeTestApplicationID != -1)
                    cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
                else
                    cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);

                try
                {
                    con.Open();
                    RowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("DAL Error: " + ex.Message);
                }
            }

            return (RowsAffected > 0);
        }

        public static bool DeleteTestAppointment(int TestAppointmentID)
        {
            int RowsAffected = 0;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);

            string query = @"DELETE FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                con.Open();
                RowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return (RowsAffected > 0);
        }

        public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);

            string query = @"SELECT TestAppointmentID, AppointmentDate, PaidFees, IsLocked 
                             FROM TestAppointments 
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                             AND TestTypeID = @TestTypeID
                             ORDER BY TestAppointmentID DESC";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }

        public static int GetNumberOfTrailsOfTest(int localLicenseAppID, int testtypeID)
        {
            int Trails = 0;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);

            string query = @"SELECT count(*) as NumOfTrails 
                             FROM TestAppointments
                             WHERE LocalDrivingLicenseApplicationID = @localLicenseAppID
                             AND TestTypeID = @testtypeID
                             AND TestAppointments.IsLocked = 1";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@localLicenseAppID", localLicenseAppID);
            cmd.Parameters.AddWithValue("@testtypeID", testtypeID);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int number))
                {
                    Trails = number;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return Trails;
        }
    }
}