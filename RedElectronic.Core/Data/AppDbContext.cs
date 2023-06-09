using Microsoft.EntityFrameworkCore;

namespace RedElectronic.Core.Data
{
    public class AppDbContext : DbContext
    {
        #region Constructor
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        #endregion
    }
}
