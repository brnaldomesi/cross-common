namespace Snappy.Common.Enumerations
{
    public class Importance : Enumeration
    {
        public static readonly Importance Unknown = new Importance(0, "Unknown");
        public static readonly Importance High = new Importance(1, "High");
        public static readonly Importance Normal = new Importance(2, "Normal");
        public static readonly Importance Low = new Importance(3, "Low");

        private Importance(int value, string displayName) : base(value, displayName) { }
    }
}