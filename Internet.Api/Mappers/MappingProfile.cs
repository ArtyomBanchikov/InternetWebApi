using AutoMapper;
using Internet.Api.ViewModels;
using Internet.Api.ViewModels.Client;
using Internet.Bll.Models;

namespace Internet.Api.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AccountViewModel, AccountModel>();
            CreateMap<AccountModel, AccountViewModel>();

            CreateMap<AccountTariffViewModel, AccountTariffModel>();
            CreateMap<AccountTariffModel, AccountTariffViewModel>();

            CreateMap<AccountServiceViewModel, AccountServiceModel>();
            CreateMap<AccountServiceModel, AccountServiceViewModel>();

            CreateMap<ClientViewModel, ClientModel>();
            CreateMap<ClientModel, ClientViewModel>();

            CreateMap<ShortClientViewModel, LoginClientViewModel>();
            CreateMap<LoginClientViewModel, ShortClientViewModel>();

            CreateMap<ShortClientViewModel, ClientViewModel>();
            CreateMap<ClientViewModel, ShortClientViewModel>();

            CreateMap<LoginClientViewModel, ClientViewModel>();
            CreateMap<ClientViewModel, LoginClientViewModel>();

            CreateMap<TariffViewModel, TariffModel>();
            CreateMap<TariffModel, TariffViewModel>();

            CreateMap<ServiceViewModel, ServiceModel>();
            CreateMap<ServiceModel, ServiceViewModel>();

            CreateMap<PeriodicServiceViewModel, PeriodicServiceModel>();
            CreateMap<PeriodicServiceModel, PeriodicServiceViewModel>();
        }
    }
}
