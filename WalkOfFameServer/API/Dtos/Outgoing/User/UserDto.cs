﻿using System;

namespace WalkOfFameServer.API.Dtos.Outgoing.User
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredAt { get; set; }
        public DateTime LastLoginAt { get; set; }
    }
}
