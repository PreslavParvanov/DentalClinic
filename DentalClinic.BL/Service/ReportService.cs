using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.DB.Common;
using DentalClinic.DB.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DentalClinic.BL.Service
{
    public class ReportService : IReportService
    {
        private readonly IConfiguration config;

        public ReportService(IConfiguration _config)
        {
            config = _config;
        }


        private readonly IRepository repo;

        /// <summary>
        /// IoC 
        /// </summary>
        /// <param name="_config">Application configuration</param>
        public ReportService(
            IConfiguration _config,
            IRepository _repo)
        {
            config = _config;
            repo = _repo;
        }
        /// <summary>
        /// Get all doctors
        /// </summary>
        /// <returns>ToList whit GetDoctorViewModel</returns>

        public async Task<IEnumerable<GetDoctorViewModel>> GetAllDentists()
        {
            var result = await repo.AllReadonly<Doctor>()
                .Select(d => new GetDoctorViewModel()
                {
                    Name = d.Name,
                    Qualification = d.Qualification,
                    MoreInfo = d.MoreInfo
                })
                .OrderBy(d => d.Name)
                .ToListAsync();
            return result;
        }
    }
}
