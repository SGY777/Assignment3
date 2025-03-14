using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; } = "";
        public string Description { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        [Column(TypeName = "decimal(10,2)")]
        public Decimal Pricing { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public Decimal ShippingCost { get; set; }
    }
}
