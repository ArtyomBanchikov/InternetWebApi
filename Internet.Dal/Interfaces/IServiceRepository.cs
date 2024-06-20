using Internet.Dal.Entities;

namespace Internet.Dal.Interfaces
{
    public interface IServiceRepository : IGenericReadRepository<ServiceEntity>
    {
        Task<IEnumerable<ServiceEntity>> GetAllByAccount(int account, CancellationToken cancellationToken);
    }
}
