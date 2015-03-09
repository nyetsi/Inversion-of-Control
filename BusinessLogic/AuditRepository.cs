using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Audit.Data;
using Audit.Data.DataModel;

namespace BusinessLogic
{
    public class AuditRepository : IRepository<AuditEntity>
    {
        private QMSEntities _context = new QMSEntities();
        public IEnumerable<AuditEntity> List
        {
            get { return _context.AuditEntities; }
        }

        public void Add(AuditEntity entity)
        {
            _context.AuditEntities.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(AuditEntity entity)
        {
            _context.AuditEntities.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(AuditEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public AuditEntity FindById(int id)
        {
            return _context.AuditEntities.FirstOrDefault(a => a.ID == id);
        }
    }
}
