using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.BL.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalClinic.Controllers
{
    public class UsersController : Controller
    {

        private readonly IUserService userService;

        public UsersController(IUserService _userService)
        {
            userService = _userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserViewModel userViewModel)
        {
            if (userViewModel.Email.Length < 1 || userViewModel.Password.Length < 1)
            {
                return View();
            }
            string result = await userService.Get(userViewModel);
            ViewBag.Message = result;
            if (result== "User does not exist!")
            {
                return View(nameof(Login), userViewModel);
            }
            else if (result == "Invalid password!")
            {
                return View(nameof(Login), userViewModel);
            }
            else
            {
                return Redirect("/");
            }
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if(model.Password != model.RePassword)
            {
                return View(model);
            }
            await userService.Create(model);
            return RedirectToAction(nameof(Login));
        }

        public IActionResult SignOut()
        {
            return Redirect("/");
        }
    }
}
