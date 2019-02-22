using System;
using System.Collections.Generic;

namespace Snappy.Common.Models.Shared
{
    public class CurrentUser
    {
        public long OrganizationId
        {
            get { return Organization.Id; }
        }
        public Guid OrganizationUid
        {
            get { return Organization.Uid; }
        }
        public CurrentOrganization Organization { get; set; }

        public int Id { get; set; }
        public string Uid { get; set; }
        public string ObfuscationSalt { get; set; }

        public List<RoleInfo> Roles { get; set; }

        public CurrentUser()
        {
            Roles = new List<RoleInfo>();
        }
    }
}