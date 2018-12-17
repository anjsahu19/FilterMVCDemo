using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersDemo.AuthData
{
    public class ActionAttribute : FilterAttribute, IActionFilter
    {

        //Will be called before action is executed
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.OnActionExecuting = filterContext.ActionDescriptor.ActionName + " Action will start executing Now!";
        }

        //Will be called after action is executed
    
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.OnActionExecuted = filterContext.ActionDescriptor.ActionName + " Action Executed!";    
        }
    }
}