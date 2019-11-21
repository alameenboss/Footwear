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
            DashboardItems = new List<DashBoardItemViewModel>();
            SliderItems = new List<SliderViewModel>();
            SocialMedia = new List<Socail>();
        }
        public List<DashBoardItemViewModel> DashboardItems { get; set; }
        public List<SliderViewModel> SliderItems { get; set; }

        public string SocialHeading { get; set; }

        public List<Socail> SocialMedia { get; set; }
    }

   public class DashBoardItemViewModel
    {
        public string Heading { get; set; }
        public string SubHeading { get; set; }

        public string ImageUrl { get; set; }
        public int Amount { get; set; }
        public int Rating { get; set; }
        public string RatingName { get; set; }
        public int Count { get; set; }
        public string ProductHeading { get; set; }
        public string Descrption { get; set; }
        public string LinkDescription { get; set; }
    }

    public class Socail 
    {
        public string CssClass { get; set; }
        public string ImageUrl { get; set; }
        public string Likes { get; set; }
    }

}