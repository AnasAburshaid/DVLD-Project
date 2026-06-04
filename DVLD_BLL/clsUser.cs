using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsUser
    {

        public enum enMode { enUpdateMode = 0, enAddMode = 1 };
        enMode _Mode;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
      

        private clsUser(int userid, int personid, string username, string password, bool isactive)
        {
            _Mode = enMode.enUpdateMode;

            this.UserID = userid;
            this.PersonID = personid;
            this.Username = username;
            this.Password = password;
            this.IsActive = isactive;
        }
        public clsUser()
        {
            this.UserID =   -1;
            this.PersonID = -1;
            this.Username = "";
            this.Password = "";
            this.IsActive = false;

            _Mode = enMode.enAddMode;
        }
        public static clsUser Find(int userid)
        {
            string username = "", password = "";
            bool isActive = false;
            int personid = -1;

            if (clsUser_DAL.GetUserInfoByID(ref userid,ref personid,ref username,ref password,ref isActive))
            {
                return new clsUser(userid, personid, username, password, isActive);
            }
            else
                return null;
        }
        private bool _AddNewUser()
        {
            this.UserID =  clsUser_DAL.AddNewUser(this.PersonID, this.Username, this.Password, this.IsActive);
            return (this.UserID != -1);

        }
        private bool _UpdateUser()
        {
            int rowAffected = clsUser_DAL.UpdateUser(this.UserID, this.PersonID, this.Username, this.Password, this.IsActive);

            return (rowAffected > 0);
        }
        public static bool DeleteUser(int userid)
        {
            int rowAffected =  clsUser_DAL.DeleteUser(userid);
            return rowAffected > 0;
        }
        public static DataTable GetListUsers()
        {
            return clsUser_DAL.GetListUsers();
        }

        public bool IsUserExists(int userid)
        {
            return clsUser_DAL.IsUserExist(ref userid);
            
        }

        public static clsUser findUsernameAndPassword(string username,string password)
        {
            bool IsActive = false;
            int userid = -1, personid = -1;

            if (clsUser_DAL.GetUserInfoByUsernameAndPassword(ref username, ref password, ref IsActive, ref userid, ref personid))
            {
                return new clsUser(userid, personid, username, password, IsActive);
            }
            else
                return null;
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddMode:
                    {
                        if (_AddNewUser())
                        {
                            _Mode = enMode.enUpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.enUpdateMode:
                    {
                        if (_UpdateUser())
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
