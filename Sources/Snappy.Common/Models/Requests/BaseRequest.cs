using System;

namespace Snappy.Common.Models.Requests
{
    public abstract class BaseRequest
    {
        public void ThrowArgumentException(string argumentName, object value)
        {
            throw new ArgumentException(argumentName + " => " + value);
        }
    }
}