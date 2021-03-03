using IndustrialFactory.Core.Entities;
using System;
using System.Threading.Tasks;

namespace Factory.Core.Repositories
{
    public interface IRepository
    {
        Task AddAsync(Measurement measurement);
        Task<Measurement> GetAsync(Guid id);
        Task UpdateAsync(Measurement measurement);
        Task DeleteAsync(Measurement measurement);
    }
}
