using System;
using System.Collections.Generic;
using EpisodeNamespace;
using DescriptionNamespace;
using System.Globalization;
using System.IO;

namespace TvUtilitiesNamespace
{
    public  class TvUtilities
    {

        public static Episode Parse(string toParse)
        {
            CultureInfo culture = new CultureInfo("en-US");
            string[] atribute = toParse.Split(',');
            int viewerCount = int.Parse(atribute[0]);
            double scoreSum = double.Parse(atribute[1],culture);
            double maxScore = double.Parse(atribute[2],culture);
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


        public static List<Episode> LoadEpisodesFromFile(string fileName)
        {
            string[] episodesInString = File.ReadAllLines(fileName);
            List<Episode> episodesInSeason = new List<Episode>();
            for (int i = 0; i < episodesInString.Length; i++)
            {
                episodesInSeason.Add(Parse(episodesInString[i]));
            }
            return episodesInSeason;
        }
    }
}
