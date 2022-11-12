using DentalClinic.BL.Models;
using DentalClinic.DB.Data.Models;

namespace DentalClinic.BL.Contracts
{
    public interface IDoctorService
    {
        Task<IEnumerable<GetDoctorViewModel>> GetDoctorById(Guid doctorId);
        Task<IEnumerable<GetDoctorViewModel>> GetAll();
        Task Create(DoctorViewModel doctorViewModel);

        Task<IEnumerable<DoctorScheduleViewModel>> GetDoctorSchedule(Guid doctor);

        Task Booked(DoctorScheduleViewModel doctorScheduleViewModel);

        Task<IEnumerable<Doctor>> GetDoctorsAsync();

        Task CreateSchedule(DoctorScheduleViewModel doctorScheduleViewModel);

    }
}
