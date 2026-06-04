using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DAL;
namespace DVLD_
{
    public class clsCountry
    {
        
        public enum enMode { enUpdateMode = 0, enAddMode = 1 };
        enMode Mode;
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        private clsCountry(int countryid, string countryname)
        {
            Mode = enMode.enUpdateMode;
            this.CountryID = countryid;
            this.CountryName = countryname;

        }

        public clsCountry()
        {
            Mode = enMode.enAddMode;
            this.CountryID = -1;
            this.CountryName = "";
           
        }
        public static clsCountry Find(int countryid)
        {
            string countryname = "";

            if (clsCountry_DAL.GetCountryInfoByID(ref countryid, ref countryname))
            {
                return new clsCountry(countryid, countryname);
            }
            return null;
        }
        public static clsCountry Find(string countryname)
        {
            int countryid = -1;
            

            if (clsCountry_DAL.GetCountryInfoByName(ref countryid, ref countryname))
            {
                return new clsCountry(countryid, countryname);
            }
            return null;
        }



        private bool _AddNewCountry()
        {
            this.CountryID = clsCountry_DAL.AddNewCountry(this.CountryName);
            return (this.CountryID > -1);
        }

        public static bool isCountryExist(int countryid)
        {
            return clsCountry_DAL.IsCountryExist(countryid);
        }

        public static bool isCountryExistByName(string countryname)
        {
            return clsCountry_DAL.IsCountryExist(countryname);
        }

        public static bool deleteCountry(int countryid)
        {
            if (clsCountry_DAL.IsCountryExist(countryid))
                return clsCountry_DAL.DeleteCountry(countryid);
            else
                return false;
        }

        private bool _UpdateCountry()
        {
            return clsCountry_DAL.UpdateContact(this.CountryID, this.CountryName);
        }

        public static DataTable GetListCountries()
        {
            return clsCountry_DAL.GetAllCountries();
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.enAddMode:
                    {
                        if (_AddNewCountry())
                        {
                            Mode = enMode.enUpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.enUpdateMode:
                    {
                        if (_UpdateCountry())
                        {
                            Mode = enMode.enUpdateMode;
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
