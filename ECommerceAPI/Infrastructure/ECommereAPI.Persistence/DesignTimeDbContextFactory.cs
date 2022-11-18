using ECommereAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ECommereAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceAPIDbContext>
    {
        public ECommerceAPIDbContext CreateDbContext(string[] args)
        {
            

           DbContextOptionsBuilder<ECommerceAPIDbContext> dbContextOptionsBuilder = new();
           dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
           return new ECommerceAPIDbContext(dbContextOptionsBuilder.Options);
        }
    }
}