using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using ECommereAPI.Persistence.Context;

namespace ECommereAPI.Persistence.Repositories;

public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
