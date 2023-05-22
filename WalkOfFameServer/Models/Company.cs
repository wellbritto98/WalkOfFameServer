﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WalkOfFameServer.Models
{
    public class Company
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
