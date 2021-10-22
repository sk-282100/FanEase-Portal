using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FanEase.Model.CreatorModel
{
    public class CreatorRegisteration
    {
        [DisplayName("Profile Photo")]
        public string ProfilePhotoPath { get; set; }

        [DisplayName("Creator Name")]
        [Required]
        public string CreatorName { get; set; }
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

        public bool Status { get; set; }

        [DisplayName("Additional Remark")]
        public string AdditionalRemark { get; set; }
    }
}
