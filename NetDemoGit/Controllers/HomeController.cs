﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetDemoGit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
         public ActionResult Demo()
        {
            ViewBag.Message = "My Demo";

            return View();
        }
        public ActionResult Sample()
        {
            ViewBag.Message = "My Sample";

            return View();
        }
        public ActionResult Sample1()
        {
            ViewBag.Message = "My Sample1";

            return View();
        }
        public ActionResult Sample2()
        {
            ViewBag.Message = "My Sample2";

            return View();
        }
    }
}
