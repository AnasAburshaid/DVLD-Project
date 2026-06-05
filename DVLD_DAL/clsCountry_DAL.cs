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
    public class clsCountry_DAL
    {
        public static bool GetCountryInfoByID(ref int countryid, ref string countryname)
        {

            bool Isfound = false;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select * from countries where countryid = @countryid";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@countryid", countryid);

            try
            {
                con.Open();
                SqlDataReader r = command.ExecuteReader();

                if (r.Read())
                {
                    Isfound = true;
                    countryid = (int)r["countryid"];
                    countryname = (string)r["countryname"];
                }
                r.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return Isfound;
        }

        public static bool GetCountryInfoByName(ref int countryid, ref string countryname)
        {

            bool Isfound = false;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select * from countries where countryname = @countryname";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@countryname", countryname);

            try
            {
                con.Open();
                SqlDataReader r = command.ExecuteReader();

                if (r.Read())
                {
                    Isfound = true;
                    countryid = (int)r["countryid"];
                    countryname = (string)r["countryname"];
                }
                r.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return Isfound;
        }

        public static bool IsCountryExist(int countryid)
        {
            bool Isfound = false;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select 1 from countries where countryid = @countryid";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@countryid", countryid);

            try
            {
                con.Open();
                SqlDataReader r = command.ExecuteReader();

                Isfound = r.HasRows;
                r.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return Isfound;
        }

        public static bool IsCountryExist(string countryname)
        {
            bool Isfound = false;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select 1 from countries where countryname = @countryname";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@countryname", countryname);

            try
            {
                con.Open();
                SqlDataReader r = command.ExecuteReader();

                Isfound = r.HasRows;
                r.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return Isfound;
        }


        public static int AddNewCountry(string countryname)
        {
            int countryid = -1;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = @"Insert into countries " +
                            "values (@countryname );" +
                            " select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@countryname", countryname);
        
            try
            {
                con.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int id))
                {
                    countryid = id;
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

            return countryid;
        }
        public static bool DeleteCountry(int countryid)
        {
            int RowsAffected = 0;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = @"Delete countries " +
                            "WHERE countryid = @countryid;";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@countryid", countryid);

            try
            {
                con.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return (RowsAffected > 0);
        }

        public static bool UpdateContact(int countryid, string countryname)
        {
            int RowsAffected = 0;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = @"Update countries
                            SET countryname = @countryname , 
                            Where countryid = @countryid ;";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@countryid", countryid);
            command.Parameters.AddWithValue("@countryname", countryname);
         
            try
            {
                con.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return (RowsAffected > 0);
        }

        public static DataTable GetAllCountries()
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select * from countries ";
            SqlCommand command = new SqlCommand(query, con);

            DataTable dt = new DataTable();

            try
            {
                con.Open();
                SqlDataReader r = command.ExecuteReader();
                if (r.HasRows)
                    dt.Load(r);

                r.Close();
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

    }
}
