using Factory.Core.Repositories;
using IndustrialFactory.Core.DTO;
using IndustrialFactory.Core.Entities;
using IndustrialFactory.Core.Exceptions;
using System;
using System.Threading.Tasks;

namespace IndustrialFactory.Core.Services
{
    public class IndustrialFactoryService : IIndustrialFactoryService
    {
        private IRepository Repository { get; }
        public IndustrialFactoryService(IRepository repository)
        {
            Repository = repository;
        }
        
        public async Task<Guid> AddAsync(MeasurementDetailsDto dto)
        {
            var toAdd = new Measurement { Id = Guid.NewGuid(), CreatedAt = DateTime.UtcNow, Timestamp = dto.Timestamp, Value = dto.Value };
            await Repository.AddAsync(toAdd);

            return toAdd.Id;
        }

        public async Task DeleteAsync(Guid id)
        {
            var measurement = await Repository.GetAsync(id);
            if (measurement is null)
            {
                throw new MeasurementNotFoundException(id);
            }

            await Repository.DeleteAsync(measurement);
        }

        public async Task<MeasurementDetailsDto> GetAsync(Guid id)
        {
            var measurement = await Repository.GetAsync(id);
            if (measurement is null)
            {
                throw new MeasurementNotFoundException(id);
            }

            return new MeasurementDetailsDto { Id = measurement.Id, Timestamp = measurement.Timestamp, Value = measurement.Value };
        }

        public async Task UpdateAsync(MeasurementDetailsDto dto)
        {
            var measurement = await Repository.GetAsync(dto.Id);
            if (measurement is null)
            {
                throw new MeasurementNotFoundException(dto.Id);
            }

            measurement.Timestamp = dto.Timestamp;
            measurement.Value = dto.Value;

            await Repository.UpdateAsync(measurement);
        }
    }
}
