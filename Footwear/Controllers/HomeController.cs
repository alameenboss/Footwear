using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Footwear.Models;

namespace Footwear.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new Dashboard();

            model.Rating1 = new Rating(3, 45);
            model.Rating2 = new Rating(2, 10);
            model.Rating3 = new Rating(4, 100);
            model.Rating4 = new Rating(5, 200);
            model.Rating5 = new Rating(1, 250);
            model.Rating6 = new Rating(5, 107);
            return View(model);
        }

        public ActionResult Shop()
        {
            return View();
        }

        public ActionResult Single()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}