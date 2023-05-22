using System.ComponentModel.DataAnnotations;

namespace WalkOfFameServer.API.Dtos.Incoming.Auth
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "empty")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "empty")]
        public string Password { get; set; }
    }
}
