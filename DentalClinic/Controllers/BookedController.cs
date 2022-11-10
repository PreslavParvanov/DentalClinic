using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    public class BookedController : Controller
    {
        private readonly IDoctorScheduleService doctorScheduleService;
        private readonly IErrorService errorService;
        public BookedController(
            IDoctorScheduleService _doctorScheduleService,
            IErrorService _errorService
            )
        {
            doctorScheduleService = _doctorScheduleService;
            errorService = _errorService;
        }

        [HttpGet]
        public async Task<IActionResult> Booked(Guid doctor)
        {
            var doctorSchedule = await doctorScheduleService.GetDoctorScheduleAsync(doctor);
            return View(doctorSchedule);
        }
    }
}
