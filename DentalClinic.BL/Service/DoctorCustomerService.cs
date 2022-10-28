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
    public class DoctorCustomerService : IDoctorCustomerService
    {
        private readonly IConfiguration config;
        private readonly ApplicationDbContext context;

        public DoctorCustomerService(IConfiguration _config)
        {
            config = _config;
           
        }


        private readonly IRepository repo;

        /// <summary>
        /// IoC 
        /// </summary>
        /// <param name="_config">Application configuration</param>
        public DoctorCustomerService(
            IConfiguration _config,
            IRepository _repo)
        {
            config = _config;
            repo = _repo;
        }

        /*public async Task<IEnumerable<DoctorScheduleViewModel>> GetAll()
        {
            var entities = await context.DoctorSchedules
                .Include(d => d.Doctors)
                .ToListAsync(); ;


            return entities
                .Select(ds => new DoctorScheduleViewModel()
                {
                    DoctorId = ds.DoctorId,
                    CustomerId = ds.CustomerId,
                    DateTimeSchedule = ds.DateTime,
                    IsBusy = ds.IsBusy,
                    //Doctors = ds.Doctors.Name
                });
        }*/

        public async Task CreateDoctorSchedule(DoctorCustomerViewModel doctorCustomerViewModel)
        {
            var doctorSchedule = new DoctorCustomer()
            {
                DoctorId = doctorCustomerViewModel.DoctorId,
                DateTime = doctorCustomerViewModel.DateTimeSchedule,
                CustomerId = doctorCustomerViewModel.CustomerId,
                IsBusy = true
            };
            await repo.AddAsync(doctorSchedule);
            await repo.SaveChangesAsync();
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
