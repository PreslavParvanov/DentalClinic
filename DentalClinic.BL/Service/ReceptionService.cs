using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.DB.Common;
using DentalClinic.DB.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DentalClinic.BL.Service
{
    public class ReceptionService : IReceptionService
    {

        private readonly IRepository repo;

        /// <summary>
        /// IoC 
        /// </summary>
        /// <param name="_config">Application configuration</param>
        public ReceptionService(IRepository _repo)
        {
            repo = _repo;
        }

        /// <summary>
        /// Мethod that lists the doctor's schedule to date 
        /// </summary>
        /// <param name="dateStart"></param>
        /// /// <param name="dateEnd"></param>
        /// <returns>ToList whit ReceptionCustomerViewModel</returns>
        public async Task<IEnumerable<ReceptionViewModel>> GetAllBookedByDate(DateTime dateStart, DateTime dateEnd)
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

        public async Task<ReceptionViewModel> GetBookedDetailsById(Guid DoctorId, string CustomerId, DateTime DateTimeSchedule)
        {
            var result = await repo.AllReadonly<DoctorCustomer>()
               .Where(ds => ds.DateTime == DateTimeSchedule
                        && ds.CustomerId==CustomerId
                        && ds.DateTime== DateTimeSchedule)
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
               .FirstOrDefaultAsync();
            return result;
        }
    }
}
