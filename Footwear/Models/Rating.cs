using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Footwear.Models
{
    public class Rating
    {
        public int Value { get; set; }
        public int Count { get; set; }

        public Rating(int val,int count)
        {
            this.Value = val;
            this.Count = count;
        }


    }
}