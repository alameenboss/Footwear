using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Footwear.Models
{
    public class SliderViewModel
    {
        public SliderViewModel()
        {

        }
        public SliderViewModel(string imgurl, string heading, string subheading, string tag)
        {
            ImageUrl = imgurl;
            Heading = heading;
            SubHeading = subheading;
            Tag = tag;
        }
        public string ImageUrl { get; set; }
        public string Heading { get; set; }
        public string SubHeading { get; set; }
        public string Tag { get; set; }

       
        
    }
}