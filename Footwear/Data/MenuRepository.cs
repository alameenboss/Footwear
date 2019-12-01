using Footwear.Interface;
using Footwear.Models;
using System.Collections.Generic;

namespace Footwear.Data
{
    public class MenuRepository
    {
        private ICacheProvider cache;
        public MenuRepository()
        {
            this.cache = new DefaultCacheProvider();
        }

        public List<Menu> GetMenu()
        {
            var model = cache.Get("MainMenu") as List<Menu>;
            if (model == null)
            {
                model = new List<Menu>();
                model.Add(new Menu() { Name = "Home" });
                model.Add( new Menu()
                {
                    Name = "Mens",
                    ImgUrl = @"/Content/images/nav_img.jpg",
                    MenuItem = new List<Menu>()
                    {
                        new Menu
                        {
                            Name = "Popular",
                            MenuItem = new List<Menu>()
                            {
                                new Menu("New arrivals", @"/Home/Shop?category=Men&Type=NewArrivals"),
                                new Menu("Stylish", @"/Home/Shop?category=Men&Type=Stylish"),
                                new Menu("Fashion", @"/Home/Shop?category=Men&Type=Fashion"),
                                new Menu("Branded", @"/Home/Shop?category=Men&Type=Branded"),
                                new Menu("Accessories", @"/Home/Shop?category=Men&Type=Accessories"),
                                new Menu("Bags", @"/Home/Shop?category=Men&Type=Bags"),
                                new Menu("Wallet", @"/Home/Shop?category=Men&Type=Wallet")
                            }
                        },
                        new Menu
                        {
                            Name = "Men Shoe",
                            MenuItem = new List<Menu>()
                            {
                                new Menu("New arrivals", @"/Home/Shop?category=Men&Type=Shoes"),
                                new Menu("Stylish", @"/Home/Shop?category=Men&Type=Slipper"),
                                new Menu("Fashion", @"/Home/Shop?category=Men&Type=Loffers"),
                                new Menu("Branded", @"/Home/Shop?category=Men&Type=Accessories"),
                                new Menu("Accessories", @"/Home/Shop?category=Men&Type=Belts"),
                                new Menu("Bags", @"/Home/Shop?category=Men&Type=Bags"),
                                new Menu("Wallet", @"/Home/Shop?category=Men&Type=Wallet")
                            }
                        },
                    }
                });
                model.Add(new Menu()
                {
                    Name = "Women",
                    ImgUrl = @"/Content/images/nav_img1.jpg",
                    MenuItem = new List<Menu>()
                    {
                        new Menu
                        {
                            Name = "Popular",
                            MenuItem = new List<Menu>()
                            {
                                new Menu("New arrivals", @"/Home/Shop?category=Women&Type=NewArrivals"),
                                new Menu("Stylish", @"/Home/Shop?category=Women&Type=Stylish"),
                                new Menu("Fashion", @"/Home/Shop?category=Women&Type=Fashion"),
                                new Menu("Branded", @"/Home/Shop?category=Women&Type=Branded"),
                                new Menu("Accessories", @"/Home/Shop?category=Women&Type=Accessories"),
                                new Menu("Bags", @"/Home/Shop?category=Women&Type=Bags"),
                                new Menu("Wallet", @"/Home/Shop?category=Women&Type=Wallet")
                            }
                        },
                        new Menu
                        {
                            Name = "Women Shoe",
                            MenuItem = new List<Menu>()
                            {
                                new Menu("New arrivals", @"/Home/Shop?category=Women&Type=Shoes"),
                                new Menu("Stylish", @"/Home/Shop?category=Women&Type=Slipper"),
                                new Menu("Fashion", @"/Home/Shop?category=Women&Type=Loffers"),
                                new Menu("Branded", @"/Home/Shop?category=Women&Type=Accessories"),
                                new Menu("Accessories", @"/Home/Shop?category=Women&Type=Belts"),
                                new Menu("Bags", @"/Home/Shop?category=Women&Type=Bags"),
                                new Menu("Wallet", @"/Home/Shop?category=Women&Type=Wallet")
                            }
                        },
                    }
                });
                model.Add(new Menu() { Name = "Kids" });
                model.Add(new Menu() { Name = "Sale" });
                model.Add(new Menu() { Name = "Customize" });
                model.Add(new Menu() { Name = "Football" });
                model.Add(new Menu() { Name = "Running" });
                model.Add(new Menu() { Name = "Originals" });
                model.Add(new Menu() { Name = "Basketball" });
                cache.Set("MainMenu", model, 60);
            }
            return model;
        }
    }
}






       