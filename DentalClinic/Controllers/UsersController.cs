﻿using DentalClinic.BL.Models;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {

        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public UsersController(
                                UserManager<User> _userManager,
                                SignInManager<User> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            var model = new UserViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByNameAsync(model.Email);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "Invalid login");

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Registration()
        {
            var model = new RegistrationViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Registration(RegistrationViewModel model)
        {  

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                UserName = model.Email,
                FirstName = model.FirstName,
                LastName=model.LastName,
                Email = model.Email,
                PhoneNumber = model.Phonenumber,
                When = DateTime.Now,
                IsActive=1
            };

            var result = await userManager.CreateAsync(user, model.Password);
            

            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Login));
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
