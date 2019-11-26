using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Footwear.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
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
        public string Category { get; set; }
    }
}