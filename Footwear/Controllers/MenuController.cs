using Footwear.Service;
using System.Web.Mvc;

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