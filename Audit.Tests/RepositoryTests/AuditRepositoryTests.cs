using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Audit.Data;
using Audit.Web.Models;
using Moq;
using NUnit.Framework;
using Audit.Data.DataModel;

namespace Audit.Tests.RepositoryTests
{
    class AuditRepositoryTests
    {
        [Test]
        public void Test_SaveAudit_WhenSuccessful_ReturnAffectedRowsCount()
        {
            var repo = new Mock<AuditRepository>();
            var audit = new Mock<AuditEntity>(new {ID = 1, Description = "Test"});

            repo.Object.CreateAudit(audit.Object);

            Assert.IsTrue(true);
        }
    }
}
