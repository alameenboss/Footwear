using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Footwear
{
    public static class HelperUtility
    {
        public static int GetRandom(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public static string GetBaseDirectory()
        {
            var basedir = AppDomain.CurrentDomain.BaseDirectory;
            if (basedir.Contains("\\bin"))
            {
                basedir = basedir.Replace("\\bin", "");
            }
            return basedir;
        }

        public static List<string> GetMensImagesList()
        {
            var folder = HelperUtility.GetBaseDirectory() + @"\Content\images\MensFootwear";

            var imageList = new List<string>();

            Directory.GetFiles(folder).ToList().ForEach(filepath =>
            {
                imageList.Add($"/Content/images/MensFootwear/{Path.GetFileName(filepath)}");
            });

            return imageList;
        }

        public static List<string> GetWomensImagesList()
        {
            var folder = HelperUtility.GetBaseDirectory() + @"\Content\images\WomenFootwear";

            var imageList = new List<string>();

            Directory.GetFiles(folder).ToList().ForEach(filepath =>
            {
                imageList.Add($"/Content/images/WomenFootwear/{Path.GetFileName(filepath)}");
            });

            return imageList;
        }
    }
}