﻿using System.Collections.Generic;

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
    }

    public abstract class BaseResponse<T> : BaseResponse where T : BaseDto, new()
    {
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