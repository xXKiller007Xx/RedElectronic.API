namespace RedElectronic.Infrastructure.Base
{
    /// <summary>
    /// Base repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseRepository<T> where T : class
    {
        /// <summary>
        /// Get all
        /// </summary>
        /// <returns>IEnumerable of T</returns>
        public Task<IEnumerable<T>> GetAllAsync();
        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>T value</returns>
        public Task<T> GetByIdAsync(Guid id);
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>TEntity</returns>
        public Task AddAsync(T entity);
        /// <summary>
        /// Add range
        /// </summary>
        /// <param name="entities">IEnumerable of T</param>
        /// <returns>TEntity</returns>
        public Task AddRangeAsync(IEnumerable<T> entities);
        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>TEntity</returns>
        public void Remove(T entity);
        /// <summary>
        /// Remove range
        /// </summary>
        /// <param name="entities"></param>
        /// <returns>IEnumberable of T</returns>
        public void RemoveRangeAsync(IEnumerable<T> entities);
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity">T entity</param>
        /// <returns>T</returns>
        public void UpdateAsync(T entity);
    }
}
