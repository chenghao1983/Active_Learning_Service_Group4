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
    public class QuizOptionDTO
    {
        [DataMember(IsRequired = true)]
        [Required(ErrorMessage = Constants.Sid + " " + Constants.Is_Empty)]
        [Range(0, int.MaxValue, ErrorMessage = Constants.Please_Enter + "A Positive Ingeter")]
        public int Sid { get; set; }

        [DataMember(IsRequired = true)]
        [Required(ErrorMessage = "Quiz Question Sid " + Constants.Is_Empty)]
        [Range(0, int.MaxValue, ErrorMessage = Constants.Please_Enter + "A Positive Ingeter")]
        [Display(Name = "Quiz Question Sid")]
        public int QuizQuestionSid { get; set; }

        [DataMember(IsRequired = true)]
        [Required(ErrorMessage = "Title " + Constants.Is_Empty)]
        [Display(Name = "Title")]
        public string Title { get; set; }

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
