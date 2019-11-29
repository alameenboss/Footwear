using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Footwear.Models;
using Footwear.Service;

namespace Footwear.Controllers
{
    public class MenuController : Controller
    {
        private MenuService _menuService;
       
        public MenuController()
        {
            _menuService = new MenuService();
        }
        // GET: Menu
        [ChildActionOnly]
        public PartialViewResult GetMenu()
        {
            var model = _menuService.GetMainMenu();
            return PartialView("Menu", model);
        }
    }
}