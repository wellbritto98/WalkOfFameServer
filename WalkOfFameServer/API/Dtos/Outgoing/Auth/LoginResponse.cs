using System;
using WalkOfFameServer.API.Dtos.Outgoing.User;

namespace WalkOfFameServer.API.Dtos.Outgoing.Auth
{
    public class LoginResponse
    {
        public string Token;
        public DateTime ExpiresAt;
        public UserDto User;
    }
}
