namespace Snappy.Common.Models.Shared
{
    public class CurrentOrganization
    {
        public long OrganizationId { get; set; }
        public string OrganizationUid { get; set; }
        public string OrganizationName { get; set; }

        public string ObfuscationKey { get; set; }
        public string ObfuscationIV { get; set; }
    }
}