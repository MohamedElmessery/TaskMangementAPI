//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Maintenance_FollowUp
    {
        public long ID { get; set; }
        public long Customer_ID { get; set; }
        public long Installation_ID { get; set; }
        public System.DateTime FollowUp_Date { get; set; }
        public string FollowUp_Comment { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public System.DateTime LastModifiedAt { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Installation Installation { get; set; }
    }
}
