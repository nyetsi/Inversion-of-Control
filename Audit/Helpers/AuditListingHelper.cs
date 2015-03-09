using System;
using System.Web;
using System.Web.Mvc;
using Audit.Data;
using Audit.Data.DataModel;
using Audit.Web.Models;

namespace Audit.Web.Helpers
{
    public static class AuditListingHelper
    {
        private static AuditRepository aRep = new AuditRepository();

        public static void PrepareAuditForCreate<T>(T auditViewModel) where T : AuditViewModel
        {
            switch (auditViewModel.Type)
            {
                case AuditType.System:
                    LoadLookups(auditViewModel as SystemAuditViewModel);
                    break;

                case AuditType.Process:
                    LoadLookups(auditViewModel as ProcessAuditViewModel);
                    break;

                case AuditType.Supplier:
                    LoadLookups(auditViewModel as SupplierAuditViewModel);
                    break;
            }
        }

        public static void LoadLookups(SystemAuditViewModel auditViewModel)
        {

        }

        public static void LoadLookups(ProcessAuditViewModel auditViewModel)
        {
           
        }

        public static void LoadLookups(SupplierAuditViewModel auditViewModel)
        {
          
        }
    }

}