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
    
    public partial class LookupType
    {
        public LookupType()
        {
            this.Lookups = new HashSet<Lookup>();
        }
    
        public int LookupTypeID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsSystemLookup { get; set; }
    
        public virtual ICollection<Lookup> Lookups { get; set; }
    }
}