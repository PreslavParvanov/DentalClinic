using DentalClinic.BL.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DentalClinic.Controllers
{
    public class TeamController : Controller
    {
        private readonly IDoctorService doctorService;
        private readonly IErrorService errorService;
        public TeamController(
            IDoctorService _doctorService,
            IErrorService _errorService
            )
        {
            doctorService = _doctorService;
            errorService = _errorService;
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

        [HttpGet]
        public IActionResult Booked()
        {
            return View();
        }
    }
}
