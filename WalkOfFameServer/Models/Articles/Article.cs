using System;
using System.ComponentModel.DataAnnotations;

namespace WalkOfFameServer.Models
{
    public class Article
    {
        [Key]
        public long Id { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime EditedAt { get; set; } = DateTime.Now;

        public List<ArticleContent> Contents { get; set; }
    }
}
