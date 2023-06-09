using Microsoft.EntityFrameworkCore;
using RedElectronic.Core.Data;

namespace RedElectronic.Infrastructure.Base
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        #region Private field
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        #endregion
        #region Constructor
        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        #endregion
        #region Task

        public virtual async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public virtual async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual void Remove(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public virtual void RemoveRangeAsync(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                if (_context.Entry(entity).State == EntityState.Detached)
                {
                    _dbSet.Attach(entity);
                }
            }
            _dbSet.RemoveRange(entities);
        }

        public virtual void UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        #endregion
    }
}
