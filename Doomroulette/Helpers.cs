using System;
using System.Linq;

namespace Doomroulette
{
    class Helpers
    {
        
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
       
    }
}
