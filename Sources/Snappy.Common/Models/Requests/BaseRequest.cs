using System;

namespace Snappy.Common.Models.Requests
{
    public abstract class BaseRequest
    {
        public void ThrowArgumentException(string argumentName, string value)
        {
            throw new ArgumentException(argumentName + " => " + value);
        }
    }
}