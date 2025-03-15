using Assignment3.Models;
using Assignment3.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Create Order (record a sale)
        [HttpPost]
        public IActionResult CreateOrder(OrderDto orderDto)
        {
            var order = new Order
            {
                UserId = orderDto.UserId,
                ProductId = orderDto.ProductId,
                Quantity = orderDto.Quantity,
                TotalPrice = orderDto.TotalPrice,
                OrderDate = DateTime.Now
            };

            _context.Orders.Add(order);
            _context.SaveChanges();

            return Ok(order);
        }

        // Get Orders for a specific User
        [HttpGet("{userId}")]
        public IActionResult GetOrders(int userId)
        {
            var orders = _context.Orders.Where(o => o.UserId == userId).ToList();
            if (!orders.Any())
            {
                return NotFound();
            }

            return Ok(orders);
        }

        // Get Order details
        [HttpGet("details/{orderId}")]
        public IActionResult GetOrderDetails(int orderId)
        {
            var order = _context.Orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        [HttpDelete("{orderId}")]
        public IActionResult RemoveFromCart(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            _context.SaveChanges();

            return Ok(new { message = "Order removed successfully." });
        }
    }
}
