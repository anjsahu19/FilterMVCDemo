using FiltersDemo.AuthData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersDemo.Controllers
{
    [Auth]
    [Excep]
    [Action][HandleError]
    public class HomeController : Controller
    {
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            ViewBag.Message = ViewBag.OnActionExecuting;
            return View();
        }
        [Authorize(Users = "abc@gmail.com")]
        public ActionResult About()
        {
            // ViewBag.Message = "abc@gmail.com Allowed!";
            ViewBag.Message = ViewBag.OnActionExecuting;
            return View();
        }
        [Authorize(Users = "anjsahu19@gmail.com")]
        public ActionResult Contact()
        {
            try
            {
                // ViewBag.Message = "anjsahu19@gmail.com Allowed!";
                int i = 0;
                int a = 5 / i;
            }
            catch
            {
                throw;
            }
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}