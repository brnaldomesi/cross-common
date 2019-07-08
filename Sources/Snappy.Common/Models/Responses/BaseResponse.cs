using System;
using System.Collections.Generic;

using Snappy.Common.Enumerations;
using Snappy.Common.Models.DataTransferObjects;
using Snappy.Common.Models.Shared;

namespace Snappy.Common.Models.Responses
{
    public abstract class BaseResponse
    {
        public ResponseStatus Status { get; set; }
        public List<string> ErrorMessages { get; set; }
        public List<string> SuccessMessages { get; set; }
        public List<string> WarningMessages { get; set; }
        public List<string> InfoMessages { get; set; }

        protected BaseResponse()
        {
            Status = ResponseStatus.Unknown;

            ErrorMessages = new List<string>();
            SuccessMessages = new List<string>();
            WarningMessages = new List<string>();
            InfoMessages = new List<string>();
        }
            
        public void SetInvalid()
        {
            Status = ResponseStatus.Invalid;
            ErrorMessages.Add(ResponseStatus.Invalid.Description);
        }

        public void SetInvalidBecauseEntityNotFound()
        {
            Status = ResponseStatus.InvalidBecauseEntityNotFound;
            ErrorMessages.Add(ResponseStatus.InvalidBecauseEntityNotFound.Description);
        }

        public void SetInvalidForDeleteBecauseHasChildren()
        {
            Status = ResponseStatus.Invalid;
            ErrorMessages.Add("can_not_delete_because_has_children_entity");
        }

        public void SetInvalidBecauseParentNotActive()
        {
            Status = ResponseStatus.Invalid;
            ErrorMessages.Add("action_is_invalid_because_parent_entity_is_not_active");
        }

        public void SetInvalidBecauseEntityNotActive()
        {
            Status = ResponseStatus.Invalid;
            ErrorMessages.Add("action_is_invalid_because_entity_is_not_active");
        }

        public void SetFailed()
        {
            Status = ResponseStatus.Failed;
            ErrorMessages.Add(ResponseStatus.Failed.Description);
        }
    }

    public abstract class BaseResponse<T> : BaseResponse where T : BaseDto, new()
    {
        public Guid ItemUid { get; set; }
        public T Item { get; set; }
        public List<T> Items { get; set; }

        public PagingInfo PagingInfo { get; set; }

        protected BaseResponse()
        {
            Item = new T();
            Items = new List<T>();

            PagingInfo = new PagingInfo();
        }
    }
}