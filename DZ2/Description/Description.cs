using System;

namespace DescriptionNamespace
{
    public class Description
    {
        int episodeNumber;
        TimeSpan episodeLength;
        string episodeName;

        public Description(int episodeNumber, TimeSpan episodeLength, string episodeName)
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

        public int Number
        {
            get
            {
                return this.episodeNumber;
            }
            set
            {
                this.episodeNumber = value;
            }
        }

        public TimeSpan Length{
            get
            {
                return this.episodeLength;
            }
            set
            {
                this.episodeLength = value;
            }
        }
        public string Name {
            get
            {
                return this.episodeName;
            }
            set
            {
                this.episodeName = value;
            }
        }

        public override string ToString()
        {
            return "" + episodeNumber + "," + episodeLength + "," + episodeName;
        }
    }
}
