using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersDemo.AuthData
{
    public class ResultAttribute : FilterAttribute, IResultFilter
    {

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            
        }

    }
}