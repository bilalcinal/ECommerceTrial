using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using ECommereAPI.Persistence.Context;

namespace ECommereAPI.Persistence.Repositories;

public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
{
    public OrderReadRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
    
