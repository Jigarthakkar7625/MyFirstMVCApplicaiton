using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApplicaiton.Controllers
{
    public class ERRORController : Controller
    {
        // GET: ERROR
        public ActionResult AccessDenied()
        {
            return View();
        }
    }
}