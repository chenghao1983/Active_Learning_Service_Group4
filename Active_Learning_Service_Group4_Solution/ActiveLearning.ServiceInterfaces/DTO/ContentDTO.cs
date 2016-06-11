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
    public class ContentDTO
    {
        [DataMember(IsRequired = true)]
        [Required(ErrorMessage = Constants.Sid + " " + Constants.Is_Empty)]
        [Range(0, int.MaxValue, ErrorMessage = Constants.Please_Enter + "A Positive Ingeter")]
        public int Sid { get; set; }

        [DataMember(IsRequired = true)]
        [Required(ErrorMessage =  "Course Sid " + Constants.Is_Empty)]
        [Range(0, int.MaxValue, ErrorMessage = Constants.Please_Enter + "A Positive Ingeter")]
        [Display(Name = "Course Sid")]
        public int CourseSid { get; set; }

        [DataMember(IsRequired = true)]
        [Required(ErrorMessage = "Content Type " + Constants.Is_Empty)]
        [Display(Name = "Content Type")]
        public string Type { get; set; }

        [DataMember(IsRequired = true)]
        [Required(ErrorMessage = "Original File Name " + Constants.Is_Empty)]
        [Display(Name = "Original File Name")]
        public string OriginalFileName { get; set; }

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
