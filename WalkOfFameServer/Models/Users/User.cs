using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using WalkOfFameServer.Models.Characters;

namespace WalkOfFameServer.Models.Users
{
    [Index(nameof(UserName), IsUnique = true), Index(nameof(Email), IsUnique = true)]
    public class User
    {
        public long Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime RegisteredAt { get; set; } = DateTime.Now;
        public DateTime LastLoginAt { get; set; } = DateTime.Now;
        
        [JsonIgnore]
        [Required]
        public string Password { get; set; }
        
        [InverseProperty("User")]
        public List<Character> Characters { get; } = new();
    }
}
