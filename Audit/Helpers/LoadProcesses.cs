using System;
using Audit.Data;
using Audit.Web.Models;

namespace Audit.Web.Helpers
{
    public static class LoadProcesses
    {
        public static void Cells(ProcessAuditViewModel auditViewModel, SessionHelper obj)
        {
            using (AuditRepository aRep = new AuditRepository())
            {
                var cells = aRep.FindCellsByCompanyId(Int32.Parse(obj.CompanyId));

                auditViewModel.AttachCells(cells);    
            }
            
        }
    }
}