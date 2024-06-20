using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Internet.Dal.DI;
using Internet.Bll.Interfaces;
using Internet.Bll.Models;
using Internet.Bll.Services;
using Microsoft.AspNetCore.SignalR;

namespace Internet.Bll.DI
{
    public static class BllServiceCollection
    {
        public static void AddBllServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IUserIdProvider, CustomClientIdProvider>();

            services.AddScoped<IGenericReadService<AccountModel>, AccountService>();
            services.AddScoped<IGenericReadService<ClientModel>, ClientService>();
            services.AddScoped<IGenericReadService<TariffModel>, TariffService>();
            services.AddScoped<IAccountTariffService, AccountTariffService>();
            services.AddScoped<IGenericReadService<ServiceModel>, ServiceService>();

            services.AddScoped<ICacheService, CacheService>();

            services.AddDalServices(configuration);
        }
    }
}
