using DentalClinic.BL.Models;
using DentalClinic.DB.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.BL.Contracts
{
    public interface IDoctorCustomerService
    {
        //Task<IEnumerable<DoctorScheduleViewModel>> GetAll();
        Task CreateDoctorSchedule(DoctorCustomerViewModel doctorCustomerViewModel);
        Task<IEnumerable<Doctor>> GetDoctorsAsync();
        
    }
}
