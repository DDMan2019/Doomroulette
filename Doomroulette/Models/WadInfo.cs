using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doomroulette.Models
{
    public class WadInfo
    {
        public Content content { get; set; }
        public Meta meta { get; set; }
    }

    public class Content
    {
        public int id { get; set; }
        public int wadId { get; set; }
        public string title { get; set; }
        public string dir { get; set; }
        public string filename { get; set; }
        public long size { get; set; }
        public DateTime age { get; set; }
        public string date { get; set; }
        public string author { get; set; }
        public object email { get; set; }
        public string description { get; set; }
        public object credits { get; set; }
        public string _base { get; set; }
        public string buildtime { get; set; }
        public string editors { get; set; }
        public string bugs { get; set; }
        public string textfile { get; set; }
        public float rating { get; set; }
        public int votes { get; set; }
        public string url { get; set; }
        public string idgamesurl { get; set; }
        public Review[] reviews { get; set; }
    }

    public class Reviews
    {
        public Review[] review { get; set; }
    }

    public class Review
    {
        public string text { get; set; }
        public int vote { get; set; }
        public string username { get; set; }
    }

    public class Meta
    {
        public int version { get; set; }
    }

    
}
