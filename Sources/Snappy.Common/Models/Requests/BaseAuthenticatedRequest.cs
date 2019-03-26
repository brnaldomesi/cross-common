namespace Snappy.Common.Models.Requests
{
    public abstract class BaseAuthenticatedRequest : BaseRequest
    {
        public long CurrentUserId { get; set; }

        protected BaseAuthenticatedRequest(long currentUserId)
        {
            //todo: giriş yapıldığında currentUserId 0 geliyor
           if (currentUserId < 1)
           {
               ThrowArgumentException(nameof(currentUserId), currentUserId);
           }

            CurrentUserId = currentUserId;
        }
    }
}