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
    public class RamRepository: GenericRepository<Ram>, IRamRepository
    {
        public RamRepository(DatabaseContext context) : base(context)
        {
        }

        public override async Task<List<Ram>> GetAllAsync(ProductFilter filter)
        {
            var motherboard = await _context.Motherboards.FirstOrDefaultAsync(m => m.Id == filter.MotherboardId);
            return await _entities.Where(r =>r.Type.Equals(motherboard.TypeOfRam) && r.Capacity <= motherboard.MaximumRamMemory &&
            r.Frequency <= motherboard.RamFrequency).ToListAsync();
        }
    }
}
