using System.ComponentModel.DataAnnotations;

namespace WalkOfFameServer.API.Dtos.Incoming.Auth
{
    public class LoginRequest
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
