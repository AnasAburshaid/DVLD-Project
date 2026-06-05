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
    public class clsDetainedLicenses_DAL
    {
        public static bool GetDetainedLicenseInfoByID(ref int DetainID, ref int LicenseID, ref DateTime DetainDate,
            ref double FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate,
            ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select * from DetainedLicenses where DetainID = @id";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@id", DetainID);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = Convert.ToDouble(reader["FineFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];

                    if (reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                    else
                        ReleaseDate = null;

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    else
                        ReleasedByUserID = null;

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    else
                        ReleaseApplicationID = null;

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

        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, double FineFees,
            int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = @"insert into DetainedLicenses  
                             Values 
                             (@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased,@ReleaseDate,@ReleasedByUserID,@ReleaseApplicationID) ;
                              select SCOPE_IDENTITY();";

            int detainid = -1;

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);

            if (ReleaseDate.HasValue)
                cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate.Value);
            else
                cmd.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);

            if (ReleasedByUserID.HasValue)
                cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID.Value);
            else
                cmd.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);

            if (ReleaseApplicationID.HasValue)
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID.Value);
            else
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    detainid = id;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }

            return detainid;
        }

        public static int UpdateDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, double FineFees,
            int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            int RowsAffected = 0;
            using (SqlConnection con = new SqlConnection(ConnectionSettings.connectionString))
            {
                string query = @"Update DetainedLicenses 
                                 SET  LicenseID = @LicenseID,
                                      DetainDate = @DetainDate,
                                      FineFees = @FineFees,
                                      CreatedByUserID = @CreatedByUserID,
                                      IsReleased = @IsReleased,
                                      ReleaseDate = @ReleaseDate,
                                      ReleasedByUserID = @ReleasedByUserID,
                                      ReleaseApplicationID = @ReleaseApplicationID
                                 WHERE
                                      DetainID = @DetainID;";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@DetainID", DetainID);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
                cmd.Parameters.AddWithValue("@FineFees", FineFees);
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                cmd.Parameters.AddWithValue("@IsReleased", IsReleased);

                cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate.HasValue ? (object)ReleaseDate.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID.HasValue ? (object)ReleasedByUserID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID.HasValue ? (object)ReleaseApplicationID.Value : DBNull.Value);

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

        public static int DeleteDetainedLicense(int DetainID)
        {
            int RowAffected = 0;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = @"DELETE DetainedLicenses    
                            WHERE
                            DetainID = @DetainID;";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                con.Open();
                RowAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }

            return RowAffected;
        }

        public static DataTable GetListDetainedLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "select * from DetainedLicenses_View";
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

        public static bool IsLicenseIDDetained(int LicenseID)
        {
            bool isDetained = false;

            string query = "SELECT TOP 1 1 FROM DetainedLicenses WHERE LicenseID = @licenseID AND IsReleased = 0";

            using (SqlConnection con = new SqlConnection(ConnectionSettings.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@licenseID", LicenseID);

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            isDetained = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                }
            }

            return isDetained;
        }
        public static bool IsDetainedLicenseExist(ref int DetainID)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select 1 from DetainedLicenses where DetainID = @id";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@id", DetainID);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                isfound = reader.HasRows;
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

        public static bool GetDetainedLicenseInfoByLicenseID(ref int LicenseID, ref int DetainID, ref DateTime DetainDate,
            ref double FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate,
            ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select * from DetainedLicenses where LicenseID = @id and IsReleased = 0";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@id", LicenseID);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = Convert.ToDouble(reader["FineFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];

                    if (reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                    else
                        ReleaseDate = null;

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    else
                        ReleasedByUserID = null;

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    else
                        ReleaseApplicationID = null;

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
    }
}