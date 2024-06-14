using AutoMapper;
using Internet.Bll.Interfaces;
using Internet.Bll.Models;
using Internet.Dal.Entities;
using Internet.Dal.Interfaces;

namespace Internet.Bll.Services
{
    public class AccountService : GenericReadService<AccountModel, AccountEntity>
    {
        private readonly ICacheService _cacheService;
        public AccountService(IGenericReadRepository<AccountEntity> repository, IMapper mapper, ICacheService cacheService) : base(repository, mapper)
        {
            _cacheService = cacheService;
        }

        public override async Task<AccountModel> GetByIdAsync(int id, CancellationToken token)
        {
            var cacheData = _cacheService.GetData<AccountModel>($"account{id}");
            if (cacheData == null)
            {
                cacheData = await base.GetByIdAsync(id, token);

                var expirityTime = DateTimeOffset.Now.AddSeconds(5);

                _cacheService.SetData($"account{id}", cacheData, expirityTime);
            }
            return cacheData;
        }

        public override async Task<IEnumerable<AccountModel>> GetAllAsync(CancellationToken token)
        {
            var cacheData = _cacheService.GetData<IEnumerable<AccountModel>>("accounts");
            if (cacheData == null)
            {
                cacheData = await base.GetAllAsync(token);

                var expirityTime = DateTimeOffset.Now.AddSeconds(5);

                _cacheService.SetData("accounts", cacheData, expirityTime);
            }
            return cacheData;
        }
    }
}
