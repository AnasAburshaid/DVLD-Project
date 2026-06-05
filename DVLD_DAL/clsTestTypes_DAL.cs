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
    public class clsTestTypes_DAL
    {
        public static bool GetTestType(ref int TestTypeID, ref string TestTypeTitle,ref string TestTypeDescription,
         ref double TestTypeFees)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "select * from TestTypes where TestTypeID = @id ";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@id", TestTypeID);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees = Convert.ToDouble(reader["TestTypeFees"]);
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

        public static int UpdateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, double TestTypeFees)
        {
            int RowsAffected = 0;
            using (SqlConnection con = new SqlConnection(ConnectionSettings.connectionString))
            {
                string query = @"Update TestTypes 
                         SET  TestTypeTitle = @TestTypeTitle,
                              TestTypeDescription = @TestTypeDescription,
                              TestTypeFees = @TestTypeFees 
                         WHERE
                              TestTypeID = @TestTypeID;";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                cmd.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                cmd.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
                cmd.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);


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

        public static DataTable GetListTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "select * from TestTypes";

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
