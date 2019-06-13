using System;



namespace Snappy.Common.Models.DataTransferObjects
{
    public abstract class BaseDto
    {
        public Guid Uid { get; set; }
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}