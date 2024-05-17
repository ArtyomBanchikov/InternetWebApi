using Internet.DAL.EF;
using Internet.DAL.Entities;
using Internet.DAL.Interfaces;
using Internet.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Internet.DAL.DI
{
    public static class DalServiceCollection
    {
        public static void AddDalServices(this IServiceCollection services, IConfiguration configuration)
        {
            var internetConnection = configuration.GetConnectionString("InternetConnection");
            services.AddDbContext<ApplicationContext>(c => c.UseMySql(internetConnection, new MySqlServerVersion(new Version(8, 0, 34))));

            services.AddScoped<IGenericReadRepository<AccountEntity>, AccountRepository>();
            services.AddScoped<IGenericReadRepository<ClientEntity>, ClientRepository>();
            services.AddScoped<IGenericReadRepository<TariffEntity>, TariffRepository>();
            services.AddScoped<IAccountTariffRepository, AccountTariffRepository>();
        }
    }
}
