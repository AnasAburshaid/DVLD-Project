using DVLD_DAL.DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DAL
{
    public class clsApplication_DAL
    {
        public static bool GetApplictionInfoByID(ref int ApplicationID, ref int applicantPersonID,
            ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate, ref double PaidFees,
            ref DateTime ApplicationDate, ref int CreatedByUserID)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select * from Applications where ApplicationID = @id";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@id", ApplicationID);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    applicantPersonID = (int)reader["applicantPersonID"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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

        public static int AddNewApplication(int applicantPersonID,
             int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate, double PaidFees,
             DateTime ApplicationDate, int CreatedByUserID)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query =
                @"insert into Applications  
                 Values 
                 (@applicantPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus,
                  @LastStatusDate,@PaidFees,@CreatedByUserID);
                  select SCOPE_IDENTITY();";

            int ApplicationID = -1;

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@applicantPersonID", applicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    ApplicationID = id;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }

            return ApplicationID;

        }


        public static int UpdateApplication(int ApplicationID, int applicantPersonID,
             int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate, double PaidFees,
             DateTime ApplicationDate, int CreatedByUserID)
        {
            int RowsAffected = 0;
            using (SqlConnection con = new SqlConnection(ConnectionSettings.connectionString))
            {
                string query = @"Update Applications 
                         SET  applicantPersonID = @applicantPersonID,
                              ApplicationTypeID = @ApplicationTypeID,
                              ApplicationStatus = @ApplicationStatus,
                              LastStatusDate = @LastStatusDate,
                              PaidFees = @PaidFees,
                              ApplicationDate = @ApplicationDate,
                              CreatedByUserID = @CreatedByUserID
                         WHERE
                              ApplicationID = @ApplicationID;";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                cmd.Parameters.AddWithValue("@applicantPersonID", applicantPersonID);
                cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
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

        public static int DeleteApplication(int ApplicationID)
        {
            int RowAffected = 0;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = @"DELETE Applications   
                            WHERE
                            ApplicationID = @ApplicationID;";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static int CancelApplication(int ApplicationID)
        {
            int RowAffected = 0;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = @"Update Applications 
                             Set ApplicationStatus = 2 where applicationid = @applicationid";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@applicationid", ApplicationID);
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

    }
}
