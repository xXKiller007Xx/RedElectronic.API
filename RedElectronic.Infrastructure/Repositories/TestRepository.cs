using RedElectronic.Core.Data;
using RedElectronic.Core.Entities;
using RedElectronic.Infrastructure.Base;
using RedElectronic.Infrastructure.Contracts;

namespace RedElectronic.Infrastructure.Repositories
{
    public class TestRepository : BaseRepository<Test>, ITestRepository
    {
        public TestRepository(AppDbContext context) : base(context)
        {

        }
    }
}
