using System;

namespace TvUtilitiesNamespace
{
    public class TvUtilities
    {





        public double GenerateRandomScore()
        {
            Random rand = new Random();
            double randScore = rand.NextDouble() * 10;
            return randScore;
        }
    }
}
