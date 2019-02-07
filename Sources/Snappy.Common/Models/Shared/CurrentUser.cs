using System.Collections.Generic;

namespace Snappy.Common.Models.Shared
{
    public class CurrentUser
    {
        public int Id { get; set; }
        public string Uid { get; set; }

        public int OrganizationId
        {
            get { return Organization.OrganizationId; }
        }
        public string OrganizationUid
        {
            get { return Organization.OrganizationUid; }
        }
        public CurrentOrganization Organization { get; set; }
        public List<RoleInfo> Roles { get; set; }

        public CurrentUser()
        {
            Roles = new List<RoleInfo>();
        }
    }
}