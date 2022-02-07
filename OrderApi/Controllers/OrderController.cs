using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using OrderApi.Models;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public OrderController(ILogger<OrderController> logger,
                               IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        [HttpGet("GetOrderDetails/{orderId}")]
        public async Task<ActionResult<Order>> GetOrderDetails(int orderId)
        {
            var client = _httpClientFactory.CreateClient("ProductApi");
            var response = await client.GetAsync("api/product/getproducts");
            var products = await response.Content.ReadAsStringAsync();
            return new Order() { Id = orderId, Products = products };
        }
    }
}
