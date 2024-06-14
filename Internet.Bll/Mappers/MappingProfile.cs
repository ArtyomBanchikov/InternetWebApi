﻿using AutoMapper;
using Internet.Bll.Models;
using Internet.Dal.Entities;

namespace Internet.Bll.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AccountEntity, AccountModel>();
            CreateMap<AccountModel, AccountEntity>();

            CreateMap<AccountTariffEntity, AccountTariffModel>();
            CreateMap<AccountTariffModel, AccountTariffEntity>();

            CreateMap<ClientEntity, ClientModel>();
            CreateMap<ClientModel, ClientEntity>();

            CreateMap<TariffEntity, TariffModel>();
            CreateMap<TariffModel, TariffEntity>();
        }
    }
}
