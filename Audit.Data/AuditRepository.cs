using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Audit.Data.DataModel;

namespace Audit.Data
{
    public class AuditRepository : IAuditRepository, IDisposable
    {
        private readonly Entities _context = new Entities();

        #region Audit CRUD
        public void CreateAudit(AuditEntity auditEntity)
        {
            try
            {
                _context.AuditEntities.Add(auditEntity);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _context.Dispose();
            }
        }

        public void CreateAuditItem(AuditItem auditItemEntity)
        {
            try
            {
                _context.AuditItems.Add(auditItemEntity);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _context.Dispose();
            }
        }

        public void UpdateAudit(AuditEntity auditEntity)
        {
            try
            {
                _context.Entry(auditEntity).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _context.Dispose();
            }
        }

        public void DeleteAudit(AuditEntity auditEntity)
        {
            try
            {
                _context.AuditEntities.Remove(auditEntity);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _context.Dispose();
            }
        }

        public List<AuditEntity> FindAuditsByTypeAndCompany(int typeId, int companyId)
        {
            try
            {
                var result = _context.AuditEntities.Where(a => a.AuditTypeID == typeId && a.CompanyID == companyId);

                return result.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _context.Dispose();
            }
        }
        #endregion

        #region Lookups
        public List<CertificationType> FindAllCertificationTypes()
        {
            return _context.CertificationTypes.ToList();
        }

        public List<Cell> FindCellsByCompanyId(int companyId)
        {
            return _context.Cells.Where(c => c.Department.CompanyID == companyId).ToList();
        }

        public List<Supplier> FindSuppliersByCompany(int companyId)
        {
            return _context.Suppliers.Where(s => s.IsPrimary && s.CompanyID == companyId).ToList();
        }

        #endregion

        public void Dispose()
        {
            using (var context = new Entities())
            {
                context.Dispose();
            }
        }
    }
}
