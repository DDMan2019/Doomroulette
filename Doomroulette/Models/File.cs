using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doomroulette.Models
{

    public class File
    {
        public int id { get; set; }
        public string title { get; set; }
        public string dir { get; set; }
        public string filename { get; set; }
        public int size { get; set; }
        public int age { get; set; }
        public string date { get; set; }
        public string author { get; set; }
        public string email { get; set; }
        public string description { get; set; }
        public float rating { get; set; }
        public int votes { get; set; }
        public string url { get; set; }
        public string idgamesurl { get; set; }
    }



}
