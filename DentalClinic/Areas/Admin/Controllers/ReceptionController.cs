using DentalClinic.BL.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Areas.Admin.Controllers
{
    [Authorize]
    public class ReceptionController : AdminBaseController
    {
        private readonly IReceptionService resectionService;

        public ReceptionController(IReceptionService _resectionService)
        {
            resectionService = _resectionService;
        }

        [HttpGet]
        public IActionResult Reception()
        {
            ViewData["Title"] = "Dental Clinic";
            ViewBag.dateSearch = DateTime.Now;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Reception(DateTime DateSearch)
        {
            ViewData["Title"] = "Dental Clinic";
            TimeSpan startTime = new TimeSpan(00, 00, 00);
            TimeSpan endTime = new TimeSpan(23, 59, 59);
            DateTime startDate = DateSearch + startTime;
            DateTime endDate = DateSearch + endTime;
            var result = await resectionService.GetAllBookedByDate(startDate, endDate);
            ViewBag.dateSearch = DateSearch;
            return View("ReceptionHdr", result);

        }

        [HttpPost]
        public async Task<IActionResult> ReceptionDet(Guid DoctorId, string CustomerId, DateTime curenttDate)
        {
            var result = await resectionService.GetBookedDetailsById(DoctorId, CustomerId, curenttDate);
            return View("ReceptionDet", result);
        }
    }
}
