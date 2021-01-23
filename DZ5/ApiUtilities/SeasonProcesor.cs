using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
                rawJson.Replace("&nbsp;", string.Empty);
                rawJson = Regex.Replace(rawJson, "<.*?>", String.Empty);
                if (string.IsNullOrWhiteSpace(rawJson))
                    return new List<SeasonModel>();

                return JsonConvert.DeserializeObject<List<SeasonModel>>(rawJson);
            }


        }
    }
}
