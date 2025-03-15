using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class CartDto
    {
        [Required(ErrorMessage = "UserId is required")]
        public int UserId { get; set; }

        //[Required(ErrorMessage = "ProductIds is required")]
        public string ProductId { get; set; } = "";  // Comma-separated Product IDs

        [Required(ErrorMessage = "Quantities is required")]
        public string Quantity { get; set; } = "";  // Comma-separated Quantities
    }
}
