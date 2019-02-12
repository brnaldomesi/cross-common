using System;

namespace Snappy.Common.Models.Requests
{
    public abstract class BaseAuthenticatedRequest : BaseRequest
    {
        public long OrganizationId { get; set; }
        public string OrganizationUid { get; set; }
        public long CurrentUserId { get; set; }

        protected BaseAuthenticatedRequest(long currentUserId)
        {
            if (currentUserId < 1)
            {
                throw new ArgumentException(nameof(currentUserId));
            }

            CurrentUserId = currentUserId;
        }
    }
}