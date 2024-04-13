using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApplicaiton.AuthData
{
    public class ResultFilter : FilterAttribute, IResultFilter
    {
        // after done return

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {

            //throw new NotImplementedException();
        }

        // While going to redirect or retun something
        // Before going to HTML (Return)
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {

            //DB CALL

            filterContext.Controller.ViewBag.Hello = "Hello Brother";
            //throw new NotImplementedException();
        }
    }
}