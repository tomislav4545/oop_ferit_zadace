using System;
using EpisodeNamespace;
using System.Collections.Generic;
using System.Collections;
using TvExceptionNamespace;

namespace SeasonNamespace
{
    
    public class Season : IEnumerable<Episode>
    {
        private int seasonNumber;
        List<Episode> episodesInSeason = new List<Episode>();

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

        public Season(int seasonNumber, List<Episode> episodes)
        {
            SeasonNumber = seasonNumber;
            for (int i = 0; i < episodes.Count; i++)
            {
                episodesInSeason.Add(episodes[i]);
            }
        }

        public Season(Season other)
        {
            SeasonNumber = other.SeasonNumber;
            episodesInSeason = new List<Episode>();
            episodesInSeason.AddRange(other.episodesInSeason);
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

        public Episode this[int i] => episodesInSeason[i];
        


        public IEnumerator<Episode> GetEnumerator()
        {
            foreach(Episode episode in episodesInSeason)
            {
                yield return episode;
            }             
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Episode episode)
        {
            episodesInSeason.Add(episode);
        }


        
        public void Remove(string episodeName)
        {
            var error = episodesInSeason.Find(item => item.Name == episodeName);
            if(error == null)
            {
                throw new TvException("No such episode found.",episodeName);
            }
            else
            {
                episodesInSeason.RemoveAll(item => item.Name == episodeName);
            }
        }
    }
}