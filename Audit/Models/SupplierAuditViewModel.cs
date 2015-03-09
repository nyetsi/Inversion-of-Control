using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Audit.Web.Models
{
    public class SupplierAuditViewModel : AuditViewModel
    {
        public int SupplierID { get; set; }

        public List<SupplierViewModel> Suppliers { get; set; }

        [Display(Name="Suppliers")]
        public SelectList SuppliersList { get; set; }

        public SupplierAuditViewModel()
        {
            Type = AuditType.Supplier;
        }
    }
}