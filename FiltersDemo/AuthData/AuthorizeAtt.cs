using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersDemo.AuthData
{
    public class AuthorizeAtt : AuthorizeAttribute
    {
        private bool localAllowed;
        public AuthorizeAtt(bool allowedParam)
        {
            localAllowed = allowedParam;
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Request.IsLocal)
            {
                return localAllowed;
            }
            else
            {
                return true;
            }
        }
    }
}