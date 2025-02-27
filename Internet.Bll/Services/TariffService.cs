﻿using AutoMapper;
using Internet.BLL.Models;
using Internet.DAL.Entities;
using Internet.DAL.Interfaces;

namespace Internet.BLL.Services
{
    public class TariffService : GenericReadService<TariffModel, TariffEntity>
    {
        public TariffService(IGenericReadRepository<TariffEntity> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
