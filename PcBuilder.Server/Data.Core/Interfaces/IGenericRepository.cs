using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data.Core.Domain;

namespace Data.Core.Interfaces
{
    public interface IGenericRepository<T> where T: IProduct
    {
        Task<bool> DeleteAsync(Guid id);
        Task<List<T>> GetAllAsync(ProductFilter filter);
        Task<T> GetByIdAsync(Guid id);
        Task<T> InsertAsync(T entity);
        Task<bool> UpdateAsync(T entity);
    }
}
