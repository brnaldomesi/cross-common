using System;

using System.Collections.Generic;

namespace Snappy.Common.Models.Shared
{
    public class CurrentUser
    {
        public CurrentOrganization Organization { get; set; }
        public long OrganizationId => Organization.Id;
        public Guid OrganizationUid => Organization.Uid;

        public long Id { get; set; }
        public Guid Uid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ObfuscationSalt { get; set; }

        public List<RoleInfo> Roles { get; set; }

        public CurrentUser()
        {
            Roles = new List<RoleInfo>();
        }
    }
}