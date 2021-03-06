//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Audit.Data.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supplier
    {
        public Supplier()
        {
            this.Supplier1 = new HashSet<Supplier>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string TelNo { get; set; }
        public string FaxNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public int CertificationTypeID { get; set; }
        public System.DateTime CertificationExpiryDate { get; set; }
        public string VendorNo { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public System.DateTime DateCaptured { get; set; }
        public int SupplierTypeID { get; set; }
        public bool Active { get; set; }
        public int CategoryID { get; set; }
        public int CurrencyID { get; set; }
        public int NegotiatedBy { get; set; }
        public string Comments { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsComplete { get; set; }
        public int Rating { get; set; }
        public int MSDS { get; set; }
        public Nullable<int> BackupSupplierID { get; set; }
    
        public virtual CertificationType CertificationType { get; set; }
        public virtual Lookup Lookup { get; set; }
        public virtual Lookup Lookup1 { get; set; }
        public virtual Lookup Lookup2 { get; set; }
        public virtual Lookup Lookup3 { get; set; }
        public virtual Lookup Lookup4 { get; set; }
        public virtual Lookup Lookup5 { get; set; }
        public virtual Lookup Lookup6 { get; set; }
        public virtual ICollection<Supplier> Supplier1 { get; set; }
        public virtual Supplier Supplier2 { get; set; }
    }
}
