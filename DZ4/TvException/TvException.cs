using System;

namespace TvExceptionNamespace
{
    public class TvException : Exception
    {
        public string Title { get; }

        public TvException() { }

        public TvException(string message)
            : base(message) { }

        public TvException(string message, Exception inner)
            : base(message, inner) { }

        public TvException(string message, string episodeName)
            : this(message)
        {
            Title = episodeName;
        }

    }
}
