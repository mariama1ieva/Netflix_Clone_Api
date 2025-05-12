using Microsoft.EntityFrameworkCore;
using Netflix.Domain.Models.Common;
using Netflix.Repository.DAL;
using Netflix.Repository.Repositories.Interface;


namespace Netflix.Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        protected readonly DbSet<T> _entities;


        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        async Task IBaseRepository<T>.CreateAsync(T entity)
        {
            _entities.Add(entity);
            await _context.SaveChangesAsync();
        }

        async Task IBaseRepository<T>.DeleteAsync(T entity)
        {

            _entities.Remove(entity);
            await _context.SaveChangesAsync();
        }

        async Task<IEnumerable<T>> IBaseRepository<T>.GetAllAsync()
        {

            return await _entities.ToListAsync();
        }

        async Task<T> IBaseRepository<T>.GetByIdAsync(int Id)
        {
            return await _entities.FirstAsync(x => x.Id == Id);
        }

        async Task IBaseRepository<T>.UpdateAsync(T entity)
        {
            _entities.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
