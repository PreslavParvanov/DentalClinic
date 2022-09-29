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
        public async Task<IActionResult> Team()
        {
            var doctors = await doctorService.GetAll();
            return View(doctors);
        }

        public IActionResult SaveReview()
        {
            return View();
        }
    }
}
