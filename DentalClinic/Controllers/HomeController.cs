using DentalClinic.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace DentalClinic.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var userName = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            ViewBag.UserName = userName;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
