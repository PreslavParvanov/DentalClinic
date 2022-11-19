using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {
        //Dentist
        private readonly IReportService reportService;
        private readonly IDoctorService doctorService;
        private readonly IErrorService errorService;


        public ReportController(
            IReportService _reportService,
            IDoctorService _doctorService,
            IErrorService _errorService)
        {
            reportService = _reportService;
            doctorService = _doctorService;
            errorService = _errorService;
        }

        [HttpGet]
        public async  Task<IActionResult> Dentists()
        {
            var result = await reportService.GetAllDentists();
            ViewBag.Doctor = "All";
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> DentistSchedule()
        {
            var model = new DoctorScheduleViewModel()
            {
                Doctors = await doctorService.GetDoctorsAsync()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DentistSchedule(Guid DoctorId,  DateTime startDate, DateTime endDate)
        {
            var result = await reportService.GetDentistScheduleByDate(DoctorId, startDate, endDate);
            var doctor = await doctorService.GetDoctorById(DoctorId);
            
            ViewBag.Doctor = doctor.ElementAt(0).Name;
            ViewBag.startDate = startDate; 
            ViewBag.endDate = endDate;  
            return View("DentistScheduleResult",result);
        }

    }
}
