using System;

namespace Snappy.Common.Models.Responses
{
    [Serializable]
    public class TokenResponse
    {
        public Guid token { get; set; }
    }
}