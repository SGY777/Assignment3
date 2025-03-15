using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }  // Foreign Key to User
        public string ProductId { get; set; } = ""; // Comma-separated Product IDs
        public string Quantity { get; set; } = ""; // Comma-separated Quantities
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
