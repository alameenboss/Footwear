using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Footwear.Data;
using Footwear.Models;
namespace Footwear.Service
{
    public class ShopService
    {
        private ShopRepository _shopRepository;

        public ShopService()
        {
            _shopRepository = new ShopRepository();
        }
        public ShopViewModel GetShopData(int page,int pagesize)
        {
            var model = new ShopViewModel();
            model.Products = _shopRepository.GetShopData(page, pagesize);

            return model;
        }
    }
}