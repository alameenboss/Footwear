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

        public DashboardService()
        {
            _dashboardRepository = new DashboardRepository();
        }
        public DashboardViewModel GetDashboardData()
        {
            var model = new DashboardViewModel();
            model.Products = _dashboardRepository.GetProducts();
            model.SliderItems = _dashboardRepository.GetSliderItems();
            model.SocialMedia = _dashboardRepository.GetSocialMediaItems();

            return model;
        }
    }
}