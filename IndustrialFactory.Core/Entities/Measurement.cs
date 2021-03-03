using System;

namespace IndustrialFactory.Core.Entities
{
    public class Measurement
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Value { get; set; }
    }
}
