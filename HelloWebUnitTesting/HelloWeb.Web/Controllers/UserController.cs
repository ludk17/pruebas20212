using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWeb.Web.Db;
using HelloWeb.Web.Models;
using HelloWeb.Web.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HelloWeb.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository repository;

        public UserController(IUserRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Message = "Mi mensaje en el viewbag";
            return View(repository.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            ValidateUserCreation(user);
            
            if(!ModelState.IsValid)
                return View("Create", user);

            repository.Create(user);

            TempData["MessageSuccess"] = "El usuario se registro correctamente";

            return RedirectToAction("Index");
        }

        private void ValidateUserCreation(User user)
        {
            if (string.IsNullOrEmpty(user.Username))
                ModelState.AddModelError("Username", "Username is required");
            if (string.IsNullOrEmpty(user.Password))
                ModelState.AddModelError("Password", "Password is required");
        }
    }
}
