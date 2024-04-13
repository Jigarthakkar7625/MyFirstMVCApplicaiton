using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyFirstMVCApplicaiton.AuthData
{
    public class Authorization : FilterAttribute, IAuthorizationFilter
    {

        private string[] _roles;
        public Authorization(params string[] role)
        {
            _roles = role; // System define
        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            var role = Convert.ToString(filterContext.HttpContext.Session["Roles"]); // Dynamic >> Comes from Database
            // Admin,HR,USER

            var rolesSplit = role.Split(',');
            // Admin
            // HR
            //USER


            var checkRights = this._roles.Contains(role);


            if (!checkRights)
            {

                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "ERROR", action = "AccessDenied" }));

            }



            // throw new NotImplementedException();
        }
    }
}