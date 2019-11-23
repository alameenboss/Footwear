using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Footwear.Data;
using Footwear.Models;
namespace Footwear.Service
{
    public class DashboardService
    {
        private DashboardRepository _dashboardRepository;

        private ProductRepository _productRepository;

        public DashboardService()
        {
            _dashboardRepository = new DashboardRepository();
            _productRepository = new ProductRepository();
        }
        public DashboardViewModel GetDashboardData()
        {
            var model = new DashboardViewModel();
            model.Products = _productRepository.GetPage(1,15);
            model.SliderItems = _dashboardRepository.GetSliderItems();
            model.SocialMedia = _dashboardRepository.GetSocialMediaItems();

            return model;
        }
    }
}