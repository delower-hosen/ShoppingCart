using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Application.Contracts.Logging;
using ShoppingCart.Infrastructure.Logging;

namespace ShoppingCart.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            return services;
        }
    }
}
