using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Application.ViewModels.Products;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductWriteRepository productWriteRepository;
        private readonly IProductReadRepository productReadRepository;

        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            this.productWriteRepository = productWriteRepository;
            this.productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task Get ()
        {
            await productWriteRepository.AddRangeAsync(new()
            {
             new() { Id = 1 ,name = "Product1" ,price = 100 },
             new() { Id = 2 ,name = "Product2" ,price = 200 },
             new() { Id = 3 ,name = "Product3" ,price = 300 },
             new() { Id = 4 ,name = "Product4" ,price = 400 }
            });
         
            await productWriteRepository.SaveAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Product model)
        {
            if (ModelState.IsValid)
            {

            }
            await productWriteRepository.AddAsync(new()
            {
                name = model.name,
                price = model.price,
                stock = model.stock
            });
            await productWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
            
        {
            Product product = await productReadRepository.GetByIdAsync(id);
            Console.WriteLine(product);
            await productWriteRepository.SaveAsync();
            return Ok(product);
           
        }

    }
}
