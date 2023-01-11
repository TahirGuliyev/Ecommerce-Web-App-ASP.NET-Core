using Ecommerce.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async void Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "Product 1", Price = 100, Stock = 100, CreatedDate = DateTime.UtcNow },
                new() { Id = Guid.NewGuid(), Name = "Product 2", Price = 200, Stock = 200, CreatedDate = DateTime.UtcNow },
                new() { Id = Guid.NewGuid(), Name = "Product 3", Price = 300, Stock = 300, CreatedDate = DateTime.UtcNow },
                new() { Id = Guid.NewGuid(), Name = "Product 4", Price = 400, Stock = 400, CreatedDate = DateTime.UtcNow },
                new() { Id = Guid.NewGuid(), Name = "Product 5", Price = 500, Stock = 500, CreatedDate = DateTime.UtcNow },
                new() { Id = Guid.NewGuid(), Name = "Product 6", Price = 600, Stock = 600, CreatedDate = DateTime.UtcNow },
                new() { Id = Guid.NewGuid(), Name = "Product 7", Price = 700, Stock = 700, CreatedDate = DateTime.UtcNow },
                new() { Id = Guid.NewGuid(), Name = "Product 8", Price = 800, Stock = 800, CreatedDate = DateTime.UtcNow },
                new() { Id = Guid.NewGuid(), Name = "Product 9", Price = 900, Stock = 900, CreatedDate = DateTime.UtcNow },
                new() { Id = Guid.NewGuid(), Name = "Product 10", Price = 1000, Stock = 1000, CreatedDate = DateTime.UtcNow },
            });
            await _productWriteRepository.SaveAsync();
        }
    }
}
