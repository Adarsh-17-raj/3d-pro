using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThreeDShopping.API.Data;

namespace ThreeDShopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/products?categoryId=1&minPrice=10&maxPrice=500
        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] int? categoryId, [FromQuery] decimal? minPrice, [FromQuery] decimal? maxPrice)
        {
            var query = _context.Products.AsQueryable();

            if (categoryId.HasValue)
                query = query.Where(p => p.CategoryId == categoryId.Value);

            if (minPrice.HasValue)
                query = query.Where(p => p.Price >= minPrice.Value);

            if (maxPrice.HasValue)
                query = query.Where(p => p.Price <= maxPrice.Value);

            var products = await query.ToListAsync();
            return Ok(products);
        }

        // GET: api/products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return NotFound();

            return Ok(product);
        }
    }
}