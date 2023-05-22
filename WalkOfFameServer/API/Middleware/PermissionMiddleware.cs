using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace WalkOfFameServer.API.Middleware
{
    public class PermissionMiddleware
    {
        private readonly RequestDelegate _next;

        public PermissionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var currentUserId = "";

            if (context.User.HasClaim(c => c.Type == ClaimTypes.NameIdentifier))
            {
                var claim = context.User.Claims.FirstOrDefault(i => i.Type == ClaimTypes.NameIdentifier);

                if (claim != null)
                {
                    currentUserId = claim.Value;
                }
            }

            context.Items.Add("CurrentUserId", currentUserId);
            await _next(context);
        }
    }
    
    public static class PermissionMiddlewareExtensions
    {
        public static IApplicationBuilder UsePermission(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<PermissionMiddleware>();
        }
    }
}
