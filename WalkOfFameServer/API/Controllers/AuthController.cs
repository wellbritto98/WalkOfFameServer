using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalkOfFameServer.API.Dtos.Incoming.Auth;
using WalkOfFameServer.Models;
using WalkOfFameServer.Models.Users;
using WalkOfFameServer.Services;

namespace WalkOfFameServer.API.Controllers
{
    public class AuthController : CoreController
    {
        private readonly UserService _service;
        private readonly UtilsService _utils;

        public AuthController(UserService service, UtilsService utils)
        {
            _service = service;
            _utils = utils;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var user = await _service.GetByUserNameAndPassword(request.UserName, request.Password);

            if (user == null) return Unauthorized(new { message = "Username and/or password do not match!" });

            var token = _utils.GetJwtToken(new[] {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            });
            
            return Ok(new {
                data = new {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo,
                    user
                }
            });
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var checkEmail = await _service.GetByEmail(request.Email);

            if (checkEmail != null) return Conflict(new { message = "E-mail address already taken!" });

            var checkName = await _service.GetByUserName(request.UserName);
            
            if (checkName != null) return Conflict(new { message = "Username already taken!" });

            var user = await _service.Create(new User {
                UserName = request.UserName,
                Password = request.Password,
                Email = request.Email
            });

            var token = _utils.GetJwtToken(new[] {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            });
            
            return Ok(new {
                data = new {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo,
                    user
                }
            });
        }
    }
}
