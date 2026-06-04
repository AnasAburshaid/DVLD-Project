using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsUser_DAL
    {
        public static bool GetUserInfoByID(ref int userid,ref int personid, ref string username,
           ref string password , ref bool isActive)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select * from Users where Userid = @id";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@id", userid);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    personid = (int)reader["Personid"];
                    username = (string)reader["username"];
                    password = (string)reader["password"];
                    isActive = Convert.ToBoolean(reader["IsActive"]);
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

        public static int AddNewUser(int personid, string username,
           string password, bool isactive)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query =
                @"insert into Users 
                 Values 
                 (@personid,@username,@password,@isactive) ;
                  select SCOPE_IDENTITY();";

            int UserId = -1;

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@personid", personid);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@isactive", isactive);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    UserId = id;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }

            return UserId;

        }

        public static int UpdateUser(int userid, int personid, string username,
           string password, bool isactive)
        {
            int RowsAffected = 0;
            using (SqlConnection con = new SqlConnection(ConnectionSettings.connectionString))
            {
                string query = @"Update Users 
                         SET  PersonID = @personid,
                              Username = @username,
                              Password = @password,
                              IsActive = @isactive
                         WHERE
                              UserID = @userid;";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@personid", personid);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@isactive", isactive);

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

        public static int DeleteUser(int userid)
        {
            int RowAffected = 0;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = @"DELETE Users   
                            WHERE
                            UserID = @userid;";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@userid", userid);

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

        public static DataTable GetListUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "SELECT " +
                            "Users.UserID, " +
                            "Users.PersonID, " +
                            "CONCAT_WS(' ', People.FirstName, People.SecondName, People.ThirdName, People.LastName) AS Fullname, " +
                            "Users.UserName as Username, " +
                            "Users.IsActive " +           
                            "FROM People " +              
                            "INNER JOIN Users ON People.PersonID = Users.PersonID;";

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

        public static bool IsUserExist(ref int userid)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select 1 from Users where UserID = @id";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@id", userid);

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

       public static bool GetUserInfoByUsernameAndPassword(ref string username,ref string password , ref bool isActive 
           ,ref int userid , ref int personid)
        {
            bool isFound = false;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "select * from users where username=@username and password=@password";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            
            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    userid = (int)reader["userid"];
                    personid = (int)reader["Personid"];
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    isFound = true;

                }
                else
                    isFound = false;

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

    }
}
