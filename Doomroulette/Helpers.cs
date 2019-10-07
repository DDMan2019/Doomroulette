using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

        private static readonly PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pvd, [In] ref uint pcFonts);

        public static FontFamily LoadFont(byte[] fontResource)
        {
            int dataLength = fontResource.Length;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontResource, 0, fontPtr, dataLength);

            uint cFonts = 0;
            AddFontMemResourceEx(fontPtr, (uint)fontResource.Length, IntPtr.Zero, ref cFonts);
            privateFontCollection.AddMemoryFont(fontPtr, dataLength);

            return privateFontCollection.Families.Last();
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
