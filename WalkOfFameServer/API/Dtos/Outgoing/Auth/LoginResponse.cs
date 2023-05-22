using System;
using WalkOfFameServer.API.Dtos.Outgoing.User;

namespace WalkOfFameServer.API.Dtos.Outgoing.Auth
{
    public class LoginResponse
    {
        public string Token { get; set; }
        public DateTime ExpiresAt { get; set; }
        public UserDto User { get; set; }
    }
}
