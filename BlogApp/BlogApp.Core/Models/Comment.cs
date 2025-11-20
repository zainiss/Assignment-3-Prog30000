using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        [JsonIgnore] // Ignore this property for postman
        public Post? OriginPost {get; set;}

    }
}