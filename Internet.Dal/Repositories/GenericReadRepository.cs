using Internet.Dal.EF;
using Internet.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Internet.Dal.Repositories
{
    public class GenericReadRepository<TEntity> : IGenericReadRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationContext _context;

        protected readonly DbSet<TEntity> dbSet;

        public GenericReadRepository(ApplicationContext context)
        {
            _context = context;
            dbSet = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken token)
        {
            return await dbSet.AsNoTracking().ToListAsync(token);
        }

        public virtual async Task<TEntity?> GetByIdAsync(int id, CancellationToken token)
        {
            return await dbSet.FindAsync(new object[] { id }, token);
        }
    }
}
