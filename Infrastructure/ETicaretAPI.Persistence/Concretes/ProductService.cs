using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new() 
        {
            new() { Id = 1 ,name = "Product1" ,price = 100 },
             new() { Id = 2 ,name = "Product2" ,price = 200 },
              new() { Id = 3 ,name = "Product3" ,price = 300 },
               new() { Id = 4 ,name = "Product4" ,price = 400 }
        };
    }
}
