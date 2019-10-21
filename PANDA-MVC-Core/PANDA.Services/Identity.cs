using Microsoft.AspNetCore.Http;

namespace PANDA.Services
{
    public static class Identity
    {
        private static IHttpContextAccessor _accessor;

        public static void Configure(IHttpContextAccessor httpContextAccessor)
        {
            _accessor = httpContextAccessor;
        }

        public static HttpContext _context => _accessor.HttpContext;

        public static bool IsUserLogged()
        {
            var userName = _context.Request.Cookies["auth"];
            if (userName == null)
            {
                return false;
            }

            return true;
        }

        public static string GetUserName()
        {
            return _context.Request.Cookies["auth"];
        }

        public static bool IsUserInRole(string role)
        {
            return _context.Request.Cookies["role"] == role;
        }
    }
}
