using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Web.DMS
{
    public class UserAuthorization : AuthorizeAttribute
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (filterContext.HttpContext.Session["UserName"] == null)
            {
                filterContext.Result = new HttpUnauthorizedResult();
                filterContext.HttpContext.Response.Redirect("/Account/LogOff");
            }
        }

        //public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        //{
        //    throw new NotImplementedException();
        //}

        //public override void OnAuthorization(AuthorizationContext filterContext)
        //{
        //    if(String.IsNullOrEmpty(filterContext.HttpContext.Session["UserName"].ToString()))
        //    {
        //        filterContext.Result = new HttpUnauthorizedResult();
        //        filterContext.HttpContext.Response.Redirect("/Account/LogOff");
        //    }
        //}
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool returnValue = true;
            if (httpContext.Session["UserName"] == null)
            {
                returnValue = false;
            }
            return returnValue;
        }

    }
}