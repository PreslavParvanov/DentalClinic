using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.DB.Common;
using DentalClinic.DB.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DentalClinic.BL.Service
{
    public class DoctorService : IDoctorService
    {
        private readonly IConfiguration config;

        public  DoctorService(IConfiguration _config)
        {
            config = _config;
        }


        private readonly IRepository repo;

        /// <summary>
        /// IoC 
        /// </summary>
        /// <param name="_config">Application configuration</param>
        public DoctorService(
            IConfiguration _config,
            IRepository _repo)
        {
            config = _config;
            repo = _repo;
        }

        public async Task<IEnumerable<GetDoctorViewModel>> GetAll()
        {      
                var result = await repo.AllReadonly<Doctor>()
                .Where(d => d.IsActive==1)
                .Select(d => new GetDoctorViewModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                    Qualification = d.Qualification,
                    MoreInfo = d.MoreInfo
                }).ToListAsync();

            return result;
        }

        public async Task Create(DoctorViewModel doctorViewModel)
        {
            var doctor = new Doctor()
            {
                Name = doctorViewModel.Name,
                Qualification = doctorViewModel.Qualification,
                MoreInfo = doctorViewModel.MoreInfo,
                IsActive = 1,
                Who = doctorViewModel.Who,
                When = DateTime.Now
            };

            await repo.AddAsync(doctor);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<GetDoctorViewModel>> GetDoctorById(Guid doctorId)
        {
            var result = await repo.AllReadonly<Doctor>()
                .Where(d => d.IsActive == 1)
                .Where(d => d.Id== doctorId)
                .Select(d => new GetDoctorViewModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                    Qualification = d.Qualification,
                    MoreInfo = d.MoreInfo
                }).ToListAsync();

            return result;
        }
    }
}
