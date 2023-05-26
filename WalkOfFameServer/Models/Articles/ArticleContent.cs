using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WalkOfFameServer.Models
{
    public class ArticleContent
    {
        [Key]
        [ForeignKey("Article")]
        public long ArticleId { get; set; }

        public Article Article { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }
    }
}
