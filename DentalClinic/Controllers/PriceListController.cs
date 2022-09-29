using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalClinic.Controllers
{
    public class PriceListController : Controller
    {
        public IActionResult CreateDentist()
        {
            return View();
        }
    }
}
