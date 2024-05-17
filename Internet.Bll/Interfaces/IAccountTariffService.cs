using Internet.BLL.Models;

namespace Internet.BLL.Interfaces
{
    public interface IAccountTariffService
    {
        Task<IEnumerable<AccountTariffModel>> GetAllAsync(CancellationToken token);
        Task<IEnumerable<AccountTariffModel>> GetAllByAccountAsync(int id, CancellationToken token);
    }
}
