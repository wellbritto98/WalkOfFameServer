﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WalkOfFameServer.Models.Users;
using WalkOfFameServer.Services;

namespace WalkOfFameServer.API.Controllers
{
    [ApiController, Route("/Api/[controller]")]
    public class CoreController : ControllerBase
    {
        protected readonly UserService _userService;

        public CoreController(UserService service)
        {
            _userService = service;
        }
        protected long? GetCurrentUserId()
        {
            return long.Parse(HttpContext.Items["CurrentUserId"]?.ToString());
        }

        protected async Task<User?> GetCurrentUser()
        {
            var currentId = GetCurrentUserId();
            
            if (!currentId.HasValue) return null;
            
            var user = await _userService.GetById(currentId.Value);

            return user;
        }
    }
}
