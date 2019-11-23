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
        private ShopService _shopService;
        private SingleService _singleService;
        public HomeController()
        {
            _dashboardService = new DashboardService();
            _shopService = new ShopService();
            _singleService = new SingleService();
        }
        public ActionResult Index()
        {

            var model = _dashboardService.GetDashboardData();
            model.SocialHeading = "Lorem ipsum dolor sit amet, consectetuer adipiscing";
            return View(model);
        }

        public ActionResult Shop()
        {
            var model = _shopService.GetAll(); 
            return View(model);
        }

        public ActionResult Single(int id)
        {
            ViewBag.Message = "Your contact page.";
            var model = _singleService.GetById(id);
            return View(model);
        }
    }
}