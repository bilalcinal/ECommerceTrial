using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ECommereAPI.Persistence.Context
{
    public class ECommerceAPIDbContext : DbContext
    {
        public ECommerceAPIDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
               var datas = ChangeTracker.Entries<BaseEntity>();
               foreach(var data in datas)
               {
                  _ = data.State switch
                {
                    
                    EntityState.Added => data.Entity.CreatedTime = DateTime.UtcNow, 
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow

                };
               }

            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}