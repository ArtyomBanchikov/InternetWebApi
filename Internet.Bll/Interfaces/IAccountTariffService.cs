using Internet.Bll.Models;

namespace Internet.Bll.Interfaces
{
    public interface IAccountTariffService
    {
        Task<IEnumerable<AccountTariffModel>> GetAllAsync(CancellationToken token);
        Task<IEnumerable<AccountTariffModel>> GetAllByAccountAsync(int id, CancellationToken token);
    }
}
