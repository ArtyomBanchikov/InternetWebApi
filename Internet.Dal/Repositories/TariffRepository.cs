using Internet.DAL.EF;
using Internet.DAL.Entities;

namespace Internet.DAL.Repositories
{
    public class TariffRepository : GenericReadRepository<TariffEntity>
    {
        public TariffRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
