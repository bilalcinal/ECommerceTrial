using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;
        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;

        public ProductController(
        IProductWriteRepository productWriteRepository, 
        IProductReadRepository productReadRepository, 
        IOrderWriteRepository orderWriteRepository, 
        ICustomerWriteRepository customerWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            var customerId = Guid.NewGuid();
            await _customerWriteRepository.AddAsync(new(){Id = customerId, Name="Bilal"});
           await _orderWriteRepository.AddAsync(new(){Description ="bla bla bla", Address="düzce", CustomerId = customerId });
           await _orderWriteRepository.SaveAsync();
        }
    
    }
}