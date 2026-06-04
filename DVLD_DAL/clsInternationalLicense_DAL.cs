using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsInternationalLicense_DAL
    {
        public static bool GetInternationalLicenseInfoByID(int internationalLicenseID,
            ref int applicationID, ref int driverID, ref int issuedUsingLocalLicenseID,
            ref DateTime issueDate, ref DateTime expirationDate, ref bool isActive, ref int createdByUserID)
        {
            bool isFound = false;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @id";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@id", internationalLicenseID);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    applicationID = (int)reader["ApplicationID"];
                    driverID = (int)reader["DriverID"];
                    issuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    createdByUserID = (int)reader["CreatedByUserID"];
                    isFound = true;
                }
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

            return isFound;
        }
        public static bool GetInternationalLicenseInfoByLocalLicenseID(int issuedUsingLocalLicenseID,
          ref int applicationID, ref int driverID, ref int InternationalLicenseID,
          ref DateTime issueDate, ref DateTime expirationDate, ref bool isActive, ref int createdByUserID)
        {
            bool isFound = false;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "SELECT * FROM InternationalLicenses WHERE IssuedUsingLocalLicenseID = @id";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@id", issuedUsingLocalLicenseID);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    applicationID = (int)reader["ApplicationID"];
                    driverID = (int)reader["DriverID"];
                    InternationalLicenseID = (int)reader["InternationalLicenseID"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    createdByUserID = (int)reader["CreatedByUserID"];
                    isFound = true;
                }
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

            return isFound;
        }
        public static int AddNewInternationalLicense(int applicationID, int driverID, int issuedUsingLocalLicenseID,
            DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
            int internationalLicenseID = -1;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);

            string query = @"INSERT INTO InternationalLicenses 
                             VALUES (@applicationID, @driverID, @issuedUsingLocalLicenseID, @issueDate, @expirationDate, @isActive, @createdByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@applicationID", applicationID);
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@issuedUsingLocalLicenseID", issuedUsingLocalLicenseID);
            cmd.Parameters.AddWithValue("@issueDate", issueDate);
            cmd.Parameters.AddWithValue("@expirationDate", expirationDate);
            cmd.Parameters.AddWithValue("@isActive", isActive);
            cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    internationalLicenseID = id;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }

            return internationalLicenseID;
        }

        public static int UpdateInternationalLicense(int internationalLicenseID, int applicationID, int driverID,
            int issuedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
            int rowsAffected = 0;
            using (SqlConnection con = new SqlConnection(ConnectionSettings.connectionString))
            {
                string query = @"UPDATE InternationalLicenses 
                                 SET ApplicationID = @applicationID,
                                     DriverID = @driverID,
                                     IssuedUsingLocalLicenseID = @issuedUsingLocalLicenseID,
                                     IssueDate = @issueDate,
                                     ExpirationDate = @expirationDate,
                                     IsActive = @isActive,
                                     CreatedByUserID = @createdByUserID
                                 WHERE InternationalLicenseID = @internationalLicenseID;";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@internationalLicenseID", internationalLicenseID);
                cmd.Parameters.AddWithValue("@applicationID", applicationID);
                cmd.Parameters.AddWithValue("@driverID", driverID);
                cmd.Parameters.AddWithValue("@issuedUsingLocalLicenseID", issuedUsingLocalLicenseID);
                cmd.Parameters.AddWithValue("@issueDate", issueDate);
                cmd.Parameters.AddWithValue("@expirationDate", expirationDate);
                cmd.Parameters.AddWithValue("@isActive", isActive);
                cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);

                try
                {
                    con.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return rowsAffected;
        }

        public static int DeleteInternationalLicense(int internationalLicenseID)
        {
            int rowsAffected = 0;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "DELETE InternationalLicenses WHERE InternationalLicenseID = @id;";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", internationalLicenseID);

            try
            {
                con.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }

            return rowsAffected;
        }

        public static DataTable GetListInternationalLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);

            string query = @"SELECT InternationalLicenseID,ApplicationID,driverid,IssuedUsingLocalLicenseID,
                            IssueDate,ExpirationDate,IsActive FROM InternationalLicenses";

            SqlCommand cmd = new SqlCommand(query, con);

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
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }

            return dt;
        }

        public static DataTable GetInternationalLicenseInfoHistoryByPersonID(int personid)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);

            string query = @"SELECT InternationalLicenses.InternationalLicenseID as IntLicenceID, Applications.ApplicationID,
                            InternationalLicenses.IssuedUsingLocalLicenseID as LocalLicenseid , InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate,InternationalLicenses.IsActive
                            FROM     InternationalLicenses INNER JOIN
                                              Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID
                                              where Applications.ApplicantPersonID = @personid;";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@personid", personid);

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
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally { con.Close(); }

            return dt;

        }

    }
}