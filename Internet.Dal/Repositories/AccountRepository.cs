using Internet.Dal.EF;
using Internet.Dal.Entities;

namespace Internet.Dal.Repositories
{
    public class AccountRepository : GenericReadRepository<AccountEntity>
    {
        public AccountRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
