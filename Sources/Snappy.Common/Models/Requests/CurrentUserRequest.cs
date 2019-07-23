using Snappy.Common.Helpers;

namespace Snappy.Common.Models.Requests
{
    public sealed class CurrentUserRequest : BaseRequest
    {
        public string Email { get; set; }

        public CurrentUserRequest(string email)
        {
            if (email.IsNotEmail())
            {
                ThrowArgumentException(nameof(email), email);
            }

            Email = email;
        }
    }
}