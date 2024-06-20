using Internet.Dal.Entities;

namespace Internet.Dal.Interfaces
{
    public interface IAccountTariffRepository
    {
        Task<IEnumerable<AccountTariffEntity>> GetAllAsync(CancellationToken token);
        Task<IEnumerable<AccountTariffEntity>> GetAllByAccountAsync(int id, CancellationToken token);
    }
}
