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
    
    public partial class Lookup
    {
        public Lookup()
        {
            this.Audits = new HashSet<AuditEntity>();
            this.Employees = new HashSet<Employee>();
            this.Suppliers = new HashSet<Supplier>();
            this.Suppliers1 = new HashSet<Supplier>();
            this.Suppliers2 = new HashSet<Supplier>();
            this.Suppliers3 = new HashSet<Supplier>();
            this.Suppliers4 = new HashSet<Supplier>();
            this.Suppliers5 = new HashSet<Supplier>();
            this.Suppliers6 = new HashSet<Supplier>();
            this.AuditFindings = new HashSet<AuditFinding>();
        }
    
        public int LookupID { get; set; }
        public int LookupTypeID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Nullable<int> GroupID { get; set; }
    
        public virtual ICollection<AuditEntity> Audits { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
        public virtual ICollection<Supplier> Suppliers1 { get; set; }
        public virtual ICollection<Supplier> Suppliers2 { get; set; }
        public virtual ICollection<Supplier> Suppliers3 { get; set; }
        public virtual ICollection<Supplier> Suppliers4 { get; set; }
        public virtual ICollection<Supplier> Suppliers5 { get; set; }
        public virtual ICollection<Supplier> Suppliers6 { get; set; }
        public virtual ICollection<AuditFinding> AuditFindings { get; set; }
        public virtual LookupType LookupType { get; set; }
    }
}