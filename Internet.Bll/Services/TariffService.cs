using AutoMapper;
using Internet.Bll.Models;
using Internet.Dal.Entities;
using Internet.Dal.Interfaces;

namespace Internet.Bll.Services
{
    public class TariffService : GenericReadService<TariffModel, TariffEntity>
    {
        public TariffService(IGenericReadRepository<TariffEntity> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
