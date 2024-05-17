using Internet.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Internet.DAL.EF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<TariffEntity> Tariffs { get; set; } = null!;

        public DbSet<AccountEntity> Accounts { get; set; } = null!;

        public DbSet<ClientEntity> Clients { get; set; } = null!;

        public DbSet<AccountTariffEntity> AccountTariffs { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
