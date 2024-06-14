using AutoMapper;
using Internet.BLL.Models;
using Internet.Dal.Entities;
using Internet.Dal.Interfaces;

namespace Internet.BLL.Services
{
    public class ClientService : GenericReadService<ClientModel, ClientEntity>
    {
        public ClientService(IGenericReadRepository<ClientEntity> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
