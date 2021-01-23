using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace ApiUtilities
{
    public class ShowProcessor
    {
        public static List<ShowModel> LoadShows(string searchQuarey)
        {
            using (var webClient = new WebClient())
            {
                string rawJson = webClient.DownloadString($"http://api.tvmaze.com/search/shows?q={searchQuarey}");
                rawJson.Replace("&nbsp;", string.Empty);
                rawJson = Regex.Replace(rawJson, "<.*?>", String.Empty);
                if (string.IsNullOrWhiteSpace(rawJson))
                    return new List<ShowModel>();

                return JsonConvert.DeserializeObject<List<ShowModel>>(rawJson);
            }
            

        }
      
    }


}
