using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data.Core.Domain;

namespace Data.Core.Interfaces
{
   public interface IPostRepository
    {
        Task<bool> DeleteAsync(Guid id);
        Task<List<Post>> GetAllAsync();
        Task<Post> GetByIdAsync(Guid id);
        Task<Post> InsertAsync(Post entity);
        Task<bool> UpdateAsync(Post entity);
    }
}
