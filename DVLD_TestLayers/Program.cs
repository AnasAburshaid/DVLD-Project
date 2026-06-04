using DVLD_BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace DVLD_TestLayers
{

   

    internal class Program
    {
        public static void FindPersonByID(int personid)
        {
            
            clsPerson person = clsPerson.Find(personid);

            if (person != null)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Person ID: " + person.PersonID);
                Console.WriteLine("National No: " + person.NationalNo);
                Console.WriteLine("Name: " + person.FirstName + " " + person.SecondName + " " + person.LastName);
                Console.WriteLine("Date Of Birth: " + person.DateOfBirth);
                Console.WriteLine("Gender: " + person.Gendor);
                Console.WriteLine("Address: " + person.Address);
                Console.WriteLine("Phone: " + person.Phone);
                Console.WriteLine("Email: " + person.Email);
                Console.WriteLine("Nationality ID: " + person.NationalityCountryID);
                Console.WriteLine("Image Path: " + person.ImagePath);
            }
            else
            {
                Console.WriteLine("Person with ID " + personid + " not found ");
            }
        }

        public static void FindPersonByNarionalNo(string NationalNo)
        {
            clsPerson person = clsPerson.Find(NationalNo);

            if (person != null)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("National No: " + person.NationalNo);
                Console.WriteLine("Person ID: " + person.PersonID);
                Console.WriteLine("Name: " + person.FirstName + " " + person.SecondName + " " + person.LastName);
                Console.WriteLine("Date Of Birth: " + person.DateOfBirth);
                Console.WriteLine("Gender: " + person.Gendor);
                Console.WriteLine("Address: " + person.Address);
                Console.WriteLine("Phone: " + person.Phone);
                Console.WriteLine("Email: " + person.Email);
                Console.WriteLine("Nationality ID: " + person.NationalityCountryID);
                Console.WriteLine("Image Path: " + person.ImagePath);
            }
            else
            {
                Console.WriteLine("Person with NationalNO (" + NationalNo + ") not found ");
            }
        }

        public static void TestAddNewPerson()
        {
            clsPerson person = new clsPerson();

            person.NationalNo = "N5";
            person.FirstName = "Anas";
            person.SecondName = "Amjad";
            person.ThirdName = "Subhi";
            person.LastName = "Aburshaid";
            person.NationalityCountryID = 90;
            person.DateOfBirth = new DateTime(2004, 5, 11);
            person.Address = "Amman";
            person.Email = "anasabushaid@gmail.com";
            person.ImagePath = "";
            person.Gendor = 0;

            if(person.Save())
            {
                Console.WriteLine("Person Added PersonID = " + person.PersonID);
            }
            else
            {
                Console.WriteLine("Error Not Added");
            }
        }

        public static void TestUpdatePerson()
        {
            clsPerson person = clsPerson.Find(1023);

            person.FirstName = "Omar";
            person.SecondName = "emad";
            person.ThirdName = "";
            person.LastName = "mahsiri";
            person.NationalityCountryID = 90;
            person.DateOfBirth = new DateTime(2005, 2, 22);
            person.Address = "Amman";
            person.Email = "onaremad@gmail.com";
            person.ImagePath = "";
            person.Gendor = 0;

            if(person.Save())
            {
                Console.WriteLine("Person with id " + person.PersonID + " updated");
            }
            else
            {
                Console.WriteLine("something went wrong");
            }

        }
        
        //public static void TestDeletePerson()
        //{
        //    clsPerson person = clsPerson.Find(1028);

        //    person.DeletePerson();

        //}

        public static void TestListPeople()
        {
            DataTable dt = clsPerson.GetListpeople();

            Console.WriteLine("\n------- DVLD People Data List -------");

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Person ID    : " + row["PersonID"]);

                // Use 'NationalNo'
                Console.WriteLine("National No  : " + row["NationalNo"]);

                string fullName = row["FirstName"].ToString() + " " +
                                  row["SecondName"].ToString() + " " +
                                  row["ThirdName"].ToString() + " " +
                                  row["LastName"].ToString();
                Console.WriteLine("Full Name    : " + fullName.Trim());

                string gender = (Convert.ToInt32(row["Gendor"]) == 0) ? "Male" : "Female";
                Console.WriteLine("Gender       : " + gender);

                Console.WriteLine("DateOfBirth  : " + Convert.ToDateTime(row["DateOfBirth"]).ToShortDateString());

                Console.WriteLine("Phone        : " + row["Phone"]);
                Console.WriteLine("Email        : " + row["Email"]);
                Console.WriteLine("Address      : " + row["Address"]);
                Console.WriteLine("--------------------------------------------------");
            }

 

        }

        public static void testIsPersonExist(int personid)
        {
            if (clsPerson.IsPersonExist(personid))
            {
                Console.WriteLine("Found");
            }
            else { Console.WriteLine("Not found"); }
        }

        public static void FindUserByID(int UserId)
        {

            clsUser User = clsUser.Find(UserId);
            if (User != null)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Person ID: " + User.PersonID);
                Console.WriteLine("Username: " + User.Username);
                Console.WriteLine("Pasword: " + User.Password);
                Console.WriteLine("UserID: " + User.UserID);
                Console.WriteLine("IsActive: " +User.IsActive);
             
            }
            else
            {
                Console.WriteLine("User with ID " + UserId + " not found ");
            }
        }
        static void Main(string[] args)
        {
            FindUserByID(15);
        }
    }
}
