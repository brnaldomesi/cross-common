using System;

namespace Snappy.Common.Models.Responses
{
    [Serializable]
    public class TokenResponse
    {
        public bool isOk { get; set; }
        public Guid token { get; set; }
    }
}