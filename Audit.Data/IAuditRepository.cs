using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Audit.Data.DataModel;

namespace Audit.Data
{
    public interface IAuditRepository // where T : AuditEntity
    {

        #region Option 1: Generic Methods
        //void CreateAudit(T auditEntity);
        // void CreateAuditItem(T auditItemEntity);
        //void UpdateAudit(T auditEntity);
        //void Delete(T audiEntity);
        //List<T> FindAllAuditsByType(int typeId, int companyId);
        #endregion

        #region Option 2: Tightly coupled methods

        void CreateAudit(AuditEntity auditEntity);
        void CreateAuditItem(AuditItem auditItemEntity);
        void UpdateAudit(AuditEntity auditEntity);
        void DeleteAudit(AuditEntity audiEntity);
        List<AuditEntity> FindAuditsByTypeAndCompany(int typeId, int companyId);

        #endregion
    }
}
