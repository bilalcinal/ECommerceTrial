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
            
            services.AddDbContext<ECommerceAPIDbContext>(options =>options.UseNpgsql(Configuration.ConnectionString)); 
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();  
            services.AddScoped<IOrderReadRepository, OrderReadRepository>(); 
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>(); 
            services.AddScoped<IProductReadRepository, ProductReadRepository>(); 
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>(); 
        }
        
    }
}