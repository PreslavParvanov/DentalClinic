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

        public async Task<IEnumerable<DoctorScheduleViewModel>> GetDoctorSchedule(Guid doctor)
        {
            var result = await repo.AllReadonly<DoctorSchedule>()
                .Where(ds => ds.DoctorId == doctor)
                .Select(ds => new DoctorScheduleViewModel()
                {
                    DoctorId = ds.DoctorId,
                    startDate = ds.ScheduleDateTime,
                    IsBusy = ds.IsBusy,
                })
                .OrderBy(ds => ds.startDate)
                .ToListAsync();
            return result;
        }

        public async Task Booked(DoctorScheduleViewModel doctorScheduleViewModel)
        {
            var result = await repo.AllReadonly<DoctorSchedule>()
            .Where(ds => ds.DoctorId == doctorScheduleViewModel.DoctorId && ds.ScheduleDateTime== doctorScheduleViewModel.startDate)
            .FirstOrDefaultAsync();


            if (result!=null)
            {
                result.Who = doctorScheduleViewModel.Who;
                result.IsBusy = true;
                result.When = DateTime.Now;
                repo.Update(result);

                var doctorCustomer = new DoctorCustomer();
                doctorCustomer.DoctorId=doctorScheduleViewModel.DoctorId;
                doctorCustomer.CustomerId = doctorScheduleViewModel.Who;
                doctorCustomer.DateTime = doctorScheduleViewModel.startDate;
                doctorCustomer.When = DateTime.Now;
                await repo.AddAsync(doctorCustomer);
                await repo.SaveChangesAsync();
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
                })
                .ToListAsync();
            return result;
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
    }
}
