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
        private readonly IErrorService errorService;


        public AdminController(IDoctorService _doctorService, IErrorService _errorService)
        {
            doctorService = _doctorService;
            errorService = _errorService;
        }

        [HttpGet]
        public IActionResult CreateDentist()
        {
            var model = new DoctorViewModel();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDentist(DoctorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await doctorService.Create(model);
                
                return RedirectToAction("Team", "Team");
            }
            catch (Exception ex)
            {
                await errorService.DCLog(ex);
                return View(model);
            }
           
        }
    }
}
