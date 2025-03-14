using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
        public string Email { get; set; } = "";
        public string PurchaseHistory { get; set; } = "";
        public String ShippingAddress { get; set; } = "";

    }
}
