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
    public class MotherboardRepository: GenericRepository<Motherboard>, IMotherboardRepository
    {
        public MotherboardRepository(DatabaseContext context) : base(context)
        {
        }

        public override async Task<List<Motherboard>> GetAllAsync(ProductFilter filter)
        {
            var computerCase = await _context.Cases.FirstOrDefaultAsync(cc => cc.Id == filter.CaseId);
            var cpu = await _context.Cpus.FirstOrDefaultAsync(c => c.Id == filter.CpuId);
            return await _entities.Where(m => computerCase._motherboardFormFactor.Contains(m.FormFactor) && m.Socket.Equals(cpu.Socket) &&
            m.MaximumRamMemory <= cpu.MaximumRamMemory && m.RamFrequency <= cpu.RamFrequency && m.TypeOfRam.Equals(cpu.TypeOfRam)).ToListAsync();
        }
    }
}
