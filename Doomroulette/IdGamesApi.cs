﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Doomroulette.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Doomroulette
{
    
    static class IdGamesApi
    {
        //https://www.doomworld.com/idgames/api/
        //ftp://archives.gamers.org/pub/games/doom2/levels/doom2/megawads/
        private static readonly HttpClient client = new HttpClient();
        private static string idUrl = "https://www.doomworld.com/idgames/api/api.php";
        

        public static WadInfo getWadInfo(int id)
        {
            string action = String.Format("?action=get&id={0}&out=json",id);
            using (var webClient = new WebClient())
            {
                string rawJson = webClient.DownloadString(idUrl + action);
                var json = JObject.Parse(rawJson);
                if(json["content"] != null)
                {
                    var content = json["content"];
                    var reviewsjson = content["reviews"];
                    var reviews = reviewsjson["review"];
                    List<Review> foundRewievs = new List<Review>();
                    foreach(var review in reviews)
                    {
                        string _text = (string)review["text"];
                        foundRewievs.Add(new Review()
                        {
                            text = (string)review["text"],
                            vote = (int) review["vote"],
                            username = (string)review["username"]
                        });
                    }
                    
                    WadInfo wadInfo = new WadInfo()
                    {
                        content = new Content()
                        {
                            id = (int)content["id"],
                            title = (string)content["title"],
                            dir = (string)content["dir"],
                            filename = (string)content["filename"],
                            size = (long)content["size"],
                            age = Helpers.FromUnixTime((long)content["age"]),
                            date = (string)content["date"],
                            author = (string)content["author"],
                            email = (string)content["email"],
                            description = (string)content["description"],
                            credits = (string)content["credits"],
                            buildtime = (string)content["buildtime"],
                            editors = (string)content["editors"],
                            bugs = (string)content["bugs"],
                            textfile = (string)content["textfile"],
                            rating = (float)content["rating"],
                            votes = (int)content["votes"],
                            url = (string)content["url"],
                            idgamesurl = (string)content["idgamesurl"],
                            reviews = foundRewievs.ToArray(),
                            _base = (string)content["base"],

                        }
                    };

                    return wadInfo;
                } else {
                    return null;
                }

                
            }

        }

        public static WadInfo[] getWads(string[] directories)
        {
            List<WadInfo> foundWads = new List<WadInfo>();
            foreach (string directory in directories)
            {
                foundWads.AddRange(getContents(directory));
            }
            return foundWads.ToArray();
        }

        public static WadInfo[] getContents(string name)
        {
            //levels/doom/megawads/
            string action = String.Format("?action=getfiles&name={0}&out=json", name);
            List<WadInfo> foundWads = new List<WadInfo>();
            using (var webClient = new WebClient())
            {
                string rawJson = webClient.DownloadString(idUrl + action);
                var json = JObject.Parse(rawJson);
                if (json["content"] != null)
                {
                    var contents = json["content"];
                    var files = contents["file"];
                    
                    foreach (var content in files)
                    {
                        WadInfo wadInfo = new WadInfo()
                        {
                            content = new Content()
                            {
                                id = (int)content["id"],
                                title = (string)content["title"],
                                dir = (string)content["dir"],
                                filename = (string)content["filename"],
                                size = (long)content["size"],
                                age = Helpers.FromUnixTime((long)content["age"]),
                                date = (string)content["date"],
                                author = (string)content["author"],
                                email = (string)content["email"],
                                description = (string)content["description"],
                                credits = (string)content["credits"],
                                buildtime = (string)content["buildtime"],
                                editors = (string)content["editors"],
                                bugs = (string)content["bugs"],
                                textfile = (string)content["textfile"], //Is always null from the api.
                                rating = (float)content["rating"],
                                votes = (int)content["votes"],
                                url = (string)content["url"],
                                idgamesurl = (string)content["idgamesurl"],
                                _base = (string)content["base"],

                            }
                        };
                        foundWads.Add(wadInfo);
                        

                    }
                }
                else
                {
                    //Something went wrong
                }
            }
            return foundWads.ToArray();
        }

        public static string cleanForJSON(string s)
        {
            if (s == null || s.Length == 0)
            {
                return "";
            }

            char c = '\0';
            int i;
            int len = s.Length;
            StringBuilder sb = new StringBuilder(len + 4);
            String t;

            for (i = 0; i < len; i += 1)
            {
                c = s[i];
                switch (c)
                {
                    //case '\\':
                    case '"':
                        sb.Append("\"");
                        //sb.Append(c);
                        break;
                    //case '/':
                    //    sb.Append('\\');
                    //    sb.Append(c);
                    //    break;
                    case '\b':
                        sb.Append("\\b");
                        break;
                    case '\t':
                        sb.Append("\\t");
                        break;
                    case '\n':
                        //sb.Append("\\n");
                        break;
                    case '\f':
                        sb.Append("\\f");
                        break;
                    case '\r':
                        sb.Append("\\r");
                        break;
                    case '\\':

                        break;
                    default:
                        if (c < ' ')
                        {
                            t = "000" + String.Format("X", c);
                            sb.Append("\\u" + t.Substring(t.Length - 4));
                        }
                        else
                        {
                            sb.Append(c);
                        }
                        break;
                }
            }
            return sb.ToString();
        }

    }
}