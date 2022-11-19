using DentalClinic.BL.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    public class ReportController : Controller
    {
        //Dentist
        private readonly IDoctorService doctorService;
        private readonly IErrorService errorService;


        public ReportController(
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
    }
}
