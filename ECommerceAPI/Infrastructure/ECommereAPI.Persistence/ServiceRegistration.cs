using Microsoft.EntityFrameworkCore;
using ECommereAPI.Persistence.Context;
using Microsoft.Extensions.DependencyInjection;
using ECommerceAPI.Application.Repositories;
using ECommereAPI.Persistence.Repositories;

namespace ECommereAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            
            services.AddDbContext<ECommerceAPIDbContext>(options =>options.UseNpgsql(Configuration.ConnectionString),
            ServiceLifetime.Singleton); 
            services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
            services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();  
            services.AddSingleton<IOrderReadRepository, OrderReadRepository>(); 
            services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>(); 
            services.AddSingleton<IProductReadRepository, ProductReadRepository>(); 
            services.AddSingleton<IProductWriteRepository, ProductWriteRepository>(); 
        }
        
    }
}