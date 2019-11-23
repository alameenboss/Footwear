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
        private ProductRepository _productRepository;

        public ShopService()
        {
            _productRepository = new ProductRepository();
        }
        public ShopViewModel GetPage(int page,int pagesize)
        {
            var model = new ShopViewModel();
            model.Products = _productRepository.GetPage(page, pagesize);
            return model;
        }

        public ShopViewModel GetAll()
        {
            var model = new ShopViewModel();
            model.Products = _productRepository.GetAll();
            return model;
        }

    }
}