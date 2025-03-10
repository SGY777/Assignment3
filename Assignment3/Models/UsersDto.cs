using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class UsersDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; } = "";

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = "";

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } = "";
        public string PurchaseHistory { get; set; } = "";

        [Required(ErrorMessage = "ShippingAddress is required")]
        public String ShippingAddress { get; set; } = "";
    }
}
