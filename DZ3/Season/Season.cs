using System;
using EpisodeNamespace;
using System.Collections.Generic;

namespace SeasonNamespace
{
    public class Season
    {
        private int seasonNumber;
        int SeasonNumber
        {
            get
            {
                return seasonNumber;
            }
            set
            {
                seasonNumber = value;
            }
        }

        List<Episode> episodesInSeason = new List<Episode>();

        int TotalViewerCount()
        {
            int viewers = 0;
            foreach(Episode episode in episodesInSeason)
            {
                viewers += episode.GetViewerCount();
            }
            return viewers;
        }
        TimeSpan TotalDuration()
        {
            TimeSpan duration = default(TimeSpan);
            foreach(Episode episode in episodesInSeason)
            {
                duration += episode.GetEpisodeDuration();
            }
            return duration;
        }

        public Season(int seasonNumber, Episode[] episodes)
        {
            SeasonNumber = seasonNumber;
            for(int i = 0; i < episodes.Length; i++)
            {
                episodesInSeason.Add(episodes[i]);
            }
        }

        public override string ToString()
        {
            string str = string.Join(Environment.NewLine, episodesInSeason);
            string spacer = "=================================================\n";
            return $"Season {seasonNumber}:\n{spacer}{str}\n{spacer}Total viewers: {TotalViewerCount()}\nTotal duration: {TotalDuration()}\n{spacer}";
        }

        public int Length
        {
            get => episodesInSeason.Count;
        }

        public Episode this[int index]
        {
            get 
            { 
                return episodesInSeason[index];
            }
            set
            { 
                episodesInSeason[index] = value;
            }
        }
    }
}
