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
    public class VideoCardRepository: GenericRepository<VideoCard>, IVideoCardRepository
    {
        public VideoCardRepository(DatabaseContext context) : base(context)
        {
        }

        public override async Task<List<VideoCard>> GetAllAsync(ProductFilter filter)
        {
            if (filter != null && filter.MotherboardId != Guid.Empty && filter.CaseId != Guid.Empty)
            {
                var motherboard = await _context.Motherboards.FirstOrDefaultAsync(m => m.Id == filter.MotherboardId);
                var computerCase = await _context.Cases.FirstOrDefaultAsync(cc => cc.Id == filter.CaseId);

                return await _entities.Where(vc =>
                        vc.Interface.Equals(motherboard.GraphicInterface) && vc.Width <= computerCase.VideoCardWidth)
                    .ToListAsync();
            }
            return await _entities.ToListAsync();

        }
    }
}
