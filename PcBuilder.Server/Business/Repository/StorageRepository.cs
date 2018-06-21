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
    public class StorageRepository: GenericRepository<Storage>, IStorageRepository
    {
        public StorageRepository(DatabaseContext context) : base(context)
        {
        }

        public override async Task<List<Storage>> GetAllAsync(ProductFilter filter)
        {
            if (filter != null && filter.MotherboardId != Guid.Empty)
            {
                var storages = new List<Storage>();
                var motherboard = await _context.Motherboards.FirstOrDefaultAsync(m => m.Id == filter.MotherboardId);
                if (motherboard.M2 != 0)
                    storages.AddRange(_entities.Where(s => s.FormFactor.Equals("M.2")));

                storages.AddRange(_entities.Where(s => s.Interface.Equals("SATA-III") && !s.FormFactor.Equals("M.2")));
                return storages.ToList();
            }
            return await _entities.ToListAsync();

        }
    }

}
