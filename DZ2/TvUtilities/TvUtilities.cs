using System;
using EpisodeNamespace;
using DescriptionNamespace;
namespace TvUtilitiesNamespace
{
    public  class TvUtilities
    {

        public static Episode Parse(string toParse)
        {
            string[] atribute = toParse.Split(',');
            int viewerCount = int.Parse(atribute[0]);
            double scoreSum = double.Parse(atribute[1]);
            double maxScore = double.Parse(atribute[2]);
            int episodeNumber = int.Parse(atribute[3]);
            TimeSpan episodeLength = TimeSpan.Parse(atribute[4]);
            string episodeName = atribute[5];
            Description tempDescription = new Description(episodeNumber, episodeLength, episodeName);
            return new Episode(viewerCount, scoreSum, maxScore, tempDescription);
            
        }

        public static void Sort(Episode[] episodes)
        {
            Episode tempEpisode = new Episode();
            for(int i = 0; i < episodes.Length; i++)
            {
                for(int j = i + 1; j < episodes.Length - 1; j++) {
                    if (episodes[i] < episodes[j])
                    {
                        tempEpisode = episodes[j];
                        episodes[j] = episodes[i];
                        episodes[i] = tempEpisode;
                    }
                }
                
            }
            
        }
        



        public static double GenerateRandomScore()
        {
            Random rand = new Random();
            double randScore = rand.NextDouble() * 10;
            return randScore;
        }
    }
}
