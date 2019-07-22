using System;

using Snappy.Common.Enumerations.Base;

namespace Snappy.Common.Enumerations
{
    public class Importance : Enumeration
    {
        public static readonly Importance Unknown = new Importance(1, new Guid("3B0F5D3C642D4E8C87C0846AFEF9D054"), "Unknown");
        public static readonly Importance High = new Importance(2, new Guid("6D20562C0ADE4B9C98DCF2219B6EC7CE"), "High");
        public static readonly Importance Normal = new Importance(3, new Guid("99FFA9314B4442718BEFF1B49F19DC24"), "Normal");
        public static readonly Importance Low = new Importance(4, new Guid("1D4AF332A20C4602B53D744AFA1887C1"), "Low");

        private Importance(int value, Guid uid, string name) : base(value, uid, name) { }
    }
}