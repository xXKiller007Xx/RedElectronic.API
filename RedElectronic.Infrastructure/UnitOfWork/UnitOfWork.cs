using RedElectronic.Core.Data;

namespace RedElectronic.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Private field
        private readonly AppDbContext _context;
        #endregion
        #region Constructor

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        #endregion
        #region Task
        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
        #endregion
    }
}
