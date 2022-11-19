﻿using DentalClinic.BL.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DentalClinic.Controllers
{
    public class ReportController : Controller
    {
        //Dentist
        private readonly IReportService reportService;
        private readonly IErrorService errorService;


        public ReportController(
            IReportService _reportService,
            IErrorService _errorService)
        {
            reportService = _reportService;
            errorService = _errorService;
        }

        [HttpGet]
        public async  Task<IActionResult> Dentists()
        {
            var result = await reportService.GetAllDentists();
            return View(result);
        }
    }
}
