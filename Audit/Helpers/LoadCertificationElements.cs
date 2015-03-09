using System.Linq;
using System.Web.Mvc;
using Audit.Data;
using Audit.Web.Models;

namespace Audit.Web.Helpers
{
    public static class LoadCertificationElements
    {
        public static void Certifications(SystemAuditViewModel auditViewModel)
        {
            using (AuditRepository aRep = new AuditRepository())
            {
                var certifications = aRep.FindAllCertificationTypes().Where(c => c.Name != "No Certification");
                var certificationElements = certifications.First().CertificationElements;

                auditViewModel.CertificationTypeList = new SelectList(certifications, "ID", "Name", auditViewModel.CertificationTypeID);
                auditViewModel.CertificationElementList = new SelectList(certificationElements, "ID", "Name", auditViewModel.CertificationElementID);    
            }
        }

       
    }
}