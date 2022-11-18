using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using ECommereAPI.Persistence.Context;

namespace ECommereAPI.Persistence.Repositories;

public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
{
    public ProductReadRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
    
