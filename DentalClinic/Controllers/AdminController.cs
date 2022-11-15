using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DentalClinic.Controllers
{
    public class AdminController : Controller
    {
        private readonly IDoctorService doctorService;
        private readonly IErrorService errorService;


        public AdminController(
            IDoctorService _doctorService, 
            IErrorService _errorService)
        {
            doctorService = _doctorService;
            errorService = _errorService;
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
            if (userId != null)
            {
                model.Who = userId.ToString();
            }
            
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
            var model = new DoctorScheduleViewModel()
            {
                Doctors = await doctorService.GetDoctorsAsync()
            };
            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> CreateSchedule(DoctorScheduleViewModel doctorScheduleViewModel, TimeSpan startTime, TimeSpan endTime)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userId != null)
            {
                doctorScheduleViewModel.Who = userId.ToString();
            }

            if (ModelState.IsValid)
            {
                return View(doctorScheduleViewModel);
            }
            if (doctorScheduleViewModel.endDate<= doctorScheduleViewModel.startDate)
            {
                ModelState.AddModelError("", "end Date is < or = on start Date!");
                return View(doctorScheduleViewModel);
            }
            if (endTime <= startTime)
            {
                ModelState.AddModelError("", "end Time is < or = on start Time!");
                return View(doctorScheduleViewModel);
            }
            await doctorService.CreateSchedule(doctorScheduleViewModel, startTime, endTime);
            return RedirectToAction(nameof(CreateSchedule));
        }
    }
}
