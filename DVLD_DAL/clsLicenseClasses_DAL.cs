using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsLicenseClasses_DAL
    {
        public static bool GetLicenseClassByID(ref int LicenseClassID, ref string ClassName,
          ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength , ref double ClassFees)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select * from LicenseClasses where LicenseClassID = @id";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@id", LicenseClassID);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = Convert.ToDouble(reader["ClassFees"]);

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

        public static bool GetLicenseClassByClassName(ref int LicenseClassID, ref string ClassName,
          ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref double ClassFees)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select * from LicenseClasses where ClassName = @ClassName";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    LicenseClassID = (int)reader["LicenseClassID"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = Convert.ToDouble(reader["ClassFees"]);

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


        public static DataTable GetListLicenseClasses()
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select * from LicenseClasses;";
            SqlCommand command = new SqlCommand(query, con);

            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { con.Close(); }

            return dt;

        }


    }
}
