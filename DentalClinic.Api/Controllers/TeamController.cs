using DentalClinic.Api;
using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DentalClinicApi.Controllers
{
    [ApiController]
    [Route("/[controller]/[action]")]
    
    public class TeamController : ControllerBase
    {
        private readonly IDoctorService doctorService;
        /// <summary>
        /// DoctorService
        /// </summary>
        /// <param name="_doctorService"></param>
        public TeamController(IDoctorService _doctorService)
        {
            doctorService = _doctorService;
        }
        /// <summary>
        /// Get All doctors
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetAllDoctors")]
        [Produces("application/json")]
        [ProducesResponseType(200, StatusCode = StatusCodes.Status200OK, Type = typeof(IEnumerable<GetDoctorViewModel>))]
        public async Task<IActionResult> GetAllDoctors()
        {
            var teams = await doctorService.GetAll();
            if (teams == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(teams);
        }

        /// <summary>
        /// Get doctor by Id
        /// </summary>
        /// <param name="doctorId"></param>
        /// <returns></returns>
        [HttpGet("{doctorId:guid}", Name = "GetDoctorById")]
        [Produces("application/json")]
        [ProducesResponseType(200, StatusCode = StatusCodes.Status200OK, Type = typeof(IEnumerable<GetDoctorViewModel>))]

        public async Task<IActionResult> GetDoctorById(Guid doctorId)
        {
            var teams = await doctorService.GetDoctorById(doctorId);
            if (teams == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(teams);
        }
    }
}
