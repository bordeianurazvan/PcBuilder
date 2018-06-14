using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repository.Base;
using Data.Core.Domain;
using Data.Core.Interfaces;
using Data.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Business.Repository
{
    public class CoolerRepository: GenericRepository<Cooler>, ICoolerRepository
    {
        public CoolerRepository(DatabaseContext context) : base(context)
        {
        }

        public override  async Task<List<Cooler>> GetAllAsync(ProductFilter filter)
        {
            if (filter != null && filter.CpuId != Guid.Empty && filter.CaseId != Guid.Empty)
            {
                var computerCase = await _context.Cases.FirstOrDefaultAsync(cc => cc.Id == filter.CaseId);
                var cpu = await _context.Cpus.FirstOrDefaultAsync(c => c.Id == filter.CpuId);
                return await _entities.Where(cool => cool._compatibleSockets.Contains(cpu.Socket).Equals(true) && cool.Height < computerCase.CoolerHeight).ToListAsync();
            }
            return await _entities.ToListAsync();

        }
    }
}
