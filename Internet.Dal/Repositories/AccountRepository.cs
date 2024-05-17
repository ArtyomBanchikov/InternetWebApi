using Internet.DAL.EF;
using Internet.DAL.Entities;
using Internet.DAL.Interfaces;

namespace Internet.DAL.Repositories
{
    public class AccountRepository : GenericReadRepository<AccountEntity>
    {
        public AccountRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
