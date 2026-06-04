using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DVLD_DAL;
namespace DVLD_BLL
{
    public class clsPerson
    {
        public enum enMode { enUpdateMode = 0, enAddMode = 1 };
        enMode _Mode;
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }



        private clsPerson(int personid, string nationalno, string firstname, string secondname, string thirdname,
      string lastname, DateTime dateofbirth, int gendor, string address, string phone,
      string email, int nationalitycountryid, string imagepath)
        {
            _Mode = enMode.enUpdateMode;

            this.PersonID = personid;
            this.NationalNo = nationalno;
            this.FirstName = firstname;       
            this.SecondName = secondname;     
            this.ThirdName = thirdname;       
            this.LastName = lastname;         
            this.DateOfBirth = dateofbirth;
            this.Gendor = gendor;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalityCountryID = nationalitycountryid;
            this.ImagePath = imagepath;
        }
        public clsPerson()
        {

            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = -1;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            _Mode = enMode.enAddMode;
        }

        public static clsPerson Find(int personID)
        {
            string NationalNo = "", FirstName = "", SecondName = "" ,
            ThirdName = "",  LastName = "", Address = "" ,Phone = "" , Email = "", ImagePath = "";
            int Gendor = -1, NationalityCountryID = -1;
            DateTime DateOfBirth = DateTime.Now;

            if (clsPeople_DAL.GetPersonInfoByID(ref personID, ref NationalNo, ref FirstName,
                ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone,
                ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(personID, NationalNo, FirstName, SecondName,ThirdName,LastName, DateOfBirth, Gendor, Address,
                     Phone, Email, NationalityCountryID, ImagePath);
            }
            else
                 return null; 
        }
        public static clsPerson Find(string NationalNO)
        {
            string FirstName = "", SecondName = "",
            ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            int Gendor = -1, NationalityCountryID = -1, PersonID = -1;
            DateTime DateOfBirth = DateTime.Now;

            if (clsPeople_DAL.GetPersonInfoByNationalNO(ref PersonID, ref NationalNO, ref FirstName,
                ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone,
                ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNO, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address,
                     Phone, Email, NationalityCountryID, ImagePath);
            }
            else
                return null;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPeople_DAL.AddNewPerosn(this.NationalNo,this.FirstName,this.SecondName,this.ThirdName,
                this.LastName,this.DateOfBirth,this.Gendor,this.Address,this.Phone,this.Email,this.NationalityCountryID,this.ImagePath);

            return (this.PersonID != -1);      
        }
        private bool _UpdatePerson()
        {
            int rowAffected = clsPeople_DAL.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

            return (rowAffected > 0);
        }

        public static bool DeletePerson(int Personid)
        {
            int rowAffected = clsPeople_DAL.DeletePerson(Personid);

            return (rowAffected > 0);
        }

        public static DataTable GetListpeople()
        {
            return clsPeople_DAL.GetListPeople();
        }

        public static bool IsPersonExist(int personid)
        {

            return clsPeople_DAL.IsPersonExist(ref personid);
        }
        public static bool IsPersonExist(string NationalNo)
        {
            return clsPeople_DAL.IsPersonExist(ref NationalNo);
        }

        public string GetFullName()
        {
            string Fullname;
            if(LastName != null)
                Fullname = FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            else
                Fullname = FirstName + " " + SecondName + " " + LastName;

            return Fullname;
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.enAddMode:
                    {
                        if (_AddNewPerson())
                        {
                            _Mode = enMode.enUpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.enUpdateMode:
                    {
                        if(_UpdatePerson())
                        {
                            _Mode = enMode.enUpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }

            }


            return false;
        }
    }
}

