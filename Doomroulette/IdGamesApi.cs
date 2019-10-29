using Newtonsoft.Json;
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
        private static string idUrl = "https://www.doomworld.com/idgames/api/api.php";
        
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
                                wadId = (int)content["id"],
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

    }
}
