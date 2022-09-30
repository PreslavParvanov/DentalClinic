using Microsoft.Extensions.Configuration;
using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using DentalClinic.DB.Data.Models;
using DentalClinic.DB.Common;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<DoctorViewModel>> GetAll()
        {
            return await repo.AllReadonly<Doctor>()
                .Where(d => d.IsActive==1)
                .Select(d => new DoctorViewModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                    Qualification = d.Qualification,
                    MoreInfo = d.MoreInfo
                }).ToListAsync();
        }

        public async Task Save(DoctorViewModel doctorViewModel)
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
    }
}
