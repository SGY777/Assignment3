using Assignment3.Models;
using Assignment3.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //
        private readonly ApplicationDbContext _context;

        //
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all Product
        [HttpGet]
        public List<Product> GetProducts()
        {
            return _context.Products.OrderByDescending(p => p.ProductId).ToList();
        }

        // Create Product
        [HttpPost]
        public IActionResult CreateProduct(ProductDto productDto)
        {

            var product = new Product
            {
                ProductName = productDto.ProductName,
                Description = productDto.Description,
                ImageUrl = productDto.ImageUrl,
                Pricing = productDto.Pricing,
                ShippingCost = productDto.ShippingCost
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return Ok(product);
        }

        // update Product
        [HttpPut("{productId}")]
        public IActionResult EditProduct(int productId, ProductDto productDto)
        {
            var product = _context.Products.Find(productId);
            if (product == null)
            {
                return NotFound();
            }

            product.ProductName = productDto.ProductName;
            product.Description = productDto.Description;
            product.ImageUrl = productDto.ImageUrl;
            product.Pricing = productDto.Pricing;
            product.ShippingCost = productDto.ShippingCost;
            
            _context.SaveChanges();

            return Ok(product);
        }

        // Delete Product
        [HttpDelete("{productId}")]
        public IActionResult DeleteProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            _context.SaveChanges();

            return Ok();
        }

    }
}
