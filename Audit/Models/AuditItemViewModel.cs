using System;

namespace Audit.Web.Models
{
    public class AuditItemViewModel
    {
        public int ID { get; set; }
        public int AuditID { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }

    }
}