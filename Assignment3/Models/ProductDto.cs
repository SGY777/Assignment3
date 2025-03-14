using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class ProductDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "ProductName is required")]
        public string ProductName { get; set; } = "";

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = "";

        [Required(ErrorMessage = "ImageUrl is required")]
        public string ImageUrl { get; set; } = "";

        [Required(ErrorMessage = "Pricing is required")]
        [Column(TypeName = "decimal(10,2)")]
        public Decimal Pricing { get; set; }

        [Required(ErrorMessage = "ShippingCost is required")]
        [Column(TypeName = "decimal(10,2)")]
        public Decimal ShippingCost { get; set; }
    }
}
