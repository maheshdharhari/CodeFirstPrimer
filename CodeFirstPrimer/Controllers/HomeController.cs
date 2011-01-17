using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstPrimer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This application is developed when I was learning MVC and Entityframework.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Mahesh Kumat Yadav";

            return View();
        }
    }
}