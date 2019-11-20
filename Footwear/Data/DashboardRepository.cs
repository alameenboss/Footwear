using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Footwear.Models;
namespace Footwear.Data
{
    public class DashboardRepository
    {
        public List<DashBoardItemViewModel> GetDashboardItems()
        {
            var model = new List<DashBoardItemViewModel>();

            model.Add(new DashBoardItemViewModel()
            {
                Heading = "Lorem ipsum dolor sit amet",
                SubHeading = "Lorem ipsum",
                ImageUrl = "/Content/images/pic.jpg",
                Amount = 480,
                Rating = 3,
                RatingName = "Rating1",
                Count = 45,
                ProductHeading = "sed diam nonummy",
                Descrption = "Lorem ipsum dolor sit amet, consectetuer",
                LinkDescription = "adipiscing elit, sed diam"
            });

            model.Add(new DashBoardItemViewModel()
            {
                Heading = "Lorem ipsum dolor sit amet",
                SubHeading = "Lorem ipsum",
                ImageUrl = "/Content/images/pic1.jpg",
                Amount = 300,
                Rating = 5,
                RatingName = "Rating2",
                Count = 200,
                ProductHeading = "sed diam nonummy",
                Descrption = "Lorem ipsum dolor sit amet, consectetuer",
                LinkDescription = "adipiscing elit, sed diam"
            });

            model.Add(new DashBoardItemViewModel()
            {
                Heading = "Lorem ipsum dolor sit amet",
                SubHeading = "Lorem ipsum",
                ImageUrl = "/Content/images/pic2.jpg",
                Amount = 490,
                Rating = 2,
                RatingName = "Rating3",
                Count = 300,
                ProductHeading = "sed diam nonummy",
                Descrption = "Lorem ipsum dolor sit amet, consectetuer",
                LinkDescription = "adipiscing elit, sed diam"
            });

            model.Add(new DashBoardItemViewModel()
            {
                Heading = "Lorem ipsum dolor sit amet",
                SubHeading = "Lorem ipsum",
                ImageUrl = "/Content/images/pic3.jpg",
                Amount = 499,
                Rating = 4,
                RatingName = "Rating4",
                Count = 504,
                ProductHeading = "sed diam nonummy",
                Descrption = "Lorem ipsum dolor sit amet, consectetuer",
                LinkDescription = "adipiscing elit, sed diam"
            });

            model.Add(new DashBoardItemViewModel()
            {
                Heading = "Lorem ipsum dolor sit amet",
                SubHeading = "Lorem ipsum",
                ImageUrl = "/Content/images/pic4.jpg",
                Amount = 1100,
                Rating = 3,
                RatingName = "Rating5",
                Count = 10,
                ProductHeading = "sed diam nonummy",
                Descrption = "Lorem ipsum dolor sit amet, consectetuer",
                LinkDescription = "adipiscing elit, sed diam"
            });

            model.Add(new DashBoardItemViewModel()
            {
                Heading = "Lorem ipsum dolor sit amet",
                SubHeading = "Lorem ipsum",
                ImageUrl = "/Content/images/pic5.jpg",
                Amount = 700,
                Rating = 4,
                RatingName = "Rating6",
                Count = 290,
                ProductHeading = "sed diam nonummy",
                Descrption = "Lorem ipsum dolor sit amet, consectetuer",
                LinkDescription = "adipiscing elit, sed diam"
            });

            return model;

        }

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

    }
}