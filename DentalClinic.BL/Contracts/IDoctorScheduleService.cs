using DentalClinic.BL.Models;
using DentalClinic.DB.Data.Models;

namespace DentalClinic.BL.Contracts
{
    public interface IDoctorScheduleService
    {
        Task CreateSchedule(DoctorScheduleViewModel doctorScheduleViewModel);
        Task<IEnumerable<DoctorScheduleViewModel>> GetDoctorScheduleAsync();
        Task<IEnumerable<Doctor>> GetDoctorsAsync();
    }
}
