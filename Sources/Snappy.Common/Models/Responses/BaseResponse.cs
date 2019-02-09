using Snappy.Common.Enumerations;

namespace Snappy.Common.Models.Responses
{
    public abstract class BaseResponse
    {
        public ResponseStatus Status { get; set; }

        protected BaseResponse()
        {
            Status = ResponseStatus.Unknown;
        }
    }
}