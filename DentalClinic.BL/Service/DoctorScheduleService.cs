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
using System.Data.Common;
using DentalClinic.DB.Data;

namespace DentalClinic.BL.Service
{
    public class DoctorScheduleService : IDoctorScheduleService
    {
        private readonly IConfiguration config;
        private readonly ApplicationDbContext context;

        public DoctorScheduleService(IConfiguration _config)
        {
            config = _config;

        }


        private readonly IRepository repo;

        /// <summary>
        /// IoC 
        /// </summary>
        /// <param name="_config">Application configuration</param>
        public DoctorScheduleService(
            IConfiguration _config,
            IRepository _repo)
        {
            config = _config;
            repo = _repo;
        }


        public async Task CreateSchedule(DoctorScheduleViewModel doctorScheduleViewModel)
        {
            DateTime currentDateTime = doctorScheduleViewModel.startDate;
            DateTime endDate = doctorScheduleViewModel.endDate;

            while (endDate > currentDateTime)
            {
                var doctorSchedule = new DoctorSchedule()
                {
                    DoctorId = doctorScheduleViewModel.DoctorId,
                    ScheduleDateTime = currentDateTime,
                    Who = doctorScheduleViewModel.Who,
                    When = DateTime.Now,
                    IsBusy = false,

                };
                await repo.AddAsync(doctorSchedule);
                await repo.SaveChangesAsync();

                currentDateTime = currentDateTime.AddMinutes(30);
            }
        }


        public async Task<IEnumerable<Doctor>> GetDoctorsAsync()
        {
            var result = await repo.AllReadonly<Doctor>()
                .Select(d => new Doctor()
                {
                    Id = d.Id,
                    Name = d.Name,
                    Qualification = d.Qualification,
                    MoreInfo = d.MoreInfo,
                    Who = d.Who
                }).ToListAsync();
            return result;
        }
    }
}