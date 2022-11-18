using ECommerceAPI.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async void Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() {Id=Guid.NewGuid(), Name="Product 1", Price=100, CreatedTime=DateTime.UtcNow, Stock=10,},
                new() {Id=Guid.NewGuid(), Name="Product 2", Price=200, CreatedTime=DateTime.UtcNow, Stock=40,},
                new() {Id=Guid.NewGuid(), Name="Product 3", Price=300, CreatedTime=DateTime.UtcNow, Stock=50,}
            });
            _productWriteRepository.SaveAsync();
        }
    }
}