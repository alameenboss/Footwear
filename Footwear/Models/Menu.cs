using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Footwear.Models
{
    public class Menu
    {
        public string Heading { get; set; }

        public int MyProperty { get; set; }
    }

    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}