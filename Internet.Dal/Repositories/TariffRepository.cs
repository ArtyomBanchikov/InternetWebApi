using Internet.Dal.EF;
using Internet.Dal.Entities;

namespace Internet.Dal.Repositories
{
    public class TariffRepository : GenericReadRepository<TariffEntity>
    {
        public TariffRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
