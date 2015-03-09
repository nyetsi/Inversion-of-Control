using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Audit.Web.Models
{
    public class SystemAuditViewModel : AuditViewModel
    {
        public int CertificationElementID { get; set; }
        public int CertificationTypeID { get; set; }

        [Display(Name = "Certification Type")]
        public SelectList CertificationTypeList { get; set; }

        [Display(Name = "Certification Element")]
        public SelectList CertificationElementList { get; set; }


        public SystemAuditViewModel()
        {
            Type = AuditType.System;
        }

    }
}