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

        [Authorize(Roles = "Member")]
        public ActionResult Shop(int? page,int? pagesize,string category,string Type)
        {
            if (page == null) page = 1;
            ViewData["pageNum"] = page.Value;

            if (pagesize == null) pagesize = 9;
            ViewData["pageSize"] = pagesize.Value;

            if (string.IsNullOrEmpty(category)) category = "Men";
            ViewData["category"] = category;

            if (string.IsNullOrEmpty(Type)) Type = "NewArrival";
            ViewData["Type"] = Type;

            ViewData["totalItems"] = _shopService.GetAll().Products.Where(x=>x.Category == category).ToList().Count;

            var model = _shopService.GetPage(page.Value, pagesize.Value, category, Type); 
            return View(model);
        }
        [Authorize(Roles = "Member")]
        public ActionResult Single(int id)
        {
            ViewBag.Message = "Your contact page.";
            var model = _singleService.GetById(id);
            return View(model);
        }
    }
}