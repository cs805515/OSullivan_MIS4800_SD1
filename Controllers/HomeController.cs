using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OSullivan_MIS4800_SD1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "GO BENGALS!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Cory's contact information";

            return View();
        }
    }
}