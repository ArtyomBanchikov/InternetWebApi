using AutoMapper;
using Internet.BLL.Models;
using Internet.DAL.Entities;

namespace Internet.BLL.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AccountEntity, AccountModel>();
            CreateMap<AccountModel, AccountEntity>();

            CreateMap<AccountTariffEntity, AccountTariffModel>();
            CreateMap<AccountTariffModel, AccountTariffEntity>();

            CreateMap<AccountServiceEntity, AccountServiceModel>();
            CreateMap<AccountServiceModel, AccountServiceEntity>();

            CreateMap<ClientEntity, ClientModel>();
            CreateMap<ClientModel, ClientEntity>();

            CreateMap<TariffEntity, TariffModel>();
            CreateMap<TariffModel, TariffEntity>();

            CreateMap<ServiceEntity, ServiceModel>();
            CreateMap<ServiceModel, ServiceEntity>();

            CreateMap<PeriodicServiceEntity, PeriodicServiceModel>();
            CreateMap<PeriodicServiceModel, PeriodicServiceEntity>();
        }
    }
}
