using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Audit.Web.Helpers
{
    public class SessionHelper
    {
        public string CompanyId { get; set; }
        public string GroupId { get; set; }

        public SessionHelper()
        {
            HttpContext context = HttpContext.Current;

            CompanyId = context.Session["CompanyID"].ToString();
            GroupId = context.Session["GroupID"].ToString();
        }
    }
}