using System;

namespace Snappy.Common.Models.Requests
{
    public abstract class BasePagedRequest : BaseRequest
    {
        public int Skip { get; set; }
        public int Take { get; set; }

        public string LastUid { get; set; }
        public bool IsAscending { get; set; }
    }
}