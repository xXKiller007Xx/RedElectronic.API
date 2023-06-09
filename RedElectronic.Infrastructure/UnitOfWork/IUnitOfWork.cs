namespace RedElectronic.Infrastructure.UnitOfWork
{
    /// <summary>
    /// IUnitOfWork
    /// </summary>
    public interface IUnitOfWork : IAsyncDisposable
    {
        public Task<int> SaveChangeAsync();
        //TODO: Add Transaction
    }
}
