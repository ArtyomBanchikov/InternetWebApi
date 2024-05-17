using AutoMapper;
using Internet.API.ViewModels;
using Internet.API.ViewModels.Client;
using Internet.BLL.Models;

namespace Internet.API.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AccountViewModel, AccountModel>();
            CreateMap<AccountModel, AccountViewModel>();

            CreateMap<AccountTariffViewModel, AccountTariffModel>();
            CreateMap<AccountTariffModel, AccountTariffViewModel>();

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
        }
    }
}
