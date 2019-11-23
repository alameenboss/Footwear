using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Footwear.Data;
using Footwear.Models;
namespace Footwear.Service
{
    public class SingleService
    {
        private ProductRepository _productRepository;

        public SingleService()
        {
            _productRepository = new ProductRepository();
        }
        public ProductViewModel GetById(int id)
        {
            return _productRepository.GetById(id);
        }
    }
}