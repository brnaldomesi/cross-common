using NodaTime;

namespace Snappy.Common.Models.DataTransferObjects
{
    public abstract class BaseDto
    {
        public Instant CreatedAt { get; set; }
        public Instant? UpdatedAt { get; set; }
    }
}