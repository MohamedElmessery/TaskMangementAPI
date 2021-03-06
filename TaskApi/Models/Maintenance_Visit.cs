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
    
    public partial class Maintenance_Visit
    {
        public long ID { get; set; }
        public long Customer_ID { get; set; }
        public Nullable<long> Installation_ID { get; set; }
        public System.DateTime Maintenance_Date { get; set; }
        public string Product_Issue { get; set; }
        public string Maintenance_Description { get; set; }
        public int Fix_Engineer_ID { get; set; }
        public int Assistant_Engineer_ID { get; set; }
        public decimal Count1 { get; set; }
        public int Equipment1_ID { get; set; }
        public Nullable<decimal> Count2 { get; set; }
        public Nullable<int> Equipment2_ID { get; set; }
        public Nullable<decimal> Count3 { get; set; }
        public Nullable<int> Equipment3_ID { get; set; }
        public Nullable<decimal> Count4 { get; set; }
        public Nullable<int> Equipment4_ID { get; set; }
        public Nullable<decimal> Count5 { get; set; }
        public Nullable<int> Equipment5_ID { get; set; }
        public string Comments { get; set; }
        public decimal CollectedFees { get; set; }
        public string OrderNumber { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public System.DateTime LastModifiedAt { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Installation Installation { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual Equipment Equipment1 { get; set; }
        public virtual Equipment Equipment2 { get; set; }
        public virtual Equipment Equipment3 { get; set; }
        public virtual Equipment Equipment4 { get; set; }
        public virtual Fix_Employee Fix_Employee { get; set; }
        public virtual Fix_Employee Fix_Employee1 { get; set; }
    }
}
