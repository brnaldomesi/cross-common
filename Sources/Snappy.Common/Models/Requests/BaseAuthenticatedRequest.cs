namespace Snappy.Common.Models.Requests
{
    public abstract class BaseAuthenticatedRequest : BasePagedRequest
    {
        public long CurrentUserId { get; set; }

        protected BaseAuthenticatedRequest(long currentUserId)
        {
            if (currentUserId < 1)
            {
                ThrowArgumentException(nameof(currentUserId), currentUserId);
            }

            CurrentUserId = currentUserId;
        }
    }
}