using Internet.Dal.EF;
using Internet.Dal.Entities;
using Internet.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Internet.Dal.Repositories
{
    public class AccountTariffRepository : IAccountTariffRepository
    {
        protected readonly ApplicationContext _context;

        protected readonly DbSet<AccountTariffEntity> dbSet;

        public AccountTariffRepository(ApplicationContext context)
        {
            _context = context;
            dbSet = context.Set<AccountTariffEntity>();
        }

        public async Task<IEnumerable<AccountTariffEntity>> GetAllAsync(CancellationToken token)
        {
            return await dbSet.AsNoTracking().ToListAsync(token);
        }

        public async Task<IEnumerable<AccountTariffEntity>> GetAllByAccountAsync(int id, CancellationToken token)
        {
            return await dbSet.AsNoTracking().Where(x => x.AccountId == id).ToListAsync(token);
        }
    }
}
