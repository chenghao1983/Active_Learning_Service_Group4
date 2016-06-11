using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ActiveLearning.Common;


namespace ActiveLearning.ServiceInterfaces.DTO
{
    [DataContract]
    public class UserDTO
    {
        [DataMember(IsRequired = true)]
        [Required(ErrorMessage = Constants.Sid + " " + Constants.Is_Empty)]
        [Range(0, int.MaxValue, ErrorMessage = Constants.Please_Enter + "A Positive Ingeter")]
        public int Sid { get; set; }

        [DataMember(IsRequired = true)]
        [Required(ErrorMessage = "User Name " + Constants.Is_Empty)]
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [DataMember(IsRequired = true)]
        [Required(ErrorMessage = "Password " + Constants.Is_Empty)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataMember(IsRequired = true)]
        [Required(ErrorMessage = "Full Name " + Constants.Is_Empty)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [DataMember(IsRequired = true)]
        [Required(ErrorMessage = "Is Active " + Constants.Is_Empty)]
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        [DataMember(IsRequired = true)]
        [Required(ErrorMessage = "Role " + Constants.Is_Empty)]
        [Display(Name = "Role")]
        public string Role { get; set; }

        [DataMember(IsRequired = true)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Created Date")]
        public System.DateTime CreateDT { get; set; }
        [DataMember]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Updated Date")]
        public Nullable<System.DateTime> UpdateDT { get; set; }

        [DataMember]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Deleted Date")]
        public Nullable<System.DateTime> DeleteDT { get; set; }
    }
}
