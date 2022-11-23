using DentalClinic.BL.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    [Authorize]
    public class ReceptionController : Controller
    {
        private readonly IReceptionService resectionService;

        public ReceptionController(IReceptionService _resectionService)
        {
            resectionService = _resectionService;
        }

        [HttpGet]
        public IActionResult Reception()
        {
            ViewBag.dateSearch = DateTime.Now;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Reception(DateTime DateSearch)
        {
            TimeSpan startTime = new TimeSpan(00, 00, 00);
            TimeSpan endTime = new TimeSpan(23, 59, 59);
            DateTime startDate = DateSearch + startTime;
            DateTime endDate = DateSearch + endTime;
            var result = await resectionService.GetAllBookdeByDate(startDate, endDate);
            ViewBag.dateSearch = DateSearch;
            return View(result);
        }
    }
}
