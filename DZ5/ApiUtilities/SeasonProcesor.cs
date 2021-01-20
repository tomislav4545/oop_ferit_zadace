using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ApiUtilities
{
    public class SeasonProcesor
    {
        public static List<SeasonModel> LoadSeasons(int id)
        {
            using (var webClient = new WebClient())
            {
                string strId = id.ToString();
                string rawJson = webClient.DownloadString($"http://api.tvmaze.com/shows/{strId}/seasons");
                rawJson = rawJson.Replace("<br />", "");
                rawJson = rawJson.Replace("<p>", "");
                rawJson = rawJson.Replace("</p>", "");
                if (string.IsNullOrWhiteSpace(rawJson))
                    return new List<SeasonModel>();

                return JsonConvert.DeserializeObject<List<SeasonModel>>(rawJson);
            }


        }
    }
}
