using ECommerceAPI.Domain.Entities.Common;

namespace ECommerceAPI.Application.Abstractions
{
    public interface IProductService
    {
         List<Product> GetProducts();
    }
}