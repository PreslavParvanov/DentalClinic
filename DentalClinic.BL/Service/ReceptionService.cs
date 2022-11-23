﻿using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.DB.Common;
using DentalClinic.DB.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DentalClinic.BL.Service
{
    public class ReceptionService : IReceptionService
    {
        private readonly IConfiguration config;

        public ReceptionService(IConfiguration _config)
        {
            config = _config;
        }


        private readonly IRepository repo;

        /// <summary>
        /// IoC 
        /// </summary>
        /// <param name="_config">Application configuration</param>
        public ReceptionService(
            IConfiguration _config,
            IRepository _repo)
        {
            config = _config;
            repo = _repo;
        }

        /// <summary>
        /// Мethod that lists the doctor's schedule to date 
        /// </summary>
        /// <param name="dateStart"></param>
        /// /// <param name="dateEnd"></param>
        /// <returns>ToList whit ReceptionCustomerViewModel</returns>
        public async Task<IEnumerable<ReceptionViewModel>> GetAllBookdeByDate(DateTime dateStart, DateTime dateEnd)
        {
            var result = await repo.AllReadonly<DoctorCustomer>()
                .Where(ds => ds.DateTime >= dateStart && ds.DateTime <= dateEnd)
                .Select(ds => new ReceptionViewModel()
                {
                    DoctorId = ds.DoctorId,
                    DoctorName = ds.Doctors.Name,
                    DateTimeSchedule = ds.DateTime,
                    CustomerId = ds.CustomerId,
                    CustomerName = ds.CustomerName,
                    CustomerEmail = ds.CustomerEmail,
                    CustomerPhone = ds.CustomerPhone
                })
                .OrderBy(ds => ds.DoctorName)
                .ThenBy(ds => ds.DateTimeSchedule)
                .ToListAsync();
            return result;
        }
    }
}
