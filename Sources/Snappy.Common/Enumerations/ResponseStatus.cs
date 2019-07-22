using System;

using Snappy.Common.Enumerations.Base;

namespace Snappy.Common.Enumerations
{
    public class ResponseStatus : Enumeration
    {
        public static readonly ResponseStatus Unknown = new ResponseStatus(0, "Unknown", "not_informed_reason");
        public static readonly ResponseStatus Success = new ResponseStatus(1, "Success", "worked_successfully");
        public static readonly ResponseStatus Failed = new ResponseStatus(2, "Failed", "request_failed");
        public static readonly ResponseStatus Invalid = new ResponseStatus(3, "Invalid", "request_not_valid");
        public static readonly ResponseStatus InvalidBecauseEntityNotFound = new ResponseStatus(4, "InvalidBecauseEntityNotFound", "request_failed_because_entity_not_found");
        public static readonly ResponseStatus SuccessWithProblems = new ResponseStatus(5, "SuccessWithProblems", "worked_successfully_but_some_parts_are_missing_check_messages");

        private ResponseStatus(int value, string name, string description) : base(value, Guid.NewGuid(), name, description) { }

        public bool IsSuccess => Value == Success.Value || Value == SuccessWithProblems.Value;
        public bool IsNotSuccess => !IsSuccess;
    }
}