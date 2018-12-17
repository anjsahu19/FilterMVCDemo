using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace FiltersDemo.AuthData
{
    public class ExcepAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            
            LogException(filterContext.Exception);
            //filterContext.ExceptionHandled = true;
        }

        public void LogException(Exception ex)
        {
            // HttpContext.Current.Server.MapPath("~/ExceptionLog/ExceptionLog.txt");
            string logFilePath = HostingEnvironment.MapPath("~/ExceptionLog/ExceptionLog.txt");
          
            using (StreamWriter sw=File.CreateText(logFilePath))
            {
                sw.WriteLine("-----------------------------------------");
                sw.WriteLine("Exception Occurred at : " + DateTime.Now);
                sw.WriteLine("Exception Type : " + ex.GetType().ToString());
                sw.WriteLine("Source : " + ex.Source);
                sw.WriteLine("Message : " + ex.Message);
                sw.WriteLine("Stack Trace : " + ex.StackTrace);
                sw.WriteLine("Target : " + ex.TargetSite);
                sw.WriteLine("-----------------------------------------");
            }
             
        }
    }
}