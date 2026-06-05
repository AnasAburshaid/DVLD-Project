using DVLD_DAL.DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsPeople_DAL
    {
        public static bool GetPersonInfoByID(ref int PersonID, ref string NationalNo,
            ref string firstname, ref string SecondName, ref string ThirdName, ref string lastname,
            ref DateTime dateofbirth, ref int Gendor, ref string address, ref string phone, ref string email,
            ref int NationalityCountryID, ref string imagepath)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select * from People where PersonID = @id";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@id", PersonID);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    NationalNo = (string)reader["NationalNO"];
                    firstname = (string)reader["firstname"];
                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["thirdname"];
                    else
                        ThirdName = "";

                    lastname = (string)reader["lastname"];
                    dateofbirth = (DateTime)reader["dateofbirth"];
                    Gendor = Convert.ToInt32(reader["Gendor"]);
                    address = (string)reader["address"];
                    phone = (string)reader["phone"];

                    if (reader["email"] != DBNull.Value)
                        email = (string)reader["email"];
                    else
                        email = "";

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    if (reader["imagepath"] != DBNull.Value)
                    {
                        imagepath = (string)reader["imagepath"];
                    }
                    else
                        imagepath = "";

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

        public static bool GetPersonInfoByNationalNO(ref int PersonID, ref string NationalNo,
            ref string firstname, ref string SecondName, ref string ThirdName, ref string lastname,
            ref DateTime dateofbirth, ref int Gendor, ref string address, ref string phone, ref string email,
            ref int NationalityCountryID, ref string imagepath)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select * from People where NationalNo = @NO";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@NO", NationalNo);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    firstname = (string)reader["firstname"];
                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["thirdname"];
                    else
                        ThirdName = "";

                    lastname = (string)reader["lastname"];
                    dateofbirth = (DateTime)reader["dateofbirth"];
                    Gendor = Convert.ToInt32(reader["Gendor"]);
                    address = (string)reader["address"];
                    phone = (string)reader["phone"];

                    if (reader["email"] != DBNull.Value)
                        email = (string)reader["email"];
                    else
                        email = "";

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    if (reader["imagepath"] != DBNull.Value)
                    {
                        imagepath = (string)reader["imagepath"];
                    }
                    else
                        imagepath = "";

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

        public static int AddNewPerosn(string NationalNo, string firstname, string secondname, string thirdname, string lastname,
            DateTime dateofbirth, int gendor, string address, string phone, string email, int nationalityCountryid, string imagepath)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query =
                @"insert into people  
                 Values 
                 (@nationalno,@firstname,@secondname,@thirdname,@lastname,@dateofbirth,@gendor,@address,@phone,
                  @email,@nationalcountryid,@imagepath) ;
                  select SCOPE_IDENTITY();";

            int personid = -1;

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nationalno", NationalNo);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@secondname", secondname);

            if (thirdname != "")
            {
                cmd.Parameters.AddWithValue("@thirdname", thirdname);
            }
            else
                cmd.Parameters.AddWithValue("@thirdname", DBNull.Value);
            
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
            cmd.Parameters.AddWithValue("@gendor", gendor);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);

            if (email != "")
            {
                cmd.Parameters.AddWithValue("@email", email);
            }
            else
                cmd.Parameters.AddWithValue("@email", DBNull.Value);

            cmd.Parameters.AddWithValue("@nationalcountryid", nationalityCountryid);

            if (imagepath != "")
            {
                cmd.Parameters.AddWithValue("@imagepath", imagepath);
            }
            else
                cmd.Parameters.AddWithValue("@imagepath", DBNull.Value);
            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    personid = id;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }

            return personid;

        }

        public static int UpdatePerson(int PersonID, string NationalNo, string firstname, string secondname, string thirdname, string lastname,
         DateTime dateofbirth, int gendor, string address, string phone, string email, int nationalityCountryid, string imagepath)
        {
            int RowsAffected = 0;
            using (SqlConnection con = new SqlConnection(ConnectionSettings.connectionString))
            {
                string query = @"Update People 
                         SET  NationalNo = @nationalno,
                              FirstName = @firstname,
                              SecondName = @secondname,
                              ThirdName = @thirdname,
                              LastName = @lastname,
                              DateOfBirth = @dateofbirth,
                              Gendor = @gendor,
                              Address = @address,
                              Phone = @phone,
                              Email = @email,
                              NationalityCountryID = @nationalitycountryid,
                              ImagePath = @imagepath
                         WHERE
                              PersonID = @personid;";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@personid", PersonID); 
                cmd.Parameters.AddWithValue("@nationalno", NationalNo);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@secondname", secondname);

                cmd.Parameters.AddWithValue("@thirdname", string.IsNullOrEmpty(thirdname) ? (object)DBNull.Value : thirdname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
                cmd.Parameters.AddWithValue("@gendor", gendor);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);

                cmd.Parameters.AddWithValue("@nationalitycountryid", nationalityCountryid);

                cmd.Parameters.AddWithValue("@imagepath", string.IsNullOrEmpty(imagepath) ? (object)DBNull.Value : imagepath);

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

        
        public static int DeletePerson(int PersonID)
        {
            int RowAffected = 0;
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = @"DELETE People   
                            WHERE
                            Personid = @personid;";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@personid", PersonID);

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

        public static DataTable GetListPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "SELECT People.PersonID, People.NationalNo, People.FirstName," +
                " People.SecondName, People.ThirdName, People.LastName, People.DateOfBirth, People.Gendor," +
                " Countries.CountryName as Nationality, People.Phone, People.Email FROM People JOIN"+
                 " Countries ON People.NationalityCountryID = Countries.CountryID";

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

        public static bool IsPersonExist(ref int PersonID)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select 1 from People where PersonID = @id";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@id", PersonID);

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

        public static bool IsPersonExist(ref string NationalNumber)
        {
            SqlConnection con = new SqlConnection(ConnectionSettings.connectionString);
            string query = "Select 1 from People where Nationalno = @id";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@id", NationalNumber);

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


    }
}



