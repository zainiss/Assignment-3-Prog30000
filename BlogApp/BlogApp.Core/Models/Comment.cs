using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Core.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public int PostId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Comments can not exceed 100 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [StringLength(150, ErrorMessage = "Email can not exceed 150 characters")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Content Required")]
        [StringLength(1000, ErrorMessage = "Content can not exceed 1000 characters")]
        public string? Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required] //made required since a comment can't be made without a post, 
                    //this is to enforce the relationship rules on developer(s).
        public Post? OriginPost {get; set;}

    }
}