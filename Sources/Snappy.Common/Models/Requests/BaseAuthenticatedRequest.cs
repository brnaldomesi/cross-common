namespace Snappy.Common.Models.Requests
{
    public abstract class BaseAuthenticatedRequest : BaseRequest
    {
        public long CurrentUserId { get;  }

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