using System.Security.Claims;

namespace ecommerce_app.Utils
{
    public static class GeneralUtils
    {
        public static string? GetUserId(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
