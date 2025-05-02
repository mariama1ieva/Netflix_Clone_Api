using Netflix.Domain.Models.Common;

namespace Netflix.Repository.Repositories.Interface
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task CreateAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task<T> GetByIdAsync(int Id);
        Task<IEnumerable<T>> GetAllAsync();



    }
}
