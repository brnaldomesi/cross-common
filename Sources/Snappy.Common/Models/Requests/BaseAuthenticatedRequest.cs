using System;

namespace Snappy.Common.Models.Requests
{
    public abstract class BaseAuthenticatedRequest : BaseRequest
    {
        public long CurrentOrganizationId { get; set; }
        public string CurrentOrganizationUid { get; set; }
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