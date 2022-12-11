using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DentalClinic.Areas.Admin.Controllers
{
    [Authorize]
    public class AdminController : AdminBaseController
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
                var result = await doctorService.GetAll();
                var doctor = result.Where(d => d.Name.ToUpper() == model.Name.ToUpper()).FirstOrDefault();
                if (doctor == null)
                {
                    await doctorService.Create(model);
                }
                else
                {
                    ModelState.AddModelError("", "This doctor exists!");
                    return View(model);
                }

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
                doctorScheduleViewModel.Doctors = await doctorService.GetDoctorsAsync();
                return View(doctorScheduleViewModel);
            }
            if (doctorScheduleViewModel.endDate <= doctorScheduleViewModel.startDate)
            {
                ModelState.AddModelError("", "end Date is < or = on start Date!");
                doctorScheduleViewModel.Doctors = await doctorService.GetDoctorsAsync();
                return View(doctorScheduleViewModel);
            }
            if (endTime <= startTime)
            {
                ModelState.AddModelError("", "end Time is < or = on start Time!");
                doctorScheduleViewModel.Doctors = await doctorService.GetDoctorsAsync();
                return View(doctorScheduleViewModel);
            }
            var result = await doctorService.GetDoctorSchedule(doctorScheduleViewModel.DoctorId, doctorScheduleViewModel.startDate, doctorScheduleViewModel.endDate);
            if (result.Count() == 0)
            {
                await doctorService.CreateSchedule(doctorScheduleViewModel, startTime, endTime);
                return RedirectToAction(nameof(CreateSchedule));
            }
            else
            {
                ModelState.AddModelError("", $"The doctor has a schedule from {startTime} to {endTime}!");
                doctorScheduleViewModel.Doctors = await doctorService.GetDoctorsAsync();
                return View(doctorScheduleViewModel);
            }


        }
    }
}
