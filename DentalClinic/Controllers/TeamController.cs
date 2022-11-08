using DentalClinic.BL.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    public class TeamController : Controller
    {
        private readonly IDoctorService doctorService;
        private readonly IDoctorScheduleService doctorScheduleService;
        private readonly IErrorService errorService;
        public TeamController(
            IDoctorService _doctorService,
            IDoctorScheduleService _doctorScheduleService,
            IErrorService _errorService
            )
        {
            doctorService = _doctorService;
            doctorScheduleService = _doctorScheduleService;
            errorService = _errorService;
        }
        [HttpGet]
        public async Task<IActionResult> Team()
        {

            var doctors = await doctorService.GetAll();
            return View(doctors);
        }

        [HttpPost]
        public async void Team(Guid doctor)
        {
            await Booked(doctor);
        }

        [HttpGet]
        private async Task<IActionResult> Booked(Guid doctor)
        {
            var doctorSchedule = await doctorScheduleService.GetDoctorScheduleAsync();
            return View(doctorSchedule);
        }
    }
}
