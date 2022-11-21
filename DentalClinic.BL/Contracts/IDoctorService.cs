using DentalClinic.BL.Models;
using DentalClinic.DB.Data.Models;

namespace DentalClinic.BL.Contracts
{
    public interface IDoctorService
    {
        Task Create(DoctorViewModel doctorViewModel);
        Task<IEnumerable<GetDoctorViewModel>> GetDoctorById(Guid doctorId);
        Task<IEnumerable<GetDoctorViewModel>> GetAll();
        Task<IEnumerable<DoctorScheduleViewModel>> GetDoctorSchedule(Guid doctor, DateTime dateStart, DateTime dateEnd);
        Task Booked(DoctorScheduleViewModel doctorScheduleViewModel);
        Task<IEnumerable<Doctor>> GetDoctorsAsync();
        Task CreateSchedule(DoctorScheduleViewModel doctorScheduleViewModel, TimeSpan startTime, TimeSpan endTime);
    }
}
