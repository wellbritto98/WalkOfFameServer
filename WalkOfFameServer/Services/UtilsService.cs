using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace WalkOfFameServer.Services
{
    public class UtilsService
    {
        private readonly IConfiguration _configuration;
        
        public UtilsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public string HashSha512(string input)
        {
            var hash = SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(input + _configuration["PasswordSalt"]));
            return string.Concat(hash.Select(b => b.ToString("x2")));
        }
        
        public JwtSecurityToken GetJwtToken(IEnumerable<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            return token;
        }
    }
}
