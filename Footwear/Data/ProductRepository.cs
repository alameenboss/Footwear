using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Footwear.Interface;
using Footwear.Models;


namespace Footwear.Data
{
    public class ProductRepository
    {
        private ICacheProvider cache;
        public ProductRepository()
        {
            this.cache = new DefaultCacheProvider();
        }

        public List<ProductViewModel> GetAll()
        {
            var model = cache.Get("product") as List<ProductViewModel>;
            if (model == null)
            {
                model = new List<ProductViewModel>();
                var Counter = 1;
                foreach (var imageUrl in HelperUtility.GetMensImagesList())
                {

                    model.Add(new ProductViewModel()
                    {
                        Id = Counter,
                        Heading = "Lorem ipsum dolor sit amet",
                        SubHeading = "Lorem ipsum",
                        ImageUrl = imageUrl,
                        Amount = HelperUtility.GetRandom(350, 1000),
                        Rating = HelperUtility.GetRandom(1, 5),
                        RatingName = "Rating1",
                        Count = HelperUtility.GetRandom(1, 30000),
                        ProductHeading = "sed diam nonummy",
                        Descrption = "Lorem ipsum dolor sit amet, consectetuer",
                        LinkDescription = "adipiscing elit, sed diam",
                        Category = "Men"
                    });
                    Counter++;
                }

                foreach (var imageUrl in HelperUtility.GetWomensImagesList())
                {

                    model.Add(new ProductViewModel()
                    {
                        Id = Counter,
                        Heading = "Lorem ipsum dolor sit amet",
                        SubHeading = "Lorem ipsum",
                        ImageUrl = imageUrl,
                        Amount = HelperUtility.GetRandom(350, 1000),
                        Rating = HelperUtility.GetRandom(1, 5),
                        RatingName = "Rating1",
                        Count = HelperUtility.GetRandom(1, 30000),
                        ProductHeading = "sed diam nonummy",
                        Descrption = "Lorem ipsum dolor sit amet, consectetuer",
                        LinkDescription = "adipiscing elit, sed diam",
                        Category = "Women"
                    });
                    Counter++;
                }
                cache.Set("product", model, 60);
            }
            return model;

        }


        public List<ProductViewModel> GetPage(int page, int pagesize)
        {
            return GetAll().Skip(page * pagesize).Take(pagesize).ToList();
        }

        public ProductViewModel GetById(int Id)
        {
            return GetAll().FirstOrDefault(x => x.Id == Id);
        }

    }
}