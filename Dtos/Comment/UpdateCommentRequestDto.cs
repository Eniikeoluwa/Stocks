using System.ComponentModel.DataAnnotations;

namespace myWebApi.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be more than 5 characters")]
        [MaxLength(280, ErrorMessage = "Title cannot be above 280 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Content must be more than 5 characters")]
        [MaxLength(280, ErrorMessage = "Content cannot be above 280 characters")]
        public string Content { get; set; } = string.Empty;
    }
}