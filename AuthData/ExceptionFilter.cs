using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApplicaiton.AuthData
{
    public class ExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {

            // When error comes in whole applicaiton it will come here
            // Insert record in DB
            // // Insert record in Text file

            // Savechanges()
            throw new NotImplementedException();
        }
    }
}