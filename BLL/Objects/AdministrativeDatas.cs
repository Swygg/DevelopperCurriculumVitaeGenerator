using System;
using System.Collections.Generic;

namespace BLL.Objects
{
    [Serializable]
    public class AdministrativeDatas
    {
        public string JobName { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adresse { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public DateTime? BirthDate { get; set; }
        public List<string> LicenseDriver { get; set; }
        public bool? IsVehiculeOwner { get; set; }

        public AdministrativeDatas()
        {
            this.LicenseDriver = new List<string>();
        }
    }
}
