using System;

namespace Snappy.Common.Models.Shared
{
    public class CurrentOrganization
    {
        public long Id { get; set; }
        public Guid Uid { get; set; }
        public string Name { get; set; }

        public string ObfuscationKey { get; set; }
        public string ObfuscationIV { get; set; }
    }
}