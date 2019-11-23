using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Footwear.Models;
namespace Footwear.Data
{
    public class DashboardRepository
    {
        public List<SliderViewModel> GetSliderItems()
        {
            var SliderItems = new List<SliderViewModel>();
            SliderItems.Add(new SliderViewModel("/Content/images/banner1.jpg", "Classic", "White", "Lorem ipsum dolor sit amet"));
            SliderItems.Add(new SliderViewModel("/Content/images/banner2.jpg", "Stlyish", "White", "Lorem ipsum dolor sit amet"));
            SliderItems.Add(new SliderViewModel("/Content/images/banner1.jpg", "Classic", "Black", "Lorem ipsum dolor sit amet"));
            SliderItems.Add(new SliderViewModel("/Content/images/banner2.jpg", "Peppy", "Brown", "Lorem ipsum dolor sit amet"));
            SliderItems.Add(new SliderViewModel("/Content/images/banner1.jpg", "Comfortable", "Orange", "Lorem ipsum dolor sit amet"));
            return SliderItems;
        }

        public List<SocailViewModel> GetSocialMediaItems()
        {
            return new List<SocailViewModel>() {

                new SocailViewModel()
                {
                    CssClass = "facebook",
                    Likes = "1.51K"
                },

                new SocailViewModel()
                {
                    CssClass = "twitter",
                    Likes = "1.51K"
                },

                new SocailViewModel()
                {
                    CssClass = "google",
                    Likes = "1.51K"
                },

                new SocailViewModel()
                {
                    CssClass = "dot",
                    Likes = "1.51K"
                },
            };
        }

    }
}