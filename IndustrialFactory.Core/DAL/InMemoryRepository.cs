using Factory.Core.Repositories;
using IndustrialFactory.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndustrialFactory.Core.DAL
{
    public class InMemoryRepository : IRepository
    {
        public async Task AddAsync(Measurement measurement)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Measurement measurement)
        {
            throw new NotImplementedException();
        }

        public async Task<Measurement> GetAsync(Guid id)
        {
            throw new NotImplementedException(); ;
        }

        public async Task UpdateAsync(Measurement measurement)
        {
            throw new NotImplementedException();
        }
    }
}
