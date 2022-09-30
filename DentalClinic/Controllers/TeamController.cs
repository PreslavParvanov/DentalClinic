using DentalClinic.BL.Contracts;
using Microsoft.AspNetCore.Mvc;


namespace DentalClinic.Controllers
{
    public class TeamController : Controller
    {
        private readonly IDoctorService doctorService;

        public TeamController(IDoctorService _doctorService)
        {
            doctorService = _doctorService;
        }
        [HttpGet]
        public async Task<IActionResult> Team()
        {
            var doctors = await doctorService.GetAll();
            return View(doctors);
        }

        [HttpPost]
        public async Task<IActionResult> Team(string doctor)
        {
            return RedirectToAction(nameof(Booked));
        }

        public IActionResult Booked(string doctor)
        {
            return View();
        }
    }
}
