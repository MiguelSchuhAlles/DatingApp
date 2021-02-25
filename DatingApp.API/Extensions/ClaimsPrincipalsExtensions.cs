using System.Security.Claims;

namespace DatingApp.API.Extensions
{
    public static class ClaimsPrincipalsExtensions
    {
        public static string GetUserName(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}