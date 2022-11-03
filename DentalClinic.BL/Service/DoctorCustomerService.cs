using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.DB.Common;
using DentalClinic.DB.Data;
using DentalClinic.DB.Data.Models;
using Microsoft.Extensions.Configuration;

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

       
    }
}
