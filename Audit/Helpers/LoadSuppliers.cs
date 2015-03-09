using System;
using System.Web.Mvc;
using Audit.Data;
using Audit.Web.Models;

namespace Audit.Web.Helpers
{
    public static class LoadSuppliers
    {
        public static void SuppliersList(SupplierAuditViewModel auditViewModel, SessionHelper obj)
        {
            using (AuditRepository aRep = new AuditRepository())
            {
                var suppliers = aRep.FindSuppliersByCompany(Int32.Parse(obj.CompanyId));

                auditViewModel.SuppliersList = new SelectList(suppliers, "ID", "Name", auditViewModel.SupplierID);
            }
        }
    }
}