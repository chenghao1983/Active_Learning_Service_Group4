//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ActiveLearning.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Content
    {
        public int Sid { get; set; }
        public int CourseSid { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
        public string OriginalFileName { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public System.DateTime CreateDT { get; set; }
        public Nullable<System.DateTime> UpdateDT { get; set; }
        public Nullable<System.DateTime> DeleteDT { get; set; }
    
        public virtual Course Course { get; set; }
    }
}
