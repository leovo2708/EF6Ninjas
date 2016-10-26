﻿using System.Web.Mvc;

namespace WebMvcAppDefault.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Pluralsight.com Getting Started with Entity Framework 6 by Julie Lerman.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}