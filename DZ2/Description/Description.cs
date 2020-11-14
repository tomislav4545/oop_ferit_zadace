using System;

namespace Description
{
    public class Description
    {
        int episodeNumber;
        TimeSpan episodeLength;
        string episodeName;
        
        public Description(int episodeNumber,TimeSpan episodeLength, string episodeName)
        {
            this.episodeNumber = episodeNumber;
            this.episodeLength = episodeLength;
            this.episodeName = episodeName;
        }

        public Description()
        {
            episodeNumber = 0;
            episodeLength = default(TimeSpan);
            episodeName = "NULL";

        }


    }
}
