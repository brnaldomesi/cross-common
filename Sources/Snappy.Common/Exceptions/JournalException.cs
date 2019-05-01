using System;

namespace Snappy.Common.Exceptions
{
    public class JournalException : Exception
    {
        public JournalException(string message) : base(message)
        {

        }
    }
}