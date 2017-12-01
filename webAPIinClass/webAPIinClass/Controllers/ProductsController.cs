﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webAPIinClass.Models;

namespace webAPIinClass.Controllers
{
    public class ProductsController : ApiController
    {

        Products[] products = new Products[]
        {
            new Products { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Products { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Products { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        // GET: api/Products
        public IEnumerable<Products> Get()
        {
            return products;
        }
        // GET: api/Products/5
        public Products Get(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }
        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }
        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }       
    }
}
