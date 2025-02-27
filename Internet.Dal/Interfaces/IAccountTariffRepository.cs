﻿using Internet.DAL.Entities;

namespace Internet.DAL.Interfaces
{
    public interface IAccountTariffRepository
    {
        Task<IEnumerable<AccountTariffEntity>> GetAllAsync(CancellationToken token);
        Task<IEnumerable<AccountTariffEntity>> GetAllByAccountAsync(int id, CancellationToken token);
    }
}
