using Assignment3.Models;
using Assignment3.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CommentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Add a new comment
        [HttpPost]
        public IActionResult AddComment(CommentDto commentDto)
        {
            var comment = new Comment
            {
                ProductId = commentDto.ProductId,
                UserId = commentDto.UserId,
                Text = commentDto.Text,
                Rating = commentDto.Rating,
                ImageUrl = commentDto.ImageUrl
            };

            _context.Comments.Add(comment);
            _context.SaveChanges();

            return Ok(comment);
        }

        // Get all comments for a specific product
        [HttpGet("{productId}")]
        public IActionResult GetComments(int productId)
        {
            var comments = _context.Comments.Where(c => c.ProductId == productId).ToList();
            if (!comments.Any())
            {
                return NotFound("No comments found for this product.");
            }

            return Ok(comments);
        }

        // Edit a comment
        [HttpPut("{commentId}")]
        public IActionResult EditComment(int commentId, CommentDto commentDto)
        {
            var comment = _context.Comments.Find(commentId);
            if (comment == null)
            {
                return NotFound("Comment not found.");
            }

            // Update fields
            comment.Text = commentDto.Text;
            comment.Rating = commentDto.Rating;
            comment.ImageUrl = commentDto.ImageUrl;

            _context.Comments.Update(comment);
            _context.SaveChanges();

            return Ok(new { message = "Comment updated successfully.", comment });
        }

        // Delete a comment
        [HttpDelete("{commentId}")]
        public IActionResult DeleteComment(int commentId)
        {
            var comment = _context.Comments.Find(commentId);
            if (comment == null)
            {
                return NotFound("Comment not found.");
            }

            _context.Comments.Remove(comment);
            _context.SaveChanges();

            return Ok(new { message = "Comment deleted successfully." });
        }
    }
}
