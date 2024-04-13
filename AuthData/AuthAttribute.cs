using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MyFirstMVCApplicaiton.AuthData
{
    public class AuthAttribute : ActionFilterAttribute, IAuthenticationFilter
    {
        MyDBJMAAEntities1 myDBJMAAEntities = new MyDBJMAAEntities1();
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            // Get the data from database and check person is valid or not

            var checkUser = myDBJMAAEntities.Users.Where(x => x.UserId == 500).FirstOrDefault();

            if (checkUser == null)
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
            //throw new NotImplementedException();
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
           // throw new NotImplementedException();
        }
    }
}