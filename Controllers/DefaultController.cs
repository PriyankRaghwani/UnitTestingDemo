using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnitTestingDemo.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ViewBag.Message = "You are in Index Page";
            return View();
        }

        public ActionResult ContactUs()
        {
            ViewBag.Message = "You are in Contactus Page";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "You are in About us page";
            return View();
        }
    }
}