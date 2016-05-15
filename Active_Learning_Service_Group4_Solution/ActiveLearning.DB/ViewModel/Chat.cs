﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveLearning.DB;
using System.ComponentModel.DataAnnotations;
using ActiveLearning.Common;
using System.Runtime.Serialization;

namespace ActiveLearning.DB
{
    [MetadataType(typeof(ChatMetadata))]
    public partial class Chat
    {
    }

    public class ChatMetadata
    {
        [Required(ErrorMessage = Constants.Please_Enter + "message")]
        [Display(Name = "Message")]
        public string Message { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Created Date")]
        public DateTime CreateDT { get; set; }

        [Display(Name = "Updated Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", NullDisplayText = "-")]
        public DateTime? UpdateDT { get; set; }

        [Display(Name = "Deleted Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", NullDisplayText = "-")]
        public DateTime? DeleteDT { get; set; }

    }

}
