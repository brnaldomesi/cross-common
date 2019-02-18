using System.Collections.Generic;

using Snappy.Common.Enumerations;
using Snappy.Common.Models.DataTransferObjects;

namespace Snappy.Common.Models.Responses
{
    public abstract class BaseResponse<T> where T : BaseDto
    {
        public ResponseStatus Status { get; set; }
        public List<string> ErrorMessages { get; set; }
        public List<string> SuccessMessages { get; set; }
        public List<string> WarningMessages { get; set; }
        public List<string> InfoMessages { get; set; }

        public T Item { get; set; }
        public List<T> Items { get; set; }

        protected BaseResponse()
        {
            Status = ResponseStatus.Unknown;

            ErrorMessages = new List<string>();
            SuccessMessages = new List<string>();
            WarningMessages = new List<string>();
            InfoMessages = new List<string>();

            Items = new List<T>();
        }
    }
}