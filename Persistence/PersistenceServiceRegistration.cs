using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Application.Contracts.Persistence;
using ShoppingCart.Persistence.Repositories;

namespace ShoppingCart.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection ConfigurePersistenceService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShoppingCartDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("ShoppingCartConnectionString")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IProductInfoRepository, ProductInfoRepository>();

            return services;
        }
    }
}
