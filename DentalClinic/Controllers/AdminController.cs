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
    public class AdminController : Controller
    {
        private readonly IDoctorService doctorService;

        public AdminController(IDoctorService _doctorService)
        {
            doctorService = _doctorService;
        }

        [HttpGet]
        public IActionResult CreateDentist()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDentist(DoctorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await doctorService.Save(model);
            return RedirectToAction(nameof(CreateDentist)); 
        }
    }
}
