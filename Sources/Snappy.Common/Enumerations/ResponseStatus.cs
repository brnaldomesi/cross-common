namespace Snappy.Common.Enumerations
{
    public class ResponseStatus : Enumeration
    {
        public static readonly ResponseStatus Unknown = new ResponseStatus(0, "Unknown");
        public static readonly ResponseStatus Success = new ResponseStatus(1, "Success");
        public static readonly ResponseStatus Failed = new ResponseStatus(2, "Failed");

        private ResponseStatus(int value, string displayName) : base(value, displayName) { }

        public bool IsSuccess { get { return Value == Success.Value && DisplayName == Success.DisplayName; } }
        public bool IsNotSuccess { get { return !IsSuccess; } }
    }
}