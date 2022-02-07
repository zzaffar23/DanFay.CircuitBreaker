
using ProductApi.Models;
using System.Collections.Generic;

namespace ProductApi.Services
{
    public interface IProductService
    {
        public List<Product> GetProducts();
    }
}
