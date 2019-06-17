using System;

namespace Snappy.Common.Models.Requests
{
    public class UserListInfo
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PrimaryMobileNumber { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string PhoneExtension { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime? BornAt { get; set; }
        public DateTime? EmployeeStartedAt { get; set; }
        public DateTime? EmployeeTerminatedAt { get; set; }
        public string Department { get; set; }
        public string PositionTitle { get; set; }
        public Guid? ParentUserUid { get; set; }
        public string ParentUserEmail { get; set; }
        public Guid? BackupUserUid { get; set; }
        public string BackupUserEmail { get; set; }
        public string WelcomeUrl { get; set; }
        public bool IsActive { get; set; }
    }
}