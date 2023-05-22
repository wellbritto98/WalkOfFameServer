using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WalkOfFameServer.Models
{
    public class Scoring
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)] 
        public string Name { get; set; }

        [StringLength(255)] 
        public string Description { get; set; }
    }
}
