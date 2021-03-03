using System;

namespace IndustrialFactory.Core.Exceptions
{
    public class MeasurementNotFoundException : Exception
    {
        public MeasurementNotFoundException(Guid id) : base($"Measurement with id {id} was not found.") { }
    }
}
