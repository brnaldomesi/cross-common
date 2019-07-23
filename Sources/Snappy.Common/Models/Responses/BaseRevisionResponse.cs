using System.Collections.Generic;

using Snappy.Common.Models.DataTransferObjects;

namespace Snappy.Common.Models.Responses
{
    public abstract class BaseRevisionResponse<T> : BaseResponse where T : BaseDto, new()        
    {        
        public List<RevisionDto<T>> Items { get; set; }        

        protected BaseRevisionResponse()
        {
            Items = new List<RevisionDto<T>>();
        }
    }
}