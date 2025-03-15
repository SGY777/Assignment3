using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class CommentDto
    {
        [Required(ErrorMessage = "ProductId is required")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "UserId is required")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Text is required")]
        public string Text { get; set; } = "";

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

        public string ImageUrl { get; set; } = "";
    }
}
