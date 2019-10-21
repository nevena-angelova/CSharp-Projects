using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PANDA.Data;
using PANDA.Models;
using PANDA.Services;
using PANDA.Web.ViewModels;
using System;
using System.Linq;

namespace PANDA.Web.Controllers
{
    public class UsersController : BaseController
    {

        private readonly PandaDbContext _context;

        public UsersController(PandaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = _context.Users.Where(x => x.Username == model.Username).Select(x => new { x.PasswordHash, x.PasswordSalt, Role = x.Role.Name }).FirstOrDefault();
            if (user == null)
            {
                throw new ArgumentException("Invalid username!");
            }

            var passHash = UsersService.CreateCheckPasswordHash(model.Password, user.PasswordSalt);
            if (!(user.PasswordHash.SequenceEqual(passHash)))
            {
                throw new ArgumentException("Invalid password!");
            }

            ControllerContext.HttpContext.Response.Cookies.Append("auth", model.Username);
            ControllerContext.HttpContext.Response.Cookies.Append("role", user.Role);

            return View();
        }

        public IActionResult Logout()
        {
            Response.Cookies.Delete("auth");
            Response.Cookies.Delete("role");

            return RedirectToAction(nameof(Login));
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            byte[] passHash, saltHash;
            UsersService.CreatePasswordHash(model.Password, out passHash, out saltHash);

            var user = new User
            {
                Email = model.Email,
                Username = model.Username,
                RoleId = 2,
                PasswordHash = passHash,
                PasswordSalt = saltHash
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            ControllerContext.HttpContext.Response.Cookies.Append("auth", model.Username);
            ControllerContext.HttpContext.Response.Cookies.Append("role", "User");

            return View();
        }
    }
}