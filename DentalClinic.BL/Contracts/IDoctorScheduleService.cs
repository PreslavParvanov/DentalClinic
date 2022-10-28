using DentalClinic.BL.Models;
using DentalClinic.DB.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.BL.Contracts
{
    public interface IDoctorScheduleService
    {
        Task CreateSchedule(DoctorScheduleViewModel doctorScheduleViewModel);
        Task<IEnumerable<Doctor>> GetDoctorsAsync();
    }
}
