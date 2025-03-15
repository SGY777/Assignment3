using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public int UserId { get; set; }  // Foreign Key to User
        public string ProductId { get; set; } = ""; // Comma-separated Product IDs for simplicity
        public string Quantity { get; set; } = ""; // Comma-separated Quantities for each product
    }
}
