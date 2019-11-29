using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Footwear.Data;
using Footwear.Models;
namespace Footwear.Service
{
    public class MenuService
    {
        private MenuRepository _menuRepository;
        public MenuService()
        {
            _menuRepository = new MenuRepository();
        }
        public List<Menu> GetMainMenu()
        {            
            return _menuRepository.GetMenu(); ;
        }
    }
}