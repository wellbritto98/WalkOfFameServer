﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WalkOfFameServer.Models
{
    public class Scoring
    {
        public string Id { get; set; }

        [Required]
        [StringLength(100)] 
        public string Name { get; set; }

        [StringLength(255)] 
        public string Description { get; set; }
    }
}
