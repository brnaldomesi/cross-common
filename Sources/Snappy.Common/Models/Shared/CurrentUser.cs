namespace Snappy.Common.Models.Shared
{
    public class CurrentUser
    {
        public int Id { get; set; }
        public string Uid { get; set; }

        public int OrganizationId { get; set; }
        public string OrganizationUid { get; set; }
    }
}