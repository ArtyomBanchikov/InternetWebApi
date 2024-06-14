using Internet.Dal.EF;
using Internet.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace Internet.Dal.Repositories
{
    public class ClientRepository : GenericReadRepository<ClientEntity>
    {
        public ClientRepository(ApplicationContext context) : base(context)
        {
        }
        public override async Task<ClientEntity?> GetByIdAsync(int account, CancellationToken token)
        {
            return await _context.Clients.SingleOrDefaultAsync(client => client.AccountId == account);
        }
    }
}
