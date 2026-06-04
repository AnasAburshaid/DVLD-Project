using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsTest_DAL
    {
        public static bool GetTestInfoByID(int TestID, ref int TestAppointmentID,
            ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool isFound = false;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "SELECT * FROM Tests WHERE TestID = @TestID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                        Notes = "";

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

        // BONUS METHOD: You will absolutely need this to find out if an Appointment already has a Test!
        public static bool GetTestInfoByTestAppointmentID(int TestAppointmentID, ref int TestID,
            ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool isFound = false;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "SELECT * FROM Tests WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    TestID = (int)reader["TestID"];
                    TestResult = (bool)reader["TestResult"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                        Notes = "";

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

        public static int AddNewTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int TestID = -1;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);

            string query = @"INSERT INTO Tests 
                             (TestAppointmentID, TestResult, Notes, CreatedByUserID) 
                             VALUES 
                             (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            if (string.IsNullOrEmpty(Notes))
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@Notes", Notes);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    TestID = id;
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

            return TestID;
        }

        public static int UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int RowsAffected = 0;
            using (SqlConnection con = new SqlConnection(ConnectionSettings.connectionString))
            {
                string query = @"UPDATE Tests 
                                 SET TestAppointmentID = @TestAppointmentID,
                                     TestResult = @TestResult,
                                     Notes = @Notes,
                                     CreatedByUserID = @CreatedByUserID
                                 WHERE TestID = @TestID;";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@TestID", TestID);
                cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                cmd.Parameters.AddWithValue("@TestResult", TestResult);
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                if (string.IsNullOrEmpty(Notes))
                    cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@Notes", Notes);

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

            return RowsAffected;
        }

        public static int DeleteTest(int TestID)
        {
            int RowsAffected = 0;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);

            string query = @"DELETE FROM Tests WHERE TestID = @TestID;";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@TestID", TestID);

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

            return RowsAffected;
        }
    }
}