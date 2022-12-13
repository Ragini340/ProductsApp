using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
       Product[] products = new Product[]
       {
            new Product { Id = 1, Name = "Maggi", Category = "Groceries", Price = 94 },
            new Product { Id = 2, Name = "C in Depth", Category = "Technical Books", Price =700  },
            new Product { Id = 3, Name = "Engineering Mathematics", Category = "Mathematics", Price = 900 },
            new Product { Id = 4, Name = "DC Machine and Synchronous Machine", Category = "Electrical Book", Price = 1000 }
       };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
