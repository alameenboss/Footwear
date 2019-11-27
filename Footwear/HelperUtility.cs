using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Security.Cryptography;

namespace Footwear
{
    public static class HelperUtility
    {
        public static int GetRandom(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public static int GetTrueRandom()
        {
            int value = 1;
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] randomNumber = new byte[4];
                rng.GetBytes(randomNumber);
                return value = BitConverter.ToInt32(randomNumber, 0);
            }
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

    public static class RandomNumber
    {
        private static Random r = new Random();
        private static object l = new object();
        private static Random globalRandom = new Random();
        [ThreadStatic]
        private static Random localRandom;
        public static int GenerateNewRandom(int min, int max)
        {
            return new Random().Next(min, max);
        }
        public static int GenerateLockedRandom(int min, int max)
        {
            int result;
            lock (RandomNumber.l)
            {
                result = RandomNumber.r.Next(min, max);
            }
            return result;
        }
        public static int GenerateRandom(int min, int max)
        {
            Random random = RandomNumber.localRandom;
            if (random == null)
            {
                int seed;
                lock (RandomNumber.globalRandom)
                {
                    seed = RandomNumber.globalRandom.Next();
                }
                random = (RandomNumber.localRandom = new Random(seed));
            }
            return random.Next(min, max);
        }
    }
}