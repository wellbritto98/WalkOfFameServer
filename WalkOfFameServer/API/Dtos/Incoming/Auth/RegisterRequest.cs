﻿using System.ComponentModel.DataAnnotations;

namespace WalkOfFameServer.API.Dtos.Incoming.Auth
{
    public class RegisterRequest
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
