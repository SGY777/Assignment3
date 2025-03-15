using Assignment3.Models;
using Assignment3.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get Cart for a specific User
        [HttpGet("{userId}")]
        public IActionResult GetCart(int userId)
        {
            var cart = _context.Carts.FirstOrDefault(c => c.UserId == userId);
            if (cart == null)
            {
                return NotFound();
            }
            return Ok(cart);
        }

        // Add Product to Cart
        [HttpPost]
        public IActionResult AddToCart(CartDto cartDto)
        {
            var cart = new Cart
            {
                UserId = cartDto.UserId,
                ProductId = cartDto.ProductId,
                Quantity = cartDto.Quantity
            };

            _context.Carts.Add(cart);
            _context.SaveChanges();

            return Ok(cart);
        }

        // Update Cart (Change quantity)
        [HttpPut("{cartId}")]
        public IActionResult UpdateCart(int cartId, CartDto cartDto)
        {
            var cart = _context.Carts.Find(cartId);
            if (cart == null)
            {
                return NotFound();
            }

            cart.Quantity = cartDto.Quantity;
            _context.SaveChanges();

            return Ok(cart);
        }

        // Remove Product from Cart
        [HttpDelete("{cartId}")]
        public IActionResult RemoveFromCart(int cartId)
        {
            var cart = _context.Carts.Find(cartId);
            if (cart == null)
            {
                return NotFound();
            }

            _context.Carts.Remove(cart);
            _context.SaveChanges();

            return Ok(new { message = "Product removed from cart successfully." });
        }
    }
}
