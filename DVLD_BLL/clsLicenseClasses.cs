using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsLicenseClasses
    {
        public int LicenseClassID {  get; set; }
        public string ClassName {  get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public double ClassFees {  get; set; }

        public clsLicenseClasses(int LicenseClassID , string ClassName,
            string ClassDescription,byte MinimumAllowedAge, byte DefaultValidityLength, double ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }

        public static clsLicenseClasses Find(int licenseClassID)
        {
            string ClassName = "", ClassDescription = "";
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
            double ClassFees = 0;

            if(clsLicenseClasses_DAL.GetLicenseClassByID(ref licenseClassID, ref ClassName , ref ClassDescription
                ,ref MinimumAllowedAge , ref DefaultValidityLength , ref ClassFees))
            {
                return new clsLicenseClasses(licenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
                return null;
        }
        public static clsLicenseClasses Find(string ClassName)
        {
            int LicenseClassID = -1; string ClassDescription = "";
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
            double ClassFees = 0;

            if (clsLicenseClasses_DAL.GetLicenseClassByClassName(ref LicenseClassID, ref ClassName, ref ClassDescription
                , ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClasses(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
                return null;
        }

        public static DataTable GetListLicenseClasses()
        {
            return clsLicenseClasses_DAL.GetListLicenseClasses();
        }

    }
}
