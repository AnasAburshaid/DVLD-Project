using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DAL
{
    public class clsLicense_DAL
    {
        public static bool GetLicenseInfoByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass,
            ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes,
            ref double PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            bool isFound = false;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                        Notes = "";

                    PaidFees = Convert.ToDouble(reader["PaidFees"]);

                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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

        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes,
            double PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);

            string query = @"INSERT INTO Licenses 
                             (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                             VALUES 
                             (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

            if (string.IsNullOrEmpty(Notes))
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@Notes", Notes);

            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    LicenseID = id;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return LicenseID;
        }

        public static int UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes,
            double PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int RowsAffected = 0;
            using (SqlConnection con = new SqlConnection(ConnectionSettings.connectionString))
            {
                string query = @"UPDATE Licenses 
                                 SET ApplicationID = @ApplicationID,
                                     DriverID = @DriverID,
                                     LicenseClass = @LicenseClass,
                                     IssueDate = @IssueDate,
                                     ExpirationDate = @ExpirationDate,
                                     Notes = @Notes,
                                     PaidFees = @PaidFees,
                                     IsActive = @IsActive,
                                     IssueReason = @IssueReason,
                                     CreatedByUserID = @CreatedByUserID
                                 WHERE LicenseID = @LicenseID;";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                cmd.Parameters.AddWithValue("@DriverID", DriverID);
                cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

                if (string.IsNullOrEmpty(Notes))
                    cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@Notes", Notes);

                cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                cmd.Parameters.AddWithValue("@IsActive", IsActive);
                cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static int DeleteLicense(int LicenseID)
        {
            int RowsAffected = 0;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);

            string query = @"DELETE FROM Licenses WHERE LicenseID = @LicenseID;";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                con.Open();
                RowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return RowsAffected;
        }

        public static DataTable GetListLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);

            string query = "SELECT * FROM Licenses";
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
            finally
            {
                con.Close();
            }
            return dt;
        }

        public static int GetLicenseIDByApplicationID(int ApplicationID)
        {
            int LicenseID = -1;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = @"Select LicenseID from Licenses where ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    LicenseID = id;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { con.Close(); }

            return LicenseID;
        }
     


        public static DataTable GetListHistoryLocalLicenses(int personid)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);

            string query = @"SELECT 
                            Licenses.LicenseID, 
                            Applications.ApplicationID, 
                            LicenseClasses.ClassName, 
                            Licenses.IssueDate, 
                            Licenses.ExpirationDate, 
                            Licenses.IsActive
                        FROM Applications 
                        INNER JOIN Licenses 
                            ON Applications.ApplicationID = Licenses.ApplicationID 
                        INNER JOIN LicenseClasses 
                            ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                        WHERE Applications.ApplicantPersonID = @personid
                        ORDER BY Licenses.IsActive DESC, Licenses.IssueDate DESC;";

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public static bool IsPersonHasClass3License(int personid)
        {
            bool isfound = false;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = @"SELECT TOP 1 Found = 1
                            FROM Licenses 
                            JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                            JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
                            WHERE Drivers.PersonID = @personid
                              AND LicenseClasses.LicenseClassID >= 3 
                              AND Licenses.IsActive = 1;";

            SqlCommand cmd = new SqlCommand(@query, con);
            cmd.Parameters.AddWithValue("@personid", personid);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    isfound = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { con.Close(); }

            return isfound;
        }

        public static bool IsThereActiveRenewDrivingLicense(int LicenseID)
        {
            bool hasActiveRenew = false;

            string query = @"SELECT TOP 1 1 FROM Licenses
                     WHERE DriverID = (SELECT DriverID FROM Licenses WHERE LicenseID = @LicenseID)
                       AND LicenseClass = (SELECT LicenseClass FROM Licenses WHERE LicenseID = @LicenseID)
                       AND IsActive = 1
                       AND LicenseID > @LicenseID";

            using (SqlConnection con = new SqlConnection(ConnectionSettings.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            hasActiveRenew = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return hasActiveRenew;
        }



    }
}