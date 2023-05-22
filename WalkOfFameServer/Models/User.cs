using System;
using System.Text.Json.Serialization;

namespace WalkOfFameServer.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredAt { get; set; } = DateTime.Now;
        public DateTime LastLoginAt { get; set; } = DateTime.Now;
        
        [JsonIgnore]
        public string Password { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
    }
}
