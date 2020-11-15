using System;
using System.Security.Cryptography;
using DescriptionNamespace;
namespace EpisodeNamespace
{
    public class Episode
    {
        private int viewerCount;
        private double scoreSum;
        private double maxScore;

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

        public double GenerateRandomScore()
        {
            Random rand = new Random();
            double randScore = rand.NextDouble() * 10;
            return randScore;
        }

        public double GetMaxScore()
        {
            return maxScore;
        }

    }

}