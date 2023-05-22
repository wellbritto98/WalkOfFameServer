using System.ComponentModel.DataAnnotations;

namespace WalkOfFameServer.API.Dtos.Incoming.Auth
{
    public class RegisterRequest
    {
        [Required(ErrorMessage = "empty")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "empty")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "empty"), EmailAddress(ErrorMessage = "invalid")]
        public string Email { get; set; }
    }
}
