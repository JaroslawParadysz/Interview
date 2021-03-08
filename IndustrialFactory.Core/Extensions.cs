using Factory.Core.Repositories;
using IndustrialFactory.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace IndustrialFactory.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddIndustrialFactoryCore(this IServiceCollection services)
        {
            services.AddScoped<IIndustrialFactoryService, IndustrialFactoryService>();

            return services;
        }
    }
}
