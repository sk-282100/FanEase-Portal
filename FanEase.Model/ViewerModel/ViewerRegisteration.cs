using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FanEase.Models.ViewerModel
{
    public class ViewerRegisteration
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        [DisplayName("City")]
        public int CityId { get; set; }

        [DisplayName("Country")]
        public int CountryId { get; set; }

        [DisplayName("Email")]
        public string EmailId { get; set; }

        [DisplayName("Mobile Number")]
        public string MobileNumber { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }
    }
}
