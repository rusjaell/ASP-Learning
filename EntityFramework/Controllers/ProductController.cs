using EntityFramework.Data;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ApplicationDBContext _context;

        public ProductController(ApplicationDBContext context, ILogger<ProductController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute]int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }
    }
}
