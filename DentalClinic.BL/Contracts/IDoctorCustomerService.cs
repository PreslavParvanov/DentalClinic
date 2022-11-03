using DentalClinic.BL.Models;

namespace DentalClinic.BL.Contracts
{
    public interface IDoctorCustomerService
    {
        //Task<IEnumerable<DoctorScheduleViewModel>> GetAll();
        Task CreateDoctorSchedule(DoctorCustomerViewModel doctorCustomerViewModel);
        
        
    }
}
