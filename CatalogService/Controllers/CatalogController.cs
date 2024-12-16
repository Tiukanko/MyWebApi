using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCatalog()
        {
            return Ok(new[] { "Product1", "Product2", "Product3" });
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            return Ok($"Product {id}");
        }
    }
}
