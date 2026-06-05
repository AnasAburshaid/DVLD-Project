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
    public class clsApplicationTypes_DAL
    {
        public static bool GetApplicationType(ref int ApplicationTypeID, ref string ApplicationTypeTitle,
          ref double ApplicationFees)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "select * from ApplicationTypes where applicationtypeid = @id ";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@id", ApplicationTypeID);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = Convert.ToDouble(reader["ApplicationFees"]);
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

        public static int UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, double ApplicationFees)
        {
            int RowsAffected = 0;
            using (SqlConnection con = new SqlConnection(ConnectionSettings.connectionString))
            {
                string query = @"Update ApplicationTypes 
                         SET  ApplicationTypeTitle = @ApplicationTypeTitle,
                              ApplicationFees = @ApplicationFees
                         WHERE
                              ApplicationTypeID = @ApplicationTypeID;";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
                cmd.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
          
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

        public static DataTable GetListApplicationTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "select * from applicationTypes";

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

    }
}
