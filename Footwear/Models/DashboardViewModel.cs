using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Footwear.Models
{
    public class DashboardViewModel
    {
        public DashboardViewModel()
        {
            Products = new List<ProductViewModel>();
            SliderItems = new List<SliderViewModel>();
            SocialMedia = new List<SocailViewModel>();
        }
        public List<ProductViewModel> Products { get; set; }
        public List<SliderViewModel> SliderItems { get; set; }

        public string SocialHeading { get; set; }

        public List<SocailViewModel> SocialMedia { get; set; }
    }
    

}