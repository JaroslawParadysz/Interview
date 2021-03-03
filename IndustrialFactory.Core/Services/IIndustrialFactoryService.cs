using IndustrialFactory.Core.DTO;
using System;
using System.Threading.Tasks;

namespace IndustrialFactory.Core.Services
{
    public interface IIndustrialFactoryService
    {
        Task<Guid> AddAsync(MeasurementDetailsDto dto);
        Task<MeasurementDetailsDto> GetAsync(Guid id);
        Task UpdateAsync(MeasurementDetailsDto dto);
        Task DeleteAsync(Guid id);
    }
}
