﻿using System;

using NodaTime;

namespace Snappy.Common.Models.DataTransferObjects
{
    public abstract class BaseDto
    {
        public Guid Uid { get; set; }
        public string Name { get; set; }

        public Instant CreatedAt { get; set; }
        public Instant? UpdatedAt { get; set; }
    }
}