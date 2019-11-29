using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Footwear.Models
{
    public class Menu
    {
        public Menu()
        {
            MenuItem = new List<Menu>();
        }

        public Menu(string _name,string _url)
        {
            MenuItem = new List<Menu>();
            Name = _name;
            Url = _url;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public string Url { get; set; }
        public string ImgUrl { get; set; }
        public List<Menu> MenuItem { get; set; }
    }

}