using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DentalClinic.Controllers
{
    public class AdminController : Controller
    {
        private readonly IDoctorService doctorService;
        private readonly IDoctorCustomerService doctorCustomerService;
        private readonly IDoctorScheduleService doctorScheduleService;
        private readonly IErrorService errorService;


        public AdminController(
            IDoctorService _doctorService, 
            IErrorService _errorService,
            IDoctorCustomerService _doctorCustomerService,
            IDoctorScheduleService _doctorScheduleService)
        {
            doctorService = _doctorService;
            errorService = _errorService;
            doctorCustomerService = _doctorCustomerService;
            doctorScheduleService = _doctorScheduleService;
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
            var model = new DoctorScheduleViewModel()
            {
                Doctors = await doctorScheduleService.GetDoctorsAsync()
            };
            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> CreateSchedule(DoctorScheduleViewModel doctorScheduleViewModel)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            doctorScheduleViewModel.Who = userId.ToString();

            if (ModelState.IsValid)
            {
                return View(doctorScheduleViewModel);
            }
            if (doctorScheduleViewModel.endDate<= doctorScheduleViewModel.startDate)
            {
                ModelState.AddModelError("", "endDate is < or = on startDate!");
                return View(doctorScheduleViewModel);
            }
            await doctorScheduleService.CreateSchedule(doctorScheduleViewModel);
            return RedirectToAction(nameof(CreateSchedule));
        }
    }
}
