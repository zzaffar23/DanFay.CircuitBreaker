
using DanFay.ProductApi.Models;
using System.Collections.Generic;

namespace DanFay.ProductApi.Services
{
    public interface IProductService
    {
        public List<Product> GetProducts();
    }
}
