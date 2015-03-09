using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Audit.Data.DataModel;
using Microsoft.Ajax.Utilities;

namespace Audit.Web.Models
{
    public abstract class AuditViewModel
    {
        public int ID { get; set; }
        public AuditType Type { get; set; }

        [Required]
        public string Description { get; set; }
        public string Reference { get; set; }
        public DateTime Date { get; set; }
        public int AuditTypeID { get; set; }
        public int CompanyID { get; set; }
        public bool IsExternal { get; set; }
        public int? AuditorID { get; set; }
        public int? AuditorContactID { get; set; }
        public int? InternalAuditorID { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedByID { get; set; }
        public DateTime ModifiedDate { get; set; }

        public List<AuditItemViewModel> AuditItems { get; set; }


        public AuditEntity AttachToEntity(AuditViewModel auditViewModel)
        {
            
        }
    }

    public enum AuditType
    {
        Process,
        System,
        Supplier
    }
}