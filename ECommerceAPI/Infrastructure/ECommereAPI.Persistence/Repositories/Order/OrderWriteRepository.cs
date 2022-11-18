using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using ECommereAPI.Persistence.Context;

namespace ECommereAPI.Persistence.Repositories;

public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
{
    public OrderWriteRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
