using AutoMapper;
using Internet.Bll.Models;
using Internet.Dal.Entities;
using Internet.Dal.Interfaces;

namespace Internet.Bll.Services
{
    public class ServiceService : GenericReadService<ServiceModel, ServiceEntity>
    {
        public ServiceService(IGenericReadRepository<ServiceEntity> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
