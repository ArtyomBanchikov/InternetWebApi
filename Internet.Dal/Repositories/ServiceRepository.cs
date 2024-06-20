using Internet.Dal.Entities;
using Internet.Dal.EF;
using Microsoft.EntityFrameworkCore;

namespace Internet.Dal.Repositories
{
    public class ServiceRepository : GenericReadRepository<ServiceEntity>
    {
        public ServiceRepository(ApplicationContext context) : base(context)
        {
        }

        public override async Task<ServiceEntity?> GetByIdAsync(int id, CancellationToken token)
        {
            return await dbSet
                .Include(s => s.PeriodicService)
                .FirstAsync(s => s.Id == id);
        }
    }
}
