using AutoMapper;
using Internet.Bll.Models;
using Internet.Dal.Entities;
using Internet.Dal.Interfaces;

namespace Internet.Bll.Services
{
    public class ClientService : GenericReadService<ClientModel, ClientEntity>
    {
        public ClientService(IGenericReadRepository<ClientEntity> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
