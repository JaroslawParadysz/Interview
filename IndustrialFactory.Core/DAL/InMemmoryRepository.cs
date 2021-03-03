using Factory.Core.Repositories;
using IndustrialFactory.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndustrialFactory.Core.DAL
{
    public class InMemmoryRepository : IRepository
    {
        private static List<Measurement> Store = new List<Measurement>();
        public async Task AddAsync(Measurement measurement)
        {
            await Task.CompletedTask;
            Store.Add(measurement);
        }

        public async Task DeleteAsync(Measurement measurement)
        {
            await Task.CompletedTask;
            Store.Remove(measurement);
        }

        public async Task<Measurement> GetAsync(Guid id)
        {
            await Task.CompletedTask;
            return Store.SingleOrDefault(x => x.Id == id);
        }

        public async Task UpdateAsync(Measurement measurement)
        {
            await Task.CompletedTask;
            var updated = Store.SingleOrDefault(x => x.Id == measurement.Id);
            updated.Timestamp = measurement.Timestamp;
            updated.Value = measurement.Value;
        }
    }
}
