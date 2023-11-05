using MVCExceptionFilter.ExceptionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace MVCExceptionFilter.Controllers
{
    [CustomeExceptionFilter]
    [Route("/api/{controller}")]
    public class HomeController : Controller
    {

        // [OutputCache(Duration =5)]
        public ActionResult Index()
        {

            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            int a, b, c;
            a = 7; b = 0;
            c = a / b;
            int[] ar = new int[2];
            ar[0] = 6;
            ar[1] = 7;
            ar[2] = 8;
            foreach (int v in ar)
                Response.Write(v);
            ViewBag.Result = c.ToString();
            return View();

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Route("{Id}")]// This is use to set the custome routing in action level
        [ActionName("Login")]// This attribute is use to change the controller action name
        public ActionResult UserLogin()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}