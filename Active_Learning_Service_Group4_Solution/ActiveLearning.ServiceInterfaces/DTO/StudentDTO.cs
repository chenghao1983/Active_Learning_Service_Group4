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
    public class StudentDTO
    {
        [DataMember(IsRequired = true)]
        [Required(ErrorMessage = Constants.Sid + " " + Constants.Is_Empty)]
        [Range(0, int.MaxValue, ErrorMessage = Constants.Please_Enter + "A Positive Ingeter")]
        public int Sid { get; set; }

        [DataMember(IsRequired = true)]
        [Required(ErrorMessage = "Batch No " + Constants.Is_Empty)]
        [Display(Name = "Batch No")]
        public string BatchNo { get; set; }

        [DataMember(IsRequired = true)]
        [Required(ErrorMessage = "User Sid " + Constants.Is_Empty)]
        [Range(0, int.MaxValue, ErrorMessage = Constants.Please_Enter + "A Positive Ingeter")]
        public int UserSid { get; set; }
    }
}
