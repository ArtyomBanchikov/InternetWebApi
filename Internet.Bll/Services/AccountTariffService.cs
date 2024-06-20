using AutoMapper;
using Internet.Bll.Interfaces;
using Internet.Bll.Models;
using Internet.Dal.Interfaces;

namespace Internet.Bll.Services
{
    public class AccountTariffService : IAccountTariffService
    {
        protected readonly IAccountTariffRepository _repository;

        protected readonly IMapper _mapper;
        public AccountTariffService(IAccountTariffRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AccountTariffModel>> GetAllAsync(CancellationToken token)
        {
            var result = _mapper.Map<IEnumerable<AccountTariffModel>>(await _repository.GetAllAsync(token));

            return result;
        }

        public async Task<IEnumerable<AccountTariffModel>> GetAllByAccountAsync(int id, CancellationToken token)
        {
            var result = _mapper.Map<IEnumerable<AccountTariffModel>>(await _repository.GetAllByAccountAsync(id, token));

            return result;
        }
    }
}
