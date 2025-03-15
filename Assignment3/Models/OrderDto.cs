using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class OrderDto
    {
        [Required(ErrorMessage = "UserId is required")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "ProductIds is required")]
        public string ProductId { get; set; } = "";  // Comma-separated Product IDs

        [Required(ErrorMessage = "Quantities is required")]
        public string Quantity { get; set; } = "";  // Comma-separated Quantities

        [Required(ErrorMessage = "TotalPrice is required")]
        public decimal TotalPrice { get; set; }
    }
}
