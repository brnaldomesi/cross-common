using System.Collections.Generic;

namespace Snappy.Common.Models.Shared
{
    public class RoleInfo
    {
        public List<PermissionInfo> Permissions { get; set; }

        public RoleInfo()
        {
            Permissions = new List<PermissionInfo>();
        }
    }
}