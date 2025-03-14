using Assignment3.Models;
using Assignment3.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        //
        private readonly ApplicationDbContext _context;

        //
        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all Users
        [HttpGet]
        public List<Users> GetUsers()
        {
            return _context.Users.OrderByDescending(p => p.UserId).ToList();
        }

        // Add User
        [HttpPost]
        public IActionResult CreateUser(UsersDto usersDto)
        {
            var user = new Users 
            {
                UserName = usersDto.UserName,
                Password = usersDto.Password,
                Email = usersDto.Email,
                PurchaseHistory = usersDto.PurchaseHistory,
                ShippingAddress = usersDto.ShippingAddress
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok(user);
        }

        // Edit User
        [HttpPut("{userId}")]
        public IActionResult EditUser(int userId, UsersDto usersDto)
        {
            var user = _context.Users.Find(userId);
            if (user == null)
            {
                return NotFound();
            }

            user.UserName = usersDto.UserName;
            user.Password = usersDto.Password;
            user.Email = usersDto.Email;
            user.PurchaseHistory = usersDto.PurchaseHistory;
            user.ShippingAddress = usersDto.ShippingAddress;

            _context.SaveChanges();

            return Ok(user);
        }

        // Delete User
        [HttpDelete("{userId}")]
        public IActionResult DeleteUser(int userId)
        {
            var user = _context.Users.Find(userId);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            _context.SaveChanges();

            return Ok(user);
        }

    }
}
