using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.BL.Service;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
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
        public async Task<IActionResult> Booked(string Title, Guid doctor,  DateTime dateStart, DateTime dateEnd, string message)
        {
            ViewBag.TitlePage = Title;
            ViewBag.Message = message;
            if (dateStart < DateTime.Now)
            {
                dateStart = DateTime.Now;
                dateEnd = DateTime.Now.AddDays(5);
            }
            var doctorSchedule = await doctorService.GetDoctorSchedule(doctor, dateStart, dateEnd);
            return View(doctorSchedule);
        }


        [HttpPost]
        public async Task<IActionResult> Booked(DoctorScheduleViewModel model, string Title)
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
            string message = $"Successfully booked for {model.startDate}";
            return RedirectToAction("Booked", "Booked", new { Title, doctor = model.DoctorId, message = message } );
            
        }
    }
}
