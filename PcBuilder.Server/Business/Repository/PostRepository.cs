using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Core.Domain;
using Data.Core.Interfaces;
using Data.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Business.Repository
{
    public class PostRepository: IPostRepository
    {
        protected readonly DatabaseContext _context;
        protected readonly DbSet<Post> _entities;

        public PostRepository(DatabaseContext context)
        {
            _context = context;
            _entities = context.Set<Post>();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = _entities.FirstOrDefault(p => p.Id == id);
            if (entity == null)
                return await _context.SaveChangesAsync() > 0;
            _entities.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<Post>> GetAllAsync() => await _entities.OrderByDescending(p => p.CreationDate).ToListAsync();

        public async Task<Post> GetByIdAsync(Guid id) => await _entities.FirstOrDefaultAsync(p => p.Id == id);

        public async Task<Post> InsertAsync(Post entity)
        {
            _entities.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> UpdateAsync(Post entity)
        {
            _entities.Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
