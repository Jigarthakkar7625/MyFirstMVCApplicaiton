using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApplicaiton.AuthData
{
    public class ActionAttr : FilterAttribute, IActionFilter
    {
        // After method executed
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //throw new NotImplementedException();
        }

       // Before method calling
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // AFter check logic
            //filterContext.Result = new RedirectResult("/Home/Login");
            // UserId
            // Get data From database
            //and store into one class ???

            // throw new NotImplementedException();
        }
    }
}