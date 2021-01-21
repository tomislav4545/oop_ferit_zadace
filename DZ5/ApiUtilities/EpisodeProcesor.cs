using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiUtilities
{
    public class EpisodeProcesor
    {
        public static List<EpisodeModel> LoadEpisodes(int id)
        {
            using (var webClient = new WebClient())
            {
                string strId = id.ToString();
                string rawJson = webClient.DownloadString($"http://api.tvmaze.com/seasons/{strId}/episodes");
                rawJson = rawJson.Replace("<br />", "");
                rawJson = rawJson.Replace("<p>", "");
                rawJson = rawJson.Replace("</p>", "");
                rawJson = rawJson.Replace("null", "0");
                if (string.IsNullOrWhiteSpace(rawJson))
                    return new List<EpisodeModel>();

                return JsonConvert.DeserializeObject<List<EpisodeModel>>(rawJson);
            }


        }
    }
}
