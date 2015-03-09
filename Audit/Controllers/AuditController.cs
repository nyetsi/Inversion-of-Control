using System.Web.Mvc;
using Audit.Data;
using Audit.Web.Helpers;
using Audit.Web.Models;

namespace Audit.Web.Controllers
{
    public class AuditController : Controller
    {
        private AuditRepository qRep = new AuditRepository();

        public ActionResult SystemAuditIndex()
        {
          
            return View();
        }

        public ActionResult CreateSystemAudit()
        {
            var auditViewModel = new SystemAuditViewModel();
            AuditHelper.PrepareAuditForCreate(auditViewModel);


            return View(auditViewModel);
        }

        [HttpPost]
        public ActionResult CreateSystemAudit(AuditViewModel auditViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (AuditRepository aRep = new AuditRepository())
                    {
                        //Map model to entity
                        var audit = auditViewModel.AttachToEntity(auditViewModel);



                    }

                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateProcessAudit()
        {
            var auditViewModel = new ProcessAuditViewModel();
            AuditHelper.PrepareAuditForCreate (auditViewModel);

            return View(auditViewModel);
        }

        public ActionResult CreateSupplierAudit()
        {
            var auditViewModel = new SupplierAuditViewModel();
            AuditHelper.PrepareAuditForCreate(auditViewModel);

            return View(auditViewModel);
        }

        

        public ActionResult CreateAuditItems()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAuditItems(AuditViewModel auditViewModel)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
