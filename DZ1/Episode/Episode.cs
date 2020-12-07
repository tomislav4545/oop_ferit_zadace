using System;
using DescriptionNamespace;
namespace EpisodeNamespace
{
    public class Episode
    {
        private int viewerCount;
        private double scoreSum;
        private double maxScore;
        Description description = new Description();

        public Episode(int viewerCount, double scoreSum, double maxScore)
        {
            this.viewerCount = viewerCount;
            this.scoreSum = scoreSum;
            this.maxScore = maxScore;
        }
        public Episode() {
            viewerCount = 0;
            scoreSum = 0;
            maxScore = 0;
        }
        public Episode(int viewerCount, double scoreSum, double maxScore, Description description)
        {
            this.viewerCount = viewerCount;
            this.scoreSum = scoreSum;
            this.maxScore = maxScore;
            this.description.Number = description.Number;
            this.description.Length = description.Length;
            this.description.Name = description.Name;
        }

        public int GetViewerCount()
        {
            return viewerCount;
        }


        public double GetAverageScore()
        {
            return (scoreSum / viewerCount);
        }


        public void AddView(double scoreSum)
        {
            this.scoreSum = scoreSum + this.scoreSum;

            if (scoreSum > this.maxScore)
            {
                this.maxScore = scoreSum;
            }
            this.viewerCount += 1;

        }

       

        public double GetMaxScore()
        {
            return maxScore;
        }
        
        public int Count
        {
            get
            {
                return this.viewerCount;
            }
            set
            {
                this.viewerCount = value;
            }
        }

        public double Sum
        {
            get
            {
                return this.scoreSum;
            }
            set
            {
                this.scoreSum = value;
            }
        }

        public double Max
        {
            get
            {
                return this.maxScore;
            }
            set
            {
                this.maxScore = value;
            }
        }

        public override string ToString()
        {
            return  viewerCount + "," + scoreSum + "," + maxScore + "," + description.Number + "," + description.Length + "," + description.Name ;
        }
        public static bool operator <(Episode episode1, Episode episode2)
        {
            if (episode1.GetAverageScore() < episode2.GetAverageScore())
                return true;
            else return false;
        }

        public static bool operator >(Episode episode1, Episode episode2)
        {
            if (episode1.GetAverageScore() > episode2.GetAverageScore())
                return true;
            else return false;
        }

        public TimeSpan GetEpisodeDuration()
        {
            return description.Length;
        }


    }

}