using ecommerce_app.Interfaces;
using ecommerce_app.Repositories;

namespace ecommerce_app.ServiceExtensions
{
    public static class RepositoryRegistrationExtension
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IStoreRepository, StoreRepository>();

            return services;
        }
    }
}
