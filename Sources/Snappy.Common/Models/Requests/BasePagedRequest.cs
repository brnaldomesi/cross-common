using System;

namespace Snappy.Common.Models.Requests
{
    public abstract class BasePagedRequest : BaseRequest
    {
        /// <summary>
        /// if skip is greater than 0
        /// service does not checks for LastUid
        /// </summary>
        public int Skip { get; set; }
        
        /// <summary>
        /// To use last uid ensure Skip is 0
        /// </summary>
        public Guid LastUid { get; set; }

        public int Take { get; set; }
        public bool IsAscending { get; set; }
    }
}