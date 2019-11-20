using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Footwear.Models;
using Footwear.Service;
namespace Footwear.Controllers
{
    public class HomeController : Controller
    {
        private DashboardService _dashboardService;

        public HomeController()
        {
            _dashboardService = new DashboardService();
        }
        public ActionResult Index()
        {
            var model = _dashboardService.GetDashboardData();
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