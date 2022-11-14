using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.BL.Service;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DentalClinic.Controllers
{
    public class BookedController : Controller
    {
        private readonly IDoctorService doctorService;
        private readonly IErrorService errorService;
        public BookedController(
            IDoctorService _doctor,
            IErrorService _errorService
            )
        {
            doctorService = _doctor;
            errorService = _errorService;
        }

        [HttpGet]
        public async Task<IActionResult> Booked(Guid doctor, DateTime dateSearch)
        {
            
            if (dateSearch < DateTime.Now)
            {
                dateSearch=DateTime.Now;
            }
            var doctorSchedule = await doctorService.GetDoctorSchedule(doctor, dateSearch);
            return View(doctorSchedule);
        }


        [HttpPost]
        public async Task<IActionResult> Booked(DoctorScheduleViewModel model)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (userId != null)
            {
                model.Who = userId.ToString();
            }
            model.IsBusy = true;
            if (ModelState.IsValid)
            {
                return View(model);
            }
            
            await doctorService.Booked(model);
            return RedirectToAction("Index", "Home");
        }
    }
}
