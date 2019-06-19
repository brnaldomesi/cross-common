using System;

namespace Snappy.Common.Models.DataTransferObjects
{
    public abstract class BaseDto
    {
        public Guid Uid { get; set; }
        public string Name { get; set; }

        public Guid CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public string UpdatedByName { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}