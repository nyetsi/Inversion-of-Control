using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Audit.Data;
using Audit.Web.Models;

namespace Audit.Web.Helpers
{
    public static class AuditHelper
    {
        private static readonly AuditRepository aRep = new AuditRepository();

        public static void PrepareAuditForCreate<T>(T auditViewModel) where T : AuditViewModel
        {
            var sessionHelper = new SessionHelper();

            switch (auditViewModel.Type)
            {
                case AuditType.System:
                    LoadCertificationElements.Certifications(auditViewModel as SystemAuditViewModel);
                    break;

                case AuditType.Process:
                    LoadProcesses.Cells(auditViewModel as ProcessAuditViewModel, sessionHelper);
                    break;

                case AuditType.Supplier:
                    LoadSuppliers.SuppliersList(auditViewModel as SupplierAuditViewModel, sessionHelper);
                    break;
            }
        }
    }



}