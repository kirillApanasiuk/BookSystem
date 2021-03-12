using Microsoft.Extensions.DependencyInjection;
using UseCases.Implementation.UnitOfWorks;
using UseCases.Interfaces;

namespace UseCases.Implementation
{
    public static class DependencyInjection
    {
        public static  IServiceCollection RegisterUseCases(this IServiceCollection services) {
            services.AddScoped<IUnitOfWork,UnitOfWork>();
            return services;
        }
    }
}
