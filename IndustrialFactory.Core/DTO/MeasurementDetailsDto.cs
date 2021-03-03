using System;

namespace IndustrialFactory.Core.DTO
{
    public class MeasurementDetailsDto
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public int Value { get; set; }
    }
}
