using Internet.Dal.EF;
using Internet.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace Internet.DAL.Repositories
{
    public class AccountRepository : GenericReadRepository<AccountEntity>
    {
        public AccountRepository(ApplicationContext context) : base(context)
        {
        }

        public override async Task<AccountEntity?> GetByIdAsync(int id, CancellationToken token)
        {
            return await dbSet
                .Include(account => account.AccountServices.Where(accountService => accountService.IsDeleted == false))
                .ThenInclude(accountService => accountService.Service)
                .ThenInclude(service => service.PeriodicService)
                .FirstAsync(s => s.Id == id);
        }
    }
}
