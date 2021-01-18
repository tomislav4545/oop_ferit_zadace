using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace ApiUtilities
{
    public class ShowProcessor
    {
        public static List<Root> LoadShows(string searchQuarey)
        {
            using (var webClient = new WebClient())
            {
                string rawJson = webClient.DownloadString($"http://api.tvmaze.com/search/shows?q={searchQuarey}");
                if (string.IsNullOrWhiteSpace(rawJson))
                    return new List<Root>();

                return JsonConvert.DeserializeObject<List<Root>>(rawJson);
            }
            

        }
      
    }


}
