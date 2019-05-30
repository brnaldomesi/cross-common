using System;

namespace Snappy.Common.Enumerations.Base
{
    public interface IEnumerationWithUid
    {
        Guid Uid { get;  }
        int Value { get; }
        string DisplayName { get; }
    }
}