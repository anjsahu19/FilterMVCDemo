using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersDemo.AuthData
{
    public class ActionAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.OnActionExecuting = filterContext.ActionDescriptor.ActionName + "Action Executed!";    
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.OnActionExecuted = filterContext.ActionDescriptor.ActionName + " will start executing Now!";
        }
    }
}