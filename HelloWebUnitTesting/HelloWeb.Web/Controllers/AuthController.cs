using System.Collections.Generic;
using System.Security.Claims;
using HelloWeb.Web.Repositories;
using HelloWeb.Web.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace HelloWeb.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserRepository repository;
        private readonly IAuthService auth;

        public AuthController(IUserRepository repository, IAuthService auth)
        {
            this.repository = repository;
            this.auth = auth;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = repository.FindUserByCredentials(username, password);
            if(user != null)
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, username)
                };

                auth.Login(claims);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("LoginValidation", "Usuario o contraseña Incorercta");
            return View();
        }
    }
}
