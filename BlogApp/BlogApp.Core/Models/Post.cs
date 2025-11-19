using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Core.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title Required")]
        [StringLength(200, ErrorMessage = "Title can not exceed 200 characters")]
        public string? Title { get; set; }

        [Required]
        public string? Content { get; set; } = string.Empty;

        public string Author { get; set; } = "admin";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedDate { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}