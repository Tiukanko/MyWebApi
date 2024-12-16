using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(new[] { "Order1", "Order2", "Order3" });
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            return Ok($"Order {id}");
        }
    }
}
