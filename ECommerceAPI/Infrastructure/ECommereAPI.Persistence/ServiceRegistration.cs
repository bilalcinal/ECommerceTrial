using ECommerceAPI.Application.Abstractions;
using ECommereAPI.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace ECommereAPI.Persistence;

    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
              services.AddSingleton<IProductService, ProductService>();
        }
        
    }
