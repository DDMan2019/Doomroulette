using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doomroulette
{
    class Helpers
    {
        public static DateTime today = DateTime.Today;

        public static DateTime FromUnixTime(long unixTime)
        {
            return epoch.AddSeconds(unixTime);
        }
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static bool arrayIsSimilar(int[] arr1, int[] arr2)
        {
            for(int i = 0; i < arr1.Length; i++)
            {
                if (!arr2.Contains(arr1[i]))
                {
                    return false;
                }
            }
                
            return true;
        }

        public static void log(string str)
        {
            try
            {
                Console.WriteLine(today + ": " + str);
                if (!Directory.Exists("logs"))
                {
                    Directory.CreateDirectory("logs");
                }

                StringBuilder sb = new StringBuilder();
                sb.AppendLine(today + ": " + str);
                string filename = "logs/log" + today.ToString("yyyyMMdd") + ".txt";

                File.AppendAllText(filename, sb.ToString());
                sb.Clear();
            }
            catch (Exception e)
            {
                log(str);
            }

        }
    }
}
