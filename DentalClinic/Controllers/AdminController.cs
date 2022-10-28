using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.BL.Service;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DentalClinic.Controllers
{
    public class AdminController : Controller
    {
        private readonly IDoctorService doctorService;
        private readonly IDoctorCustomerService doctorCustomerService;
        private readonly IErrorService errorService;


        public AdminController(
            IDoctorService _doctorService, 
            IErrorService _errorService,
            IDoctorCustomerService _doctorCustomerService)
        {
            doctorService = _doctorService;
            errorService = _errorService;
            doctorCustomerService = _doctorCustomerService;
        }

        [HttpGet]
        public IActionResult CreateDentist()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDentist(DoctorViewModel model)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            model.Who = userId.ToString();
            if (ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await doctorService.Create(model);
            }
            catch (Exception ex)
            {
                await errorService.DCLog(ex);
                return View(model);
            }
            return RedirectToAction(nameof(CreateDentist)); 
        }

        [HttpGet]
        public async Task<IActionResult> CreateSchedule()
        {
            var model = new DoctorCustomerViewModel()
            {
                Doctors = await doctorCustomerService.GetDoctorsAsync()
            };
            return View(model);

        }
    }
}
