using Internet.DAL.EF;
using Internet.DAL.Entities;
using Internet.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Internet.DAL.Repositories
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
