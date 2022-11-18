using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using ECommereAPI.Persistence.Context;

namespace ECommereAPI.Persistence.Repositories;

public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
{
    public CustomerWriteRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}

